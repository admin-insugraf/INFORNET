Public Class Form1

    Private handler As New InputHandler
    Private temp As prop

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function Gethandler() As InputHandler
        Return handler
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
   
        For Each entry As prop In handler.GetEntries
            ListBox1.Items.Add(entry.time.ToLongDateString & " : " & entry.time.ToLongTimeString)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        temp = New prop
        temp.txt = TextBox1.Text
        temp.time = Date.Now
        handler.AddEntries(temp)
        TextBox1.Text = ""
    End Sub
End Class