Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmEditPurchasereturn
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim Ammount As String
    Dim ClosingBalance As String


    Private Sub FrmEditPurchasereturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        txtClosingBalance.Enabled = False
        txtTotalCost.Enabled = False

        If testModule.var.ToString() <> "" Then
            str = ""
            str = "select *from PurchaseReturnMaster where AssetID=" + testModule.var.ToString()
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
                DTPReturn.Value = ds.Tables(0).Rows(0)("ReturnDate").ToString()
                txtQuantity.Text = ds.Tables(0).Rows(0)("Qty").ToString()
                txtCostPerItem.Text = ds.Tables(0).Rows(0)("CostPerItem").ToString()
                txtTotalCost.Text = ds.Tables(0).Rows(0)("TotalCost").ToString()
                txtReturnItem.Text = ds.Tables(0).Rows(0)("ReturnItem").ToString()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FrmAssetManagement.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtReturnItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReturnItem.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False

        End If
    End Sub

    Private Sub txtReturnItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnItem.TextChanged
        ClosingBalance = Ammount - (Val(txtCostPerItem.Text) * Val(txtReturnItem.Text))
        txtClosingBalance.Text = ClosingBalance
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        Ammount = 0
        Ammount = Val(txtCostPerItem.Text) * Val(txtQuantity.Text)
        txtTotalCost.Text = Ammount
        txtClosingBalance.Text = Ammount
        ClosingBalance = Ammount - (Val(txtCostPerItem.Text) * Val(txtReturnItem.Text))
        txtClosingBalance.Text = ClosingBalance
    End Sub

    Private Sub txtCostPerItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostPerItem.TextChanged
        Ammount = 0
        Ammount = Val(txtCostPerItem.Text) * Val(txtQuantity.Text)
        txtTotalCost.Text = Ammount
        txtClosingBalance.Text = Ammount
        ClosingBalance = Ammount - (Val(txtCostPerItem.Text) * Val(txtReturnItem.Text))
        txtClosingBalance.Text = ClosingBalance
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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
            str = "Update PurchaseReturnMaster set AssetName='" + txtAssetName.Text + "',InstID='" + cmbInstituteName.SelectedItem + "',DeptID='" + cmbDepartmentName.SelectedItem + "',AssetGroup='" + cmbAssetGroup.SelectedItem + "',SupplierName='" + txtSupplierName.Text + "',ReturnDate='" + DTPReturn.Value + "',Qty='" + txtQuantity.Text + "',CostPerItem='" + txtCostPerItem.Text + "',TotalCost='" + txtTotalCost.Text + "',ReturnItem='" + txtReturnItem.Text + "',ClosingBalance='" + txtClosingBalance.Text + "' where AssetID=" + testModule.var.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "Purchase Return Master")
            FrmPurchasereturnMaster.ClearDetails()
            BindGrid()
            Me.Close()
            FrmPurchaseReturnGrid.Show()
            var = ""
        End If
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from PurchaseReturnMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            FrmPurchaseReturnGrid.DGPurchaseReturn.DataSource = ds.Tables(0)
        Else
            FrmPurchaseReturnGrid.DGPurchaseReturn.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If testModule.var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Purchase Return Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from PurchaseReturnMaster where AssetID= '" + testModule.var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Purchase Return", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()
                var = ""
                Me.Close()
                FrmPurchaseReturnGrid.Show()
            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Purchase Return Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                var = ""
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Purchase Ruturn Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            var = ""
        End If
    End Sub

    Private Sub txtAssetName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAssetName.KeyPress
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

  
End Class