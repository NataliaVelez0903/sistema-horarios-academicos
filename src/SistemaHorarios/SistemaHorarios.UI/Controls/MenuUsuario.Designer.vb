<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNombreMenu = New System.Windows.Forms.Label()
        Me.lblCorreoMenu = New System.Windows.Forms.Label()
        Me.panelLinea = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnMiPerfil = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreMenu
        '
        Me.lblNombreMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMenu.Location = New System.Drawing.Point(78, 18)
        Me.lblNombreMenu.Name = "lblNombreMenu"
        Me.lblNombreMenu.Size = New System.Drawing.Size(230, 24)
        Me.lblNombreMenu.TabIndex = 1
        Me.lblNombreMenu.Text = "Administrador"
        '
        'lblCorreoMenu
        '
        Me.lblCorreoMenu.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoMenu.Location = New System.Drawing.Point(78, 42)
        Me.lblCorreoMenu.Name = "lblCorreoMenu"
        Me.lblCorreoMenu.Size = New System.Drawing.Size(244, 22)
        Me.lblCorreoMenu.TabIndex = 2
        Me.lblCorreoMenu.Text = "administrador@autonoma.edu.co"
        '
        'panelLinea
        '
        Me.panelLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.panelLinea.Location = New System.Drawing.Point(18, 83)
        Me.panelLinea.Name = "panelLinea"
        Me.panelLinea.Size = New System.Drawing.Size(304, 1)
        Me.panelLinea.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(18, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 1)
        Me.Panel1.TabIndex = 4
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnCerrarSesion.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcCerrarsesion
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(18, 156)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnCerrarSesion.Size = New System.Drawing.Size(304, 47)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnMiPerfil
        '
        Me.btnMiPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMiPerfil.FlatAppearance.BorderSize = 0
        Me.btnMiPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnMiPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiPerfil.ForeColor = System.Drawing.Color.Black
        Me.btnMiPerfil.Image = Global.SistemaHorarios.UI.My.Resources.Resources.OpcUsua
        Me.btnMiPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMiPerfil.Location = New System.Drawing.Point(18, 90)
        Me.btnMiPerfil.Name = "btnMiPerfil"
        Me.btnMiPerfil.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnMiPerfil.Size = New System.Drawing.Size(304, 53)
        Me.btnMiPerfil.TabIndex = 4
        Me.btnMiPerfil.Text = "Mi perfil"
        Me.btnMiPerfil.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcUsuario
        Me.PictureBox1.Location = New System.Drawing.Point(18, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnMiPerfil)
        Me.Controls.Add(Me.panelLinea)
        Me.Controls.Add(Me.lblCorreoMenu)
        Me.Controls.Add(Me.lblNombreMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuUsuario"
        Me.Size = New System.Drawing.Size(351, 230)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNombreMenu As Label
    Friend WithEvents lblCorreoMenu As Label
    Friend WithEvents panelLinea As Panel
    Friend WithEvents btnMiPerfil As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Panel1 As Panel
End Class
