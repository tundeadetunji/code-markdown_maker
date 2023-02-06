Imports System.Windows.Forms

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupUI()
    End Sub

    Private Sub SetupUI()
        Form1.MdiParent = Me
    End Sub
    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click

    End Sub

    Private Sub MarkdownButton_Click(sender As Object, e As EventArgs) Handles MarkdownButton.Click
        Form1.Show()
    End Sub

    Private Sub HTMLButton_Click(sender As Object, e As EventArgs) Handles HTMLButton.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub

    Private Sub FontButton_Click(sender As Object, e As EventArgs) Handles FontButton.Click

    End Sub
End Class
