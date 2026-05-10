<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Sidebar1 = New SistemaHorarios.UI.Sidebar()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.TopBar1 = New SistemaHorarios.UI.TopBar()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.MenuUsuario1 = New SistemaHorarios.UI.MenuUsuario()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.AutoScroll = True
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.Sidebar1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 768)
        Me.pnlSidebar.TabIndex = 0
        '
        'Sidebar1
        '
        Me.Sidebar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Sidebar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sidebar1.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar1.Name = "Sidebar1"
        Me.Sidebar1.Size = New System.Drawing.Size(300, 768)
        Me.Sidebar1.TabIndex = 0
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.White
        Me.pnlTopBar.Controls.Add(Me.TopBar1)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(300, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1066, 72)
        Me.pnlTopBar.TabIndex = 1
        '
        'TopBar1
        '
        Me.TopBar1.BackColor = System.Drawing.Color.White
        Me.TopBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopBar1.Location = New System.Drawing.Point(0, 0)
        Me.TopBar1.Name = "TopBar1"
        Me.TopBar1.Size = New System.Drawing.Size(1066, 72)
        Me.TopBar1.TabIndex = 0
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(300, 72)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1066, 696)
        Me.pnlContenido.TabIndex = 2
        '
        'MenuUsuario1
        '
        Me.MenuUsuario1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuUsuario1.BackColor = System.Drawing.Color.White
        Me.MenuUsuario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MenuUsuario1.Location = New System.Drawing.Point(1022, 80)
        Me.MenuUsuario1.Name = "MenuUsuario1"
        Me.MenuUsuario1.Size = New System.Drawing.Size(320, 205)
        Me.MenuUsuario1.TabIndex = 3
        Me.MenuUsuario1.Visible = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.MenuUsuario1)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de horarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents pnlContenido As System.Windows.Forms.Panel
    Friend WithEvents Sidebar1 As Global.SistemaHorarios.UI.Sidebar
    Friend WithEvents TopBar1 As Global.SistemaHorarios.UI.TopBar
    Friend WithEvents MenuUsuario1 As Global.SistemaHorarios.UI.MenuUsuario
End Class
