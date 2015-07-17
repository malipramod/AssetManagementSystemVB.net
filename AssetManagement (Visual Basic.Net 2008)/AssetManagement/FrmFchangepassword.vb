Imports System.Data.SqlClient
Public Class FrmFchangepassword
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        str = ""
        str = "Update UserRegMaster set Password = '" + txtConfirmPass.Text + "' where RegID= " + testModule.rid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Password Changed Successfully", "Change Password")


        'Dim frm As New FrmLoginForm
        'frm.ShowDialog()
        FrmLoginForm.Show()

        Me.Hide()


    End Sub

    Private Sub FrmFchangepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)

        con.Open()
    End Sub

    Private Sub txtConfirmPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmPass.LostFocus
        If (txtNewPass.Text <> txtConfirmPass.Text) Then
            MessageBox.Show("Password does not match", "Change Password")
            txtNewPass.Text = ""
            txtConfirmPass.Text = ""
            txtConfirmPass.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class