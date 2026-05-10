Public Class TablaPaginada
    Private Sub TablaPaginada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarEstiloTabla()
    End Sub

    Private Sub pnlPaginacion_Paint(sender As Object, e As PaintEventArgs) Handles pnlPaginacion.Paint

    End Sub

    Private Sub pnlTitulo_Paint(sender As Object, e As PaintEventArgs) Handles pnlTitulo.Paint

    End Sub

    Public Sub AgregarFila(ParamArray valores As Object())
        dgvDatos.Rows.Add(valores)
        dgvDatos.ClearSelection()
    End Sub

    Private Sub ConfigurarEstiloTabla()
        dgvDatos.RowHeadersVisible = False
        dgvDatos.EnableHeadersVisualStyles = False
        dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDatos.MultiSelect = False

        dgvDatos.BackgroundColor = Color.White
        dgvDatos.BorderStyle = BorderStyle.None
        dgvDatos.GridColor = Color.Gainsboro

        dgvDatos.DefaultCellStyle.BackColor = Color.White
        dgvDatos.DefaultCellStyle.ForeColor = Color.Black
        dgvDatos.DefaultCellStyle.SelectionBackColor = Color.White
        dgvDatos.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro
        dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvDatos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gainsboro
        dgvDatos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        dgvDatos.ClearSelection()
    End Sub

    Private Sub dgvDatos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDatos.CellFormatting
        If e.RowIndex < 0 OrElse e.Value Is Nothing Then
            Return
        End If

        Dim nombreColumna As String = dgvDatos.Columns(e.ColumnIndex).Name
        Dim valor As String = e.Value.ToString()

        If nombreColumna = "Jornada" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            e.CellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            If valor = "Nocturna" Then
                e.CellStyle.BackColor = Color.FromArgb(224, 215, 246)
                e.CellStyle.ForeColor = Color.FromArgb(83, 91, 198)
                e.CellStyle.SelectionBackColor = Color.FromArgb(224, 215, 246)
                e.CellStyle.SelectionForeColor = Color.FromArgb(83, 91, 198)
            ElseIf valor = "Diurna" Then
                e.CellStyle.BackColor = Color.FromArgb(204, 226, 243)
                e.CellStyle.ForeColor = Color.FromArgb(0, 106, 166)
                e.CellStyle.SelectionBackColor = Color.FromArgb(204, 226, 243)
                e.CellStyle.SelectionForeColor = Color.FromArgb(0, 106, 166)
            End If
        End If

        If nombreColumna = "Estado" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            e.CellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            If valor = "Aprobado" Then
                e.CellStyle.BackColor = Color.FromArgb(220, 247, 224)
                e.CellStyle.ForeColor = Color.FromArgb(26, 158, 59)
                e.CellStyle.SelectionBackColor = Color.FromArgb(220, 247, 224)
                e.CellStyle.SelectionForeColor = Color.FromArgb(26, 158, 59)
            End If
        End If
    End Sub


End Class
