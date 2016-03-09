<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoginBt = New System.Windows.Forms.Button()
        Me.Passwordtb = New System.Windows.Forms.TextBox()
        Me.Usernametb = New System.Windows.Forms.TextBox()
        Me.Passwordlb = New System.Windows.Forms.Label()
        Me.Usernamelb = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LoginBt)
        Me.GroupBox1.Controls.Add(Me.Passwordtb)
        Me.GroupBox1.Controls.Add(Me.Usernametb)
        Me.GroupBox1.Controls.Add(Me.Passwordlb)
        Me.GroupBox1.Controls.Add(Me.Usernamelb)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(37, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 117)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOG IN"
        '
        'LoginBt
        '
        Me.LoginBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LoginBt.Location = New System.Drawing.Point(145, 76)
        Me.LoginBt.Name = "LoginBt"
        Me.LoginBt.Size = New System.Drawing.Size(75, 23)
        Me.LoginBt.TabIndex = 4
        Me.LoginBt.Text = "LOG IN"
        Me.LoginBt.UseVisualStyleBackColor = True
        '
        'Passwordtb
        '
        Me.Passwordtb.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordtb.Location = New System.Drawing.Point(106, 52)
        Me.Passwordtb.Name = "Passwordtb"
        Me.Passwordtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passwordtb.Size = New System.Drawing.Size(114, 18)
        Me.Passwordtb.TabIndex = 3
        '
        'Usernametb
        '
        Me.Usernametb.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernametb.Location = New System.Drawing.Point(106, 30)
        Me.Usernametb.Name = "Usernametb"
        Me.Usernametb.Size = New System.Drawing.Size(114, 18)
        Me.Usernametb.TabIndex = 2
        '
        'Passwordlb
        '
        Me.Passwordlb.AutoSize = True
        Me.Passwordlb.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordlb.Location = New System.Drawing.Point(31, 50)
        Me.Passwordlb.Name = "Passwordlb"
        Me.Passwordlb.Size = New System.Drawing.Size(69, 16)
        Me.Passwordlb.TabIndex = 1
        Me.Passwordlb.Text = "PASSWORD"
        '
        'Usernamelb
        '
        Me.Usernamelb.AutoSize = True
        Me.Usernamelb.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelb.Location = New System.Drawing.Point(31, 29)
        Me.Usernamelb.Name = "Usernamelb"
        Me.Usernamelb.Size = New System.Drawing.Size(69, 16)
        Me.Usernamelb.TabIndex = 0
        Me.Usernamelb.Text = "USERNAME"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HR_InfoSystem.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(578, 339)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoginBt As System.Windows.Forms.Button
    Friend WithEvents Passwordtb As System.Windows.Forms.TextBox
    Friend WithEvents Usernametb As System.Windows.Forms.TextBox
    Friend WithEvents Passwordlb As System.Windows.Forms.Label
    Friend WithEvents Usernamelb As System.Windows.Forms.Label
End Class
