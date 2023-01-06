Imports iNovation.Code.General
Public Class KB

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
            Case elements.strong.ToString
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

    Public Enum elements
        a
        a_verbose
        blockquote
        code
        h1
        h2
        h3
        h4
        h5
        h6
        i
        img
        li
        p
        pre
        strikethrough
        strong
        strong_i
        video
    End Enum

    Public Enum defaultLanguage
        java
        c#
        javascript
        python
        html
        css
    End Enum

End Class
