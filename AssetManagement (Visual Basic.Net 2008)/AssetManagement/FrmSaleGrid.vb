Imports System.Data.SqlClient
Public Class FrmSaleGrid

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String

    Private Sub FrmSaleGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        BindGrid()
        cmbSearchBy.Text = "Asset Name"
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from SaleMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGSalesMaster.DataSource = ds.Tables(0)
        Else
            DGSalesMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub


    Private Sub DGSalesMaster_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGSalesMaster.CellMouseClick
        str = ""
        str = "select *from SaleMaster where AssetID=" + DGSalesMaster.SelectedRows(0).Cells("AssetID").Value.ToString()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            var = ds.Tables(0).Rows(0)("AssetID").ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New FrmSaleMaster
        frm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If var <> "" Then
            Dim frm As New FrmEditSaleMaster
            frm.ShowDialog()
            BindGrid()
        Else
            MsgBox("Please Select any Record to Perform this operation", MsgBoxStyle.Critical, "Please Select a Reocrd")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Sale Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from SaleMaster where AssetID= '" + var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Sale Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()
                var = ""

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

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If cmbSearchBy.Text.Equals("Asset Name") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SaleMaster Where AssetName like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSalesMaster.DataSource = ds.Tables(0)
                    DGSalesMaster.Columns(0).Visible = False
                Else
                    DGSalesMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Company") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SaleMaster Where Company like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSalesMaster.DataSource = ds.Tables(0)
                    DGSalesMaster.Columns(0).Visible = False
                Else
                    DGSalesMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Buyer Name") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SaleMaster Where BuyerName like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSalesMaster.DataSource = ds.Tables(0)
                    DGSalesMaster.Columns(0).Visible = False
                Else
                    DGSalesMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("City") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SaleMaster Where City like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSalesMaster.DataSource = ds.Tables(0)
                    DGSalesMaster.Columns(0).Visible = False
                Else
                    DGSalesMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Mobile Number") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SaleMaster Where MobileNo like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSalesMaster.DataSource = ds.Tables(0)
                    DGSalesMaster.Columns(0).Visible = False
                Else
                    DGSalesMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Email Address") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SaleMaster Where EmailID like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSalesMaster.DataSource = ds.Tables(0)
                    DGSalesMaster.Columns(0).Visible = False
                Else
                    DGSalesMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        End If
    End Sub

    
End Class