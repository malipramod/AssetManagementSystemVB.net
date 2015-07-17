Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class FrmEditDepartmentMaster
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim id As String
    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbInstituteName.Text = ""
        txtDepartmentName.Text = ""
        txtHODName.Text = ""
        cmbInstituteName.Focus()

    End Sub
    Sub BindCombo()

        str = ""
        str = "Select * from DepartmentMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            cmbInstituteName.DataSource = ds.Tables(0)
            cmbInstituteName.DisplayMember = "InstName"
            cmbInstituteName.ValueMember = "InstID"
            cmbInstituteName.SelectedIndex = -1

            cmbDeptName.DataSource = ds.Tables(0)
            cmbDeptName.DisplayMember = "DeptName"
            cmbDeptName.ValueMember = "DeptID"
            cmbDeptName.SelectedIndex = -1
        Else
            cmbInstituteName.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub


    Private Sub FrmEditDepartmentMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=CC-PC\;Initial Catalog=AssetManagementSystem;Persist Security Info=True;User ID=sa;Password=rudh012")
        con.Open()
        BindCombo()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cmbDeptName.SelectedIndex > -1 Then
            str = ""
            str = "Update DepartmentMaster set DeptName='" + txtDepartmentName.Text + "',HODName='" + txtHODName.Text + "' where DeptID = " + cmbDeptName.SelectedValue.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "Department Master")

        Else
            MessageBox.Show("Please Fill all the records")

        End If
    End Sub

    Private Sub cmbDeptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeptName.SelectedIndexChanged

    End Sub

    Private Sub cmbInstituteName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInstituteName.SelectedIndexChanged
        If (cmbDeptName.SelectedIndex > 0) Then
            str = ""
            str = "Select * from DepartmentMaster where DeptID=" + cmbDeptName.SelectedValue.ToString()
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If (ds.Tables(0).Rows.Count > 0) Then
                txtDepartmentName.Text = ds.Tables(0).Rows(0)("DeptName").ToString()
                txtHODName.Text = ds.Tables(0).Rows(0)("HODName").ToString()

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (cmbDeptName.SelectedIndex > -1) Then
            str = ""
            str = "Delete From DepartmentMaster Where DeptID=" + cmbDeptName.SelectedValue.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            txtDepartmentName.Text = ""
            txtHODName.Text = ""
            MessageBox.Show("Delete Record Sucessfuly", "ContryMaster")

        Else
            MessageBox.Show("First Select Record", "ContryMaster")
        End If
    End Sub
End Class