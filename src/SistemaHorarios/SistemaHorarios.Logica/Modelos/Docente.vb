Namespace Modelos

    ' Representa un docente dentro del sistema.
    ' Un docente puede dictar una o varias materias.
    Public Class Docente

        ' Identificador único del docente.
        ' Este campo es autoincremental en la base de datos.
        Public Property Id As Integer

        ' Número de identificación del docente.
        ' Campo obligatorio (NO NULO).
        Public Property Identificacion As String

        ' Nombre completo del docente.
        ' Permite almacenar una cadena de longitud variable.
        Public Property Nombre As String

        ' Correo electrónico del docente.
        ' Debe ser único y obligatorio (NO NULO).
        Public Property Correo As String

        ' Estado del docente.
        ' True  = Activo.
        ' False = Inactivo.
        ' Campo obligatorio (NO NULO).
        Public Property Estado As Boolean

    End Class

End Namespace