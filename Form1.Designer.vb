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
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolution.Location = New System.Drawing.Point(318, 32)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(36, 39)
        Me.lblSolution.TabIndex = 0
        Me.lblSolution.Text = "?"
        '
        'lblEquation
        '
        Me.lblEquation.AutoSize = True
        Me.lblEquation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(143, 32)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(169, 39)
        Me.lblEquation.TabIndex = 1
        Me.lblEquation.Text = "10 + 20 = "
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(104, 104)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(114, 46)
        Me.btnShowAnswer.TabIndex = 2
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(277, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 198)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.lblSolution)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSolution As Label
    Friend WithEvents lblEquation As Label
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents btnExit As Button
End Class
