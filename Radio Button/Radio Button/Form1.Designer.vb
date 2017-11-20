<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.GroupBoxOne = New System.Windows.Forms.GroupBox()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.radChickenPatty = New System.Windows.Forms.RadioButton()
        Me.radCheeseburger = New System.Windows.Forms.RadioButton()
        Me.radHamburger = New System.Windows.Forms.RadioButton()
        Me.GroupBoxTwo = New System.Windows.Forms.GroupBox()
        Me.chkJalopenos = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBoxThree = New System.Windows.Forms.GroupBox()
        Me.radSalad = New System.Windows.Forms.RadioButton()
        Me.radOnionRings = New System.Windows.Forms.RadioButton()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBoxOne.SuspendLayout()
        Me.GroupBoxTwo.SuspendLayout()
        Me.GroupBoxThree.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(12, 300)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(75, 23)
        Me.btnResult.TabIndex = 0
        Me.btnResult.Text = "Enter"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'GroupBoxOne
        '
        Me.GroupBoxOne.Controls.Add(Me.radHam)
        Me.GroupBoxOne.Controls.Add(Me.radChickenPatty)
        Me.GroupBoxOne.Controls.Add(Me.radCheeseburger)
        Me.GroupBoxOne.Controls.Add(Me.radHamburger)
        Me.GroupBoxOne.Location = New System.Drawing.Point(12, 60)
        Me.GroupBoxOne.Name = "GroupBoxOne"
        Me.GroupBoxOne.Size = New System.Drawing.Size(174, 149)
        Me.GroupBoxOne.TabIndex = 1
        Me.GroupBoxOne.TabStop = False
        Me.GroupBoxOne.Text = "Select Meal"
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(16, 126)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(157, 17)
        Me.radHam.TabIndex = 3
        Me.radHam.TabStop = True
        Me.radHam.Text = "Ham and Turkey Sandwich "
        Me.radHam.UseVisualStyleBackColor = True
        '
        'radChickenPatty
        '
        Me.radChickenPatty.AutoSize = True
        Me.radChickenPatty.Location = New System.Drawing.Point(16, 89)
        Me.radChickenPatty.Name = "radChickenPatty"
        Me.radChickenPatty.Size = New System.Drawing.Size(91, 17)
        Me.radChickenPatty.TabIndex = 2
        Me.radChickenPatty.TabStop = True
        Me.radChickenPatty.Text = "Chicken Patty"
        Me.radChickenPatty.UseVisualStyleBackColor = True
        '
        'radCheeseburger
        '
        Me.radCheeseburger.AutoSize = True
        Me.radCheeseburger.Location = New System.Drawing.Point(16, 51)
        Me.radCheeseburger.Name = "radCheeseburger"
        Me.radCheeseburger.Size = New System.Drawing.Size(95, 17)
        Me.radCheeseburger.TabIndex = 1
        Me.radCheeseburger.TabStop = True
        Me.radCheeseburger.Text = "Cheese Burger"
        Me.radCheeseburger.UseVisualStyleBackColor = True
        '
        'radHamburger
        '
        Me.radHamburger.AutoSize = True
        Me.radHamburger.Location = New System.Drawing.Point(16, 19)
        Me.radHamburger.Name = "radHamburger"
        Me.radHamburger.Size = New System.Drawing.Size(77, 17)
        Me.radHamburger.TabIndex = 0
        Me.radHamburger.TabStop = True
        Me.radHamburger.Text = "Hamburger"
        Me.radHamburger.UseVisualStyleBackColor = True
        '
        'GroupBoxTwo
        '
        Me.GroupBoxTwo.Controls.Add(Me.chkJalopenos)
        Me.GroupBoxTwo.Controls.Add(Me.chkMayo)
        Me.GroupBoxTwo.Controls.Add(Me.chkLettuce)
        Me.GroupBoxTwo.Controls.Add(Me.chkTomato)
        Me.GroupBoxTwo.Location = New System.Drawing.Point(215, 60)
        Me.GroupBoxTwo.Name = "GroupBoxTwo"
        Me.GroupBoxTwo.Size = New System.Drawing.Size(170, 149)
        Me.GroupBoxTwo.TabIndex = 2
        Me.GroupBoxTwo.TabStop = False
        Me.GroupBoxTwo.Text = "Toppings"
        '
        'chkJalopenos
        '
        Me.chkJalopenos.AutoSize = True
        Me.chkJalopenos.Location = New System.Drawing.Point(25, 126)
        Me.chkJalopenos.Name = "chkJalopenos"
        Me.chkJalopenos.Size = New System.Drawing.Size(74, 17)
        Me.chkJalopenos.TabIndex = 3
        Me.chkJalopenos.Text = "Jalopenos"
        Me.chkJalopenos.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(25, 89)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(25, 51)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(25, 19)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBoxThree
        '
        Me.GroupBoxThree.Controls.Add(Me.radSalad)
        Me.GroupBoxThree.Controls.Add(Me.radOnionRings)
        Me.GroupBoxThree.Controls.Add(Me.radFries)
        Me.GroupBoxThree.Location = New System.Drawing.Point(215, 223)
        Me.GroupBoxThree.Name = "GroupBoxThree"
        Me.GroupBoxThree.Size = New System.Drawing.Size(170, 100)
        Me.GroupBoxThree.TabIndex = 3
        Me.GroupBoxThree.TabStop = False
        Me.GroupBoxThree.Text = "Side Order"
        '
        'radSalad
        '
        Me.radSalad.AutoSize = True
        Me.radSalad.Location = New System.Drawing.Point(25, 67)
        Me.radSalad.Name = "radSalad"
        Me.radSalad.Size = New System.Drawing.Size(52, 17)
        Me.radSalad.TabIndex = 2
        Me.radSalad.TabStop = True
        Me.radSalad.Text = "Salad"
        Me.radSalad.UseVisualStyleBackColor = True
        '
        'radOnionRings
        '
        Me.radOnionRings.AutoSize = True
        Me.radOnionRings.Location = New System.Drawing.Point(25, 44)
        Me.radOnionRings.Name = "radOnionRings"
        Me.radOnionRings.Size = New System.Drawing.Size(83, 17)
        Me.radOnionRings.TabIndex = 1
        Me.radOnionRings.TabStop = True
        Me.radOnionRings.Text = "Onion Rings"
        Me.radOnionRings.UseVisualStyleBackColor = True
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(25, 19)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(47, 17)
        Me.radFries.TabIndex = 0
        Me.radFries.TabStop = True
        Me.radFries.Text = "Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 223)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(184, 51)
        Me.lblResult.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(61, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 29)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Welcome To Donald Trumps Food Court"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(111, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 344)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBoxThree)
        Me.Controls.Add(Me.GroupBoxTwo)
        Me.Controls.Add(Me.GroupBoxOne)
        Me.Controls.Add(Me.btnResult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxOne.ResumeLayout(False)
        Me.GroupBoxOne.PerformLayout()
        Me.GroupBoxTwo.ResumeLayout(False)
        Me.GroupBoxTwo.PerformLayout()
        Me.GroupBoxThree.ResumeLayout(False)
        Me.GroupBoxThree.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnResult As System.Windows.Forms.Button
    Friend WithEvents GroupBoxOne As System.Windows.Forms.GroupBox
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents radChickenPatty As System.Windows.Forms.RadioButton
    Friend WithEvents radCheeseburger As System.Windows.Forms.RadioButton
    Friend WithEvents radHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxTwo As System.Windows.Forms.GroupBox
    Friend WithEvents chkJalopenos As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxThree As System.Windows.Forms.GroupBox
    Friend WithEvents radSalad As System.Windows.Forms.RadioButton
    Friend WithEvents radOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents radFries As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
