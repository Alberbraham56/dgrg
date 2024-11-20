Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, Num1, Num2, Num3, Num4, un As Integer
        Dim Micros As Date
        Num3 = 200
        Num4 = 204

        For i = 0 To 10 Step 1
            Micros = Date.Now
            un = Micros.Microsecond / 10
            RichTextBox1.Text = RichTextBox1.Text & un & vbCrLf
            If Num1 > Num2 Then
                Num2 = Num1
            ElseIf Num1 <= Num2 Then
                Num1 = un
            End If

            If Num3 < Num4 Then
                Num4 = Num3
            ElseIf Num3 >= Num4 Then
                Num3 = un
            End If
        Next i
        TextBox1.Text = Num2
        TextBox2.Text = Num4
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RichTextBox1.Text = ""

    End Sub
End Class