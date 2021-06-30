Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "" Or txtPassword.Text = "") Then
            MessageBox.Show("Login credentials must not be blank")
        Else
            Dim username, password As String
            username = txtUsername.Text
            password = txtPassword.Text
            Dim sql, conString As String
            sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'"
            conString = "Data Source=LAPTOP-LENOVO;Initial Catalog=Library;Integrated Security=True"
            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim da As SqlDataAdapter
            Dim dt As New DataTable

            con = New SqlConnection(conString)
            cmd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MessageBox.Show("Login Successfull!")
                frmMain.LogoutToolStripMenuItem.Enabled = True
                frmMain.LoginToolStripMenuItem.Enabled = False
                frmMain.BookToolStripMenuItem.Enabled = True
                If (dt.Rows(0)(1).ToString() = "admin1") Then
                    frmMain.UserToolStripMenuItem.Enabled = True
                End If
                Me.Close()
            Else
                MessageBox.Show("Invalid Credentials!")
            End If

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class