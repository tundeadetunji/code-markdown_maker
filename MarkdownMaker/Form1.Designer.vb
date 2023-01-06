<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dropElement = New System.Windows.Forms.ComboBox()
        Me.buttonFont = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.dropLanguage = New System.Windows.Forms.ComboBox()
        Me.buttonSendToClipboard = New System.Windows.Forms.Button()
        Me.buttonOpen = New System.Windows.Forms.Button()
        Me.buttonElement = New System.Windows.Forms.Button()
        Me.textMarkup = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'dropElement
        '
        Me.dropElement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dropElement.FormattingEnabled = True
        Me.dropElement.Location = New System.Drawing.Point(390, 14)
        Me.dropElement.Name = "dropElement"
        Me.dropElement.Size = New System.Drawing.Size(341, 33)
        Me.dropElement.TabIndex = 1
        '
        'buttonFont
        '
        Me.buttonFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonFont.Image = Global.MarkdownMaker.My.Resources.Resources.Apps_preferences_desktop_font_icon_24
        Me.buttonFont.Location = New System.Drawing.Point(881, 14)
        Me.buttonFont.Name = "buttonFont"
        Me.buttonFont.Size = New System.Drawing.Size(66, 33)
        Me.buttonFont.TabIndex = 3
        Me.buttonFont.UseVisualStyleBackColor = True
        '
        'buttonSave
        '
        Me.buttonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSave.Image = Global.MarkdownMaker.My.Resources.Resources.Actions_document_save_as_icon_24
        Me.buttonSave.Location = New System.Drawing.Point(809, 14)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(66, 33)
        Me.buttonSave.TabIndex = 2
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'dropLanguage
        '
        Me.dropLanguage.FormattingEnabled = True
        Me.dropLanguage.Location = New System.Drawing.Point(85, 14)
        Me.dropLanguage.Name = "dropLanguage"
        Me.dropLanguage.Size = New System.Drawing.Size(227, 33)
        Me.dropLanguage.TabIndex = 4
        '
        'buttonSendToClipboard
        '
        Me.buttonSendToClipboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSendToClipboard.Image = Global.MarkdownMaker.My.Resources.Resources.Alarm_Arrow_Up_icon_24
        Me.buttonSendToClipboard.Location = New System.Drawing.Point(737, 14)
        Me.buttonSendToClipboard.Name = "buttonSendToClipboard"
        Me.buttonSendToClipboard.Size = New System.Drawing.Size(66, 33)
        Me.buttonSendToClipboard.TabIndex = 5
        Me.buttonSendToClipboard.UseVisualStyleBackColor = True
        '
        'buttonOpen
        '
        Me.buttonOpen.Image = Global.MarkdownMaker.My.Resources.Resources.Alarm_Arrow_Down_icon_24
        Me.buttonOpen.Location = New System.Drawing.Point(13, 14)
        Me.buttonOpen.Name = "buttonOpen"
        Me.buttonOpen.Size = New System.Drawing.Size(66, 33)
        Me.buttonOpen.TabIndex = 7
        Me.buttonOpen.UseVisualStyleBackColor = True
        '
        'buttonElement
        '
        Me.buttonElement.Image = Global.MarkdownMaker.My.Resources.Resources.Alarm_Tick_icon_24
        Me.buttonElement.Location = New System.Drawing.Point(318, 14)
        Me.buttonElement.Name = "buttonElement"
        Me.buttonElement.Size = New System.Drawing.Size(66, 33)
        Me.buttonElement.TabIndex = 8
        Me.buttonElement.UseVisualStyleBackColor = True
        '
        'textMarkup
        '
        Me.textMarkup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textMarkup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textMarkup.Location = New System.Drawing.Point(13, 53)
        Me.textMarkup.Name = "textMarkup"
        Me.textMarkup.Size = New System.Drawing.Size(934, 360)
        Me.textMarkup.TabIndex = 9
        Me.textMarkup.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(961, 427)
        Me.Controls.Add(Me.textMarkup)
        Me.Controls.Add(Me.buttonElement)
        Me.Controls.Add(Me.buttonOpen)
        Me.Controls.Add(Me.buttonSendToClipboard)
        Me.Controls.Add(Me.dropLanguage)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.buttonFont)
        Me.Controls.Add(Me.dropElement)
        Me.Font = New System.Drawing.Font("Cascadia Code ExtraLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Markdown Maker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dropElement As ComboBox
    Friend WithEvents buttonFont As Button
    Friend WithEvents FontDialog As FontDialog
    Friend WithEvents buttonSave As Button
    Friend WithEvents dropLanguage As ComboBox
    Friend WithEvents buttonSendToClipboard As Button
    Friend WithEvents buttonOpen As Button
    Friend WithEvents buttonElement As Button
    Friend WithEvents textMarkup As RichTextBox
End Class
