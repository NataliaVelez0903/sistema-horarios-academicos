Imports SistemaHorarios.Logica.Entidades

Namespace Negocio.Docentes

    ' ==================================================
    ' CLASE: GestorDisponibilidad
    ' FUNCIÓN:
    ' Administrar la disponibilidad horaria de los docentes.
    '
    ' Esta clase permite:
    ' - Registrar disponibilidades
    ' - Consultar disponibilidades
    ' - Validar horarios disponibles
    ' - Eliminar disponibilidades
    '
    ' REGLA DEL SISTEMA:
    ' No se permiten clases entre 12:00 PM y 2:00 PM.
    ' ==================================================
    Public Class GestorDisponibilidad

        ' Lista que almacena las disponibilidades registradas.
        Private ReadOnly listaDisponibilidades As List(Of DisponibilidadDocente)

        ' ==================================================
        ' CONSTRUCTOR
        ' Inicializa la lista de disponibilidades.
        ' ==================================================
        Public Sub New()

            listaDisponibilidades = New List(Of DisponibilidadDocente)

        End Sub

        ' ==================================================
        ' MÉTODO: AgregarDisponibilidad
        ' FUNCIÓN:
        ' Registra una nueva disponibilidad para un docente.
        ' ==================================================
        Public Sub AgregarDisponibilidad(disponibilidad As DisponibilidadDocente)

            ' Valida que el objeto no sea nulo.
            If disponibilidad Is Nothing Then
                Throw New Exception("La disponibilidad no puede ser nula.")
            End If

            ' ==================================================
            ' REGLA ACADÉMICA
            ' No se permiten horarios entre 12:00 PM y 2:00 PM.
            ' ==================================================

            Dim horaRestriccionInicio As New TimeSpan(12, 0, 0)
            Dim horaRestriccionFin As New TimeSpan(14, 0, 0)

            ' Valida si la disponibilidad cruza el horario restringido.
            If disponibilidad.HoraInicio < horaRestriccionFin AndAlso
               disponibilidad.HoraFin > horaRestriccionInicio Then

                Throw New Exception("No se permiten clases entre las 12:00 PM y las 2:00 PM.")

            End If

            ' Agrega la disponibilidad a la lista.
            listaDisponibilidades.Add(disponibilidad)

        End Sub

        ' ==================================================
        ' MÉTODO: ObtenerDisponibilidades
        ' FUNCIÓN:
        ' Retorna todas las disponibilidades registradas.
        ' ==================================================
        Public Function ObtenerDisponibilidades() As List(Of DisponibilidadDocente)

            Return listaDisponibilidades

        End Function

        ' ==================================================
        ' MÉTODO: ObtenerDisponibilidadesPorDocente
        ' FUNCIÓN:
        ' Obtiene todas las disponibilidades de un docente.
        ' ==================================================
        Public Function ObtenerDisponibilidadesPorDocente(idDocente As Integer) As List(Of DisponibilidadDocente)

            Return listaDisponibilidades.
                Where(Function(d) d.Docente.Id = idDocente).
                ToList()

        End Function

        ' ==================================================
        ' MÉTODO: DocenteDisponible
        ' FUNCIÓN:
        ' Verifica si un docente tiene disponibilidad
        ' en un día y horario específico.
        ' ==================================================
        Public Function DocenteDisponible(idDocente As Integer,
                                          dia As String,
                                          horaInicio As TimeSpan,
                                          horaFin As TimeSpan) As Boolean

            ' ==================================================
            ' VALIDACIÓN:
            ' No permitir clases entre 12 PM y 2 PM.
            ' ==================================================

            Dim horaRestriccionInicio As New TimeSpan(12, 0, 0)
            Dim horaRestriccionFin As New TimeSpan(14, 0, 0)

            If horaInicio < horaRestriccionFin AndAlso
               horaFin > horaRestriccionInicio Then

                Return False

            End If

            ' Busca si existe una disponibilidad válida.
            Dim disponible = listaDisponibilidades.Any(Function(d)

                                                           Return d.Docente.Id = idDocente AndAlso
                                                                  d.Dia = dia AndAlso
                                                                  horaInicio >= d.HoraInicio AndAlso
                                                                  horaFin <= d.HoraFin

                                                       End Function)

            Return disponible

        End Function

        ' ==================================================
        ' MÉTODO: EliminarDisponibilidad
        ' FUNCIÓN:
        ' Elimina una disponibilidad registrada.
        ' ==================================================
        Public Sub EliminarDisponibilidad(disponibilidad As DisponibilidadDocente)

            ' Valida que exista.
            If disponibilidad Is Nothing Then
                Throw New Exception("La disponibilidad no existe.")
            End If

            ' Elimina la disponibilidad.
            listaDisponibilidades.Remove(disponibilidad)

        End Sub

    End Class

End Namespace