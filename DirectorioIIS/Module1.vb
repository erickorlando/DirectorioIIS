Imports System.Net

Module Module1

    Sub Main()

        Try
            Dim ruta = "http://localhost/aspnet_client"

            Dim archivo As String = ruta + "/readme.txt"

            Console.WriteLine(archivo)

            Dim client = WebRequest.Create(archivo)
            client.Method = "GET"

            Dim result = client.GetResponse()

            If result.ContentLength > 0 Then

                Console.WriteLine("Archivo existe")

            Else
                Console.WriteLine("No encontrado")

            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadLine()
        End Try


    End Sub

End Module
