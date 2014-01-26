Imports System.Data.SqlClient

Public Class ServerConnect



    Public Shared Function GetDatabaseNames(serverName As String) As List(Of String)
        Dim connString As String
        Dim databaseNames As New List(Of String)

        ' Be sure to replace this with your connection string.
        connString = "Data Source=" & serverName & ";Integrated Security=True"

        If Not String.IsNullOrEmpty(connString) Then
            Using cn As SqlConnection = New SqlConnection(connString)
                ' Open the connection
                cn.Open()

                Using cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_databases"

                    Using myReader As SqlDataReader = cmd.ExecuteReader()
                        While (myReader.Read())
                            databaseNames.Add(myReader.GetString(0))
                        End While
                    End Using
                End Using
            End Using
        End If

        Return databaseNames
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connectMe()
        'frmlogin.ShowDialog()
        'BiometricsScan.ShowDialog()
        frmlogin.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Dim instance As System.Data.Sql.SqlDataSourceEnumerator = System.Data.Sql.SqlDataSourceEnumerator.Instance
        Dim dataTable As System.Data.DataTable = instance.GetDataSources()

        ComboBox1.DataSource = dataTable
        ComboBox1.DisplayMember = "ServerName"
    End Sub


    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        If Not String.IsNullOrEmpty(ComboBox1.Text) Then
            ComboBox2.DataSource = GetDatabaseNames(ComboBox1.Text)
        End If
    End Sub

    Private Sub connectMe()
        Dim newSqlInstance As New SqlConnectionDBase(ComboBox1.Text, ComboBox2.Text, TextBox1.Text, TextBox2.Text, CheckBox1.Checked)
        MessageBox.Show(newSqlInstance.openConnection())

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub
End Class