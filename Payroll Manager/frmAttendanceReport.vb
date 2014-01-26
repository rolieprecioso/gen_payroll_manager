Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmAttendanceReport
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    '    Dim cs As String = "Provider=Microsoft.ACE.Sql.12.0;Data Source=|DataDirectory|\PayrollManagerDB.accdb;Persist Security Info=False;"
    Private Sub frmAttendanceReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub frmAttendanceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptAttendance() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            ' myConnection = myConnection
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select EmployeeRegistration.EmployeeID,EmployeeName from EmployeeAttendance,EmployeeRegistration where EmployeeRegistration.EmployeeID=EmployeeAttendance.EmployeeID and WorkingDate between '" & DateFrom.Text & "' And '" & DateTo.Text & "'  and Status = 'P'  order by EmployeeName "
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeeAttendance")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            con = myConnection
            'con.Open()
            cmd = New SqlCommand("select count(status) from employeeattendance where WorkingDate between '" & DateFrom.Text & "' And '" & DateTo.Text & "'   group by EmployeeID ", con)
            rdr = cmd.ExecuteReader()

            If (rdr.Read()) Then

                'Label1.Text = rdr.GetInt32(0).ToString()
            End If
            If ((rdr Is Nothing)) Then

                rdr.Close()
            End If
            'If (con.State = ConnectionState.Open) Then

            '    con.Close()
            'End If
            rpt.SetParameterValue("variable", DateFrom.Value)
            rpt.SetParameterValue("variable1", DateTo.Value)
            'rpt.SetParameterValue("variable2", Label1.Text)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        CrystalReportViewer1.ReportSource = Nothing
        DateFrom.Value = Today
        DateTo.Value = Today
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
End Class