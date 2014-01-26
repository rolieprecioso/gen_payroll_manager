Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Windows.Forms
Imports DPUruNet

Partial Public Class EnrollmentControl
    Inherits Form
    Private WithEvents enrollmentControl As DPCtlUruNet.EnrollmentControl

    Private _sender As BiometricsScan
    Public Property Sender() As BiometricsScan
        Get
            Return _sender
        End Get
        Set(ByVal value As BiometricsScan)
            _sender = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub enrollment_OnCancel(ByVal enrollmentControl As DPCtlUruNet.EnrollmentControl, ByVal result As Constants.ResultCode, ByVal fingerPosition As Integer) Handles EnrollmentControl.OnCancel

        If enrollmentControl.Reader IsNot Nothing Then
            ShowMessage("OnCancel:  " & Convert.ToString(enrollmentControl.Reader.Description.Name) & ", finger " & fingerPosition)
        Else
            ShowMessage("OnCancel:  No Reader Connected, finger " & fingerPosition)
        End If

        btnCancel.Enabled = False
    End Sub

    Private Sub enrollment_OnCaptured(ByVal enrollmentControl As DPCtlUruNet.EnrollmentControl, ByVal captureResult As CaptureResult, ByVal fingerPosition As Integer) Handles EnrollmentControl.OnCaptured
        If enrollmentControl.Reader IsNot Nothing Then
            ShowMessage(("OnCaptured:  " & Convert.ToString(enrollmentControl.Reader.Description.Name) & ", finger " & fingerPosition & ", quality ") + captureResult.Quality.ToString())
        Else
            ShowMessage("OnCaptured:  No Reader Connected, finger " & fingerPosition)
        End If

        If captureResult.ResultCode <> Constants.ResultCode.DP_SUCCESS Then
            If _sender.CurrentReader IsNot Nothing Then
                _sender.CurrentReader.Dispose()
                _sender.CurrentReader = Nothing
            End If

            ' Disconnect reader from enrollment control.
            _enrollmentControl.Reader = Nothing
            MessageBox.Show("Error:  " & captureResult.ResultCode.ToString())
            btnCancel.Enabled = False
        Else
            If (pbFingerprint.Image IsNot Nothing) Then
                pbFingerprint.Image.Dispose()
                pbFingerprint.Image = Nothing
            End If

            For Each fiv As Fid.Fiv In captureResult.Data.Views
                pbFingerprint.Image = CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height)
            Next
        End If
    End Sub

    Private Sub enrollment_OnDelete(ByVal enrollmentControl As DPCtlUruNet.EnrollmentControl, ByVal result As Constants.ResultCode, ByVal fingerPosition As Integer) Handles EnrollmentControl.OnDelete
        If enrollmentControl.Reader IsNot Nothing Then
            ShowMessage("OnDelete:  " & Convert.ToString(enrollmentControl.Reader.Description.Name) & ", finger " & fingerPosition)
        Else
            ShowMessage("OnDelete:  No Reader Connected, finger " & fingerPosition)
        End If

        Dim main As BiometricsScan = _sender

        main.Fmds.Remove(fingerPosition)

        If main.Fmds.Count = 0 Then
            main.btnIdentificationControl.Enabled = False
        End If
    End Sub

    Private Sub enrollment_OnEnroll(ByVal enrollmentControl As DPCtlUruNet.EnrollmentControl, ByVal result As DataResult(Of Fmd), ByVal fingerPosition As Integer) Handles EnrollmentControl.OnEnroll
        If enrollmentControl.Reader IsNot Nothing Then
            ShowMessage("OnEnroll:  " & Convert.ToString(enrollmentControl.Reader.Description.Name) & ", finger " & fingerPosition)
        Else
            ShowMessage("OnEnroll:  No Reader Connected, finger " & fingerPosition)
        End If

        ' Save the enrollment to file.
        If result IsNot Nothing AndAlso result.Data IsNot Nothing Then
            _sender.Fmds.Add(fingerPosition, result.Data)
        End If

        btnCancel.Enabled = False

        _sender.btnIdentificationControl.Enabled = True
    End Sub

    Private Sub enrollment_OnStartEnroll(ByVal enrollmentControl As DPCtlUruNet.EnrollmentControl, ByVal result As Constants.ResultCode, ByVal fingerPosition As Integer) Handles EnrollmentControl.OnStartEnroll
        If enrollmentControl.Reader IsNot Nothing Then
            ShowMessage("OnStartEnroll:  " & Convert.ToString(enrollmentControl.Reader.Description.Name) & ", finger " & fingerPosition)
        Else
            ShowMessage("OnStartEnroll:  No Reader Connected, finger " & fingerPosition)
        End If


        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to cancel this enrollment?", "Are You Sure?", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = System.Windows.Forms.DialogResult.Yes Then
            enrollmentControl.Cancel()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ShowMessage(ByVal message As String)
        txtMessage.Text += message & vbCr & vbLf & vbCr & vbLf
        txtMessage.SelectionStart = txtMessage.TextLength
        txtMessage.ScrollToCaret()
    End Sub

    Public Function CreateBitmap(ByVal bytes As Byte(), ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim rgbBytes As Byte() = New Byte(bytes.Length * 3 - 1) {}

        For i As Integer = 0 To bytes.Length - 1
            rgbBytes((i * 3)) = bytes(i)
            rgbBytes((i * 3) + 1) = bytes(i)
            rgbBytes((i * 3) + 2) = bytes(i)
        Next
        Dim bmp As New Bitmap(width, height, PixelFormat.Format24bppRgb)

        Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.[WriteOnly], PixelFormat.Format24bppRgb)

        For i As Integer = 0 To bmp.Height - 1
            Dim p As New IntPtr(data.Scan0.ToInt32() + data.Stride * i)
            System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3)
        Next

        bmp.UnlockBits(data)

        Return bmp
    End Function

    Private Sub EnrollmentControl_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        enrollmentControl.Cancel()
    End Sub

    Private Sub EnrollmentControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If enrollmentControl Is Nothing Then
            enrollmentControl = New DPCtlUruNet.EnrollmentControl(_sender.CurrentReader, Constants.CapturePriority.DP_PRIORITY_COOPERATIVE)
            enrollmentControl.BackColor = System.Drawing.SystemColors.Window
            enrollmentControl.Location = New System.Drawing.Point(3, 3)
            enrollmentControl.Name = "ctlEnrollmentControl"
            enrollmentControl.Size = New System.Drawing.Size(482, 346)
            enrollmentControl.TabIndex = 0
        Else
            _enrollmentControl.Reader = _sender.CurrentReader
        End If

        Me.Controls.Add(enrollmentControl)
    End Sub
End Class
