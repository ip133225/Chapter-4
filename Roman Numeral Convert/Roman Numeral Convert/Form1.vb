﻿Public Class Form1

    Private Sub lblTwo_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumber As Integer

        Try
            intNumber = txtUserInteger.Text
            If intNumber = 1 Then
                lblConvert.Text = "I"
            ElseIf intNumber = 2 Then
                lblConvert.Text = "II"
            ElseIf intNumber = 3 Then
                lblConvert.Text = "III"
            ElseIf intNumber = 4 Then
                lblConvert.Text = "IV"
            ElseIf intNumber = 5 Then
                lblConvert.Text = "V"
            ElseIf intNumber = 6 Then
                lblConvert.Text = "VI"
            ElseIf intNumber = 7 Then
                lblConvert.Text = "VII"
            ElseIf intNumber = 8 Then
                lblConvert.Text = "VIII"
            ElseIf intNumber = 9 Then
                lblConvert.Text = "IX"
            ElseIf intNumber = 10 Then
                lblConvert.Text = "X"
            ElseIf intNumber > 10 Then
                lblMessage.Text = "Make sure it is between 1 and 10."
            End If

        Catch
            lblMessage.Text = "Make sure you enter a number between 1 and 10."
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
