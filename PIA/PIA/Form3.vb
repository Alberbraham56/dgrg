Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edad, genero, name As String
        Dim m, s, d, h As Integer
        genero = txtg.Text
        edad = txtedad.Text
        name = txtname.Text
        m = edad * 12
        s = m * 4
        d = edad * 365
        h = d * 24
        txtm.Text = m
        txts.Text = s
        txtd.Text = d
        txth.Text = h
        If genero = "f" Then
            MessageBox.Show(name + " ES UNA MUJER")

        ElseIf genero = "m" Then
            MessageBox.Show(name + " ES UN HOMBRE")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtedad.Text = ""
        txtd.Text = ""
        txtg.Text = ""
        txth.Text = ""
        txtm.Text = ""
        txtname.Text = ""
        txts.Text = ""

    End Sub
End Class