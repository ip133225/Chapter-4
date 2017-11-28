<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class madLibs
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.listColor = New System.Windows.Forms.ListBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblEst = New System.Windows.Forms.Label()
        Me.listEst = New System.Windows.Forms.ListBox()
        Me.listNumber = New System.Windows.Forms.ListBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.listBodyPart = New System.Windows.Forms.ListBox()
        Me.listAnimal = New System.Windows.Forms.ListBox()
        Me.listNoun = New System.Windows.Forms.ListBox()
        Me.listPlaralNoun = New System.Windows.Forms.ListBox()
        Me.lblBodyPart = New System.Windows.Forms.Label()
        Me.lblAnimal = New System.Windows.Forms.Label()
        Me.lblNoun = New System.Windows.Forms.Label()
        Me.lblPluralNoun = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(172, 357)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(253, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(334, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'listColor
        '
        Me.listColor.FormattingEnabled = True
        Me.listColor.Items.AddRange(New Object() {"Red", "Blue", "Green", "Yellow "})
        Me.listColor.Location = New System.Drawing.Point(25, 25)
        Me.listColor.Name = "listColor"
        Me.listColor.Size = New System.Drawing.Size(120, 95)
        Me.listColor.TabIndex = 4
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(22, 9)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 5
        Me.lblColor.Text = "Color"
        '
        'lblEst
        '
        Me.lblEst.AutoSize = True
        Me.lblEst.Location = New System.Drawing.Point(158, 9)
        Me.lblEst.Name = "lblEst"
        Me.lblEst.Size = New System.Drawing.Size(99, 13)
        Me.lblEst.TabIndex = 6
        Me.lblEst.Text = "Word Ending In Est"
        '
        'listEst
        '
        Me.listEst.FormattingEnabled = True
        Me.listEst.Items.AddRange(New Object() {"Fastest ", "Biggest", "Smallest", "Smartest", "Dumbest", "Strongest"})
        Me.listEst.Location = New System.Drawing.Point(161, 25)
        Me.listEst.Name = "listEst"
        Me.listEst.Size = New System.Drawing.Size(120, 95)
        Me.listEst.TabIndex = 7
        '
        'listNumber
        '
        Me.listNumber.FormattingEnabled = True
        Me.listNumber.Items.AddRange(New Object() {"Number 1", "Number 2", "Number 3", "Number 4"})
        Me.listNumber.Location = New System.Drawing.Point(298, 25)
        Me.listNumber.Name = "listNumber"
        Me.listNumber.Size = New System.Drawing.Size(120, 95)
        Me.listNumber.TabIndex = 8
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(295, 9)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(44, 13)
        Me.lblNumber.TabIndex = 9
        Me.lblNumber.Text = "Number"
        '
        'listBodyPart
        '
        Me.listBodyPart.FormattingEnabled = True
        Me.listBodyPart.Items.AddRange(New Object() {"Legs", "Arms", "Head", "Fingers"})
        Me.listBodyPart.Location = New System.Drawing.Point(25, 145)
        Me.listBodyPart.Name = "listBodyPart"
        Me.listBodyPart.Size = New System.Drawing.Size(120, 95)
        Me.listBodyPart.TabIndex = 10
        '
        'listAnimal
        '
        Me.listAnimal.FormattingEnabled = True
        Me.listAnimal.Items.AddRange(New Object() {"Cat", "Dog ", "Deer", "Turtle", "Monkey", "Elephant"})
        Me.listAnimal.Location = New System.Drawing.Point(161, 145)
        Me.listAnimal.Name = "listAnimal"
        Me.listAnimal.Size = New System.Drawing.Size(120, 95)
        Me.listAnimal.TabIndex = 11
        '
        'listNoun
        '
        Me.listNoun.FormattingEnabled = True
        Me.listNoun.Items.AddRange(New Object() {"City", "River", "Desert", "Skyscarper"})
        Me.listNoun.Location = New System.Drawing.Point(298, 145)
        Me.listNoun.Name = "listNoun"
        Me.listNoun.Size = New System.Drawing.Size(120, 95)
        Me.listNoun.TabIndex = 12
        '
        'listPlaralNoun
        '
        Me.listPlaralNoun.FormattingEnabled = True
        Me.listPlaralNoun.Items.AddRange(New Object() {"People ", "Useless", "Buildings", "Mountains"})
        Me.listPlaralNoun.Location = New System.Drawing.Point(25, 285)
        Me.listPlaralNoun.Name = "listPlaralNoun"
        Me.listPlaralNoun.Size = New System.Drawing.Size(120, 95)
        Me.listPlaralNoun.TabIndex = 13
        '
        'lblBodyPart
        '
        Me.lblBodyPart.AutoSize = True
        Me.lblBodyPart.Location = New System.Drawing.Point(25, 127)
        Me.lblBodyPart.Name = "lblBodyPart"
        Me.lblBodyPart.Size = New System.Drawing.Size(53, 13)
        Me.lblBodyPart.TabIndex = 14
        Me.lblBodyPart.Text = "Body Part"
        '
        'lblAnimal
        '
        Me.lblAnimal.AutoSize = True
        Me.lblAnimal.Location = New System.Drawing.Point(161, 127)
        Me.lblAnimal.Name = "lblAnimal"
        Me.lblAnimal.Size = New System.Drawing.Size(38, 13)
        Me.lblAnimal.TabIndex = 15
        Me.lblAnimal.Text = "Animal"
        '
        'lblNoun
        '
        Me.lblNoun.AutoSize = True
        Me.lblNoun.Location = New System.Drawing.Point(298, 126)
        Me.lblNoun.Name = "lblNoun"
        Me.lblNoun.Size = New System.Drawing.Size(33, 13)
        Me.lblNoun.TabIndex = 16
        Me.lblNoun.Text = "Noun"
        '
        'lblPluralNoun
        '
        Me.lblPluralNoun.AutoSize = True
        Me.lblPluralNoun.Location = New System.Drawing.Point(25, 266)
        Me.lblPluralNoun.Name = "lblPluralNoun"
        Me.lblPluralNoun.Size = New System.Drawing.Size(62, 13)
        Me.lblPluralNoun.TabIndex = 17
        Me.lblPluralNoun.Text = "Plural Noun"
        '
        'madLibs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 434)
        Me.Controls.Add(Me.lblPluralNoun)
        Me.Controls.Add(Me.lblNoun)
        Me.Controls.Add(Me.lblAnimal)
        Me.Controls.Add(Me.lblBodyPart)
        Me.Controls.Add(Me.listPlaralNoun)
        Me.Controls.Add(Me.listNoun)
        Me.Controls.Add(Me.listAnimal)
        Me.Controls.Add(Me.listBodyPart)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.listNumber)
        Me.Controls.Add(Me.listEst)
        Me.Controls.Add(Me.lblEst)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.listColor)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "madLibs"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents listColor As System.Windows.Forms.ListBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblEst As System.Windows.Forms.Label
    Friend WithEvents listEst As System.Windows.Forms.ListBox
    Friend WithEvents listNumber As System.Windows.Forms.ListBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents listBodyPart As System.Windows.Forms.ListBox
    Friend WithEvents listAnimal As System.Windows.Forms.ListBox
    Friend WithEvents listNoun As System.Windows.Forms.ListBox
    Friend WithEvents listPlaralNoun As System.Windows.Forms.ListBox
    Friend WithEvents lblBodyPart As System.Windows.Forms.Label
    Friend WithEvents lblAnimal As System.Windows.Forms.Label
    Friend WithEvents lblNoun As System.Windows.Forms.Label
    Friend WithEvents lblPluralNoun As System.Windows.Forms.Label

End Class
