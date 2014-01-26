Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAdvanceEntryReport
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    'Dim cs As String = "Provider=Microsoft.ACE.Sql.12.0;Data Source=|DataDirectory|\PayrollManagerDB.accdb;Persist Security Info=False;"


    Private Sub frmAdvanceEntryReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub
    Private Sub frmAdvanceEntryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub
    Sub fillcombo()

        Try

            'Dim CN As New SqlConnection(cs)

            'CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (employeename) FROM Advanceentry,employeeRegistration where EmployeeRegistration.EmployeeID=AdvanceEntry.EmployeeID", MyConnection)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbEmployeeName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbEmployeeName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmployeeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmployeeName.SelectedIndexChanged
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptAdvancePayment() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            'myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select EmployeeRegistration.EmployeeID,EmployeeName,Amount,WorkingDate FROM Advanceentry,employeeRegistration where EmployeeRegistration.EmployeeID=AdvanceEntry.EmployeeID and employeeName = '" & cmbEmployeeName.Text & "' and Amount > 0 order by WorkingDate"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "AdvanceEntry")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeName.TextChanged
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptAdvancePayment() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            'myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select EmployeeRegistration.EmployeeID,EmployeeName,Amount,WorkingDate FROM Advanceentry,employeeRegistration where EmployeeRegistration.EmployeeID=AdvanceEntry.EmployeeID and employeeName like '" & cmbEmployeeName.Text & "%' and  Amount > 0 order by workingDate"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "AdvanceEntry")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptAdvancePayment() 'The report you created.
            'Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New PayrollManagerDBDataSet 'The DataSet you created.
            'myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select EmployeeRegistration.EmployeeID,EmployeeName,Amount,WorkingDate FROM Advanceentry,employeeRegistration where EmployeeRegistration.EmployeeID=AdvanceEntry.EmployeeID and Amount > 0 and workingdate between '" & DateFrom.Value & "' And '" & DateTo.Value & "' order by workingdate"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "AdvanceEntry")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer2.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        CrystalReportViewer2.ReportSource = Nothing
        DateFrom.Value = Today
        DateTo.Value = Today
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click

        cmbEmployeeName.Text = ""
        txtEmployeeName.Text = ""
        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        CrystalReportViewer2.ReportSource = Nothing
        DateFrom.Value = Today
        DateTo.Value = Today

        cmbEmployeeName.Text = ""
        txtEmployeeName.Text = ""
        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
End Class