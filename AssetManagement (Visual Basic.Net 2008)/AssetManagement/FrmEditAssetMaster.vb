Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmEditAssetMaster
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim Ammount As String

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FrmAssetManagement.Show()
        Me.Close()
    End Sub

    Private Sub FrmEditAssetMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        txtTotalAmmount.Enabled = False

        If testModule.var.ToString() <> "" Then
            str = ""
            str = "select *from AssetMaster where AssetID=" + testModule.var.ToString()
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtAssetName.Text = ds.Tables(0).Rows(0)("AssetName").ToString()
                cmbInstituteName.Text = ds.Tables(0).Rows(0)("InstID").ToString()
                cmbDepartmentName.Text = ds.Tables(0).Rows(0)("DeptID").ToString()
                cmbAssetGroup.SelectedItem = ds.Tables(0).Rows(0)("AssetGroup").ToString()
                txtCompany.Text = ds.Tables(0).Rows(0)("Company").ToString()
                txtSupplierName.Text = ds.Tables(0).Rows(0)("SupplierName").ToString()
                DTPDate.Value = ds.Tables(0).Rows(0)("Date").ToString()

                txtQuantity.Text = ds.Tables(0).Rows(0)("Qty").ToString()
                txtCostPerItem.Text = ds.Tables(0).Rows(0)("CostPerItem").ToString()
                txtTotalAmmount.Text = ds.Tables(0).Rows(0)("TotalCost").ToString()
            End If
        End If
    End Sub

    
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
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
            str = "Update AssetMaster set AssetName='" + txtAssetName.Text + "',InstID='" + cmbInstituteName.SelectedItem + "',DeptID='" + cmbInstituteName.SelectedItem + "',AssetGroup='" + cmbAssetGroup.SelectedItem + "',Company='" + txtCompany.Text + "',SupplierName='" + txtSupplierName.Text + "',Date='" + DTPDate.Value + "',Qty='" + txtQuantity.Text + "',CostPerItem='" + txtCostPerItem.Text + "',TotalCost='" + txtTotalAmmount.Text + "' where AssetID=" + testModule.var.ToString()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "Asset Master")
            Me.Hide()
            frmAssetDetails.Show()
            FrmAssetMaster.ClearDetails()
            BindGrid()
            testModule.var = ""
        End If
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from AssetMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            frmAssetDetails.DGAssetMaster.DataSource = ds.Tables(0)
        Else
            frmAssetDetails.DGAssetMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If testModule.var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Asset Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from AssetMaster where AssetID= '" + testModule.var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Asset Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()
                testModule.var = ""
                Me.Close()
                frmAssetDetails.Show()
            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Asset Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                testModule.var = ""
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Asset Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Refresh()
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        Ammount = 0
        Ammount = Val(txtCostPerItem.Text) * Val(txtQuantity.Text)
        txtTotalAmmount.Text = Ammount
    End Sub

    Private Sub txtCostPerItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostPerItem.TextChanged
        Ammount = 0
        Ammount = Val(txtCostPerItem.Text) * Val(txtQuantity.Text)
        txtTotalAmmount.Text = Ammount
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

End Class