Imports System.Data.SqlClient
Public Class FrmSales
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtDeptName.Text = "" Then
            MsgBox("Please Insert Asset Name which sold", MsgBoxStyle.Critical, "Asset Name is Missing")
            txtDeptName.Focus()
        Else
            testModule.rptID = 2
            testModule.item = txtDeptName.Text
            Me.Hide()
            frmRPTViewer.Show()
        End If
    End Sub

    Private Sub btmClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmClear.Click
        txtDeptName.Text = ""
    End Sub

    Private Sub txtStateName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptName.TextChanged

    End Sub
End Class