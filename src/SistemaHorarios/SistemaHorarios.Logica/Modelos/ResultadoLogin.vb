'Clase que representa la respuesta de un intento de inicio de sesión, indicando si fue exitoso, un mensaje descriptivo y el nombre del usuario.
Public Class ResultadoLogin


    Public Property Exitoso As Boolean
    Public Property Mensaje As String
    Public Property Usuario As String

    Public Sub New()
        Exitoso = False
        Mensaje = ""
        Usuario = ""
    End Sub

End Class
