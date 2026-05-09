Imports SistemaHorarios.Logica
Imports SistemaHorarios.Logica.Modelos
Imports SistemaHorarios.Logica.Negocio.Materias
Imports SistemaHorarios.Logica.ReglasMaImports

Public Class Form1

    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Try

            MessageBox.Show(
                "=== INICIO PRUEBA MATERIAS ==="
            )

            ' Crear materia de prueba
            Dim materia As New Materia()

            materia.Id = 1
            materia.Codigo = "MAT101"
            materia.Nombre = ""
            materia.Creditos = 0
            materia.IntensidadHoraria = 6
            materia.SemestreRecomendado = 1
            materia.Estado = True
            materia.AplicaTAPSI = True
            materia.EsObligatoriaTAPSI = False
            materia.TieneComponentePractico = True

            ' Probar gestor
            Dim gestor As New GestorMateria()

            Dim resultado =
                gestor.RegistrarMateria(materia)

            MessageBox.Show(
                "Materia válida: " &
                resultado.ToString()
            )

            ' Lista de materias
            Dim materias As New List(Of Materia)

            materias.Add(materia)

            ' Probar calculador
            Dim calculador As New CalculadorCargaAcademica()

            Dim totalCreditos =
                calculador.
                CalcularTotalCreditos(materias)

            MessageBox.Show(
                "Total créditos: " &
                totalCreditos
            )

            Dim intensidad =
                calculador.
                CalcularIntensidadHoraria(materias)

            MessageBox.Show(
                "Intensidad horaria: " &
                intensidad
            )

            Dim esPesada =
                calculador.
                EsCargaPesada(materias)

            MessageBox.Show(
                "¿Carga pesada?: " &
                esPesada.ToString()
            )

            ' Probar reglas
            Dim esTAPSI =
                ReglasMateria.
                EsMateriaTAPSI(materia)

            MessageBox.Show(
                "¿Aplica TAPSI?: " &
                esTAPSI.ToString()
            )

            Dim tienePractica =
                ReglasMateria.
                TieneComponentePractico(materia)

            MessageBox.Show(
                "¿Tiene práctica?: " &
                tienePractica.ToString()
            )

            MessageBox.Show(
                "=== FIN PRUEBA ==="
            )

        Catch ex As Exception

            MessageBox.Show(
                "ERROR: " &
                ex.Message
            )

        End Try

    End Sub

End Class