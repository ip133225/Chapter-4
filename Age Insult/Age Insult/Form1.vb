Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Double
        Try
            intAge = txtUserAgeInput.Text
If intAge &lt; 10 Then
                lblResult.Text = "Can you even read?"
ElseIf intAge &gt;= 10 And intAge &lt; 14 Then
lblResult.Text = &quot;There are no words to express how naive you are.&quot;
ElseIf intAge &lt;= 14 And intAge &lt; 18 Then
lblResult.Text = &quot;You have no clue how the real world works.&quot;
            End If
        Catch ex As Exception
lblMessage.Text = &quot;Enter a numeric value&quot;
        End Try
    End Sub
End Class
