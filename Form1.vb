Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        txtAbsV.Text = (Math.Abs(Val(txtNum.Text)))
    End Sub
End Class
