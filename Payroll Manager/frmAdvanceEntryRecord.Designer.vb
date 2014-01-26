<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvanceEntryRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvanceEntryRecord))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Total = New System.Windows.Forms.GroupBox()
        Me.TotalAdvance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.EmployeeName = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Total.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox6.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(20, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(786, 537)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Total)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.groupBox6)
        Me.TabPage1.Controls.Add(Me.groupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(778, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Employee Name"
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Total.Controls.Add(Me.TotalAdvance)
        Me.Total.Controls.Add(Me.Label2)
        Me.Total.Location = New System.Drawing.Point(458, 94)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(206, 88)
        Me.Total.TabIndex = 20
        Me.Total.TabStop = False
        Me.Total.Text = "Total"
        Me.Total.Visible = False
        '
        'TotalAdvance
        '
        Me.TotalAdvance.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAdvance.Location = New System.Drawing.Point(19, 44)
        Me.TotalAdvance.Name = "TotalAdvance"
        Me.TotalAdvance.Size = New System.Drawing.Size(166, 24)
        Me.TotalAdvance.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Advance"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 401)
        Me.DataGridView1.TabIndex = 8
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.button6)
        Me.groupBox6.Controls.Add(Me.button8)
        Me.groupBox6.Location = New System.Drawing.Point(325, 6)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(250, 87)
        Me.groupBox6.TabIndex = 7
        Me.groupBox6.TabStop = False
        '
        'button6
        '
        Me.button6.BackgroundImage = CType(resources.GetObject("button6.BackgroundImage"), System.Drawing.Image)
        Me.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.ForeColor = System.Drawing.Color.White
        Me.button6.Location = New System.Drawing.Point(125, 26)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(105, 40)
        Me.button6.TabIndex = 5
        Me.button6.Text = "&Export Excel"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.ForeColor = System.Drawing.Color.White
        Me.button8.Image = CType(resources.GetObject("button8.Image"), System.Drawing.Image)
        Me.button8.Location = New System.Drawing.Point(15, 26)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(104, 40)
        Me.button8.TabIndex = 1
        Me.button8.Text = "&Reset"
        Me.button8.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.label6)
        Me.groupBox5.Controls.Add(Me.EmployeeName)
        Me.groupBox5.Location = New System.Drawing.Point(8, 6)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(302, 87)
        Me.groupBox5.TabIndex = 5
        Me.groupBox5.TabStop = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(26, 18)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(98, 15)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Employee Name"
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmployeeName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.FormattingEnabled = True
        Me.EmployeeName.Location = New System.Drawing.Point(24, 42)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(205, 26)
        Me.EmployeeName.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.groupBox4)
        Me.TabPage2.Controls.Add(Me.groupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(778, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By Entry Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(466, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 106)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total"
        Me.GroupBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(18, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 24)
        Me.TextBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Advance"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.Color.Silver
        Me.DataGridView2.Location = New System.Drawing.Point(6, 98)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(444, 387)
        Me.DataGridView2.TabIndex = 9
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.Button1)
        Me.groupBox4.Controls.Add(Me.button4)
        Me.groupBox4.Controls.Add(Me.button5)
        Me.groupBox4.Location = New System.Drawing.Point(404, 6)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(332, 87)
        Me.groupBox4.TabIndex = 7
        Me.groupBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(210, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Export Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.BackgroundImage = CType(resources.GetObject("button4.BackgroundImage"), System.Drawing.Image)
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.Color.White
        Me.button4.Location = New System.Drawing.Point(10, 26)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(94, 40)
        Me.button4.TabIndex = 0
        Me.button4.Text = "&Get Data"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.BackgroundImage = CType(resources.GetObject("button5.BackgroundImage"), System.Drawing.Image)
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.Location = New System.Drawing.Point(110, 26)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(94, 40)
        Me.button5.TabIndex = 1
        Me.button5.Text = "&Reset"
        Me.button5.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.DateTo)
        Me.groupBox3.Controls.Add(Me.DateFrom)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Location = New System.Drawing.Point(8, 6)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(379, 87)
        Me.groupBox3.TabIndex = 5
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Entry Date"
        '
        'DateTo
        '
        Me.DateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.CustomFormat = "dd/MMM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(180, 42)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(137, 22)
        Me.DateTo.TabIndex = 12
        '
        'DateFrom
        '
        Me.DateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(26, 42)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(137, 22)
        Me.DateFrom.TabIndex = 11
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(26, 22)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(43, 16)
        Me.label7.TabIndex = 9
        Me.label7.Text = "From"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(186, 22)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(27, 16)
        Me.label9.TabIndex = 10
        Me.label9.Text = "To"
        '
        'frmAdvanceEntryRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 547)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdvanceEntryRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Entry Record"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Total.ResumeLayout(False)
        Me.Total.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents EmployeeName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents groupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents button8 As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.GroupBox
    Friend WithEvents TotalAdvance As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
