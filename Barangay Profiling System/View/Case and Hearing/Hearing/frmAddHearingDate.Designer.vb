<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddHearingDate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpAddHearingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddHearingDate = New System.Windows.Forms.Button()
        Me.btnCancelHearingDate = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 38)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADD HEARING DATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 197)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 25)
        Me.Panel2.TabIndex = 23
        '
        'dtpAddHearingDate
        '
        Me.dtpAddHearingDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAddHearingDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpAddHearingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAddHearingDate.Location = New System.Drawing.Point(180, 112)
        Me.dtpAddHearingDate.Name = "dtpAddHearingDate"
        Me.dtpAddHearingDate.Size = New System.Drawing.Size(179, 22)
        Me.dtpAddHearingDate.TabIndex = 453
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(32, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 23)
        Me.Label7.TabIndex = 452
        Me.Label7.Text = "Date of Hearing"
        '
        'btnAddHearingDate
        '
        Me.btnAddHearingDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddHearingDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddHearingDate.ForeColor = System.Drawing.Color.White
        Me.btnAddHearingDate.Location = New System.Drawing.Point(101, 162)
        Me.btnAddHearingDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddHearingDate.Name = "btnAddHearingDate"
        Me.btnAddHearingDate.Size = New System.Drawing.Size(119, 29)
        Me.btnAddHearingDate.TabIndex = 455
        Me.btnAddHearingDate.Text = "Add"
        Me.btnAddHearingDate.UseVisualStyleBackColor = False
        '
        'btnCancelHearingDate
        '
        Me.btnCancelHearingDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancelHearingDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelHearingDate.ForeColor = System.Drawing.Color.White
        Me.btnCancelHearingDate.Location = New System.Drawing.Point(240, 162)
        Me.btnCancelHearingDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelHearingDate.Name = "btnCancelHearingDate"
        Me.btnCancelHearingDate.Size = New System.Drawing.Size(119, 29)
        Me.btnCancelHearingDate.TabIndex = 454
        Me.btnCancelHearingDate.Text = "Cancel"
        Me.btnCancelHearingDate.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(291, 44)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 456
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(32, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 457
        Me.Label2.Text = "Hearing Code"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(180, 72)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(179, 22)
        Me.txtCode.TabIndex = 458
        '
        'frmAddHearingDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 222)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnAddHearingDate)
        Me.Controls.Add(Me.btnCancelHearingDate)
        Me.Controls.Add(Me.dtpAddHearingDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddHearingDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpAddHearingDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddHearingDate As Button
    Friend WithEvents btnCancelHearingDate As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCode As TextBox
End Class
