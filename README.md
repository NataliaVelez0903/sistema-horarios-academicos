# Sistema de Generación Automática de Horarios Académicos

## Descripción general

Este proyecto tiene como propósito desarrollar una solución de software de escritorio para apoyar a la coordinación académica en la planificación, organización y generación automática de horarios académicos.

El sistema permitirá gestionar información relacionada con el plan académico del programa, materias, prerrequisitos, docentes, disponibilidad horaria, grupos, jornadas y tipos de estudiantes. La solución contempla estudiantes regulares y estudiantes TAPSI, quienes pueden ingresar con materias homologadas y requerir una asignación académica específica.

A partir de la información registrada, el sistema generará horarios académicos procurando evitar conflictos entre materias, grupos, docentes y franjas horarias. Además, permitirá consultar horarios, revisar conflictos, realizar ajustes manuales, aprobar horarios finales y generar reportes académicos útiles para la toma de decisiones.

El sistema está orientado principalmente al personal de coordinación académica y administrativo, con posibilidad de ampliar sus funcionalidades en futuras fases para incluir consultas por parte de estudiantes.

---

## Objetivo del proyecto

Desarrollar una aplicación de escritorio que permita planificar y generar horarios académicos de manera automática, teniendo en cuenta restricciones institucionales como jornadas, prerrequisitos, carga académica, disponibilidad docente y tipos de estudiantes.

---

## Tecnologías utilizadas

Las tecnologías iniciales propuestas para el desarrollo del proyecto son:

- **Lenguaje de programación:** Visual Basic .NET
- **Framework:** .NET
- **Tipo de aplicación:** Aplicación de escritorio
- **IDE recomendado:** Visual Studio
- **Base de datos:** SQL Server
- **Control de versiones:** Git
- **Repositorio remoto:** GitHub
- **Gestión del proyecto:** Jira
- **Metodología de trabajo:** Scrum
- **Modelo de ramas:** Git Flow

---

## Integrantes del equipo

Natalia Velez Orjuela - Product Owner
Sebastian Villaneda - Scrum Master
Luis Carlos Gallego - Development Team
Juan Jose Giraldo - Development Team
Johan Javier Roldon - Development Team
Gilary Valeria Rugeles Avendaño - Development Team
Salomé Toro Diaz - Development Team
Samuel Colorado - Development Team

---

## Funcionalidades principales

El sistema contempla las siguientes funcionalidades principales:

- Gestión del plan académico.
- Registro de materias, créditos, intensidad horaria y prerrequisitos.
- Gestión de estudiantes regulares y estudiantes TAPSI.
- Registro de materias homologadas para estudiantes TAPSI.
- Gestión de materias obligatorias para estudiantes TAPSI.
- Gestión de docentes.
- Registro de disponibilidad horaria de docentes.
- Asignación de materias que puede dictar cada docente.
- Creación y administración de grupos académicos.
- Manejo de jornadas diurna y nocturna.
- Generación automática de horarios académicos.
- Detección de conflictos de horario, docentes, créditos y prerrequisitos.
- Ajuste manual de horarios generados.
- Aprobación de horarios finales.
- Consulta de horarios por grupo, docente o jornada.
- Generación de reportes académicos.
- Exportación de horarios y reportes en formatos definidos.

---

## Reglas principales del sistema

El sistema debe cumplir con las siguientes reglas:

- Existen dos jornadas académicas: diurna y nocturna.
- Los estudiantes pueden ser regulares o TAPSI.
- Los estudiantes TAPSI pueden tener materias homologadas.
- Los estudiantes TAPSI deben cursar primero las materias obligatorias definidas por coordinación.
- Ninguna materia puede asignarse si no se cumplen sus prerrequisitos.
- Un estudiante TAPSI no puede cursar una materia que ya tenga homologada.
- Los estudiantes TAPSI pueden compartir grupos con estudiantes regulares cuando sea posible.
- Un grupo no puede tener dos materias en la misma franja horaria.
- Un docente no puede tener dos asignaciones en la misma franja horaria.
- Toda asignación docente debe respetar la disponibilidad registrada.
- La jornada diurna tiene un máximo de 18 créditos.
- La jornada nocturna tiene un máximo de 14 créditos.
- Un horario solo puede aprobarse si cumple las reglas académicas y operativas definidas.

---

## Estructura inicial del proyecto

La estructura inicial del proyecto estará organizada separando la interfaz de usuario y la lógica interna del sistema. Aunque el sistema será una aplicación de escritorio en .NET con Visual Basic, se manejará una división entre frontend y backend para mantener una arquitectura más ordenada, escalable y fácil de mantener.

El frontend estará encargado de la interfaz gráfica, formularios, controles visuales y recursos de presentación. El backend contendrá la lógica del negocio, modelos, validaciones, servicios, conexión a base de datos, repositorios y generación de reportes.

```plaintext
ProyectoHorariosAcademicos/
│
├── ProyectoHorariosAcademicos.sln
├── README.md
├── .gitignore
├── LICENSE
│
├── src/
│   ├── frontend/
│   │   └── ProyectoHorariosAcademicos.UI/
│   │       ├── ProyectoHorariosAcademicos.UI.vbproj
│   │       ├── App.config
│   │       ├── Program.vb
│   │       ├── Forms/
│   │       │   ├── FrmLogin.vb
│   │       │   ├── FrmPrincipal.vb
│   │       │   ├── FrmPlanAcademico.vb
│   │       │   ├── FrmMaterias.vb
│   │       │   ├── FrmDocentes.vb
│   │       │   ├── FrmDisponibilidadDocente.vb
│   │       │   ├── FrmGrupos.vb
│   │       │   ├── FrmGeneracionHorarios.vb
│   │       │   ├── FrmReportes.vb
│   │       │   └── FrmUsuarios.vb
│   │       ├── Controls/
│   │       ├── Resources/
│   │       │   ├── Images/
│   │       │   └── Icons/
│   │       └── Styles/
│   │
│   ├── backend/
│   │   ├── ProyectoHorariosAcademicos.Domain/
│   │   │   ├── ProyectoHorariosAcademicos.Domain.vbproj
│   │   │   ├── Models/
│   │   │   │   ├── Materia.vb
│   │   │   │   ├── Docente.vb
│   │   │   │   ├── Grupo.vb
│   │   │   │   ├── Horario.vb
│   │   │   │   ├── Jornada.vb
│   │   │   │   ├── Estudiante.vb
│   │   │   │   └── Usuario.vb
│   │   │   └── Enums/
│   │   │       ├── TipoEstudiante.vb
│   │   │       ├── TipoJornada.vb
│   │   │       └── EstadoHorario.vb
│   │   │
│   │   ├── ProyectoHorariosAcademicos.Application/
│   │   │   ├── ProyectoHorariosAcademicos.Application.vbproj
│   │   │   ├── Services/
│   │   │   │   ├── HorarioService.vb
│   │   │   │   ├── MateriaService.vb
│   │   │   │   ├── DocenteService.vb
│   │   │   │   ├── GrupoService.vb
│   │   │   │   ├── ReporteService.vb
│   │   │   │   └── AuthService.vb
│   │   │   ├── Validators/
│   │   │   │   ├── HorarioValidator.vb
│   │   │   │   ├── MateriaValidator.vb
│   │   │   │   └── DocenteValidator.vb
│   │   │   └── DTOs/
│   │   │       ├── MateriaDTO.vb
│   │   │       ├── DocenteDTO.vb
│   │   │       └── HorarioDTO.vb
│   │   │
│   │   └── ProyectoHorariosAcademicos.Infrastructure/
│   │       ├── ProyectoHorariosAcademicos.Infrastructure.vbproj
│   │       ├── Data/
│   │       │   ├── Conexion.vb
│   │       │   └── DbContext.vb
│   │       ├── Repositories/
│   │       │   ├── MateriaRepository.vb
│   │       │   ├── DocenteRepository.vb
│   │       │   ├── GrupoRepository.vb
│   │       │   ├── HorarioRepository.vb
│   │       │   └── UsuarioRepository.vb
│   │       └── Reports/
│   │           ├── PdfReportGenerator.vb
│   │           └── CsvReportGenerator.vb
│
├── database/
│   ├── scripts/
│   │   ├── 01_creacion_base_datos.sql
│   │   ├── 02_creacion_tablas.sql
│   │   └── 03_datos_iniciales.sql
│   └── backups/
│
├── docs/
│   ├── analisis/
│   ├── manuales/
│   ├── diagramas/
│   └── evidencias/
│
└── tests/
    └── ProyectoHorariosAcademicos.Tests/
        ├── Services/
        ├── Validators/
        └── Repositories/