Imports MySql.Data.MySqlClient

Namespace Conexion

    Public Class ConexionMySQL

        Private cadenaConexion As String =
            "server=localhost;" &
            "port=3306;" &
            "database=sistema_horarios;" &
            "uid=root;" &
            "pwd=1234;"

        Public Function ObtenerConexion() As MySqlConnection
            Return New MySqlConnection(cadenaConexion)
        End Function

    End Class

End Namespace