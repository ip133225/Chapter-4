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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUserInteger = New System.Windows.Forms.TextBox()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(45, 189)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 189)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUserInteger
        '
        Me.txtUserInteger.Location = New System.Drawing.Point(156, 51)
        Me.txtUserInteger.Name = "txtUserInteger"
        Me.txtUserInteger.Size = New System.Drawing.Size(100, 20)
        Me.txtUserInteger.TabIndex = 2
        '
        'lblOne
        '
        Me.lblOne.Location = New System.Drawing.Point(12, 41)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(128, 39)
        Me.lblOne.TabIndex = 3
        Me.lblOne.Text = "Enter a decimal integer between the range 1 -10:"
        Me.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(29, 91)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(111, 33)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "Equialent Roman Numeral:"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConvert
        '
        Me.lblConvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConvert.Location = New System.Drawing.Point(156, 101)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(100, 23)
        Me.lblConvert.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 250)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.txtUserInteger)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtUserInteger As System.Windows.Forms.TextBox
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblConvert As System.Windows.Forms.Label

End Class
