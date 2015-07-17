Imports System.Data.SqlClient

Public Class FrmEditInstituteMaster
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim id As String
    Private Sub FrmInstituteMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()


        BindCombo()
    End Sub
    Sub BindCombo()
        str = ""
        str = "Select * from InstituteMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)

        If (ds.Tables(0).Rows.Count > 0) Then
            cmbInstituteName.DataSource = ds.Tables(0)
            cmbInstituteName.DisplayMember = "InstName"
            cmbInstituteName.ValueMember = "InstID"


        Else
            cmbInstituteName.DataSource = System.DBNull.Value.ToString()
        End If

    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cmbInstituteName.SelectedIndex > -1 Then
            str = ""
            str = "Update InstituteMaster set InstName='" + txtInstituteName.Text + "',Area='" + txtArea.Text + "',Address='" + txtAddress.Text + "',Description='" + txtDescription.Text + "' where InstID = " + cmbInstituteName.SelectedValue.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "InstituteMaster")

        Else
            MessageBox.Show("Please Fill all the records")

        End If
    End Sub

    Private Sub cmbInstituteName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInstituteName.SelectedIndexChanged
        If (cmbInstituteName.SelectedIndex > 0) Then
            str = ""
            str = "Select * from InstituteMaster where InstID=" + cmbInstituteName.SelectedValue.ToString()
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If (ds.Tables(0).Rows.Count > 0) Then
                txtInstituteName.Text = ds.Tables(0).Rows(0)("InstName").ToString()
                txtArea.Text = ds.Tables(0).Rows(0)("Area").ToString()
                txtAddress.Text = ds.Tables(0).Rows(0)("Address").ToString()
                txtDescription.Text = ds.Tables(0).Rows(0)("Description").ToString()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If cmbInstituteName.SelectedIndex > -1 Then
            str = ""
            str = "Delete From InstituteMaster Where InstID=" + cmbInstituteName.SelectedValue.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            txtInstituteName.Text = ""
            txtArea.Text = ""
            txtAddress.Text = ""
            txtDescription.Text = ""
            MessageBox.Show("Delete Record Sucessfully", "Institute Master")

        Else
            MessageBox.Show("First Select Record", "Institute Master")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class