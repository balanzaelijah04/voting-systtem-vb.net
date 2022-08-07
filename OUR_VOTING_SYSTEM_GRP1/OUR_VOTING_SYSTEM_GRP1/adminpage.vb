Public Class adminpage

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        animation.Hide(Panel6)
        animation.Hide(Panel2)
        animation.Hide(Panel4)
        animation.Hide(Panel5)

        animation.Show(Panel3)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        animation.Hide(Panel6)
        animation.Hide(Panel2)
        animation.Hide(Panel3)
        animation.Hide(Panel5)

        animation.Show(Panel4)
        tally2()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        animation.Hide(Panel6)
        animation.Hide(Panel2)
        animation.Hide(Panel4)
        animation.Hide(Panel3)

        animation.Show(Panel5)
        vacct()

    End Sub


    Private Sub adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tally2()
        vacct()
        

    End Sub

    Private Sub tally2()
        Dim dt As DataTable = tally()
        GunaDataGridView1.DataSource = dt

    End Sub


    Private Sub vacct()
        Dim dt As DataTable = vacc()
        GunaDataGridView2.DataSource = dt

    End Sub




    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        animation.Hide(Panel2)
        animation.Hide(Panel4)
        animation.Hide(Panel3)
        animation.Hide(Panel5)
        animation.Show(Panel6)

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
                BunifuMaterialTextbox3.Text = ""
                BunifuMaterialTextbox4.Text = ""
                animation.Show(Panel2)
                animation.Hide(Panel4)
                animation.Hide(Panel3)
                animation.Hide(Panel5)
                animation.Hide(Panel6)
                MsgBox("Succsfully Logout")
                Me.Hide()
                Form1.Show()

            Else
                MsgBox("Wrong Password")
            End If
        ElseIf BunifuMaterialTextbox3.Text = "admin" Then
            If BunifuMaterialTextbox4.Text = "admin" Then
                BunifuMaterialTextbox3.Text = ""
                BunifuMaterialTextbox4.Text = ""
                animation.Show(Panel2)
                animation.Hide(Panel4)
                animation.Hide(Panel3)
                animation.Hide(Panel5)
                animation.Hide(Panel6)
                MsgBox("Successfully Logout")
                Me.Hide()
                Form1.Show()
            Else
                MsgBox("Wrong Username ")
            End If

        ElseIf BunifuMaterialTextbox4.Text <> "admin" And BunifuMaterialTextbox3.Text <> "admin" Then
            MsgBox("Wrong Username and Password")


        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)
        End

    End Sub

    
    Private Sub Guna2HtmlLabel15_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel15.Click

    End Sub

    Private Sub GunaDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView2.CellContentClick

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        End
    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        animation.Hide(Panel2)
        animation.Hide(Panel4)
        animation.Hide(Panel3)
        animation.Hide(Panel5)
        animation.Hide(Panel6)

    End Sub
End Class