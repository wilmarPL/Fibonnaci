Public Class Form1
    Dim primero As Integer = 0
    Dim segundo As Integer = 1
    Dim suma As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String = primero.ToString + " , " + segundo.ToString

        For i = 1 To Val(TextBox1.Text) - 2
            suma = primero + segundo
            cadena += " , " + suma.ToString
            primero = segundo
            segundo = suma

        Next

        TextBox2.Text = cadena
        ReiniciarVariables()
    End Sub

    Private Sub ReiniciarVariables()
        primero = 0
        segundo = 1
        suma = 0
    End Sub
End Class
