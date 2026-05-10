Imports System.Drawing

Public Class FrmEditarPerfilDialog

    Public Sub CargarDatos(usuario As UsuarioSesion)
        If usuario Is Nothing Then
            Return
        End If
        txtNombre.Text = "Administrador"
        txtCorreo.Text = usuario.Correo
        txtTelefono.Text = "3456789012"
        txtFacultadPrograma.Text = "Facultad de Ingeniería / Ingeniería de Sistemas"

        txtCorreo.ReadOnly = True
        txtCorreo.TabStop = False
        txtCorreo.BackColor = Color.White
        txtCorreo.ForeColor = Color.Gray
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class