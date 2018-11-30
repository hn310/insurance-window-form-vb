<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDeleteForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Edit_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Back_Btn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.EditAgeTextBox = New System.Windows.Forms.TextBox()
        Me.EditAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EditPasswordLabel = New System.Windows.Forms.Label()
        Me.EditPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Edit_Btn
        '
        Me.Edit_Btn.Location = New System.Drawing.Point(300, 241)
        Me.Edit_Btn.Name = "Edit_Btn"
        Me.Edit_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Btn.TabIndex = 6
        Me.Edit_Btn.Text = "Edit"
        Me.Edit_Btn.UseVisualStyleBackColor = True
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Location = New System.Drawing.Point(441, 241)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Btn.TabIndex = 7
        Me.Delete_Btn.Text = "Delete"
        Me.Delete_Btn.UseVisualStyleBackColor = True
        '
        'Back_Btn
        '
        Me.Back_Btn.Location = New System.Drawing.Point(150, 241)
        Me.Back_Btn.Name = "Back_Btn"
        Me.Back_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Back_Btn.TabIndex = 8
        Me.Back_Btn.Text = "Back"
        Me.Back_Btn.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'EditUsernameTextBox
        '
        Me.EditUsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EditUsernameTextBox.Location = New System.Drawing.Point(277, 52)
        Me.EditUsernameTextBox.Name = "EditUsernameTextBox"
        Me.EditUsernameTextBox.ReadOnly = True
        Me.EditUsernameTextBox.Size = New System.Drawing.Size(100, 30)
        Me.EditUsernameTextBox.TabIndex = 10
        '
        'EditAgeTextBox
        '
        Me.EditAgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EditAgeTextBox.Location = New System.Drawing.Point(277, 90)
        Me.EditAgeTextBox.Name = "EditAgeTextBox"
        Me.EditAgeTextBox.ReadOnly = True
        Me.EditAgeTextBox.Size = New System.Drawing.Size(100, 30)
        Me.EditAgeTextBox.TabIndex = 11
        '
        'EditAddressTextBox
        '
        Me.EditAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EditAddressTextBox.Location = New System.Drawing.Point(277, 131)
        Me.EditAddressTextBox.Name = "EditAddressTextBox"
        Me.EditAddressTextBox.ReadOnly = True
        Me.EditAddressTextBox.Size = New System.Drawing.Size(100, 30)
        Me.EditAddressTextBox.TabIndex = 12
        '
        'EditPasswordLabel
        '
        Me.EditPasswordLabel.AutoSize = True
        Me.EditPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EditPasswordLabel.Location = New System.Drawing.Point(147, 178)
        Me.EditPasswordLabel.Name = "EditPasswordLabel"
        Me.EditPasswordLabel.Size = New System.Drawing.Size(98, 25)
        Me.EditPasswordLabel.TabIndex = 13
        Me.EditPasswordLabel.Text = "Password"
        '
        'EditPasswordTextBox
        '
        Me.EditPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EditPasswordTextBox.Location = New System.Drawing.Point(275, 175)
        Me.EditPasswordTextBox.Name = "EditPasswordTextBox"
        Me.EditPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EditPasswordTextBox.Size = New System.Drawing.Size(100, 30)
        Me.EditPasswordTextBox.TabIndex = 14
        '
        'EditDeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EditPasswordTextBox)
        Me.Controls.Add(Me.EditPasswordLabel)
        Me.Controls.Add(Me.EditAddressTextBox)
        Me.Controls.Add(Me.EditAgeTextBox)
        Me.Controls.Add(Me.EditUsernameTextBox)
        Me.Controls.Add(Me.Back_Btn)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Edit_Btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditDeleteForm"
        Me.Text = "EditDelete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Edit_Btn As Button
    Friend WithEvents Delete_Btn As Button
    Friend WithEvents Back_Btn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditUsernameTextBox As TextBox
    Friend WithEvents EditAgeTextBox As TextBox
    Friend WithEvents EditAddressTextBox As TextBox
    Friend WithEvents EditPasswordLabel As Label
    Friend WithEvents EditPasswordTextBox As TextBox
End Class
