Imports System.Data.SqlClient
Public Class frmAssetDetails
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String

    Private Sub frmAssetDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        BindGrid()
    End Sub

    Private Sub frmDonorDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        BindGrid()
        cmbSearchBy.Text = "Asset Name"
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from AssetMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGAssetMaster.DataSource = ds.Tables(0)
        Else
            DGAssetMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub DGAssetMaster_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGAssetMaster.CellMouseClick
        str = ""
        str = "select *from AssetMaster where AssetID=" + DGAssetMaster.SelectedRows(0).Cells("AssetID").Value.ToString()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            var = ds.Tables(0).Rows(0)("AssetID").ToString()
        End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New FrmAssetMaster
        frm.ShowDialog()
        'BindGrid()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If var <> "" Then
            Dim frm As New FrmEditAssetMaster
            frm.ShowDialog()
            BindGrid()
        Else
            MsgBox("Please Select any Record to Perform this operation", MsgBoxStyle.Critical, "Please Select a Reocrd")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Asset Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from AssetMaster where AssetID= '" + var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Asset Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()

            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Asset Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Refresh()
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Asset Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Refresh()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If cmbSearchBy.Text.Equals("Asset Name") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from AssetMaster Where AssetName like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGAssetMaster.DataSource = ds.Tables(0)
                    DGAssetMaster.Columns(0).Visible = False
                Else
                    DGAssetMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Insititute") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from AssetMaster Where InstID like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGAssetMaster.DataSource = ds.Tables(0)
                    DGAssetMaster.Columns(0).Visible = False
                Else
                    DGAssetMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Department") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from AssetMaster Where DeptID like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGAssetMaster.DataSource = ds.Tables(0)
                    DGAssetMaster.Columns(0).Visible = False
                Else
                    DGAssetMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Company") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from AssetMaster Where Company like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGAssetMaster.DataSource = ds.Tables(0)
                    DGAssetMaster.Columns(0).Visible = False
                Else
                    DGAssetMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Supplier Name") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from AssetMaster Where SupplierName like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGAssetMaster.DataSource = ds.Tables(0)
                    DGAssetMaster.Columns(0).Visible = False
                Else
                    DGAssetMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Date") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from AssetMaster Where Date like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGAssetMaster.DataSource = ds.Tables(0)
                    DGAssetMaster.Columns(0).Visible = False
                Else
                    DGAssetMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        End If

    End Sub
End Class
