Imports System.Resources

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ap, p, a As Double
        ap = txtap.Text
        p = txtp.Text
        a = (ap * p) / 2
        txta.Text = a

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txta.Text = ""
        txtap.Text = ""
        txtp.Text = ""

    End Sub

    Private Sub txtap_TextChanged(sender As Object, e As EventArgs) Handles txtap.TextChanged

    End Sub
End Class