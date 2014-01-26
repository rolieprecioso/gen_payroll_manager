<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeePayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeePayment))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PaymentID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PresentDays = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Department = New System.Windows.Forms.TextBox()
        Me.Designation = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PaymentModeDetails = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Overtime = New System.Windows.Forms.TextBox()
        Me.Advance = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OvertimeAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OvertimeRate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NetPay = New System.Windows.Forms.TextBox()
        Me.PaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Deduction = New System.Windows.Forms.TextBox()
        Me.Salary = New System.Windows.Forms.TextBox()
        Me.EmployeeID = New System.Windows.Forms.ComboBox()
        Me.paymentmode = New System.Windows.Forms.ComboBox()
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.btnSlip = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.BasicSalary = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Employee ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Employee Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 409)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Mode Of Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Deduction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Basic Salary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Payment Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PaymentID)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.PresentDays)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Department)
        Me.GroupBox1.Controls.Add(Me.Designation)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.PaymentModeDetails)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Overtime)
        Me.GroupBox1.Controls.Add(Me.Advance)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.OvertimeAmount)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.OvertimeRate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.NetPay)
        Me.GroupBox1.Controls.Add(Me.PaymentDate)
        Me.GroupBox1.Controls.Add(Me.Deduction)
        Me.GroupBox1.Controls.Add(Me.Salary)
        Me.GroupBox1.Controls.Add(Me.EmployeeID)
        Me.GroupBox1.Controls.Add(Me.paymentmode)
        Me.GroupBox1.Controls.Add(Me.EmployeeName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(58, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 524)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(451, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PaymentID
        '
        Me.PaymentID.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentID.Location = New System.Drawing.Point(178, 21)
        Me.PaymentID.Name = "PaymentID"
        Me.PaymentID.ReadOnly = True
        Me.PaymentID.Size = New System.Drawing.Size(258, 24)
        Me.PaymentID.TabIndex = 51
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(28, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 15)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Payment ID"
        '
        'PresentDays
        '
        Me.PresentDays.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresentDays.Location = New System.Drawing.Point(470, 209)
        Me.PresentDays.Name = "PresentDays"
        Me.PresentDays.ReadOnly = True
        Me.PresentDays.Size = New System.Drawing.Size(158, 24)
        Me.PresentDays.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(385, 209)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 15)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Present Days"
        '
        'Department
        '
        Me.Department.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.Location = New System.Drawing.Point(178, 170)
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.Size = New System.Drawing.Size(397, 24)
        Me.Department.TabIndex = 3
        '
        'Designation
        '
        Me.Designation.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Designation.Location = New System.Drawing.Point(178, 134)
        Me.Designation.Name = "Designation"
        Me.Designation.ReadOnly = True
        Me.Designation.Size = New System.Drawing.Size(397, 24)
        Me.Designation.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 15)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Department"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 15)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Designation"
        '
        'PaymentModeDetails
        '
        Me.PaymentModeDetails.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeDetails.Location = New System.Drawing.Point(178, 447)
        Me.PaymentModeDetails.Multiline = True
        Me.PaymentModeDetails.Name = "PaymentModeDetails"
        Me.PaymentModeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PaymentModeDetails.Size = New System.Drawing.Size(431, 24)
        Me.PaymentModeDetails.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 447)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 15)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Payment Mode Details"
        '
        'Overtime
        '
        Me.Overtime.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overtime.Location = New System.Drawing.Point(178, 285)
        Me.Overtime.Name = "Overtime"
        Me.Overtime.ReadOnly = True
        Me.Overtime.Size = New System.Drawing.Size(197, 24)
        Me.Overtime.TabIndex = 8
        '
        'Advance
        '
        Me.Advance.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Advance.Location = New System.Drawing.Point(178, 245)
        Me.Advance.Name = "Advance"
        Me.Advance.ReadOnly = True
        Me.Advance.Size = New System.Drawing.Size(197, 24)
        Me.Advance.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Advance"
        '
        'OvertimeAmount
        '
        Me.OvertimeAmount.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvertimeAmount.Location = New System.Drawing.Point(178, 325)
        Me.OvertimeAmount.Name = "OvertimeAmount"
        Me.OvertimeAmount.ReadOnly = True
        Me.OvertimeAmount.Size = New System.Drawing.Size(196, 24)
        Me.OvertimeAmount.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Overtime Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Overtime Rate"
        '
        'OvertimeRate
        '
        Me.OvertimeRate.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvertimeRate.Location = New System.Drawing.Point(470, 283)
        Me.OvertimeRate.Name = "OvertimeRate"
        Me.OvertimeRate.Size = New System.Drawing.Size(158, 24)
        Me.OvertimeRate.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Overtime (d.HH:MM:SS)"
        '
        'NetPay
        '
        Me.NetPay.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetPay.Location = New System.Drawing.Point(178, 485)
        Me.NetPay.Name = "NetPay"
        Me.NetPay.ReadOnly = True
        Me.NetPay.Size = New System.Drawing.Size(159, 24)
        Me.NetPay.TabIndex = 14
        '
        'PaymentDate
        '
        Me.PaymentDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentDate.CustomFormat = "dd/MMM/yyyy"
        Me.PaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PaymentDate.Location = New System.Drawing.Point(178, 367)
        Me.PaymentDate.Name = "PaymentDate"
        Me.PaymentDate.Size = New System.Drawing.Size(196, 22)
        Me.PaymentDate.TabIndex = 11
        '
        'Deduction
        '
        Me.Deduction.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction.Location = New System.Drawing.Point(470, 245)
        Me.Deduction.Name = "Deduction"
        Me.Deduction.Size = New System.Drawing.Size(158, 24)
        Me.Deduction.TabIndex = 7
        '
        'Salary
        '
        Me.Salary.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary.Location = New System.Drawing.Point(178, 207)
        Me.Salary.Name = "Salary"
        Me.Salary.ReadOnly = True
        Me.Salary.Size = New System.Drawing.Size(197, 24)
        Me.Salary.TabIndex = 4
        '
        'EmployeeID
        '
        Me.EmployeeID.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.FormattingEnabled = True
        Me.EmployeeID.Location = New System.Drawing.Point(178, 58)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(258, 25)
        Me.EmployeeID.TabIndex = 0
        '
        'paymentmode
        '
        Me.paymentmode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.paymentmode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.paymentmode.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentmode.FormattingEnabled = True
        Me.paymentmode.Items.AddRange(New Object() {"Cash", "Check", "DD", "Online"})
        Me.paymentmode.Location = New System.Drawing.Point(178, 406)
        Me.paymentmode.Name = "paymentmode"
        Me.paymentmode.Size = New System.Drawing.Size(196, 25)
        Me.paymentmode.TabIndex = 12
        '
        'EmployeeName
        '
        Me.EmployeeName.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.Location = New System.Drawing.Point(178, 97)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Size = New System.Drawing.Size(397, 24)
        Me.EmployeeName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 485)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Net Pay"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.DateTo)
        Me.groupBox3.Controls.Add(Me.DateFrom)
        Me.groupBox3.Controls.Add(Me.Label11)
        Me.groupBox3.Controls.Add(Me.Label12)
        Me.groupBox3.Location = New System.Drawing.Point(58, 60)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(400, 80)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        '
        'DateTo
        '
        Me.DateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.CustomFormat = "dd/MMM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(222, 42)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(137, 22)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(30, 42)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(137, 22)
        Me.DateFrom.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "From"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(224, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "To"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Update_Record)
        Me.GroupBox2.Controls.Add(Me.btnSlip)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.NewRecord)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Location = New System.Drawing.Point(990, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 217)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Update_Record
        '
        Me.Update_Record.BackgroundImage = CType(resources.GetObject("Update_Record.BackgroundImage"), System.Drawing.Image)
        Me.Update_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Update_Record.Enabled = False
        Me.Update_Record.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Record.ForeColor = System.Drawing.Color.White
        Me.Update_Record.Location = New System.Drawing.Point(16, 135)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(99, 29)
        Me.Update_Record.TabIndex = 6
        Me.Update_Record.Text = "&Update"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'btnSlip
        '
        Me.btnSlip.BackgroundImage = CType(resources.GetObject("btnSlip.BackgroundImage"), System.Drawing.Image)
        Me.btnSlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlip.Enabled = False
        Me.btnSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlip.ForeColor = System.Drawing.Color.White
        Me.btnSlip.Location = New System.Drawing.Point(16, 171)
        Me.btnSlip.Name = "btnSlip"
        Me.btnSlip.Size = New System.Drawing.Size(99, 29)
        Me.btnSlip.TabIndex = 5
        Me.btnSlip.Text = "&View Slip"
        Me.btnSlip.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(10, 10)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&calc"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.BackgroundImage = CType(resources.GetObject("Delete.BackgroundImage"), System.Drawing.Image)
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.White
        Me.Delete.Location = New System.Drawing.Point(16, 101)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(99, 29)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.BackgroundImage = CType(resources.GetObject("NewRecord.BackgroundImage"), System.Drawing.Image)
        Me.NewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.ForeColor = System.Drawing.Color.White
        Me.NewRecord.Location = New System.Drawing.Point(16, 25)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(99, 29)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.BackgroundImage = CType(resources.GetObject("Save.BackgroundImage"), System.Drawing.Image)
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.White
        Me.Save.Location = New System.Drawing.Point(16, 63)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(99, 29)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'BasicSalary
        '
        Me.BasicSalary.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicSalary.Location = New System.Drawing.Point(1127, 678)
        Me.BasicSalary.Multiline = True
        Me.BasicSalary.Name = "BasicSalary"
        Me.BasicSalary.ReadOnly = True
        Me.BasicSalary.Size = New System.Drawing.Size(10, 10)
        Me.BasicSalary.TabIndex = 48
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.Location = New System.Drawing.Point(725, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView1.Size = New System.Drawing.Size(244, 514)
        Me.DataGridView1.TabIndex = 2
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 45)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Employee Payment"
        '
        'frmEmployeePayment
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 687)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BasicSalary)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEmployeePayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Deduction As System.Windows.Forms.TextBox
    Friend WithEvents Salary As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents paymentmode As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents NetPay As System.Windows.Forms.TextBox
    Friend WithEvents PaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents OvertimeRate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Overtime As System.Windows.Forms.TextBox
    Friend WithEvents Advance As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents OvertimeAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSlip As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Department As System.Windows.Forms.TextBox
    Friend WithEvents Designation As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PresentDays As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Update_Record As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BasicSalary As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PaymentID As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents PaymentModeDetails As System.Windows.Forms.TextBox
End Class
