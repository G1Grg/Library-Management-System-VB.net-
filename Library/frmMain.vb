Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogoutToolStripMenuItem.Enabled = False
        BookToolStripMenuItem.Enabled = False
        UserToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Dim login As New frmLogin()
        login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginToolStripMenuItem.Enabled = True
        BookToolStripMenuItem.Enabled = False
        UserToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBookToolStripMenuItem.Click
        Dim book As frmBook
        book = New frmBook()
        book.ShowDialog()
    End Sub
End Class
