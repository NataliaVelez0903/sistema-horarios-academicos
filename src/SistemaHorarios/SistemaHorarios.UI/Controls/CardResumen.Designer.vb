<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardResumen
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
        Me.picIcono = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        CType(Me.picIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIcono
        '
        Me.picIcono.BackColor = System.Drawing.Color.Transparent
        Me.picIcono.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcUsuaCircul
        Me.picIcono.Location = New System.Drawing.Point(8, 13)
        Me.picIcono.Name = "picIcono"
        Me.picIcono.Size = New System.Drawing.Size(82, 106)
        Me.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIcono.TabIndex = 0
        Me.picIcono.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(129, 13)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(198, 55)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Docentes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValor
        '
        Me.lblValor.BackColor = System.Drawing.Color.Transparent
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(169, 68)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(110, 47)
        Me.lblValor.TabIndex = 2
        Me.lblValor.Text = "50"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.picIcono)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "CardResumen"
        Me.Size = New System.Drawing.Size(357, 154)
        CType(Me.picIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picIcono As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblValor As Label
End Class
