Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmEditSaleMaster
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim Ammount As String

    Private Sub FrmEditSaleMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        If testModule.var.ToString() <> "" Then
            str = ""
            str = "select *from SaleMaster where AssetID=" + testModule.var.ToString()
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtAssetName.Text = ds.Tables(0).Rows(0)("AssetName").ToString()
                cmbAssetGroup.SelectedItem = ds.Tables(0).Rows(0)("AssetGroup").ToString()
                txtCompany.Text = ds.Tables(0).Rows(0)("Company").ToString()
                DTPSaleDate.Value = ds.Tables(0).Rows(0)("SaleDate").ToString()
                txtQuantity.Text = ds.Tables(0).Rows(0)("Qty").ToString()
                txtCostPerItem.Text = ds.Tables(0).Rows(0)("CostPerItem").ToString()
                txtTotalCost.Text = ds.Tables(0).Rows(0)("TotalCost").ToString()
                txtBuyerName.Text = ds.Tables(0).Rows(0)("BuyerName").ToString()
                cmbGender.SelectedItem = ds.Tables(0).Rows(0)("Gender").ToString()
                txtAddress.Text = ds.Tables(0).Rows(0)("Address").ToString()
                txtCity.Text = ds.Tables(0).Rows(0)("City").ToString()
                txtMobileNo.Text = ds.Tables(0).Rows(0)("MobileNo").ToString()
                txtEmailID.Text = ds.Tables(0).Rows(0)("EmailID").ToString()
                txtLandlineNo.Text = ds.Tables(0).Rows(0)("LandlineNo").ToString()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtAssetName.Text = "" Then
            MsgBox("Please Fill the Asset Name", MsgBoxStyle.Critical, "Asset Name Missing")
            txtAssetName.Focus()
        ElseIf cmbAssetGroup.SelectedIndex.Equals(-1) Then
            MsgBox("Please Select Asset Group", MsgBoxStyle.Critical, "Asset Group is Not Selected")
            cmbAssetGroup.Focus()
        ElseIf txtCompany.Text = "" Then
            MsgBox("Please Fill the Company Name", MsgBoxStyle.Critical, "Company Name Missing")
            txtCompany.Focus()      
        ElseIf txtCostPerItem.Text = "" Then
            MsgBox("Please Fill the Cost per Item", MsgBoxStyle.Critical, "Cost Per Item Missing")
            txtCostPerItem.Focus()
        ElseIf txtBuyerName.Text = "" Then
            MsgBox("Please Fill Buyer's Name", MsgBoxStyle.Critical, "Buyer Name Missing")
            txtBuyerName.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please Fill the Address", MsgBoxStyle.Critical, "Address is Missing")
            txtAddress.Focus()
        ElseIf txtCity.Text = "" Then
            MsgBox("Please Fill the City", MsgBoxStyle.Critical, "City is Missing")
            txtCity.Focus()
        ElseIf txtMobileNo.Text = "" Then
            MsgBox("Please Fill the Mobile Number", MsgBoxStyle.Critical, "Mobile Number Missing")
            txtMobileNo.Focus()
        ElseIf cmbGender.SelectedIndex.Equals(-1) Then
            MsgBox("Please Select the Gender", MsgBoxStyle.Critical, "Gender is not Selected")
            cmbGender.Focus()
        Else
            str = ""
            str = "Update SaleMaster set AssetName='" + txtAssetName.Text + "',AssetGroup='" + cmbAssetGroup.SelectedItem + "',Company='" + txtCompany.Text + "',SaleDate='" + DTPSaleDate.Value + "',Qty='" + txtQuantity.Text + "',CostPerItem='" + txtCostPerItem.Text + "',TotalCost='" + txtTotalCost.Text + "',BuyerName='" + txtBuyerName.Text + "',Gender='" + cmbGender.SelectedItem + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',MobileNo='" + txtMobileNo.Text + "',LandlineNo='" + txtLandlineNo.Text + "',EmailID='" + txtEmailID.Text + "' where AssetID=" + testModule.var.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "Sales Master")
            FrmSaleMaster.ClearDetails()
            var = ""
            BindGrid()
            Me.Close()
        End If
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from SaleMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            FrmSaleGrid.DGSalesMaster.DataSource = ds.Tables(0)
        Else
            FrmSaleGrid.DGSalesMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If testModule.var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Sales Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from SaleMaster where AssetID= '" + testModule.var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Sale Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()
                var = ""
                Me.Close()
                FrmSaleGrid.Show()
            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Sale Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                var = ""
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Sale Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            var = ""
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        Ammount = 0
        Ammount = Val(txtCostPerItem.Text) * Val(txtQuantity.Text)
        txtTotalCost.Text = Ammount
    End Sub

    Private Sub txtCostPerItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostPerItem.TextChanged
        Ammount = 0
        Ammount = Val(txtCostPerItem.Text) * Val(txtQuantity.Text)
        txtTotalCost.Text = Ammount
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False

        End If
    End Sub

    Private Sub txtCostPerItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostPerItem.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
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

    Private Sub txtBuyerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuyerName.KeyPress
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

    Private Sub txtEmailID_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmailID.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtEmailID.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txtEmailID.Clear()
        End If
    End Sub

    Private Sub txtAssetName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAssetName.KeyPress
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