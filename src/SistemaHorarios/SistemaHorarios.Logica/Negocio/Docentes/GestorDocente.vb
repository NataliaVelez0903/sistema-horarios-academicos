' Importa la entidad Docente.
Imports SistemaHorarios.Logica.Entidades
Imports SistemaHorarios.Logica.Modelos

' Namespace encargado de la lógica de negocio
' relacionada con la gestión de docentes.
Namespace Negocio.Docentes

    ' Clase que administra las operaciones CRUD
    ' de los docentes en memoria.
    Public Class GestorDocente

        ' Lista donde se almacenan los docentes.
        Private ReadOnly listaDocentes As List(Of Docente)

        ' Constructor de la clase.
        Public Sub New()

            listaDocentes = New List(Of Docente)

        End Sub

        ' ==================================================
        ' CREAR DOCENTE
        ' ==================================================
        Public Sub AgregarDocente(docente As Docente)

            If docente Is Nothing Then
                Throw New Exception("El docente no puede ser nulo.")
            End If

            If String.IsNullOrWhiteSpace(docente.Identificacion) Then
                Throw New Exception("La identificación es obligatoria.")
            End If

            If String.IsNullOrWhiteSpace(docente.Nombre) Then
                Throw New Exception("El nombre es obligatorio.")
            End If

            ' Verifica si ya existe un docente
            ' con la misma identificación.
            Dim existe = listaDocentes.Any(
                Function(d) d.Identificacion = docente.Identificacion
            )

            If existe Then
                Throw New Exception("Ya existe un docente con esa identificación.")
            End If

            listaDocentes.Add(docente)

        End Sub

        ' ==================================================
        ' LEER TODOS LOS DOCENTES
        ' ==================================================
        Public Function ObtenerDocentes() As List(Of Docente)

            Return listaDocentes

        End Function

        ' ==================================================
        ' LEER DOCENTE POR IDENTIFICACIÓN
        ' ==================================================
        Public Function ObtenerDocentePorIdentificacion(
            identificacion As String
        ) As Docente

            If String.IsNullOrWhiteSpace(identificacion) Then
                Throw New Exception("La identificación es obligatoria.")
            End If

            Dim docente = listaDocentes.FirstOrDefault(
                Function(d) d.Identificacion = identificacion
            )

            If docente Is Nothing Then
                Throw New Exception("Docente no encontrado.")
            End If

            Return docente

        End Function

        ' ==================================================
        ' ACTUALIZAR DOCENTE
        ' ==================================================
        Public Sub ActualizarDocente(docenteActualizado As Docente)

            If docenteActualizado Is Nothing Then
                Throw New Exception("El docente no puede ser nulo.")
            End If

            Dim docente = listaDocentes.FirstOrDefault(
                Function(d) d.Id = docenteActualizado.Id
            )

            If docente Is Nothing Then
                Throw New Exception("Docente no encontrado.")
            End If

            docente.Nombre = docenteActualizado.Nombre
            docente.Identificacion = docenteActualizado.Identificacion
            docente.Estado = docenteActualizado.Estado

        End Sub

        ' ==================================================
        ' ELIMINAR DOCENTE
        ' ==================================================
        Public Sub EliminarDocente(id As Integer)

            Dim docente = listaDocentes.FirstOrDefault(
                Function(d) d.Id = id
            )

            If docente Is Nothing Then
                Throw New Exception("Docente no encontrado.")
            End If

            ' Validación:
            ' Solo se puede eliminar si está inactivo.
            If docente.Estado = True Then
                Throw New Exception(
                    "No se puede eliminar un docente activo."
                )
            End If

            listaDocentes.Remove(docente)

        End Sub

    End Class

End Namespace