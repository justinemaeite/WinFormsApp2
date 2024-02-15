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
        firstnumber = New TextBox()
        secondnumber = New TextBox()
        Label2 = New Label()
        Divide = New Button()
        Result = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' firstnumber
        ' 
        firstnumber.Location = New Point(37, 57)
        firstnumber.Name = "firstnumber"
        firstnumber.Size = New Size(100, 23)
        firstnumber.TabIndex = 1
        ' 
        ' secondnumber
        ' 
        secondnumber.Location = New Point(37, 136)
        secondnumber.Name = "secondnumber"
        secondnumber.Size = New Size(100, 23)
        secondnumber.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 2
        Label2.Text = "Second Number"
        ' 
        ' Divide
        ' 
        Divide.Location = New Point(37, 179)
        Divide.Name = "Divide"
        Divide.Size = New Size(75, 23)
        Divide.TabIndex = 4
        Divide.Text = "Divide"
        Divide.UseVisualStyleBackColor = True
        ' 
        ' Result
        ' 
        Result.AutoSize = True
        Result.Location = New Point(37, 214)
        Result.Name = "Result"
        Result.Size = New Size(39, 15)
        Result.TabIndex = 5
        Result.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(517, 450)
        Controls.Add(Result)
        Controls.Add(Divide)
        Controls.Add(secondnumber)
        Controls.Add(Label2)
        Controls.Add(firstnumber)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents firstnumber As TextBox
    Friend WithEvents secondnumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Divide As Button
    Friend WithEvents Result As Label
End Class
