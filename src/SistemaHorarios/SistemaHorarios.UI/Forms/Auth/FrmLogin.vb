Imports System.Drawing

Public Class FrmLogin

    Private Const PLACEHOLDER_USUARIO As String = "Ingresa tu usuario"
    Private Const PLACEHOLDER_CONTRASENA As String = "Ingresa tu contraseña"

    ' Datos temporales solo para probar el frontend
    Private Const USUARIO_VALIDO As String = "admin"
    Private Const CONTRASENA_VALIDA As String = "1234"

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarPlaceholders()
        OcultarErrores()
    End Sub

    Private Sub ConfigurarPlaceholders()
        txtUsuario.Text = PLACEHOLDER_USUARIO
        txtUsuario.ForeColor = Color.Gray

        txtContrasena.Text = PLACEHOLDER_CONTRASENA
        txtContrasena.ForeColor = Color.Gray
        txtContrasena.UseSystemPasswordChar = False
    End Sub

    Private Sub OcultarErrores()
        lblErrorUsuario.Text = "El usuario es obligatorio."
        lblErrorUsuario.Visible = False

        lblErrorLogin.Text = ""
        lblErrorLogin.Visible = False
    End Sub

    Private Sub MostrarErrorLogin(mensaje As String)
        lblErrorLogin.Text = mensaje
        lblErrorLogin.Visible = True
    End Sub

    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If txtUsuario.Text = PLACEHOLDER_USUARIO Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text.Trim() = "" Then
            txtUsuario.Text = PLACEHOLDER_USUARIO
            txtUsuario.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtContrasena_Enter(sender As Object, e As EventArgs) Handles txtContrasena.Enter
        If txtContrasena.Text = PLACEHOLDER_CONTRASENA Then
            txtContrasena.Text = ""
            txtContrasena.ForeColor = Color.Black
            txtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtContrasena_Leave(sender As Object, e As EventArgs) Handles txtContrasena.Leave
        If txtContrasena.Text.Trim() = "" Then
            txtContrasena.Text = PLACEHOLDER_CONTRASENA
            txtContrasena.ForeColor = Color.Gray
            txtContrasena.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        OcultarErrores()

        If txtUsuario.Text.Trim() = "" OrElse txtUsuario.Text = PLACEHOLDER_USUARIO Then
            lblErrorUsuario.Visible = True
            txtUsuario.Focus()
            Return
        End If

        If txtContrasena.Text.Trim() = "" OrElse txtContrasena.Text = PLACEHOLDER_CONTRASENA Then
            MostrarErrorLogin("La contraseña es obligatoria.")
            txtContrasena.Focus()
            Return
        End If

        If txtUsuario.Text.Trim() <> USUARIO_VALIDO OrElse txtContrasena.Text.Trim() <> CONTRASENA_VALIDA Then
            MostrarErrorLogin("Usuario o contraseña incorrectos.")
            txtContrasena.Focus()
            Return
        End If

        Dim sesion As New UsuarioSesion With {
            .Id = 1,
            .Nombre = "Administrador",
            .Correo = "administrador@autonoma.edu.co",
            .Rol = "Coordinador"
        }

        Dim principal As New FrmPrincipal(sesion)
        principal.Show()
        Me.Hide()
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub PicFondo_Click(sender As Object, e As EventArgs) Handles picFondo.Click

    End Sub

    Private Sub LnkOlvidoContrasena_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOlvidoContrasena.LinkClicked

    End Sub

    Private Sub LblContrasena_Click(sender As Object, e As EventArgs) Handles lblContrasena.Click

    End Sub

    Private Sub LblErrorUsuario_Click(sender As Object, e As EventArgs) Handles lblErrorUsuario.Click

    End Sub

End Class