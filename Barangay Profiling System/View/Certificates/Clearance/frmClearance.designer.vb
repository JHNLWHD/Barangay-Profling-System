<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClearance
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClearanceCivilStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClearanceGender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClearanceAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClearanceName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClearancePurpose = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboSearch = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvCertificate = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clearpurpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpersonc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1txtClearanceAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        CType(Me.dgvCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 50)
        Me.Panel1.TabIndex = 227
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(316, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "CLEARANCE"
        '
        'txtClearanceCivilStatus
        '
        Me.txtClearanceCivilStatus.Enabled = False
        Me.txtClearanceCivilStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearanceCivilStatus.Location = New System.Drawing.Point(139, 219)
        Me.txtClearanceCivilStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClearanceCivilStatus.Name = "txtClearanceCivilStatus"
        Me.txtClearanceCivilStatus.Size = New System.Drawing.Size(191, 27)
        Me.txtClearanceCivilStatus.TabIndex = 454
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(37, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 453
        Me.Label5.Text = "Civil Status"
        '
        'txtClearanceGender
        '
        Me.txtClearanceGender.Enabled = False
        Me.txtClearanceGender.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearanceGender.Location = New System.Drawing.Point(139, 181)
        Me.txtClearanceGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClearanceGender.Name = "txtClearanceGender"
        Me.txtClearanceGender.Size = New System.Drawing.Size(191, 27)
        Me.txtClearanceGender.TabIndex = 452
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(39, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 451
        Me.Label4.Text = "Gender"
        '
        'txtClearanceAge
        '
        Me.txtClearanceAge.Enabled = False
        Me.txtClearanceAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearanceAge.Location = New System.Drawing.Point(139, 146)
        Me.txtClearanceAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClearanceAge.Name = "txtClearanceAge"
        Me.txtClearanceAge.Size = New System.Drawing.Size(191, 27)
        Me.txtClearanceAge.TabIndex = 450
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(40, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 449
        Me.Label3.Text = "Age"
        '
        'txtClearanceName
        '
        Me.txtClearanceName.Enabled = False
        Me.txtClearanceName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearanceName.ForeColor = System.Drawing.Color.Black
        Me.txtClearanceName.Location = New System.Drawing.Point(139, 107)
        Me.txtClearanceName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClearanceName.Name = "txtClearanceName"
        Me.txtClearanceName.Size = New System.Drawing.Size(191, 27)
        Me.txtClearanceName.TabIndex = 448
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(40, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 447
        Me.Label2.Text = "Name"
        '
        'txtClearancePurpose
        '
        Me.txtClearancePurpose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearancePurpose.Location = New System.Drawing.Point(139, 301)
        Me.txtClearancePurpose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClearancePurpose.Name = "txtClearancePurpose"
        Me.txtClearancePurpose.Size = New System.Drawing.Size(191, 27)
        Me.txtClearancePurpose.TabIndex = 456
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(37, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 455
        Me.Label6.Text = "Purpose"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(0, 360)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(773, 39)
        Me.btnPrint.TabIndex = 457
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator7, Me.cboSearch, Me.ToolStripSeparator8})
        Me.toolStrip1.Location = New System.Drawing.Point(373, 69)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(360, 28)
        Me.toolStrip1.TabIndex = 501
        Me.toolStrip1.Text = "toolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(69, 25)
        Me.ToolStripLabel3.Text = "Search"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 28)
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Items.AddRange(New Object() {"All", "Appearance", "Clearance", "Indigency", "Residency"})
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(265, 28)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 28)
        '
        'dgvCertificate
        '
        Me.dgvCertificate.AllowUserToAddRows = False
        Me.dgvCertificate.AllowUserToDeleteRows = False
        Me.dgvCertificate.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.dgvCertificate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCertificate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCertificate.BackgroundColor = System.Drawing.Color.White
        Me.dgvCertificate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCertificate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCertificate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCertificate.ColumnHeadersHeight = 30
        Me.dgvCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCertificate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.clearpurpose, Me.Column6, Me.idpersonc})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCertificate.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCertificate.EnableHeadersVisualStyles = False
        Me.dgvCertificate.GridColor = System.Drawing.Color.White
        Me.dgvCertificate.Location = New System.Drawing.Point(373, 107)
        Me.dgvCertificate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgvCertificate.MultiSelect = False
        Me.dgvCertificate.Name = "dgvCertificate"
        Me.dgvCertificate.ReadOnly = True
        Me.dgvCertificate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCertificate.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCertificate.RowHeadersVisible = False
        Me.dgvCertificate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCertificate.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCertificate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCertificate.Size = New System.Drawing.Size(372, 224)
        Me.dgvCertificate.TabIndex = 500
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column5
        '
        Me.Column5.FillWeight = 76.14214!
        Me.Column5.HeaderText = "Type"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'clearpurpose
        '
        Me.clearpurpose.FillWeight = 111.9289!
        Me.clearpurpose.HeaderText = "Purpose"
        Me.clearpurpose.Name = "clearpurpose"
        Me.clearpurpose.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FillWeight = 111.9289!
        Me.Column6.HeaderText = "Date of Print"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'idpersonc
        '
        Me.idpersonc.HeaderText = "person_idperson"
        Me.idpersonc.Name = "idpersonc"
        Me.idpersonc.ReadOnly = True
        Me.idpersonc.Visible = False
        '
        'TextBox1txtClearanceAddress
        '
        Me.TextBox1txtClearanceAddress.Enabled = False
        Me.TextBox1txtClearanceAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1txtClearanceAddress.Location = New System.Drawing.Point(139, 260)
        Me.TextBox1txtClearanceAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1txtClearanceAddress.Name = "TextBox1txtClearanceAddress"
        Me.TextBox1txtClearanceAddress.Size = New System.Drawing.Size(191, 27)
        Me.TextBox1txtClearanceAddress.TabIndex = 503
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(37, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 502
        Me.Label7.Text = "Address"
        '
        'frmClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 399)
        Me.Controls.Add(Me.TextBox1txtClearanceAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.dgvCertificate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtClearancePurpose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtClearanceCivilStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClearanceGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtClearanceAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClearanceName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClearance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        CType(Me.dgvCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClearanceCivilStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtClearanceGender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClearanceAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClearanceName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClearancePurpose As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Private WithEvents toolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Private WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents cboSearch As ToolStripComboBox
    Private WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents dgvCertificate As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents clearpurpose As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents idpersonc As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1txtClearanceAddress As TextBox
    Friend WithEvents Label7 As Label
End Class
