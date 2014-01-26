Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmSalarySlipsReport
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    'Dim cs As String = "Provider=Microsoft.ACE.Sql.12.0;Data Source=|DataDirectory|\PayrollManagerDB.accdb;Persist Security Info=False;"

    Private Sub frmSalarySlipsReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Try

            Dim rpt As New rptSalarySlips() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            'myConnection = myConnection
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select PaymentID,Datefrom,dateTo,EmployeeRegistration.employeeid,employeename,designation,department,EmployeePayment.salary,presentdays,advance,deduction,overtime,overtimeamount,paymentdate,modeofpayment,netpay from EmployeePayment,EmployeeRegistration where EmployeeRegistration.EmployeeID=EmployeePayment.EmployeeID and PaymentDate between '" & DateFrom.Text & "' And '" & DateTo.Text & "'"
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

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        DateFrom.Text = Today
        DateTo.Text = Today
        CrystalReportViewer1.ReportSource = Nothing
    End Sub
    Sub fillcombo()

        Try

            'Dim CN As New SqlConnection(cs)

            'CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  (employeename) FROM employeeRegistration,EmployeePayment where EmployeeRegistration.EmployeeID=Employeepayment.EmployeeID", MyConnection)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            EmployeeName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                EmployeeName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim rpt As New rptSalarySlips() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            'myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select PaymentID,Datefrom,dateTo,EmployeeRegistration.employeeid,employeename,designation,department,EmployeePayment.salary,presentdays,advance,deduction,overtime,overtimeamount,paymentdate,modeofpayment,netpay from EmployeePayment,EmployeeRegistration where EmployeeRegistration.EmployeeID=EmployeePayment.EmployeeID and PaymentDate between '" & DateTimePicker2.Value & "' And '" & DateTimePicker1.Value & "' AND Employeename='" & EmployeeName.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeePayment")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer2.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        EmployeeName.Text = ""
        CrystalReportViewer2.ReportSource = Nothing
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        EmployeeName.Text = ""
        CrystalReportViewer2.ReportSource = Nothing
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateFrom.Text = Today
        DateTo.Text = Today
        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub frmSalarySlipsReport_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class