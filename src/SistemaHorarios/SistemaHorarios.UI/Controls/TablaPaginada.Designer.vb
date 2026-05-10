<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TablaPaginada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TablaPaginada))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlPaginacion = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPaginaFinal = New System.Windows.Forms.Button()
        Me.btnPuntos = New System.Windows.Forms.Button()
        Me.btnPagina3 = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPagina1 = New System.Windows.Forms.Button()
        Me.btnPagina2 = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jornada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grupos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlPaginacion.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Location = New System.Drawing.Point(42, 12)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(382, 59)
        Me.pnlTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(4, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(273, 28)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Últimos horarios generados"
        '
        'pnlPaginacion
        '
        Me.pnlPaginacion.Controls.Add(Me.Button1)
        Me.pnlPaginacion.Controls.Add(Me.btnPaginaFinal)
        Me.pnlPaginacion.Controls.Add(Me.btnPuntos)
        Me.pnlPaginacion.Controls.Add(Me.btnPagina3)
        Me.pnlPaginacion.Controls.Add(Me.btnAnterior)
        Me.pnlPaginacion.Controls.Add(Me.btnPagina1)
        Me.pnlPaginacion.Controls.Add(Me.btnPagina2)
        Me.pnlPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPaginacion.Location = New System.Drawing.Point(0, 473)
        Me.pnlPaginacion.Name = "pnlPaginacion"
        Me.pnlPaginacion.Size = New System.Drawing.Size(1446, 67)
        Me.pnlPaginacion.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1394, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPaginaFinal
        '
        Me.btnPaginaFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaginaFinal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPaginaFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPaginaFinal.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaginaFinal.Location = New System.Drawing.Point(1348, 12)
        Me.btnPaginaFinal.Name = "btnPaginaFinal"
        Me.btnPaginaFinal.Size = New System.Drawing.Size(37, 37)
        Me.btnPaginaFinal.TabIndex = 5
        Me.btnPaginaFinal.UseVisualStyleBackColor = True
        '
        'btnPuntos
        '
        Me.btnPuntos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPuntos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPuntos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPuntos.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuntos.Location = New System.Drawing.Point(1305, 12)
        Me.btnPuntos.Name = "btnPuntos"
        Me.btnPuntos.Size = New System.Drawing.Size(37, 37)
        Me.btnPuntos.TabIndex = 4
        Me.btnPuntos.Text = "..."
        Me.btnPuntos.UseVisualStyleBackColor = True
        '
        'btnPagina3
        '
        Me.btnPagina3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagina3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPagina3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPagina3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagina3.Location = New System.Drawing.Point(1262, 12)
        Me.btnPagina3.Name = "btnPagina3"
        Me.btnPagina3.Size = New System.Drawing.Size(37, 37)
        Me.btnPagina3.TabIndex = 3
        Me.btnPagina3.Text = "3"
        Me.btnPagina3.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(1133, 12)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(37, 37)
        Me.btnAnterior.TabIndex = 0
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPagina1
        '
        Me.btnPagina1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagina1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPagina1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPagina1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagina1.Location = New System.Drawing.Point(1176, 12)
        Me.btnPagina1.Name = "btnPagina1"
        Me.btnPagina1.Size = New System.Drawing.Size(37, 37)
        Me.btnPagina1.TabIndex = 2
        Me.btnPagina1.Text = "1"
        Me.btnPagina1.UseVisualStyleBackColor = True
        '
        'btnPagina2
        '
        Me.btnPagina2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagina2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPagina2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPagina2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagina2.Location = New System.Drawing.Point(1219, 12)
        Me.btnPagina2.Name = "btnPagina2"
        Me.btnPagina2.Size = New System.Drawing.Size(37, 37)
        Me.btnPagina2.TabIndex = 1
        Me.btnPagina2.Text = "2"
        Me.btnPagina2.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToResizeRows = False
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Fecha, Me.Jornada, Me.Grupos, Me.Semestre, Me.Estado})
        Me.dgvDatos.EnableHeadersVisualStyles = False
        Me.dgvDatos.GridColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvDatos.Location = New System.Drawing.Point(51, 77)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersWidth = 62
        Me.dgvDatos.RowTemplate.Height = 32
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(1351, 243)
        Me.dgvDatos.TabIndex = 2
        '
        'Nombre
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle1
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Fecha
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 8
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Jornada
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jornada.DefaultCellStyle = DataGridViewCellStyle3
        Me.Jornada.HeaderText = "Jornada"
        Me.Jornada.MinimumWidth = 8
        Me.Jornada.Name = "Jornada"
        Me.Jornada.ReadOnly = True
        '
        'Grupos
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupos.DefaultCellStyle = DataGridViewCellStyle4
        Me.Grupos.HeaderText = "Grupos"
        Me.Grupos.MinimumWidth = 8
        Me.Grupos.Name = "Grupos"
        Me.Grupos.ReadOnly = True
        '
        'Semestre
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Semestre.DefaultCellStyle = DataGridViewCellStyle5
        Me.Semestre.HeaderText = "Semestre"
        Me.Semestre.MinimumWidth = 8
        Me.Semestre.Name = "Semestre"
        Me.Semestre.ReadOnly = True
        '
        'Estado
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado.DefaultCellStyle = DataGridViewCellStyle6
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 8
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'TablaPaginada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlPaginacion)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.dgvDatos)
        Me.Name = "TablaPaginada"
        Me.Size = New System.Drawing.Size(1446, 540)
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlPaginacion.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlPaginacion As Panel
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPagina2 As Button
    Friend WithEvents btnPagina1 As Button
    Friend WithEvents btnPagina3 As Button
    Friend WithEvents btnPuntos As Button
    Friend WithEvents btnPaginaFinal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Jornada As DataGridViewTextBoxColumn
    Friend WithEvents Grupos As DataGridViewTextBoxColumn
    Friend WithEvents Semestre As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
