Imports MySql.Data.MySqlClient
Public Class student

    Dim con As New MySqlConnection("server=localhost;database=grp1votingsystem;user=root;password='';")
    Dim president1, president2, v_president1, v_president2, secretary1, secretary2, auditor1, auditor2, id As Integer


    Dim constring As String = "data source = localhost; user id = root; database = grp1votingsystem"
    Dim cmd As MySqlCommand

    Private Sub displaytally()
        Dim dt As DataTable = tally()
        GunaDataGridView1.DataSource = dt



    End Sub



    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ComboBox1.Text = "--SELECT--"
        Guna2ComboBox2.Text = "--SELECT--"
        Guna2ComboBox3.Text = "--SELECT--"
        Guna2ComboBox4.Text = "--SELECT--"


        Guna2PictureBox2.Image = My.Resources._select
        Guna2PictureBox3.Image = My.Resources._select
        Guna2PictureBox4.Image = My.Resources._select
        Guna2PictureBox5.Image = My.Resources._select
        displaytally()





    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        animation2.Hide(Panel2)
        animation2.Hide(Panel4)
        animation2.Hide(Panel5)
        animation2.Show(Panel3)


    End Sub


    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)
        End

    End Sub



    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        If Guna2ComboBox1.Text = "--SELECT--" Then
            Guna2PictureBox2.Image = My.Resources._select

        ElseIf Guna2ComboBox1.Text = "PRESIDENT 1" Then
            Guna2PictureBox2.Image = My.Resources.person1

        ElseIf Guna2ComboBox1.Text = "PRESIDENT 2" Then

            Guna2PictureBox2.Image = My.Resources.person2

        End If



    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        If Guna2ComboBox2.Text = "--SELECT--" Then
            Guna2PictureBox3.Image = My.Resources._select

        ElseIf Guna2ComboBox2.Text = "VICE PRESIDENT 1" Then
            Guna2PictureBox3.Image = My.Resources.person1

        ElseIf Guna2ComboBox2.Text = "VICE PRESIDENT 2" Then

            Guna2PictureBox3.Image = My.Resources.person2

        End If
    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox3.SelectedIndexChanged

        If Guna2ComboBox3.Text = "--SELECT--" Then
            Guna2PictureBox4.Image = My.Resources._select

        ElseIf Guna2ComboBox3.Text = "SECRETARY 1" Then
            Guna2PictureBox4.Image = My.Resources.person1

        ElseIf Guna2ComboBox3.Text = "SECRETARY 2" Then

            Guna2PictureBox4.Image = My.Resources.person2

        End If

    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox4.SelectedIndexChanged

        If Guna2ComboBox4.Text = "--SELECT--" Then
            Guna2PictureBox5.Image = My.Resources._select

        ElseIf Guna2ComboBox4.Text = "AUDITOR 1" Then
            Guna2PictureBox5.Image = My.Resources.person1

        ElseIf Guna2ComboBox4.Text = "AUDITOR 2" Then

            Guna2PictureBox5.Image = My.Resources.person2

        End If

    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click

        '// START OF TALLY FOR PRESIDENTS

        If Guna2ComboBox1.Text = "PRESIDENT 1" Then

            '//president 1

            Dim command As New MySqlCommand("select * from tally where id =@id", con)

            president1 = 1
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = president1
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder1 As Integer
            holder1 = table.Rows(0)(2).ToString()
            holder1 = holder1 + 1



            '// PRESIDENT 1 TALLY


            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & president1 & "', tcount = '" & holder1 & "' where id = '" & president1 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted PRESIDENT 1 for President ", vbInformation, "admin")
                    Guna2ComboBox1.Enabled = False



                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            '//PRESIDENT 1 TALLY



        ElseIf Guna2ComboBox1.Text = "PRESIDENT 2" Then

            '// PRESIDENT 2
            Dim command As New MySqlCommand("select * from tally where id =@id", con)

            president2 = 5
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = president2
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder2 As Integer
            holder2 = table.Rows(0)(2).ToString()
            holder2 = holder2 + 1


            '// PRESIDENT 2 TALLY

            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & president2 & "', tcount = '" & holder2 & "' where id = '" & president2 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted PRESIDENT 2 for President", vbInformation, "admin")
                    Guna2ComboBox1.Enabled = False
                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        End If
        '// PRESIDENT 2 TALLY


        '// END OF TALLY FOR PRESIDENTS






        '//VICE PRESIDENT SECTION
        If Guna2ComboBox2.Text = "VICE PRESIDENT 1" Then

            '//VICE PRESIDENT 1

            Dim command As New MySqlCommand("select * from tally where id =@id", con)

            v_president1 = 2
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = v_president1
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder3 As Integer
            holder3 = table.Rows(0)(2).ToString()
            holder3 = holder3 + 1



            '// VICE PRESIDENT 1 TALLY


            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & v_president1 & "', tcount = '" & holder3 & "' where id = '" & v_president1 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You Voted VICE PRESIDENT 1 for Vice President", vbInformation, "admin")
                    Guna2ComboBox2.Enabled = False



                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            'END VICE PRESIDENT 1



            'START VICE PRESIDENT 2
        ElseIf Guna2ComboBox2.Text = "VICE PRESIDENT 2" Then

            '//VICE PRESIDENT 2 

            Dim command As New MySqlCommand("select * from tally where id =@id", con)

            v_president2 = 6
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = v_president2
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder4 As Integer
            holder4 = table.Rows(0)(2).ToString()
            holder4 = holder4 + 1



            '// VICE PRESIDENT 2 TALLY


            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & v_president2 & "', tcount = '" & holder4 & "' where id = '" & v_president2 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted VICE PRESIDENT 2 for Vice President", vbInformation, "admin")
                    Guna2ComboBox2.Enabled = False



                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            '//VICE PRESIDENT 2 TALLY

        End If


        '//END VICE PRESIDENT SECTION











        '//SECTION START OF SECRETARY 

        If Guna2ComboBox3.Text = "SECRETARY 1" Then

            '//SECRETARY 1 

            Dim command As New MySqlCommand("select * from tally where id =@id", con)

            secretary1 = 3
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = secretary1
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder5 As Integer
            holder5 = table.Rows(0)(2).ToString()
            holder5 = holder5 + 1

            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & secretary1 & "', tcount = '" & holder5 & "' where id = '" & secretary1 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted SECRETARY 1 for Secretary", vbInformation, "admin")
                    Guna2ComboBox3.Enabled = False
                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '// END OF SECRETARY 1


            '// START OF SECRETARY 2

        ElseIf Guna2ComboBox3.Text = "SECRETARY 2" Then

            '//SECRETARY 2

            Dim command As New MySqlCommand("select * from tally where id =@id", con)

            secretary2 = 7
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = secretary2
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder6 As Integer
            holder6 = table.Rows(0)(2).ToString()
            holder6 = holder6 + 1

            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & secretary2 & "', tcount = '" & holder6 & "' where id = '" & secretary2 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted SECRETARY 2 for Secretary", vbInformation, "admin")
                    Guna2ComboBox3.Enabled = False
                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '//END OF SECRETARY 2

        End If
        '//SECTION END OF SECRETARY 2





        '// START OF AUDITOR

        If Guna2ComboBox4.Text = "AUDITOR 1" Then

            '//AUDITOR 1

            Dim command As New MySqlCommand("select * from tally where id =@id", con)
            auditor1 = 4
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = auditor1
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder7 As Integer
            holder7 = table.Rows(0)(2).ToString()
            holder7 = holder7 + 1

            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & auditor1 & "', tcount = '" & holder7 & "' where id = '" & auditor1 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted AUDITOR 1 for Auditor", vbInformation, "admin")
                    Guna2ComboBox4.Enabled = False
                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '//END OF AUDITOR 1



            '// START IF AUDITOR 2

        ElseIf Guna2ComboBox4.Text = "AUDITOR 2" Then

            '//AUDITOR 2

            Dim command As New MySqlCommand("select * from tally where id =@id", con)
            auditor2 = 8
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = auditor2
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            Dim holder8 As Integer
            holder8 = table.Rows(0)(2).ToString()
            holder8 = holder8 + 1

            Try
                con = New MySqlConnection(constring)
                con.Open()
                Dim SQL As String = "Update tally set id = '" & auditor2 & "', tcount = '" & holder8 & "' where id = '" & auditor2 & "' "
                cmd = New MySqlCommand(SQL, con)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i <> 0 Then
                    MsgBox("You voted AUDITOR 2 for Auditor", vbInformation, "admin")
                    Guna2ComboBox4.Enabled = False
                Else
                    MsgBox("vote not recorded", vbCritical, "admin")
                End If
                displaytally()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '//END OF AUDITOR 2

        End If
        '// END OF AUDITOR




        If Guna2ComboBox1.Enabled = False And Guna2ComboBox2.Enabled = False And Guna2ComboBox3.Enabled = False And Guna2ComboBox4.Enabled = False Then
            MsgBox("THANK YOU FOR YOUR PARTICIPATION", vbInformation, "admin")

            Guna2ComboBox1.Enabled = True
            Guna2ComboBox2.Enabled = True
            Guna2ComboBox3.Enabled = True
            Guna2ComboBox4.Enabled = True
            Guna2ComboBox1.Text = "--SELECT--"
            Guna2ComboBox2.Text = "--SELECT--"
            Guna2ComboBox3.Text = "--SELECT--"
            Guna2ComboBox4.Text = "--SELECT--"


            Guna2PictureBox2.Image = My.Resources._select
            Guna2PictureBox3.Image = My.Resources._select
            Guna2PictureBox4.Image = My.Resources._select
            Guna2PictureBox5.Image = My.Resources._select

            animation2.Hide(Panel2)
            animation2.Hide(Panel3)
            animation2.Hide(Panel4)
            animation2.Hide(Panel5)
            animation2.Show(Panel6)




            



        Else
            MsgBox("PLEASE FILL ALL THE BALLOTS", vbInformation, "admin")

        End If








    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()

    End Sub


    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        animation2.Hide(Panel2)
        animation2.Hide(Panel3)
        animation2.Hide(Panel5)
        animation2.Show(Panel4)






    End Sub


    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        animation2.Hide(Panel2)
        animation2.Hide(Panel3)
        animation2.Hide(Panel4)
        animation2.Show(Panel5)





    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click



        If BunifuMaterialTextbox1.Text = Nothing And BunifuMaterialTextbox2.Text = Nothing And BunifuMaterialTextbox3.Text = Nothing And BunifuMaterialTextbox4.Text = Nothing And BunifuMaterialTextbox5.Text = Nothing Then
            MsgBox("Please fill up the blanks")

        Else

            Try
                Dim user, pass As String
                user = BunifuMaterialTextbox1.Text
                pass = BunifuMaterialTextbox2.Text

                Dim dt As DataTable = login(user, pass)
                If dt.Rows.Count > 0 Then
                    MsgBox("Succesfully Logout")
                    MsgBox("Your vote has been recorded")
                   


                    Insert(BunifuMaterialTextbox3.Text, BunifuMaterialTextbox4.Text, BunifuMaterialTextbox5.Text)
                    BunifuMaterialTextbox1.Text = ""
                    BunifuMaterialTextbox2.Text = ""
                    BunifuMaterialTextbox3.Text = ""
                    BunifuMaterialTextbox4.Text = ""
                    BunifuMaterialTextbox5.Text = ""


                    animation2.Hide(Panel3)
                    animation2.Hide(Panel4)
                    animation2.Hide(Panel5)
                    animation2.Hide(Panel6)
                    animation2.Show(Panel2)

                    Me.Hide()
                    Form1.Show()

                Else
                    MsgBox("Invalid username and password")

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If








        
    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        End
    End Sub

    Private Sub BunifuFlatButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class