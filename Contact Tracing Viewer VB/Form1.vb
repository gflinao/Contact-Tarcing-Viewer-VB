﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OFD.ShowDialog = DialogResult.OK) Then
            RTBox.Text = My.Computer.FileSystem.ReadAllText(OFD.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cfdialog As DialogResult
        cfdialog = MessageBox.Show("Do you want to clear all field?")
        RTBox.Clear()
    End Sub
End Class
