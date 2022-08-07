Public Class Form1

    Private Sub linkacct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkacct.LinkClicked
        anima1.HideSync(p2)
        anima1.ShowSync(p3)
        BunifuMaterialTextbox1.Text = ""
        BunifuMaterialTextbox2.Text = ""


    End Sub
    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        anima1.HideSync(p3)
        anima1.ShowSync(p2)
        BunifuMaterialTextbox3.Text = ""
        BunifuMaterialTextbox4.Text = ""



    End Sub
    Private Sub GunaCheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs)
        End
    End Sub




    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

        If BunifuMaterialTextbox4.Text = "" And BunifuMaterialTextbox3.Text = "" Then
            MsgBox("PLEAS FILL UP THE TWO EMPTY BOXES")
        ElseIf BunifuMaterialTextbox4.Text = Nothing Then
            MsgBox("Fill up the Username")
        ElseIf BunifuMaterialTextbox3.Text = Nothing Then
            MsgBox("Fill up the Password")

        ElseIf BunifuMaterialTextbox4.Text = "admin" Then
            If BunifuMaterialTextbox3.Text = "admin" Then
                BunifuMaterialTextbox4.Text = ""
                BunifuMaterialTextbox3.Text = ""
                MsgBox("Succsfully Login")
                Me.Hide()
                adminpage.Show()


            Else
                MsgBox("Wrong Password")
            End If
        ElseIf BunifuMaterialTextbox3.Text = "admin" Then
            If BunifuMaterialTextbox4.Text = "admin" Then
                BunifuMaterialTextbox4.Text = ""
                BunifuMaterialTextbox3.Text = ""
                MsgBox("Successfully Login")
                Me.Hide()
                adminpage.Show()
            Else
                MsgBox("Wrong Username ")
            End If

        ElseIf BunifuMaterialTextbox4.Text <> "admin" And BunifuMaterialTextbox3.Text <> "admin" Then
            MsgBox("Wrong Username and Password")


        End If



    End Sub



    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim user, pass As String
            user = BunifuMaterialTextbox1.Text
            pass = BunifuMaterialTextbox2.Text

            Dim dt As DataTable = login(user, pass)

            If dt.Rows.Count > 0 Then
                MsgBox("Succesfully Login")
                BunifuMaterialTextbox1.Text = ""
                BunifuMaterialTextbox2.Text = ""

                '//Verification Process start

                Dim dt2 As DataTable = verification(user, pass)
                If dt2.Rows.Count > 0 Then
                    MsgBox("But you're already voted")
                    BunifuMaterialTextbox1.Text = ""
                    BunifuMaterialTextbox2.Text = ""
                Else
                    Me.Hide()
                    student.Show()
                End If
                '//Verification Process end


            Else
                MsgBox("Invalid username and password")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        End

    End Sub



    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

 
    Private Sub GunaLinkLabel2_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaLinkLabel2.MouseClick

    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        anima2.Hide(p2)
        anima2.Hide(p3)
        anima2.Hide(p1)

        anima2.Show(dev)


    End Sub

    Private Sub Guna2HtmlLabel14_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel14.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Guna2HtmlLabel10_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2HtmlLabel9.MouseClick, Guna2HtmlLabel8.MouseClick, Guna2HtmlLabel10.MouseClick
        anima2.Hide(dev)
        anima2.Show(p1)
        anima2.Hide(p3)
        anima2.Show(p2)


    End Sub
End Class