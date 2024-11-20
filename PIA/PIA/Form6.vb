Public Class Form6
    Dim suma, promedio, m As Double
    Dim res As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 1 To 10
            res = InputBox("control de los resultados" & i & ":", "digitalizar de resultados")

            suma = suma + res
            promedio = suma / 100
            m = promedio
            If res > res Then
            ElseIf res < res Then
            End If

            Me.lblinfo.Text = Me.lblinfo.Text & "resultado" & i & "=" & res & Chr(13) & Chr(10)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("resultado de las sumas:" & suma, "la suma de todos los resultados es:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("resultado del Promedio:" & m, "el promedio de la suma:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("numeros mayor y menor:" & res, "el promedio de la suma:", MessageBoxButtons.OK, MessageBoxIcon.Information)


        If m >= 7 Then
            MessageBox.Show("Aprobo")
        Else
            MessageBox.Show("NO Aprobo")

        End If
        Me.lblinfo.Text = Me.lblinfo.Text & "resultado total= " & suma & Chr(13) & Chr(10)
    End Sub
End Class