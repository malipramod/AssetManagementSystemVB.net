Imports System.Data.SqlClient
Public Class FrmLoginForm
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Dim username As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUserName.Text = ""
        txtUserName.Text = ""
        txtPassword.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    
    Private Sub FrmLoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        con = New SqlConnection(testModule.Constr)
        con.Open()
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        str = ""
        str = "SELECT UserName FROM UserRegMaster "
        str = str & "WHERE (UserName = '" + txtUserName.Text + "' "
        str = str & "And Password = '" + txtPassword.Text + "'"
        str = str & "And UserType = '" + cmbUserType.Text + "')"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds, "UserRegMaster")

        For Each rowTest In ds.Tables(0).Rows
            username = rowTest("UserName").ToString
        Next

        If username <> "" Then
            MessageBox.Show("Welcome " & username & "!")
            str = ""
            str = "INSERT INTO LoginMaster (UserName,Password,UserType,LoggedInTime) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cmbUserType.Text + "','" + lblTimer.Text + "'   )"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()

            str = ""
            str = "select max(UserID) as UserID from LoginMaster"
            da = New SqlDataAdapter(str, con)
            Dim ds1 As DataSet
            ds1 = New DataSet
            da.Fill(ds1)
            If (ds1.Tables(0).Rows.Count > 0) Then

                testModule.uid = ds1.Tables(0).Rows(0)("UserID").ToString()

            End If

            str = ""
            str = "SELECT * FROM UserRegMaster "
            str = str & "WHERE (UserName = '" + txtUserName.Text + "' "
            str = str & "And Password = '" + txtPassword.Text + "'"
            str = str & "And UserType = '" + cmbUserType.Text + "')"
            da = New SqlDataAdapter(str, con)
            Dim ds2 As DataSet
            ds2 = New DataSet
            da.Fill(ds2, "UserRegMaster")
            If (ds2.Tables(0).Rows.Count > 0) Then

                testModule.rid = ds2.Tables(0).Rows(0)("RegID").ToString()


            End If


            Me.Hide()
            FrmAssetManagement.Show()


        Else
            MessageBox.Show("Please check user name and password.")
            txtUserName.Text = ""
            txtPassword.Text = ""
            cmbUserType.SelectedIndex = -1
            txtUserName.Focus()

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimer.Text = System.DateTime.Now.ToLongTimeString
    End Sub

    Private Sub btnLogIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnLogIn.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 32) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False

        End If
    End Sub

    Private Sub btnForgotPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForgotPass.Click
        FrmForgotpassord.Show()
        Me.Hide()
    End Sub
End Class
