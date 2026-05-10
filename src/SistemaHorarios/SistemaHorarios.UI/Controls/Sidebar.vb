Public Class Sidebar
    Inherits System.Windows.Forms.UserControl

    Public Event Navegar(opcion As String)

    Public Sub Configurar(sesion As UsuarioSesion, opcionActiva As String)
        btnCoordinadores.Visible = sesion.EsAdministrador
        btnHistorialCambios.Visible = sesion.EsAdministrador

        MarcarActivo(opcionActiva)
    End Sub

    Private Sub MarcarActivo(opcion As String)

        Dim colorNormal As Color = Color.FromArgb(76, 94, 113)
        Dim colorActivo As Color = Color.FromArgb(0, 120, 183)

        Dim botones = {
        btnInicio,
        btnPlanAcademico,
        btnMaterias,
        btnDocentes,
        btnGruposAcademicos,
        btnCoordinadores,
        btnHorarios,
        btnReportes,
        btnHistorialCambios,
        btnManual
        }

        For Each boton In botones
            boton.BackColor = colorNormal
            boton.ForeColor = Color.White
            boton.FlatAppearance.BorderSize = 0
        Next

        Select Case opcion
            Case "Inicio"
                btnInicio.BackColor = colorActivo
            Case "PlanAcademico"
                btnPlanAcademico.BackColor = colorActivo
            Case "Materias"
                btnMaterias.BackColor = colorActivo
            Case "Docentes"
                btnDocentes.BackColor = colorActivo
            Case "GruposAcademicos"
                btnGruposAcademicos.BackColor = colorActivo
            Case "Coordinadores"
                btnCoordinadores.BackColor = colorActivo
            Case "Horarios"
                btnHorarios.BackColor = colorActivo
            Case "Reportes"
                btnReportes.BackColor = colorActivo
            Case "HistorialCambios"
                btnHistorialCambios.BackColor = colorActivo
            Case "Manual"
                btnManual.BackColor = colorActivo
        End Select

    End Sub


    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        RaiseEvent Navegar("Inicio")
    End Sub

    Private Sub btnPlanAcademico_Click(sender As Object, e As EventArgs) Handles btnPlanAcademico.Click
        RaiseEvent Navegar("PlanAcademico")
    End Sub

    Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        RaiseEvent Navegar("Materias")
    End Sub

    Private Sub btnDocentes_Click(sender As Object, e As EventArgs) Handles btnDocentes.Click
        RaiseEvent Navegar("Docentes")
    End Sub

    Private Sub btnGruposAcademicos_Click(sender As Object, e As EventArgs) Handles btnGruposAcademicos.Click
        RaiseEvent Navegar("GruposAcademicos")
    End Sub

    Private Sub btnCoordinadores_Click(sender As Object, e As EventArgs) Handles btnCoordinadores.Click
        RaiseEvent Navegar("Coordinadores")
    End Sub

    Private Sub btnHorarios_Click(sender As Object, e As EventArgs) Handles btnHorarios.Click
        RaiseEvent Navegar("Horarios")
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        RaiseEvent Navegar("Reportes")
    End Sub

    Private Sub btnHistorialCambios_Click(sender As Object, e As EventArgs) Handles btnHistorialCambios.Click
        RaiseEvent Navegar("HistorialCambios")
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        RaiseEvent Navegar("Manual")
    End Sub

    Private Sub Sidebar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
