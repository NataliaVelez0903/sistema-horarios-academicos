Imports SistemaHorarios.Logica.Entidades

Namespace Negocio.Horarios

    ' Clase encargada de validar disponibilidad
    ' de los docentes.
    Public Class GestorDisponibilidad

        ' ==================================================
        ' VALIDA SI EL DOCENTE YA TIENE
        ' UN HORARIO EN ESE MISMO BLOQUE
        ' ==================================================
        Public Sub ValidarCruceHorario(
            docente As Docente,
            nuevoHorario As Horario
        )

            If docente Is Nothing Then
                Throw New Exception("El docente no existe.")
            End If

            ' Verifica si existe un horario
            ' con mismo día y hora.
            Dim cruce = docente.Horarios.Any(
                Function(h)

                    Return h.Dia = nuevoHorario.Dia AndAlso
                           h.HoraInicio < nuevoHorario.HoraFin AndAlso
                           nuevoHorario.HoraInicio < h.HoraFin

                End Function
            )

            If cruce Then
                Throw New Exception(
                    "El docente ya tiene un horario asignado en ese bloque."
                )
            End If

        End Sub

    End Class

End Namespace
