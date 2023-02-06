Imports iNovation.Code.General
Imports MarkdownMaker.Values
Public Class Service
    Public Shared Sub formatDrops(drops As Array)
        If drops.Length = 0 Then Return
        Dim d As ComboBox
        For i = 0 To drops.Length - 1
            d = CType(drops(i), ComboBox)
            d.AutoCompleteMode = AutoCompleteMode.Suggest
            d.AutoCompleteSource = AutoCompleteSource.ListItems
        Next
    End Sub

    Public Shared Function getSnippetMarkup(element As String, Optional text As String = "", Optional language As String = "") As List(Of String)
        Dim result As New List(Of String)
        Select Case element

            Case elementsMarkup.hr.ToString
                result.Add("<hr>")
                result.Add("")
            Case elementsMarkup.br.ToString
                result.Add("<br>")
                result.Add("")
            Case elementsMarkup.video.ToString
                Dim s As String = "<a href=""http://www.youtube.com/watch?feature=player_embedded&v=" & text & """ target=""_blank""><img src=""http://img.youtube.com/vi/" & text & "/0.jpg"" width=""240"" height=""180"" border=""10"" /></a>"
                result.Add(s)
                result.Add("")
            Case elementsMarkup.a.ToString
                Dim tokens As List(Of String) = SplitTextInSplits(text, "/", SideToReturn.AsListOfString)
                Dim token As String = tokens(tokens.Count - 1)
                Dim s As String = "[" & token & "](" & text & ")"
                result.Add(s)
                result.Add("")
            Case elementsMarkup.img.ToString
                Dim tokens As List(Of String) = SplitTextInSplits(text, "/", SideToReturn.AsListOfString)
                Dim token As String = tokens(tokens.Count - 1)
                Dim s As String = "![alt text](" & text & " """ & token & """)"
                result.Add(s)
                result.Add("")


            Case elementsMarkup.h1.ToString
                result.Add("<h1>")
                result.Add("</h1>")
            Case elementsMarkup.h2.ToString
                result.Add("<h2>")
                result.Add("</h2>")
            Case elementsMarkup.h3.ToString
                result.Add("<h3>")
                result.Add("</h3>")
            Case elementsMarkup.h4.ToString
                result.Add("<h4>")
                result.Add("</h4>")
            Case elementsMarkup.h5.ToString
                result.Add("<h5>")
                result.Add("</h5>")
            Case elementsMarkup.h6.ToString
                result.Add("<h6>")
                result.Add("</h6>")
            Case elementsMarkup.li.ToString
                result.Add("<li>")
                result.Add("</li>")
            Case elementsMarkup.p.ToString
                result.Add("<p>")
                result.Add("</p>")
            Case elementsMarkup.subscript.ToString
                result.Add("<sub>")
                result.Add("</sub>")
            Case elementsMarkup.superscript.ToString
                result.Add("<sup>")
                result.Add("</sup>")
            Case elementsMarkup.underline.ToString
                result.Add("<u>")
                result.Add("</u>")

            Case elementsMarkup.i.ToString
                result.Add("<i>")
                result.Add("</i>")
            Case elementsMarkup.strong.ToString
                result.Add("<strong>")
                result.Add("</strong>")
            Case elementsMarkup.strong_i.ToString
                result.Add("<strong><i>")
                result.Add("</i></strong>")
            Case elementsMarkup.strikethrough.ToString
                result.Add("<strike>")
                result.Add("</strike>")
            Case elementsMarkup.a_verbose.ToString
                result.Add("<")
                result.Add(">")
            Case elementsMarkup.blockquote.ToString
                result.Add("<blockquote>")
                result.Add("</blockquote>")
            Case elementsMarkup.keyboard.ToString
                result.Add("<kbd>")
                result.Add("</kbd>")
            Case elementsMarkup.pre.ToString
                result.Add("<pre>")
                result.Add("</pre>")


        End Select

        Return result

    End Function

    Public Shared Function getSnippet(element As String, Optional text As String = "", Optional language As String = "") As List(Of String)
        Dim result As New List(Of String)
        Select Case element

            Case elements.h1.ToString
                result.Add("# ")
                result.Add("")
            Case elements.h2.ToString
                result.Add("## ")
                result.Add("")
            Case elements.h3.ToString
                result.Add("### ")
                result.Add("")
            Case elements.h4.ToString
                result.Add("#### ")
                result.Add("")
            Case elements.h5.ToString
                result.Add("##### ")
                result.Add("")
            Case elements.h6.ToString
                result.Add("###### ")
                result.Add("")
            Case elements.hr.ToString
                result.Add(vbCrLf & vbCrLf & "---" & vbCrLf & vbCrLf)
                result.Add("")
            Case elements.li.ToString
                result.Add("+ ")
                result.Add("")
            Case elements.p.ToString
                result.Add("  " & vbCrLf & vbCrLf)
                result.Add("")



            Case elements.i.ToString
                result.Add("*")
                result.Add("*")
            Case elements.strong.ToString
                result.Add("**")
                result.Add("**")
            Case elements.strong_i.ToString
                result.Add("***")
                result.Add("***")
            Case elements.strikethrough.ToString
                result.Add("~~")
                result.Add("~~")
            Case elements.a_verbose.ToString
                result.Add("<")
                result.Add(">")
            Case elements.blockquote.ToString
                result.Add("> ")
                result.Add("")
            Case elements.a.ToString
                Dim tokens As List(Of String) = SplitTextInSplits(text, "/", SideToReturn.AsListOfString)
                Dim token As String = tokens(tokens.Count - 1)
                Dim s As String = "[" & token & "](" & text & ")"
                result.Add(s)
                result.Add("")
            Case elements.img.ToString
                Dim tokens As List(Of String) = SplitTextInSplits(text, "/", SideToReturn.AsListOfString)
                Dim token As String = tokens(tokens.Count - 1)
                Dim s As String = "![alt text](" & text & " """ & token & """)"
                result.Add(s)
                result.Add("")
            Case elements.code.ToString
                result.Add("`")
                result.Add("`")
            Case elements.pre.ToString
                result.Add("```" & language.ToLower & vbCrLf)
                result.Add(vbCrLf & "```")
            Case elements.video.ToString
                Dim s As String = "<a href=""http://www.youtube.com/watch?feature=player_embedded&v=" & text & """ target=""_blank""><img src=""http://img.youtube.com/vi/" & text & "/0.jpg"" width=""240"" height=""180"" border=""10"" /></a>"
                result.Add(s)
                result.Add("")


        End Select

        Return result

    End Function

End Class
