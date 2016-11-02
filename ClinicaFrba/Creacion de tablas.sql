use consultorio;

-- -----------------------------------------------------
-- Creacion tabla Usuarios
-- -----------------------------------------------------
CREATE TABLE Usuarios (
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
CREATE TABLE Roles (
  codigo NUMERIC(18) NOT NULL IDENTITY(1,1),
  descripcion VARCHAR(255) NULL,
  activo BIT NOT NULL DEFAULT 1,
  PRIMARY KEY (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Funcionalidades
-- -----------------------------------------------------
CREATE TABLE Funcionalidades (
  codigo NUMERIC(18) NOT NULL IDENTITY(1,1),
  funcionalidad VARCHAR(255) NOT NULL,
  PRIMARY KEY (codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Rol_Funcionalidades
-- -----------------------------------------------------
CREATE TABLE Rol_Funcionalidades (
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
CREATE TABLE Planes_Medicos (
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
CREATE TABLE Personas_Detalle (
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
CREATE TABLE Afiliados (
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
CREATE TABLE Compras (
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
CREATE TABLE Bonos (
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
CREATE TABLE Tipos_Especialidad (
  codigo NUMERIC(18) NOT NULL,
  descripcion VARCHAR(255) NULL,
  PRIMARY KEY (codigo)
 )

-- -----------------------------------------------------
-- Creacion tabla Especialidades
-- -----------------------------------------------------
CREATE TABLE Especialidades (
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
CREATE TABLE Profesionales (
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
CREATE TABLE Medico_Especialidad (
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
CREATE TABLE Agendas (
  desde DATETIME NULL,
  hasta DATETIME NULL,
  especialidad_codigo NUMERIC(18) NOT NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  PRIMARY KEY (especialidad_codigo, profesional_dni),

  CONSTRAINT fk_Agenda_Medicos_Especialidades
    FOREIGN KEY (profesional_dni, especialidad_codigo)
    REFERENCES Medico_Especialidad (profesional_dni, especialidad_codigo)
)

-- -----------------------------------------------------
-- Creacion tabla Disponibilidad
-- -----------------------------------------------------
CREATE TABLE Disponibilidad (
  fecha DATETIME NOT NULL,
  especialidad_codigo NUMERIC(18) NOT NULL,
  profesional_dni NUMERIC(18) NOT NULL,

  PRIMARY KEY (fecha, especialidad_codigo, profesional_dni),

  CONSTRAINT fk_Dispinibilidad_Agenda
    FOREIGN KEY (especialidad_codigo, profesional_dni)
    REFERENCES Agendas (especialidad_codigo, profesional_dni)
)


-- -----------------------------------------------------
-- Creacion tabla Turnos
-- -----------------------------------------------------
CREATE TABLE Turnos (
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
    REFERENCES Medico_Especialidad (profesional_dni, especialidad_codigo),

  CONSTRAINT fk_Turnos_Disponibilidad
	FOREIGN KEY (fecha, especialidad_codigo, profesional_dni)
	REFERENCES Disponibilidad (fecha, especialidad_codigo, profesional_dni)
   
)

-- -----------------------------------------------------
-- Creacion tabla Usuario_Roles
-- -----------------------------------------------------
CREATE TABLE Usuario_Roles (
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
CREATE TABLE Cambios_De_Plan (
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
CREATE TABLE Atencion_Medica (
  turno_numero NUMERIC(18) NOT NULL,
  fecha_efectivizacion DATETIME NULL,
  nro_bono NUMERIC(18) NULL,
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
CREATE TABLE Cancelaciones (
  turno_nro NUMERIC(18) NOT NULL,
  tipo INT NULL,
  motivo VARCHAR(45) NULL,
  PRIMARY KEY (turno_nro),
  CONSTRAINT fk_Cancelaciones_Turnos1
    FOREIGN KEY (turno_nro)
    REFERENCES Turnos (numero)
)


-- -----------------------------------------------------
-- Table Horas_Trabajadas
-- -----------------------------------------------------
CREATE TABLE Horas_Trabajadas (
  plan_codigo NUMERIC(18) NOT NULL,
  cantidad VARCHAR(45) NULL,
  profesional_dni NUMERIC(18) NOT NULL,
  especialidad_codigo NUMERIC(18) NOT NULL,
  PRIMARY KEY (profesional_dni, especialidad_codigo, plan_codigo),

  CONSTRAINT fk_Horas_Trabajadas_Medico_Especialidad
    FOREIGN KEY (profesional_dni, especialidad_codigo)
    REFERENCES Medico_Especialidad (profesional_dni, especialidad_codigo)
)


-- -----------------------------------------------------
-- Table Diagnosticos
-- -----------------------------------------------------
CREATE TABLE Diagnosticos (
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
CREATE TABLE Sintomas (
  sintoma_id NUMERIC(18) NOT NULL IDENTITY(1,1),
  atencion NUMERIC(18) NOT NULL,
  sintoma VARCHAR(45) NULL,
  PRIMARY KEY (sintoma_id),
  CONSTRAINT fk_Sintomas_Atencion_Medica1
    FOREIGN KEY (atencion)
    REFERENCES Atencion_Medica (turno_numero)
)
