Imports SistemaHorarios.Logica.Modelos

Public Class ValidadorMateria

    Public Function ValidarMateria(
        materia As Materia
    ) As List(Of String)

        Dim errores As New List(Of String)

        If materia Is Nothing Then
            errores.Add("La materia es requerida.")
            Return errores
        End If

        ValidarCodigo(materia, errores)

        ValidarNombre(materia, errores)

        ValidarCreditos(materia, errores)

        ValidarIntensidadHoraria(materia, errores)

        ValidarSemestre(materia, errores)

        ValidarReglasTAPSI(materia, errores)

        Return errores

    End Function

    Private Sub ValidarCodigo(
        materia As Materia,
        errores As List(Of String)
    )

        If String.IsNullOrWhiteSpace(materia.Codigo) Then

            errores.Add("El código de la materia es obligatorio.")

        End If

    End Sub

    Private Sub ValidarNombre(
        materia As Materia,
        errores As List(Of String)
    )

        If String.IsNullOrWhiteSpace(materia.Nombre) Then

            errores.Add("El nombre de la materia es obligatorio.")

        End If

    End Sub

    Private Sub ValidarCreditos(
        materia As Materia,
        errores As List(Of String)
    )

        If materia.Creditos <= 0 Then

            errores.Add(
                "Los créditos deben ser mayores a cero."
            )

        End If

        If materia.Creditos > 10 Then

            errores.Add(
                "Los créditos de la materia no son válidos."
            )

        End If

    End Sub

    Private Sub ValidarIntensidadHoraria(
        materia As Materia,
        errores As List(Of String)
    )

        If materia.IntensidadHoraria <= 0 Then

            errores.Add(
                "La intensidad horaria debe ser mayor a cero."
            )

        End If

        If materia.IntensidadHoraria > 20 Then

            errores.Add(
                "La intensidad horaria excede el límite permitido."
            )

        End If

    End Sub

    Private Sub ValidarSemestre(
        materia As Materia,
        errores As List(Of String)
    )

        If materia.SemestreRecomendado <= 0 Then

            errores.Add(
                "El semestre recomendado no es válido."
            )

        End If

        If materia.SemestreRecomendado > 10 Then

            errores.Add(
                "El semestre recomendado excede el rango permitido."
            )

        End If

    End Sub

    Private Sub ValidarReglasTAPSI(
        materia As Materia,
        errores As List(Of String)
    )

        If materia.EsObligatoriaTAPSI AndAlso
           Not materia.AplicaTAPSI Then

            errores.Add(
                "Una materia obligatoria TAPSI debe aplicar para TAPSI."
            )

        End If

    End Sub

End Class