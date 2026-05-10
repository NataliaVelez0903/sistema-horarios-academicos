Imports SistemaHorarios.Logica.Modelos
Imports SistemaHorarios.Logica.Negocio.Materias

Module ModuloPruebas

    Sub Main()

        Try

            Console.WriteLine("=== PRUEBA MATERIAS ===")

            Dim materia As New Materia()

            materia.Id = 1
            materia.Codigo = "MAT101"
            materia.Nombre = "Programación I"
            materia.Creditos = 4
            materia.IntensidadHoraria = 6
            materia.SemestreRecomendado = 1
            materia.Estado = True
            materia.AplicaTAPSI = True
            materia.EsObligatoriaTAPSI = False
            materia.TieneComponentePractico = True

            Dim gestor As New GestorMateria()

            Dim resultado =
                gestor.RegistrarMateria(materia)

            Console.WriteLine(
                "Materia registrada correctamente: " &
                resultado.ToString()
            )

            Dim materias As New List(Of Materia)

            materias.Add(materia)

            Dim calculador As New CalculadorCargaAcademica()

            Dim totalCreditos =
                calculador.CalcularTotalCreditos(materias)

            Console.WriteLine(
                "Total créditos: " &
                totalCreditos
            )

            Dim intensidad =
                calculador.CalcularIntensidadHoraria(materias)

            Console.WriteLine(
                "Intensidad horaria: " &
                intensidad
            )

            Console.WriteLine("=== FIN PRUEBA ===")

        Catch ex As Exception

            Console.WriteLine(
                "ERROR: " & ex.Message
            )

        End Try

        Console.ReadLine()

    End Sub

End Module