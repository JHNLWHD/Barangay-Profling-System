<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRole
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
        Me.cboFamilyRole = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSaveRole = New System.Windows.Forms.Button()
        Me.btnCancelRole = New System.Windows.Forms.Button()
        Me.gboMarriage = New System.Windows.Forms.GroupBox()
        Me.dtpDOM = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gboMarriage.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFamilyRole
        '
        Me.cboFamilyRole.BackColor = System.Drawing.SystemColors.Menu
        Me.cboFamilyRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamilyRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFamilyRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFamilyRole.FormattingEnabled = True
        Me.cboFamilyRole.Items.AddRange(New Object() {"Child", "Cousin", "Grandparent", "Sibling", "Parent", "Spouse", "Nephew", "Niece"})
        Me.cboFamilyRole.Location = New System.Drawing.Point(123, 72)
        Me.cboFamilyRole.Name = "cboFamilyRole"
        Me.cboFamilyRole.Size = New System.Drawing.Size(276, 28)
        Me.cboFamilyRole.TabIndex = 343
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(47, 75)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 23)
        Me.Label11.TabIndex = 342
        Me.Label11.Text = "Role"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 37)
        Me.Panel2.TabIndex = 345
        '
        'btnSaveRole
        '
        Me.btnSaveRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSaveRole.FlatAppearance.BorderSize = 0
        Me.btnSaveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRole.ForeColor = System.Drawing.Color.White
        Me.btnSaveRole.Location = New System.Drawing.Point(96, 244)
        Me.btnSaveRole.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveRole.Name = "btnSaveRole"
        Me.btnSaveRole.Size = New System.Drawing.Size(118, 30)
        Me.btnSaveRole.TabIndex = 346
        Me.btnSaveRole.Text = "Save"
        Me.btnSaveRole.UseVisualStyleBackColor = False
        '
        'btnCancelRole
        '
        Me.btnCancelRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelRole.FlatAppearance.BorderSize = 0
        Me.btnCancelRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelRole.ForeColor = System.Drawing.Color.White
        Me.btnCancelRole.Location = New System.Drawing.Point(295, 244)
        Me.btnCancelRole.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelRole.Name = "btnCancelRole"
        Me.btnCancelRole.Size = New System.Drawing.Size(118, 30)
        Me.btnCancelRole.TabIndex = 347
        Me.btnCancelRole.Text = "Cancel"
        Me.btnCancelRole.UseVisualStyleBackColor = False
        '
        'gboMarriage
        '
        Me.gboMarriage.Controls.Add(Me.dtpDOM)
        Me.gboMarriage.Controls.Add(Me.Label10)
        Me.gboMarriage.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboMarriage.Location = New System.Drawing.Point(45, 126)
        Me.gboMarriage.Margin = New System.Windows.Forms.Padding(4)
        Me.gboMarriage.Name = "gboMarriage"
        Me.gboMarriage.Padding = New System.Windows.Forms.Padding(4)
        Me.gboMarriage.Size = New System.Drawing.Size(407, 98)
        Me.gboMarriage.TabIndex = 348
        Me.gboMarriage.TabStop = False
        Me.gboMarriage.Text = "If Spouse"
        '
        'dtpDOM
        '
        Me.dtpDOM.CustomFormat = "yyyy-MM-dd"
        Me.dtpDOM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOM.Location = New System.Drawing.Point(153, 43)
        Me.dtpDOM.Name = "dtpDOM"
        Me.dtpDOM.Size = New System.Drawing.Size(247, 26)
        Me.dtpDOM.TabIndex = 335
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(9, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 23)
        Me.Label10.TabIndex = 334
        Me.Label10.Text = "Date of Marriage"
        '
        'frmRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(500, 305)
        Me.Controls.Add(Me.gboMarriage)
        Me.Controls.Add(Me.btnCancelRole)
        Me.Controls.Add(Me.btnSaveRole)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cboFamilyRole)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gboMarriage.ResumeLayout(False)
        Me.gboMarriage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFamilyRole As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSaveRole As Button
    Friend WithEvents btnCancelRole As Button
    Friend WithEvents gboMarriage As GroupBox
    Friend WithEvents dtpDOM As DateTimePicker
    Friend WithEvents Label10 As Label
End Class
