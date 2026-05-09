
SET FOREIGN_KEY_CHECKS = 0;
SET sql_mode = 'STRICT_TRANS_TABLES,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO';

-- ============================================================
--  1. ADMINISTRACIÓN Y SEGURIDAD
-- ============================================================

CREATE TABLE roles (
    id          INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nombre      VARCHAR(50)  NOT NULL UNIQUE,
    descripcion TEXT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE usuarios (
    id              INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    username        VARCHAR(80)  NOT NULL UNIQUE,
    password_hash   VARCHAR(255) NOT NULL,
    nombre_completo VARCHAR(150) NOT NULL,
    email           VARCHAR(150),
    rol_id          INT UNSIGNED NOT NULL,
    activo          TINYINT(1)   NOT NULL DEFAULT 1,
    creado_en       DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_usuarios_rol FOREIGN KEY (rol_id) REFERENCES roles(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Auditoría (RF68, RF69)
-- ENUM para módulos y acciones comunes; 'detalle' en JSON para flexibilidad
CREATE TABLE auditoria (
    id           BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    usuario_id   INT UNSIGNED,
    modulo       VARCHAR(60)  NOT NULL,
    accion       VARCHAR(60)  NOT NULL,
    tabla        VARCHAR(80),
    registro_id  INT,
    detalle      JSON,
    realizado_en DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_auditoria_usuario FOREIGN KEY (usuario_id)
        REFERENCES usuarios(id) ON DELETE SET NULL,
    INDEX idx_auditoria_usuario (usuario_id),
    INDEX idx_auditoria_modulo  (modulo, realizado_en)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  2. PLAN ACADÉMICO
-- ============================================================

CREATE TABLE semestres (
    id      INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    numero  TINYINT UNSIGNED NOT NULL UNIQUE,
    nombre  VARCHAR(50)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE materias (
    id                  INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    codigo              VARCHAR(20)  NOT NULL UNIQUE,
    nombre              VARCHAR(150) NOT NULL,
    creditos            TINYINT UNSIGNED NOT NULL,
    intensidad_semanal  TINYINT UNSIGNED NOT NULL,  -- horas/semana
    semestre_id         INT UNSIGNED NOT NULL,
    activa              TINYINT(1)   NOT NULL DEFAULT 1,
    creado_en           DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    actualizado_en      DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
                                     ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT fk_materias_semestre FOREIGN KEY (semestre_id)
        REFERENCES semestres(id),
    INDEX idx_materias_semestre (semestre_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Prerrequisitos: relación autorreferencial materia → materia
CREATE TABLE prerrequisitos (
    materia_id       INT UNSIGNED NOT NULL,
    prerrequisito_id INT UNSIGNED NOT NULL,
    PRIMARY KEY (materia_id, prerrequisito_id),
    CONSTRAINT fk_pre_materia FOREIGN KEY (materia_id)
        REFERENCES materias(id) ON DELETE CASCADE,
    CONSTRAINT fk_pre_prereq  FOREIGN KEY (prerrequisito_id)
        REFERENCES materias(id) ON DELETE RESTRICT,
    INDEX idx_prerrequisitos_mat (materia_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  3. DOCENTES
-- ============================================================

CREATE TABLE docentes (
    id              INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    identificacion  VARCHAR(30)  NOT NULL UNIQUE,
    nombre          VARCHAR(150) NOT NULL,
    email           VARCHAR(150),
    activo          TINYINT(1)   NOT NULL DEFAULT 1,
    creado_en       DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE docente_materias (
    docente_id  INT UNSIGNED NOT NULL,
    materia_id  INT UNSIGNED NOT NULL,
    PRIMARY KEY (docente_id, materia_id),
    CONSTRAINT fk_dm_docente FOREIGN KEY (docente_id)
        REFERENCES docentes(id) ON DELETE CASCADE,
    CONSTRAINT fk_dm_materia FOREIGN KEY (materia_id)
        REFERENCES materias(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  4. FRANJAS HORARIAS
-- ============================================================

CREATE TABLE franjas_horarias (
    id          INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    dia         ENUM('lunes','martes','miercoles','jueves','viernes','sabado') NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin    TIME NOT NULL,
    CONSTRAINT chk_franja_horas CHECK (hora_fin > hora_inicio),
    UNIQUE KEY uq_franja (dia, hora_inicio, hora_fin)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Disponibilidad del docente por franja
CREATE TABLE docente_disponibilidad (
    docente_id  INT UNSIGNED NOT NULL,
    franja_id   INT UNSIGNED NOT NULL,
    PRIMARY KEY (docente_id, franja_id),
    CONSTRAINT fk_dd_docente FOREIGN KEY (docente_id)
        REFERENCES docentes(id) ON DELETE CASCADE,
    CONSTRAINT fk_dd_franja  FOREIGN KEY (franja_id)
        REFERENCES franjas_horarias(id) ON DELETE CASCADE,
    INDEX idx_docente_disp_franja (franja_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  5. GRUPOS
-- ============================================================

CREATE TABLE grupos (
    id               INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    codigo           VARCHAR(30)  NOT NULL UNIQUE,
    jornada          ENUM('diurna','nocturna') NOT NULL,
    capacidad_maxima SMALLINT UNSIGNED,
    activo           TINYINT(1)   NOT NULL DEFAULT 1,
    creado_en        DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  6. ESTUDIANTES
-- ============================================================

CREATE TABLE estudiantes (
    id              INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    identificacion  VARCHAR(30)  NOT NULL UNIQUE,
    nombre          VARCHAR(150) NOT NULL,
    email           VARCHAR(150),
    tipo            ENUM('regular','tapsi') NOT NULL DEFAULT 'regular',
    semestre_actual TINYINT UNSIGNED,
    activo          TINYINT(1)   NOT NULL DEFAULT 1,
    creado_en       DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE grupo_estudiantes (
    grupo_id      INT UNSIGNED NOT NULL,
    estudiante_id INT UNSIGNED NOT NULL,
    PRIMARY KEY (grupo_id, estudiante_id),
    CONSTRAINT fk_ge_grupo     FOREIGN KEY (grupo_id)
        REFERENCES grupos(id) ON DELETE CASCADE,
    CONSTRAINT fk_ge_estudiante FOREIGN KEY (estudiante_id)
        REFERENCES estudiantes(id) ON DELETE CASCADE,
    INDEX idx_grupo_est_est (estudiante_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  7. MÓDULO TAPSI
-- ============================================================

CREATE TABLE tapsi_homologadas (
    estudiante_id INT UNSIGNED NOT NULL,
    materia_id    INT UNSIGNED NOT NULL,
    PRIMARY KEY (estudiante_id, materia_id),
    CONSTRAINT fk_th_estudiante FOREIGN KEY (estudiante_id)
        REFERENCES estudiantes(id) ON DELETE CASCADE,
    CONSTRAINT fk_th_materia    FOREIGN KEY (materia_id)
        REFERENCES materias(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE tapsi_obligatorias (
    id         INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    materia_id INT UNSIGNED NOT NULL UNIQUE,
    CONSTRAINT fk_to_materia FOREIGN KEY (materia_id)
        REFERENCES materias(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  8. HORARIOS
-- ============================================================

CREATE TABLE horarios (
    id             INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nombre         VARCHAR(100)  NOT NULL,
    jornada        ENUM('diurna','nocturna') NOT NULL,
    periodo        VARCHAR(20)   NOT NULL,
    estado         ENUM('borrador','propuesta','aprobado','rechazado')
                   NOT NULL DEFAULT 'borrador',
    aprobado_por   INT UNSIGNED,
    aprobado_en    DATETIME,
    creado_por     INT UNSIGNED,
    creado_en      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    actualizado_en DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                            ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT fk_h_aprobador FOREIGN KEY (aprobado_por)
        REFERENCES usuarios(id) ON DELETE SET NULL,
    CONSTRAINT fk_h_creador   FOREIGN KEY (creado_por)
        REFERENCES usuarios(id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE horario_asignaciones (
    id         BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    horario_id INT UNSIGNED NOT NULL,
    grupo_id   INT UNSIGNED NOT NULL,
    materia_id INT UNSIGNED NOT NULL,
    docente_id INT UNSIGNED NOT NULL,
    franja_id  INT UNSIGNED NOT NULL,
    -- RF32: mismo grupo no puede tener dos materias en la misma franja
    UNIQUE KEY uq_grupo_franja   (horario_id, grupo_id,   franja_id),
    -- RF33: un docente no puede tener dos asignaciones en la misma franja
    UNIQUE KEY uq_docente_franja (horario_id, docente_id, franja_id),
    CONSTRAINT fk_ha_horario FOREIGN KEY (horario_id)
        REFERENCES horarios(id) ON DELETE CASCADE,
    CONSTRAINT fk_ha_grupo   FOREIGN KEY (grupo_id)
        REFERENCES grupos(id)   ON DELETE RESTRICT,
    CONSTRAINT fk_ha_materia FOREIGN KEY (materia_id)
        REFERENCES materias(id) ON DELETE RESTRICT,
    CONSTRAINT fk_ha_docente FOREIGN KEY (docente_id)
        REFERENCES docentes(id) ON DELETE RESTRICT,
    CONSTRAINT fk_ha_franja  FOREIGN KEY (franja_id)
        REFERENCES franjas_horarias(id) ON DELETE RESTRICT,
    INDEX idx_asig_horario  (horario_id),
    INDEX idx_asig_grupo    (grupo_id),
    INDEX idx_asig_docente  (docente_id),
    INDEX idx_asig_franja   (franja_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE horario_conflictos (
    id          BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    horario_id  INT UNSIGNED NOT NULL,
    tipo        ENUM(
                    'solapamiento_grupo',
                    'solapamiento_docente',
                    'docente_no_disponible',
                    'creditos_excedidos',
                    'prerrequisito_incumplido',
                    'materia_no_habilitada_docente',
                    'carga_incompleta',
                    'otro'
                ) NOT NULL,
    descripcion TEXT NOT NULL,
    resuelto    TINYINT(1)  NOT NULL DEFAULT 0,
    detectado_en DATETIME   NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_hc_horario FOREIGN KEY (horario_id)
        REFERENCES horarios(id) ON DELETE CASCADE,
    INDEX idx_conflictos_horario (horario_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  9. REPORTES
-- ============================================================

CREATE TABLE reportes (
    id           INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    tipo         ENUM('carga_docente','asignacion_materias_grupo',
                      'conflictos','horarios_aprobados') NOT NULL,
    formato      ENUM('pdf','csv') NOT NULL,
    horario_id   INT UNSIGNED,
    generado_por INT UNSIGNED,
    parametros   JSON,
    ruta_archivo TEXT,
    generado_en  DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_r_horario FOREIGN KEY (horario_id)
        REFERENCES horarios(id) ON DELETE SET NULL,
    CONSTRAINT fk_r_usuario FOREIGN KEY (generado_por)
        REFERENCES usuarios(id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
--  10. VISTAS
-- ============================================================

-- Carga docente por horario
CREATE OR REPLACE VIEW v_carga_docente AS
SELECT
    h.id            AS horario_id,
    h.nombre        AS horario_nombre,
    h.periodo,
    d.id            AS docente_id,
    d.nombre        AS docente,
    COUNT(ha.id)    AS total_sesiones,
    SUM(m.creditos) AS total_creditos
FROM horario_asignaciones ha
JOIN horarios   h ON ha.horario_id = h.id
JOIN docentes   d ON ha.docente_id = d.id
JOIN materias   m ON ha.materia_id = m.id
GROUP BY h.id, h.nombre, h.periodo, d.id, d.nombre;

-- Horario completo por grupo
CREATE OR REPLACE VIEW v_horario_grupo AS
SELECT
    h.id            AS horario_id,
    h.nombre        AS horario_nombre,
    h.periodo,
    h.estado,
    g.codigo        AS grupo,
    g.jornada,
    m.codigo        AS materia_codigo,
    m.nombre        AS materia,
    m.creditos,
    d.nombre        AS docente,
    f.dia,
    f.hora_inicio,
    f.hora_fin
FROM horario_asignaciones ha
JOIN horarios         h ON ha.horario_id = h.id
JOIN grupos           g ON ha.grupo_id   = g.id
JOIN materias         m ON ha.materia_id = m.id
JOIN docentes         d ON ha.docente_id = d.id
JOIN franjas_horarias f ON ha.franja_id  = f.id
ORDER BY g.codigo, f.dia, f.hora_inicio;

-- Créditos por grupo y validación de límite
CREATE OR REPLACE VIEW v_creditos_grupo AS
SELECT
    ha.horario_id,
    ha.grupo_id,
    g.codigo    AS grupo,
    g.jornada,
    SUM(m.creditos) AS total_creditos,
    CASE g.jornada
        WHEN 'diurna'   THEN 18
        WHEN 'nocturna' THEN 14
    END AS limite_creditos,
    CASE
        WHEN SUM(m.creditos) > CASE g.jornada WHEN 'diurna' THEN 18 ELSE 14 END
        THEN 1 ELSE 0
    END AS excede_limite
FROM horario_asignaciones ha
JOIN grupos   g ON ha.grupo_id   = g.id
JOIN materias m ON ha.materia_id = m.id
GROUP BY ha.horario_id, ha.grupo_id, g.codigo, g.jornada;

-- ============================================================
--  11. DATOS INICIALES
-- ============================================================

SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO roles (nombre, descripcion) VALUES
    ('coordinador',    'Acceso completo al sistema'),
    ('administrativo', 'Consulta y descarga de reportes');

INSERT INTO semestres (numero, nombre) VALUES
    (1,'Primer semestre'),(2,'Segundo semestre'),(3,'Tercer semestre'),
    (4,'Cuarto semestre'),(5,'Quinto semestre'),(6,'Sexto semestre'),
    (7,'Séptimo semestre'),(8,'Octavo semestre'),(9,'Noveno semestre'),
    (10,'Décimo semestre');
