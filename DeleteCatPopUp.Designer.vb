<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCatPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteCatPopUp))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCatDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCatName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCatID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 40)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Category"
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 5
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClose.Location = New System.Drawing.Point(489, 303)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(132, 45)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 5
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.Gold
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.Location = New System.Drawing.Point(323, 303)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(133, 45)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Category Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 34)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Category ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 34)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Category Name"
        '
        'txtCatDesc
        '
        Me.txtCatDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCatDesc.DefaultText = ""
        Me.txtCatDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCatDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCatDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCatDesc.DisabledState.Parent = Me.txtCatDesc
        Me.txtCatDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCatDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatDesc.FocusedState.Parent = Me.txtCatDesc
        Me.txtCatDesc.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatDesc.ForeColor = System.Drawing.Color.Black
        Me.txtCatDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatDesc.HoverState.Parent = Me.txtCatDesc
        Me.txtCatDesc.Location = New System.Drawing.Point(293, 214)
        Me.txtCatDesc.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtCatDesc.Name = "txtCatDesc"
        Me.txtCatDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCatDesc.PlaceholderText = ""
        Me.txtCatDesc.SelectedText = ""
        Me.txtCatDesc.ShadowDecoration.Parent = Me.txtCatDesc
        Me.txtCatDesc.Size = New System.Drawing.Size(285, 34)
        Me.txtCatDesc.TabIndex = 11
        '
        'txtCatName
        '
        Me.txtCatName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCatName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCatName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCatName.DefaultText = ""
        Me.txtCatName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCatName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCatName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCatName.DisabledState.Parent = Me.txtCatName
        Me.txtCatName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatName.FocusedState.Parent = Me.txtCatName
        Me.txtCatName.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatName.ForeColor = System.Drawing.Color.Black
        Me.txtCatName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatName.HoverState.Parent = Me.txtCatName
        Me.txtCatName.Location = New System.Drawing.Point(293, 149)
        Me.txtCatName.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtCatName.Name = "txtCatName"
        Me.txtCatName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCatName.PlaceholderText = ""
        Me.txtCatName.SelectedText = ""
        Me.txtCatName.ShadowDecoration.Parent = Me.txtCatName
        Me.txtCatName.Size = New System.Drawing.Size(285, 34)
        Me.txtCatName.TabIndex = 12
        '
        'txtCatID
        '
        Me.txtCatID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCatID.DefaultText = ""
        Me.txtCatID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCatID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCatID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCatID.DisabledState.Parent = Me.txtCatID
        Me.txtCatID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCatID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatID.FocusedState.Parent = Me.txtCatID
        Me.txtCatID.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatID.ForeColor = System.Drawing.Color.Black
        Me.txtCatID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatID.HoverState.Parent = Me.txtCatID
        Me.txtCatID.Location = New System.Drawing.Point(293, 80)
        Me.txtCatID.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCatID.PlaceholderText = ""
        Me.txtCatID.ReadOnly = True
        Me.txtCatID.SelectedText = ""
        Me.txtCatID.ShadowDecoration.Parent = Me.txtCatID
        Me.txtCatID.Size = New System.Drawing.Size(285, 38)
        Me.txtCatID.TabIndex = 12
        '
        'DeleteCatPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(685, 380)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCatDesc)
        Me.Controls.Add(Me.txtCatID)
        Me.Controls.Add(Me.txtCatName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeleteCatPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DeleteCatPopUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCatDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCatName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCatID As Guna.UI2.WinForms.Guna2TextBox
End Class
