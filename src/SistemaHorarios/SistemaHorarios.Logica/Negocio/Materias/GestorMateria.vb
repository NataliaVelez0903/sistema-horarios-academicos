Imports SistemaHorarios.Logica.Modelos

Public Class GestorMateria

    Private ReadOnly _validador As ValidadorMateria

    Public Sub New()

        _validador = New ValidadorMateria()

    End Sub

    ''' <summary>
    ''' Registra una nueva materia en el sistema.
    ''' </summary>
    Public Function RegistrarMateria(materia As Materia) As Boolean

        If materia Is Nothing Then
            Throw New Exception("La materia es requerida.")
        End If

        Dim errores As List(Of String) =
            _validador.ValidarMateria(materia)

        If errores.Count > 0 Then
            Throw New Exception(String.Join(Environment.NewLine, errores))
        End If

        ' Aquí después irá la persistencia en base de datos.
        Return True

    End Function

    ''' <summary>
    ''' Actualiza la información de una materia.
    ''' </summary>
    Public Function ActualizarMateria(materia As Materia) As Boolean

        If materia Is Nothing Then
            Throw New Exception("La materia es requerida.")
        End If

        If materia.Id <= 0 Then
            Throw New Exception("El id de la materia no es válido.")
        End If

        Dim errores As List(Of String) =
            _validador.ValidarMateria(materia)

        If errores.Count > 0 Then
            Throw New Exception(String.Join(Environment.NewLine, errores))
        End If

        Return True

    End Function

    ''' <summary>
    ''' Valida si una materia puede ser utilizada en el sistema.
    ''' </summary>
    Public Function MateriaEsValida(materia As Materia) As Boolean

        Dim errores As List(Of String) =
            _validador.ValidarMateria(materia)

        Return errores.Count = 0

    End Function

    ''' <summary>
    ''' Verifica si la materia aplica para estudiantes TAPSI.
    ''' </summary>
    Public Function EsMateriaTAPSI(materia As Materia) As Boolean

        If materia Is Nothing Then
            Throw New Exception("La materia es requerida.")
        End If

        Return materia.AplicaTAPSI

    End Function

    ''' <summary>
    ''' Verifica si la materia es obligatoria para TAPSI.
    ''' </summary>
    Public Function EsMateriaObligatoriaTAPSI(materia As Materia) As Boolean

        If materia Is Nothing Then
            Throw New Exception("La materia es requerida.")
        End If

        Return materia.EsObligatoriaTAPSI

    End Function

    ''' <summary>
    ''' Verifica si la materia tiene componente práctico.
    ''' </summary>
    Public Function TieneComponentePractico(materia As Materia) As Boolean

        If materia Is Nothing Then
            Throw New Exception("La materia es requerida.")
        End If

        Return materia.TieneComponentePractico

    End Function

    ''' <summary>
    ''' Calcula la carga académica en créditos.
    ''' </summary>
    Public Function CalcularCargaAcademica(
        materias As List(Of Materia)
    ) As Integer

        If materias Is Nothing OrElse materias.Count = 0 Then
            Return 0
        End If

        Dim totalCreditos As Integer = 0

        For Each materia As Materia In materias

            totalCreditos += materia.Creditos

        Next

        Return totalCreditos

    End Function

    ''' <summary>
    ''' Obtiene materias activas.
    ''' </summary>
    Public Function ObtenerMateriasActivas(
        materias As List(Of Materia)
    ) As List(Of Materia)

        Return materias.
            Where(Function(m) m.Estado = True).
            ToList()

    End Function

    ''' <summary>
    ''' Filtra materias que aplican para TAPSI.
    ''' </summary>
    Public Function ObtenerMateriasTAPSI(
        materias As List(Of Materia)
    ) As List(Of Materia)

        Return materias.
            Where(Function(m) m.AplicaTAPSI = True).
            ToList()

    End Function

    ''' <summary>
    ''' Filtra materias por semestre recomendado.
    ''' </summary>
    Public Function ObtenerMateriasPorSemestre(
        materias As List(Of Materia),
        semestre As Integer
    ) As List(Of Materia)

        Return materias.
            Where(Function(m) m.SemestreRecomendado = semestre).
            ToList()

    End Function

End Class