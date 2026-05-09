Imports SistemaHorarios.Logica.Entidades

Namespace Negocio.Docentes

    ' ==================================================
    ' CLASE: ValidadorDocente
    ' FUNCIÓN:
    ' Contiene las validaciones relacionadas con los docentes.
    ' ==================================================
    Public Class ValidadorDocente

        ' ==================================================
        ' MÉTODO: DocenteActivo
        ' FUNCIÓN:
        ' Verifica si un docente se encuentra activo.
        '
        ' RETORNA:
        ' True  -> Si el docente está activo.
        ' False -> Si el docente está inactivo.
        ' ==================================================
        Public Function DocenteActivo(docente As Docente) As Boolean

            ' Valida que el objeto docente no sea nulo.
            If docente Is Nothing Then
                Throw New Exception("El docente no puede ser nulo.")
            End If

            ' Retorna el estado actual del docente.
            Return docente.Estado

        End Function

    End Class

End Namespace