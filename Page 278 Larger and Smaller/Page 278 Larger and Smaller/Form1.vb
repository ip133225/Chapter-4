Public Class Form1

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCompose_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim n1, n2 As Integer
        n1 = Val(txtBox1.Text)
        n2 = Val(txtBox2.Text)
        If n1 > n2 Then
            lblResult.Text = "The Greater Number Is" & n1
        Else
            lblResult.Text = "The Greater Number Is" & n2
        End If
    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class
