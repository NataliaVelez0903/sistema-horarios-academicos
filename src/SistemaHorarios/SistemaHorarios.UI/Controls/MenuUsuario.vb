Public Class MenuUsuario

    Public Event MiPerfilClick()
    Public Event CerrarSesionClick()

    Public Sub ConfigurarUsuario(nombre As String, correo As String)
        lblNombreMenu.Text = nombre
        lblCorreoMenu.Text = correo
    End Sub

    Private Sub btnMiPerfil_Click(sender As Object, e As EventArgs) Handles btnMiPerfil.Click
        RaiseEvent MiPerfilClick()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        RaiseEvent CerrarSesionClick()
    End Sub

End Class
