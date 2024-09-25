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
        Label2 = New Label()
        txtnumber = New TextBox()
        btncheck = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(252, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 30)
        Label1.TabIndex = 0
        Label1.Text = "Number Check"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 25)
        Label2.TabIndex = 1
        Label2.Text = "Enter Number"
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(337, 104)
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(224, 31)
        txtnumber.TabIndex = 2
        ' 
        ' btncheck
        ' 
        btncheck.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncheck.Location = New Point(269, 191)
        btncheck.Name = "btncheck"
        btncheck.Size = New Size(112, 34)
        btncheck.TabIndex = 3
        btncheck.Text = "Check"
        btncheck.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btncheck)
        Controls.Add(txtnumber)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents btncheck As Button

End Class
