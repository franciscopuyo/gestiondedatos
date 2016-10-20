USE [consultorio]
GO
/****** Object:  StoredProcedure [dbo].[migracion]    Script Date: 19/10/2016 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[migracion] 
AS
BEGIN
	SET NOCOUNT ON;
	-------- INICIO CREAR ROLES ----------
	
	INSERT INTO Roles VALUES (1, 'Profesional');
	INSERT INTO Roles VALUES (2, 'Afiliado');
	INSERT INTO Roles VALUES (3, 'Admin');
	
	--------- FIN CREAR ROLES ---------
	
	--------- INICIO CREAR PLANES MEDICOS -------

	INSERT INTO Planes_Medicos
		SELECT DISTINCT
			 Plan_Med_Descripcion, 
			 Plan_Med_Codigo, 
			 Plan_Med_Precio_Bono_Consulta, 
			 Plan_Med_Precio_Bono_Farmacia, 
			 0 as Cuota
		FROM 
			GD2C2016.gd_esquema.Maestra;
	
	--------- FIN CREAR PLANES MEDICOS -------
	
	--------- INICIO CREAR TIPOS DE ESPECIALIDADES -------
	
	INSERT INTO Tipos_Especialidad
		SELECT DISTINCT 
			Tipo_Especialidad_Codigo, 
			Tipo_Especialidad_Descripcion
		FROM 
			GD2C2016.gd_esquema.Maestra
		WHERE Tipo_Especialidad_Codigo IS NOT NULL
	
	--------- FIN CREAR TIPOS DE ESPECIALIDADES -------
	
	--------- INICIO CREAR ESPECIALIDADES -------
	
	INSERT INTO Especialidades
		SELECT DISTINCT 
			Especialidad_Codigo,
			Especialidad_Descripcion, 
			0 AS cantidad_cancelaciones,
			Tipo_Especialidad_Codigo
		FROM 
			GD2C2016.gd_esquema.Maestra
		WHERE Especialidad_Codigo IS NOT NULL
	
	--------- FIN CREAR ESPECIALIDADES -------

	-------- INICIO CREAR AFILIADOS --------

	DECLARE @nro_afiliado INT = 0;
	DECLARE @nro_afiliado_completo INT;

	DECLARE @dni NUMERIC(18);
	DECLARE @apellido varchar(255);
	DECLARE @direccion varchar(255);
	DECLARE @fecha_nac DATETIME;
	DECLARE @mail varchar(255);
	DECLARE @nombre varchar(255);
	DECLARE @telefono NUMERIC(18);
	DECLARE @plan_medico NUMERIC(18);

	DECLARE cPaciente CURSOR FOR (
		SELECT DISTINCT Paciente_Dni, Paciente_Apellido, Paciente_Direccion, Paciente_Fecha_Nac, Paciente_Mail, Paciente_Nombre,
		Paciente_Telefono, Plan_Med_Codigo 
		from GD2C2016.gd_esquema.Maestra
	);
	OPEN cPaciente;
	FETCH NEXT FROM cPaciente INTO @dni, @apellido, @direccion, @fecha_nac, @mail, @nombre, @telefono, @plan_medico;
	WHILE @@FETCH_STATUS = 0
		BEGIN	
			
			set @nro_afiliado = @nro_afiliado + 1;
			set @nro_afiliado_completo = CONVERT(INT, STR(@nro_afiliado) + '01');
			
			INSERT INTO Usuarios (dni, usuario, activo, cantidad_intentos_login, contrasena)
			VALUES (@dni, REPLACE(@apellido + STR(@dni), ' ', ''), 1, 0, @dni);
			INSERT INTO Usuario_Roles (usuario_dni, rol_codigo) VALUES (@dni, 2);
			INSERT INTO Personas_Detalle (dni, apellido, direccion, telefono, mail, nacimiento, nombre)
			VALUES (@dni, @apellido, @direccion, @telefono, @mail, @fecha_nac, @nombre);
			INSERT INTO Afiliados (usuario_dni, nro_afiliado, plan_medico_codigo)
			VALUES (@dni, @nro_afiliado_completo, @plan_medico);
			FETCH NEXT FROM cPaciente INTO @dni, @apellido, @direccion, @fecha_nac, @mail, @nombre, @telefono, @plan_medico;
		END
	CLOSE cPaciente;
	DEALLOCATE cPaciente;
	
	
	------ FIN CREAR AFILIADOS ----------------------

	-------- INICIO CREAR MEDICOS --------

	DECLARE cMedico CURSOR FOR (
		SELECT DISTINCT Medico_Dni, 
						Medico_Apellido, 
						Medico_Direccion, 
						Medico_Fecha_Nac, 
						Medico_Mail, 
						Medico_Nombre,
						Medico_Telefono 
		FROM 
			GD2C2016.gd_esquema.Maestra
	);
	OPEN cMedico;
	FETCH NEXT FROM cMedico 
				INTO 
						@dni, 
						@apellido, 
						@direccion, 
						@fecha_nac, 
						@mail, 
						@nombre, 
						@telefono 
						
	WHILE @@FETCH_STATUS = 0
		BEGIN	
			
			INSERT INTO Usuarios (dni, usuario, activo, cantidad_intentos_login, contrasena)
				VALUES (@dni, REPLACE(@apellido + STR(@dni), ' ', ''), 1, 0, @dni);
			
			INSERT INTO Usuario_Roles (usuario_dni, rol_codigo) 
				VALUES (@dni, 1);
			
			INSERT INTO Personas_Detalle (dni, apellido, direccion, telefono, mail, nacimiento, nombre)
				VALUES (@dni, @apellido, @direccion, @telefono, @mail, @fecha_nac, @nombre);
			
			INSERT INTO Profesionales (usuario_dni)
				VALUES (@dni);
			 
			-- Un medico puede tener mas de una especialidad
			INSERT INTO Medico_Especialidad(especialidad_codigo, profesional_dni)
				SELECT Especialidad_Codigo , Medico_Dni
				FROM GD2C2016.gd_esquema.Maestra
				WHERE Medico_Dni = @dni

			FETCH NEXT FROM cMedico INTO @dni, @apellido, @direccion, @fecha_nac, @mail, @nombre, @telefono;
		END
	CLOSE cMedico;
	DEALLOCATE cMedico;
	
	
	------ FIN CREAR MEDICOS ----------------------


	-------- INICIO CREAR COMPRAS --------

	INSERT INTO Compras(afiliado_usuario_dni, fecha, monto, cantidad)
		SELECT
			Paciente_Dni as dni,
			Compra_Bono_Fecha as fecha_compra,
			0 as monto,
			COUNT(*) as cantidad
		FROM
			GD2C2016.gd_esquema.Maestra
		WHERE
			Compra_Bono_Fecha IS NOT NULL
		GROUP BY
			Paciente_Dni, Compra_Bono_Fecha, Plan_Med_Codigo
		
	------ FIN CREAR COMPRAS ----------------------

	-------- INICIO CREAR BONOS --------

	INSERT INTO Bonos(afiliado, compra_id, nro_bono, plan_codigo)
		SELECT
			Paciente_Dni,
			(SELECT compra_id From Compras WHERE Paciente_Dni = m.Paciente_Dni AND Compra_Bono_Fecha = m.Compra_Bono_Fecha),
			Bono_Consulta_Numero,
			Plan_Med_Codigo
		FROM
			GD2C2016.gd_esquema.Maestra as m
		WHERE
			Compra_Bono_Fecha IS NOT NULL
		GROUP BY
			Paciente_Dni, Bono_Consulta_Numero, Plan_Med_Codigo
		
	------ FIN CREAR BONOS ----------------------


END