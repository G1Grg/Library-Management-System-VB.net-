Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBook

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (txtBookName.Text = "") Then
            MessageBox.Show("Please enter book name")
        Else
            Dim book_name, book_author, book_publisher, book_isbn As String
            Dim book_date As Date
            book_name = txtBookName.Text
            book_author = txtAuthor.Text
            book_publisher = txtPublisher.Text
            book_isbn = txtISBN.Text
            book_date = dtpPublishedDate.Value
            Dim sql, conString As String
            sql = "INSERT INTO books(book_name,book_author,book_publisher,book_isbn,book_published_date)
                VALUES('" + book_name + "','" + book_author + "','" + book_publisher + "','" + book_isbn + "','" + book_date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')"
            conString = "Data Source=LAPTOP-LENOVO;Initial Catalog=Library;Integrated Security=True"
            Dim con As SqlConnection
            Dim cmd As SqlCommand

            con = New SqlConnection(conString)
            con.Open()

            cmd = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("New Book Added Successfully!")
        End If
    End Sub

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class