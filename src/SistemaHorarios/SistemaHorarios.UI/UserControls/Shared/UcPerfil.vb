Public Class UcPerfil

    Public Event CerrarSesionClick()
    Public Event EditarPerfilClick()
    Public Event CambiarContrasenaClick()

    Private Sub UcPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarContenido()
    End Sub

    Private Sub UcPerfil_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CentrarContenido()
    End Sub

    Private Sub CentrarContenido()
        pnlFondo.Left = (Me.ClientSize.Width - pnlFondo.Width) \ 2
    End Sub

    Public Sub Configurar(usuario As UsuarioSesion)
        If usuario Is Nothing Then
            Return
        End If

        lblNombreValor.Text = usuario.Nombre
        lblCorreoValor.Text = usuario.Correo
        lblRolValor.Text = usuario.Rol

        lblTelefonoValor.Text = "3456789012"
        lblFacultadValor.Text = "Facultad de Ingeniería / Ingeniería de Sistemas"
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        RaiseEvent CerrarSesionClick()
    End Sub

    Private Sub btnEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
        RaiseEvent EditarPerfilClick()
    End Sub

    Private Sub btnCambiarContrasena_Click(sender As Object, e As EventArgs) Handles btnCambiarContrasena.Click
        RaiseEvent CambiarContrasenaClick()
    End Sub

    Private Sub btnCambiarFoto_Click(sender As Object, e As EventArgs) Handles btnCambiarFoto.Click
        MessageBox.Show("Cambiar foto")
    End Sub

End Class