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
			GD2C2016.gd_esquema.Maestra
		WHERE Plan_Med_Descripcion IS NOT NULL;
	
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
	INSERT INTO Usuarios(usuario_dni, usuario, activo, cantidad_intentos_login, contrasena)
			SELECT DISTINCT Paciente_Dni as usuario_dni,
							STR(Paciente_dni) AS usuario,
							1 as activo,
							0 as cantidad_intentos_login,
							Paciente_Dni as contrasena			 
			FROM GD2C2016.gd_esquema.Maestra
			WHERE Paciente_Dni IS NOT NULL
			ORDER BY usuario
			
	INSERT INTO Usuario_Roles (usuario_dni, rol_codigo) 
		SELECT
			usuario_dni,
			2 as rol_codigo
		FROM Usuarios
		WHERE usuario_dni IS NOT NULL
			
	INSERT INTO Personas_Detalle (dni, nombre, apellido, direccion, nacimiento, mail, telefono)
		SELECT DISTINCT Paciente_Dni as dni,
						Paciente_Nombre as nombre,
						Paciente_Apellido as apellido,
						Paciente_Direccion as direccion, 
						Paciente_Fecha_Nac as fecha_nac,
						Paciente_Mail as mail,
						Paciente_Telefono as telefono
		FROM GD2C2016.gd_esquema.Maestra
		WHERE Paciente_Dni IS NOT NULL
			
	INSERT INTO Afiliados (afiliado_dni, nro_afiliado, plan_medico_codigo)
		SELECT DISTINCT Paciente_Dni as dni,
						Paciente_Dni * 100 + 1 as nro_afiliado,
						Plan_Med_Codigo as plan_medico 
		from GD2C2016.gd_esquema.Maestra
		WHERE Paciente_Dni IS NOT NULL
	
	
	------ FIN CREAR AFILIADOS ----------------------

	
	-------- INICIO CREAR MEDICOS --------

	INSERT INTO Usuarios(usuario_dni, usuario, activo, cantidad_intentos_login, contrasena)
		SELECT DISTINCT Medico_Dni as dni, 
						Medico_Dni as usuario,
						1 as activo,
						0 as cantidad_intentos_login,
						Medico_Dni as contrasena 
	FROM 
		GD2C2016.gd_esquema.Maestra
		WHERE Medico_Dni IS NOT NULL
			
	INSERT INTO Usuario_Roles (usuario_dni, rol_codigo) 
		SELECT DISTINCT 
			Medico_Dni as dni,
			1 as rol
		FROM 
			GD2C2016.gd_esquema.Maestra
		WHERE Medico_Dni IS NOT NULL
			
	INSERT INTO Personas_Detalle (dni, apellido, direccion, telefono, mail, nacimiento, nombre)
		SELECT DISTINCT Medico_Dni as dni, 
						Medico_Apellido as apellido, 
						Medico_Direccion as direccion, 
						Medico_Telefono as telefono,
						Medico_Mail as mail,
						Medico_Fecha_Nac as nacimiento, 
						Medico_Nombre as nombre	
				FROM
					GD2C2016.gd_esquema.Maestra
				WHERE Medico_Dni IS NOT NULL
			
	INSERT INTO Profesionales (profesional_dni)
		SELECT DISTINCT Medico_Dni as dni
			 FROM
				GD2C2016.gd_esquema.Maestra
				WHERE Medico_Dni IS NOT NULL
	
	------ FIN CREAR MEDICOS ----------------------

	
	-------- INICIO CREAR AGENDAS --------
	
	DECLARE @medico_dni NUMERIC(18);
	DECLARE @especialidad NUMERIC(18);

	DECLARE @nro_agenda NUMERIC(18) = 0;

	DECLARE cMedico_Especialidad CURSOR FOR (select distinct Medico_Dni, Especialidad_Codigo from GD2C2016.gd_esquema.Maestra WHERE Medico_Dni IS NOT NULL)
	OPEN cMedico_Especialidad

	FETCH NEXT FROM cMedico_Especialidad into @medico_dni, @especialidad
		WHILE @@FETCH_STATUS = 0
			BEGIN
				
				INSERT INTO Agendas DEFAULT VALUES
				SET @nro_agenda = @nro_agenda + 1;

				INSERT INTO Medico_Especialidad(agenda_id, especialidad_codigo, profesional_dni)
				VALUES(@nro_agenda, @especialidad, @medico_dni) 

				FETCH NEXT FROM cMedico_Especialidad into @medico_dni, @especialidad
			
			END
	CLOSE cMedico_Especialidad
	DEALLOCATE cMedico_Especialidad
	
	------ FIN CREAR AGENDAS ----------------------


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
			Paciente_Dni, Compra_Bono_Fecha
		
	------ FIN CREAR COMPRAS ----------------------

	-------- INICIO CREAR BONOS --------

	INSERT INTO Bonos(afiliado_dni, compra_id, nro_bono, plan_codigo)
		SELECT
			DISTINCT
			Paciente_Dni as afiliado_dni,
				(SELECT TOP 1 
					compra_id 
					FROM 
						Compras 
					WHERE 
						afiliado_usuario_dni = m.Paciente_Dni 
						AND
						fecha = m.Compra_Bono_Fecha
				) as compra_id,
			Bono_Consulta_Numero as nro_bono,
			Plan_Med_Codigo as plan_codigo
		FROM
			GD2C2016.gd_esquema.Maestra as m
		WHERE
			Compra_Bono_Fecha IS NOT NULL
		
		
	------ FIN CREAR BONOS ----------------------

END