Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmEmployeePaymentReport
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    'Dim cs As String = "Provider=Microsoft.ACE.sql.12.0;Data Source=|DataDirectory|\PayrollManagerDB.accdb;Persist Security Info=False;"

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        'Try
        Dim rpt As New rptEmployeePayment() 'The report you created.
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New DataSet 'The DataSet you created.
        MyCommand.CommandText = "select Employeename,EmployeeRegistration.EmployeeID,PaymentID,Designation,Department,EmployeePayment.salary,deduction,OvertimeAmount,Paymentdate,NetPay from employeepayment,EmployeeRegistration  where EmployeeRegistration.EmployeeID=EmployeePayment.EmployeeID and paymentdate between '" & DateFrom.Text & "' And '" & DateTo.Text & "'"
        MyCommand.Connection = MyConnection
        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand
        myDA.Fill(myDS, "EmployeePayment")
        myDA.Fill(myDS, "EmployeeRegistration")

        rpt.SetDataSource(myDS)
        rpt.SetParameterValue("variable1", DateFrom.Value)
        rpt.SetParameterValue("variable2", DateTo.Value)
        CrystalReportViewer1.ReportSource = rpt
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub frmEmployeePaymentReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        CrystalReportViewer1.ReportSource = Nothing
        DateFrom.Value = Today
        DateTo.Value = Today
    End Sub

    Private Sub frmEmployeePaymentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class