<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picFondo = New System.Windows.Forms.PictureBox()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.chkMantenerSesion = New System.Windows.Forms.CheckBox()
        Me.lnkOlvidoContrasena = New System.Windows.Forms.LinkLabel()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblErrorUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblErrorLogin = New System.Windows.Forms.Label()
        CType(Me.picFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFondo
        '
        Me.picFondo.Image = Global.SistemaHorarios.UI.My.Resources.Resources.ImgCupula
        Me.picFondo.Location = New System.Drawing.Point(-95, 104)
        Me.picFondo.Name = "picFondo"
        Me.picFondo.Size = New System.Drawing.Size(1410, 891)
        Me.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFondo.TabIndex = 0
        Me.picFondo.TabStop = False
        '
        'pnlLogin
        '
        Me.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogin.Controls.Add(Me.lblErrorLogin)
        Me.pnlLogin.Controls.Add(Me.btnIniciarSesion)
        Me.pnlLogin.Controls.Add(Me.chkMantenerSesion)
        Me.pnlLogin.Controls.Add(Me.lnkOlvidoContrasena)
        Me.pnlLogin.Controls.Add(Me.txtContrasena)
        Me.pnlLogin.Controls.Add(Me.lblContrasena)
        Me.pnlLogin.Controls.Add(Me.lblErrorUsuario)
        Me.pnlLogin.Controls.Add(Me.txtUsuario)
        Me.pnlLogin.Controls.Add(Me.lblUsuario)
        Me.pnlLogin.Controls.Add(Me.lblSubtitulo)
        Me.pnlLogin.Controls.Add(Me.lblTitulo)
        Me.pnlLogin.Controls.Add(Me.picLogo)
        Me.pnlLogin.Location = New System.Drawing.Point(854, 76)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(482, 593)
        Me.pnlLogin.TabIndex = 1
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnIniciarSesion.FlatAppearance.BorderSize = 0
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btnIniciarSesion.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcIniciar
        Me.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciarSesion.Location = New System.Drawing.Point(39, 478)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(395, 54)
        Me.btnIniciarSesion.TabIndex = 11
        Me.btnIniciarSesion.Text = "Iniciar sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'chkMantenerSesion
        '
        Me.chkMantenerSesion.AutoSize = True
        Me.chkMantenerSesion.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMantenerSesion.Location = New System.Drawing.Point(39, 436)
        Me.chkMantenerSesion.Name = "chkMantenerSesion"
        Me.chkMantenerSesion.Size = New System.Drawing.Size(208, 25)
        Me.chkMantenerSesion.TabIndex = 10
        Me.chkMantenerSesion.Text = "Mantener sesión iniciada"
        Me.chkMantenerSesion.UseVisualStyleBackColor = True
        '
        'lnkOlvidoContrasena
        '
        Me.lnkOlvidoContrasena.AutoSize = True
        Me.lnkOlvidoContrasena.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkOlvidoContrasena.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lnkOlvidoContrasena.Location = New System.Drawing.Point(35, 392)
        Me.lnkOlvidoContrasena.Name = "lnkOlvidoContrasena"
        Me.lnkOlvidoContrasena.Size = New System.Drawing.Size(187, 21)
        Me.lnkOlvidoContrasena.TabIndex = 9
        Me.lnkOlvidoContrasena.TabStop = True
        Me.lnkOlvidoContrasena.Text = "¿Olvidaste tu contraseña?"
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(37, 327)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(397, 31)
        Me.txtContrasena.TabIndex = 8
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(32, 296)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(118, 28)
        Me.lblContrasena.TabIndex = 7
        Me.lblContrasena.Text = "Contraseña"
        '
        'lblErrorUsuario
        '
        Me.lblErrorUsuario.AutoSize = True
        Me.lblErrorUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblErrorUsuario.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.lblErrorUsuario.Location = New System.Drawing.Point(35, 275)
        Me.lblErrorUsuario.Name = "lblErrorUsuario"
        Me.lblErrorUsuario.Size = New System.Drawing.Size(180, 21)
        Me.lblErrorUsuario.TabIndex = 6
        Me.lblErrorUsuario.Text = "El usuario es obligatorio."
        Me.lblErrorUsuario.Visible = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(37, 236)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(395, 31)
        Me.txtUsuario.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(34, 205)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(84, 28)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(96, 172)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(309, 21)
        Me.lblSubtitulo.TabIndex = 2
        Me.lblSubtitulo.Text = "Sistema de gestión de horarios académicos"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(114, 118)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(267, 54)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Iniciar sesión"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.Image = Global.SistemaHorarios.UI.My.Resources.Resources.LogoU
        Me.picLogo.Location = New System.Drawing.Point(175, -1)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(188, 128)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblErrorLogin
        '
        Me.lblErrorLogin.AutoSize = True
        Me.lblErrorLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblErrorLogin.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.lblErrorLogin.Location = New System.Drawing.Point(35, 361)
        Me.lblErrorLogin.Name = "lblErrorLogin"
        Me.lblErrorLogin.Size = New System.Drawing.Size(0, 21)
        Me.lblErrorLogin.TabIndex = 12
        Me.lblErrorLogin.Visible = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.picFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picFondo As PictureBox
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblErrorUsuario As Label
    Friend WithEvents lnkOlvidoContrasena As LinkLabel
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents chkMantenerSesion As CheckBox
    Friend WithEvents lblErrorLogin As Label
End Class
