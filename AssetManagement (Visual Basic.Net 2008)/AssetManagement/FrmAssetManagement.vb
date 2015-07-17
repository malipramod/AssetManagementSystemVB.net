Imports System.Data.SqlClient
Public Class FrmAssetManagement
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        str = ""
        str = "Update LoginMaster set LoggedOutTime = '" + lblouttimer.Text + "' where UserID= " + testModule.uid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("You are LoggedOut Successfully", "Log Out ")
        End
    End Sub

    Private Sub BtnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReg.Click
        PnlReg.Visible = True
        If PnlTrans.Visible = True Then
            PnlTrans.Visible = False
        End If
    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        PnlTrans.Visible = True
        If PnlReg.Visible = True Then
            PnlReg.Visible = False
        End If
    End Sub

    Private Sub BtnInst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInst.Click
        Dim frm As New FrmInstituteMaster
        frm.ShowDialog()
        PnlReg.Visible = False
    End Sub

    Private Sub BtnDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDept.Click
        Dim frm As New FrmDepartmentMaster
        frm.ShowDialog()
    End Sub

    Private Sub BtnUserReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUserReg.Click
        Dim frm As New FrmUserReg
        frm.ShowDialog()
        PnlReg.Visible = False

    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Str = ""
        Str = "Update LoginMaster set LoggedOutTime = '" + lblouttimer.Text + "' where UserID= " + testModule.uid.ToString()
        cmd = New SqlCommand(Str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("You are LoggedOut Successfully", "Log Out ")

        End
    End Sub

    Private Sub btnAssetReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssetReg.Click
        Dim frm As New FrmAssetMaster
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New FrmSupplierMaster
        frm.ShowDialog()
    End Sub

    Private Sub FrmAssetManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblTimer.Text = System.DateTime.Now.ToLongTimeString
        lblUserName.Text = FrmLoginForm.txtUserName.Text
        con = New SqlConnection(testModule.Constr)
        con.Open()
        If FrmLoginForm.cmbUserType.Text = "Admin" Then
            BtnInst.Enabled = True
            BtnDept.Enabled = True
            BtnUserReg.Enabled = True
            BtnEditDept.Enabled = True
            BtnEditInst.Enabled = True
            frmEditUserReg.btnDelete.Enabled = True
            frmEditUserReg.cmbUserType.Enabled = True
        End If
    End Sub

    Private Sub BtnAssetTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAssetTrans.Click
        Dim frm As New frmAssetDetails
        frm.ShowDialog()
    End Sub

    Private Sub BtnPurchaseReturnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPurchaseReturnTrans.Click
        Dim frm As New FrmPurchaseReturnGrid
        frm.ShowDialog()
    End Sub

    Private Sub btnRepairmentsTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepairmentsTran.Click
        Dim frm As New FrmRepairmentGrid
        frm.ShowDialog()
    End Sub

    Private Sub btnSalesTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesTran.Click
        Dim frm As New FrmSaleGrid
        frm.ShowDialog()
    End Sub

    Private Sub btnSupplirTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplirTran.Click
        Dim frm As New FrmSupplierGrid
        frm.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblouttimer.Text = System.DateTime.Now.ToLongTimeString
    End Sub
End Class
