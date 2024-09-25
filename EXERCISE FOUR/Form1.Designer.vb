<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnshow = New Button()
        txtresult = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(235, 42)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 30)
        Label1.TabIndex = 0
        Label1.Text = "Multiplication table from 1 to 10"
        ' 
        ' btnshow
        ' 
        btnshow.Location = New Point(400, 609)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(118, 49)
        btnshow.TabIndex = 1
        btnshow.Text = "Show"
        btnshow.UseVisualStyleBackColor = True
        ' 
        ' txtresult
        ' 
        txtresult.Location = New Point(173, 99)
        txtresult.Multiline = True
        txtresult.Name = "txtresult"
        txtresult.Size = New Size(562, 493)
        txtresult.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1001, 707)
        Controls.Add(txtresult)
        Controls.Add(btnshow)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Form1"
        Text = "4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnshow As Button
    Friend WithEvents txtresult As TextBox

End Class
