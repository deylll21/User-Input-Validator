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
        Me.lblPromt = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPromt
        '
        Me.lblPromt.AutoSize = True
        Me.lblPromt.Location = New System.Drawing.Point(313, 82)
        Me.lblPromt.Name = "lblPromt"
        Me.lblPromt.Size = New System.Drawing.Size(79, 13)
        Me.lblPromt.TabIndex = 0
        Me.lblPromt.Text = "Enter your age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(296, 123)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(108, 20)
        Me.txtAge.TabIndex = 1
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(257, 184)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(181, 23)
        Me.btnValidate.TabIndex = 2
        Me.btnValidate.Text = "Validate Age"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(254, 247)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblPromt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPromt As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnValidate As Button
    Friend WithEvents lblResult As Label
End Class
