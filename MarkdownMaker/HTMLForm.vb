Imports MarkdownMaker.Service
Imports iNovation.Code.Desktop
Imports iNovation.Code.General
Imports MarkdownMaker.KB
Imports iNovation.Code.Feedback
Imports MarkdownMaker.Values
Public Class HTMLForm
    Private feedback As New iNovation.Code.Feedback
    Private opened_file As String = ""
    Private Sub HTMLForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupUI()
    End Sub

    Private Sub SetupUI()
        BindProperty(dropElement, GetEnum(New elementsMarkup))
        formatDrops({dropLanguage, dropElement})
        textMarkup.Focus()
    End Sub

    Private Sub HTMLForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub buttonOpen_Click(sender As Object, e As EventArgs) Handles buttonOpen.Click
        Dim file As String = GetFile(textMarkup, FileDialogExpectedFormat.code)
        If file.Length > 0 Then Text = "Editing " + file

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        SaveFile(Content(textMarkup), FileKind.Markdown, "Choose where to save your file", "ReadMe")
    End Sub

    Private Sub buttonSendToClipboard_Click(sender As Object, e As EventArgs) Handles buttonSendToClipboard.Click
        Dim t As String = Content(textMarkup)
        If t.Length > 0 Then Clipboard.SetText(t)
    End Sub

    Private Sub buttonElement_Click(sender As Object, e As EventArgs) Handles buttonElement.Click
        dropElement_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub dropElement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropElement.SelectedIndexChanged
        If Content(textMarkup).Length < 1 Then Return
        showSnippet()
    End Sub

    Sub showSnippet()

        Dim t As RichTextBox = textMarkup
        Dim drop As ComboBox = dropElement

        If Content(dropElement) = elementsMarkup.__________________________.ToString Then Return

        If t.SelectionLength < 1 Then
            If Content(drop) <> elementsMarkup.hr.ToString And
                    Content(drop) <> elementsMarkup.br.ToString And
                    Content(drop) <> elementsMarkup.video.ToString And
                    Content(drop) <> elementsMarkup.a.ToString And
                    Content(drop) <> elementsMarkup.img.ToString Then
                feedback.say("please make a selection first")
                Return
            End If
        End If

        Dim pre As String = t.Text.Substring(0, t.SelectionStart)
        Dim suf As String = t.Text.Substring(t.SelectionLength + t.SelectionStart)
        Dim text As String = t.Text.Substring(t.SelectionStart, t.SelectionLength).Trim.Replace(vbCrLf, "").Replace(vbCr, "")
        Dim code As List(Of String) = getSnippetMarkup(Content(dropElement), text, Content(dropLanguage))

        textMarkup.Focus()
        Dim s = t.SelectionStart
        Dim l = t.SelectionLength

        If dropElement.Text = elementsMarkup.a.ToString Then
            t.Text = pre & code(0) & vbCrLf & suf
        ElseIf dropElement.Text = elementsMarkup.img.ToString Then
            t.Text = pre & code(0) & vbCrLf & suf
        ElseIf dropElement.Text = elementsMarkup.video.ToString Then
            t.Text = pre & code(0) & vbCrLf & suf
        Else
            t.Text = pre & code(0) & text & code(1) & suf
        End If

        t.SelectionStart = s ''+ l
        t.ScrollToCaret()
    End Sub
End Class