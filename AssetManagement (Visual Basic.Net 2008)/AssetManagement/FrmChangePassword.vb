Imports System.Data.SqlClient
Public Class FrmChangePassword
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String
    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtConfirmPass.Text = ""
        txtCurrentPass.Text = ""
        txtNewPass.Text = ""
        txtCurrentPass.Focus()

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        str = ""
        str = "Update UserRegMaster set Password = '" + txtConfirmPass.Text + "' where RegID= " + testModule.rid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Password Changed Successfully", "Change Password")
        Me.Close()
    End Sub

    Private Sub txtConfirmPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmPass.LostFocus
        If (txtNewPass.Text <> txtConfirmPass.Text) Then
            MessageBox.Show("Password does not match", "Change Password")
            txtCurrentPass.Text = ""
            txtNewPass.Text = ""
            txtCurrentPass.Focus()
        End If
    End Sub

End Class
