' Importa el namespace donde se encuentra definida
' la entidad Docente que será utilizada en esta clase.
Imports SistemaHorarios.Logica.Entidades

' Namespace encargado de agrupar toda la lógica
' relacionada con la gestión de docentes.
Namespace Negocio.Docentes

    ' Clase responsable de administrar las operaciones CRUD
    ' (Crear, Leer, Actualizar y Eliminar) de los docentes.
    Public Class GestorDocente

        ' Lista privada que almacena temporalmente
        ' todos los docentes registrados en memoria.
        '
        ' ReadOnly indica que la referencia de la lista
        ' no puede cambiar después de inicializarse.
        Private ReadOnly listaDocentes As List(Of Docente)

        ' Constructor de la clase.
        '
        ' Se ejecuta automáticamente al crear un objeto
        ' de tipo GestorDocente.
        Public Sub New()

            ' Inicializa la lista vacía de docentes.
            listaDocentes = New List(Of Docente)

        End Sub

        ' ==================================================
        ' MÉTODO: AgregarDocente
        ' FUNCIÓN:
        ' Registra un nuevo docente en el sistema.
        ' ==================================================
        Public Sub AgregarDocente(docente As Docente)

            ' Valida que el objeto docente no sea nulo.
            If docente Is Nothing Then
                Throw New Exception("El docente no puede ser nulo.")
            End If

            ' Valida que la identificación tenga contenido.
            If String.IsNullOrWhiteSpace(docente.Identificacion) Then
                Throw New Exception("La identificación es obligatoria.")
            End If

            ' Valida que el nombre tenga contenido.
            If String.IsNullOrWhiteSpace(docente.Nombre) Then
                Throw New Exception("El nombre es obligatorio.")
            End If

            ' Busca si ya existe un docente con la misma identificación.
            '
            ' Any() retorna True si encuentra al menos
            ' un elemento que cumpla la condición.
            Dim existe = listaDocentes.Any(Function(d) d.Identificacion = docente.Identificacion)

            ' Si ya existe un docente con la misma identificación,
            ' se genera una excepción para evitar duplicados.
            If existe Then
                Throw New Exception("Ya existe un docente con esa identificación.")
            End If

            ' Agrega el nuevo docente a la lista.
            listaDocentes.Add(docente)

        End Sub

        ' ==================================================
        ' MÉTODO: ObtenerDocentes
        ' FUNCIÓN:
        ' Retorna la lista completa de docentes registrados.
        ' ==================================================
        Public Function ObtenerDocentes() As List(Of Docente)

            ' Devuelve todos los docentes almacenados.
            Return listaDocentes

        End Function

        ' ==================================================
        ' MÉTODO: ObtenerDocentePorId
        ' FUNCIÓN:
        ' Busca y retorna un docente usando su ID.
        ' ==================================================
        Public Function ObtenerDocentePorId(id As Integer) As Docente

            ' FirstOrDefault busca el primer elemento
            ' que cumpla la condición especificada.
            '
            ' Si no encuentra coincidencias,
            ' retorna Nothing.
            Return listaDocentes.FirstOrDefault(Function(d) d.Id = id)

        End Function

        ' ==================================================
        ' MÉTODO: ActualizarDocente
        ' FUNCIÓN:
        ' Modifica la información de un docente existente.
        ' ==================================================
        Public Sub ActualizarDocente(docenteActualizado As Docente)

            ' Busca el docente original usando el ID.
            Dim docente = ObtenerDocentePorId(docenteActualizado.Id)

            ' Verifica que el docente exista.
            If docente Is Nothing Then
                Throw New Exception("Docente no encontrado.")
            End If

            ' Actualiza los datos del docente.
            docente.Identificacion = docenteActualizado.Identificacion
            docente.Nombre = docenteActualizado.Nombre
            docente.Estado = docenteActualizado.Estado

        End Sub

        ' ==================================================
        ' MÉTODO: EliminarDocente
        ' FUNCIÓN:
        ' Elimina un docente de la lista.
        ' ==================================================
        Public Sub EliminarDocente(id As Integer)

            ' Busca el docente usando el ID recibido.
            Dim docente = ObtenerDocentePorId(id)

            ' Verifica que el docente exista.
            If docente Is Nothing Then
                Throw New Exception("Docente no encontrado.")
            End If

            ' Elimina el docente de la lista.
            listaDocentes.Remove(docente)

        End Sub

    End Class

End Namespace