<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpInfo
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
        Me.gboEmploymentInfo = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbtnStaff = New System.Windows.Forms.RadioButton()
        Me.rbtnOfficial = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gboEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtExtensionName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gboEmploymentInfo.SuspendLayout()
        Me.gboEmployeeInfo.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(821, 60)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(689, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EMPLOYEE INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 547)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(821, 43)
        Me.Panel2.TabIndex = 12
        '
        'gboEmploymentInfo
        '
        Me.gboEmploymentInfo.Controls.Add(Me.txtStatus)
        Me.gboEmploymentInfo.Controls.Add(Me.txtPosition)
        Me.gboEmploymentInfo.Controls.Add(Me.Label13)
        Me.gboEmploymentInfo.Controls.Add(Me.Label12)
        Me.gboEmploymentInfo.Controls.Add(Me.rbtnStaff)
        Me.gboEmploymentInfo.Controls.Add(Me.rbtnOfficial)
        Me.gboEmploymentInfo.Controls.Add(Me.Label11)
        Me.gboEmploymentInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboEmploymentInfo.Location = New System.Drawing.Point(468, 84)
        Me.gboEmploymentInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboEmploymentInfo.Name = "gboEmploymentInfo"
        Me.gboEmploymentInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboEmploymentInfo.Size = New System.Drawing.Size(328, 444)
        Me.gboEmploymentInfo.TabIndex = 25
        Me.gboEmploymentInfo.TabStop = False
        Me.gboEmploymentInfo.Text = "Employment Information"
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Black
        Me.txtStatus.Location = New System.Drawing.Point(103, 165)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(200, 27)
        Me.txtStatus.TabIndex = 20
        '
        'txtPosition
        '
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(103, 112)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(200, 27)
        Me.txtPosition.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Position"
        '
        'rbtnStaff
        '
        Me.rbtnStaff.AutoSize = True
        Me.rbtnStaff.Enabled = False
        Me.rbtnStaff.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnStaff.Location = New System.Drawing.Point(192, 57)
        Me.rbtnStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnStaff.Name = "rbtnStaff"
        Me.rbtnStaff.Size = New System.Drawing.Size(64, 27)
        Me.rbtnStaff.TabIndex = 17
        Me.rbtnStaff.Text = "Staff"
        Me.rbtnStaff.UseVisualStyleBackColor = True
        '
        'rbtnOfficial
        '
        Me.rbtnOfficial.AutoSize = True
        Me.rbtnOfficial.Checked = True
        Me.rbtnOfficial.Enabled = False
        Me.rbtnOfficial.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOfficial.Location = New System.Drawing.Point(103, 57)
        Me.rbtnOfficial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnOfficial.Name = "rbtnOfficial"
        Me.rbtnOfficial.Size = New System.Drawing.Size(83, 27)
        Me.rbtnOfficial.TabIndex = 16
        Me.rbtnOfficial.TabStop = True
        Me.rbtnOfficial.Text = "Official"
        Me.rbtnOfficial.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 23)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Type"
        '
        'gboEmployeeInfo
        '
        Me.gboEmployeeInfo.Controls.Add(Me.txtAge)
        Me.gboEmployeeInfo.Controls.Add(Me.Label10)
        Me.gboEmployeeInfo.Controls.Add(Me.dtpDOB)
        Me.gboEmployeeInfo.Controls.Add(Me.Label9)
        Me.gboEmployeeInfo.Controls.Add(Me.rbtnFemale)
        Me.gboEmployeeInfo.Controls.Add(Me.rbtnMale)
        Me.gboEmployeeInfo.Controls.Add(Me.Label8)
        Me.gboEmployeeInfo.Controls.Add(Me.txtTelephoneNumber)
        Me.gboEmployeeInfo.Controls.Add(Me.Label7)
        Me.gboEmployeeInfo.Controls.Add(Me.txtMobileNumber)
        Me.gboEmployeeInfo.Controls.Add(Me.Label6)
        Me.gboEmployeeInfo.Controls.Add(Me.txtExtensionName)
        Me.gboEmployeeInfo.Controls.Add(Me.Label5)
        Me.gboEmployeeInfo.Controls.Add(Me.txtMiddleName)
        Me.gboEmployeeInfo.Controls.Add(Me.Label4)
        Me.gboEmployeeInfo.Controls.Add(Me.txtFirstName)
        Me.gboEmployeeInfo.Controls.Add(Me.Label3)
        Me.gboEmployeeInfo.Controls.Add(Me.txtLastName)
        Me.gboEmployeeInfo.Controls.Add(Me.Label2)
        Me.gboEmployeeInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboEmployeeInfo.Location = New System.Drawing.Point(25, 84)
        Me.gboEmployeeInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboEmployeeInfo.Name = "gboEmployeeInfo"
        Me.gboEmployeeInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboEmployeeInfo.Size = New System.Drawing.Size(427, 444)
        Me.gboEmployeeInfo.TabIndex = 24
        Me.gboEmployeeInfo.TabStop = False
        Me.gboEmployeeInfo.Text = "Employee Information"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(188, 356)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(236, 27)
        Me.txtAge.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Age"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "yyyy-MM-dd"
        Me.dtpDOB.Enabled = False
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(189, 313)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(233, 30)
        Me.dtpDOB.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Date of Birth"
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Enabled = False
        Me.rbtnFemale.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFemale.Location = New System.Drawing.Point(284, 203)
        Me.rbtnFemale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(85, 27)
        Me.rbtnFemale.TabIndex = 14
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Checked = True
        Me.rbtnMale.Enabled = False
        Me.rbtnMale.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMale.Location = New System.Drawing.Point(189, 203)
        Me.rbtnMale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(68, 27)
        Me.rbtnMale.TabIndex = 13
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Gender"
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Enabled = False
        Me.txtTelephoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(187, 276)
        Me.txtTelephoneNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(236, 27)
        Me.txtTelephoneNumber.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Telephone Number"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Enabled = False
        Me.txtMobileNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(187, 238)
        Me.txtMobileNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(236, 27)
        Me.txtMobileNumber.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Mobile Number"
        '
        'txtExtensionName
        '
        Me.txtExtensionName.Enabled = False
        Me.txtExtensionName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtensionName.Location = New System.Drawing.Point(187, 170)
        Me.txtExtensionName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExtensionName.Name = "txtExtensionName"
        Me.txtExtensionName.Size = New System.Drawing.Size(236, 27)
        Me.txtExtensionName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Extension Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(187, 132)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(236, 27)
        Me.txtMiddleName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(187, 97)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(236, 27)
        Me.txtFirstName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(187, 58)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(236, 27)
        Me.txtLastName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Last Name"
        '
        'EmpInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 590)
        Me.Controls.Add(Me.gboEmploymentInfo)
        Me.Controls.Add(Me.gboEmployeeInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EmpInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.gboEmploymentInfo.ResumeLayout(False)
        Me.gboEmploymentInfo.PerformLayout()
        Me.gboEmployeeInfo.ResumeLayout(False)
        Me.gboEmployeeInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gboEmploymentInfo As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents rbtnStaff As RadioButton
    Friend WithEvents rbtnOfficial As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents gboEmployeeInfo As GroupBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelephoneNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtExtensionName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtPosition As TextBox
End Class
