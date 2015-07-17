<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssetManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAssetManagement))
        Me.BtnReg = New System.Windows.Forms.Button
        Me.btnTransaction = New System.Windows.Forms.Button
        Me.btnReports = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnMiniMize = New System.Windows.Forms.Button
        Me.PnlReg = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnLogout = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnUserReg = New System.Windows.Forms.Button
        Me.BtnDept = New System.Windows.Forms.Button
        Me.BtnInst = New System.Windows.Forms.Button
        Me.btnAssetReg = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblTimer = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnAssetTrans = New System.Windows.Forms.Button
        Me.BtnPurchaseReturnTrans = New System.Windows.Forms.Button
        Me.BtnChangePass = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnEditInst = New System.Windows.Forms.Button
        Me.BtnEditDept = New System.Windows.Forms.Button
        Me.BtnEditUser = New System.Windows.Forms.Button
        Me.btnRepairmentsTran = New System.Windows.Forms.Button
        Me.btnSalesTran = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PnlTrans = New System.Windows.Forms.Panel
        Me.lblouttimer = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSupplirTran = New System.Windows.Forms.Button
        Me.PnlReg.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTrans.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnReg
        '
        Me.BtnReg.BackColor = System.Drawing.Color.White
        Me.BtnReg.BackgroundImage = CType(resources.GetObject("BtnReg.BackgroundImage"), System.Drawing.Image)
        Me.BtnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReg.FlatAppearance.BorderSize = 3
        Me.BtnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReg.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReg.ForeColor = System.Drawing.Color.White
        Me.BtnReg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnReg.Location = New System.Drawing.Point(326, 40)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(215, 58)
        Me.BtnReg.TabIndex = 52
        Me.BtnReg.Text = "&Registration"
        Me.BtnReg.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.White
        Me.btnTransaction.BackgroundImage = CType(resources.GetObject("btnTransaction.BackgroundImage"), System.Drawing.Image)
        Me.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransaction.FlatAppearance.BorderSize = 3
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnTransaction.Location = New System.Drawing.Point(563, 40)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(320, 58)
        Me.btnTransaction.TabIndex = 53
        Me.btnTransaction.Text = "&Transaction / Edit"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.White
        Me.btnReports.BackgroundImage = CType(resources.GetObject("btnReports.BackgroundImage"), System.Drawing.Image)
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 3
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnReports.Location = New System.Drawing.Point(906, 40)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(154, 58)
        Me.btnReports.TabIndex = 54
        Me.btnReports.Text = "Re&ports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1301, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(53, 25)
        Me.btnClose.TabIndex = 104
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMiniMize
        '
        Me.btnMiniMize.BackgroundImage = CType(resources.GetObject("btnMiniMize.BackgroundImage"), System.Drawing.Image)
        Me.btnMiniMize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMiniMize.Location = New System.Drawing.Point(1259, 8)
        Me.btnMiniMize.Name = "btnMiniMize"
        Me.btnMiniMize.Size = New System.Drawing.Size(40, 24)
        Me.btnMiniMize.TabIndex = 105
        Me.btnMiniMize.UseVisualStyleBackColor = True
        '
        'PnlReg
        '
        Me.PnlReg.BackColor = System.Drawing.Color.Transparent
        Me.PnlReg.BackgroundImage = Global.AssetManagement.My.Resources.Resources.flow_of_glow_wide_2
        Me.PnlReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlReg.Controls.Add(Me.Button1)
        Me.PnlReg.Controls.Add(Me.BtnLogout)
        Me.PnlReg.Controls.Add(Me.PictureBox2)
        Me.PnlReg.Controls.Add(Me.BtnUserReg)
        Me.PnlReg.Controls.Add(Me.BtnDept)
        Me.PnlReg.Controls.Add(Me.BtnInst)
        Me.PnlReg.Controls.Add(Me.btnAssetReg)
        Me.PnlReg.Controls.Add(Me.Label2)
        Me.PnlReg.Location = New System.Drawing.Point(156, 140)
        Me.PnlReg.Name = "PnlReg"
        Me.PnlReg.Size = New System.Drawing.Size(609, 349)
        Me.PnlReg.TabIndex = 112
        Me.PnlReg.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(39, 116)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 35)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "&Supplier Registration"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLogout.FlatAppearance.BorderSize = 2
        Me.BtnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogout.Location = New System.Drawing.Point(40, 291)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(135, 35)
        Me.BtnLogout.TabIndex = 97
        Me.BtnLogout.Text = "LOG &OUT"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(358, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 267)
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'BtnUserReg
        '
        Me.BtnUserReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnUserReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUserReg.FlatAppearance.BorderSize = 2
        Me.BtnUserReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUserReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUserReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUserReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserReg.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUserReg.Location = New System.Drawing.Point(39, 247)
        Me.BtnUserReg.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUserReg.Name = "BtnUserReg"
        Me.BtnUserReg.Size = New System.Drawing.Size(210, 35)
        Me.BtnUserReg.TabIndex = 93
        Me.BtnUserReg.Text = "&User Registration"
        Me.BtnUserReg.UseVisualStyleBackColor = True
        '
        'BtnDept
        '
        Me.BtnDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDept.FlatAppearance.BorderSize = 2
        Me.BtnDept.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDept.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDept.Location = New System.Drawing.Point(39, 202)
        Me.BtnDept.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDept.Name = "BtnDept"
        Me.BtnDept.Size = New System.Drawing.Size(281, 35)
        Me.BtnDept.TabIndex = 91
        Me.BtnDept.Text = "&Department Registration"
        Me.BtnDept.UseVisualStyleBackColor = True
        '
        'BtnInst
        '
        Me.BtnInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnInst.FlatAppearance.BorderSize = 2
        Me.BtnInst.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnInst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInst.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnInst.Location = New System.Drawing.Point(39, 160)
        Me.BtnInst.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInst.Name = "BtnInst"
        Me.BtnInst.Size = New System.Drawing.Size(248, 35)
        Me.BtnInst.TabIndex = 90
        Me.BtnInst.Text = "&Institute Registration"
        Me.BtnInst.UseVisualStyleBackColor = True
        '
        'btnAssetReg
        '
        Me.btnAssetReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAssetReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAssetReg.FlatAppearance.BorderSize = 2
        Me.btnAssetReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAssetReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAssetReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAssetReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssetReg.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssetReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAssetReg.Location = New System.Drawing.Point(39, 73)
        Me.btnAssetReg.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAssetReg.Name = "btnAssetReg"
        Me.btnAssetReg.Size = New System.Drawing.Size(218, 35)
        Me.btnAssetReg.TabIndex = 88
        Me.btnAssetReg.Text = "&Asset Registration"
        Me.btnAssetReg.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 713)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "UserName :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(138, 714)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(80, 25)
        Me.lblUserName.TabIndex = 117
        Me.lblUserName.Text = "xyz098"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTimer.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTimer.Location = New System.Drawing.Point(506, 714)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(113, 25)
        Me.lblTimer.TabIndex = 119
        Me.lblTimer.Text = "08 : 30 AM"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(338, 714)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 25)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Logged In Time : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(976, 716)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(377, 31)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "By NeuronExcellence Infotech"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Transaction"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAssetTrans
        '
        Me.BtnAssetTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAssetTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAssetTrans.FlatAppearance.BorderSize = 2
        Me.BtnAssetTrans.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAssetTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAssetTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnAssetTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAssetTrans.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAssetTrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAssetTrans.Location = New System.Drawing.Point(39, 73)
        Me.BtnAssetTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAssetTrans.Name = "BtnAssetTrans"
        Me.BtnAssetTrans.Size = New System.Drawing.Size(215, 35)
        Me.BtnAssetTrans.TabIndex = 88
        Me.BtnAssetTrans.Text = "&Asset Transaction"
        Me.BtnAssetTrans.UseVisualStyleBackColor = True
        '
        'BtnPurchaseReturnTrans
        '
        Me.BtnPurchaseReturnTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPurchaseReturnTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPurchaseReturnTrans.FlatAppearance.BorderSize = 2
        Me.BtnPurchaseReturnTrans.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPurchaseReturnTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPurchaseReturnTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnPurchaseReturnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPurchaseReturnTrans.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPurchaseReturnTrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPurchaseReturnTrans.Location = New System.Drawing.Point(39, 119)
        Me.BtnPurchaseReturnTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPurchaseReturnTrans.Name = "BtnPurchaseReturnTrans"
        Me.BtnPurchaseReturnTrans.Size = New System.Drawing.Size(204, 35)
        Me.BtnPurchaseReturnTrans.TabIndex = 89
        Me.BtnPurchaseReturnTrans.Text = "&Purchase Return"
        Me.BtnPurchaseReturnTrans.UseVisualStyleBackColor = True
        '
        'BtnChangePass
        '
        Me.BtnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnChangePass.FlatAppearance.BorderSize = 2
        Me.BtnChangePass.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangePass.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangePass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnChangePass.Location = New System.Drawing.Point(38, 503)
        Me.BtnChangePass.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnChangePass.Name = "BtnChangePass"
        Me.BtnChangePass.Size = New System.Drawing.Size(216, 35)
        Me.BtnChangePass.TabIndex = 91
        Me.BtnChangePass.Text = "&Change Password"
        Me.BtnChangePass.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(294, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(228, 245)
        Me.PictureBox3.TabIndex = 94
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-3, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 46)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Edit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEditInst
        '
        Me.BtnEditInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEditInst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEditInst.FlatAppearance.BorderSize = 2
        Me.BtnEditInst.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditInst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnEditInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditInst.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditInst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditInst.Location = New System.Drawing.Point(39, 368)
        Me.BtnEditInst.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditInst.Name = "BtnEditInst"
        Me.BtnEditInst.Size = New System.Drawing.Size(174, 35)
        Me.BtnEditInst.TabIndex = 96
        Me.BtnEditInst.Text = "Edit &Institutes"
        Me.BtnEditInst.UseVisualStyleBackColor = True
        '
        'BtnEditDept
        '
        Me.BtnEditDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEditDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEditDept.FlatAppearance.BorderSize = 2
        Me.BtnEditDept.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditDept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditDept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnEditDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditDept.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditDept.Location = New System.Drawing.Point(39, 413)
        Me.BtnEditDept.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditDept.Name = "BtnEditDept"
        Me.BtnEditDept.Size = New System.Drawing.Size(208, 35)
        Me.BtnEditDept.TabIndex = 97
        Me.BtnEditDept.Text = "Edit &Departments"
        Me.BtnEditDept.UseVisualStyleBackColor = True
        '
        'BtnEditUser
        '
        Me.BtnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEditUser.FlatAppearance.BorderSize = 2
        Me.BtnEditUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditUser.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditUser.Location = New System.Drawing.Point(38, 458)
        Me.BtnEditUser.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditUser.Name = "BtnEditUser"
        Me.BtnEditUser.Size = New System.Drawing.Size(205, 35)
        Me.BtnEditUser.TabIndex = 98
        Me.BtnEditUser.Text = "Edit &User Profile"
        Me.BtnEditUser.UseVisualStyleBackColor = True
        '
        'btnRepairmentsTran
        '
        Me.btnRepairmentsTran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRepairmentsTran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRepairmentsTran.FlatAppearance.BorderSize = 2
        Me.btnRepairmentsTran.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRepairmentsTran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRepairmentsTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnRepairmentsTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepairmentsTran.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepairmentsTran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRepairmentsTran.Location = New System.Drawing.Point(39, 163)
        Me.btnRepairmentsTran.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRepairmentsTran.Name = "btnRepairmentsTran"
        Me.btnRepairmentsTran.Size = New System.Drawing.Size(163, 35)
        Me.btnRepairmentsTran.TabIndex = 100
        Me.btnRepairmentsTran.Text = "&Repairments"
        Me.btnRepairmentsTran.UseVisualStyleBackColor = True
        '
        'btnSalesTran
        '
        Me.btnSalesTran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalesTran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalesTran.FlatAppearance.BorderSize = 2
        Me.btnSalesTran.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalesTran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalesTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSalesTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesTran.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesTran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalesTran.Location = New System.Drawing.Point(39, 209)
        Me.btnSalesTran.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalesTran.Name = "btnSalesTran"
        Me.btnSalesTran.Size = New System.Drawing.Size(98, 35)
        Me.btnSalesTran.TabIndex = 101
        Me.btnSalesTran.Text = "&Sales"
        Me.btnSalesTran.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(294, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 235)
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'PnlTrans
        '
        Me.PnlTrans.BackColor = System.Drawing.Color.Transparent
        Me.PnlTrans.BackgroundImage = Global.AssetManagement.My.Resources.Resources.flow_of_glow_wide_2
        Me.PnlTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlTrans.Controls.Add(Me.btnSupplirTran)
        Me.PnlTrans.Controls.Add(Me.PictureBox1)
        Me.PnlTrans.Controls.Add(Me.btnSalesTran)
        Me.PnlTrans.Controls.Add(Me.btnRepairmentsTran)
        Me.PnlTrans.Controls.Add(Me.BtnEditUser)
        Me.PnlTrans.Controls.Add(Me.BtnEditDept)
        Me.PnlTrans.Controls.Add(Me.BtnEditInst)
        Me.PnlTrans.Controls.Add(Me.Label4)
        Me.PnlTrans.Controls.Add(Me.PictureBox3)
        Me.PnlTrans.Controls.Add(Me.BtnChangePass)
        Me.PnlTrans.Controls.Add(Me.BtnPurchaseReturnTrans)
        Me.PnlTrans.Controls.Add(Me.BtnAssetTrans)
        Me.PnlTrans.Controls.Add(Me.Label3)
        Me.PnlTrans.Location = New System.Drawing.Point(429, 139)
        Me.PnlTrans.Name = "PnlTrans"
        Me.PnlTrans.Size = New System.Drawing.Size(579, 557)
        Me.PnlTrans.TabIndex = 124
        Me.PnlTrans.Visible = False
        '
        'lblouttimer
        '
        Me.lblouttimer.AutoSize = True
        Me.lblouttimer.Location = New System.Drawing.Point(247, 562)
        Me.lblouttimer.Name = "lblouttimer"
        Me.lblouttimer.Size = New System.Drawing.Size(65, 21)
        Me.lblouttimer.TabIndex = 125
        Me.lblouttimer.Text = "Label8"
        Me.lblouttimer.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnSupplirTran
        '
        Me.btnSupplirTran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSupplirTran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSupplirTran.FlatAppearance.BorderSize = 2
        Me.btnSupplirTran.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSupplirTran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSupplirTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSupplirTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplirTran.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplirTran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSupplirTran.Location = New System.Drawing.Point(38, 254)
        Me.btnSupplirTran.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSupplirTran.Name = "btnSupplirTran"
        Me.btnSupplirTran.Size = New System.Drawing.Size(99, 35)
        Me.btnSupplirTran.TabIndex = 103
        Me.btnSupplirTran.Text = "Su&pplier "
        Me.btnSupplirTran.UseVisualStyleBackColor = True
        '
        'FrmAssetManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AssetManagement.My.Resources.Resources.neon_squares_HD_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.lblouttimer)
        Me.Controls.Add(Me.PnlTrans)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlReg)
        Me.Controls.Add(Me.btnMiniMize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.BtnReg)
        Me.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FrmAssetManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " & _
            "                                                                              "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlReg.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTrans.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnReg As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMiniMize As System.Windows.Forms.Button
    Friend WithEvents PnlReg As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnUserReg As System.Windows.Forms.Button
    Friend WithEvents BtnDept As System.Windows.Forms.Button
    Friend WithEvents BtnInst As System.Windows.Forms.Button
    Friend WithEvents btnAssetReg As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnAssetTrans As System.Windows.Forms.Button
    Friend WithEvents BtnPurchaseReturnTrans As System.Windows.Forms.Button
    Friend WithEvents BtnChangePass As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnEditInst As System.Windows.Forms.Button
    Friend WithEvents BtnEditDept As System.Windows.Forms.Button
    Friend WithEvents BtnEditUser As System.Windows.Forms.Button
    Friend WithEvents btnRepairmentsTran As System.Windows.Forms.Button
    Friend WithEvents btnSalesTran As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlTrans As System.Windows.Forms.Panel
    Friend WithEvents lblouttimer As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSupplirTran As System.Windows.Forms.Button

End Class
