Imports SistemaHorarios.Logica.Modelos

Public Class EvaluadorMateriaHabilitada

    ''' <summary>
    ''' Determina si un estudiante puede cursar una materia.
    ''' </summary>
    Public Function PuedeCursarMateria(
        materia As Materia,
        materiasAprobadas As List(Of Materia),
        prerequisitos As List(Of PrerequisitoMateria),
        tipoEstudiante As TipoEstudiante
    ) As Boolean

        If materia Is Nothing Then

            Throw New Exception(
                "La materia es requerida."
            )

        End If

        If Not materia.Estado Then

            Return False

        End If

        If Not ValidarTAPSI(
            materia,
            tipoEstudiante
        ) Then

            Return False

        End If

        If Not CumplePrerequisitos(
            materia,
            materiasAprobadas,
            prerequisitos
        ) Then

            Return False

        End If

        Return True

    End Function

    ''' <summary>
    ''' Verifica si el estudiante cumple los prerequisitos.
    ''' </summary>
    Private Function CumplePrerequisitos(
        materia As Materia,
        materiasAprobadas As List(Of Materia),
        prerequisitos As List(Of PrerequisitoMateria)
    ) As Boolean

        Dim prerequisitosMateria =
            prerequisitos.Where(
                Function(p)
                    p.IdMateria = materia.Id
                End Function
            ).ToList()

        If prerequisitosMateria.Count = 0 Then

            Return True

        End If

        For Each prerequisito In prerequisitosMateria

            Dim aprobado =
                materiasAprobadas.Any(
                    Function(m)
                        m.Id =
                        prerequisito.IdMateriaPrerequisito
                    End Function
                )

            If Not aprobado Then

                Return False

            End If

        Next

        Return True

    End Function

    ''' <summary>
    ''' Valida reglas relacionadas con estudiantes TAPSI.
    ''' </summary>
    Private Function ValidarTAPSI(
        materia As Materia,
        tipoEstudiante As TipoEstudiante
    ) As Boolean

        If tipoEstudiante = TipoEstudiante.TAPSI Then

            Return materia.AplicaTAPSI

        End If

        Return True

    End Function

    ''' <summary>
    ''' Obtiene las materias habilitadas para un estudiante.
    ''' </summary>
    Public Function ObtenerMateriasHabilitadas(
        materias As List(Of Materia),
        materiasAprobadas As List(Of Materia),
        prerequisitos As List(Of PrerequisitoMateria),
        tipoEstudiante As TipoEstudiante
    ) As List(Of Materia)

        Dim materiasHabilitadas As New List(Of Materia)

        For Each materia In materias

            If PuedeCursarMateria(
                materia,
                materiasAprobadas,
                prerequisitos,
                tipoEstudiante
            ) Then

                materiasHabilitadas.Add(materia)

            End If

        Next

        Return materiasHabilitadas

    End Function

End Class