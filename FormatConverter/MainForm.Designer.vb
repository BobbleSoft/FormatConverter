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
        Me.lblSource = New System.Windows.Forms.Label()
        Me.txtSrc = New System.Windows.Forms.TextBox()
        Me.rbSrcText = New System.Windows.Forms.RadioButton()
        Me.rbSrcHtml = New System.Windows.Forms.RadioButton()
        Me.rbSrcRtf = New System.Windows.Forms.RadioButton()
        Me.pnlSrc = New System.Windows.Forms.Panel()
        Me.txtTgt = New System.Windows.Forms.TextBox()
        Me.lblTgt = New System.Windows.Forms.Label()
        Me.pnlTgt = New System.Windows.Forms.Panel()
        Me.rbTgtText = New System.Windows.Forms.RadioButton()
        Me.rbTgtRtf = New System.Windows.Forms.RadioButton()
        Me.rbTgtHtml = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSrcLoad = New System.Windows.Forms.Button()
        Me.btnTgtSave = New System.Windows.Forms.Button()
        Me.LoadFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.pnlSrc.SuspendLayout()
        Me.pnlTgt.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(9, 9)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(44, 13)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Source:"
        '
        'txtSrc
        '
        Me.txtSrc.Location = New System.Drawing.Point(85, 29)
        Me.txtSrc.Multiline = True
        Me.txtSrc.Name = "txtSrc"
        Me.txtSrc.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSrc.Size = New System.Drawing.Size(423, 202)
        Me.txtSrc.TabIndex = 1
        Me.txtSrc.WordWrap = False
        '
        'rbSrcText
        '
        Me.rbSrcText.AutoSize = True
        Me.rbSrcText.Checked = True
        Me.rbSrcText.Location = New System.Drawing.Point(3, 49)
        Me.rbSrcText.Name = "rbSrcText"
        Me.rbSrcText.Size = New System.Drawing.Size(46, 17)
        Me.rbSrcText.TabIndex = 2
        Me.rbSrcText.TabStop = True
        Me.rbSrcText.Text = "Text"
        Me.rbSrcText.UseVisualStyleBackColor = True
        '
        'rbSrcHtml
        '
        Me.rbSrcHtml.AutoSize = True
        Me.rbSrcHtml.Location = New System.Drawing.Point(3, 3)
        Me.rbSrcHtml.Name = "rbSrcHtml"
        Me.rbSrcHtml.Size = New System.Drawing.Size(55, 17)
        Me.rbSrcHtml.TabIndex = 3
        Me.rbSrcHtml.Text = "HTML"
        Me.rbSrcHtml.UseVisualStyleBackColor = True
        '
        'rbSrcRtf
        '
        Me.rbSrcRtf.AutoSize = True
        Me.rbSrcRtf.Location = New System.Drawing.Point(3, 26)
        Me.rbSrcRtf.Name = "rbSrcRtf"
        Me.rbSrcRtf.Size = New System.Drawing.Size(46, 17)
        Me.rbSrcRtf.TabIndex = 4
        Me.rbSrcRtf.Text = "RTF"
        Me.rbSrcRtf.UseVisualStyleBackColor = True
        '
        'pnlSrc
        '
        Me.pnlSrc.AutoSize = True
        Me.pnlSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSrc.Controls.Add(Me.rbSrcText)
        Me.pnlSrc.Controls.Add(Me.rbSrcRtf)
        Me.pnlSrc.Controls.Add(Me.rbSrcHtml)
        Me.pnlSrc.Location = New System.Drawing.Point(12, 29)
        Me.pnlSrc.Name = "pnlSrc"
        Me.pnlSrc.Size = New System.Drawing.Size(67, 76)
        Me.pnlSrc.TabIndex = 5
        '
        'txtTgt
        '
        Me.txtTgt.Location = New System.Drawing.Point(85, 280)
        Me.txtTgt.Multiline = True
        Me.txtTgt.Name = "txtTgt"
        Me.txtTgt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTgt.Size = New System.Drawing.Size(423, 202)
        Me.txtTgt.TabIndex = 6
        Me.txtTgt.WordWrap = False
        '
        'lblTgt
        '
        Me.lblTgt.AutoSize = True
        Me.lblTgt.Location = New System.Drawing.Point(9, 264)
        Me.lblTgt.Name = "lblTgt"
        Me.lblTgt.Size = New System.Drawing.Size(42, 13)
        Me.lblTgt.TabIndex = 7
        Me.lblTgt.Text = "Output:"
        '
        'pnlTgt
        '
        Me.pnlTgt.AutoSize = True
        Me.pnlTgt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTgt.Controls.Add(Me.rbTgtText)
        Me.pnlTgt.Controls.Add(Me.rbTgtRtf)
        Me.pnlTgt.Controls.Add(Me.rbTgtHtml)
        Me.pnlTgt.Location = New System.Drawing.Point(12, 280)
        Me.pnlTgt.Name = "pnlTgt"
        Me.pnlTgt.Size = New System.Drawing.Size(63, 71)
        Me.pnlTgt.TabIndex = 8
        '
        'rbTgtText
        '
        Me.rbTgtText.AutoSize = True
        Me.rbTgtText.Location = New System.Drawing.Point(3, 49)
        Me.rbTgtText.Name = "rbTgtText"
        Me.rbTgtText.Size = New System.Drawing.Size(46, 17)
        Me.rbTgtText.TabIndex = 2
        Me.rbTgtText.Text = "Text"
        Me.rbTgtText.UseVisualStyleBackColor = True
        '
        'rbTgtRtf
        '
        Me.rbTgtRtf.AutoSize = True
        Me.rbTgtRtf.Location = New System.Drawing.Point(3, 26)
        Me.rbTgtRtf.Name = "rbTgtRtf"
        Me.rbTgtRtf.Size = New System.Drawing.Size(46, 17)
        Me.rbTgtRtf.TabIndex = 4
        Me.rbTgtRtf.Text = "RTF"
        Me.rbTgtRtf.UseVisualStyleBackColor = True
        '
        'rbTgtHtml
        '
        Me.rbTgtHtml.AutoSize = True
        Me.rbTgtHtml.Checked = True
        Me.rbTgtHtml.Location = New System.Drawing.Point(3, 3)
        Me.rbTgtHtml.Name = "rbTgtHtml"
        Me.rbTgtHtml.Size = New System.Drawing.Size(55, 17)
        Me.rbTgtHtml.TabIndex = 3
        Me.rbTgtHtml.TabStop = True
        Me.rbTgtHtml.Text = "HTML"
        Me.rbTgtHtml.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.AutoSize = True
        Me.btnGo.Enabled = False
        Me.btnGo.Location = New System.Drawing.Point(548, 30)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 9
        Me.btnGo.Text = "Conver&t"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.AutoSize = True
        Me.btnAbout.Location = New System.Drawing.Point(548, 60)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSrcLoad
        '
        Me.btnSrcLoad.AutoSize = True
        Me.btnSrcLoad.Location = New System.Drawing.Point(422, 4)
        Me.btnSrcLoad.Name = "btnSrcLoad"
        Me.btnSrcLoad.Size = New System.Drawing.Size(86, 23)
        Me.btnSrcLoad.TabIndex = 11
        Me.btnSrcLoad.Text = "Load From File"
        Me.btnSrcLoad.UseVisualStyleBackColor = True
        '
        'btnTgtSave
        '
        Me.btnTgtSave.Enabled = False
        Me.btnTgtSave.Location = New System.Drawing.Point(422, 253)
        Me.btnTgtSave.Name = "btnTgtSave"
        Me.btnTgtSave.Size = New System.Drawing.Size(86, 23)
        Me.btnTgtSave.TabIndex = 12
        Me.btnTgtSave.Text = "Save To File"
        Me.btnTgtSave.UseVisualStyleBackColor = True
        '
        'LoadFileDialog
        '
        Me.LoadFileDialog.ReadOnlyChecked = True
        Me.LoadFileDialog.Title = "Please select the file to load:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 497)
        Me.Controls.Add(Me.btnTgtSave)
        Me.Controls.Add(Me.btnSrcLoad)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.pnlTgt)
        Me.Controls.Add(Me.lblTgt)
        Me.Controls.Add(Me.txtTgt)
        Me.Controls.Add(Me.pnlSrc)
        Me.Controls.Add(Me.txtSrc)
        Me.Controls.Add(Me.lblSource)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Format Converter"
        Me.pnlSrc.ResumeLayout(False)
        Me.pnlSrc.PerformLayout()
        Me.pnlTgt.ResumeLayout(False)
        Me.pnlTgt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSource As Label
    Friend WithEvents txtSrc As TextBox
    Friend WithEvents rbSrcText As RadioButton
    Friend WithEvents rbSrcHtml As RadioButton
    Friend WithEvents rbSrcRtf As RadioButton
    Friend WithEvents pnlSrc As Panel
    Friend WithEvents txtTgt As TextBox
    Friend WithEvents lblTgt As Label
    Friend WithEvents pnlTgt As Panel
    Friend WithEvents rbTgtText As RadioButton
    Friend WithEvents rbTgtRtf As RadioButton
    Friend WithEvents rbTgtHtml As RadioButton
    Friend WithEvents btnGo As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSrcLoad As Button
    Friend WithEvents btnTgtSave As Button
    Friend WithEvents LoadFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
End Class
