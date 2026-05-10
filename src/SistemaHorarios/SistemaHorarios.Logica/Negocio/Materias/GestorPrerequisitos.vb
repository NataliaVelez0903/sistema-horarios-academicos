Imports SistemaHorarios.Logica.Modelos

Public Class GestorPrerequisitos

    ''' <summary>
    ''' Agrega un prerequisito a una materia.
    ''' </summary>
    Public Function AgregarPrerequisito(
        prerequisitos As List(Of PrerequisitoMateria),
        nuevoPrerequisito As PrerequisitoMateria
    ) As Boolean

        If prerequisitos Is Nothing Then
            Throw New Exception(
                "La lista de prerequisitos es requerida."
            )
        End If

        If nuevoPrerequisito Is Nothing Then
            Throw New Exception(
                "El prerequisito es requerido."
            )
        End If

        If nuevoPrerequisito.IdMateria <= 0 Then
            Throw New Exception(
                "La materia no es válida."
            )
        End If

        If nuevoPrerequisito.IdMateriaPrerequisito <= 0 Then
            Throw New Exception(
                "La materia prerequisito no es válida."
            )
        End If

        If nuevoPrerequisito.IdMateria =
           nuevoPrerequisito.IdMateriaPrerequisito Then

            Throw New Exception(
                "Una materia no puede ser prerequisito de sí misma."
            )

        End If

        Dim yaExiste = prerequisitos.Any(
            Function(p)
                p.IdMateria =
                nuevoPrerequisito.IdMateria AndAlso
                p.IdMateriaPrerequisito =
                nuevoPrerequisito.IdMateriaPrerequisito
            End Function
        )

        If yaExiste Then

            Throw New Exception(
                "El prerequisito ya existe."
            )

        End If

        prerequisitos.Add(nuevoPrerequisito)

        Return True

    End Function

    ''' <summary>
    ''' Obtiene los prerequisitos de una materia.
    ''' </summary>
    Public Function ObtenerPrerequisitos(
        idMateria As Integer,
        prerequisitos As List(Of PrerequisitoMateria)
    ) As List(Of PrerequisitoMateria)

        If idMateria <= 0 Then

            Throw New Exception(
                "El id de la materia no es válido."
            )

        End If

        Return prerequisitos.
            Where(Function(p)
                      p.IdMateria = idMateria
                  End Function).
            ToList()

    End Function

    ''' <summary>
    ''' Verifica si una materia tiene prerequisitos.
    ''' </summary>
    Public Function TienePrerequisitos(
        idMateria As Integer,
        prerequisitos As List(Of PrerequisitoMateria)
    ) As Boolean

        Return prerequisitos.Any(
            Function(p)
                p.IdMateria = idMateria
            End Function
        )

    End Function

    ''' <summary>
    ''' Elimina un prerequisito.
    ''' </summary>
    Public Function EliminarPrerequisito(
        prerequisitos As List(Of PrerequisitoMateria),
        idMateria As Integer,
        idMateriaPrerequisito As Integer
    ) As Boolean

        Dim prerequisito = prerequisitos.FirstOrDefault(
            Function(p)
                p.IdMateria = idMateria AndAlso
                p.IdMateriaPrerequisito =
                idMateriaPrerequisito
            End Function
        )

        If prerequisito Is Nothing Then

            Throw New Exception(
                "El prerequisito no existe."
            )

        End If

        prerequisitos.Remove(prerequisito)

        Return True

    End Function

    ''' <summary>
    ''' Verifica si una materia depende de otra.
    ''' </summary>
    Public Function DependeDe(
        idMateria As Integer,
        idMateriaPrerequisito As Integer,
        prerequisitos As List(Of PrerequisitoMateria)
    ) As Boolean

        Return prerequisitos.Any(
            Function(p)
                p.IdMateria = idMateria AndAlso
                p.IdMateriaPrerequisito =
                idMateriaPrerequisito
            End Function
        )

    End Function

End Class