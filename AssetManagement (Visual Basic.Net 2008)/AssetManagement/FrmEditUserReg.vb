Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmEditUserReg
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub


    Private Sub FrmUserReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        str = ""
        str = "Select * from UserRegMaster where RegID =" + testModule.rid.ToString()
        ds = New DataSet()
        da = New SqlDataAdapter(str, con)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            txtUserName.Text = ds.Tables(0).Rows(0)("UserName").ToString()
            txtFirstName.Text = ds.Tables(0).Rows(0)("FirstName").ToString()
            txtMiddlename.Text = ds.Tables(0).Rows(0)("MiddleName").ToString()
            txtLastName.Text = ds.Tables(0).Rows(0)("LastName").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0)("Address").ToString()
            cmbUserType.SelectedItem = ds.Tables(0).Rows(0)("UserType").ToString()
            txtContactNo.Text = ds.Tables(0).Rows(0)("ContactNo").ToString()
            txtPassword.Text = ds.Tables(0).Rows(0)("Password").ToString()
            txtSecurtyQuestion.Text = ds.Tables(0).Rows(0)("SecurityQue").ToString()
            txtAnswer.Text = ds.Tables(0).Rows(0)("Answer").ToString()
        End If

    End Sub

    Private Sub btnMiniMize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

 
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        str = ""
        str = "Update UserRegMaster set UserName='" + txtUserName.Text + "',FirstName='" + txtFirstName.Text + "',MiddleName='" + txtMiddlename.Text + "',LastName='" + txtLastName.Text + "',Address='" + txtAddress.Text + "',UserType='" + cmbUserType.SelectedItem + "',ContactNo='" + txtContactNo.Text + "',Password='" + txtPassword.Text + "',SecurityQuestion='" + txtSecurtyQuestion.Text + "',Answer='" + txtAnswer.Text + "' where RegID=" + testModule.rid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Updated Successfully", "User Registration Master")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        str = ""
        str = "Delete From UserRegMaster Where UserID=" + Me.txtUserName.Text()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        txtUserName.Text = ""
        txtFirstName.Text = ""
        txtMiddlename.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
        txtSecurtyQuestion.Text = ""
        txtPassword.Text = ""
        txtAnswer.Text = ""
        cmbUserType.SelectedItem = ""
        MessageBox.Show("Delete Record Sucessfully", "User Registration Master")
    End Sub

    Private Sub txtContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtMiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddlename.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtLastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class