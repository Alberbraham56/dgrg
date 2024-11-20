Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j, p As Double
        j = txtj.Text

        If j >= 4 Then
            p = j * 600
            txtp.Text = p
        ElseIf j <= 3 Then
            p = j * 900
            txtp.Text = p
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtp.Text = ""
        txtj.Text = ""
    End Sub
End Class