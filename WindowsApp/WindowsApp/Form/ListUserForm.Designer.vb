<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListUserForm
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
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.user_name = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.user_age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoveToAddFormBtn = New System.Windows.Forms.Button()
        Me.PagingBackBtn = New System.Windows.Forms.Button()
        Me.PagingNextBtn = New System.Windows.Forms.Button()
        Me.PagingDisplay = New System.Windows.Forms.Label()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_name, Me.user_age, Me.user_address})
        Me.UserDataGridView.Location = New System.Drawing.Point(232, 93)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(343, 150)
        Me.UserDataGridView.TabIndex = 1
        '
        'user_name
        '
        Me.user_name.HeaderText = "Username"
        Me.user_name.Name = "user_name"
        Me.user_name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'user_age
        '
        Me.user_age.HeaderText = "Age"
        Me.user_age.Name = "user_age"
        '
        'user_address
        '
        Me.user_address.HeaderText = "Address"
        Me.user_address.Name = "user_address"
        '
        'MoveToAddFormBtn
        '
        Me.MoveToAddFormBtn.Location = New System.Drawing.Point(232, 286)
        Me.MoveToAddFormBtn.Name = "MoveToAddFormBtn"
        Me.MoveToAddFormBtn.Size = New System.Drawing.Size(123, 36)
        Me.MoveToAddFormBtn.TabIndex = 2
        Me.MoveToAddFormBtn.Text = "Add New User"
        Me.MoveToAddFormBtn.UseVisualStyleBackColor = True
        '
        'PagingBackBtn
        '
        Me.PagingBackBtn.Location = New System.Drawing.Point(259, 57)
        Me.PagingBackBtn.Name = "PagingBackBtn"
        Me.PagingBackBtn.Size = New System.Drawing.Size(75, 23)
        Me.PagingBackBtn.TabIndex = 3
        Me.PagingBackBtn.Text = "Back"
        Me.PagingBackBtn.UseVisualStyleBackColor = True
        '
        'PagingNextBtn
        '
        Me.PagingNextBtn.Location = New System.Drawing.Point(472, 57)
        Me.PagingNextBtn.Name = "PagingNextBtn"
        Me.PagingNextBtn.Size = New System.Drawing.Size(75, 23)
        Me.PagingNextBtn.TabIndex = 4
        Me.PagingNextBtn.Text = "Next"
        Me.PagingNextBtn.UseVisualStyleBackColor = True
        '
        'PagingDisplay
        '
        Me.PagingDisplay.AutoSize = True
        Me.PagingDisplay.Location = New System.Drawing.Point(380, 62)
        Me.PagingDisplay.Name = "PagingDisplay"
        Me.PagingDisplay.Size = New System.Drawing.Size(39, 13)
        Me.PagingDisplay.TabIndex = 5
        Me.PagingDisplay.Text = "Label1"
        '
        'ListUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PagingDisplay)
        Me.Controls.Add(Me.PagingNextBtn)
        Me.Controls.Add(Me.PagingBackBtn)
        Me.Controls.Add(Me.MoveToAddFormBtn)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Name = "ListUserForm"
        Me.Text = "ListUser"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents user_name As DataGridViewLinkColumn
    Friend WithEvents user_age As DataGridViewTextBoxColumn
    Friend WithEvents user_address As DataGridViewTextBoxColumn
    Friend WithEvents MoveToAddFormBtn As Button
    Friend WithEvents PagingBackBtn As Button
    Friend WithEvents PagingNextBtn As Button
    Friend WithEvents PagingDisplay As Label
End Class
