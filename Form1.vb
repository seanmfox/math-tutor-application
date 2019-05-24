'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-22-19
'Program Name: Math Tutor Application
'Description: Chapter 2, Programming Challenge 2 - Create an application that, when a button is clicked, shows the answer to a math problem

Public Class Form1
    Private Sub BtnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblSolution.Text = "30"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub LblSolution_Click(sender As Object, e As EventArgs) Handles lblSolution.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
