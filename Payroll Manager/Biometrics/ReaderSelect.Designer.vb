<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReaderSelect
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnCaps = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cboReaders = New System.Windows.Forms.ComboBox()
        Me.lblSelectReader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(143, 81)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 23)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(22, 81)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(115, 23)
        Me.btnSelect.TabIndex = 17
        Me.btnSelect.Text = "Select"
        '
        'btnCaps
        '
        Me.btnCaps.Enabled = False
        Me.btnCaps.Location = New System.Drawing.Point(143, 52)
        Me.btnCaps.Name = "btnCaps"
        Me.btnCaps.Size = New System.Drawing.Size(115, 23)
        Me.btnCaps.TabIndex = 16
        Me.btnCaps.Text = "Capabilities"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(22, 52)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(115, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh List"
        '
        'cboReaders
        '
        Me.cboReaders.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.cboReaders.Location = New System.Drawing.Point(12, 25)
        Me.cboReaders.Name = "cboReaders"
        Me.cboReaders.Size = New System.Drawing.Size(256, 21)
        Me.cboReaders.TabIndex = 14
        '
        'lblSelectReader
        '
        Me.lblSelectReader.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectReader.Name = "lblSelectReader"
        Me.lblSelectReader.Size = New System.Drawing.Size(296, 13)
        Me.lblSelectReader.TabIndex = 19
        Me.lblSelectReader.Text = "Select Reader:"
        '
        'ReaderSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 129)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnCaps)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cboReaders)
        Me.Controls.Add(Me.lblSelectReader)
        Me.Name = "ReaderSelect"
        Me.Text = "ReaderSelect"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnCaps As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cboReaders As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectReader As System.Windows.Forms.Label
End Class
