USE [consultorio]
GO
/****** Object:  StoredProcedure [dbo].[migracion]    Script Date: 04/11/2016 17:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[migracion] 
AS
BEGIN
	SET NOCOUNT ON;

	-------- INICIO CREAR ROLES ----------
	
	INSERT INTO Roles(descripcion) VALUES ('Profesional');
	INSERT INTO Roles(descripcion) VALUES ('Afiliado');
	INSERT INTO Roles(descripcion) VALUES ('Admin');
	
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Gestionar roles');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Gestionar afiliados');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Comprar bonos');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Gestionar agendas');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Pedir turno');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Registrar llegada para atencion');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Registrar resultado de atencion');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Cancelar atencion');
	INSERT INTO Funcionalidades(funcionalidad) VALUES('Listados estadisticos');

	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Admin')

	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Afiliado')
			AND Funcionalidades.codigo = (SELECT Funcionalidades.codigo FROM Funcionalidades WHERE Funcionalidades.funcionalidad = 'Comprar bonos')

	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Afiliado')
			AND Funcionalidades.codigo = (SELECT Funcionalidades.codigo FROM Funcionalidades WHERE Funcionalidades.funcionalidad = 'Pedir turno')
			
	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Afiliado')
			AND Funcionalidades.codigo = (SELECT Funcionalidades.codigo FROM Funcionalidades WHERE Funcionalidades.funcionalidad = 'Cancelar atencion')

			
	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Profesional')
			AND Funcionalidades.codigo = (SELECT Funcionalidades.codigo FROM Funcionalidades WHERE Funcionalidades.funcionalidad = 'Gestionar agendas')
			
	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Profesional')
			AND Funcionalidades.codigo = (SELECT Funcionalidades.codigo FROM Funcionalidades WHERE Funcionalidades.funcionalidad = 'Registrar resultado de atencion')
			
	INSERT INTO Rol_Funcionalidades(rol_codigo, funcionalidad_codigo)
		SELECT Roles.codigo, Funcionalidades.codigo FROM Roles, Funcionalidades
			WHERE Roles.codigo = (SELECT codigo FROM Roles WHERE descripcion = 'Profesional')
			AND Funcionalidades.codigo = (SELECT Funcionalidades.codigo FROM Funcionalidades WHERE Funcionalidades.funcionalidad = 'Cancelar atencion')

	INSERT INTO Usuarios(contrasena, usuario, usuario_dni) VALUES(HASHBYTES('SHA2_256', 'w23e'),'admin' , 0);

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
							CONVERT(VARCHAR(255), Paciente_dni) AS usuario,
							1 as activo,
							0 as cantidad_intentos_login,
							HASHBYTES('SHA2_256', Paciente_Apellido + Paciente_Nombre) AS contrasena			 
			FROM GD2C2016.gd_esquema.Maestra
			WHERE Paciente_Dni IS NOT NULL
			ORDER BY usuario
			
	INSERT INTO Usuario_Roles (usuario_dni, rol_codigo) 
		SELECT
			usuario_dni,
			(SELECT codigo FROM Roles WHERE descripcion = 'Admin') as rol_codigo
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
			
	INSERT INTO Afiliados (activo, afiliado_dni, tipo_documento, nro_afiliado, plan_medico_codigo, cantidad_consultas_realizadas)
		SELECT DISTINCT 
						1 as activo,
						Paciente_Dni as dni,
						'DNI' as tipo_documento,
						Paciente_Dni * 100 + 1 as nro_afiliado,
						Plan_Med_Codigo as plan_medico,
						(	
							SELECT
								sq.cant
							FROM
								(SELECT 
									Paciente_Dni AS dni, 
									COUNT(DISTINCT Bono_Consulta_Numero) AS cant
								FROM
									GD2C2016.gd_esquema.Maestra m2
								WHERE 
									m2.Paciente_Dni = m1.Paciente_Dni 
								GROUP BY 
									Paciente_Dni) AS sq
						) AS cantidad_consultas_realizadas
		FROM GD2C2016.gd_esquema.Maestra m1
		WHERE Paciente_Dni IS NOT NULL
	
	
	------ FIN CREAR AFILIADOS ----------------------

	
	-------- INICIO CREAR MEDICOS --------

	INSERT INTO Usuarios(usuario_dni, usuario, activo, cantidad_intentos_login, contrasena)
		SELECT DISTINCT Medico_Dni as dni, 
						CONVERT(VARCHAR(255), Medico_Dni) as usuario,
						1 as activo,
						0 as cantidad_intentos_login,
						HASHBYTES('SHA2_256', Medico_Apellido + Medico_Nombre) AS contrasena 
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

	
	-------- INICIO CREAR MEDICO ESPECIALIDAD --------
	
	INSERT INTO Medico_Especialidad(profesional_dni, especialidad_codigo)
			SELECT DISTINCT 
				Medico_Dni, 
				Especialidad_Codigo 
			FROM 
				GD2C2016.gd_esquema.Maestra
			WHERE 
				Medico_Dni IS NOT NULL 

	------ FIN CREAR MEDICO ESPECIALIDAD ----------------------


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

	INSERT INTO Bonos(compra_id, plan_codigo, nro_bono, afiliado_dni, nro_consulta_medica)
	SELECT
		(
			SELECT TOP 1 
				compra_id 
			FROM 
				Compras 
			WHERE 
				afiliado_usuario_dni = sq.dni
				AND
				fecha = sq.fecha
		) AS compra_id,
		sq.plan_codigo AS plan_codigo,
		sq.nro_bono AS nro_bono,
		sq.dni AS afiliado_dni,
		(
			SELECT
				sq_bonos_ordenados.indice
				FROM
					(SELECT 
						Paciente_Dni,
						Bono_Consulta_Numero as nro,
						ROW_NUMBER() OVER(ORDER BY Paciente_Dni, Bono_Consulta_Fecha_Impresion) AS indice
					FROM
						GD2C2016.gd_esquema.Maestra 
					WHERE
						Bono_Consulta_Numero IS NOT NULL
						AND
						Paciente_Dni = sq.dni
					GROUP BY
						Paciente_Dni, Bono_Consulta_Numero, Bono_Consulta_Fecha_Impresion
					) AS sq_bonos_ordenados
				WHERE
					sq_bonos_ordenados.nro = sq.nro_bono
		)AS nro_consulta_medica
	FROM
		(
			SELECT TOP 500000
				Paciente_Dni AS dni,
				Bono_Consulta_Numero AS nro_bono,
				Compra_Bono_Fecha AS fecha,
				Plan_Med_Codigo AS plan_codigo
			FROM
				GD2C2016.gd_esquema.Maestra as m
			WHERE
				Compra_Bono_Fecha IS NOT NULL
				AND
				Bono_Consulta_Numero IS NOT NULL
			ORDER BY
				Paciente_Dni, Compra_Bono_Fecha, Bono_Consulta_Numero
		) AS sq
		
		
	------ FIN CREAR BONOS ----------------------

	-------- INICIO CREAR TURNOS --------

	INSERT INTO Turnos(numero, afiliado_dni, especialidad_codigo, profesional_dni, fecha)
		SELECT DISTINCT 
			Turno_Numero, Paciente_Dni, Especialidad_Codigo, Medico_Dni, Turno_Fecha 
		FROM 
			GD2C2016.gd_esquema.Maestra
		WHERE
			Turno_Numero IS NOT NULL
	
		
	------ FIN CREAR TURNOS ----------------------

	-------- INICIO CREAR ATENCION_MEDICA --------

	INSERT INTO Atencion_Medica(turno_numero, fecha_efectivizacion, nro_bono, realizada, fecha_llegada)
		SELECT DISTINCT
				Turno_Numero, 
				Bono_Consulta_Fecha_Impresion,
				Bono_Consulta_Numero,
				1 as realizada,
				Bono_Consulta_Fecha_Impresion as fecha_llegada
		 FROM 
			GD2C2016.gd_esquema.Maestra
		 WHERE 
			Turno_Numero IS NOT NULL
			AND
			Bono_Consulta_Fecha_Impresion IS NOT NULL
		
	------ FIN CREAR ATENCION_MEDICA ----------------------

	------ INICIO CREAR SINTOMAS Y DIAGNOSTICOS ----------------------

	INSERT INTO Diagnosticos(atencion, diagnostico)
	SELECT
		DISTINCT Turno_Numero, Consulta_Enfermedades
	FROM 
		GD2C2016.gd_esquema.Maestra
	WHERE
		Turno_Numero IS NOT NULL
		AND 
		Consulta_Enfermedades IS NOT NULL

	INSERT INTO Sintomas(atencion, sintoma)
		SELECT
			DISTINCT Turno_Numero, Consulta_Sintomas
		FROM 
			GD2C2016.gd_esquema.Maestra
		WHERE
			Turno_Numero IS NOT NULL
			AND 
			Consulta_Sintomas IS NOT NULL
	
	------ FIN CREAR SINTOMAS Y DIAGNOSTICOS ----------------------

END