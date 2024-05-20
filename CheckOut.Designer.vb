<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.txtTransactionNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OrderDetailsDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbMode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRecievedBy = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRecieved = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCheckOut = New Guna.UI2.WinForms.Guna2Button()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.txtServedBy = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.OrderDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatePicker
        '
        Me.DatePicker.AllowDrop = True
        Me.DatePicker.Animated = True
        Me.DatePicker.CheckedState.Parent = Me.DatePicker
        Me.DatePicker.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DatePicker.HoverState.Parent = Me.DatePicker
        Me.DatePicker.Location = New System.Drawing.Point(391, 5)
        Me.DatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.ShadowDecoration.Parent = Me.DatePicker
        Me.DatePicker.Size = New System.Drawing.Size(314, 38)
        Me.DatePicker.TabIndex = 32
        Me.DatePicker.Value = New Date(2023, 8, 11, 17, 21, 58, 802)
        '
        'btnView
        '
        Me.btnView.BorderRadius = 5
        Me.btnView.CheckedState.Parent = Me.btnView
        Me.btnView.CustomImages.Parent = Me.btnView
        Me.btnView.FillColor = System.Drawing.Color.Gold
        Me.btnView.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Black
        Me.btnView.HoverState.Parent = Me.btnView
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnView.Location = New System.Drawing.Point(233, 56)
        Me.btnView.Name = "btnView"
        Me.btnView.ShadowDecoration.Parent = Me.btnView
        Me.btnView.Size = New System.Drawing.Size(197, 45)
        Me.btnView.TabIndex = 28
        Me.btnView.Text = "View Order"
        '
        'txtTransactionNumber
        '
        Me.txtTransactionNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTransactionNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTransactionNumber.BorderColor = System.Drawing.Color.Gold
        Me.txtTransactionNumber.BorderRadius = 15
        Me.txtTransactionNumber.BorderThickness = 2
        Me.txtTransactionNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionNumber.DefaultText = ""
        Me.txtTransactionNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTransactionNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTransactionNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransactionNumber.DisabledState.Parent = Me.txtTransactionNumber
        Me.txtTransactionNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransactionNumber.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtTransactionNumber.FocusedState.Parent = Me.txtTransactionNumber
        Me.txtTransactionNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionNumber.ForeColor = System.Drawing.Color.Black
        Me.txtTransactionNumber.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtTransactionNumber.HoverState.Parent = Me.txtTransactionNumber
        Me.txtTransactionNumber.IconRight = CType(resources.GetObject("txtTransactionNumber.IconRight"), System.Drawing.Image)
        Me.txtTransactionNumber.IconRightSize = New System.Drawing.Size(25, 25)
        Me.txtTransactionNumber.Location = New System.Drawing.Point(13, 5)
        Me.txtTransactionNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTransactionNumber.Name = "txtTransactionNumber"
        Me.txtTransactionNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransactionNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtTransactionNumber.PlaceholderText = "Search Transaction ID"
        Me.txtTransactionNumber.SelectedText = ""
        Me.txtTransactionNumber.ShadowDecoration.Parent = Me.txtTransactionNumber
        Me.txtTransactionNumber.Size = New System.Drawing.Size(340, 43)
        Me.txtTransactionNumber.TabIndex = 29
        '
        'OrderDetailsDGV
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OrderDetailsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.OrderDetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderDetailsDGV.BackgroundColor = System.Drawing.Color.White
        Me.OrderDetailsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrderDetailsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrderDetailsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderDetailsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.OrderDetailsDGV.ColumnHeadersHeight = 25
        Me.OrderDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderDetailsDGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.OrderDetailsDGV.EnableHeadersVisualStyles = False
        Me.OrderDetailsDGV.GridColor = System.Drawing.Color.WhiteSmoke
        Me.OrderDetailsDGV.Location = New System.Drawing.Point(491, 49)
        Me.OrderDetailsDGV.Name = "OrderDetailsDGV"
        Me.OrderDetailsDGV.RowHeadersVisible = False
        Me.OrderDetailsDGV.RowTemplate.Height = 25
        Me.OrderDetailsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.OrderDetailsDGV.Size = New System.Drawing.Size(227, 136)
        Me.OrderDetailsDGV.TabIndex = 31
        Me.OrderDetailsDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.OrderDetailsDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.OrderDetailsDGV.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange
        Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.Height = 25
        Me.OrderDetailsDGV.ThemeStyle.ReadOnly = False
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.Height = 25
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderDetailsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmbMode
        '
        Me.cmbMode.BackColor = System.Drawing.Color.Transparent
        Me.cmbMode.BorderColor = System.Drawing.Color.Gold
        Me.cmbMode.BorderRadius = 5
        Me.cmbMode.BorderThickness = 2
        Me.cmbMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMode.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMode.FocusedState.Parent = Me.cmbMode
        Me.cmbMode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.HoverState.Parent = Me.cmbMode
        Me.cmbMode.ItemHeight = 30
        Me.cmbMode.Items.AddRange(New Object() {"CASH", "MOBILE-MONEY", "BANK-TRANSAFER"})
        Me.cmbMode.ItemsAppearance.Parent = Me.cmbMode
        Me.cmbMode.Location = New System.Drawing.Point(505, 201)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.ShadowDecoration.Parent = Me.cmbMode
        Me.cmbMode.Size = New System.Drawing.Size(200, 36)
        Me.cmbMode.TabIndex = 47
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtDescription.BorderColor = System.Drawing.Color.Gold
        Me.txtDescription.BorderRadius = 10
        Me.txtDescription.BorderThickness = 2
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.Parent = Me.txtDescription
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtDescription.FocusedState.Parent = Me.txtDescription
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtDescription.HoverState.Parent = Me.txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(505, 274)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(200, 38)
        Me.txtDescription.TabIndex = 41
        '
        'txtRecievedBy
        '
        Me.txtRecievedBy.BackColor = System.Drawing.Color.Transparent
        Me.txtRecievedBy.BorderColor = System.Drawing.Color.Gold
        Me.txtRecievedBy.BorderRadius = 10
        Me.txtRecievedBy.BorderThickness = 2
        Me.txtRecievedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRecievedBy.DefaultText = ""
        Me.txtRecievedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRecievedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRecievedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecievedBy.DisabledState.Parent = Me.txtRecievedBy
        Me.txtRecievedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecievedBy.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtRecievedBy.FocusedState.Parent = Me.txtRecievedBy
        Me.txtRecievedBy.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecievedBy.ForeColor = System.Drawing.Color.Crimson
        Me.txtRecievedBy.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtRecievedBy.HoverState.Parent = Me.txtRecievedBy
        Me.txtRecievedBy.Location = New System.Drawing.Point(505, 335)
        Me.txtRecievedBy.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtRecievedBy.Name = "txtRecievedBy"
        Me.txtRecievedBy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecievedBy.PlaceholderText = ""
        Me.txtRecievedBy.SelectedText = ""
        Me.txtRecievedBy.ShadowDecoration.Parent = Me.txtRecievedBy
        Me.txtRecievedBy.Size = New System.Drawing.Size(200, 38)
        Me.txtRecievedBy.TabIndex = 42
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Transparent
        Me.txtBalance.BorderColor = System.Drawing.Color.Gold
        Me.txtBalance.BorderRadius = 10
        Me.txtBalance.BorderThickness = 2
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.DefaultText = ""
        Me.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBalance.DisabledState.Parent = Me.txtBalance
        Me.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBalance.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtBalance.FocusedState.Parent = Me.txtBalance
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtBalance.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtBalance.HoverState.Parent = Me.txtBalance
        Me.txtBalance.Location = New System.Drawing.Point(110, 385)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBalance.PlaceholderText = ""
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.SelectedText = ""
        Me.txtBalance.ShadowDecoration.Parent = Me.txtBalance
        Me.txtBalance.Size = New System.Drawing.Size(200, 38)
        Me.txtBalance.TabIndex = 43
        '
        'txtRecieved
        '
        Me.txtRecieved.BackColor = System.Drawing.Color.Transparent
        Me.txtRecieved.BorderColor = System.Drawing.Color.Gold
        Me.txtRecieved.BorderRadius = 10
        Me.txtRecieved.BorderThickness = 2
        Me.txtRecieved.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRecieved.DefaultText = ""
        Me.txtRecieved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRecieved.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRecieved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecieved.DisabledState.Parent = Me.txtRecieved
        Me.txtRecieved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecieved.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtRecieved.FocusedState.Parent = Me.txtRecieved
        Me.txtRecieved.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecieved.ForeColor = System.Drawing.Color.Black
        Me.txtRecieved.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtRecieved.HoverState.Parent = Me.txtRecieved
        Me.txtRecieved.Location = New System.Drawing.Point(110, 335)
        Me.txtRecieved.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtRecieved.Name = "txtRecieved"
        Me.txtRecieved.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecieved.PlaceholderText = ""
        Me.txtRecieved.SelectedText = ""
        Me.txtRecieved.ShadowDecoration.Parent = Me.txtRecieved
        Me.txtRecieved.Size = New System.Drawing.Size(200, 38)
        Me.txtRecieved.TabIndex = 44
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BorderRadius = 5
        Me.btnCheckOut.CheckedState.Parent = Me.btnCheckOut
        Me.btnCheckOut.CustomImages.Parent = Me.btnCheckOut
        Me.btnCheckOut.FillColor = System.Drawing.Color.Gold
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.Black
        Me.btnCheckOut.HoverState.Parent = Me.btnCheckOut
        Me.btnCheckOut.Image = CType(resources.GetObject("btnCheckOut.Image"), System.Drawing.Image)
        Me.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCheckOut.Location = New System.Drawing.Point(400, 385)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.ShadowDecoration.Parent = Me.btnCheckOut
        Me.btnCheckOut.Size = New System.Drawing.Size(188, 45)
        Me.btnCheckOut.TabIndex = 40
        Me.btnCheckOut.Text = "CheckOut"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.BorderColor = System.Drawing.Color.Gold
        Me.txtTotal.BorderRadius = 10
        Me.txtTotal.BorderThickness = 2
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.Parent = Me.txtTotal
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtTotal.FocusedState.Parent = Me.txtTotal
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtTotal.HoverState.Parent = Me.txtTotal
        Me.txtTotal.Location = New System.Drawing.Point(110, 272)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.Size = New System.Drawing.Size(200, 38)
        Me.txtTotal.TabIndex = 45
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtSubTotal.BorderColor = System.Drawing.Color.Gold
        Me.txtSubTotal.BorderRadius = 10
        Me.txtSubTotal.BorderThickness = 2
        Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubTotal.DefaultText = ""
        Me.txtSubTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubTotal.DisabledState.Parent = Me.txtSubTotal
        Me.txtSubTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubTotal.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtSubTotal.FocusedState.Parent = Me.txtSubTotal
        Me.txtSubTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtSubTotal.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtSubTotal.HoverState.Parent = Me.txtSubTotal
        Me.txtSubTotal.Location = New System.Drawing.Point(110, 201)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubTotal.PlaceholderText = ""
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.SelectedText = ""
        Me.txtSubTotal.ShadowDecoration.Parent = Me.txtSubTotal
        Me.txtSubTotal.Size = New System.Drawing.Size(200, 38)
        Me.txtSubTotal.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(381, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 26)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 26)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Payment Mode"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(383, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 26)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "RecievedBy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Recieved"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 397)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 26)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Balance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "SubTotal"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 86400000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8
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
        Me.btnClose.Location = New System.Drawing.Point(615, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(132, 45)
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "Close"
        '
        'txtServedBy
        '
        Me.txtServedBy.BackColor = System.Drawing.Color.Transparent
        Me.txtServedBy.BorderColor = System.Drawing.Color.Gold
        Me.txtServedBy.BorderRadius = 10
        Me.txtServedBy.BorderThickness = 2
        Me.txtServedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServedBy.DefaultText = ""
        Me.txtServedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtServedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtServedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServedBy.DisabledState.Parent = Me.txtServedBy
        Me.txtServedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServedBy.FocusedState.BorderColor = System.Drawing.Color.Transparent
        Me.txtServedBy.FocusedState.Parent = Me.txtServedBy
        Me.txtServedBy.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServedBy.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtServedBy.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.txtServedBy.HoverState.Parent = Me.txtServedBy
        Me.txtServedBy.Location = New System.Drawing.Point(110, 147)
        Me.txtServedBy.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtServedBy.Name = "txtServedBy"
        Me.txtServedBy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServedBy.PlaceholderText = ""
        Me.txtServedBy.ReadOnly = True
        Me.txtServedBy.SelectedText = ""
        Me.txtServedBy.ShadowDecoration.Parent = Me.txtServedBy
        Me.txtServedBy.Size = New System.Drawing.Size(200, 38)
        Me.txtServedBy.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 26)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "ServedBy"
        '
        'btnPrint
        '
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(727, 201)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(180, 45)
        Me.btnPrint.TabIndex = 51
        Me.btnPrint.Text = "Guna2Button1"
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 480)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtServedBy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtRecievedBy)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtRecieved)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtTransactionNumber)
        Me.Controls.Add(Me.OrderDetailsDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckOut"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CheckOut"
        CType(Me.OrderDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtTransactionNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OrderDetailsDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbMode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRecievedBy As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRecieved As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCheckOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtServedBy As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
End Class
