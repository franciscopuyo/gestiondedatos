USE GD2C2016;  
GO  
	CREATE SCHEMA group_by 
	-- -----------------------------------------------------
-- Creacion tabla Usuarios
-- -----------------------------------------------------
CREATE TABLE [group_by].Usuarios (
  contrasena BINARY(32) NOT NULL,
  usuario VARCHAR(255) NOT NULL UNIQUE,
  activo BIT NOT NULL DEFAULT 1,
  cantidad_intentos_login INT NOT NULL DEFAULT 0,
  usuario_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (usuario_dni)
)

-- -----------------------------------------------------
-- Creacion tabla roles
-- -----------------------------------------------------
CREATE TABLE [group_by].Roles (
  codigo NUMERIC(18) NOT NULL IDENTITY(1,1),
  descripcion VARCHAR(255) NULL,
  activo BIT NOT NULL DEFAULT 1,
  PRIMARY KEY (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Funcionalidades
-- -----------------------------------------------------
CREATE TABLE [group_by].Funcionalidades (
  codigo NUMERIC(18) NOT NULL IDENTITY(1,1),
  funcionalidad VARCHAR(255) NOT NULL,
  PRIMARY KEY (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Rol_Funcionalidades
-- -----------------------------------------------------
CREATE TABLE [group_by].Rol_Funcionalidades (
  rol_codigo NUMERIC(18) NOT NULL,
  funcionalidad_codigo NUMERIC(18) NOT NULL,
  PRIMARY KEY (rol_codigo, funcionalidad_codigo),

  CONSTRAINT fk_rol FOREIGN KEY (rol_codigo)
	REFERENCES Roles(codigo),

  CONSTRAINT fk_funcionalidad FOREIGN KEY (funcionalidad_codigo)
	REFERENCES Funcionalidades(codigo)

)


-- -----------------------------------------------------
-- Creacion tabla Planes_Medicos
-- -----------------------------------------------------
CREATE TABLE [group_by].Planes_Medicos (
  descripcion VARCHAR(255) NULL,
  codigo NUMERIC(18) NOT NULL,
  precio_bono_consulta DECIMAL(12,2) NOT NULL,
  precio_bono_farmacia DECIMAL(12,2) NOT NULL,
  cuota DECIMAL(12,2) NOT NULL,
  PRIMARY KEY (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Personas_Detalle
-- -----------------------------------------------------
CREATE TABLE [group_by].Personas_Detalle (
  dni NUMERIC(18) NOT NULL,
  direccion VARCHAR(255) NULL,
  telefono NUMERIC(18) NULL,
  mail VARCHAR(255) NULL,
  nacimiento DATETIME NULL,
  sexo INT NULL,
  nombre VARCHAR(255) NULL,
  apellido VARCHAR(255) NULL,
  estado_civil INT NULL,
  PRIMARY KEY (dni)
 )

  -- -----------------------------------------------------
-- Creacion tabla Afiliados
-- -----------------------------------------------------
CREATE TABLE [group_by].Afiliados (
  afiliado_dni NUMERIC(18) NULL UNIQUE,
  tipo_documento VARCHAR(5),
  nro_afiliado NUMERIC(20) NOT NULL,
  afiliado_responsable NUMERIC(18) NULL,
  afiliado_conyugue NUMERIC(18) NULL,
  plan_medico_codigo NUMERIC(18) NOT NULL,
  cantidad_consultas_realizadas NUMERIC(18),
  activo BIT DEFAULT 1,
  PRIMARY KEY (nro_afiliado),
 
  CONSTRAINT fk_Afiliados_Afiliados_Responsable
    FOREIGN KEY (afiliado_responsable)
    REFERENCES Afiliados (afiliado_dni),

  CONSTRAINT fk_Afiliados_Afiliados_Conyugue
    FOREIGN KEY (afiliado_conyugue)
    REFERENCES Afiliados (afiliado_dni),

  CONSTRAINT fk_Afiliados_Planes_Medicos
    FOREIGN KEY (plan_medico_codigo)
    REFERENCES Planes_Medicos (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Compras
-- -----------------------------------------------------
CREATE TABLE [group_by].Compras (
  fecha DATETIME NULL,
  cantidad INT NULL,
  monto DECIMAL(12,2) NULL,
  compra_id NUMERIC(18) NOT NULL IDENTITY(1,1),
  afiliado_usuario_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (compra_id),
 
  CONSTRAINT fk_Compras_Afiliados1
    FOREIGN KEY (afiliado_usuario_dni)
    REFERENCES Afiliados (afiliado_dni)
)

-- -----------------------------------------------------
-- Creacion tabla Bonos
-- -----------------------------------------------------
CREATE TABLE [group_by].Bonos (
  compra_id NUMERIC(18) NOT NULL,
  plan_codigo NUMERIC(18) NOT NULL,
  nro_bono NUMERIC(18) NOT NULL,
  afiliado_dni NUMERIC(18) NOT NULL,
  nro_consulta_medica NUMERIC(18),

  PRIMARY KEY (nro_bono),

  CONSTRAINT fk_Bonos_Compra_Bonos
    FOREIGN KEY (compra_id)
    REFERENCES Compras (compra_id),

  CONSTRAINT fk_Bonos_Planes_Medicos
    FOREIGN KEY (plan_codigo)
    REFERENCES Planes_Medicos (codigo),

  CONSTRAINT fk_Bonos_Afiliados
    FOREIGN KEY (afiliado_dni)
    REFERENCES Afiliados (afiliado_dni)

)

-- -----------------------------------------------------
-- Creacion tabla Tipos_Especialidad
-- -----------------------------------------------------
CREATE TABLE [group_by].Tipos_Especialidad (
  codigo NUMERIC(18) NOT NULL,
  descripcion VARCHAR(255) NULL,
  PRIMARY KEY (codigo)
 )

-- -----------------------------------------------------
-- Creacion tabla Especialidades
-- -----------------------------------------------------
CREATE TABLE [group_by].Especialidades (
  codigo NUMERIC(18) NOT NULL,
  descripcion VARCHAR(255) NOT NULL,
  cantidad_cancelaciones DECIMAL(10,0) NULL,
  tipo_especialidad_codigo NUMERIC(18) NOT NULL,
  PRIMARY KEY (codigo),
 
  CONSTRAINT fk_Especialidades_Tipos_Especialidad1
    FOREIGN KEY (tipo_especialidad_codigo)
    REFERENCES Tipos_Especialidad (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Profesionales
-- -----------------------------------------------------
CREATE TABLE [group_by].Profesionales (
  matricula VARCHAR(45) NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (profesional_dni),
 
  CONSTRAINT fk_Profesionales_Usuarios1
    FOREIGN KEY (profesional_dni)
    REFERENCES Usuarios (usuario_dni),

  CONSTRAINT fk_Profesionales_Personas_Detalle
    FOREIGN KEY (profesional_dni)
    REFERENCES Personas_Detalle (dni)
)

-- -----------------------------------------------------
-- Creacion tabla Medico_Especialidad
-- -----------------------------------------------------
CREATE TABLE [group_by].Medico_Especialidad (
  especialidad_codigo NUMERIC(18) NOT NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (profesional_dni, especialidad_codigo),
 
  CONSTRAINT fk_especialidades
    FOREIGN KEY (especialidad_codigo)
    REFERENCES Especialidades (codigo),
 
  CONSTRAINT fk_Medico_Especialidad_Profesionales1
    FOREIGN KEY (profesional_dni)
    REFERENCES Profesionales (profesional_dni)
)

-- -----------------------------------------------------
-- Creacion tabla Agendas
-- -----------------------------------------------------
CREATE TABLE [group_by].Agendas (
  agenda_id NUMERIC(18) IDENTITY (1,1),
  desde DATE NULL,
  hasta DATE NULL,
  especialidad_codigo NUMERIC(18) NOT NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (agenda_id),

  CONSTRAINT fk_Agenda_Medicos_Especialidades
    FOREIGN KEY (profesional_dni, especialidad_codigo)
    REFERENCES Medico_Especialidad (profesional_dni, especialidad_codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Disponibilidad
-- -----------------------------------------------------
CREATE TABLE [group_by].Disponibilidad (
  dia INT NOT NULL,
  desde TIME NOT NULL,
  hasta TIME NOT NULL,
  agenda NUMERIC(18) NOT NULL,

  PRIMARY KEY (dia, agenda),

  CONSTRAINT fk_Dispinibilidad_Agenda
    FOREIGN KEY (agenda)
    REFERENCES Agendas (agenda_id)
)


-- -----------------------------------------------------
-- Creacion tabla Turnos
-- -----------------------------------------------------
CREATE TABLE [group_by].Turnos (
  numero NUMERIC(18) NOT NULL,
  afiliado_dni NUMERIC(18) NOT NULL,
  especialidad_codigo NUMERIC(18) NOT NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  fecha DATETIME NOT NULL,
  PRIMARY KEY (numero),
  
  CONSTRAINT fk_Turnos_Afiliados
    FOREIGN KEY (afiliado_dni)
    REFERENCES Afiliados (afiliado_dni),
 
  CONSTRAINT fk_Turnos_Medico_Especialidad
    FOREIGN KEY (profesional_dni, especialidad_codigo)
    REFERENCES Medico_Especialidad (profesional_dni, especialidad_codigo)
   
)

-- -----------------------------------------------------
-- Creacion tabla Usuario_Roles
-- -----------------------------------------------------
CREATE TABLE [group_by].Usuario_Roles (
  usuario_dni NUMERIC(18) NOT NULL,
  rol_codigo NUMERIC(18) NOT NULL,
  PRIMARY KEY (usuario_dni, rol_codigo),
 
  CONSTRAINT fk_Usuario_has_Rol_Usuario1
    FOREIGN KEY (usuario_dni)
    REFERENCES Usuarios (usuario_dni),
 
  CONSTRAINT fk_Usuario_has_Rol_Rol1
    FOREIGN KEY (rol_codigo)
	REFERENCES Roles(codigo)
)


-- -----------------------------------------------------
-- Table Cambios_De_Plan
-- -----------------------------------------------------
CREATE TABLE [group_by].Cambios_De_Plan (
  cambio_id NUMERIC(18) NOT NULL IDENTITY(1,1),
  plan_viejo NUMERIC(18) NOT NULL,
  plan_nuevo NUMERIC(18) NOT NULL,
  fecha DATETIME NOT NULL,
  motivo VARCHAR(45) NULL,
  afiliados_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (cambio_id),
  CONSTRAINT fk_Cambios_Plan_Planes_Medicos1
    FOREIGN KEY (plan_viejo)
    REFERENCES Planes_Medicos (codigo),
  CONSTRAINT fk_Cambios_Plan_Planes_Medicos2
    FOREIGN KEY (plan_nuevo)
    REFERENCES Planes_Medicos (codigo),
  CONSTRAINT fk_Cambios_De_Plan_Afiliados1
    FOREIGN KEY (afiliados_dni)
    REFERENCES Afiliados (afiliado_dni)
)


-- -----------------------------------------------------
-- Table Atencion_Medica
-- -----------------------------------------------------
CREATE TABLE [group_by].Atencion_Medica (
  turno_numero NUMERIC(18) NOT NULL,
  fecha_llegada DATETIME NULL,
  fecha_efectivizacion DATETIME NULL,
  nro_bono NUMERIC(18) NULL,
  realizada BIT DEFAULT 0,
  PRIMARY KEY (turno_numero),
  CONSTRAINT fk_Atencion_Medica_Turnos1
    FOREIGN KEY (turno_numero)
    REFERENCES Turnos (numero),
  CONSTRAINT fk_Atencion_Medica_Bonos1
    FOREIGN KEY (nro_bono)
    REFERENCES Bonos (nro_bono)
)

-- -----------------------------------------------------
-- Table Cancelaciones
-- -----------------------------------------------------
CREATE TABLE [group_by].Cancelaciones (
  turno_nro NUMERIC(18) NOT NULL,
  tipo INT NULL,
  motivo VARCHAR(45) NULL,
  PRIMARY KEY (turno_nro),
  CONSTRAINT fk_Cancelaciones_Turnos1
    FOREIGN KEY (turno_nro)
    REFERENCES Turnos (numero)
)

-- -----------------------------------------------------
-- Table Diagnosticos
-- -----------------------------------------------------
CREATE TABLE [group_by].Diagnosticos (
  diagnostico_id NUMERIC(18) NOT NULL IDENTITY(1,1),
  atencion NUMERIC(18) NOT NULL,
  diagnostico VARCHAR(45) NULL,
  PRIMARY KEY (diagnostico_id),
  CONSTRAINT fk_Resultados_Atencion_Medica1
    FOREIGN KEY (atencion)
    REFERENCES Atencion_Medica (turno_numero)
)

-- -----------------------------------------------------
-- Table Sintomas
-- -----------------------------------------------------
CREATE TABLE [group_by].Sintomas (
  sintoma_id NUMERIC(18) NOT NULL IDENTITY(1,1),
  atencion NUMERIC(18) NOT NULL,
  sintoma VARCHAR(45) NULL,
  PRIMARY KEY (sintoma_id),
  CONSTRAINT fk_Sintomas_Atencion_Medica1
    FOREIGN KEY (atencion)
    REFERENCES Atencion_Medica (turno_numero)
		)

CREATE TABLE [group_by].Periodos_Cancelados (
  id_cancelacion NUMERIC(18) NOT NULL IDENTITY(1,1),
  desde DATETIME NOT NULL,
  hasta DATETIME NOT NULL,
  especialidad_codigo NUMERIC(18) NOT NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (id_cancelacion),

  CONSTRAINT fk_Peri_Can_Medicos_Especialidades
    FOREIGN KEY (profesional_dni, especialidad_codigo)
    REFERENCES Medico_Especialidad (profesional_dni, especialidad_codigo)
)
GO
------------------------------------------------------
-- MIGRACION
------------------------------------------------------
CREATE PROCEDURE [group_by].[migracion] 
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

	------------- INICIO CREAR AGENDAS ------------
	INSERT INTO Agendas(profesional_dni,especialidad_codigo, desde, hasta)
		SELECT 
			Medico_Dni, Especialidad_Codigo, CONVERT(DATE, MIN(Turno_Fecha)), CONVERT(DATE, MAX(Turno_Fecha)) 
		FROM
			GD2C2016.gd_esquema.Maestra
		WHERE Medico_Dni IS NOT NULL
		GROUP BY
			Medico_Dni, Especialidad_Codigo
	------------ FIN CREAR AGENDAS -------------

	
	------------- INICIO CREAR DISPONIBILIDADES ------------
	INSERT INTO Disponibilidad(dia, desde, hasta, agenda)
		SELECT DISTINCT
			DATEPART(WEEKDAY, Turno_Fecha) as Dia, 
			MIN(CONVERT(TIME, Turno_Fecha)), MAX(CONVERT(TIME, Turno_Fecha)), 
			(SELECT top 1 agenda_id FROM Agendas WHERE profesional_dni = Medico_DNI and especialidad_codigo = Especialidad_Codigo) as agenda
		FROM
			GD2C2016.gd_esquema.Maestra 
		WHERE Medico_Dni IS NOT NULL
		GROUP BY
			Medico_Dni, Especialidad_Codigo, DATEPART(WEEKDAY, Turno_Fecha)
	------------- FIN CREAR DISPONIBILIDADES ------------


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


	CREATE INDEX i1 ON group_by.Agendas (desde);
	CREATE INDEX i2 ON group_by.Agendas (hasta);
	CREATE INDEX i3 ON group_by.Turnos (fecha);


END
GO

use GD2C2016;
GO

CREATE FUNCTION [group_by].StringPerteneceAGrupoFamiliar(@dni NUMERIC(18))
returns char(60)
as
begin
	IF((select top 1 afiliado_dni from[group_by].Afiliados where afiliado_responsable = @dni) is not null)
	begin
		return 'Pertenece a grupo familiar'
	end

	IF((select top 1 afiliado_dni from [group_by].Afiliados where afiliado_conyugue = @dni) is not null)
	begin
		return 'Pertenece a grupo familiar'
	end

	IF((select afiliado_conyugue from [group_by].Afiliados where afiliado_dni = @dni) is not null)
	begin
		return 'Pertenece a grupo familiar'
	end

	IF((select afiliado_responsable from [group_by].Afiliados where afiliado_dni = @dni) is not null)
	begin
		return 'Pertenece a grupo familiar'
	end
	
	return 'No pertenece a grupo familiar' 
end
go



GO


EXEC [group_by].migracion 
GO