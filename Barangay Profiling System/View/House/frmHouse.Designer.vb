<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHouse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHouse))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.btnAddHouseOwner = New System.Windows.Forms.Button()
        Me.btnBrowseHouseOwner = New System.Windows.Forms.Button()
        Me.btnSameOwner = New System.Windows.Forms.Button()
        Me.btnAddLotOwner = New System.Windows.Forms.Button()
        Me.btnBrowseLotOwner = New System.Windows.Forms.Button()
        Me.btnHouseAddress = New System.Windows.Forms.Button()
        Me.txtHouseAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHouseLevel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHouseName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHouseOwnerName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHouseCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLotOwnerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtLotCode = New System.Windows.Forms.TextBox()
        Me.rbtnLegal = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbtnIllegal = New System.Windows.Forms.RadioButton()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnShowRecords = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 60)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1299, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "HOUSE MODULE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 532)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1299, 60)
        Me.Panel2.TabIndex = 9
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlInfo.Controls.Add(Me.btnAddHouseOwner)
        Me.pnlInfo.Controls.Add(Me.btnBrowseHouseOwner)
        Me.pnlInfo.Controls.Add(Me.btnSameOwner)
        Me.pnlInfo.Controls.Add(Me.btnAddLotOwner)
        Me.pnlInfo.Controls.Add(Me.btnBrowseLotOwner)
        Me.pnlInfo.Controls.Add(Me.btnHouseAddress)
        Me.pnlInfo.Controls.Add(Me.txtHouseAddress)
        Me.pnlInfo.Controls.Add(Me.Label7)
        Me.pnlInfo.Controls.Add(Me.txtHouseLevel)
        Me.pnlInfo.Controls.Add(Me.Label6)
        Me.pnlInfo.Controls.Add(Me.txtHouseName)
        Me.pnlInfo.Controls.Add(Me.Label5)
        Me.pnlInfo.Controls.Add(Me.txtHouseOwnerName)
        Me.pnlInfo.Controls.Add(Me.Label4)
        Me.pnlInfo.Controls.Add(Me.txtHouseCode)
        Me.pnlInfo.Controls.Add(Me.Label3)
        Me.pnlInfo.Controls.Add(Me.txtLotOwnerName)
        Me.pnlInfo.Controls.Add(Me.Label2)
        Me.pnlInfo.Controls.Add(Me.cboType)
        Me.pnlInfo.Controls.Add(Me.txtLotCode)
        Me.pnlInfo.Controls.Add(Me.rbtnLegal)
        Me.pnlInfo.Controls.Add(Me.Label13)
        Me.pnlInfo.Controls.Add(Me.Label11)
        Me.pnlInfo.Controls.Add(Me.Label12)
        Me.pnlInfo.Controls.Add(Me.rbtnIllegal)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInfo.Location = New System.Drawing.Point(265, 60)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(801, 472)
        Me.pnlInfo.TabIndex = 13
        '
        'btnAddHouseOwner
        '
        Me.btnAddHouseOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddHouseOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddHouseOwner.FlatAppearance.BorderSize = 0
        Me.btnAddHouseOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddHouseOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHouseOwner.ForeColor = System.Drawing.Color.White
        Me.btnAddHouseOwner.Location = New System.Drawing.Point(295, 300)
        Me.btnAddHouseOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddHouseOwner.Name = "btnAddHouseOwner"
        Me.btnAddHouseOwner.Size = New System.Drawing.Size(27, 27)
        Me.btnAddHouseOwner.TabIndex = 292
        Me.btnAddHouseOwner.Text = "+"
        Me.btnAddHouseOwner.UseVisualStyleBackColor = False
        '
        'btnBrowseHouseOwner
        '
        Me.btnBrowseHouseOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseHouseOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBrowseHouseOwner.FlatAppearance.BorderSize = 0
        Me.btnBrowseHouseOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseHouseOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseHouseOwner.ForeColor = System.Drawing.Color.White
        Me.btnBrowseHouseOwner.Location = New System.Drawing.Point(330, 300)
        Me.btnBrowseHouseOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowseHouseOwner.Name = "btnBrowseHouseOwner"
        Me.btnBrowseHouseOwner.Size = New System.Drawing.Size(27, 27)
        Me.btnBrowseHouseOwner.TabIndex = 291
        Me.btnBrowseHouseOwner.Text = "..."
        Me.btnBrowseHouseOwner.UseVisualStyleBackColor = False
        '
        'btnSameOwner
        '
        Me.btnSameOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSameOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSameOwner.FlatAppearance.BorderSize = 0
        Me.btnSameOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSameOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSameOwner.ForeColor = System.Drawing.Color.White
        Me.btnSameOwner.Location = New System.Drawing.Point(365, 300)
        Me.btnSameOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSameOwner.Name = "btnSameOwner"
        Me.btnSameOwner.Size = New System.Drawing.Size(27, 27)
        Me.btnSameOwner.TabIndex = 290
        Me.btnSameOwner.UseVisualStyleBackColor = False
        '
        'btnAddLotOwner
        '
        Me.btnAddLotOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddLotOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddLotOwner.FlatAppearance.BorderSize = 0
        Me.btnAddLotOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLotOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLotOwner.ForeColor = System.Drawing.Color.White
        Me.btnAddLotOwner.Location = New System.Drawing.Point(295, 167)
        Me.btnAddLotOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddLotOwner.Name = "btnAddLotOwner"
        Me.btnAddLotOwner.Size = New System.Drawing.Size(27, 27)
        Me.btnAddLotOwner.TabIndex = 289
        Me.btnAddLotOwner.Text = "+"
        Me.btnAddLotOwner.UseVisualStyleBackColor = False
        '
        'btnBrowseLotOwner
        '
        Me.btnBrowseLotOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseLotOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBrowseLotOwner.FlatAppearance.BorderSize = 0
        Me.btnBrowseLotOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseLotOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseLotOwner.ForeColor = System.Drawing.Color.White
        Me.btnBrowseLotOwner.Location = New System.Drawing.Point(324, 167)
        Me.btnBrowseLotOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowseLotOwner.Name = "btnBrowseLotOwner"
        Me.btnBrowseLotOwner.Size = New System.Drawing.Size(27, 27)
        Me.btnBrowseLotOwner.TabIndex = 288
        Me.btnBrowseLotOwner.Text = "..."
        Me.btnBrowseLotOwner.UseVisualStyleBackColor = False
        '
        'btnHouseAddress
        '
        Me.btnHouseAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHouseAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHouseAddress.FlatAppearance.BorderSize = 0
        Me.btnHouseAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHouseAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouseAddress.ForeColor = System.Drawing.Color.White
        Me.btnHouseAddress.Location = New System.Drawing.Point(725, 233)
        Me.btnHouseAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHouseAddress.Name = "btnHouseAddress"
        Me.btnHouseAddress.Size = New System.Drawing.Size(27, 27)
        Me.btnHouseAddress.TabIndex = 17
        Me.btnHouseAddress.Text = "+"
        Me.btnHouseAddress.UseVisualStyleBackColor = False
        '
        'txtHouseAddress
        '
        Me.txtHouseAddress.Enabled = False
        Me.txtHouseAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseAddress.Location = New System.Drawing.Point(529, 233)
        Me.txtHouseAddress.Name = "txtHouseAddress"
        Me.txtHouseAddress.Size = New System.Drawing.Size(189, 27)
        Me.txtHouseAddress.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 23)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "House Address"
        '
        'txtHouseLevel
        '
        Me.txtHouseLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseLevel.Location = New System.Drawing.Point(529, 167)
        Me.txtHouseLevel.Name = "txtHouseLevel"
        Me.txtHouseLevel.Size = New System.Drawing.Size(223, 27)
        Me.txtHouseLevel.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "House Level"
        '
        'txtHouseName
        '
        Me.txtHouseName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseName.Location = New System.Drawing.Point(128, 364)
        Me.txtHouseName.Name = "txtHouseName"
        Me.txtHouseName.Size = New System.Drawing.Size(223, 27)
        Me.txtHouseName.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "House Name"
        '
        'txtHouseOwnerName
        '
        Me.txtHouseOwnerName.Enabled = False
        Me.txtHouseOwnerName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseOwnerName.Location = New System.Drawing.Point(128, 300)
        Me.txtHouseOwnerName.Name = "txtHouseOwnerName"
        Me.txtHouseOwnerName.Size = New System.Drawing.Size(164, 27)
        Me.txtHouseOwnerName.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "House Owner"
        '
        'txtHouseCode
        '
        Me.txtHouseCode.Enabled = False
        Me.txtHouseCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseCode.Location = New System.Drawing.Point(128, 233)
        Me.txtHouseCode.Name = "txtHouseCode"
        Me.txtHouseCode.Size = New System.Drawing.Size(223, 27)
        Me.txtHouseCode.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "House Code"
        '
        'txtLotOwnerName
        '
        Me.txtLotOwnerName.Enabled = False
        Me.txtLotOwnerName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotOwnerName.Location = New System.Drawing.Point(128, 167)
        Me.txtLotOwnerName.Name = "txtLotOwnerName"
        Me.txtLotOwnerName.Size = New System.Drawing.Size(164, 27)
        Me.txtLotOwnerName.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Lot Owner"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Residential", "Rent", "Commercial"})
        Me.cboType.Location = New System.Drawing.Point(529, 101)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(223, 28)
        Me.cboType.TabIndex = 20
        '
        'txtLotCode
        '
        Me.txtLotCode.Enabled = False
        Me.txtLotCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotCode.Location = New System.Drawing.Point(128, 102)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(223, 27)
        Me.txtLotCode.TabIndex = 19
        '
        'rbtnLegal
        '
        Me.rbtnLegal.AutoSize = True
        Me.rbtnLegal.Checked = True
        Me.rbtnLegal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnLegal.Location = New System.Drawing.Point(488, 314)
        Me.rbtnLegal.Name = "rbtnLegal"
        Me.rbtnLegal.Size = New System.Drawing.Size(125, 27)
        Me.rbtnLegal.TabIndex = 16
        Me.rbtnLegal.TabStop = True
        Me.rbtnLegal.Text = "Legal Settler"
        Me.rbtnLegal.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Lot Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(385, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 23)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Settlement Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(385, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "House Type"
        '
        'rbtnIllegal
        '
        Me.rbtnIllegal.AutoSize = True
        Me.rbtnIllegal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIllegal.Location = New System.Drawing.Point(643, 314)
        Me.rbtnIllegal.Name = "rbtnIllegal"
        Me.rbtnIllegal.Size = New System.Drawing.Size(130, 27)
        Me.rbtnIllegal.TabIndex = 17
        Me.rbtnIllegal.Text = "Illegal Settler"
        Me.rbtnIllegal.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSearch.Controls.Add(Me.toolStrip1)
        Me.pnlSearch.Controls.Add(Me.dgvSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSearch.Location = New System.Drawing.Point(0, 60)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(265, 472)
        Me.pnlSearch.TabIndex = 12
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator7, Me.ToolStripSeparator8, Me.ToolStripSeparator3, Me.txtSearch, Me.ToolStripSeparator2, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.toolStrip1.Location = New System.Drawing.Point(11, 22)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(271, 27)
        Me.toolStrip1.TabIndex = 443
        Me.toolStrip1.Text = "toolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripLabel3.Text = "Search"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'txtSearch
        '
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(150, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.dgvSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvSearch.ColumnHeadersHeight = 30
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSearch.ColumnHeadersVisible = False
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvSearch.EnableHeadersVisualStyles = False
        Me.dgvSearch.GridColor = System.Drawing.Color.White
        Me.dgvSearch.Location = New System.Drawing.Point(13, 64)
        Me.dgvSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSearch.MultiSelect = False
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearch.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearch.RowHeadersVisible = False
        Me.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSearch.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(245, 402)
        Me.dgvSearch.TabIndex = 444
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "House Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "lot_house_idlot_house"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.btnShowRecords)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(1066, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 472)
        Me.Panel3.TabIndex = 11
        '
        'btnShowRecords
        '
        Me.btnShowRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnShowRecords.FlatAppearance.BorderSize = 0
        Me.btnShowRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowRecords.ForeColor = System.Drawing.Color.White
        Me.btnShowRecords.Location = New System.Drawing.Point(41, 354)
        Me.btnShowRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowRecords.Name = "btnShowRecords"
        Me.btnShowRecords.Size = New System.Drawing.Size(162, 61)
        Me.btnShowRecords.TabIndex = 16
        Me.btnShowRecords.Text = "Show Records"
        Me.btnShowRecords.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(41, 245)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(162, 61)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(41, 139)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(162, 61)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(41, 40)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(162, 61)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'frmHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 592)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents txtHouseAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHouseLevel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHouseName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHouseOwnerName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHouseCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLotOwnerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtLotCode As TextBox
    Friend WithEvents rbtnLegal As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents rbtnIllegal As RadioButton
    Friend WithEvents pnlSearch As Panel
    Private WithEvents toolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Private WithEvents ToolStripSeparator7 As ToolStripSeparator
    Private WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnShowRecords As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnHouseAddress As Button
    Friend WithEvents btnAddLotOwner As Button
    Friend WithEvents btnBrowseLotOwner As Button
    Friend WithEvents btnAddHouseOwner As Button
    Friend WithEvents btnBrowseHouseOwner As Button
    Friend WithEvents btnSameOwner As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
