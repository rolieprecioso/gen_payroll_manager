Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmSalarySlip

    Private Sub SalarySlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim rpt As New rptSalarySlip() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            'myConnection = New SqlConnection("Provider=Microsoft.ACE.Sql.12.0;Data Source=|DataDirectory|\PayrollManagerDB.accdb;Persist Security Info=False;")
            MyCommand.Connection = MyConnection
            MyCommand.CommandText = "select PaymentID,Datefrom,dateTo,EmployeeRegistration.employeeid,employeename,designation,department,EmployeePayment.salary,presentdays,advance,deduction,overtime,overtimeamount,paymentdate,modeofpayment,netpay from EmployeePayment,EmployeeRegistration where EmployeeRegistration.EmployeeID=EmployeePayment.EmployeeID and PaymentID='" & frmEmployeePayment.PaymentID.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeePayment")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class