Public Class FrmCambiarContrasenaDialog

    Private Sub FrmCambiarContrasenaDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblError.Visible = False
        lblError.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        lblError.Visible = False
        lblError.Text = ""

        If txtContrasenaActual.Text.Trim() = "" Then
            MostrarError("La contraseña actual es obligatoria.")
            txtContrasenaActual.Focus()
            Return
        End If

        If txtConfirmarContrasena.Text.Trim() = "" Then
            MostrarError("La nueva contraseña es obligatoria.")
            txtConfirmarContrasena.Focus()
            Return
        End If

        If txtConfirmarContrasena.Text.Trim() = "" Then
            MostrarError("Debe confirmar la nueva contraseña.")
            txtConfirmarContrasena.Focus()
            Return
        End If

        If txtConfirmarContrasena.Text <> txtConfirmarContrasena.Text Then
            MostrarError("Las contraseñas no coinciden.")
            txtConfirmarContrasena.Focus()
            Return
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MostrarError(mensaje As String)
        lblError.Text = mensaje
        lblError.Visible = True
    End Sub

End Class