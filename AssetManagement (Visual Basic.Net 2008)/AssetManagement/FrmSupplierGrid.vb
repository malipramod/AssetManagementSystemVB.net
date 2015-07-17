Imports System.Data.SqlClient
Public Class FrmSupplierGrid

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String


    Private Sub FrmSupplierGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        BindGrid()
        cmbSearchBy.Text = "Supplier Name"
    End Sub

    Sub BindGrid()
        str = ""
        str = "Select *from SupplierMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGSupplierMaster.DataSource = ds.Tables(0)
        Else
            DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub DGSupplierMaster_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGSupplierMaster.CellMouseClick
        str = ""
        str = "select *from SupplierMaster where SupplierID=" + DGSupplierMaster.SelectedRows(0).Cells("SupplierID").Value.ToString()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            var = ds.Tables(0).Rows(0)("SupplierID").ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New FrmSupplierMaster
        frm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If var <> "" Then
            Dim frm As New FrmEditSupplierMaster
            frm.ShowDialog()
            BindGrid()
        Else
            MsgBox("Please Select any Record to Perform this operation", MsgBoxStyle.Critical, "Please Select a Reocrd")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are you sure?", "Supplier Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete from SupplierMaster where SupplierID= '" + var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()

            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Refresh()
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Refresh()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If cmbSearchBy.Text.Equals("Supplier Name") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SupplierMaster Where SupplierName like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSupplierMaster.DataSource = ds.Tables(0)
                    DGSupplierMaster.Columns(0).Visible = False
                Else
                    DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Company") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SupplierMaster Where Company like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSupplierMaster.DataSource = ds.Tables(0)
                    DGSupplierMaster.Columns(0).Visible = False
                Else
                    DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("City") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SupplierMaster Where City like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSupplierMaster.DataSource = ds.Tables(0)
                    DGSupplierMaster.Columns(0).Visible = False
                Else
                    DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Mobile Number") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SupplierMaster Where MobileNo like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSupplierMaster.DataSource = ds.Tables(0)
                    DGSupplierMaster.Columns(0).Visible = False
                Else
                    DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        ElseIf cmbSearchBy.Text.Equals("Email Address") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from SupplierMaster Where EmailID like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet()
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGSupplierMaster.DataSource = ds.Tables(0)
                    DGSupplierMaster.Columns(0).Visible = False
                Else
                    DGSupplierMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        End If
    End Sub

    
End Class