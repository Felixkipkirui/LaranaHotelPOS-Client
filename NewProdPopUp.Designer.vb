<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProdPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProdPopUp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProdID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtUnitPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 40)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Product"
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
        Me.btnClose.Location = New System.Drawing.Point(363, 380)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(132, 45)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.Gold
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(206, 380)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(133, 45)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Category"
        '
        'lblProdID
        '
        Me.lblProdID.AutoSize = True
        Me.lblProdID.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdID.Location = New System.Drawing.Point(266, 57)
        Me.lblProdID.Name = "lblProdID"
        Me.lblProdID.Size = New System.Drawing.Size(128, 34)
        Me.lblProdID.TabIndex = 8
        Me.lblProdID.Text = "Category ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(148, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 34)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 34)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Product Name"
        '
        'txtProdName
        '
        Me.txtProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdName.DefaultText = ""
        Me.txtProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdName.DisabledState.Parent = Me.txtProdName
        Me.txtProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.FocusedState.Parent = Me.txtProdName
        Me.txtProdName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdName.ForeColor = System.Drawing.Color.Black
        Me.txtProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.HoverState.Parent = Me.txtProdName
        Me.txtProdName.Location = New System.Drawing.Point(272, 119)
        Me.txtProdName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdName.PlaceholderText = ""
        Me.txtProdName.SelectedText = ""
        Me.txtProdName.ShadowDecoration.Parent = Me.txtProdName
        Me.txtProdName.Size = New System.Drawing.Size(313, 35)
        Me.txtProdName.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnitPrice.DefaultText = ""
        Me.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnitPrice.DisabledState.Parent = Me.txtUnitPrice
        Me.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitPrice.FocusedState.Parent = Me.txtUnitPrice
        Me.txtUnitPrice.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitPrice.HoverState.Parent = Me.txtUnitPrice
        Me.txtUnitPrice.Location = New System.Drawing.Point(272, 245)
        Me.txtUnitPrice.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnitPrice.PlaceholderText = ""
        Me.txtUnitPrice.SelectedText = ""
        Me.txtUnitPrice.ShadowDecoration.Parent = Me.txtUnitPrice
        Me.txtUnitPrice.Size = New System.Drawing.Size(313, 35)
        Me.txtUnitPrice.TabIndex = 12
        '
        'txtProdDescription
        '
        Me.txtProdDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdDescription.DefaultText = ""
        Me.txtProdDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdDescription.DisabledState.Parent = Me.txtProdDescription
        Me.txtProdDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdDescription.FocusedState.Parent = Me.txtProdDescription
        Me.txtProdDescription.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdDescription.ForeColor = System.Drawing.Color.Black
        Me.txtProdDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdDescription.HoverState.Parent = Me.txtProdDescription
        Me.txtProdDescription.Location = New System.Drawing.Point(272, 308)
        Me.txtProdDescription.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtProdDescription.Name = "txtProdDescription"
        Me.txtProdDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdDescription.PlaceholderText = ""
        Me.txtProdDescription.SelectedText = ""
        Me.txtProdDescription.ShadowDecoration.Parent = Me.txtProdDescription
        Me.txtProdDescription.Size = New System.Drawing.Size(313, 35)
        Me.txtProdDescription.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 34)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Unit Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 34)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Description"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderColor = System.Drawing.Color.Gold
        Me.cmbCategory.BorderRadius = 5
        Me.cmbCategory.BorderThickness = 2
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCategory.FocusedState.Parent = Me.cmbCategory
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.HoverState.Parent = Me.cmbCategory
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.ItemsAppearance.Parent = Me.cmbCategory
        Me.cmbCategory.Location = New System.Drawing.Point(272, 181)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.ShadowDecoration.Parent = Me.cmbCategory
        Me.cmbCategory.Size = New System.Drawing.Size(313, 36)
        Me.cmbCategory.TabIndex = 15
        '
        'NewProdPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 450)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblProdID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProdDescription)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtProdName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewProdPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NewProdPopUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProdID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtUnitPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
End Class
