<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capabilities
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
        Me.txtReaderSelected = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lstCaps = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtReaderSelected
        '
        Me.txtReaderSelected.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtReaderSelected.Location = New System.Drawing.Point(13, 75)
        Me.txtReaderSelected.Name = "txtReaderSelected"
        Me.txtReaderSelected.Size = New System.Drawing.Size(260, 20)
        Me.txtReaderSelected.TabIndex = 29
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(11, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(236, 15)
        Me.label2.TabIndex = 30
        Me.label2.Text = "Selected Reader:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtName.Location = New System.Drawing.Point(14, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(260, 20)
        Me.txtName.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Name:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(157, 269)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(115, 23)
        Me.btnSelect.TabIndex = 27
        Me.btnSelect.Text = "Close"
        '
        'lstCaps
        '
        Me.lstCaps.Location = New System.Drawing.Point(12, 101)
        Me.lstCaps.Name = "lstCaps"
        Me.lstCaps.Size = New System.Drawing.Size(260, 160)
        Me.lstCaps.TabIndex = 26
        '
        'Capabilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 320)
        Me.Controls.Add(Me.txtReaderSelected)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lstCaps)
        Me.Name = "Capabilities"
        Me.Text = "Capabilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReaderSelected As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lstCaps As System.Windows.Forms.ListBox
End Class
