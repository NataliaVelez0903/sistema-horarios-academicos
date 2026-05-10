Public Class TopBar

    Public Event UsuarioClick()

    Public Sub ConfigurarUsuario(nombre As String)
        lblUsuario.Text = nombre
    End Sub

    Private Sub panelUsuario_Click(sender As Object, e As EventArgs) Handles pnlUsuario.Click, picUsuario.Click, lblUsuario.Click, picFlecha.Click
        RaiseEvent UsuarioClick()
    End Sub

End Class
