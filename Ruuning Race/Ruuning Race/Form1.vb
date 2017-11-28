Public Class Form1

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtFinishTime1.Text
        dblTime2 = txtFinishTime2.Text
        dblTime3 = txtFinishTime3.Text

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lblResult1.Text = txtName1.Text
            If dblTime2 < dblTime3 Then
                lblResult2.Text = txtName2.Text
                lblResult3.Text = txtName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblResult2.Text = txtName3.Text
                lblResult3 = txtName2.Text

            End If

        End If
        If dblTime2 < dblTime1 And dblTime2 < dblTime1 Then
            lblResult1.Text = txtName2.Text
        End If
    End Sub
End Class
