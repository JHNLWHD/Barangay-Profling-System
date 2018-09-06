<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAddress
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDrive = New System.Windows.Forms.Button()
        Me.btnPurok = New System.Windows.Forms.Button()
        Me.btnRoad = New System.Windows.Forms.Button()
        Me.btnStreet = New System.Windows.Forms.Button()
        Me.cboRoad = New System.Windows.Forms.ComboBox()
        Me.cboPurok = New System.Windows.Forms.ComboBox()
        Me.cboDrive = New System.Windows.Forms.ComboBox()
        Me.cboStreet = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 60)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADDRESS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 359)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 60)
        Me.Panel2.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 60)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(525, 299)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDrive)
        Me.GroupBox2.Controls.Add(Me.btnPurok)
        Me.GroupBox2.Controls.Add(Me.btnRoad)
        Me.GroupBox2.Controls.Add(Me.btnStreet)
        Me.GroupBox2.Controls.Add(Me.cboRoad)
        Me.GroupBox2.Controls.Add(Me.cboPurok)
        Me.GroupBox2.Controls.Add(Me.cboDrive)
        Me.GroupBox2.Controls.Add(Me.cboStreet)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnGo)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(517, 281)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Residential"
        '
        'btnDrive
        '
        Me.btnDrive.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrive.ForeColor = System.Drawing.Color.White
        Me.btnDrive.Location = New System.Drawing.Point(470, 67)
        Me.btnDrive.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDrive.Name = "btnDrive"
        Me.btnDrive.Size = New System.Drawing.Size(43, 34)
        Me.btnDrive.TabIndex = 76
        Me.btnDrive.Text = "+"
        Me.btnDrive.UseVisualStyleBackColor = False
        '
        'btnPurok
        '
        Me.btnPurok.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPurok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurok.ForeColor = System.Drawing.Color.White
        Me.btnPurok.Location = New System.Drawing.Point(470, 114)
        Me.btnPurok.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPurok.Name = "btnPurok"
        Me.btnPurok.Size = New System.Drawing.Size(43, 34)
        Me.btnPurok.TabIndex = 75
        Me.btnPurok.Text = "+"
        Me.btnPurok.UseVisualStyleBackColor = False
        '
        'btnRoad
        '
        Me.btnRoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoad.ForeColor = System.Drawing.Color.White
        Me.btnRoad.Location = New System.Drawing.Point(470, 159)
        Me.btnRoad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRoad.Name = "btnRoad"
        Me.btnRoad.Size = New System.Drawing.Size(43, 34)
        Me.btnRoad.TabIndex = 74
        Me.btnRoad.Text = "+"
        Me.btnRoad.UseVisualStyleBackColor = False
        '
        'btnStreet
        '
        Me.btnStreet.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStreet.ForeColor = System.Drawing.Color.White
        Me.btnStreet.Location = New System.Drawing.Point(470, 25)
        Me.btnStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStreet.Name = "btnStreet"
        Me.btnStreet.Size = New System.Drawing.Size(43, 34)
        Me.btnStreet.TabIndex = 73
        Me.btnStreet.Text = "+"
        Me.btnStreet.UseVisualStyleBackColor = False
        '
        'cboRoad
        '
        Me.cboRoad.BackColor = System.Drawing.Color.White
        Me.cboRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboRoad.FormattingEnabled = True
        Me.cboRoad.Location = New System.Drawing.Point(140, 161)
        Me.cboRoad.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRoad.Name = "cboRoad"
        Me.cboRoad.Size = New System.Drawing.Size(325, 33)
        Me.cboRoad.TabIndex = 72
        '
        'cboPurok
        '
        Me.cboPurok.BackColor = System.Drawing.Color.White
        Me.cboPurok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPurok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboPurok.FormattingEnabled = True
        Me.cboPurok.Location = New System.Drawing.Point(140, 116)
        Me.cboPurok.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPurok.Name = "cboPurok"
        Me.cboPurok.Size = New System.Drawing.Size(325, 33)
        Me.cboPurok.TabIndex = 71
        '
        'cboDrive
        '
        Me.cboDrive.BackColor = System.Drawing.Color.White
        Me.cboDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboDrive.FormattingEnabled = True
        Me.cboDrive.Location = New System.Drawing.Point(140, 67)
        Me.cboDrive.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDrive.Name = "cboDrive"
        Me.cboDrive.Size = New System.Drawing.Size(325, 33)
        Me.cboDrive.TabIndex = 70
        '
        'cboStreet
        '
        Me.cboStreet.BackColor = System.Drawing.Color.White
        Me.cboStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStreet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboStreet.FormattingEnabled = True
        Me.cboStreet.Location = New System.Drawing.Point(140, 25)
        Me.cboStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStreet.Name = "cboStreet"
        Me.cboStreet.Size = New System.Drawing.Size(325, 33)
        Me.cboStreet.TabIndex = 68
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(49, 164)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 23)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Road"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(49, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Purok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(49, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Drive"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(49, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Street"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(220, 218)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(119, 41)
        Me.btnGo.TabIndex = 53
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(347, 218)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 41)
        Me.btnCancel.TabIndex = 52
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmAddAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 419)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddAddress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboRoad As ComboBox
    Friend WithEvents cboPurok As ComboBox
    Friend WithEvents cboDrive As ComboBox
    Friend WithEvents cboStreet As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnStreet As Button
    Friend WithEvents btnDrive As Button
    Friend WithEvents btnPurok As Button
    Friend WithEvents btnRoad As Button
End Class
