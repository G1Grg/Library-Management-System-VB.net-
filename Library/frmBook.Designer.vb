<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpPublishedDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Name:"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(162, 74)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(148, 26)
        Me.txtBookName.TabIndex = 1
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(162, 114)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(148, 26)
        Me.txtAuthor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Author:"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(162, 154)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(148, 26)
        Me.txtPublisher.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Publisher:"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(162, 194)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(148, 26)
        Me.txtISBN.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ISBN No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Published Date:"
        '
        'dtpPublishedDate
        '
        Me.dtpPublishedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPublishedDate.Location = New System.Drawing.Point(186, 234)
        Me.dtpPublishedDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpPublishedDate.Name = "dtpPublishedDate"
        Me.dtpPublishedDate.Size = New System.Drawing.Size(170, 26)
        Me.dtpPublishedDate.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(200, 294)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpPublishedDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmBook"
        Me.Text = "frmBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpPublishedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
