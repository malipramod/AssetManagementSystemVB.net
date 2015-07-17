Public Class frmPurchaseReturns

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtAssetName.Text.Equals("") Then
            MsgBox("Please Provide Asset Name", MsgBoxStyle.Critical, "Asset Name is Missing")
            txtAssetName.Focus()
        Else
            testModule.rptID = 4
            testModule.item = txtAssetName.Text
            Me.Hide()
            frmRPTViewer.Show()
        End If
    End Sub
End Class