Public Class madLibs

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String ' Hold selected from list boxes 

        If listColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a color.")
        ElseIf listEst.SelectedIndex = -1 Then
            MessageBox.Show("No word ending in EST was selected.")
        ElseIf listNumber.SelectedIndex = -1 Then
            MessageBox.Show("Select a number.")
        ElseIf listBodyPart.SelectedIndex = -1 Then
            MessageBox.Show("Select a body part.")
        ElseIf listAnimal.SelectedIndex = -1 Then
            MessageBox.Show("Select an animal.")
        ElseIf listNoun.SelectedIndex = -1 Then
            MessageBox.Show("Select a noun.")
        ElseIf listPlaralNoun.SelectedIndex = -1 Then
            MessageBox.Show("Select a plural noun.")

        End If

        strInput = listColor.SelectedItem.ToString() & "Dragon is the " &
            listEst.SelectedItem.ToString() & "Dragon of them all. It has " & listNumber.SelectedItem.ToString() &
            " " & listBodyPart.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shape like a "

        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")
    End Sub

    Private Sub listPlaralNoun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPlaralNoun.SelectedIndexChanged
        listColor.SelectedIndex = -1
        listAnimal.SelectedIndex = -1
        listBodyPart.SelectedIndex = -1
        listEst.SelectedIndex = -1
        listNoun.SelectedIndex = -1
        listNumber.SelectedIndex = -1
        listPlaralNoun.SelectedIndex = -1


    End Sub
End Class
