<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FontButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarkdownButton = New System.Windows.Forms.ToolStripButton()
        Me.HTMLButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.Green
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontButton, Me.ToolStripSeparator1, Me.MarkdownButton, Me.HTMLButton, Me.ToolStripSeparator2, Me.SaveButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(737, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'FontButton
        '
        Me.FontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontButton.Image = Global.MarkdownMaker.My.Resources.Resources.Apps_preferences_desktop_font_icon_24
        Me.FontButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(23, 22)
        Me.FontButton.Text = "Change Font"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'MarkdownButton
        '
        Me.MarkdownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MarkdownButton.Image = Global.MarkdownMaker.My.Resources.Resources.text_x_markdown_icon_24
        Me.MarkdownButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.MarkdownButton.Name = "MarkdownButton"
        Me.MarkdownButton.Size = New System.Drawing.Size(23, 22)
        Me.MarkdownButton.Text = "Markdown"
        '
        'HTMLButton
        '
        Me.HTMLButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HTMLButton.Image = Global.MarkdownMaker.My.Resources.Resources.html_5_icon_24
        Me.HTMLButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HTMLButton.Name = "HTMLButton"
        Me.HTMLButton.Size = New System.Drawing.Size(23, 22)
        Me.HTMLButton.Text = "Open"
        Me.HTMLButton.ToolTipText = "HTML"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = Global.MarkdownMaker.My.Resources.Resources.Alarm_Arrow_Up_icon_24
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveButton.Text = "Save"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 523)
        Me.Controls.Add(Me.ToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Markdown + HTML Editor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MarkdownButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents HTMLButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FontButton As ToolStripButton
    Friend WithEvents FontDialog As FontDialog
End Class
