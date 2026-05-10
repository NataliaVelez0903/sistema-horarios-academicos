Imports SistemaHorarios.Logica.Modelos
Imports SistemaHorarios.Logica.ReglasMaImports

Public Class CalculadorCargaAcademica

    ''' <summary>
    ''' Calcula el total de créditos de una lista de materias.
    ''' </summary>
    Public Function CalcularTotalCreditos(
        materias As List(Of Materia)
    ) As Integer

        If materias Is Nothing OrElse
           materias.Count = 0 Then

            Return 0

        End If

        Dim total As Integer = 0

        For Each materia As Materia In materias

            total += materia.Creditos

        Next

        Return total

    End Function

    ''' <summary>
    ''' Calcula la intensidad horaria total semanal.
    ''' </summary>
    Public Function CalcularIntensidadHoraria(
        materias As List(Of Materia)
    ) As Integer

        If materias Is Nothing OrElse
           materias.Count = 0 Then

            Return 0

        End If

        Dim total As Integer = 0

        For Each materia As Materia In materias

            total += materia.IntensidadHoraria

        Next

        Return total

    End Function

    ''' <summary>
    ''' Obtiene la cantidad total de materias.
    ''' </summary>
    Public Function ContarMaterias(
        materias As List(Of Materia)
    ) As Integer

        If materias Is Nothing Then

            Return 0

        End If

        Return materias.Count

    End Function

    ''' <summary>
    ''' Determina si la carga académica es pesada.
    ''' </summary>
    Public Function EsCargaPesada(
        materias As List(Of Materia)
    ) As Boolean

        Dim totalCreditos =
            CalcularTotalCreditos(materias)

        Return totalCreditos >= 18

    End Function

    ''' <summary>
    ''' Determina si la intensidad horaria es alta.
    ''' </summary>
    Public Function TieneAltaIntensidad(
        materias As List(Of Materia)
    ) As Boolean

        Dim intensidad =
            CalcularIntensidadHoraria(materias)

        Return intensidad >= 30

    End Function

    ''' <summary>
    ''' Verifica si la carga académica excede
    ''' el límite permitido.
    ''' </summary>
    Public Function ExcedeLimiteCreditos(
        materias As List(Of Materia),
        limite As Integer
    ) As Boolean

        Dim totalCreditos =
            CalcularTotalCreditos(materias)

        Return totalCreditos > limite

    End Function

    ''' <summary>
    ''' Obtiene únicamente materias pesadas.
    ''' </summary>
    Public Function ObtenerMateriasPesadas(
        materias As List(Of Materia)
    ) As List(Of Materia)

        Return materias.
            Where(Function(m)
                      ReglasMateria.
                      EsMateriaPesada(m)
                  End Function).
            ToList()

    End Function

    ''' <summary>
    ''' Obtiene materias con componente práctico.
    ''' </summary>
    Public Function ObtenerMateriasPracticas(
    materias As List(Of Materia)
    ) As List(Of Materia)

        Return materias.
        Where(Function(m) m.TieneComponentePractico).
        ToList()

    End Function

End Class