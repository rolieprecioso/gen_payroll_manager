<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchByOverTime
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchByOverTime))
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.GroupBox()
        Me.TotalOverTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        Me.Total.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.DateTo)
        Me.groupBox3.Controls.Add(Me.DateFrom)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(12, 3)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(400, 87)
        Me.groupBox3.TabIndex = 17
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Working Date"
        '
        'DateTo
        '
        Me.DateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.CustomFormat = "dd/MMM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(212, 44)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(153, 22)
        Me.DateTo.TabIndex = 12
        '
        'DateFrom
        '
        Me.DateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(20, 44)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(154, 22)
        Me.DateFrom.TabIndex = 11
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(17, 23)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(39, 16)
        Me.label7.TabIndex = 9
        Me.label7.Text = "From"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(209, 23)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(25, 16)
        Me.label9.TabIndex = 10
        Me.label9.Text = "To"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 96)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(643, 505)
        Me.DataGridView1.TabIndex = 18
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.button6)
        Me.groupBox4.Controls.Add(Me.button4)
        Me.groupBox4.Controls.Add(Me.button5)
        Me.groupBox4.Location = New System.Drawing.Point(419, 3)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(329, 87)
        Me.groupBox4.TabIndex = 19
        Me.groupBox4.TabStop = False
        '
        'button6
        '
        Me.button6.BackgroundImage = CType(resources.GetObject("button6.BackgroundImage"), System.Drawing.Image)
        Me.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.ForeColor = System.Drawing.Color.White
        Me.button6.Location = New System.Drawing.Point(218, 26)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(94, 40)
        Me.button6.TabIndex = 6
        Me.button6.Text = "&Export Excel"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.BackgroundImage = CType(resources.GetObject("button4.BackgroundImage"), System.Drawing.Image)
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.Color.White
        Me.button4.Location = New System.Drawing.Point(18, 26)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(94, 40)
        Me.button4.TabIndex = 0
        Me.button4.Text = "&Get Data"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.BackgroundImage = CType(resources.GetObject("button5.BackgroundImage"), System.Drawing.Image)
        Me.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.Location = New System.Drawing.Point(118, 26)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(94, 40)
        Me.button5.TabIndex = 1
        Me.button5.Text = "&Reset"
        Me.button5.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.Controls.Add(Me.TotalOverTime)
        Me.Total.Controls.Add(Me.Label1)
        Me.Total.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(669, 96)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(223, 92)
        Me.Total.TabIndex = 20
        Me.Total.TabStop = False
        Me.Total.Text = "Total"
        Me.Total.Visible = False
        '
        'TotalOverTime
        '
        Me.TotalOverTime.Location = New System.Drawing.Point(17, 57)
        Me.TotalOverTime.Name = "TotalOverTime"
        Me.TotalOverTime.Size = New System.Drawing.Size(180, 24)
        Me.TotalOverTime.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Overtime (d.HH:MM:SS)"
        '
        'frmSearchByOverTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 631)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.groupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearchByOverTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Record"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        Me.Total.ResumeLayout(False)
        Me.Total.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.GroupBox
    Friend WithEvents TotalOverTime As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents button6 As System.Windows.Forms.Button
End Class
