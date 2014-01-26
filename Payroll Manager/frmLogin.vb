Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmlogin

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmChangePassword.Show()
    End Sub

    Private Sub login_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_button.Click
        If Len(Trim(UserName.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Focus()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
            Exit Sub
        End If
        Try
            'SQL SERVER 
            'Dim myConnection As New SqlConnectionDBase(


            'Dim myConnection As OleDbConnection
            'myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PayrollManagerDB.accdb;Persist Security Info=False;")

            'Dim myCommand As OleDbCommand

            'myCommand = New OleDbCommand("SELECT username,password FROM Users WHERE username = @username AND password = @UserPassword", myConnection)

            'Dim uName As New OleDbParameter("@username", OleDbType.VarChar)

            'Dim uPassword As New OleDbParameter("@UserPassword", OleDbType.VarChar)

            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("SELECT username,password FROM Users WHERE username = @username AND password = @UserPassword", MyConnection)

            Dim uName As New SqlParameter("@username", SqlDbType.VarChar)

            Dim uPassword As New SqlParameter("@UserPassword", SqlDbType.VarChar)

            uName.Value = UserName.Text

            uPassword.Value = Password.Text

            myCommand.Parameters.Add(uName)

            myCommand.Parameters.Add(uPassword)

            'myCommand.Connection.Open()

            Dim myReader As SqlDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then

                myReader.Read()

                Login = myReader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                UserName.Clear()
                Password.Clear()
                UserName.Focus()
            Else

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 5000
                ProgressBar1.Minimum = 0
                ProgressBar1.Value = 4
                ProgressBar1.Step = 1

                For i = 0 To 5000
                    ProgressBar1.PerformStep()
                Next

                frmMainMenu.ToolStripStatusLabel2.Text = UserName.Text
                Me.Hide()
                frmMainMenu.Show()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Login_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ServerConnect.ShowDialog()
        UserName.Focus()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        frmPasswordRecovery.Show()
    End Sub


End Class