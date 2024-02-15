Public Class Form1
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        Try
            Dim a, b As Integer
            a = firstnumber.Text
            b = secondnumber.Text
            Result.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class
