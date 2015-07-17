Imports System.Data.SqlClient

Public Class FrmForgotpassord
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim ContactNo As String


    Private Sub Forgotpassord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
    End Sub



 

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        str = ""
        str = "SELECT * FROM UserRegMaster "
        str = str & "WHERE (UserName = '" + txtUserName.Text + "' "
        str = str & "And ContactNo = '" + txtContactNo.Text + "'"
        str = str & "And SecurityQuestion = '" + txtSecurityQuestion.Text + "'"
        str = str & "And Answer = '" + txtAnswer.Text + "')"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds, "UserRegMaster")

        For Each rowTest In ds.Tables(0).Rows
            ContactNo = rowTest("ContactNo").ToString
        Next


        If ContactNo <> "" Then
            'Dim frm As New FrmFchangepassword
            'frm.ShowDialog()
            FrmFchangepassword.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please check user name and password.")
            txtAnswer.Text = ""
            txtAnswer.Focus()

        End If
    End Sub

    Private Sub txtContactNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactNo.LostFocus
        str = ""
        str = "SELECT SecurityQuestion FROM UserRegMaster where ContactNo=" + txtContactNo.Text.ToString
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            txtSecurityQuestion.Text = ds.Tables(0).Rows(0)("SecurityQuestion").ToString()
        End If
    End Sub

    
   
End Class