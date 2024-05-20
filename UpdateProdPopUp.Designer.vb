<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateProdPopUp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProdPopUp))
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUnitPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 5
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.Gold
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdate.Location = New System.Drawing.Point(280, 300)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(133, 45)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 40)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Product"
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
        Me.btnClose.Location = New System.Drawing.Point(446, 300)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(132, 45)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 34)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Product Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 34)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 34)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Product Name"
        '
        'txtProdDesc
        '
        Me.txtProdDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdDesc.DefaultText = ""
        Me.txtProdDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdDesc.DisabledState.Parent = Me.txtProdDesc
        Me.txtProdDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdDesc.FocusedState.Parent = Me.txtProdDesc
        Me.txtProdDesc.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdDesc.ForeColor = System.Drawing.Color.Black
        Me.txtProdDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdDesc.HoverState.Parent = Me.txtProdDesc
        Me.txtProdDesc.Location = New System.Drawing.Point(293, 228)
        Me.txtProdDesc.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdDesc.Name = "txtProdDesc"
        Me.txtProdDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdDesc.PlaceholderText = ""
        Me.txtProdDesc.SelectedText = ""
        Me.txtProdDesc.ShadowDecoration.Parent = Me.txtProdDesc
        Me.txtProdDesc.Size = New System.Drawing.Size(285, 34)
        Me.txtProdDesc.TabIndex = 28
        '
        'txtProdID
        '
        Me.txtProdID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdID.DefaultText = ""
        Me.txtProdID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdID.DisabledState.Parent = Me.txtProdID
        Me.txtProdID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdID.FocusedState.Parent = Me.txtProdID
        Me.txtProdID.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdID.ForeColor = System.Drawing.Color.Black
        Me.txtProdID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdID.HoverState.Parent = Me.txtProdID
        Me.txtProdID.Location = New System.Drawing.Point(293, 109)
        Me.txtProdID.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdID.PlaceholderText = ""
        Me.txtProdID.ReadOnly = True
        Me.txtProdID.SelectedText = ""
        Me.txtProdID.ShadowDecoration.Parent = Me.txtProdID
        Me.txtProdID.Size = New System.Drawing.Size(285, 38)
        Me.txtProdID.TabIndex = 29
        '
        'txtProdName
        '
        Me.txtProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdName.DefaultText = ""
        Me.txtProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdName.DisabledState.Parent = Me.txtProdName
        Me.txtProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.FocusedState.Parent = Me.txtProdName
        Me.txtProdName.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdName.ForeColor = System.Drawing.Color.Black
        Me.txtProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.HoverState.Parent = Me.txtProdName
        Me.txtProdName.Location = New System.Drawing.Point(293, 50)
        Me.txtProdName.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdName.PlaceholderText = ""
        Me.txtProdName.SelectedText = ""
        Me.txtProdName.ShadowDecoration.Parent = Me.txtProdName
        Me.txtProdName.Size = New System.Drawing.Size(285, 34)
        Me.txtProdName.TabIndex = 30
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
        Me.txtUnitPrice.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitPrice.HoverState.Parent = Me.txtUnitPrice
        Me.txtUnitPrice.Location = New System.Drawing.Point(293, 161)
        Me.txtUnitPrice.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnitPrice.PlaceholderText = ""
        Me.txtUnitPrice.ReadOnly = True
        Me.txtUnitPrice.SelectedText = ""
        Me.txtUnitPrice.ShadowDecoration.Parent = Me.txtUnitPrice
        Me.txtUnitPrice.Size = New System.Drawing.Size(285, 38)
        Me.txtUnitPrice.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 34)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Unit Price"
        '
        'UpdateProdPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 390)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtProdDesc)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.txtProdName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateProdPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateProdPopUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProdDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUnitPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
End Class
