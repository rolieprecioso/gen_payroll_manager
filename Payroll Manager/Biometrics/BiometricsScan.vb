Imports DPCtlUruNet
Imports System.Threading
Imports System.Collections
Imports System.Collections.Generic
Imports DPUruNet
Imports DPUruNet.Constants

Public Class BiometricsScan

    ' Whether streaming or capture was chosen.
    Public streamingOn As Boolean

    Private _readerSelect As ReaderSelect
    Private Sub btnReaderSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReaderSelect.Click
        If _readerSelect Is Nothing Then
            _readerSelect = New ReaderSelect
            _readerSelect.Sender = Me
        End If

        _readerSelect.ShowDialog()
    End Sub

    Public Property Fmds() As Dictionary(Of Int16, Fmd)
        Get
            Return _fmds
        End Get
        Set(ByVal value As Dictionary(Of Int16, Fmd))
            _fmds = value
        End Set
    End Property
    Private _fmds As Dictionary(Of Int16, Fmd) = New Dictionary(Of Int16, Fmd)

    Private Enum Action
        UpdateReaderState
    End Enum

    ' When set by child forms, shows s/n and enables buttons.
    Public Property CurrentReader() As Reader
        Get
            Return _currentReader
        End Get
        Set(ByVal value As Reader)
            _currentReader = value
            SendMessage(Action.UpdateReaderState, value)
        End Set
    End Property
    Private _currentReader As Reader

    Public Function CaptureFinger(ByRef fid As Fid) As Boolean
        Try
            Dim result = _currentReader.GetStatus()

            If (result <> ResultCode.DP_SUCCESS) Then
                MessageBox.Show("Get Status Error:  " & result.ToString())
                If CurrentReader IsNot Nothing Then
                    CurrentReader.Dispose()
                    CurrentReader = Nothing
                End If
                Return False
            End If

            If (_currentReader.Status.Status = ReaderStatuses.DP_STATUS_BUSY) Then
                Thread.Sleep(50)
                Return True
            ElseIf (_currentReader.Status.Status = ReaderStatuses.DP_STATUS_NEED_CALIBRATION) Then
                _currentReader.Calibrate()
            ElseIf (_currentReader.Status.Status <> ReaderStatuses.DP_STATUS_READY) Then
                MessageBox.Show("Get Status:  " & CurrentReader.Status.Status)
                If CurrentReader IsNot Nothing Then
                    CurrentReader.Dispose()
                    CurrentReader = Nothing
                End If
                Return False
            End If

            Dim captureResult = _currentReader.Capture(Formats.Fid.ANSI, _
                                               CaptureProcessing.DP_IMG_PROC_DEFAULT, _
                                               5000, _
                                               _currentReader.Capabilities.Resolutions(0))

            If (captureResult.ResultCode <> ResultCode.DP_SUCCESS) Then
                MessageBox.Show("Error:  " & captureResult.ResultCode.ToString())
                If CurrentReader IsNot Nothing Then
                    CurrentReader.Dispose()
                    CurrentReader = Nothing
                End If
                Return False
            End If

            If (captureResult.Quality = CaptureQuality.DP_QUALITY_CANCELED) Then
                Return False
            End If

            If (captureResult.Quality = CaptureQuality.DP_QUALITY_NO_FINGER _
                Or captureResult.Quality = CaptureQuality.DP_QUALITY_TIMED_OUT) Then
                Return True
            End If

            If (captureResult.Quality = CaptureQuality.DP_QUALITY_FAKE_FINGER) Then
                MessageBox.Show("Quality Error:  " & captureResult.Quality.ToString())
                Return True
            End If

            fid = captureResult.Data

            Return True
        Catch ex As Exception
            MessageBox.Show("An error has occurred.")
            If CurrentReader IsNot Nothing Then
                CurrentReader.Dispose()
                CurrentReader = Nothing
            End If
            Return False
        End Try
    End Function

    Private Delegate Sub SendMessageCallback(ByVal state As Action, ByVal payload As Object)
    Private Sub SendMessage(ByVal state As Action, ByVal payload As Object)
        On Error Resume Next

        If Me.txtReaderSelected.InvokeRequired Then
            Dim d As New SendMessageCallback(AddressOf SendMessage)
            Me.Invoke(d, New Object() {state, payload})
        Else

            Select Case state
                Case Action.UpdateReaderState
                    Dim _reader As Reader = (DirectCast(payload, Reader))
                    If (_reader IsNot Nothing) Then
                        txtReaderSelected.Text = _reader.Description.SerialNumber
                        btnCapture.Enabled = True
                        btnStreaming.Enabled = True
                        btnVerify.Enabled = True
                        btnIdentify.Enabled = True
                        btnEnroll.Enabled = True
                        btnEnrollmentControl.Enabled = True
                        If _fmds.Count > 0 Then
                            btnIdentificationControl.Enabled = True
                        End If
                    ElseIf (_reader Is Nothing) Then
                        _currentReader.Dispose()
                        _currentReader = Nothing
                        txtReaderSelected.Text = String.Empty
                        btnCapture.Enabled = False
                        btnStreaming.Enabled = False
                        btnVerify.Enabled = False
                        btnIdentify.Enabled = False
                        btnEnroll.Enabled = False
                        btnEnrollmentControl.Enabled = False
                        btnIdentificationControl.Enabled = False
                    End If
            End Select

        End If
    End Sub

    Private Sub BiometricsScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private enrollmentControl As EnrollmentControl
    Private Sub btnEnrollmentControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrollmentControl.Click

        If (enrollmentControl Is Nothing) Then
            enrollmentControl = New EnrollmentControl()
            enrollmentControl.Sender = Me
        End If

        enrollmentControl.ShowDialog()
    End Sub
End Class