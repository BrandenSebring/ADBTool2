Imports Microsoft.Office.Interop
Public Class Form1
    Dim StoreInfo(0 To 3) As String
    Dim adbDirectory As String = "C:\Users\Branden\Desktop\adb"
    'Dim adbDirectory As String = System.Windows.Forms.Application.StartupPath


    Private Sub CheckConnBTN_Click(sender As Object, e As EventArgs) Handles CheckConnBTN.Click

        Try
            Dim chkConnStart As New Process
            chkConnStart.StartInfo.FileName = (adbDirectory + "\adb.exe")
            chkConnStart.StartInfo.Arguments = "devices"
            chkConnStart.StartInfo.UseShellExecute = False
            chkConnStart.StartInfo.RedirectStandardOutput = True
            chkConnStart.StartInfo.CreateNoWindow = True
            chkConnStart.Start()

            Dim readInfo() As String = chkConnStart.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln As String In readInfo
                TopInfoBox.AppendText(vbNewLine & ln)
                If ln.Reverse(1) = "e" Then
                    TopInfoBox.AppendText(vbNewLine & "***Device is Authenticated***")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error, Please Check ADB Location")
        End Try

    End Sub

    Private Sub RestartADBbtn_Click(sender As Object, e As EventArgs) Handles RestartADBbtn.Click
        TopInfoBox.AppendText(vbNewLine + "Restarting ADB Server, Please Wait")
        Try
            Dim restarterCom As New Process
            restarterCom.StartInfo.FileName = (adbDirectory + "\adb.exe")
            restarterCom.StartInfo.UseShellExecute = False
            restarterCom.StartInfo.RedirectStandardOutput = True
            restarterCom.StartInfo.CreateNoWindow = True
            restarterCom.StartInfo.Arguments = "kill-server"
            restarterCom.Start()

            restarterCom.StartInfo.Arguments = "devices"
            restarterCom.Start()

            Dim readInfo() As String = restarterCom.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln As String In readInfo
                TopInfoBox.AppendText(vbNewLine & ln)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub KillADBbtn_Click(sender As Object, e As EventArgs) Handles KillADBbtn.Click

        Try
            Dim killer1 As New Process
            killer1.StartInfo.FileName = (adbDirectory + "\adb.exe")
            killer1.StartInfo.Arguments = "kill-server"
            killer1.StartInfo.RedirectStandardOutput = True
            killer1.StartInfo.CreateNoWindow = True
            killer1.StartInfo.UseShellExecute = False
            killer1.Start()

        Catch ex As Exception

        End Try

        TopInfoBox.AppendText(vbNewLine + "ADB SERVER KILLED!!")

    End Sub

    Public Sub getMacAction()
        Dim dirtyMac As String = ""

        Try
            Dim getMac As New Process
            getMac.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getMac.StartInfo.Arguments = "shell ip addr show wlan0"
            getMac.StartInfo.UseShellExecute = False
            getMac.StartInfo.RedirectStandardOutput = True
            getMac.StartInfo.CreateNoWindow = True
            getMac.Start()

            Dim readinfo() As String = getMac.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln As String In readinfo
                If ln.Reverse(1) = "f" Then
                    dirtyMac = ln
                End If
            Next

            'Cleaning up Mac Address:
            dirtyMac = Trim(dirtyMac)
            Dim holderMac() As String = Split(dirtyMac)
            Dim cleaner111 As String = holderMac(1)
            cleaner111 = cleaner111.Replace(":", "")
            cleaner111 = cleaner111.ToUpper()
            StoreInfo(1) = cleaner111
        Catch ex As Exception

        End Try


    End Sub

    Public Sub getSerialNumAction()

        Dim dirtySerial As String = ""

        Try
            Dim getProp As New Process
            getProp.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getProp.StartInfo.Arguments = ("shell getprop")
            getProp.StartInfo.UseShellExecute = False
            getProp.StartInfo.RedirectStandardOutput = True
            getProp.StartInfo.CreateNoWindow = True
            getProp.Start()

            Dim readinfo() As String = getProp.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln2 As String In readinfo
                If ln2.Contains("[ro.boot.serialno]:") Then
                    dirtySerial = ln2
                End If
            Next

            dirtySerial = Trim(dirtySerial)
            Dim holderSerial() As String = Split(dirtySerial)
            Dim cleaner11 As String = holderSerial(1)
            cleaner11 = cleaner11.Replace("[", "")
            cleaner11 = cleaner11.Replace("]", "")
            cleaner11 = cleaner11.ToUpper()
            cleaner11 = RTrim(cleaner11)
            cleaner11 = LTrim(cleaner11)
            StoreInfo(0) = cleaner11
        Catch ex As Exception

        End Try

    End Sub

    Public Sub getIMEIaction()

        Dim starter As Integer = 0
        Dim storers(0 To 4) As String
        Dim args1 As String = "shell service call iphonesubinfo 1"
        Try
            Dim getIMEI As New Process
            getIMEI.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getIMEI.StartInfo.Arguments = args1
            getIMEI.StartInfo.RedirectStandardOutput = True
            getIMEI.StartInfo.UseShellExecute = False
            getIMEI.StartInfo.CreateNoWindow = True
            getIMEI.Start()

            Dim readinfo() As String = getIMEI.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            While starter < 4

                For Each ln As String In readinfo
                    'TopInfoBox.AppendText(vbNewLine + vbNewLine + ln)
                    storers(starter) = ln
                    starter += 1
                Next
            End While

            Dim cleaner1() As String = Split(storers(1), "'")
            Dim cleaner2() As String = Split(storers(2), "'")
            Dim cleaner3() As String = Split(storers(3), "'")

            Dim cleanIMEIp1 As String = cleaner1(1)
            Dim cleanIMEIp2 As String = cleaner2(1)
            Dim cleanIMEIp3 As String = cleaner3(1)
            cleanIMEIp1 = cleanIMEIp1.Replace(".", "")
            cleanIMEIp2 = cleanIMEIp2.Replace(".", "")
            cleanIMEIp3 = cleanIMEIp3.Replace(".", "")

            Dim theIMEIclean = cleanIMEIp1 + cleanIMEIp2 + cleanIMEIp3
            theIMEIclean = RTrim(theIMEIclean)
            StoreInfo(2) = theIMEIclean

        Catch ex As Exception

        End Try

    End Sub

    Public Sub getICCIDaction()
        Dim keepers(0 To 6) As String
        Dim argumentative As String = "shell service call iphonesubinfo 12"
        Try
            Dim counterstarter As Integer = 0

            Dim getICCID As New Process
            getICCID.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getICCID.StartInfo.Arguments = (argumentative)
            getICCID.StartInfo.UseShellExecute = False
            getICCID.StartInfo.RedirectStandardOutput = True
            getICCID.StartInfo.CreateNoWindow = True
            getICCID.Start()

            Dim readinfo6() As String = getICCID.StandardOutput.ReadToEnd.Split(CChar(vbLf))

            While counterstarter < 5

                For Each ln As String In readinfo6
                    keepers(counterstarter) = Trim(ln)
                    counterstarter += 1
                Next
            End While

            Dim cleanerP1() As String = Split(keepers(1))
            Dim cleanerP2() As String = Split(keepers(2))
            Dim cleanerP3() As String = Split(keepers(3))

            Dim cleansplitP1 = cleanerP1(5)
            Dim cleansplitP2 = cleanerP2(5)
            Dim cleansplitP3 = cleanerP3(5)

            Dim together As String = cleansplitP1 + cleansplitP2 + cleansplitP3
            together = together.Replace(".", "")
            together = together.Replace("'", "")

            StoreInfo(3) = together

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PullMACbtn_Click(sender As Object, e As EventArgs) Handles PullMACbtn.Click

        getMacAction()
        TopInfoBox.AppendText(vbNewLine & "Mac Address: " & StoreInfo(1))

    End Sub

    Private Sub PullSerialNumBTN_Click(sender As Object, e As EventArgs) Handles PullSerialNumBTN.Click

        getSerialNumAction()
        TopInfoBox.AppendText(vbNewLine & "Serial Number: " & StoreInfo(0))
    End Sub

    Private Sub GetIMEIbtn_Click(sender As Object, e As EventArgs) Handles GetIMEIbtn.Click

        getIMEIaction()
        TopInfoBox.AppendText(vbNewLine & "IMEI: " & StoreInfo(2))
    End Sub

    Private Sub PullICCIDbtn_Click(sender As Object, e As EventArgs) Handles PullICCIDbtn.Click

        getICCIDaction()
        TopInfoBox.AppendText(vbNewLine & "ICCID: " & StoreInfo(3))
    End Sub

    Private Sub UpdaterBTN_Click(sender As Object, e As EventArgs) Handles UpdaterBTN.Click
        getMacAction()
        getSerialNumAction()
        getIMEIaction()
        getICCIDaction()
        IMEItextBox1.Text = StoreInfo(2)
        MacAddresstextBox1.Text = StoreInfo(1)
        SerialNumTextBox1.Text = StoreInfo(0)
        ICCIDtextBox1.Text = StoreInfo(3)
    End Sub

    Dim excelLocalPath As String
    Private Sub ExportExcelBTN_Click(sender As Object, e As EventArgs) Handles ExportExcelBTN.Click
        If String.IsNullOrEmpty(excelLocalPath) Then
            Using browserThing As New OpenFileDialog
                If browserThing.ShowDialog() <> DialogResult.OK Then Return
                excelLocalPath = browserThing.FileName
            End Using
        End If

        Try
            Dim excelApp As Excel.Application = New Excel.Application()
            Dim excelBook As Excel.Workbook

            excelBook = excelApp.Workbooks.Open(excelLocalPath, 0, False, 5, System.Reflection.Missing.Value, System.Reflection.Missing.Value, False, System.Reflection.Missing.Value, System.Reflection.Missing.Value, True, False, System.Reflection.Missing.Value, False)

            Dim excelSheets As Excel.Sheets = excelBook.Sheets
            Dim excelSheet As Excel.Worksheet = excelSheets(1)
            Dim excelRange As Excel.Range = excelSheet.UsedRange

            excelRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Activate()
            Dim intNewRow As Int32 = excelApp.ActiveCell.Row + 1
            Dim strNewCellSerial As String = "A" & intNewRow
            Dim strNewCellIMEI As String = "B" & intNewRow
            Dim StrNewCellMAC As String = "C" & intNewRow
            Dim strNewCellICCID As String = "D" & intNewRow

            excelSheet.Range(strNewCellSerial).Value = StoreInfo(0)
            excelSheet.Range(strNewCellIMEI).Value = StoreInfo(2)
            excelSheet.Range(StrNewCellMAC).Value = StoreInfo(1)
            excelSheet.Range(strNewCellICCID).Value = StoreInfo(3)

            excelBook.Save()
            excelBook.Close()
            excelApp.Quit()

            TopInfoBox.AppendText(vbNewLine & "Information has been Written to Excel" & vbNewLine & "At " & excelLocalPath)
        Catch
            MessageBox.Show("Error")
        End Try
    End Sub

    Dim txtSaveLocation As String
    Private Sub ExportTextBtn_Click(sender As Object, e As EventArgs) Handles ExportTextBtn.Click

        If String.IsNullOrEmpty(txtSaveLocation) Then
            Using browserThing As New OpenFileDialog
                If browserThing.ShowDialog() <> DialogResult.OK Then Return
                txtSaveLocation = browserThing.FileName
            End Using
        End If

        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(txtSaveLocation, True)
            file.WriteLine("Serial Number: " & StoreInfo(0))
            file.WriteLine("IMEI: " & StoreInfo(2))
            file.WriteLine("MAC: " & StoreInfo(1))
            file.WriteLine("ICCID: " & StoreInfo(3))
            file.Close()

            TopInfoBox.AppendText("Exported to text file located at: " & vbNewLine & txtSaveLocation)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RebootBtn1_Click(sender As Object, e As EventArgs) Handles RebootBtn1.Click

        Dim rebootPhone As New Process
        rebootPhone.StartInfo.FileName = (adbDirectory + "\adb.exe")
        rebootPhone.StartInfo.Arguments = "reboot"
        rebootPhone.StartInfo.UseShellExecute = False
        rebootPhone.StartInfo.CreateNoWindow = True
        rebootPhone.StartInfo.RedirectStandardOutput = True
        rebootPhone.Start()

        TopInfoBox.AppendText("A reboot Command has been sent to the device")

    End Sub

    Private Sub RebootFastBootBtn1_Click(sender As Object, e As EventArgs) Handles RebootFastBootBtn1.Click

        Dim fastbootReboot As New Process
        fastbootReboot.StartInfo.FileName = (adbDirectory + "\adb.exe")
        fastbootReboot.StartInfo.Arguments = "reboot bootloader"
        fastbootReboot.StartInfo.UseShellExecute = False
        fastbootReboot.StartInfo.CreateNoWindow = True
        fastbootReboot.StartInfo.RedirectStandardOutput = True
        fastbootReboot.Start()

        TopInfoBox.AppendText("A Request to Reboot into FASTBOOT has been sent to the device")

    End Sub

    Private Sub RebootRecoveryBTN1_Click(sender As Object, e As EventArgs) Handles RebootRecoveryBTN1.Click

        Dim recoveryReboot As New Process
        recoveryReboot.StartInfo.FileName = (adbDirectory + "\adb.exe")
        recoveryReboot.StartInfo.Arguments = "reboot recovery"
        recoveryReboot.StartInfo.UseShellExecute = False
        recoveryReboot.StartInfo.CreateNoWindow = True
        recoveryReboot.StartInfo.RedirectStandardOutput = True
        recoveryReboot.Start()

        TopInfoBox.AppendText("A Reqest to Reboot into Recovery has been sent to the device")

    End Sub

    Private Sub SuperReboot_Click(sender As Object, e As EventArgs) Handles SuperReboot.Click

        Dim superADBkiller As New Process
        superADBkiller.StartInfo.FileName = (adbDirectory + "\adb.exe")
        superADBkiller.StartInfo.Arguments = "reboot"
        superADBkiller.StartInfo.UseShellExecute = False
        superADBkiller.StartInfo.CreateNoWindow = True
        superADBkiller.StartInfo.RedirectStandardOutput = True
        superADBkiller.Start()

        Dim superFastBootkiller As New Process
        superFastBootkiller.StartInfo.FileName = (adbDirectory + "\fastboot.exe")
        superFastBootkiller.StartInfo.Arguments = "reboot"
        superFastBootkiller.StartInfo.UseShellExecute = False
        superFastBootkiller.StartInfo.CreateNoWindow = True
        superFastBootkiller.StartInfo.RedirectStandardOutput = True
        superFastBootkiller.Start()

    End Sub

    Private Sub RunCustomBTN1_Click(sender As Object, e As EventArgs) Handles RunCustomBTN1.Click

        Try
            Dim argu1 As String = (" " + adbCommandText1.Text)
            TopInfoBox.AppendText(argu1)
            Dim customCommand1 As New Process
            customCommand1.StartInfo.FileName = (adbDirectory + "\adb.exe")
            customCommand1.StartInfo.UseShellExecute = False
            customCommand1.StartInfo.CreateNoWindow = True
            customCommand1.StartInfo.RedirectStandardOutput = True
            customCommand1.StartInfo.Arguments = argu1
            customCommand1.Start()

            Dim reader() As String = customCommand1.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln In reader
                TopInfoBox.AppendText(vbNewLine & ln)
            Next
        Catch ex As Exception
            MessageBox.Show("Error has occured", "Experimental")
        End Try
    End Sub

    Private Sub RunCustomFastBootBtn1_Click(sender As Object, e As EventArgs) Handles RunCustomFastBootBtn1.Click

        Try
            Dim argu2 As String = (" " + fastbootCommandText1.Text)
            TopInfoBox.AppendText(argu2)

            Dim customCommand2 As New Process
            customCommand2.StartInfo.FileName = (adbDirectory + "\fastboot.exe")
            customCommand2.StartInfo.UseShellExecute = False
            customCommand2.StartInfo.CreateNoWindow = True
            customCommand2.StartInfo.RedirectStandardOutput = True
            customCommand2.StartInfo.Arguments = argu2
            customCommand2.Start()

            Dim reader() As String = customCommand2.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln In reader
                TopInfoBox.AppendText(vbNewLine & ln)
            Next

        Catch ex As Exception
            MessageBox.Show("Error has occured", "Experimental")
        End Try


    End Sub
    Dim apkFileLocation As String
    Private Sub InstallBtn1_Click(sender As Object, e As EventArgs) Handles installBtn1.Click

        Dim argu3 As String = ("install " + apkFileLocation)

        Dim installAPK As New Process
        installAPK.StartInfo.FileName = (adbDirectory + "\adb.exe")
        installAPK.StartInfo.UseShellExecute = False
        installAPK.StartInfo.CreateNoWindow = True
        installAPK.StartInfo.RedirectStandardOutput = True
        installAPK.StartInfo.Arguments = argu3
        installAPK.Start()

        Dim reader() As String = installAPK.StandardOutput.ReadToEnd.Split(CChar(vbLf))
        For Each ln In reader
            TopInfoBox.AppendText(vbNewLine & ln)
        Next

    End Sub

    Private Sub BroswerForAPKBtn_Click(sender As Object, e As EventArgs) Handles BroswerForAPKBtn.Click
        Using browseThing As New OpenFileDialog
            browseThing.Filter() = ".apk files (*.apk)|*.apk|All files (*.*)|*.*"
            If browseThing.ShowDialog() <> DialogResult.OK Then Return
            apkFileLocation = browseThing.FileName
        End Using
        TopInfoBox.AppendText(vbNewLine & "File Selected for Install: " & apkFileLocation & vbNewLine & "Click Install APK to Proceed")
        APKpathTextBox.AppendText(apkFileLocation)

    End Sub
End Class
