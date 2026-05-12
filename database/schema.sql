CREATE DATABASE IF NOT EXISTS sistema_horarios;
USE sistema_horarios;
 
 

CREATE TABLE roles (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(200)
);
 
 

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombreUsuario VARCHAR(50) NOT NULL,
    contrasena VARCHAR(255) NOT NULL,
    nombreCompleto VARCHAR(150) NOT NULL,
    correo VARCHAR(150),
    celular VARCHAR(20),
    estado VARCHAR(20) NOT NULL,
    rol_id INT,
    FOREIGN KEY (rol_id) REFERENCES roles(id)
);
 
 

CREATE TABLE semestres (
    id INT AUTO_INCREMENT PRIMARY KEY,
    numero INT NOT NULL,
    nombre VARCHAR(50)
);
 
 

CREATE TABLE materias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    creditos INT NOT NULL,
    intensidadSemanal INT NOT NULL,
    aplicaTapsi BOOLEAN DEFAULT FALSE,
    activa BOOLEAN DEFAULT TRUE,
    semestre_id INT,
    FOREIGN KEY (semestre_id) REFERENCES semestres(id)
);
 
 

CREATE TABLE prerrequisitos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    materia_id INT,
    prerrequisito_id INT,
    FOREIGN KEY (materia_id) REFERENCES materias(id),
    FOREIGN KEY (prerrequisito_id) REFERENCES materias(id)
);
 

CREATE TABLE docentes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    identificacion VARCHAR(30) NOT NULL,
    nombre VARCHAR(150) NOT NULL,
    correo VARCHAR(150),
    disponibilidadGeneral VARCHAR(20),
    activo BOOLEAN DEFAULT TRUE
);
 
 

CREATE TABLE docente_materias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    docente_id INT,
    materia_id INT,
    FOREIGN KEY (docente_id) REFERENCES docentes(id),
    FOREIGN KEY (materia_id) REFERENCES materias(id)
);
 
 

CREATE TABLE franjas_horarias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    dia VARCHAR(15) NOT NULL,
    horaInicio TIME NOT NULL,
    horaFin TIME NOT NULL
);
 
 

CREATE TABLE docente_disponibilidad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    docente_id INT,
    franja_id INT,
    FOREIGN KEY (docente_id) REFERENCES docentes(id),
    FOREIGN KEY (franja_id) REFERENCES franjas_horarias(id)
);
 

CREATE TABLE grupos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    codigo VARCHAR(30) NOT NULL,
    jornada VARCHAR(15) NOT NULL,
    tipo VARCHAR(15) NOT NULL,
    plazasDisponibles INT,
    activo BOOLEAN DEFAULT TRUE
);
 
 

CREATE TABLE grupo_materias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    grupo_id INT,
    materia_id INT,
    FOREIGN KEY (grupo_id) REFERENCES grupos(id),
    FOREIGN KEY (materia_id) REFERENCES materias(id)
);
 

CREATE TABLE horarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    jornada VARCHAR(15) NOT NULL,
    periodo VARCHAR(20) NOT NULL,
    estado VARCHAR(20) NOT NULL,
    fechaCreacion DATETIME DEFAULT CURRENT_TIMESTAMP,
    semestre_id INT,
    creadoPor INT,
    FOREIGN KEY (semestre_id) REFERENCES semestres(id),
    FOREIGN KEY (creadoPor) REFERENCES usuarios(id)
);
 

CREATE TABLE horario_asignaciones (
    id INT AUTO_INCREMENT PRIMARY KEY,
    horario_id INT,
    grupo_id INT,
    materia_id INT,
    docente_id INT,
    franja_id INT,
    observacion VARCHAR(255),
    FOREIGN KEY (horario_id) REFERENCES horarios(id),
    FOREIGN KEY (grupo_id) REFERENCES grupos(id),
    FOREIGN KEY (materia_id) REFERENCES materias(id),
    FOREIGN KEY (docente_id) REFERENCES docentes(id),
    FOREIGN KEY (franja_id) REFERENCES franjas_horarias(id)
);
 

CREATE TABLE reportes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL,
    periodo VARCHAR(20),
    formato VARCHAR(10) NOT NULL,
    descripcion VARCHAR(255),
    fechaGeneracion DATETIME DEFAULT CURRENT_TIMESTAMP,
    horario_id INT,
    generadoPor INT,
    FOREIGN KEY (horario_id) REFERENCES horarios(id),
    FOREIGN KEY (generadoPor) REFERENCES usuarios(id)
);