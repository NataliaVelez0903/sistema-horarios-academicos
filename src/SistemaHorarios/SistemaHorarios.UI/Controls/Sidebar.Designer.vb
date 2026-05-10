<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sidebar
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
        Me.flpMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnPlanAcademico = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.btnDocentes = New System.Windows.Forms.Button()
        Me.btnGruposAcademicos = New System.Windows.Forms.Button()
        Me.btnCoordinadores = New System.Windows.Forms.Button()
        Me.btnHorarios = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnHistorialCambios = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.flpMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpMenu
        '
        Me.flpMenu.Controls.Add(Me.btnInicio)
        Me.flpMenu.Controls.Add(Me.btnPlanAcademico)
        Me.flpMenu.Controls.Add(Me.btnMaterias)
        Me.flpMenu.Controls.Add(Me.btnDocentes)
        Me.flpMenu.Controls.Add(Me.btnGruposAcademicos)
        Me.flpMenu.Controls.Add(Me.btnCoordinadores)
        Me.flpMenu.Controls.Add(Me.btnHorarios)
        Me.flpMenu.Controls.Add(Me.btnReportes)
        Me.flpMenu.Controls.Add(Me.btnHistorialCambios)
        Me.flpMenu.Controls.Add(Me.btnManual)
        Me.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMenu.Location = New System.Drawing.Point(0, 91)
        Me.flpMenu.Name = "flpMenu"
        Me.flpMenu.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.flpMenu.Size = New System.Drawing.Size(300, 674)
        Me.flpMenu.TabIndex = 0
        Me.flpMenu.WrapContents = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.Transparent
        Me.btnInicio.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcInicio
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(21, 3)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnInicio.Size = New System.Drawing.Size(250, 58)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "  Inicio"
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnPlanAcademico
        '
        Me.btnPlanAcademico.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnPlanAcademico.FlatAppearance.BorderSize = 0
        Me.btnPlanAcademico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPlanAcademico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPlanAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanAcademico.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanAcademico.ForeColor = System.Drawing.Color.White
        Me.btnPlanAcademico.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcPlanAca
        Me.btnPlanAcademico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlanAcademico.Location = New System.Drawing.Point(21, 67)
        Me.btnPlanAcademico.Name = "btnPlanAcademico"
        Me.btnPlanAcademico.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnPlanAcademico.Size = New System.Drawing.Size(250, 58)
        Me.btnPlanAcademico.TabIndex = 1
        Me.btnPlanAcademico.Text = "  Plan Académico"
        Me.btnPlanAcademico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlanAcademico.UseVisualStyleBackColor = False
        '
        'btnMaterias
        '
        Me.btnMaterias.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnMaterias.FlatAppearance.BorderSize = 0
        Me.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterias.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterias.ForeColor = System.Drawing.Color.White
        Me.btnMaterias.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcMaterias
        Me.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaterias.Location = New System.Drawing.Point(21, 131)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnMaterias.Size = New System.Drawing.Size(250, 58)
        Me.btnMaterias.TabIndex = 2
        Me.btnMaterias.Text = "  Materias"
        Me.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaterias.UseVisualStyleBackColor = False
        '
        'btnDocentes
        '
        Me.btnDocentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDocentes.FlatAppearance.BorderSize = 0
        Me.btnDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocentes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocentes.ForeColor = System.Drawing.Color.White
        Me.btnDocentes.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcDocentes
        Me.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocentes.Location = New System.Drawing.Point(21, 195)
        Me.btnDocentes.Name = "btnDocentes"
        Me.btnDocentes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnDocentes.Size = New System.Drawing.Size(250, 58)
        Me.btnDocentes.TabIndex = 3
        Me.btnDocentes.Text = "  Docentes"
        Me.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDocentes.UseVisualStyleBackColor = False
        '
        'btnGruposAcademicos
        '
        Me.btnGruposAcademicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnGruposAcademicos.FlatAppearance.BorderSize = 0
        Me.btnGruposAcademicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnGruposAcademicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnGruposAcademicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGruposAcademicos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGruposAcademicos.ForeColor = System.Drawing.Color.White
        Me.btnGruposAcademicos.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcGrupos
        Me.btnGruposAcademicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGruposAcademicos.Location = New System.Drawing.Point(21, 259)
        Me.btnGruposAcademicos.Name = "btnGruposAcademicos"
        Me.btnGruposAcademicos.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnGruposAcademicos.Size = New System.Drawing.Size(250, 74)
        Me.btnGruposAcademicos.TabIndex = 4
        Me.btnGruposAcademicos.Text = "  Grupos                     Académicos"
        Me.btnGruposAcademicos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnGruposAcademicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGruposAcademicos.UseVisualStyleBackColor = False
        '
        'btnCoordinadores
        '
        Me.btnCoordinadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCoordinadores.FlatAppearance.BorderSize = 0
        Me.btnCoordinadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCoordinadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCoordinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoordinadores.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoordinadores.ForeColor = System.Drawing.Color.White
        Me.btnCoordinadores.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcCoordinadores
        Me.btnCoordinadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCoordinadores.Location = New System.Drawing.Point(21, 339)
        Me.btnCoordinadores.Name = "btnCoordinadores"
        Me.btnCoordinadores.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnCoordinadores.Size = New System.Drawing.Size(250, 58)
        Me.btnCoordinadores.TabIndex = 5
        Me.btnCoordinadores.Text = "  Coordinadores"
        Me.btnCoordinadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCoordinadores.UseVisualStyleBackColor = False
        '
        'btnHorarios
        '
        Me.btnHorarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnHorarios.FlatAppearance.BorderSize = 0
        Me.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorarios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHorarios.ForeColor = System.Drawing.Color.White
        Me.btnHorarios.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcHorarios
        Me.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorarios.Location = New System.Drawing.Point(21, 403)
        Me.btnHorarios.Name = "btnHorarios"
        Me.btnHorarios.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnHorarios.Size = New System.Drawing.Size(250, 58)
        Me.btnHorarios.TabIndex = 6
        Me.btnHorarios.Text = "  Horarios"
        Me.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHorarios.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcReportes
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(21, 467)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnReportes.Size = New System.Drawing.Size(250, 58)
        Me.btnReportes.TabIndex = 7
        Me.btnReportes.Text = "  Reportes"
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnHistorialCambios
        '
        Me.btnHistorialCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnHistorialCambios.FlatAppearance.BorderSize = 0
        Me.btnHistorialCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHistorialCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHistorialCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialCambios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialCambios.ForeColor = System.Drawing.Color.White
        Me.btnHistorialCambios.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcHistorial
        Me.btnHistorialCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorialCambios.Location = New System.Drawing.Point(21, 531)
        Me.btnHistorialCambios.Name = "btnHistorialCambios"
        Me.btnHistorialCambios.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnHistorialCambios.Size = New System.Drawing.Size(250, 75)
        Me.btnHistorialCambios.TabIndex = 8
        Me.btnHistorialCambios.Text = "  Historial de             cambios"
        Me.btnHistorialCambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorialCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistorialCambios.UseVisualStyleBackColor = False
        '
        'btnManual
        '
        Me.btnManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnManual.FlatAppearance.BorderSize = 0
        Me.btnManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.ForeColor = System.Drawing.Color.White
        Me.btnManual.Image = Global.SistemaHorarios.UI.My.Resources.Resources.IcManual
        Me.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManual.Location = New System.Drawing.Point(21, 612)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnManual.Size = New System.Drawing.Size(250, 58)
        Me.btnManual.TabIndex = 9
        Me.btnManual.Text = "  Manual"
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManual.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.SistemaHorarios.UI.My.Resources.Resources.LogoU
        Me.PictureBox1.Location = New System.Drawing.Point(80, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Sidebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.flpMenu)
        Me.Name = "Sidebar"
        Me.Size = New System.Drawing.Size(300, 768)
        Me.flpMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpMenu As FlowLayoutPanel
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnPlanAcademico As Button
    Friend WithEvents btnMaterias As Button
    Friend WithEvents btnDocentes As Button
    Friend WithEvents btnGruposAcademicos As Button
    Friend WithEvents btnCoordinadores As Button
    Friend WithEvents btnHorarios As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnHistorialCambios As Button
    Friend WithEvents btnManual As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
