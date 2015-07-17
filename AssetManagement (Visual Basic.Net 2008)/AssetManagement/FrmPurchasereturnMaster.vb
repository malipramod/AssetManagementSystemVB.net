Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmPurchasereturnMaster
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim Ammount As String
    Dim ClosingBalance As String
    Dim diff As String

    Private Sub FrmPurchasereturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        txtClosingBalance.Enabled = False
        txtTotalCost.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtAssetName.Text = "" Then
            MsgBox("Please Fill the Asset Name", MsgBoxStyle.Critical, "Asset Name Missing")
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
            str = "Insert Into PurchaseReturnMaster(AssetName,InstID,DeptID,AssetGroup,Company,SupplierName,ReturnDate,Qty,CostPerItem,TotalCost,ReturnItem,ClosingBalance) values('" + txtAssetName.Text + "','" + cmbInstituteName.SelectedItem + "','" + cmbDepartmentName.SelectedItem + "','" + cmbAssetGroup.SelectedItem + "','" + txtCompany.Text + "','" + txtSupplierName.Text + "','" + DTPReturn.Value + "','" + txtQuantity.Text + "','" + txtCostPerItem.Text + "','" + Ammount + "','" + txtReturnItem.Text + "','" + txtClosingBalance.Text + "')"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Inserted Successfully", "Purchase Return")
            Me.Hide()
            frmAssetDetails.Show()
            BindGrid()
            ClearDetails()
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

    Sub ClearDetails()
        txtAssetName.Text = ""
        cmbInstituteName.SelectedIndex = -1
        cmbAssetGroup.SelectedIndex = -1
        cmbDepartmentName.SelectedIndex = -1
        txtCompany.Text = ""
        txtSupplierName.Text = ""       
        txtQuantity.Text = ""
        txtCostPerItem.Text = ""
        txtTotalCost.Text = ""
        txtClosingBalance.Text = ""
        txtReturnItem.Text = ""
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

    Private Sub txtReturnItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReturnItem.Click
        txtReturnItem.Text = ""
    End Sub

    Private Sub txtReturnItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnItem.TextChanged
        ClosingBalance = Ammount - (Val(txtCostPerItem.Text) * Val(txtReturnItem.Text))
        txtClosingBalance.Text = ClosingBalance
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearDetails()
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