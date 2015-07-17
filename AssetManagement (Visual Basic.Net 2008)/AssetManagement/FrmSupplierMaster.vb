Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmSupplierMaster
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String

    Private Sub FrmSupplierMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()

    End Sub

    Sub ClearDetails()
        txtSupplierName.Text = ""
        txtCompany.Text = ""
        txtCompany.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        cmbGender.SelectedIndex = -1
        txtMobileNo.Text = ""
        txtEmailID.Text = ""
        txtLandlineNo.Text = ""
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtSupplierName.Text = "" Then
            MsgBox("Please Fill the Asset Name", MsgBoxStyle.Critical, "Asset Name Missing")
            txtSupplierName.Focus()
        ElseIf cmbGender.SelectedIndex.Equals(-1) Then
            MsgBox("Please Select the Gender", MsgBoxStyle.Critical, "Gender is not Selected")
            cmbGender.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please Fill the Address", MsgBoxStyle.Critical, "Address is Missing")
            txtAddress.Focus()
        ElseIf txtCity.Text = "" Then
            MsgBox("Please Fill the City", MsgBoxStyle.Critical, "City is Missing")
            txtCity.Focus()
        ElseIf txtCompany.Text = "" Then
            MsgBox("Please Fill the Company Name", MsgBoxStyle.Critical, "Company Name Missing")
            txtCompany.Focus()
        ElseIf txtMobileNo.Text = "" Then
            MsgBox("Please Fill the Mobile Number", MsgBoxStyle.Critical, "Mobile Number Missing")
            txtMobileNo.Focus()
        ElseIf txtLandlineNo.Text = "" Then
            MsgBox("Please Fill the Landline Number", MsgBoxStyle.Critical, "Landline Number Missing")
            txtLandlineNo.Focus()
        Else
            str = ""
            str = "Insert Into SupplierMaster(SupplierName,Gender,Address,City,MobileNo,LandlineNo,EmailID,Company) values('" + txtSupplierName.Text + "','" + cmbGender.SelectedItem + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtMobileNo.Text + "','" + txtLandlineNo.Text + "','" + txtEmailID.Text + "','" + txtCompany.Text + "')"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Inserted Successfully", "Supplier Register Master")
            ClearDetails()
            BindGrid()
        End If
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from SupplierMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            FrmSupplierGrid.DGSupplierMaster.DataSource = ds.Tables(0)
        Else
            FrmSupplierGrid.DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearDetails()
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress
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

    Private Sub txtMobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtLandlineNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLandlineNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtSupplierName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupplierName.KeyPress
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

    Private Sub txtEmailID_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmailID.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtEmailID.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txtEmailID.Clear()
        End If
    End Sub
End Class