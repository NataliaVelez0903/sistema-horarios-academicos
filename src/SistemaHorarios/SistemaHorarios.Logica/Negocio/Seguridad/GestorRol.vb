Public Class GestorRol

    ' Busca un rol por su identificador dentro de una lista recibida.
    Public Function ObtenerRolPorId(roles As List(Of Rol), idRol As Integer) As Rol

        If roles Is Nothing OrElse roles.Count = 0 Then
            Return Nothing
        End If

        For Each rol As Rol In roles
            If rol.IdRol = idRol Then
                Return rol
            End If
        Next

        Return Nothing

    End Function

    ' Busca un rol por su nombre dentro de una lista recibida.
    Public Function ObtenerRolPorNombre(roles As List(Of Rol), nombreRol As String) As Rol

        If roles Is Nothing OrElse roles.Count = 0 Then
            Return Nothing
        End If

        If String.IsNullOrWhiteSpace(nombreRol) Then
            Return Nothing
        End If

        For Each rol As Rol In roles
            If String.Equals(rol.Nombre, nombreRol.Trim(), StringComparison.OrdinalIgnoreCase) Then
                Return rol
            End If
        Next

        Return Nothing

    End Function

    ' Verifica si existe un rol por su identificador.
    Public Function ExisteRolPorId(roles As List(Of Rol), idRol As Integer) As Boolean

        Dim rol As Rol = ObtenerRolPorId(roles, idRol)

        If rol Is Nothing Then
            Return False
        End If

        Return True

    End Function

    ' Verifica si existe un rol por su nombre.
    Public Function ExisteRolPorNombre(roles As List(Of Rol), nombreRol As String) As Boolean

        Dim rol As Rol = ObtenerRolPorNombre(roles, nombreRol)

        If rol Is Nothing Then
            Return False
        End If

        Return True

    End Function

    ' Verifica si un rol se encuentra activo usando su identificador.
    Public Function RolEstaActivoPorId(roles As List(Of Rol), idRol As Integer) As Boolean

        Dim rol As Rol = ObtenerRolPorId(roles, idRol)

        If rol Is Nothing Then
            Return False
        End If

        Return rol.Activo

    End Function

    ' Verifica si un rol se encuentra activo usando su nombre.
    Public Function RolEstaActivoPorNombre(roles As List(Of Rol), nombreRol As String) As Boolean

        Dim rol As Rol = ObtenerRolPorNombre(roles, nombreRol)

        If rol Is Nothing Then
            Return False
        End If

        Return rol.Activo

    End Function

End Class

