Imports MySql.Data.MySqlClient

Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub LoginBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBt.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;database=hr_informationsystem3"

        If Usernametb.Text = "" Or Passwordtb.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Usernametb.Focus()
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "select * from hr_informationsystem3.user where username='" & Usernametb.Text & "'and user_password='" & Passwordtb.Text & "' "
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader

                Dim count As Integer
                count = 0
                While Reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    Form4.Show()
                    Me.Opacity = 0
                ElseIf count > 1 Then
                    MessageBox.Show("Duplicate")
                Else
                    MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Usernametb.Text = ""
                    Passwordtb.Text = ""
                    Usernametb.Focus()
                End If

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
    End Sub
End Class