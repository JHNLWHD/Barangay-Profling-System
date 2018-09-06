<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriveRecords
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDriveRecords))
        Me.RemoveDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmDriveActivate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActivateDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveDriveToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeactivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmDriveDeactivate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgvDrive = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripSearch = New System.Windows.Forms.ToolStrip()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cmDriveActivate.SuspendLayout()
        Me.cmDriveDeactivate.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDrive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStripSearch.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RemoveDriveToolStripMenuItem
        '
        Me.RemoveDriveToolStripMenuItem.Name = "RemoveDriveToolStripMenuItem"
        Me.RemoveDriveToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.RemoveDriveToolStripMenuItem.Text = "Remove"
        '
        'cmDriveActivate
        '
        Me.cmDriveActivate.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmDriveActivate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivateDriveToolStripMenuItem, Me.RemoveDriveToolStripMenuItem})
        Me.cmDriveActivate.Name = "cmFYActionsActive"
        Me.cmDriveActivate.Size = New System.Drawing.Size(178, 52)
        '
        'ActivateDriveToolStripMenuItem
        '
        Me.ActivateDriveToolStripMenuItem.Name = "ActivateDriveToolStripMenuItem"
        Me.ActivateDriveToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.ActivateDriveToolStripMenuItem.Text = "Make as Active"
        '
        'RemoveDriveToolStripMenuItem8
        '
        Me.RemoveDriveToolStripMenuItem8.Name = "RemoveDriveToolStripMenuItem8"
        Me.RemoveDriveToolStripMenuItem8.Size = New System.Drawing.Size(187, 24)
        Me.RemoveDriveToolStripMenuItem8.Text = "Remove"
        '
        'DeactivateToolStripMenuItem
        '
        Me.DeactivateToolStripMenuItem.Name = "DeactivateToolStripMenuItem"
        Me.DeactivateToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DeactivateToolStripMenuItem.Text = "Make as Inactive"
        '
        'cmDriveDeactivate
        '
        Me.cmDriveDeactivate.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmDriveDeactivate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeactivateToolStripMenuItem, Me.RemoveDriveToolStripMenuItem8})
        Me.cmDriveDeactivate.Name = "cmFYActionsActive"
        Me.cmDriveDeactivate.Size = New System.Drawing.Size(188, 52)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(923, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DRIVE RECORDS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 41)
        Me.Panel1.TabIndex = 9
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(732, 2)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(173, 34)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dgvDrive
        '
        Me.dgvDrive.AllowUserToAddRows = False
        Me.dgvDrive.AllowUserToDeleteRows = False
        Me.dgvDrive.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDrive.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDrive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDrive.BackgroundColor = System.Drawing.Color.White
        Me.dgvDrive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDrive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDrive.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDrive.ColumnHeadersHeight = 30
        Me.dgvDrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDrive.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDrive.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDrive.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDrive.EnableHeadersVisualStyles = False
        Me.dgvDrive.GridColor = System.Drawing.Color.White
        Me.dgvDrive.Location = New System.Drawing.Point(3, 46)
        Me.dgvDrive.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDrive.MultiSelect = False
        Me.dgvDrive.Name = "dgvDrive"
        Me.dgvDrive.ReadOnly = True
        Me.dgvDrive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDrive.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDrive.RowHeadersVisible = False
        Me.dgvDrive.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDrive.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDrive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDrive.Size = New System.Drawing.Size(909, 311)
        Me.dgvDrive.TabIndex = 446
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
        Me.Column2.HeaderText = "Drive Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Status"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(24, 35)
        Me.btnRefresh.Text = "Refresh"
        '
        'txtSearch
        '
        Me.txtSearch.AutoSize = False
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(580, 29)
        Me.txtSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(53, 35)
        Me.ToolStripLabel3.Text = "Search"
        '
        'toolStripSearch
        '
        Me.toolStripSearch.AutoSize = False
        Me.toolStripSearch.CanOverflow = False
        Me.toolStripSearch.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStripSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toolStripSearch.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator7, Me.ToolStripSeparator8, Me.ToolStripSeparator9, Me.txtSearch, Me.btnRefresh})
        Me.toolStripSearch.Location = New System.Drawing.Point(4, 2)
        Me.toolStripSearch.Name = "toolStripSearch"
        Me.toolStripSearch.Size = New System.Drawing.Size(727, 38)
        Me.toolStripSearch.TabIndex = 449
        Me.toolStripSearch.Text = "toolStrip1"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.toolStripSearch)
        Me.TabPage1.Controls.Add(Me.dgvDrive)
        Me.TabPage1.Controls.Add(Me.btnPrint)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(915, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Drive"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(923, 395)
        Me.TabControl1.TabIndex = 10
        '
        'frmDriveRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDriveRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.cmDriveActivate.ResumeLayout(False)
        Me.cmDriveDeactivate.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDrive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStripSearch.ResumeLayout(False)
        Me.toolStripSearch.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RemoveDriveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmDriveActivate As ContextMenuStrip
    Friend WithEvents ActivateDriveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveDriveToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents DeactivateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmDriveDeactivate As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgvDrive As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents txtSearch As ToolStripTextBox
    Private WithEvents ToolStripSeparator9 As ToolStripSeparator
    Private WithEvents ToolStripSeparator8 As ToolStripSeparator
    Private WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Private WithEvents toolStripSearch As ToolStrip
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
End Class
