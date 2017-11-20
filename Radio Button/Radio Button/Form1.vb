Public Class Form1

    Private Sub lblOne_Click(sender As Object, e As EventArgs) Handles lblResult.Click
       
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim dblHamburger As Double = 5.99
        Dim dblCheeseBurger As Double = 6.99
        Dim dblChickenPatty As Double = 3.99
        Dim dblHam As Double = 4.99

        Dim dblTomato As Double = 0.75
        Dim dblLettuce As Double = 0.5
        Dim dblMayo As Double = 0.25
        Dim dblJalopeno As Double = 0.99

        Dim dblFries As Double = 1.99
        Dim dblOnionRings As Double = 2.99
        Dim dblSalad As Double = 0.99
        Dim Total As Double

        If radHamburger.Checked = True Then
            lblResult.Text = "You selected Cheese Burger"
            Total = dblCheeseBurger + Total
        ElseIf radCheeseburger.Checked = True Then
            lblResult.Text = "You selected Hamburger"
            Total = dblHamburger + Total
        ElseIf radChickenPatty.Checked = True Then
            lblResult.Text = "You selected Chicken Patty"
            Total = dblChickenPatty + Total
        ElseIf radHam.Checked = True Then
            lblResult.Text = "You selected Ham and Turkey"
            Total = dblHam + Total
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            Total = dblTomato + Total
        End If
        If chkLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            Total = dblLettuce + Total
        End If
        If chkMayo.Checked = True Then
            lblResult.Text &= ", and Mayo"
            Total = dblMayo + Total
        End If
        If chkJalopenos.Checked = True Then
            lblResult.Text &= ", and Jalopenos"
            Total = dblJalopeno + Total
        End If
        If radFries.Checked = True Then
            lblResult.Text &= " Fires "
            Total = dblFries + Total
        End If
        If radOnionRings.Checked = True Then
            lblResult.Text &= " Onion Rings"
            Total = dblOnionRings + Total
        End If
        If radSalad.Checked = True Then
            lblResult.Text &= " Salad "
            Total = dblSalad + Total
        End If
        lblResult.Text = Total.ToString("c")
    End Sub
End Class
