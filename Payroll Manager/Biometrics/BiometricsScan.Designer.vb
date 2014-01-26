<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BiometricsScan
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnIdentificationControl = New System.Windows.Forms.Button()
        Me.btnEnrollmentControl = New System.Windows.Forms.Button()
        Me.txtReaderSelected = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.btnIdentify = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnStreaming = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnReaderSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enroll"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Identify"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnIdentificationControl
        '
        Me.btnIdentificationControl.Enabled = False
        Me.btnIdentificationControl.Location = New System.Drawing.Point(416, 198)
        Me.btnIdentificationControl.Name = "btnIdentificationControl"
        Me.btnIdentificationControl.Size = New System.Drawing.Size(115, 23)
        Me.btnIdentificationControl.TabIndex = 29
        Me.btnIdentificationControl.Text = "Identification GUI"
        '
        'btnEnrollmentControl
        '
        Me.btnEnrollmentControl.Enabled = False
        Me.btnEnrollmentControl.Location = New System.Drawing.Point(295, 198)
        Me.btnEnrollmentControl.Name = "btnEnrollmentControl"
        Me.btnEnrollmentControl.Size = New System.Drawing.Size(115, 23)
        Me.btnEnrollmentControl.TabIndex = 28
        Me.btnEnrollmentControl.Text = "Enrollment GUI"
        '
        'txtReaderSelected
        '
        Me.txtReaderSelected.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtReaderSelected.Location = New System.Drawing.Point(298, 75)
        Me.txtReaderSelected.Name = "txtReaderSelected"
        Me.txtReaderSelected.ReadOnly = True
        Me.txtReaderSelected.Size = New System.Drawing.Size(233, 20)
        Me.txtReaderSelected.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(295, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Selected Reader:"
        '
        'btnEnroll
        '
        Me.btnEnroll.Enabled = False
        Me.btnEnroll.Location = New System.Drawing.Point(295, 159)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(115, 23)
        Me.btnEnroll.TabIndex = 26
        Me.btnEnroll.Text = "Enrollment"
        '
        'btnIdentify
        '
        Me.btnIdentify.Enabled = False
        Me.btnIdentify.Location = New System.Drawing.Point(416, 130)
        Me.btnIdentify.Name = "btnIdentify"
        Me.btnIdentify.Size = New System.Drawing.Size(115, 23)
        Me.btnIdentify.TabIndex = 25
        Me.btnIdentify.Text = "Identification"
        '
        'btnVerify
        '
        Me.btnVerify.Enabled = False
        Me.btnVerify.Location = New System.Drawing.Point(295, 130)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(115, 23)
        Me.btnVerify.TabIndex = 24
        Me.btnVerify.Text = "Verification"
        '
        'btnStreaming
        '
        Me.btnStreaming.Enabled = False
        Me.btnStreaming.Location = New System.Drawing.Point(416, 159)
        Me.btnStreaming.Name = "btnStreaming"
        Me.btnStreaming.Size = New System.Drawing.Size(115, 23)
        Me.btnStreaming.TabIndex = 27
        Me.btnStreaming.Text = "Streaming"
        '
        'btnCapture
        '
        Me.btnCapture.Enabled = False
        Me.btnCapture.Location = New System.Drawing.Point(416, 101)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(115, 23)
        Me.btnCapture.TabIndex = 23
        Me.btnCapture.Text = "Capture"
        '
        'btnReaderSelect
        '
        Me.btnReaderSelect.Location = New System.Drawing.Point(295, 101)
        Me.btnReaderSelect.Name = "btnReaderSelect"
        Me.btnReaderSelect.Size = New System.Drawing.Size(115, 23)
        Me.btnReaderSelect.TabIndex = 22
        Me.btnReaderSelect.Text = "Reader Selection"
        '
        'BiometricsScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 279)
        Me.Controls.Add(Me.btnIdentificationControl)
        Me.Controls.Add(Me.btnEnrollmentControl)
        Me.Controls.Add(Me.txtReaderSelected)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.btnIdentify)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnStreaming)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnReaderSelect)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BiometricsScan"
        Me.Text = "BiometricsScan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents btnIdentificationControl As System.Windows.Forms.Button
    Friend WithEvents btnEnrollmentControl As System.Windows.Forms.Button
    Friend WithEvents txtReaderSelected As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnroll As System.Windows.Forms.Button
    Friend WithEvents btnIdentify As System.Windows.Forms.Button
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnStreaming As System.Windows.Forms.Button
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents btnReaderSelect As System.Windows.Forms.Button
End Class
