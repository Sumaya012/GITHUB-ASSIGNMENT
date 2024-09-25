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
        Label3 = New Label()
        btnclick = New Button()
        txtname = New TextBox()
        txtage = New TextBox()
        txtfavoritecolor = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 0
        Label1.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(106, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 25)
        Label2.TabIndex = 1
        Label2.Text = "AGE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(106, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 25)
        Label3.TabIndex = 2
        Label3.Text = "FAVORITE COLOR"
        ' 
        ' btnclick
        ' 
        btnclick.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclick.Location = New Point(244, 244)
        btnclick.Name = "btnclick"
        btnclick.Size = New Size(121, 50)
        btnclick.TabIndex = 3
        btnclick.Text = "CLICK"
        btnclick.UseVisualStyleBackColor = True
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(282, 37)
        txtname.Name = "txtname"
        txtname.Size = New Size(150, 31)
        txtname.TabIndex = 4
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(282, 88)
        txtage.Name = "txtage"
        txtage.Size = New Size(150, 31)
        txtage.TabIndex = 5
        ' 
        ' txtfavoritecolor
        ' 
        txtfavoritecolor.Location = New Point(282, 134)
        txtfavoritecolor.Name = "txtfavoritecolor"
        txtfavoritecolor.Size = New Size(150, 31)
        txtfavoritecolor.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtfavoritecolor)
        Controls.Add(txtage)
        Controls.Add(txtname)
        Controls.Add(btnclick)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnclick As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtfavoritecolor As TextBox

End Class
