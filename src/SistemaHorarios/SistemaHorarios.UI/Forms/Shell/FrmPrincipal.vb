Public Class FrmPrincipal

    Private ReadOnly _sesion As UsuarioSesion

    Public Sub New()
        InitializeComponent()

        _sesion = New UsuarioSesion With {
            .Id = 1,
            .Nombre = "Administrador",
            .Correo = "administrador@autonoma.edu.co",
            .Rol = "Administrador"
        }
    End Sub

    Public Sub New(sesion As UsuarioSesion)
        InitializeComponent()
        _sesion = sesion
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then
            Return
        End If

        If TopBar1 Is Nothing OrElse MenuUsuario1 Is Nothing OrElse Sidebar1 Is Nothing Then
            Return
        End If

        MenuUsuario1.Visible = False
        UbicarMenuUsuario()
        ConfigurarSesion()

        AddHandler TopBar1.UsuarioClick, AddressOf MostrarMenuUsuario
        AddHandler MenuUsuario1.MiPerfilClick, AddressOf AbrirMiPerfil
        AddHandler MenuUsuario1.CerrarSesionClick, AddressOf CerrarSesion
    End Sub

    Private Sub ConfigurarSesion()
        If _sesion Is Nothing Then
            Return
        End If

        Sidebar1.Configurar(_sesion, "Inicio")
        TopBar1.ConfigurarUsuario(_sesion.Nombre)
        MenuUsuario1.ConfigurarUsuario(_sesion.Nombre, _sesion.Correo)
    End Sub

    Private Sub FrmPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        UbicarMenuUsuario()
    End Sub

    Private Sub MostrarMenuUsuario()
        If MenuUsuario1 Is Nothing Then
            Return
        End If

        UbicarMenuUsuario()
        MenuUsuario1.Visible = Not MenuUsuario1.Visible
        MenuUsuario1.BringToFront()
    End Sub

    Private Sub AbrirMiPerfil()
        If MenuUsuario1 IsNot Nothing Then
            MenuUsuario1.Visible = False
        End If

        Dim perfil As New UcPerfil()
        perfil.Dock = DockStyle.Fill
        perfil.Configurar(_sesion)

        AddHandler perfil.CerrarSesionClick, AddressOf CerrarSesion
        AddHandler perfil.EditarPerfilClick, AddressOf EditarPerfil
        AddHandler perfil.CambiarContrasenaClick, AddressOf CambiarContrasena

        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(perfil)
    End Sub

    Private Sub EditarPerfil()
        Using dialogo As New FrmEditarPerfilDialog()
            dialogo.CargarDatos(_sesion)
            dialogo.ShowDialog(Me)
        End Using
    End Sub

    Private Sub CambiarContrasena()
        Using dialogo As New FrmCambiarContrasenaDialog()
            dialogo.ShowDialog(Me)
        End Using
    End Sub

    Private Sub CerrarSesion()
        If MenuUsuario1 IsNot Nothing Then
            MenuUsuario1.Visible = False
        End If

        Using dialogo As New FrmCerrarSesionDialog()
            If dialogo.ShowDialog(Me) = DialogResult.OK Then
                MostrarLogin()
                Me.Close()
            End If
        End Using
    End Sub

    Private Sub MostrarLogin()
        Dim login As FrmLogin = Nothing

        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmLogin Then
                login = DirectCast(frm, FrmLogin)
                Exit For
            End If
        Next

        If login Is Nothing Then
            login = New FrmLogin()
        End If

        login.Show()
        login.WindowState = FormWindowState.Maximized
        login.BringToFront()
        login.Activate()
    End Sub

    Private Sub UbicarMenuUsuario()
        If MenuUsuario1 Is Nothing OrElse pnlTopBar Is Nothing Then
            Return
        End If

        MenuUsuario1.Location = New Point(Me.ClientSize.Width - MenuUsuario1.Width - 24, pnlTopBar.Bottom + 8)
        MenuUsuario1.BringToFront()
    End Sub

End Class