<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepairment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepairment))
        Me.btmClear = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAssetName = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btmClear
        '
        Me.btmClear.BackgroundImage = CType(resources.GetObject("btmClear.BackgroundImage"), System.Drawing.Image)
        Me.btmClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btmClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btmClear.FlatAppearance.BorderSize = 2
        Me.btmClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btmClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btmClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmClear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmClear.ForeColor = System.Drawing.Color.White
        Me.btmClear.Location = New System.Drawing.Point(300, 71)
        Me.btmClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btmClear.Name = "btmClear"
        Me.btmClear.Size = New System.Drawing.Size(73, 31)
        Me.btmClear.TabIndex = 119
        Me.btmClear.Text = "&Clear"
        Me.btmClear.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.BackgroundImage = CType(resources.GetObject("btnShow.BackgroundImage"), System.Drawing.Image)
        Me.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShow.FlatAppearance.BorderSize = 2
        Me.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(222, 71)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(72, 30)
        Me.btnShow.TabIndex = 118
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(63, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 22)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Asset Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAssetName
        '
        Me.txtAssetName.BackColor = System.Drawing.Color.White
        Me.txtAssetName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetName.Location = New System.Drawing.Point(194, 37)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.Size = New System.Drawing.Size(185, 26)
        Me.txtAssetName.TabIndex = 116
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(329, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 24)
        Me.btnClose.TabIndex = 120
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmRepairment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(391, 130)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btmClear)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAssetName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRepairment"
        Me.Text = "frmRepairment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btmClear As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAssetName As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
