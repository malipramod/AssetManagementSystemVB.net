Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class FrmInstituteMaster
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim Var As String
    Private Sub FrmInstituteMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        str = ""
        str = "Insert into InstituteMaster(InstName,Address,Area,Description)values('" + txtInstituteName.Text + "','" + txtAddress.Text + "','" + txtArea.Text + "','" + txtDescription.Text + "')"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Insert Record Successfully", "InstituteMaster")
    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtInstituteName.Text = ""
        txtAddress.Text = ""
        txtArea.Text = ""
        txtDescription.Text = ""

    End Sub
End Class