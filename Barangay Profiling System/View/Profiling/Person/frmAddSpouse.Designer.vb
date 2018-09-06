<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSpouse
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpSpouseInfoMarriage = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboSpouseInfo = New System.Windows.Forms.GroupBox()
        Me.btnPersonSpouse = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbtnDead = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtnAlive = New System.Windows.Forms.RadioButton()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPOB = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtExtensionName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtID2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gboSpouseInfo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtID2)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 56)
        Me.Panel1.TabIndex = 237
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(28, 13)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(241, 34)
        Me.txtID.TabIndex = 474
        Me.txtID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(396, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ADD SPOUSE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 609)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 36)
        Me.Panel2.TabIndex = 238
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpSpouseInfoMarriage)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 446)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 100)
        Me.GroupBox2.TabIndex = 368
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marriage Information"
        '
        'dtpSpouseInfoMarriage
        '
        Me.dtpSpouseInfoMarriage.CustomFormat = "yyyy-MM-dd"
        Me.dtpSpouseInfoMarriage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSpouseInfoMarriage.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSpouseInfoMarriage.Location = New System.Drawing.Point(219, 38)
        Me.dtpSpouseInfoMarriage.Name = "dtpSpouseInfoMarriage"
        Me.dtpSpouseInfoMarriage.Size = New System.Drawing.Size(241, 34)
        Me.dtpSpouseInfoMarriage.TabIndex = 475
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(41, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 28)
        Me.Label3.TabIndex = 474
        Me.Label3.Text = "Date of Marriage"
        '
        'gboSpouseInfo
        '
        Me.gboSpouseInfo.Controls.Add(Me.btnPersonSpouse)
        Me.gboSpouseInfo.Controls.Add(Me.Panel3)
        Me.gboSpouseInfo.Controls.Add(Me.chkResident)
        Me.gboSpouseInfo.Controls.Add(Me.cboCivilStatus)
        Me.gboSpouseInfo.Controls.Add(Me.Label18)
        Me.gboSpouseInfo.Controls.Add(Me.txtTelephoneNumber)
        Me.gboSpouseInfo.Controls.Add(Me.Label20)
        Me.gboSpouseInfo.Controls.Add(Me.txtMobileNumber)
        Me.gboSpouseInfo.Controls.Add(Me.Label21)
        Me.gboSpouseInfo.Controls.Add(Me.dtpDOB)
        Me.gboSpouseInfo.Controls.Add(Me.txtAge)
        Me.gboSpouseInfo.Controls.Add(Me.Label14)
        Me.gboSpouseInfo.Controls.Add(Me.rbtnFemale)
        Me.gboSpouseInfo.Controls.Add(Me.rbtnMale)
        Me.gboSpouseInfo.Controls.Add(Me.Label15)
        Me.gboSpouseInfo.Controls.Add(Me.Label17)
        Me.gboSpouseInfo.Controls.Add(Me.txtPOB)
        Me.gboSpouseInfo.Controls.Add(Me.Label22)
        Me.gboSpouseInfo.Controls.Add(Me.txtExtensionName)
        Me.gboSpouseInfo.Controls.Add(Me.Label23)
        Me.gboSpouseInfo.Controls.Add(Me.txtMiddleName)
        Me.gboSpouseInfo.Controls.Add(Me.Label24)
        Me.gboSpouseInfo.Controls.Add(Me.txtFirstName)
        Me.gboSpouseInfo.Controls.Add(Me.Label25)
        Me.gboSpouseInfo.Controls.Add(Me.txtLastName)
        Me.gboSpouseInfo.Controls.Add(Me.Label26)
        Me.gboSpouseInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboSpouseInfo.Location = New System.Drawing.Point(12, 77)
        Me.gboSpouseInfo.Name = "gboSpouseInfo"
        Me.gboSpouseInfo.Size = New System.Drawing.Size(963, 363)
        Me.gboSpouseInfo.TabIndex = 369
        Me.gboSpouseInfo.TabStop = False
        Me.gboSpouseInfo.Text = "Spouse Information"
        '
        'btnPersonSpouse
        '
        Me.btnPersonSpouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPersonSpouse.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPersonSpouse.FlatAppearance.BorderSize = 0
        Me.btnPersonSpouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonSpouse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonSpouse.ForeColor = System.Drawing.Color.White
        Me.btnPersonSpouse.Location = New System.Drawing.Point(34, 27)
        Me.btnPersonSpouse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPersonSpouse.Name = "btnPersonSpouse"
        Me.btnPersonSpouse.Size = New System.Drawing.Size(38, 29)
        Me.btnPersonSpouse.TabIndex = 473
        Me.btnPersonSpouse.Text = "..."
        Me.btnPersonSpouse.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbtnDead)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.rbtnAlive)
        Me.Panel3.Location = New System.Drawing.Point(568, 271)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(325, 43)
        Me.Panel3.TabIndex = 472
        '
        'rbtnDead
        '
        Me.rbtnDead.AutoSize = True
        Me.rbtnDead.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtnDead.Location = New System.Drawing.Point(233, 5)
        Me.rbtnDead.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnDead.Name = "rbtnDead"
        Me.rbtnDead.Size = New System.Drawing.Size(79, 32)
        Me.rbtnDead.TabIndex = 387
        Me.rbtnDead.Text = "Dead"
        Me.rbtnDead.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 28)
        Me.Label2.TabIndex = 385
        Me.Label2.Text = "Vital Status"
        '
        'rbtnAlive
        '
        Me.rbtnAlive.AutoSize = True
        Me.rbtnAlive.Checked = True
        Me.rbtnAlive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAlive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtnAlive.Location = New System.Drawing.Point(126, 4)
        Me.rbtnAlive.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnAlive.Name = "rbtnAlive"
        Me.rbtnAlive.Size = New System.Drawing.Size(76, 32)
        Me.rbtnAlive.TabIndex = 386
        Me.rbtnAlive.TabStop = True
        Me.rbtnAlive.Text = "Alive"
        Me.rbtnAlive.UseVisualStyleBackColor = True
        '
        'chkResident
        '
        Me.chkResident.AutoSize = True
        Me.chkResident.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResident.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkResident.Location = New System.Drawing.Point(785, 321)
        Me.chkResident.Margin = New System.Windows.Forms.Padding(4)
        Me.chkResident.Name = "chkResident"
        Me.chkResident.Size = New System.Drawing.Size(108, 32)
        Me.chkResident.TabIndex = 471
        Me.chkResident.Text = "Resident"
        Me.chkResident.UseVisualStyleBackColor = True
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCivilStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCivilStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed", "Separated"})
        Me.cboCivilStatus.Location = New System.Drawing.Point(651, 225)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(242, 36)
        Me.cboCivilStatus.TabIndex = 470
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(538, 226)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 28)
        Me.Label18.TabIndex = 469
        Me.Label18.Text = "Civil Status"
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.BackColor = System.Drawing.Color.White
        Me.txtTelephoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelephoneNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(652, 185)
        Me.txtTelephoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(241, 34)
        Me.txtTelephoneNumber.TabIndex = 467
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(473, 186)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(178, 28)
        Me.Label20.TabIndex = 468
        Me.Label20.Text = "Telephone Number"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.BackColor = System.Drawing.Color.White
        Me.txtMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(652, 148)
        Me.txtMobileNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(241, 34)
        Me.txtMobileNumber.TabIndex = 465
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(501, 148)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(151, 28)
        Me.Label21.TabIndex = 466
        Me.Label21.Text = "Mobile Number"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "yyyy-MM-dd"
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(652, 71)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(241, 34)
        Me.dtpDOB.TabIndex = 464
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(652, 111)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(241, 34)
        Me.txtAge.TabIndex = 458
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(597, 111)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 28)
        Me.Label14.TabIndex = 463
        Me.Label14.Text = "Age"
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtnFemale.Location = New System.Drawing.Point(295, 266)
        Me.rbtnFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(95, 32)
        Me.rbtnFemale.TabIndex = 462
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Checked = True
        Me.rbtnMale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtnMale.Location = New System.Drawing.Point(223, 266)
        Me.rbtnMale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(76, 32)
        Me.rbtnMale.TabIndex = 461
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(117, 263)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 28)
        Me.Label15.TabIndex = 460
        Me.Label15.Text = "Gender"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(523, 71)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 28)
        Me.Label17.TabIndex = 457
        Me.Label17.Text = "Date Of Birth"
        '
        'txtPOB
        '
        Me.txtPOB.BackColor = System.Drawing.Color.White
        Me.txtPOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOB.Location = New System.Drawing.Point(219, 222)
        Me.txtPOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.Size = New System.Drawing.Size(241, 34)
        Me.txtPOB.TabIndex = 456
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(71, 219)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 28)
        Me.Label22.TabIndex = 459
        Me.Label22.Text = "Place Of Birth"
        '
        'txtExtensionName
        '
        Me.txtExtensionName.BackColor = System.Drawing.Color.White
        Me.txtExtensionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtensionName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtensionName.Location = New System.Drawing.Point(219, 186)
        Me.txtExtensionName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExtensionName.Name = "txtExtensionName"
        Me.txtExtensionName.Size = New System.Drawing.Size(241, 34)
        Me.txtExtensionName.TabIndex = 454
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(49, 180)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 28)
        Me.Label23.TabIndex = 455
        Me.Label23.Text = "Extension Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.White
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(219, 149)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(241, 34)
        Me.txtMiddleName.TabIndex = 452
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(70, 145)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 28)
        Me.Label24.TabIndex = 453
        Me.Label24.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(219, 112)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(241, 34)
        Me.txtFirstName.TabIndex = 450
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(90, 108)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 28)
        Me.Label25.TabIndex = 451
        Me.Label25.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(219, 74)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(241, 34)
        Me.txtLastName.TabIndex = 448
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(90, 71)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 28)
        Me.Label26.TabIndex = 449
        Me.Label26.Text = "Last Name"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(676, 557)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 40)
        Me.btnSave.TabIndex = 370
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(832, 557)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 40)
        Me.btnCancel.TabIndex = 371
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtID2
        '
        Me.txtID2.BackColor = System.Drawing.Color.White
        Me.txtID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID2.Location = New System.Drawing.Point(692, 13)
        Me.txtID2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID2.Name = "txtID2"
        Me.txtID2.Size = New System.Drawing.Size(241, 34)
        Me.txtID2.TabIndex = 475
        Me.txtID2.Visible = False
        '
        'frmAddSpouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 645)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gboSpouseInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddSpouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gboSpouseInfo.ResumeLayout(False)
        Me.gboSpouseInfo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpSpouseInfoMarriage As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents gboSpouseInfo As GroupBox
    Friend WithEvents btnPersonSpouse As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rbtnDead As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtnAlive As RadioButton
    Friend WithEvents chkResident As CheckBox
    Friend WithEvents cboCivilStatus As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTelephoneNumber As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPOB As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtExtensionName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtID2 As TextBox
End Class
