Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox_Pass.TextChanged

    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtBox_Pass.Text = "cookies") Then
            MessageBox.Show("The Password Is Correct")
        Else
            MessageBox.Show("The Password Is Incorrect")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
