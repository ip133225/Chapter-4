Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub btnInsult_Click_1(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Double

        Try
            intAge = txtUserAgeInput.Text

            If intAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how naive your are."
            ElseIf intAge >= 14 And intAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            End If
        Catch ex As Exception
            lblResult.Text = "Enter a numeric value"
        End Try
    End Sub
End Class
