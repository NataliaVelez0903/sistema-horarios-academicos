Imports SistemaHorarios.Logica.Modelos

Namespace Servicios

    ' Contiene la lógica base para validar el inicio de sesión.
    Public Class AutenticacionServicio

        ' Valida las credenciales ingresadas por el usuario.
        Public Function ValidarCredenciales(usuario As String, contrasena As String) As ResultadoLogin

            ' Crea el objeto que almacenará la respuesta del proceso.
            Dim resultado As New ResultadoLogin()

            ' Elimina espacios al inicio y al final de los datos ingresados.
            usuario = usuario.Trim()
            contrasena = contrasena.Trim()

            ' Valida que el campo usuario no esté vacío.
            If usuario = "" Then
                resultado.Exitoso = False
                resultado.Mensaje = "El usuario es obligatorio."
                Return resultado
            End If

            ' Valida que el campo contraseña no esté vacío.
            If contrasena = "" Then
                resultado.Exitoso = False
                resultado.Mensaje = "La contraseña es obligatoria."
                Return resultado
            End If

            ' Simula la validación de existencia del usuario.
            If usuario <> "admin" Then
                resultado.Exitoso = False
                resultado.Mensaje = "El usuario no existe."
                Return resultado
            End If

            ' Simula la validación de la contraseña.
            If contrasena <> "1234" Then
                resultado.Exitoso = False
                resultado.Mensaje = "La contraseña es incorrecta."
                Return resultado
            End If

            ' Retorna una respuesta exitosa cuando los datos son correctos.
            resultado.Exitoso = True
            resultado.Mensaje = "Autenticación exitosa."
            resultado.Usuario = usuario

            Return resultado

        End Function

    End Class

End Namespace