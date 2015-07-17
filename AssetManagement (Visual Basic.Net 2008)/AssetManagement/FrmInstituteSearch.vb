Imports System.Data.SqlClient
Public Class FrmInstituteSearch
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmStateMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.ConStr)
        con.Open()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtInstName.Text = "" Then
            MsgBox("Please Insert Institute Name", MsgBoxStyle.Critical, "Institute Name is Missing")
            txtInstName.Focus()
        Else
            testModule.rptID = 5
            testModule.item = txtInstName.Text
            Me.Hide()
            frmRPTViewer.Show()
        End If
    End Sub

    Private Sub btmClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmClear.Click
        txtInstName.Text = ""
    End Sub
End Class