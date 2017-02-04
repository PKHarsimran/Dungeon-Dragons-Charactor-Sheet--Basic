Imports System
Imports System.IO

Public Class Form1
    Dim CharactorName As String
    Dim Age As String
    Dim TemplateUsed As String

    Dim BodyStat As String
    Dim MindStat As String
    Dim SoulStat As String

    Dim HealthPoint As String
    Dim EnergyPoint As String
    Dim ShockPoint As String

    Dim message, title, defaultValue As String
    Dim myValue As Object

    Dim FILE_NAME As String = "C:\Users\Harsimran\Documents\D&D.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CharactorName = TxtName.Text
        Age = TxtAge.Text
        TemplateUsed = TxtTemplates.Text

        BodyStat = TxtBodyStat.Text
        MindStat = TxtMindStat.Text
        SoulStat = TxtSoulStat.Text

        HealthPoint = TxtHealth.Text
        EnergyPoint = TxtEnergy.Text
        ShockPoint = TxtEnergy.Text

        Call Typer()

    End Sub

    Private Sub BtnAddSkill_Click(sender As Object, e As EventArgs) Handles BtnAddSkill.Click
        message = "Add Skills"
        title = "Skill Adding Box"

        myValue = MsgBox(message, title, myValue)

        TxtSkills.Text += myValue & vbCrLf
    End Sub

    Private Sub BtnAddDefec_Click(sender As Object, e As EventArgs) Handles BtnAddDefec.Click
        message = "Add Defects"
        title = "Defects Adding Box"

        myValue = MsgBox(message, title, myValue)

        TxtDefects.Text += myValue & vbCrLf
    End Sub

    Private Sub BtnRoll_Click(sender As Object, e As EventArgs) Handles BtnRoll.Click
        Dim roll As Integer
        Randomize()
        ' The program will generate a number from 0 to 50
        roll = Int(Rnd() * 20) + 1

        TxtRoll.Text = roll
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAddAttri.Click
        message = "Add Attribute"
        title = "Attribute Adding Box"

        myValue = MsgBox(message, title, myValue)

        TxtAttributes.Text += myValue & vbCrLf

    End Sub

    Function MsgBox(ByRef message As String, ByRef title As String, ByVal myValue As String)
        defaultValue = 1

        ' Display message, title, and default value.
        myValue = InputBox(message, title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue 
        If myValue Is "" Then
            myValue = defaultValue
        Else
            Return myValue

        End If
    End Function

    Sub Typer()


        If System.IO.File.Exists(FILE_NAME) = True Then

            'Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            Using objWriter As StreamWriter = File.AppendText(FILE_NAME)
                objWriter.WriteLine("Charactor Name : " & CharactorName & vbCrLf)
                objWriter.WriteLine("Age : " & Age & vbCrLf)
                objWriter.WriteLine("Template Used : " & TemplateUsed & vbCrLf)

                objWriter.WriteLine(vbCrLf)

                objWriter.WriteLine("Body Stat : " & BodyStat & "   ")
                objWriter.WriteLine("Mind Stat : " & MindStat & "   ")
                objWriter.WriteLine("Soul Stat : " & SoulStat & "   ")

                objWriter.WriteLine(vbCrLf)
                objWriter.WriteLine(vbCrLf)

                objWriter.WriteLine("Attributes" & vbCrLf)
                objWriter.WriteLine(TxtAttributes.Text)

                objWriter.WriteLine(vbCrLf)
                objWriter.WriteLine(vbCrLf)

                objWriter.WriteLine("Skills" & vbCrLf)
                objWriter.WriteLine(TxtSkills.Text)

                objWriter.WriteLine(vbCrLf)
                objWriter.WriteLine(vbCrLf)

                objWriter.WriteLine("Defects" & vbCrLf)
                objWriter.WriteLine(TxtDefects.Text)
            End Using

            MessageBox.Show("Text File Written")

        Else

            MessageBox.Show("File Does Not Exist")

        End If

    End Sub

End Class
