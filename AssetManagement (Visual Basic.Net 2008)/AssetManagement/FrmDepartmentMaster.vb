Imports System.Data.SqlClient
Public Class FrmDepartmentMaster
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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbInstituteName.Text = ""
        txtDepartmentName.Text = ""
        txtHODName.Text = ""
        cmbInstituteName.Focus()

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
            cmbInstituteName.SelectedIndex = -1
        Else
            cmbInstituteName.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        str = ""
        str = "Insert into DepartmentMaster(InstID,DeptName,HODName)values(" + cmbInstituteName.SelectedValue.ToString() + ",'" + txtDepartmentName.Text + "','" + txtHODName.Text + "')"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Insert Record Successfully", "DepartmentMaster")
        cmbInstituteName.SelectedIndex = -1



    End Sub

    Private Sub FrmDepartmentMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.ConStr)
        con.Open()
        BindCombo()
    End Sub

    Private Sub txtHODName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHODName.KeyPress
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