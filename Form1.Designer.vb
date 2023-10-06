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
        lbAbs = New Label()
        Label3 = New Label()
        btnCompute = New Button()
        txtNum = New TextBox()
        txtAbsV = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 0
        Label1.Text = "Number"
        ' 
        ' lbAbs
        ' 
        lbAbs.AutoSize = True
        lbAbs.Location = New Point(98, 109)
        lbAbs.Name = "lbAbs"
        lbAbs.Size = New Size(108, 20)
        lbAbs.TabIndex = 1
        lbAbs.Text = "Absolute Value"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Highlight
        Label3.Location = New Point(252, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 2
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(231, 181)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 29)
        btnCompute.TabIndex = 3
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(252, 49)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(125, 27)
        txtNum.TabIndex = 4
        ' 
        ' txtAbsV
        ' 
        txtAbsV.Location = New Point(254, 107)
        txtAbsV.Name = "txtAbsV"
        txtAbsV.Size = New Size(125, 27)
        txtAbsV.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtAbsV)
        Controls.Add(txtNum)
        Controls.Add(btnCompute)
        Controls.Add(Label3)
        Controls.Add(lbAbs)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Absolute Value"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbAbs As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtAbsV As TextBox
End Class
