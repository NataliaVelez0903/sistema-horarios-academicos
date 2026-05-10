Imports SistemaHorarios.Logica.Modelos

Public Class ReglasMateria

        ''' <summary>
        ''' Determina si una materia es considerada pesada.
        ''' </summary>
        Public Shared Function EsMateriaPesada(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.Creditos >= 4

        End Function

        ''' <summary>
        ''' Determina si una materia tiene alta intensidad horaria.
        ''' </summary>
        Public Shared Function TieneAltaIntensidadHoraria(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.IntensidadHoraria >= 6

        End Function

        ''' <summary>
        ''' Determina si una materia tiene componente práctico.
        ''' </summary>
        Public Shared Function TieneComponentePractico(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.TieneComponentePractico

        End Function

        ''' <summary>
        ''' Determina si una materia aplica para estudiantes TAPSI.
        ''' </summary>
        Public Shared Function EsMateriaTAPSI(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.AplicaTAPSI

        End Function

        ''' <summary>
        ''' Determina si una materia es obligatoria para TAPSI.
        ''' </summary>
        Public Shared Function EsObligatoriaTAPSI(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.EsObligatoriaTAPSI

        End Function

        ''' <summary>
        ''' Determina si una materia puede compartirse
        ''' entre estudiantes TAPSI y regulares.
        ''' </summary>
        Public Shared Function PuedeCompartirse(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.Estado AndAlso
               materia.AplicaTAPSI

        End Function

        ''' <summary>
        ''' Determina si una materia está activa.
        ''' </summary>
        Public Shared Function EstaActiva(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.Estado

        End Function

        ''' <summary>
        ''' Determina si la materia pertenece
        ''' a semestres avanzados.
        ''' </summary>
        Public Shared Function EsMateriaAvanzada(
        materia As Materia
    ) As Boolean

            If materia Is Nothing Then

                Throw New Exception(
                "La materia es requerida."
            )

            End If

            Return materia.SemestreRecomendado >= 7

        End Function

    End Class