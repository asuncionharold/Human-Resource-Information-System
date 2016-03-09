Imports MySql.Data.MySqlClient

Public Class Form3
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Gender As String

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBt.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;database=hr_informationsystem3"


        If EmployeeIDtb.Text = "" Or Lastnametb.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeIDtb.Focus()
        Else
            Try
                MysqlConn.Open()
                Dim Query1 As String
                Query1 = "insert into hr_informationsystem3.employee (employee_id,lastname,firstname,middlename) values ('" & EmployeeIDtb.Text & "','" & Lastnametb.Text & "', '" & Firstnametb.Text & "', '" & Middlenametb.Text & "')"
                Command = New MySqlCommand(Query1, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()

                MysqlConn.Open()
                Dim Query2 As String
                Query2 = "insert into hr_informationsystem3.employee_personalinfo (employee_id,gender,marital_status,age,birthday,phonenum,telnum,emailadd,contactperson,cp_phonenum,cp_telnum) values ('" & EmployeeIDtb.Text & "', '" & Gender & "','" & MStatustb.Text & "', '" & Agetb.Text & "', '" & Birthdaydp.Text & "', '" & Cellnumtb.Text & "', '" & Telnumtb.Text & "', '" & Emailtb.Text & "', '" & Contactpertb.Text & "', '" & ContactpCellnumtb.Text & "', '" & ContactpTelnumtb.Text & "')"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()

                MysqlConn.Open()
                Dim Query3 As String
                Query3 = "insert into hr_informationsystem3.job_history (department_id,position_id,project_id,salary,employment_status,hired_date) values ('" & DepartmentIDtb.Text & "', '" & PositionIDtb.Text & "','" & ProjectIDtb.Text & "', '" & Salarytb.Text & "', '" & EStatustb.Text & "', '" & Hireddatedp.Text & "')"
                Command = New MySqlCommand(Query3, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()

                MysqlConn.Open()
                Dim Query4 As String
                Query4 = "insert into hr_informationsystem3.educational_background (primarysch,pygraduated,secondarysch,sygraduated,tertiarysch,tygraduated) values ('" & Primarytb.Text & "', '" & PrimaryYGtb.Text & "','" & Secondarytb.Text & "', '" & SecondaryYGtb.Text & "', '" & Tertiarytb.Text & "', '" & TertiaryYGtb.Text & "')"
                Command = New MySqlCommand(Query4, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()

                MessageBox.Show("Data Saved")

                EmployeeIDtb.Text = ""
                Lastnametb.Text = ""
                Firstnametb.Text = ""
                Middlenametb.Text = ""
                EmployeeIDtb.Text = ""
                'For gender if incase
                MStatustb.Text = ""
                'Address
                Agetb.Text = ""
                Birthdaydp.Text = ""
                Cellnumtb.Text = ""
                Telnumtb.Text = ""
                Emailtb.Text = ""
                Contactpertb.Text = ""
                ContactpCellnumtb.Text = ""
                ContactpTelnumtb.Text = ""
                DepartmentIDtb.Text = ""
                PositionIDtb.Text = ""
                ProjectIDtb.Text = ""
                Salarytb.Text = ""
                EStatustb.Text = ""
                Hireddatedp.Text = ""
                Primarytb.Text = ""
                PrimaryYGtb.Text = ""
                Secondarytb.Text = ""
                SecondaryYGtb.Text = ""
                Tertiarytb.Text = ""
                TertiaryYGtb.Text = ""
                
                EmployeeIDtb.Focus()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Gender = "Female"
    End Sub
End Class