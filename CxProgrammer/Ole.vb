Imports System.Runtime.InteropServices
Public MustInherit Class Ole



    Shared Sub ExtreaerDatos(ruta As String)
        Try
            Dim cx As Object
            cx = CreateObject("CX-SERVER")

            ' Abrir el proyecto
            cx.Open(ruta)

            ' Acceder a una variable espec�fica
            Dim variable As Object
            variable = cx.Variables("NombreDeLaVariable")

            ' Leer el valor
            Dim valor As VariantType
            valor = variable.Value

            ' Mostrar el valor
            Console.WriteLine("El valor de la variable es: " & valor)

            ' Cerrar el proyecto
            cx.Close()



        Catch ex As Exception
            Throw ex

        End Try
    End Sub

End Class
