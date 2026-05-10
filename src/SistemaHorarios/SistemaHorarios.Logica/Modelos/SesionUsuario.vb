' Representa los datos básicos de la sesión activa del usuario.
Public Class SesionUsuario
    ' Guarda el nombre del usuario que inició sesión.
    Public Property Usuario As String

    ' Indica si actualmente existe una sesión activa.
    Public Property Activa As Boolean

    ' Guarda el mensaje relacionado con el estado de la sesión.
    Public Property Mensaje As String

    ' Inicializa la sesión con valores por defecto.
    Public Sub New()
        Usuario = ""
        Activa = False
        Mensaje = ""
    End Sub

    ' Inicializa la sesión con datos específicos.
    Public Sub New(usuario As String, activa As Boolean, mensaje As String)
        Me.Usuario = usuario
        Me.Activa = activa
        Me.Mensaje = mensaje
    End Sub

End Class
