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
        Me.txtRunner1 = New System.Windows.Forms.TextBox()
        Me.txtRunner3 = New System.Windows.Forms.TextBox()
        Me.txtRunner2 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.lblResult3 = New System.Windows.Forms.Label()
        Me.lbl3rdPlace = New System.Windows.Forms.Label()
        Me.lbl2ndPlace = New System.Windows.Forms.Label()
        Me.lbl1stPlace = New System.Windows.Forms.Label()
        Me.lblRunner1 = New System.Windows.Forms.Label()
        Me.lblRunner2 = New System.Windows.Forms.Label()
        Me.lblRunner3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRunner1
        '
        Me.txtRunner1.Location = New System.Drawing.Point(76, 44)
        Me.txtRunner1.Name = "txtRunner1"
        Me.txtRunner1.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner1.TabIndex = 0
        '
        'txtRunner3
        '
        Me.txtRunner3.Location = New System.Drawing.Point(76, 122)
        Me.txtRunner3.Name = "txtRunner3"
        Me.txtRunner3.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner3.TabIndex = 1
        '
        'txtRunner2
        '
        Me.txtRunner2.Location = New System.Drawing.Point(76, 85)
        Me.txtRunner2.Name = "txtRunner2"
        Me.txtRunner2.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner2.TabIndex = 2
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(230, 122)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(54, 20)
        Me.txtTime3.TabIndex = 3
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(230, 82)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(54, 20)
        Me.txtTime2.TabIndex = 4
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(230, 44)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(54, 20)
        Me.txtTime1.TabIndex = 5
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblResult1)
        Me.groupBox1.Controls.Add(Me.lblResult2)
        Me.groupBox1.Controls.Add(Me.lblResult3)
        Me.groupBox1.Controls.Add(Me.lbl3rdPlace)
        Me.groupBox1.Controls.Add(Me.lbl2ndPlace)
        Me.groupBox1.Controls.Add(Me.lbl1stPlace)
        Me.groupBox1.Location = New System.Drawing.Point(76, 184)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(211, 125)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Race Results"
        '
        'lblResult1
        '
        Me.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult1.Location = New System.Drawing.Point(90, 19)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(100, 23)
        Me.lblResult1.TabIndex = 11
        '
        'lblResult2
        '
        Me.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult2.Location = New System.Drawing.Point(90, 53)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(100, 23)
        Me.lblResult2.TabIndex = 10
        '
        'lblResult3
        '
        Me.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult3.Location = New System.Drawing.Point(90, 84)
        Me.lblResult3.Name = "lblResult3"
        Me.lblResult3.Size = New System.Drawing.Size(100, 23)
        Me.lblResult3.TabIndex = 9
        '
        'lbl3rdPlace
        '
        Me.lbl3rdPlace.AutoSize = True
        Me.lbl3rdPlace.Location = New System.Drawing.Point(33, 84)
        Me.lbl3rdPlace.Name = "lbl3rdPlace"
        Me.lbl3rdPlace.Size = New System.Drawing.Size(55, 13)
        Me.lbl3rdPlace.TabIndex = 7
        Me.lbl3rdPlace.Text = "3rd Place:"
        '
        'lbl2ndPlace
        '
        Me.lbl2ndPlace.AutoSize = True
        Me.lbl2ndPlace.Location = New System.Drawing.Point(30, 54)
        Me.lbl2ndPlace.Name = "lbl2ndPlace"
        Me.lbl2ndPlace.Size = New System.Drawing.Size(58, 13)
        Me.lbl2ndPlace.TabIndex = 1
        Me.lbl2ndPlace.Text = "2nd Place:"
        '
        'lbl1stPlace
        '
        Me.lbl1stPlace.AutoSize = True
        Me.lbl1stPlace.Location = New System.Drawing.Point(33, 20)
        Me.lbl1stPlace.Name = "lbl1stPlace"
        Me.lbl1stPlace.Size = New System.Drawing.Size(54, 13)
        Me.lbl1stPlace.TabIndex = 0
        Me.lbl1stPlace.Text = "1st Place:"
        '
        'lblRunner1
        '
        Me.lblRunner1.AutoSize = True
        Me.lblRunner1.Location = New System.Drawing.Point(16, 44)
        Me.lblRunner1.Name = "lblRunner1"
        Me.lblRunner1.Size = New System.Drawing.Size(54, 13)
        Me.lblRunner1.TabIndex = 7
        Me.lblRunner1.Text = "Runner 1:"
        '
        'lblRunner2
        '
        Me.lblRunner2.AutoSize = True
        Me.lblRunner2.Location = New System.Drawing.Point(16, 85)
        Me.lblRunner2.Name = "lblRunner2"
        Me.lblRunner2.Size = New System.Drawing.Size(54, 13)
        Me.lblRunner2.TabIndex = 8
        Me.lblRunner2.Text = "Runner 2:"
        '
        'lblRunner3
        '
        Me.lblRunner3.AutoSize = True
        Me.lblRunner3.Location = New System.Drawing.Point(16, 125)
        Me.lblRunner3.Name = "lblRunner3"
        Me.lblRunner3.Size = New System.Drawing.Size(54, 13)
        Me.lblRunner3.TabIndex = 9
        Me.lblRunner3.Text = "Runner 3:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(189, 19)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(137, 13)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "Finishing Time (In Seconds)"
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.Location = New System.Drawing.Point(95, 19)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(35, 13)
        Me.lblNames.TabIndex = 8
        Me.lblNames.Text = "Name"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(54, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 361)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.lblRunner3)
        Me.Controls.Add(Me.lblRunner2)
        Me.Controls.Add(Me.lblRunner1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtRunner2)
        Me.Controls.Add(Me.txtRunner3)
        Me.Controls.Add(Me.txtRunner1)
        Me.Name = "Form1"
        Me.Text = "Race Results"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime1 As System.Windows.Forms.TextBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult3 As System.Windows.Forms.Label
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents lbl3rdPlace As System.Windows.Forms.Label
    Friend WithEvents lbl2ndPlace As System.Windows.Forms.Label
    Friend WithEvents lbl1stPlace As System.Windows.Forms.Label
    Friend WithEvents lblRunner1 As System.Windows.Forms.Label
    Friend WithEvents lblRunner2 As System.Windows.Forms.Label
    Friend WithEvents lblRunner3 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblResult1 As System.Windows.Forms.Label
    Friend WithEvents lblResult2 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
