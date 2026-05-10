Public Class UsuarioSesion

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Correo As String
    Public Property Rol As String

    Public ReadOnly Property EsAdministrador As Boolean
        Get
            Return String.Equals(Rol, "Administrador", StringComparison.OrdinalIgnoreCase)
        End Get
    End Property

    Public ReadOnly Property EsCoordinador As Boolean
        Get
            Return String.Equals(Rol, "Coordinador", StringComparison.OrdinalIgnoreCase)
        End Get
    End Property

End Class
