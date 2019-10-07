<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TopInfoBox = New System.Windows.Forms.TextBox()
        Me.CheckConnBTN = New System.Windows.Forms.Button()
        Me.RestartADBbtn = New System.Windows.Forms.Button()
        Me.GetIMEIbtn = New System.Windows.Forms.Button()
        Me.PullMACbtn = New System.Windows.Forms.Button()
        Me.PullSerialNumBTN = New System.Windows.Forms.Button()
        Me.PullICCIDbtn = New System.Windows.Forms.Button()
        Me.ExportExcelBTN = New System.Windows.Forms.Button()
        Me.ExportSQLbtn1 = New System.Windows.Forms.Button()
        Me.ExportTextBtn = New System.Windows.Forms.Button()
        Me.UpdaterBTN = New System.Windows.Forms.Button()
        Me.SerialNumLabel1 = New System.Windows.Forms.Label()
        Me.MacAddressLabel1 = New System.Windows.Forms.Label()
        Me.SerialNumberLabel1 = New System.Windows.Forms.Label()
        Me.ICCIDlabel1 = New System.Windows.Forms.Label()
        Me.IMEItextBox1 = New System.Windows.Forms.TextBox()
        Me.MacAddresstextBox1 = New System.Windows.Forms.TextBox()
        Me.SerialNumTextBox1 = New System.Windows.Forms.TextBox()
        Me.ICCIDtextBox1 = New System.Windows.Forms.TextBox()
        Me.RunCustomBTN1 = New System.Windows.Forms.Button()
        Me.adbCommandText1 = New System.Windows.Forms.TextBox()
        Me.CustomCommandMakeLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RebootBtn1 = New System.Windows.Forms.Button()
        Me.RebootFastBootBtn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FastBootCommandlabel1 = New System.Windows.Forms.Label()
        Me.fastbootCommandText1 = New System.Windows.Forms.TextBox()
        Me.RunCustomFastBootBtn1 = New System.Windows.Forms.Button()
        Me.RebootRecoveryBTN1 = New System.Windows.Forms.Button()
        Me.BroswerForAPKBtn = New System.Windows.Forms.Button()
        Me.APKpathTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.installBtn1 = New System.Windows.Forms.Button()
        Me.PointADBbtn = New System.Windows.Forms.Button()
        Me.StartADBbtn = New System.Windows.Forms.Button()
        Me.KillADBbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TopInfoBox
        '
        Me.TopInfoBox.Location = New System.Drawing.Point(13, 13)
        Me.TopInfoBox.Multiline = True
        Me.TopInfoBox.Name = "TopInfoBox"
        Me.TopInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TopInfoBox.Size = New System.Drawing.Size(273, 182)
        Me.TopInfoBox.TabIndex = 0
        '
        'CheckConnBTN
        '
        Me.CheckConnBTN.Location = New System.Drawing.Point(13, 201)
        Me.CheckConnBTN.Name = "CheckConnBTN"
        Me.CheckConnBTN.Size = New System.Drawing.Size(126, 23)
        Me.CheckConnBTN.TabIndex = 1
        Me.CheckConnBTN.Text = "Check Connection"
        Me.CheckConnBTN.UseVisualStyleBackColor = True
        '
        'RestartADBbtn
        '
        Me.RestartADBbtn.Location = New System.Drawing.Point(12, 230)
        Me.RestartADBbtn.Name = "RestartADBbtn"
        Me.RestartADBbtn.Size = New System.Drawing.Size(127, 23)
        Me.RestartADBbtn.TabIndex = 2
        Me.RestartADBbtn.Text = "Restart ADB "
        Me.RestartADBbtn.UseVisualStyleBackColor = True
        '
        'GetIMEIbtn
        '
        Me.GetIMEIbtn.Location = New System.Drawing.Point(13, 260)
        Me.GetIMEIbtn.Name = "GetIMEIbtn"
        Me.GetIMEIbtn.Size = New System.Drawing.Size(126, 23)
        Me.GetIMEIbtn.TabIndex = 3
        Me.GetIMEIbtn.Text = "Pull IMEI"
        Me.GetIMEIbtn.UseVisualStyleBackColor = True
        '
        'PullMACbtn
        '
        Me.PullMACbtn.Location = New System.Drawing.Point(13, 290)
        Me.PullMACbtn.Name = "PullMACbtn"
        Me.PullMACbtn.Size = New System.Drawing.Size(126, 23)
        Me.PullMACbtn.TabIndex = 4
        Me.PullMACbtn.Text = "Pull MAC"
        Me.PullMACbtn.UseVisualStyleBackColor = True
        '
        'PullSerialNumBTN
        '
        Me.PullSerialNumBTN.Location = New System.Drawing.Point(13, 320)
        Me.PullSerialNumBTN.Name = "PullSerialNumBTN"
        Me.PullSerialNumBTN.Size = New System.Drawing.Size(126, 23)
        Me.PullSerialNumBTN.TabIndex = 5
        Me.PullSerialNumBTN.Text = "Pull Serial Num"
        Me.PullSerialNumBTN.UseVisualStyleBackColor = True
        '
        'PullICCIDbtn
        '
        Me.PullICCIDbtn.Location = New System.Drawing.Point(13, 350)
        Me.PullICCIDbtn.Name = "PullICCIDbtn"
        Me.PullICCIDbtn.Size = New System.Drawing.Size(126, 23)
        Me.PullICCIDbtn.TabIndex = 6
        Me.PullICCIDbtn.Text = "Pull ICCID"
        Me.PullICCIDbtn.UseVisualStyleBackColor = True
        '
        'ExportExcelBTN
        '
        Me.ExportExcelBTN.Location = New System.Drawing.Point(160, 202)
        Me.ExportExcelBTN.Name = "ExportExcelBTN"
        Me.ExportExcelBTN.Size = New System.Drawing.Size(126, 23)
        Me.ExportExcelBTN.TabIndex = 7
        Me.ExportExcelBTN.Text = "Export To Excel"
        Me.ExportExcelBTN.UseVisualStyleBackColor = True
        '
        'ExportSQLbtn1
        '
        Me.ExportSQLbtn1.Location = New System.Drawing.Point(160, 231)
        Me.ExportSQLbtn1.Name = "ExportSQLbtn1"
        Me.ExportSQLbtn1.Size = New System.Drawing.Size(126, 23)
        Me.ExportSQLbtn1.TabIndex = 8
        Me.ExportSQLbtn1.Text = "Export to SQL"
        Me.ExportSQLbtn1.UseVisualStyleBackColor = True
        '
        'ExportTextBtn
        '
        Me.ExportTextBtn.Location = New System.Drawing.Point(160, 260)
        Me.ExportTextBtn.Name = "ExportTextBtn"
        Me.ExportTextBtn.Size = New System.Drawing.Size(126, 23)
        Me.ExportTextBtn.TabIndex = 9
        Me.ExportTextBtn.Text = "Export to Text File"
        Me.ExportTextBtn.UseVisualStyleBackColor = True
        '
        'UpdaterBTN
        '
        Me.UpdaterBTN.Location = New System.Drawing.Point(335, 14)
        Me.UpdaterBTN.Name = "UpdaterBTN"
        Me.UpdaterBTN.Size = New System.Drawing.Size(208, 23)
        Me.UpdaterBTN.TabIndex = 10
        Me.UpdaterBTN.Text = "Update Current Info"
        Me.UpdaterBTN.UseVisualStyleBackColor = True
        '
        'SerialNumLabel1
        '
        Me.SerialNumLabel1.AutoSize = True
        Me.SerialNumLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumLabel1.Location = New System.Drawing.Point(292, 46)
        Me.SerialNumLabel1.Name = "SerialNumLabel1"
        Me.SerialNumLabel1.Size = New System.Drawing.Size(37, 13)
        Me.SerialNumLabel1.TabIndex = 11
        Me.SerialNumLabel1.Text = "IMEI:"
        '
        'MacAddressLabel1
        '
        Me.MacAddressLabel1.AutoSize = True
        Me.MacAddressLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MacAddressLabel1.Location = New System.Drawing.Point(292, 72)
        Me.MacAddressLabel1.Name = "MacAddressLabel1"
        Me.MacAddressLabel1.Size = New System.Drawing.Size(100, 13)
        Me.MacAddressLabel1.TabIndex = 12
        Me.MacAddressLabel1.Text = "MAC ADDRESS:"
        '
        'SerialNumberLabel1
        '
        Me.SerialNumberLabel1.AutoSize = True
        Me.SerialNumberLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberLabel1.Location = New System.Drawing.Point(292, 98)
        Me.SerialNumberLabel1.Name = "SerialNumberLabel1"
        Me.SerialNumberLabel1.Size = New System.Drawing.Size(112, 13)
        Me.SerialNumberLabel1.TabIndex = 13
        Me.SerialNumberLabel1.Text = "SERIAL NUMBER:"
        '
        'ICCIDlabel1
        '
        Me.ICCIDlabel1.AutoSize = True
        Me.ICCIDlabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICCIDlabel1.Location = New System.Drawing.Point(292, 125)
        Me.ICCIDlabel1.Name = "ICCIDlabel1"
        Me.ICCIDlabel1.Size = New System.Drawing.Size(44, 13)
        Me.ICCIDlabel1.TabIndex = 14
        Me.ICCIDlabel1.Text = "ICCID:"
        '
        'IMEItextBox1
        '
        Me.IMEItextBox1.Location = New System.Drawing.Point(335, 43)
        Me.IMEItextBox1.Name = "IMEItextBox1"
        Me.IMEItextBox1.Size = New System.Drawing.Size(259, 20)
        Me.IMEItextBox1.TabIndex = 15
        '
        'MacAddresstextBox1
        '
        Me.MacAddresstextBox1.Location = New System.Drawing.Point(399, 68)
        Me.MacAddresstextBox1.Name = "MacAddresstextBox1"
        Me.MacAddresstextBox1.Size = New System.Drawing.Size(195, 20)
        Me.MacAddresstextBox1.TabIndex = 16
        '
        'SerialNumTextBox1
        '
        Me.SerialNumTextBox1.Location = New System.Drawing.Point(411, 95)
        Me.SerialNumTextBox1.Name = "SerialNumTextBox1"
        Me.SerialNumTextBox1.Size = New System.Drawing.Size(183, 20)
        Me.SerialNumTextBox1.TabIndex = 17
        '
        'ICCIDtextBox1
        '
        Me.ICCIDtextBox1.Location = New System.Drawing.Point(342, 122)
        Me.ICCIDtextBox1.Name = "ICCIDtextBox1"
        Me.ICCIDtextBox1.Size = New System.Drawing.Size(252, 20)
        Me.ICCIDtextBox1.TabIndex = 18
        '
        'RunCustomBTN1
        '
        Me.RunCustomBTN1.Location = New System.Drawing.Point(335, 210)
        Me.RunCustomBTN1.Name = "RunCustomBTN1"
        Me.RunCustomBTN1.Size = New System.Drawing.Size(208, 23)
        Me.RunCustomBTN1.TabIndex = 19
        Me.RunCustomBTN1.Text = "Run Custom ADB Command"
        Me.RunCustomBTN1.UseVisualStyleBackColor = True
        '
        'adbCommandText1
        '
        Me.adbCommandText1.Location = New System.Drawing.Point(297, 184)
        Me.adbCommandText1.Name = "adbCommandText1"
        Me.adbCommandText1.Size = New System.Drawing.Size(297, 20)
        Me.adbCommandText1.TabIndex = 20
        '
        'CustomCommandMakeLabel1
        '
        Me.CustomCommandMakeLabel1.AutoSize = True
        Me.CustomCommandMakeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomCommandMakeLabel1.Location = New System.Drawing.Point(336, 165)
        Me.CustomCommandMakeLabel1.Name = "CustomCommandMakeLabel1"
        Me.CustomCommandMakeLabel1.Size = New System.Drawing.Size(207, 16)
        Me.CustomCommandMakeLabel1.TabIndex = 21
        Me.CustomCommandMakeLabel1.Text = "Enter Custom ADB Command"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "***********************************************************"
        '
        'RebootBtn1
        '
        Me.RebootBtn1.Location = New System.Drawing.Point(160, 290)
        Me.RebootBtn1.Name = "RebootBtn1"
        Me.RebootBtn1.Size = New System.Drawing.Size(126, 23)
        Me.RebootBtn1.TabIndex = 23
        Me.RebootBtn1.Text = "Reboot Device"
        Me.RebootBtn1.UseVisualStyleBackColor = True
        '
        'RebootFastBootBtn1
        '
        Me.RebootFastBootBtn1.Location = New System.Drawing.Point(160, 320)
        Me.RebootFastBootBtn1.Name = "RebootFastBootBtn1"
        Me.RebootFastBootBtn1.Size = New System.Drawing.Size(126, 23)
        Me.RebootFastBootBtn1.TabIndex = 24
        Me.RebootFastBootBtn1.Text = "Reboot to Fastboot"
        Me.RebootFastBootBtn1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "***********************************************************"
        '
        'FastBootCommandlabel1
        '
        Me.FastBootCommandlabel1.AutoSize = True
        Me.FastBootCommandlabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastBootCommandlabel1.Location = New System.Drawing.Point(320, 260)
        Me.FastBootCommandlabel1.Name = "FastBootCommandlabel1"
        Me.FastBootCommandlabel1.Size = New System.Drawing.Size(238, 16)
        Me.FastBootCommandlabel1.TabIndex = 26
        Me.FastBootCommandlabel1.Text = "Enter Custom FastBoot Command"
        '
        'fastbootCommandText1
        '
        Me.fastbootCommandText1.Location = New System.Drawing.Point(297, 279)
        Me.fastbootCommandText1.Name = "fastbootCommandText1"
        Me.fastbootCommandText1.Size = New System.Drawing.Size(297, 20)
        Me.fastbootCommandText1.TabIndex = 27
        '
        'RunCustomFastBootBtn1
        '
        Me.RunCustomFastBootBtn1.Location = New System.Drawing.Point(335, 305)
        Me.RunCustomFastBootBtn1.Name = "RunCustomFastBootBtn1"
        Me.RunCustomFastBootBtn1.Size = New System.Drawing.Size(208, 23)
        Me.RunCustomFastBootBtn1.TabIndex = 28
        Me.RunCustomFastBootBtn1.Text = "Run Custom FastBoot Command"
        Me.RunCustomFastBootBtn1.UseVisualStyleBackColor = True
        '
        'RebootRecoveryBTN1
        '
        Me.RebootRecoveryBTN1.Location = New System.Drawing.Point(160, 350)
        Me.RebootRecoveryBTN1.Name = "RebootRecoveryBTN1"
        Me.RebootRecoveryBTN1.Size = New System.Drawing.Size(126, 23)
        Me.RebootRecoveryBTN1.TabIndex = 29
        Me.RebootRecoveryBTN1.Text = "Reboot to Recovery"
        Me.RebootRecoveryBTN1.UseVisualStyleBackColor = True
        '
        'BroswerForAPKBtn
        '
        Me.BroswerForAPKBtn.Location = New System.Drawing.Point(296, 347)
        Me.BroswerForAPKBtn.Name = "BroswerForAPKBtn"
        Me.BroswerForAPKBtn.Size = New System.Drawing.Size(88, 23)
        Me.BroswerForAPKBtn.TabIndex = 30
        Me.BroswerForAPKBtn.Text = "Select APK File"
        Me.BroswerForAPKBtn.UseVisualStyleBackColor = True
        '
        'APKpathTextBox
        '
        Me.APKpathTextBox.Location = New System.Drawing.Point(390, 348)
        Me.APKpathTextBox.Name = "APKpathTextBox"
        Me.APKpathTextBox.ReadOnly = True
        Me.APKpathTextBox.Size = New System.Drawing.Size(204, 20)
        Me.APKpathTextBox.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "************************************************************"
        '
        'installBtn1
        '
        Me.installBtn1.Location = New System.Drawing.Point(335, 377)
        Me.installBtn1.Name = "installBtn1"
        Me.installBtn1.Size = New System.Drawing.Size(208, 23)
        Me.installBtn1.TabIndex = 33
        Me.installBtn1.Text = "Install APK To Device"
        Me.installBtn1.UseVisualStyleBackColor = True
        '
        'PointADBbtn
        '
        Me.PointADBbtn.Location = New System.Drawing.Point(13, 380)
        Me.PointADBbtn.Name = "PointADBbtn"
        Me.PointADBbtn.Size = New System.Drawing.Size(157, 23)
        Me.PointADBbtn.TabIndex = 34
        Me.PointADBbtn.Text = "Set Different ADB Directory"
        Me.PointADBbtn.UseVisualStyleBackColor = True
        '
        'StartADBbtn
        '
        Me.StartADBbtn.Location = New System.Drawing.Point(13, 410)
        Me.StartADBbtn.Name = "StartADBbtn"
        Me.StartADBbtn.Size = New System.Drawing.Size(75, 23)
        Me.StartADBbtn.TabIndex = 35
        Me.StartADBbtn.Text = "Start ADB"
        Me.StartADBbtn.UseVisualStyleBackColor = True
        '
        'KillADBbtn
        '
        Me.KillADBbtn.Location = New System.Drawing.Point(95, 410)
        Me.KillADBbtn.Name = "KillADBbtn"
        Me.KillADBbtn.Size = New System.Drawing.Size(75, 23)
        Me.KillADBbtn.TabIndex = 36
        Me.KillADBbtn.Text = "Kill ADB"
        Me.KillADBbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 442)
        Me.Controls.Add(Me.KillADBbtn)
        Me.Controls.Add(Me.StartADBbtn)
        Me.Controls.Add(Me.PointADBbtn)
        Me.Controls.Add(Me.installBtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.APKpathTextBox)
        Me.Controls.Add(Me.BroswerForAPKBtn)
        Me.Controls.Add(Me.RebootRecoveryBTN1)
        Me.Controls.Add(Me.RunCustomFastBootBtn1)
        Me.Controls.Add(Me.fastbootCommandText1)
        Me.Controls.Add(Me.FastBootCommandlabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RebootFastBootBtn1)
        Me.Controls.Add(Me.RebootBtn1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustomCommandMakeLabel1)
        Me.Controls.Add(Me.adbCommandText1)
        Me.Controls.Add(Me.RunCustomBTN1)
        Me.Controls.Add(Me.ICCIDtextBox1)
        Me.Controls.Add(Me.SerialNumTextBox1)
        Me.Controls.Add(Me.MacAddresstextBox1)
        Me.Controls.Add(Me.IMEItextBox1)
        Me.Controls.Add(Me.ICCIDlabel1)
        Me.Controls.Add(Me.SerialNumberLabel1)
        Me.Controls.Add(Me.MacAddressLabel1)
        Me.Controls.Add(Me.SerialNumLabel1)
        Me.Controls.Add(Me.UpdaterBTN)
        Me.Controls.Add(Me.ExportTextBtn)
        Me.Controls.Add(Me.ExportSQLbtn1)
        Me.Controls.Add(Me.ExportExcelBTN)
        Me.Controls.Add(Me.PullICCIDbtn)
        Me.Controls.Add(Me.PullSerialNumBTN)
        Me.Controls.Add(Me.PullMACbtn)
        Me.Controls.Add(Me.GetIMEIbtn)
        Me.Controls.Add(Me.RestartADBbtn)
        Me.Controls.Add(Me.CheckConnBTN)
        Me.Controls.Add(Me.TopInfoBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ADB TOOL 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopInfoBox As TextBox
    Friend WithEvents CheckConnBTN As Button
    Friend WithEvents RestartADBbtn As Button
    Friend WithEvents GetIMEIbtn As Button
    Friend WithEvents PullMACbtn As Button
    Friend WithEvents PullSerialNumBTN As Button
    Friend WithEvents PullICCIDbtn As Button
    Friend WithEvents ExportExcelBTN As Button
    Friend WithEvents ExportSQLbtn1 As Button
    Friend WithEvents ExportTextBtn As Button
    Friend WithEvents UpdaterBTN As Button
    Friend WithEvents SerialNumLabel1 As Label
    Friend WithEvents MacAddressLabel1 As Label
    Friend WithEvents SerialNumberLabel1 As Label
    Friend WithEvents ICCIDlabel1 As Label
    Friend WithEvents IMEItextBox1 As TextBox
    Friend WithEvents MacAddresstextBox1 As TextBox
    Friend WithEvents SerialNumTextBox1 As TextBox
    Friend WithEvents ICCIDtextBox1 As TextBox
    Friend WithEvents RunCustomBTN1 As Button
    Friend WithEvents adbCommandText1 As TextBox
    Friend WithEvents CustomCommandMakeLabel1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RebootBtn1 As Button
    Friend WithEvents RebootFastBootBtn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FastBootCommandlabel1 As Label
    Friend WithEvents fastbootCommandText1 As TextBox
    Friend WithEvents RunCustomFastBootBtn1 As Button
    Friend WithEvents RebootRecoveryBTN1 As Button
    Friend WithEvents BroswerForAPKBtn As Button
    Friend WithEvents APKpathTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents installBtn1 As Button
    Friend WithEvents PointADBbtn As Button
    Friend WithEvents StartADBbtn As Button
    Friend WithEvents KillADBbtn As Button
End Class
