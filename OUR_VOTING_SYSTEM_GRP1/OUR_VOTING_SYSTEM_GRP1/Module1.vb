Imports MySql.Data.MySqlClient


Module Module1
    Public con As New MySqlConnection("server=localhost;database=grp1votingsystem;uid=root;pwd='';")

    Public Sub Connect()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        Else
            con.Open()
        End If

    End Sub


    Public Function login(username As String, password As String)



        Connect()
        Dim cmd As New MySqlCommand("select * from  student_acc where username = @1  and password = @2", con)
        cmd.Parameters.AddWithValue("@1", username)
        cmd.Parameters.AddWithValue("@2", password)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader

        dt.Load(dr)
        Return dt

    End Function

    Public Function Insert(username As String, password As String, fullname As String)
        Connect()
        Dim cmd As New MySqlCommand("insert into votedacc(username,password,FullName) VALUES(@2,@3,@4)", con)
        With cmd
            .Parameters.AddWithValue("@2", username)
            .Parameters.AddWithValue("@3", password)
            .Parameters.AddWithValue("@4", fullname)
            .ExecuteNonQuery()
        End With
        Return True
    End Function


    Public Function verification(username As String, password As String)

        Connect()
        Dim cmd As New MySqlCommand("select * from votedacc where username = @2 and password = @3", con)
        cmd.Parameters.AddWithValue("@2", username)
        cmd.Parameters.AddWithValue("@3", password)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt

    End Function





    Public Function tally()
        Connect()
        Dim cmd As New MySqlCommand("select * from tally", con)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt
    End Function

    Public Function vacc()
        Connect()
        Dim cmd As New MySqlCommand("select * from votedacc", con)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt
    End Function









End Module
