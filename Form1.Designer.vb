<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TxtAttributes = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtSkills = New System.Windows.Forms.TextBox()
        Me.TxtDefects = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTemplates = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBodyStat = New System.Windows.Forms.TextBox()
        Me.TxtMindStat = New System.Windows.Forms.TextBox()
        Me.TxtSoulStat = New System.Windows.Forms.TextBox()
        Me.TxtAttackCombo = New System.Windows.Forms.TextBox()
        Me.TxtDefenseCombat = New System.Windows.Forms.TextBox()
        Me.TxtDamageMulti = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtHealth = New System.Windows.Forms.TextBox()
        Me.TxtEnergy = New System.Windows.Forms.TextBox()
        Me.TxtShock = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.BtnAddAttri = New System.Windows.Forms.Button()
        Me.BtnAddSkill = New System.Windows.Forms.Button()
        Me.BtnAddDefec = New System.Windows.Forms.Button()
        Me.BtnRoll = New System.Windows.Forms.Button()
        Me.TxtRoll = New System.Windows.Forms.TextBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtAttributes
        '
        Me.TxtAttributes.Location = New System.Drawing.Point(12, 209)
        Me.TxtAttributes.Multiline = True
        Me.TxtAttributes.Name = "TxtAttributes"
        Me.TxtAttributes.ReadOnly = True
        Me.TxtAttributes.Size = New System.Drawing.Size(383, 330)
        Me.TxtAttributes.TabIndex = 0
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(20, 31)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(105, 20)
        Me.TxtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Charactor Name"
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(164, 31)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(59, 20)
        Me.TxtAge.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Attributes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtSkills
        '
        Me.TxtSkills.Location = New System.Drawing.Point(417, 209)
        Me.TxtSkills.Multiline = True
        Me.TxtSkills.Name = "TxtSkills"
        Me.TxtSkills.ReadOnly = True
        Me.TxtSkills.Size = New System.Drawing.Size(383, 173)
        Me.TxtSkills.TabIndex = 7
        '
        'TxtDefects
        '
        Me.TxtDefects.Location = New System.Drawing.Point(417, 413)
        Me.TxtDefects.Multiline = True
        Me.TxtDefects.Name = "TxtDefects"
        Me.TxtDefects.ReadOnly = True
        Me.TxtDefects.Size = New System.Drawing.Size(383, 173)
        Me.TxtDefects.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Skills"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Defects"
        '
        'TxtTemplates
        '
        Me.TxtTemplates.Location = New System.Drawing.Point(559, 31)
        Me.TxtTemplates.Name = "TxtTemplates"
        Me.TxtTemplates.Size = New System.Drawing.Size(119, 20)
        Me.TxtTemplates.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(556, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Templates Used"
        '
        'TxtBodyStat
        '
        Me.TxtBodyStat.Location = New System.Drawing.Point(52, 95)
        Me.TxtBodyStat.Name = "TxtBodyStat"
        Me.TxtBodyStat.Size = New System.Drawing.Size(115, 20)
        Me.TxtBodyStat.TabIndex = 13
        '
        'TxtMindStat
        '
        Me.TxtMindStat.Location = New System.Drawing.Point(173, 95)
        Me.TxtMindStat.Name = "TxtMindStat"
        Me.TxtMindStat.Size = New System.Drawing.Size(115, 20)
        Me.TxtMindStat.TabIndex = 14
        '
        'TxtSoulStat
        '
        Me.TxtSoulStat.Location = New System.Drawing.Point(294, 95)
        Me.TxtSoulStat.Name = "TxtSoulStat"
        Me.TxtSoulStat.Size = New System.Drawing.Size(115, 20)
        Me.TxtSoulStat.TabIndex = 15
        '
        'TxtAttackCombo
        '
        Me.TxtAttackCombo.Location = New System.Drawing.Point(52, 153)
        Me.TxtAttackCombo.Name = "TxtAttackCombo"
        Me.TxtAttackCombo.Size = New System.Drawing.Size(115, 20)
        Me.TxtAttackCombo.TabIndex = 16
        '
        'TxtDefenseCombat
        '
        Me.TxtDefenseCombat.Location = New System.Drawing.Point(173, 153)
        Me.TxtDefenseCombat.Name = "TxtDefenseCombat"
        Me.TxtDefenseCombat.Size = New System.Drawing.Size(115, 20)
        Me.TxtDefenseCombat.TabIndex = 17
        '
        'TxtDamageMulti
        '
        Me.TxtDamageMulti.Location = New System.Drawing.Point(294, 153)
        Me.TxtDamageMulti.Name = "TxtDamageMulti"
        Me.TxtDamageMulti.Size = New System.Drawing.Size(115, 20)
        Me.TxtDamageMulti.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Body Stat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(205, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Mind Stat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Soul Stat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Attack combo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(186, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Defense combat "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(314, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Damage Multi"
        '
        'TxtHealth
        '
        Me.TxtHealth.Location = New System.Drawing.Point(476, 130)
        Me.TxtHealth.Name = "TxtHealth"
        Me.TxtHealth.Size = New System.Drawing.Size(98, 20)
        Me.TxtHealth.TabIndex = 25
        '
        'TxtEnergy
        '
        Me.TxtEnergy.Location = New System.Drawing.Point(590, 130)
        Me.TxtEnergy.Name = "TxtEnergy"
        Me.TxtEnergy.Size = New System.Drawing.Size(98, 20)
        Me.TxtEnergy.TabIndex = 26
        '
        'TxtShock
        '
        Me.TxtShock.Location = New System.Drawing.Point(702, 130)
        Me.TxtShock.Name = "TxtShock"
        Me.TxtShock.Size = New System.Drawing.Size(98, 20)
        Me.TxtShock.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(473, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Health points"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(587, 114)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(71, 13)
        Me.Label58.TabIndex = 29
        Me.Label58.Text = "Energy points"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(699, 114)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 13)
        Me.Label.TabIndex = 30
        Me.Label.Text = "Shock points"
        '
        'BtnAddAttri
        '
        Me.BtnAddAttri.Location = New System.Drawing.Point(419, 156)
        Me.BtnAddAttri.Name = "BtnAddAttri"
        Me.BtnAddAttri.Size = New System.Drawing.Size(165, 24)
        Me.BtnAddAttri.TabIndex = 31
        Me.BtnAddAttri.Text = "Add Attributes"
        Me.BtnAddAttri.UseVisualStyleBackColor = True
        '
        'BtnAddSkill
        '
        Me.BtnAddSkill.Location = New System.Drawing.Point(590, 156)
        Me.BtnAddSkill.Name = "BtnAddSkill"
        Me.BtnAddSkill.Size = New System.Drawing.Size(165, 24)
        Me.BtnAddSkill.TabIndex = 32
        Me.BtnAddSkill.Text = "Add Skills"
        Me.BtnAddSkill.UseVisualStyleBackColor = True
        '
        'BtnAddDefec
        '
        Me.BtnAddDefec.Location = New System.Drawing.Point(590, 182)
        Me.BtnAddDefec.Name = "BtnAddDefec"
        Me.BtnAddDefec.Size = New System.Drawing.Size(165, 24)
        Me.BtnAddDefec.TabIndex = 33
        Me.BtnAddDefec.Text = "Add Defects"
        Me.BtnAddDefec.UseVisualStyleBackColor = True
        '
        'BtnRoll
        '
        Me.BtnRoll.Location = New System.Drawing.Point(351, 12)
        Me.BtnRoll.Name = "BtnRoll"
        Me.BtnRoll.Size = New System.Drawing.Size(119, 36)
        Me.BtnRoll.TabIndex = 34
        Me.BtnRoll.Text = "Roll!!"
        Me.BtnRoll.UseVisualStyleBackColor = True
        '
        'TxtRoll
        '
        Me.TxtRoll.Location = New System.Drawing.Point(376, 54)
        Me.TxtRoll.Name = "TxtRoll"
        Me.TxtRoll.Size = New System.Drawing.Size(69, 20)
        Me.TxtRoll.TabIndex = 35
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(703, 16)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(97, 49)
        Me.BtnOpen.TabIndex = 36
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 598)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.TxtRoll)
        Me.Controls.Add(Me.BtnRoll)
        Me.Controls.Add(Me.BtnAddDefec)
        Me.Controls.Add(Me.BtnAddSkill)
        Me.Controls.Add(Me.BtnAddAttri)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtShock)
        Me.Controls.Add(Me.TxtEnergy)
        Me.Controls.Add(Me.TxtHealth)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDamageMulti)
        Me.Controls.Add(Me.TxtDefenseCombat)
        Me.Controls.Add(Me.TxtAttackCombo)
        Me.Controls.Add(Me.TxtSoulStat)
        Me.Controls.Add(Me.TxtMindStat)
        Me.Controls.Add(Me.TxtBodyStat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTemplates)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDefects)
        Me.Controls.Add(Me.TxtSkills)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtAttributes)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAttributes As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtSkills As TextBox
    Friend WithEvents TxtDefects As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTemplates As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBodyStat As TextBox
    Friend WithEvents TxtMindStat As TextBox
    Friend WithEvents TxtSoulStat As TextBox
    Friend WithEvents TxtAttackCombo As TextBox
    Friend WithEvents TxtDefenseCombat As TextBox
    Friend WithEvents TxtDamageMulti As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtHealth As TextBox
    Friend WithEvents TxtEnergy As TextBox
    Friend WithEvents TxtShock As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label As Label
    Friend WithEvents BtnAddAttri As Button
    Friend WithEvents BtnAddSkill As Button
    Friend WithEvents BtnAddDefec As Button
    Friend WithEvents BtnRoll As Button
    Friend WithEvents TxtRoll As TextBox
    Friend WithEvents BtnOpen As Button
End Class
