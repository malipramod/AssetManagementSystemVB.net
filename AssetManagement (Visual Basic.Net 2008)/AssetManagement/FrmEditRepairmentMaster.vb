Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmEditRepairmentMaster
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim Ammount As String

    Private Sub FrmEditRepairmentMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()


        If testModule.var.ToString() <> "" Then
            str = ""
            str = "select *from RepairmentRegisterMaster where AssetID=" + testModule.var.ToString()
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtAssetName.Text = ds.Tables(0).Rows(0)("AssetName").ToString()
                cmbInstituteName.SelectedItem = ds.Tables(0).Rows(0)("InstID").ToString()
                cmbDepartmentName.SelectedItem = ds.Tables(0).Rows(0)("DeptID").ToString()
                cmbAssetGroup.SelectedItem = ds.Tables(0).Rows(0)("AssetGroup").ToString()
                txtCompany.Text = ds.Tables(0).Rows(0)("Company").ToString()
                txtSupplierName.Text = ds.Tables(0).Rows(0)("SupplierName").ToString()
                txtAddress.Text = ds.Tables(0).Rows(0)("Address").ToString()
                txtCity.Text = ds.Tables(0).Rows(0)("City").ToString()
                DTPGivenDate.Value = ds.Tables(0).Rows(0)("GivenDate").ToString()
                DTPReceiveDate.Value = ds.Tables(0).Rows(0)("ReceiveDate").ToString()
                txtQuantity.Text = ds.Tables(0).Rows(0)("Qty").ToString()
                txtCostPerItem.Text = ds.Tables(0).Rows(0)("CostPerItem").ToString()
                txtTotalCost.Text = ds.Tables(0).Rows(0)("TotalCost").ToString()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtAssetName.Text.Equals("") Then
            MsgBox("Please Select the Asset Name", MsgBoxStyle.Critical, "Asset Name Not Selected")
            txtAssetName.Focus()
        ElseIf cmbInstituteName.SelectedIndex.Equals(-1) Then
            MsgBox("Please Select Institute Name", MsgBoxStyle.Critical, "Institute is Not Selected")
            cmbInstituteName.Focus()
        ElseIf cmbDepartmentName.SelectedIndex.Equals(-1) Then
            MsgBox("Please Select Department Name", MsgBoxStyle.Critical, "Department is Not Selected")
            cmbDepartmentName.Focus()
        ElseIf cmbAssetGroup.SelectedIndex.Equals(-1) Then
            MsgBox("Please Select Asset Group", MsgBoxStyle.Critical, "Asset Group is Not Selected")
            cmbAssetGroup.Focus()
        ElseIf txtSupplierName.Text = "" Then
            MsgBox("Please Fill the Supplier Name", MsgBoxStyle.Critical, "Supplier Name Missing")
            txtSupplierName.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please Fill the Address", MsgBoxStyle.Critical, "Address is Missing")
            txtAddress.Focus()
        ElseIf txtCity.Text = "" Then
            MsgBox("Please Fill the City", MsgBoxStyle.Critical, "City is Missing")
            txtCity.Focus()
        ElseIf txtCompany.Text = "" Then
            MsgBox("Please Fill the Company Name", MsgBoxStyle.Critical, "Company Name Missing")
            txtCompany.Focus()
        ElseIf txtQuantity.Text = "" Then
            MsgBox("Please Fill the Quantity", MsgBoxStyle.Critical, "Quantity Missing")
            txtQuantity.Focus()
        ElseIf txtCostPerItem.Text = "" Then
            MsgBox("Please Fill Cost Per Item", MsgBoxStyle.Critical, "Cost Per Item Missing")
            txtCostPerItem.Focus()
        Else
            str = ""
            str = "Update RepairmentRegisterMaster set AssetName='" + txtAssetName.Text + "',InstID='" + cmbInstituteName.SelectedItem + "',DeptID='" + cmbDepartmentName.SelectedItem + "',AssetGroup='" + cmbAssetGroup.SelectedItem + "',Company='" + txtCompany.Text + "',SupplierName='" + txtSupplierName.Text + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',GivenDate='" + DTPGivenDate.Value + "',ReceiveDate='" + DTPReceiveDate.Value + "',Qty='" + txtQuantity.Text + "',CostPerItem='" + txtCostPerItem.Text + "',TotalCost='" + txtTotalCost.Text + "' where AssetID=" + testModule.var.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "Repairment Register Master")
            FrmRepairmentMaster.ClearDetails()
            var = ""
            BindGrid()
            Me.Close()
        End If
    End Sub
    Sub BindGrid()        
        str = ""
        str = "Select *from RepairmentRegisterMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            FrmRepairmentGrid.DGRepairmentMaster.DataSource = ds.Tables(0)
        Else
            FrmRepairmentGrid.DGRepairmentMaster.DataSource = System.DBNull.Value.ToString()
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If testModule.var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Repairment Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from RepairmentRegisterMaster where AssetID= '" + testModule.var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Repairment Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmRepairmentGrid.BindGrid()
                var = ""
                Me.Close()
                FrmRepairmentGrid.Show()
            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Repairment Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                var = ""
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Repairment Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            var = ""
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


End Class