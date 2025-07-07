﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.InputFileMessage = New System.Windows.Forms.Label()
        Me.InputFileTxt = New System.Windows.Forms.TextBox()
        Me.OutputFileMessage = New System.Windows.Forms.Label()
        Me.OutputFileTxt = New System.Windows.Forms.TextBox()
        Me.ActionGroupBox = New System.Windows.Forms.GroupBox()
        Me.PreprocessRButton = New System.Windows.Forms.RadioButton()
        Me.ExtractRButton = New System.Windows.Forms.RadioButton()
        Me.CompressRButton = New System.Windows.Forms.RadioButton()
        Me.cmixVersionToUseLabel = New System.Windows.Forms.Label()
        Me.cmixVersionDropdown = New System.Windows.Forms.ComboBox()
        Me.BrowseButton1 = New System.Windows.Forms.Button()
        Me.BrowseButton2 = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AboutLabel1 = New System.Windows.Forms.Label()
        Me.AboutLabel2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.BrowseFolder = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.UseEngDictCheckbox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SpanishRButton = New System.Windows.Forms.RadioButton()
        Me.EnglishRButton = New System.Windows.Forms.RadioButton()
        Me.ProgressLog = New System.Windows.Forms.RichTextBox()
        Me.SaveLogButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearLogButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TotalRAM = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AvailableRAM = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UsedRAM = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RAMBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ShowCMD = New System.Windows.Forms.CheckBox()
        Me.ActionGroupBox.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'InputFileMessage
        '
        Me.InputFileMessage.AutoSize = true
        Me.InputFileMessage.Location = New System.Drawing.Point(9, 70)
        Me.InputFileMessage.Name = "InputFileMessage"
        Me.InputFileMessage.Size = New System.Drawing.Size(223, 13)
        Me.InputFileMessage.TabIndex = 0
        Me.InputFileMessage.Text = "Step 1: Browse for a file or folder to compress:"
        '
        'InputFileTxt
        '
        Me.InputFileTxt.Location = New System.Drawing.Point(12, 86)
        Me.InputFileTxt.Name = "InputFileTxt"
        Me.InputFileTxt.Size = New System.Drawing.Size(237, 20)
        Me.InputFileTxt.TabIndex = 3
        '
        'OutputFileMessage
        '
        Me.OutputFileMessage.AutoSize = true
        Me.OutputFileMessage.Location = New System.Drawing.Point(9, 109)
        Me.OutputFileMessage.Name = "OutputFileMessage"
        Me.OutputFileMessage.Size = New System.Drawing.Size(240, 13)
        Me.OutputFileMessage.TabIndex = 2
        Me.OutputFileMessage.Text = "Step 2: Browse for a location to save the archive:"
        '
        'OutputFileTxt
        '
        Me.OutputFileTxt.Location = New System.Drawing.Point(12, 125)
        Me.OutputFileTxt.Name = "OutputFileTxt"
        Me.OutputFileTxt.Size = New System.Drawing.Size(237, 20)
        Me.OutputFileTxt.TabIndex = 6
        '
        'ActionGroupBox
        '
        Me.ActionGroupBox.Controls.Add(Me.PreprocessRButton)
        Me.ActionGroupBox.Controls.Add(Me.ExtractRButton)
        Me.ActionGroupBox.Controls.Add(Me.CompressRButton)
        Me.ActionGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ActionGroupBox.Name = "ActionGroupBox"
        Me.ActionGroupBox.Size = New System.Drawing.Size(276, 46)
        Me.ActionGroupBox.TabIndex = 4
        Me.ActionGroupBox.TabStop = false
        Me.ActionGroupBox.Text = "I want to:"
        '
        'PreprocessRButton
        '
        Me.PreprocessRButton.AutoSize = true
        Me.PreprocessRButton.Location = New System.Drawing.Point(83, 19)
        Me.PreprocessRButton.Name = "PreprocessRButton"
        Me.PreprocessRButton.Size = New System.Drawing.Size(116, 17)
        Me.PreprocessRButton.TabIndex = 1
        Me.PreprocessRButton.TabStop = true
        Me.PreprocessRButton.Text = "Only Preprocessing"
        Me.PreprocessRButton.UseVisualStyleBackColor = true
        '
        'ExtractRButton
        '
        Me.ExtractRButton.AutoSize = true
        Me.ExtractRButton.Location = New System.Drawing.Point(205, 19)
        Me.ExtractRButton.Name = "ExtractRButton"
        Me.ExtractRButton.Size = New System.Drawing.Size(58, 17)
        Me.ExtractRButton.TabIndex = 2
        Me.ExtractRButton.TabStop = true
        Me.ExtractRButton.Text = "Extract"
        Me.ExtractRButton.UseVisualStyleBackColor = true
        '
        'CompressRButton
        '
        Me.CompressRButton.AutoSize = true
        Me.CompressRButton.Location = New System.Drawing.Point(6, 19)
        Me.CompressRButton.Name = "CompressRButton"
        Me.CompressRButton.Size = New System.Drawing.Size(71, 17)
        Me.CompressRButton.TabIndex = 0
        Me.CompressRButton.TabStop = true
        Me.CompressRButton.Text = "Compress"
        Me.CompressRButton.UseVisualStyleBackColor = true
        '
        'cmixVersionToUseLabel
        '
        Me.cmixVersionToUseLabel.AutoSize = true
        Me.cmixVersionToUseLabel.Location = New System.Drawing.Point(9, 148)
        Me.cmixVersionToUseLabel.Name = "cmixVersionToUseLabel"
        Me.cmixVersionToUseLabel.Size = New System.Drawing.Size(100, 13)
        Me.cmixVersionToUseLabel.TabIndex = 5
        Me.cmixVersionToUseLabel.Text = "cmix version to use:"
        '
        'cmixVersionDropdown
        '
        Me.cmixVersionDropdown.FormattingEnabled = true
        Me.cmixVersionDropdown.Location = New System.Drawing.Point(12, 164)
        Me.cmixVersionDropdown.Name = "cmixVersionDropdown"
        Me.cmixVersionDropdown.Size = New System.Drawing.Size(121, 21)
        Me.cmixVersionDropdown.TabIndex = 8
        '
        'BrowseButton1
        '
        Me.BrowseButton1.Location = New System.Drawing.Point(255, 84)
        Me.BrowseButton1.Name = "BrowseButton1"
        Me.BrowseButton1.Size = New System.Drawing.Size(96, 23)
        Me.BrowseButton1.TabIndex = 4
        Me.BrowseButton1.Text = "Browse File"
        Me.BrowseButton1.UseVisualStyleBackColor = true
        '
        'BrowseButton2
        '
        Me.BrowseButton2.Location = New System.Drawing.Point(255, 123)
        Me.BrowseButton2.Name = "BrowseButton2"
        Me.BrowseButton2.Size = New System.Drawing.Size(96, 23)
        Me.BrowseButton2.TabIndex = 7
        Me.BrowseButton2.Text = "Browse"
        Me.BrowseButton2.UseVisualStyleBackColor = true
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StartButton.Location = New System.Drawing.Point(183, 151)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(263, 57)
        Me.StartButton.TabIndex = 10
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AboutLabel1
        '
        Me.AboutLabel1.AutoSize = True
        Me.AboutLabel1.Location = New System.Drawing.Point(9, 234)
        Me.AboutLabel1.Name = "AboutLabel1"
        Me.AboutLabel1.Size = New System.Drawing.Size(353, 13)
        Me.AboutLabel1.TabIndex = 10
        Me.AboutLabel1.Text = "GUI software by: Moisés Cardona, and updated by mn7216 and xyzzy121"
        '
        'AboutLabel2
        '
        Me.AboutLabel2.AutoSize = True
        Me.AboutLabel2.Location = New System.Drawing.Point(9, 249)
        Me.AboutLabel2.Name = "AboutLabel2"
        Me.AboutLabel2.Size = New System.Drawing.Size(101, 13)
        Me.AboutLabel2.TabIndex = 11
        Me.AboutLabel2.Text = "cmix by: Byron Knoll"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "cmix GitHub Repo:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(111, 263)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(174, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/byronknoll/cmix"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(396, 251)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(56, 13)
        Me.VersionLabel.TabIndex = 14
        Me.VersionLabel.Text = "GUI v1.11"
        '
        'BrowseFolder
        '
        Me.BrowseFolder.Location = New System.Drawing.Point(357, 84)
        Me.BrowseFolder.Name = "BrowseFolder"
        Me.BrowseFolder.Size = New System.Drawing.Size(89, 23)
        Me.BrowseFolder.TabIndex = 5
        Me.BrowseFolder.Text = "Browse Folder"
        Me.BrowseFolder.UseVisualStyleBackColor = True
        '
        'UseEngDictCheckbox
        '
        Me.UseEngDictCheckbox.AutoSize = True
        Me.UseEngDictCheckbox.Location = New System.Drawing.Point(12, 192)
        Me.UseEngDictCheckbox.Name = "UseEngDictCheckbox"
        Me.UseEngDictCheckbox.Size = New System.Drawing.Size(148, 17)
        Me.UseEngDictCheckbox.TabIndex = 9
        Me.UseEngDictCheckbox.Text = "Use the English dictionary"
        Me.UseEngDictCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SpanishRButton)
        Me.GroupBox2.Controls.Add(Me.EnglishRButton)
        Me.GroupBox2.Location = New System.Drawing.Point(311, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 46)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Language / Idioma"
        '
        'SpanishRButton
        '
        Me.SpanishRButton.AutoSize = True
        Me.SpanishRButton.Location = New System.Drawing.Point(70, 19)
        Me.SpanishRButton.Name = "SpanishRButton"
        Me.SpanishRButton.Size = New System.Drawing.Size(63, 17)
        Me.SpanishRButton.TabIndex = 4
        Me.SpanishRButton.TabStop = True
        Me.SpanishRButton.Text = "Español"
        Me.SpanishRButton.UseVisualStyleBackColor = True
        '
        'EnglishRButton
        '
        Me.EnglishRButton.AutoSize = True
        Me.EnglishRButton.Location = New System.Drawing.Point(6, 19)
        Me.EnglishRButton.Name = "EnglishRButton"
        Me.EnglishRButton.Size = New System.Drawing.Size(59, 17)
        Me.EnglishRButton.TabIndex = 3
        Me.EnglishRButton.TabStop = True
        Me.EnglishRButton.Text = "English"
        Me.EnglishRButton.UseVisualStyleBackColor = True
        '
        'ProgressLog
        '
        Me.ProgressLog.BackColor = System.Drawing.Color.White
        Me.ProgressLog.Location = New System.Drawing.Point(475, 25)
        Me.ProgressLog.Name = "ProgressLog"
        Me.ProgressLog.ReadOnly = True
        Me.ProgressLog.Size = New System.Drawing.Size(406, 213)
        Me.ProgressLog.TabIndex = 16
        Me.ProgressLog.Text = ""
        '
        'SaveLogButton
        '
        Me.SaveLogButton.Location = New System.Drawing.Point(475, 244)
        Me.SaveLogButton.Name = "SaveLogButton"
        Me.SaveLogButton.Size = New System.Drawing.Size(310, 23)
        Me.SaveLogButton.TabIndex = 17
        Me.SaveLogButton.Text = "Save Log"
        Me.SaveLogButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Log:"
        '
        'ClearLogButton
        '
        Me.ClearLogButton.Location = New System.Drawing.Point(791, 244)
        Me.ClearLogButton.Name = "ClearLogButton"
        Me.ClearLogButton.Size = New System.Drawing.Size(90, 23)
        Me.ClearLogButton.TabIndex = 19
        Me.ClearLogButton.Text = "Clear Log"
        Me.ClearLogButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalRAM, Me.AvailableRAM, Me.UsedRAM, Me.RAMBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 276)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(893, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TotalRAM
        '
        Me.TotalRAM.Name = "TotalRAM"
        Me.TotalRAM.Size = New System.Drawing.Size(101, 17)
        Me.TotalRAM.Text = "Total RAM: 0.0 GB"
        '
        'AvailableRAM
        '
        Me.AvailableRAM.Name = "AvailableRAM"
        Me.AvailableRAM.Size = New System.Drawing.Size(123, 17)
        Me.AvailableRAM.Text = "Available RAM: 0.0 GB"
        '
        'UsedRAM
        '
        Me.UsedRAM.Name = "UsedRAM"
        Me.UsedRAM.Size = New System.Drawing.Size(98, 17)
        Me.UsedRAM.Text = "Used RAM: 0.0GB"
        '
        'RAMBar
        '
        Me.RAMBar.Name = "RAMBar"
        Me.RAMBar.Size = New System.Drawing.Size(100, 16)
        '
        'ShowCMD
        '
        Me.ShowCMD.AutoSize = true
        Me.ShowCMD.Location = New System.Drawing.Point(183, 214)
        Me.ShowCMD.Name = "ShowCMD"
        Me.ShowCMD.Size = New System.Drawing.Size(80, 17)
        Me.ShowCMD.TabIndex = 22
        Me.ShowCMD.Text = "Show CMD"
        Me.ShowCMD.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AllowDrop = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 298)
        Me.Controls.Add(Me.ShowCMD)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ClearLogButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveLogButton)
        Me.Controls.Add(Me.ProgressLog)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.UseEngDictCheckbox)
        Me.Controls.Add(Me.BrowseFolder)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AboutLabel2)
        Me.Controls.Add(Me.AboutLabel1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.BrowseButton2)
        Me.Controls.Add(Me.BrowseButton1)
        Me.Controls.Add(Me.cmixVersionDropdown)
        Me.Controls.Add(Me.cmixVersionToUseLabel)
        Me.Controls.Add(Me.ActionGroupBox)
        Me.Controls.Add(Me.OutputFileTxt)
        Me.Controls.Add(Me.OutputFileMessage)
        Me.Controls.Add(Me.InputFileTxt)
        Me.Controls.Add(Me.InputFileMessage)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "cmix Graphical User Interface"
        Me.ActionGroupBox.ResumeLayout(false)
        Me.ActionGroupBox.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents InputFileMessage As Label
    Friend WithEvents InputFileTxt As TextBox
    Friend WithEvents OutputFileMessage As Label
    Friend WithEvents OutputFileTxt As TextBox
    Friend WithEvents ActionGroupBox As GroupBox
    Friend WithEvents ExtractRButton As RadioButton
    Friend WithEvents CompressRButton As RadioButton
    Friend WithEvents cmixVersionToUseLabel As Label
    Friend WithEvents cmixVersionDropdown As ComboBox
    Friend WithEvents BrowseButton1 As Button
    Friend WithEvents BrowseButton2 As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AboutLabel1 As Label
    Friend WithEvents AboutLabel2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents VersionLabel As Label
    Friend WithEvents BrowseFolder As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents UseEngDictCheckbox As CheckBox
    Friend WithEvents PreprocessRButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SpanishRButton As RadioButton
    Friend WithEvents EnglishRButton As RadioButton
    Friend WithEvents ProgressLog As RichTextBox
    Friend WithEvents SaveLogButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearLogButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TotalRAM As ToolStripStatusLabel
    Friend WithEvents AvailableRAM As ToolStripStatusLabel
    Friend WithEvents UsedRAM As ToolStripStatusLabel
    Friend WithEvents RAMBar As ToolStripProgressBar
    Friend WithEvents ShowCMD As CheckBox
End Class
