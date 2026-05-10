Public Class CardResumen
    Public Sub Configurar(titulo As String, valor As String, icono As Image)
        lblTitulo.Text = titulo
        lblValor.Text = valor
        picIcono.Image = icono
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub
End Class
