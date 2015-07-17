Imports System.Data.SqlClient
Public Class frmSupplier
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtName.Text.Equals("") Then
            MsgBox("Please Provide Text in the TextBox", MsgBoxStyle.Critical, "Text is Missing")
            txtName.Focus()
        Else
            testModule.rptID = 1
            testModule.item = txtName.Text
            Me.Hide()
            frmRPTViewer.Show()
        End If
    End Sub

End Class