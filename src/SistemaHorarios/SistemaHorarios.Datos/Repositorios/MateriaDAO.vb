Imports MySql.Data.MySqlClient
Imports SistemaHorarios.Datos.Conexion
Imports SistemaHorarios.Logica
Imports SistemaHorarios.Logica.Modelos

Namespace Repositorios

    Public Class MateriaDAO

        Private conexion As New ConexionMySQL()

        Public Function ObtenerMaterias() As List(Of Materia)

            Dim lista As New List(Of Materia)

            Using conn = conexion.ObtenerConexion()

                conn.Open()

                Dim query As String =
                    "SELECT * FROM materias"

                Dim cmd As New MySqlCommand(query, conn)

                Dim reader = cmd.ExecuteReader()

                While reader.Read()

                    Dim materia As New Materia()

                    materia.Id = Convert.ToInt32(reader("id"))
                    materia.Codigo = reader("codigo").ToString()
                    materia.Nombre = reader("nombre").ToString()
                    materia.Creditos = Convert.ToInt32(reader("creditos"))

                    lista.Add(materia)

                End While

            End Using

            Return lista

        End Function

    End Class

End Namespace