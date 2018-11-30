<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
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
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.AddAgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Back_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Add_Btn
        '
        Me.Add_Btn.Location = New System.Drawing.Point(331, 232)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Add_Btn.TabIndex = 17
        Me.Add_Btn.Text = "Add"
        Me.Add_Btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username"
        '
        'AddUsernameTextBox
        '
        Me.AddUsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AddUsernameTextBox.Location = New System.Drawing.Point(331, 56)
        Me.AddUsernameTextBox.Name = "AddUsernameTextBox"
        Me.AddUsernameTextBox.Size = New System.Drawing.Size(100, 27)
        Me.AddUsernameTextBox.TabIndex = 18
        '
        'AddAgeTextBox
        '
        Me.AddAgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AddAgeTextBox.Location = New System.Drawing.Point(331, 94)
        Me.AddAgeTextBox.Name = "AddAgeTextBox"
        Me.AddAgeTextBox.Size = New System.Drawing.Size(100, 27)
        Me.AddAgeTextBox.TabIndex = 19
        '
        'AddAddressTextBox
        '
        Me.AddAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AddAddressTextBox.Location = New System.Drawing.Point(331, 135)
        Me.AddAddressTextBox.Name = "AddAddressTextBox"
        Me.AddAddressTextBox.Size = New System.Drawing.Size(100, 27)
        Me.AddAddressTextBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Password"
        '
        'AddPasswordTextBox
        '
        Me.AddPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AddPasswordTextBox.Location = New System.Drawing.Point(331, 173)
        Me.AddPasswordTextBox.Name = "AddPasswordTextBox"
        Me.AddPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.AddPasswordTextBox.Size = New System.Drawing.Size(100, 27)
        Me.AddPasswordTextBox.TabIndex = 22
        '
        'Back_Btn
        '
        Me.Back_Btn.Location = New System.Drawing.Point(176, 232)
        Me.Back_Btn.Name = "Back_Btn"
        Me.Back_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Back_Btn.TabIndex = 23
        Me.Back_Btn.Text = "Back"
        Me.Back_Btn.UseVisualStyleBackColor = True
        '
        'AddUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Back_Btn)
        Me.Controls.Add(Me.AddPasswordTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AddAddressTextBox)
        Me.Controls.Add(Me.AddAgeTextBox)
        Me.Controls.Add(Me.AddUsernameTextBox)
        Me.Controls.Add(Me.Add_Btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddUserForm"
        Me.Text = "AddUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add_Btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddUsernameTextBox As TextBox
    Friend WithEvents AddAgeTextBox As TextBox
    Friend WithEvents AddAddressTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddPasswordTextBox As TextBox
    Friend WithEvents Back_Btn As Button
End Class
