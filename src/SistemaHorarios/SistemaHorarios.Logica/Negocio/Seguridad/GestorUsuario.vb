' Gestiona la lógica básica relacionada con los usuarios del sistema.
Public Class GestorUsuario

    ' Busca un usuario por su identificador dentro de una lista recibida.
    Public Function ObtenerUsuarioPorId(usuarios As List(Of Usuario), idUsuario As Integer) As Usuario

        If usuarios Is Nothing OrElse usuarios.Count = 0 Then
            Return Nothing
        End If

        For Each usuario As Usuario In usuarios
            If usuario.IdUsuario = idUsuario Then
                Return usuario
            End If
        Next

        Return Nothing

    End Function

    ' Busca un usuario por su nombre de usuario dentro de una lista recibida.
    Public Function ObtenerUsuarioPorNombre(usuarios As List(Of Usuario), nombreUsuario As String) As Usuario

        If usuarios Is Nothing OrElse usuarios.Count = 0 Then
            Return Nothing
        End If

        If String.IsNullOrWhiteSpace(nombreUsuario) Then
            Return Nothing
        End If

        For Each usuario As Usuario In usuarios
            If String.Equals(usuario.NombreUsuario, nombreUsuario.Trim(), StringComparison.OrdinalIgnoreCase) Then
                Return usuario
            End If
        Next

        Return Nothing

    End Function

    ' Verifica si existe un usuario por su identificador.
    Public Function ExisteUsuarioPorId(usuarios As List(Of Usuario), idUsuario As Integer) As Boolean

        Dim usuario As Usuario = ObtenerUsuarioPorId(usuarios, idUsuario)

        If usuario Is Nothing Then
            Return False
        End If

        Return True

    End Function

    ' Verifica si existe un usuario por su nombre de usuario.
    Public Function ExisteUsuarioPorNombre(usuarios As List(Of Usuario), nombreUsuario As String) As Boolean

        Dim usuario As Usuario = ObtenerUsuarioPorNombre(usuarios, nombreUsuario)

        If usuario Is Nothing Then
            Return False
        End If

        Return True

    End Function

    ' Verifica si un usuario se encuentra activo usando su identificador.
    Public Function UsuarioEstaActivoPorId(usuarios As List(Of Usuario), idUsuario As Integer) As Boolean

        Dim usuario As Usuario = ObtenerUsuarioPorId(usuarios, idUsuario)

        If usuario Is Nothing Then
            Return False
        End If

        Return usuario.Activo

    End Function

    ' Verifica si un usuario se encuentra activo usando su nombre de usuario.
    Public Function UsuarioEstaActivoPorNombre(usuarios As List(Of Usuario), nombreUsuario As String) As Boolean

        Dim usuario As Usuario = ObtenerUsuarioPorNombre(usuarios, nombreUsuario)

        If usuario Is Nothing Then
            Return False
        End If

        Return usuario.Activo

    End Function

    ' Obtiene el rol asignado a un usuario usando su identificador.
    Public Function ObtenerRolUsuarioPorId(usuarios As List(Of Usuario), idUsuario As Integer) As Rol

        Dim usuario As Usuario = ObtenerUsuarioPorId(usuarios, idUsuario)

        If usuario Is Nothing Then
            Return Nothing
        End If

        Return usuario.Rol

    End Function

    ' Obtiene el rol asignado a un usuario usando su nombre de usuario.
    Public Function ObtenerRolUsuarioPorNombre(usuarios As List(Of Usuario), nombreUsuario As String) As Rol

        Dim usuario As Usuario = ObtenerUsuarioPorNombre(usuarios, nombreUsuario)

        If usuario Is Nothing Then
            Return Nothing
        End If

        Return usuario.Rol

    End Function

End Class