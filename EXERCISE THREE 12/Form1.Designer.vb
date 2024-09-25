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
        btncounttozero = New Button()
        txtnumberentered = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(412, 120)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 30)
        Label1.TabIndex = 0
        Label1.Text = "Enter Number"
        ' 
        ' btncounttozero
        ' 
        btncounttozero.Location = New Point(412, 269)
        btncounttozero.Margin = New Padding(4, 4, 4, 4)
        btncounttozero.Name = "btncounttozero"
        btncounttozero.Size = New Size(182, 41)
        btncounttozero.TabIndex = 1
        btncounttozero.Text = "Count to zero"
        btncounttozero.UseVisualStyleBackColor = True
        ' 
        ' txtnumberentered
        ' 
        txtnumberentered.Location = New Point(368, 190)
        txtnumberentered.Margin = New Padding(4, 4, 4, 4)
        txtnumberentered.Name = "txtnumberentered"
        txtnumberentered.Size = New Size(296, 37)
        txtnumberentered.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 540)
        Controls.Add(txtnumberentered)
        Controls.Add(btncounttozero)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Form1"
        Text = "3b"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncounttozero As Button
    Friend WithEvents txtnumberentered As TextBox

End Class
