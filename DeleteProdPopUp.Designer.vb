<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteProdPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteProdPopUp))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProdDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(715, 40)
        Me.Panel1.TabIndex = 15
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
        Me.btnClose.Location = New System.Drawing.Point(486, 381)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(132, 45)
        Me.btnClose.TabIndex = 22
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
        Me.btnDelete.Location = New System.Drawing.Point(317, 381)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(133, 45)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 34)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Unit Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 34)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 34)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Product Name"
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdPrice.DefaultText = ""
        Me.txtProdPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdPrice.DisabledState.Parent = Me.txtProdPrice
        Me.txtProdPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdPrice.FocusedState.Parent = Me.txtProdPrice
        Me.txtProdPrice.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdPrice.ForeColor = System.Drawing.Color.Black
        Me.txtProdPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdPrice.HoverState.Parent = Me.txtProdPrice
        Me.txtProdPrice.Location = New System.Drawing.Point(293, 253)
        Me.txtProdPrice.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdPrice.PlaceholderText = ""
        Me.txtProdPrice.SelectedText = ""
        Me.txtProdPrice.ShadowDecoration.Parent = Me.txtProdPrice
        Me.txtProdPrice.Size = New System.Drawing.Size(285, 34)
        Me.txtProdPrice.TabIndex = 19
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
        Me.txtProdID.Location = New System.Drawing.Point(293, 125)
        Me.txtProdID.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdID.PlaceholderText = ""
        Me.txtProdID.ReadOnly = True
        Me.txtProdID.SelectedText = ""
        Me.txtProdID.ShadowDecoration.Parent = Me.txtProdID
        Me.txtProdID.Size = New System.Drawing.Size(285, 38)
        Me.txtProdID.TabIndex = 20
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
        Me.txtProdName.Location = New System.Drawing.Point(293, 67)
        Me.txtProdName.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdName.PlaceholderText = ""
        Me.txtProdName.SelectedText = ""
        Me.txtProdName.ShadowDecoration.Parent = Me.txtProdName
        Me.txtProdName.Size = New System.Drawing.Size(285, 34)
        Me.txtProdName.TabIndex = 21
        '
        'txtProdCat
        '
        Me.txtProdCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdCat.DefaultText = ""
        Me.txtProdCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdCat.DisabledState.Parent = Me.txtProdCat
        Me.txtProdCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdCat.FocusedState.Parent = Me.txtProdCat
        Me.txtProdCat.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdCat.ForeColor = System.Drawing.Color.Black
        Me.txtProdCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdCat.HoverState.Parent = Me.txtProdCat
        Me.txtProdCat.Location = New System.Drawing.Point(293, 187)
        Me.txtProdCat.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdCat.Name = "txtProdCat"
        Me.txtProdCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdCat.PlaceholderText = ""
        Me.txtProdCat.ReadOnly = True
        Me.txtProdCat.SelectedText = ""
        Me.txtProdCat.ShadowDecoration.Parent = Me.txtProdCat
        Me.txtProdCat.Size = New System.Drawing.Size(285, 38)
        Me.txtProdCat.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 34)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Product Category"
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
        Me.txtProdDesc.Location = New System.Drawing.Point(293, 315)
        Me.txtProdDesc.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProdDesc.Name = "txtProdDesc"
        Me.txtProdDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdDesc.PlaceholderText = ""
        Me.txtProdDesc.SelectedText = ""
        Me.txtProdDesc.ShadowDecoration.Parent = Me.txtProdDesc
        Me.txtProdDesc.Size = New System.Drawing.Size(285, 34)
        Me.txtProdDesc.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 34)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Product Description"
        '
        'DeleteProdPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProdDesc)
        Me.Controls.Add(Me.txtProdCat)
        Me.Controls.Add(Me.txtProdPrice)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.txtProdName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeleteProdPopUp"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DeleteProdPopUp"
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
    Friend WithEvents txtProdPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProdDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
