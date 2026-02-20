Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numero 1 As Integer = Integer.parse(TextBox2.text)
        Dim Numero 2 As Integer = Integer.parse(TextBox1.text)
        Dim resultado As Integer = Numero1 + Numero2
        Label4.Text = resultado.ToString()
    End Sub
End Class
