Imports System.Data.SqlClient

Public Class frmRPTViewer
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRV.Load
        con = New SqlConnection(testModule.Constr)
        con.Open()
        If testModule.rptID = 1 Then
            str = ""
            str = "SELECT SupplierName, Address, Gender, MobileNo, EmailID, Company FROM SupplierMaster where SupplierName like'%" + testModule.item.ToString + "%'"
            ds = New DataSet
            da = New SqlDataAdapter(str, con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim rpt As New CRSupplier
                rpt.SetDataSource(ds.Tables(0))
                CRV.ReportSource = rpt
            End If
        ElseIf testModule.rptID = 2 Then
            str = ""
            str = "SELECT     AssetName, AssetGroup, Company, SaleDate, BuyerName, MobileNo FROM SaleMaster where AssetName like'%" + testModule.item.ToString + "%'"
            ds = New DataSet
            da = New SqlDataAdapter(str, con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim rpt As New CRSales
                rpt.SetDataSource(ds.Tables(0))
                CRV.ReportSource = rpt
            End If
        ElseIf testModule.rptID = 3 Then
            str = ""
            str = "SELECT     AssetName, AssetGroup, Company, Address, GivenDate, ReceiveDate, TotalCost FROM RepairmentRegisterMaster where AssetName like'%" + testModule.item.ToString + "%'"
            ds = New DataSet
            da = New SqlDataAdapter(str, con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim rpt As New CRRepairments
                rpt.SetDataSource(ds.Tables(0))
                CRV.ReportSource = rpt
            End If
        ElseIf testModule.rptID = 4 Then
            str = ""
            str = "SELECT AssetName, AssetGroup, SupplierName, ReturnDate, TotalCost, ClosingBalance FROM PurchaseReturnMaster where AssetName like'%" + testModule.item.ToString + "%'"
            ds = New DataSet
            da = New SqlDataAdapter(str, con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim rpt As New CRPurchaseReturn
                rpt.SetDataSource(ds.Tables(0))
                CRV.ReportSource = rpt
            End If
        ElseIf testModule.rptID = 5 Then
            str = ""
            str = "SELECT InstituteMaster.InstName, DepartmentMaster.DeptName FROM DepartmentMaster INNER JOIN InstituteMaster ON DepartmentMaster.InstID = InstituteMaster.InstID where InstName like'%" + testModule.item.ToString + "%'"
            ds = New DataSet
            da = New SqlDataAdapter(str, con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim rpt As New CRInstDept
                rpt.SetDataSource(ds.Tables(0))
                CRV.ReportSource = rpt
            End If
        ElseIf testModule.rptID = 6 Then
            str = ""
            str = "SELECT InstituteMaster.InstName, DepartmentMaster.DeptName FROM DepartmentMaster INNER JOIN InstituteMaster ON DepartmentMaster.InstID = InstituteMaster.InstID where DeptName like'%" + testModule.item.ToString + "%'"
            ds = New DataSet
            da = New SqlDataAdapter(str, con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim rpt As New CRInstDept
                rpt.SetDataSource(ds.Tables(0))
                CRV.ReportSource = rpt
            End If
        End If
    End Sub

    Private Sub frmRPTViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class