<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopBar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlUsuario = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.picUsuario = New System.Windows.Forms.PictureBox()
        Me.picFlecha = New System.Windows.Forms.PictureBox()
        Me.pnlUsuario.SuspendLayout()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(24, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(535, 36)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Sistema de gestión de horarios académicos"
        '
        'pnlUsuario
        '
        Me.pnlUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUsuario.AutoSize = True
        Me.pnlUsuario.Controls.Add(Me.lblUsuario)
        Me.pnlUsuario.Controls.Add(Me.picUsuario)
        Me.pnlUsuario.Controls.Add(Me.picFlecha)
        Me.pnlUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlUsuario.Location = New System.Drawing.Point(187, 11)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Size = New System.Drawing.Size(300, 54)
        Me.pnlUsuario.TabIndex = 2
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(58, 12)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(170, 24)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Administrador"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picUsuario
        '
        Me.picUsuario.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcUsuaCircul
        Me.picUsuario.Location = New System.Drawing.Point(8, 7)
        Me.picUsuario.Name = "picUsuario"
        Me.picUsuario.Size = New System.Drawing.Size(45, 44)
        Me.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUsuario.TabIndex = 1
        Me.picUsuario.TabStop = False
        '
        'picFlecha
        '
        Me.picFlecha.Image = Global.SistemaHorarios.UI.My.Resources.Resources.flecha
        Me.picFlecha.Location = New System.Drawing.Point(245, 17)
        Me.picFlecha.Name = "picFlecha"
        Me.picFlecha.Size = New System.Drawing.Size(27, 24)
        Me.picFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFlecha.TabIndex = 0
        Me.picFlecha.TabStop = False
        '
        'TopBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlUsuario)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "TopBar"
        Me.Size = New System.Drawing.Size(1066, 72)
        Me.pnlUsuario.ResumeLayout(False)
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlUsuario As Panel
    Friend WithEvents picFlecha As PictureBox
    Friend WithEvents picUsuario As PictureBox
    Friend WithEvents lblUsuario As Label
End Class
