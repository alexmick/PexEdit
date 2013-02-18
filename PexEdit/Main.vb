Imports System.IO

Public Class Main
    Const ver As String = "v0.1"
    Public appdir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & Path.DirectorySeparatorChar & "PexEdit"
    Public openfile As String
    Public wasnew As Boolean
    Public saveOK As Boolean
    Public lines() As String
    Public groupslist As New List(Of Group)
    Public userslist As New List(Of User)
    Public tabstring As String
    Public currentgroup As Group
    Public currentuser As User
    Public currentworld As World
    Public optionsuggest As New List(Of String)
    Public permsuggest As New List(Of String)
    Public justselect As Boolean = False
    Public waitHandle As Threading.AutoResetEvent = New Threading.AutoResetEvent(False)


    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        If Not (Directory.Exists(appdir)) Then
            Directory.CreateDirectory(appdir)
        End If
        If Not (Directory.Exists(appdir & Path.DirectorySeparatorChar & "temp")) Then
            Directory.CreateDirectory(appdir & Path.DirectorySeparatorChar & "temp")
        End If
        For i As Integer = 1 To My.Settings.tablength
            tabstring = tabstring & " "
        Next
        'Restore after crash section
        If File.Exists(appdir & Path.DirectorySeparatorChar & "perms.yml") Then
            If MsgBox("PexEdit seems to have been forced to exit last time" & vbCrLf & "Would you like to restore the file you were editing at the time?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Restore from error") = MsgBoxResult.Yes Then
                File.Move(appdir & Path.DirectorySeparatorChar & "perms.yml", appdir & Path.DirectorySeparatorChar & "restore.yml")
                fileopen(appdir & Path.DirectorySeparatorChar & "restore.yml", False)
                Me.StatusLabel1.Text = "File succesfully restored - Happy editing!"
            Else
                delfiles()
                Me.StatusLabel1.Text = "File not restored - Please use the file menu to start"
            End If
        Else
            Me.StatusLabel1.Text = "Welcome to PexEdit " & ver & " - Please use the file menu to start"
        End If
        refreshrecentfiles()
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim nwarn As Integer
        If File.Exists(appdir & Path.DirectorySeparatorChar & "perms.yml") Then
            If File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "perms.yml") > File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
                nwarn = MsgBox("Do you want to save before exiting?", CType(vbYesNoCancel + vbQuestion, MsgBoxStyle), "Warning")
                Select Case nwarn
                    Case 7
                        'if no is cliked
                        delfiles()
                    Case 6
                        'if yes is clicked
                        Me.SaveToolStripMenuItem_Click(sender, e)
                        If saveOK = True Then
                            delfiles()
                        Else
                            e.Cancel = True
                        End If
                    Case 2
                        'if cancel is clicked
                        e.Cancel = True
                End Select
            Else
                delfiles()
            End If
        Else
            delfiles()
        End If
        My.Settings.Save()
    End Sub


#Region "Menu items"

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.fileopen(OpenFileDialog1.FileName, False)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim nwarn As Integer
        If File.Exists(appdir & Path.DirectorySeparatorChar & "perms.yml") Then
            If File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "perms.yml") > File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
                nwarn = MsgBox("Do you want to save before opening a file?", CType(vbYesNoCancel + vbDefaultButton3 + vbQuestion, MsgBoxStyle), "Warning")
                If nwarn = 7 Then
                    'if no is clicked
                    File.Delete(appdir & Path.DirectorySeparatorChar & "perms.yml")
                    OpenFileDialog1.ShowDialog()
                ElseIf nwarn = 6 Then
                    'if yes is clicked
                    SaveToolStripMenuItem_Click(sender, e)
                    If saveOK = True Then
                        OpenFileDialog1.ShowDialog()
                    End If
                End If
            Else
                OpenFileDialog1.ShowDialog()
            End If
        Else
            OpenFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim nwarn As Integer
        If File.Exists(appdir & Path.DirectorySeparatorChar & "perms.yml") Then
            If File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "perms.yml") > File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
                nwarn = MsgBox("Do you want to save before creating a new file?", CType(vbYesNoCancel + vbDefaultButton3 + vbQuestion, MsgBoxStyle), "Warning")
                If nwarn = 6 Then
                    Me.SaveAsToolStripMenuItem_Click(sender, e)
                    If saveOK = True Then
                        fileopen("untitled.yml", True)
                    End If
                ElseIf nwarn = 7 Then
                    'if no is clicked
                    fileopen("untitled.yml", True)
                End If
            Else
                fileopen("untitled.yml", True)
            End If
        Else
            fileopen("untitled.yml", True)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "perms.yml") > File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
            If BckGrndWrkWritetofile.IsBusy Then
                waitHandle.WaitOne()
            End If
            If wasnew = True Or openfile = appdir & Path.DirectorySeparatorChar & "restore.yml" Then
                saveOK = False
                SaveFileDialog1.ShowDialog()
                If saveOK = True Then
                    Me.Text = "PexEdit - " & SaveFileDialog1.FileName
                    StatusLabel1.Text = "File saved as: " & SaveFileDialog1.FileName
                End If
            Else
                File.Delete(openfile)
                File.Copy(appdir & Path.DirectorySeparatorChar & "perms.yml", openfile)
                File.Delete(appdir & Path.DirectorySeparatorChar & "lastsave.yml")
                File.Copy(appdir & Path.DirectorySeparatorChar & "perms.yml", appdir & Path.DirectorySeparatorChar & "lastsave.yml")
                saveOK = True
                StatusLabel1.Text = "File saved"
            End If
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "perms.yml") > File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
            waitHandle.WaitOne()
        End If
        saveOK = False
        SaveFileDialog1.ShowDialog()
        If saveOK = True Then
            Me.Text = "PexEdit - " & SaveFileDialog1.FileName
            StatusLabel1.Text = "File saved as: " & SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If File.Exists(SaveFileDialog1.FileName) Then
            File.Delete(SaveFileDialog1.FileName)
        End If
        File.Copy(appdir & Path.DirectorySeparatorChar & "perms.yml", SaveFileDialog1.FileName)
        File.Delete(appdir & Path.DirectorySeparatorChar & "lastsave.yml")
        File.Copy(appdir & Path.DirectorySeparatorChar & "perms.yml", appdir & Path.DirectorySeparatorChar & "lastsave.yml")
        wasnew = False
        saveOK = True
    End Sub

    Private Sub RecentFilesToolStripMenuItem_DropDownItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles RecentFilesToolStripMenuItem.DropDownItemClicked
        If File.Exists(e.ClickedItem.Text) Then
            If File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "perms.yml") > File.GetLastWriteTime(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
                Select Case MsgBox("Do you want to save before opening " & e.ClickedItem.Text.Split(Path.DirectorySeparatorChar)(e.ClickedItem.Text.Split(Path.DirectorySeparatorChar).Length - 1) & " ?", CType(vbYesNoCancel + vbDefaultButton3 + vbQuestion, MsgBoxStyle), "Warning")
                    Case CType(6, MsgBoxResult)
                        Me.SaveAsToolStripMenuItem_Click(sender, e)
                        If saveOK = True Then
                            fileopen(e.ClickedItem.Text, False)
                        End If
                    Case CType(7, MsgBoxResult)
                        'if no is clicked
                        fileopen(e.ClickedItem.Text, False)
                End Select
            Else
                fileopen(e.ClickedItem.Text, False)
            End If
        Else
            MsgBox("This file no longer exists at that location...", MsgBoxStyle.Information, "Error")
            RecentFilesToolStripMenuItem.DropDownItems.Remove(e.ClickedItem)
        End If
    End Sub

    Private Sub ClrHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClrHistoryToolStripMenuItem.Click
        My.Settings.recentfiles.Clear()
        My.Settings.recentfiles.Add("SOF")
        RecentFilesToolStripMenuItem.DropDownItems.Clear()
        Me.StatusLabel1.Text = "Cleared history of recent files"
    End Sub
    Private Sub RefreshAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshAllToolStripMenuItem.Click
        If BckGrndWrkWritetofile.IsBusy Then
            waitHandle.WaitOne()
        End If
        TabControlGroups.SelectTab(0)
        userslist.Clear()
        groupslist.Clear()
        ComboPermWorld.Items.Clear()
        ComboInheritsName.Items.Clear()
        ComboNewWorldName.Items.Clear()
        ComboUNewWorldName.Items.Clear()
        ComboRnkLaddr.Items.Clear()
        parsefile()
        sortlists()
        populatetreeview(1)
        populatetreeview(2)
        StatusProgressBar1.Value = StatusProgressBar1.Maximum
        StatusLabel1.Text = "All the file has been read, please report any bugs with the help menu"
    End Sub
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Dim temppath As String = appdir + Path.DirectorySeparatorChar + "temp" + Path.DirectorySeparatorChar
        If File.Exists(temppath + "1.yml.undo") Then
            For i As Integer = My.Settings.maxundoes - 1 To 1 Step -1
                If File.Exists(temppath + CStr(i) + ".yml.redo") Then
                    File.Move(temppath + CStr(i) + ".yml.redo", temppath + CStr(i + 1) + ".yml.redo")
                End If
            Next
            File.Move(appdir + Path.DirectorySeparatorChar + "perms.yml", temppath + "1.yml.redo")
            File.Move(temppath + "1.yml.undo", appdir + Path.DirectorySeparatorChar + "perms.yml")
            For i As Integer = 2 To My.Settings.maxundoes
                If File.Exists(temppath + CStr(i) + ".yml.undo") Then
                    File.Move(temppath + CStr(i) + ".yml.undo", temppath + CStr(i - 1) + ".yml.undo")
                End If
            Next
            StatusLabel1.Text = "Last change undone"
        End If
        'testing
        Dim node As Integer
        node = TreeViewG.SelectedNode.Index
        TabControlGroups.SelectTab(0)
        userslist.Clear()
        groupslist.Clear()
        ComboPermWorld.Items.Clear()
        ComboInheritsName.Items.Clear()
        ComboNewWorldName.Items.Clear()
        ComboUNewWorldName.Items.Clear()
        parsefile()
        sortlists()
        populatetreeview(1)
        populatetreeview(2)
        StatusProgressBar1.Value = StatusProgressBar1.Maximum
        TreeViewG.SelectedNode() = TreeViewG.Nodes(node)
        RedoToolStripMenuItem.Enabled = True
        If Not File.Exists(temppath + "1.yml.undo") Then
            UndoToolStripMenuItem.Enabled = False
            If File.Exists(temppath + "5.yml.redo") Then
                StatusLabel1.Text = StatusLabel1.Text + "Sorry you have reached " + CStr(My.Settings.maxundoes) + " undoes ... Look in the settings to change this number for next time"
            End If
        End If
    End Sub
    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Dim temppath As String = appdir + Path.DirectorySeparatorChar + "temp" + Path.DirectorySeparatorChar
        If File.Exists(temppath + "1.yml.redo") Then
            For i As Integer = My.Settings.maxundoes - 1 To 1 Step -1
                If File.Exists(temppath + CStr(i) + ".yml.undo") Then
                    File.Move(temppath + CStr(i) + ".yml.undo", temppath + CStr(i + 1) + ".yml.undo")
                End If
            Next
            File.Move(appdir + Path.DirectorySeparatorChar + "perms.yml", temppath + "1.yml.undo")
            File.Move(temppath + "1.yml.redo", appdir + Path.DirectorySeparatorChar + "perms.yml")
            For i As Integer = 2 To My.Settings.maxundoes
                If File.Exists(temppath + CStr(i) + ".yml.redo") Then
                    File.Move(temppath + CStr(i) + ".yml.redo", temppath + CStr(i - 1) + ".yml.redo")
                End If
            Next
            StatusLabel1.Text = "Last change redone"
        End If
        TabControlGroups.SelectTab(0)
        userslist.Clear()
        groupslist.Clear()
        ComboPermWorld.Items.Clear()
        ComboInheritsName.Items.Clear()
        ComboNewWorldName.Items.Clear()
        ComboUNewWorldName.Items.Clear()
        ComboRnkLaddr.Items.Clear()
        parsefile()
        sortlists()
        populatetreeview(1)
        populatetreeview(2)
        StatusProgressBar1.Value = StatusProgressBar1.Maximum
        UndoToolStripMenuItem.Enabled = True
        If Not File.Exists(temppath + "1.yml.redo") Then
            RedoToolStripMenuItem.Enabled = False
        End If
    End Sub
#End Region
#Region "GroupSubTabs"
    Private Sub TreeViewG_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewG.AfterSelect
        If justselect = False Then   ' just select test if we are changing tree selection because of a tab change or because of a click in the tree
            For Each scangroup In groupslist
                If scangroup.name = TreeViewG.SelectedNode.FullPath.Split(CChar("/"))(0) Then
                    currentgroup = scangroup
                End If
            Next
            TxtBxGroupname.Text = currentgroup.name
            ChckBxDefault.Checked = currentgroup.isdefault
            LstBxPrefixWorlds.Items.Clear()
            LstBxGroupInherit.Items.Clear()
            LstVwGrpOptions.Items.Clear()
            ComboPermWorld.Items.Clear()
            For Each scanworld As World In currentgroup.getworlds
                LstBxPrefixWorlds.Items.Add(scanworld.name)
                ComboPermWorld.Items.Add(scanworld.name)
            Next
            For Each scaninherit In currentgroup.inheritsfrom
                LstBxGroupInherit.Items.Add(scaninherit)
            Next
            Dim TempStr(1) As String
            For Each scanoption In currentgroup.getoptions
                TempStr(0) = scanoption.text
                TempStr(1) = scanoption.value
                LstVwGrpOptions.Items.Add(New ListViewItem(TempStr))
            Next
            refreshprefixtab()
            refreshpermtab()

            'Handle where the treenode was clicked
            Select Case TreeViewG.SelectedNode.Level
                Case 0
                    TabControlGroups.SelectTab(1)
                Case 1
                    Select Case TreeViewG.SelectedNode.Name
                        Case "prefix"
                            TabControlGroups.SelectTab(2)
                        Case "permissions"
                            TabControlGroups.SelectTab(3)
                        Case "isdefault", "inheritance", "options"
                            TabControlGroups.SelectTab(1)
                    End Select
                Case 2
                    Select Case TreeViewG.SelectedNode.Parent.Name
                        Case "prefix"
                            TabControlGroups.SelectTab(2)
                            LstBxPrefixWorlds.SelectedIndex = TreeViewG.SelectedNode.Index
                        Case "permissions"
                            TabControlGroups.SelectTab(3)
                            ComboPermWorld.SelectedItem = TreeViewG.SelectedNode.Name
                        Case "isdefault"
                            TabControlGroups.SelectTab(1)
                        Case "inheritance"
                            TabControlGroups.SelectTab(1)
                            LstBxGroupInherit.SelectedItem = TreeViewG.SelectedNode.Name
                        Case "options"
                            TabControlGroups.SelectTab(1)
                            LstVwGrpOptions.Items(TreeViewG.SelectedNode.Index).Selected = True
                    End Select
                Case 3
                    TabControlGroups.SelectTab(3)
                    ComboPermWorld.SelectedItem = TreeViewG.SelectedNode.Parent.Name
                    LstVwGroupPerms.Items(TreeViewG.SelectedNode.Index).Selected = True
            End Select
        Else
            justselect = False
        End If
    End Sub
#Region "Actions Tab"
    Private Sub BtnNewGroup_Click(sender As System.Object, e As System.EventArgs) Handles BtnGroupNew.Click
        If ComboNewGroupName.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If ComboNewGroupName.Text.Contains(CChar(" ")) OrElse ComboNewGroupName.Text.Contains(CChar(":")) OrElse ComboNewGroupName.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(ComboNewGroupName.Text.Contains(" "), "spaces", "")) & CStr(IIf(ComboNewGroupName.Text.Contains(" ") And ComboNewGroupName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboNewGroupName.Text.Contains(":"), "colons", "")) & CStr(IIf(ComboNewGroupName.Text.Contains(":") And ComboNewGroupName.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(ComboNewGroupName.Text.Contains(" ") And ComboNewGroupName.Text.Contains(CChar("'")) And Not ComboNewGroupName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboNewGroupName.Text.Contains("'"), "apostrophes", "")) & " in group name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        For Each scangroup In groupslist
            If scangroup.name = ComboNewGroupName.Text Then
                TreeViewG.SelectedNode = TreeViewG.Nodes(scangroup.name)
                Exit Sub
            End If
        Next
        Dim gname As String = ComboNewGroupName.Text
        groupslist.Add(New Group(gname))
        StatusLabel1.Text = "Created new group: " & gname
        TreeViewG.Nodes.Add(gname, gname)
        TreeViewG.Nodes(gname).Nodes.Add("isdefault", "Default: False")
        TreeViewG.Nodes(gname).Nodes.Add("prefix", "Prefix(es)")
        TreeViewG.Nodes(gname).Nodes("prefix").Nodes.Add("All worlds", "All worlds : None set")
        TreeViewG.Nodes(gname).Nodes.Add("inheritance", "Inherits")
        TreeViewG.Nodes(gname).Nodes.Add("permissions", "Permissions")
        TreeViewG.Nodes(gname).Nodes("permissions").Nodes.Add("All worlds", "All worlds : None set")
        TreeViewG.Nodes(gname).Expand()
        TreeViewG.SelectedNode = TreeViewG.Nodes(gname)
        WriteChanges()
    End Sub

    Private Sub ComboNewGroupName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboNewGroupName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnNewGroup_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
#End Region
#Region "Settings tab"
    Private Sub LstVwGrpOptions_Resize(sender As Object, e As EventArgs) Handles LstVwGrpOptions.Resize
        LstVwGrpOptions.Columns(0).Width = LstVwGrpOptions.Width - 5 - LstVwGrpOptions.Columns(1).Width
    End Sub
    Private Sub TabPageGroups_Info_Enter(sender As Object, e As System.EventArgs) Handles TabPageGroups_Info.Enter
        If TreeViewG.SelectedNode Is Nothing Then
            MsgBox("Please select a group from treeview first", CType(vbOKOnly + vbExclamation, MsgBoxStyle))
            TabControlGroups.SelectTab(0)
        Else
            TreeViewG.Nodes(currentgroup.name).Expand()
            justselect = True
            TreeViewG.SelectedNode = TreeViewG.Nodes(currentgroup.name)
        End If
    End Sub

    Private Sub ChckBxDefault_Click(sender As Object, e As System.EventArgs) Handles ChckBxDefault.Click
        If ChckBxDefault.Checked = False Then
            For Each scangroup In groupslist
                If scangroup.name = currentgroup.name Then
                    scangroup.isdefault = True
                    TreeViewG.Nodes(scangroup.name).Nodes("isdefault").Text = "Default: True"
                Else
                    scangroup.isdefault = False
                    TreeViewG.Nodes(scangroup.name).Nodes("isdefault").Text = "Default: False"
                End If
            Next
            ChckBxDefault.Checked = True
            StatusLabel1.Text = "Changed default group to " & currentgroup.name
            WriteChanges()
        End If
    End Sub
    Private Sub ButtonSetGroupName_Click(sender As System.Object, e As System.EventArgs) Handles BtnGroupNameSet.Click
        If TxtBxGroupname.Text = "" Then
            MsgBox("Please enter a name for this group", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If TxtBxGroupname.Text.Contains(CChar(" ")) OrElse TxtBxGroupname.Text.Contains(CChar(":")) OrElse TxtBxGroupname.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(TxtBxGroupname.Text.Contains(" "), "spaces", "")) & CStr(IIf(TxtBxGroupname.Text.Contains(" ") And TxtBxGroupname.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxGroupname.Text.Contains(":"), "colons", "")) & CStr(IIf(TxtBxGroupname.Text.Contains(":") And TxtBxGroupname.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(TxtBxGroupname.Text.Contains(" ") And TxtBxGroupname.Text.Contains(CChar("'")) And Not TxtBxGroupname.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxGroupname.Text.Contains("'"), "apostrophes", "")) & " in group name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        TreeViewG.Nodes(currentgroup.name).Name = TxtBxGroupname.Text
        currentgroup.name = TxtBxGroupname.Text
        TreeViewG.Nodes(currentgroup.name).Text = TxtBxGroupname.Text
        StatusLabel1.Text = "Renamed group"
        WriteChanges()
    End Sub

    Private Sub TxtBxGroupname_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtBxGroupname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonSetGroupName_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BtnDeleteGroup_Click(sender As System.Object, e As System.EventArgs) Handles BtnGroupDelete.Click
        If MsgBox("Are you sure you want to delete " & currentgroup.name & " group and all its content?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle)) = MsgBoxResult.Yes Then
            groupslist.Remove(currentgroup)
            StatusLabel1.Text = "Deleted group: " & currentgroup.name
            currentgroup = Nothing
            populatetreeview(1)
            TabControlGroups.SelectTab(0)
            WriteChanges()
        End If
    End Sub
    Private Sub BtnGroupDuplicate_Click(sender As Object, e As EventArgs) Handles BtnGroupDuplicate.Click
        Dim newgroup As New Group(currentgroup.name)
        Dim found As Boolean
        Do
            found = False
            newgroup.name += ".copy"
            For Each scangp In groupslist
                If scangp.name = newgroup.name Then
                    found = True
                End If
            Next
        Loop While found = True
        groupslist.Add(newgroup)
        newgroup.isdefault = currentgroup.isdefault
        For Each scanin In currentgroup.inheritsfrom
            newgroup.addinherit(scanin)
        Next
        For Each scanworld In currentgroup.getworlds
            If scanworld.name <> "All worlds" Then
                newgroup.addworld(scanworld.name)
            End If
            newgroup.world(scanworld.name).prefix = scanworld.prefix
            For Each scanperm In scanworld.permissions
                newgroup.world(scanworld.name).addperm(scanperm.text, scanperm.state)
            Next
            For Each scangr In scanworld.getgroups
                newgroup.world(scanworld.name).addgroup(scangr)
            Next
        Next
        For Each scopt In currentgroup.getoptions
            If scopt.text <> "rank" Then
                newgroup.addoption(scopt.text, scopt.value)
            Else
                newgroup.getoptions(0).value = scopt.value
                '                   ^ using 0 is OK because options have not yet been sorted
            End If
        Next
        TreeViewG.Nodes.Add(CType(TreeViewG.Nodes(currentgroup.name).Clone, TreeNode))
        TreeViewG.Nodes(currentgroup.name).Name = newgroup.name
        TreeViewG.Nodes(currentgroup.name).Text = newgroup.name
        StatusLabel1.Text = "Duplicated group: " & TxtBxGroupname.Text
        sortlists()
        TreeViewG.SelectedNode = TreeViewG.Nodes(newgroup.name)
        WriteChanges()
    End Sub

    Private Sub LstBxGroupInherit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstBxGroupInherit.SelectedIndexChanged
        BtnRemoveInherit.Enabled = (LstBxGroupInherit.SelectedItems.Count = 1)
    End Sub
    Private Sub BtnAddInherit_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddInherit.Click
        If ComboInheritsName.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If ComboInheritsName.Text.Contains(CChar(" ")) OrElse ComboInheritsName.Text.Contains(CChar(":")) OrElse ComboInheritsName.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(ComboInheritsName.Text.Contains(" "), "spaces", "")) & CStr(IIf(ComboInheritsName.Text.Contains(" ") And ComboInheritsName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboInheritsName.Text.Contains(":"), "colons", "")) & CStr(IIf(ComboInheritsName.Text.Contains(":") And ComboInheritsName.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(ComboInheritsName.Text.Contains(" ") And ComboInheritsName.Text.Contains(CChar("'")) And Not ComboInheritsName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboInheritsName.Text.Contains("'"), "apostrophes", "")) & " in group name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        For Each scaninherit In currentgroup.inheritsfrom
            If scaninherit = ComboInheritsName.Text Then
                Exit Sub
            End If
        Next
        currentgroup.inheritsfrom.Add(ComboInheritsName.Text)
        LstBxGroupInherit.Items.Add(ComboInheritsName.Text)
        TreeViewG.Nodes(currentgroup.name).Nodes("inheritance").Nodes.Add(ComboInheritsName.Text, ComboInheritsName.Text)
        StatusLabel1.Text = "Group" & currentgroup.name & " now inherits from " & ComboInheritsName.Text
        ComboInheritsName.Text = "Add group"
        WriteChanges()
    End Sub
    Private Sub BtnRemoveInherit_Click(sender As System.Object, e As System.EventArgs) Handles BtnRemoveInherit.Click
        currentgroup.inheritsfrom.Remove(LstBxGroupInherit.GetItemText(LstBxGroupInherit.SelectedItem))
        TreeViewG.Nodes(currentgroup.name).Nodes("inheritance").Nodes(LstBxGroupInherit.GetItemText(LstBxGroupInherit.SelectedItem)).Remove()
        'select previous one if deleted the last or the next one if possible
        Dim i As Integer = LstBxGroupInherit.SelectedIndex
        LstBxGroupInherit.Items.RemoveAt(i)
        Try
            LstBxGroupInherit.SelectedIndex = i * CInt(i > LstBxGroupInherit.Items.Count)
        Catch ex As Exception
        End Try
        StatusLabel1.Text = "Inheritance for " & currentgroup.name & " removed"
        WriteChanges()
    End Sub
    Private Sub LstBxGroupInherit_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LstBxGroupInherit.KeyDown
        If Not LstBxGroupInherit.SelectedItem Is Nothing AndAlso e.KeyCode = Keys.Delete Then
            BtnRemoveInherit_Click(sender, e)
        End If
    End Sub

    Private Sub LstViewGrpOptions_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstVwGrpOptions.SelectedIndexChanged
        BtnRmOption.Enabled = (LstVwGrpOptions.SelectedItems.Count = 1)
    End Sub
    Private Sub BtnAddOption_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddOption.Click
        Dim newoption As New OptionEditor(optionsuggest)
showoptdialog:
        Dim found As Integer = -1
        newoption.ShowDialog()
        'look if the new option doesn't already exist
        For Each scopt In currentgroup.getoptions
            If scopt.text = newoption.gettext Then
                found = currentgroup.getoptions.IndexOf(scopt)
            End If
        Next
        If found >= 0 Then
            Select Case MsgBox("This option already exists." + vbCrLf + "Replace the old value with the new one?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, MsgBoxStyle), "Question")
                Case MsgBoxResult.No
                    newoption = Nothing
                    Exit Sub
                Case MsgBoxResult.Yes
                    currentgroup.getoptions(found).value = newoption.getvalue
                    LstVwGrpOptions.Items(found).SubItems(1).Text = newoption.getvalue
                    TreeViewG.Nodes(currentgroup.name).Nodes("options").Nodes(found).Text = newoption.gettext + " : " + newoption.getvalue
                    Exit Sub
                Case Else
                    GoTo showoptdialog
            End Select
        End If
        Dim TempStr(1) As String
        TempStr(0) = newoption.gettext
        TempStr(1) = newoption.getvalue
        LstVwGrpOptions.Items.Add(New ListViewItem(TempStr))
        currentgroup.addoption(TempStr(0), TempStr(1))
        TreeViewG.Nodes(currentgroup.name).Nodes("options").Nodes.Add(TempStr(0), TempStr(0) & " : " & TempStr(1))
        If Not (optionsuggest.Contains(TempStr(0))) Then
            optionsuggest.Add(TempStr(0))
        End If
        newoption = Nothing
        sortlists()
        WriteChanges()

    End Sub
    Private Sub CntxtMenuOptions_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles CntxtMenuOptions.Opening
        If LstVwGrpOptions.SelectedItems.Count = 1 Then
            CntxtMenuOptions.Items(0).Enabled = True
            CntxtMenuOptions.Items(1).Enabled = True
            CntxtMenuOptions.Items(2).Enabled = True
        Else
            CntxtMenuOptions.Items(0).Enabled = False
            CntxtMenuOptions.Items(1).Enabled = False
            CntxtMenuOptions.Items(2).Enabled = True

        End If
    End Sub

    Private Sub CntxtMenuOptionsEditItem_Click(sender As System.Object, e As System.EventArgs) Handles CntxtMenuOptionsEditItem.Click
        Dim optionedit = New OptionEditor(optionsuggest, LstVwGrpOptions.SelectedItems(0).SubItems(0).Text, LstVwGrpOptions.SelectedItems(0).SubItems(1).Text)
        Dim ok As Boolean
        Do
            ok = True
            optionedit.ShowDialog()
            If optionedit.gettext <> LstVwGrpOptions.SelectedItems(0).SubItems(0).Text Then
                For Each scanopt In currentgroup.getoptions
                    If optionedit.gettext = scanopt.text Then
                        optionedit = New OptionEditor(optionsuggest, LstVwGrpOptions.SelectedItems(0).SubItems(0).Text, LstVwGrpOptions.SelectedItems(0).SubItems(1).Text)
                        optionedit.ErrLbl.Visible = True
                        optionedit.ErrLbl.Text = "Error: this option already exists"
                        ok = False
                        Exit For
                    End If
                Next
            End If
        Loop While ok = False
        For Each scanopt In currentgroup.getoptions
            If scanopt.text = LstVwGrpOptions.SelectedItems(0).SubItems(0).Text Then
                TreeViewG.Nodes(currentgroup.name).Nodes("options").Nodes(scanopt.text).Text = optionedit.gettext() & " : " & optionedit.getvalue()
                TreeViewG.Nodes(currentgroup.name).Nodes("options").Nodes(scanopt.text).Name = optionedit.gettext()
                scanopt.text = optionedit.gettext()
                scanopt.value = optionedit.getvalue()
            End If
        Next
        LstVwGrpOptions.SelectedItems(0).SubItems(0).Text = optionedit.gettext()
        LstVwGrpOptions.SelectedItems(0).SubItems(1).Text = optionedit.getvalue()
        optionedit = Nothing
        WriteChanges()
    End Sub
    Private Sub LstViewGrpOptions_DoubleClick(sender As Object, e As System.EventArgs) Handles LstVwGrpOptions.DoubleClick
        If LstVwGrpOptions.SelectedItems.Count = 1 Then
            CntxtMenuOptionsEditItem_Click(sender, e)
        End If
    End Sub
    Private Sub DuplicateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CntxtMenuOptionsDuplicateItem.Click
        Dim newitem As New ListViewItem()
        Dim found As Boolean
        Dim TempStr() As String = {LstVwGrpOptions.SelectedItems(0).SubItems(0).Text, LstVwGrpOptions.SelectedItems(0).SubItems(1).Text}
        Do
            found = False
            TempStr(0) += ".copy"
            For Each scanopt In currentgroup.getoptions
                If scanopt.text = TempStr(0) Then
                    found = True
                End If
            Next
        Loop While found = True
        currentgroup.addoption(TempStr(0), TempStr(1))
        TreeViewG.Nodes(currentgroup.name).Nodes("options").Nodes.Add(TempStr(0) + " : " + TempStr(1))
        LstVwGrpOptions.Items.Add(New ListViewItem(TempStr))
        WriteChanges()
    End Sub

    Private Sub ContextMenuOptionsRemoveItem_Click(sender As System.Object, e As System.EventArgs) Handles CntxtMenuOptionsRemoveItem.Click
        Dim i As Integer
        For Each scanopt In currentgroup.getoptions
            If scanopt.text = LstVwGrpOptions.SelectedItems(0).SubItems(0).Text Then
                i = currentgroup.getoptions.IndexOf(scanopt)
            End If
        Next
        currentgroup.getoptions.RemoveAt(i)
        TreeViewG.Nodes(currentgroup.name).Nodes("options").Nodes(i).Remove()
        LstVwGrpOptions.SelectedItems(0).Remove()
        WriteChanges()
    End Sub
    Private Sub BtnRmOption_Click(sender As System.Object, e As System.EventArgs) Handles BtnRmOption.Click
        ContextMenuOptionsRemoveItem_Click(sender, e)
    End Sub
    Private Sub LstViewGrpOptions_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LstVwGrpOptions.KeyDown
        If e.KeyCode = Keys.Delete Then
            If LstVwGrpOptions.SelectedItems.Count > 0 Then
                ContextMenuOptionsRemoveItem_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            CntxtMenuOptionsEditItem_Click(sender, e)
        End If
    End Sub

#End Region
#Region "Prefix tab"
    Private Sub TabPageGroups_Prefixes_Enter(sender As Object, e As System.EventArgs) Handles TabPageGroups_Prefixes.Enter
        If TreeViewG.SelectedNode Is Nothing Then
            MsgBox("Please select a group from treeview first", CType(vbOKOnly + vbExclamation, MsgBoxStyle))
            TabControlGroups.SelectTab(0)
        Else
            TreeViewG.Nodes(currentgroup.name).Expand()
            justselect = True
            TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Expand()
            refreshprefixtab()
        End If
    End Sub

    Private Sub LstBxPrefixWorlds_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstBxPrefixWorlds.SelectedIndexChanged
        refreshprefixtab()
    End Sub
    Private Sub refreshprefixtab()
        If LstBxPrefixWorlds.SelectedItems.Count > 0 Then
            If LstBxPrefixWorlds.SelectedItems.Count > 1 Then
                Dim foundprefixes As New List(Of String)
                For Each selecteditem In LstBxPrefixWorlds.SelectedItems
                    For Each scanworld In currentgroup.getworlds
                        If scanworld.name = LstBxPrefixWorlds.GetItemText(selecteditem) Then
                            foundprefixes.Add(scanworld.prefix)
                        End If
                    Next
                Next
                Dim test As Boolean = False
                For i As Integer = 0 To foundprefixes.Count - 1
                    If foundprefixes(i) <> foundprefixes(0) Then
                        test = True
                    End If
                Next
                If test = False Then
                    TxtBxPrefix.Text = foundprefixes(0)
                Else
                    TxtBxPrefix.Text = "Multiple values"
                End If
                TxtBxWorldname.Text = "Multiple selected"
                TxtBxWorldname.ReadOnly = True
                BtnWorldnameSet.Enabled = False
                BtnWorldDelete.Enabled = False
            Else
                If LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem) = "All worlds" Then
                    TxtBxWorldname.Text = "Default values for all worlds"
                    TxtBxWorldname.ReadOnly = True
                    BtnWorldnameSet.Enabled = False
                    BtnWorldDelete.Enabled = False
                Else
                    TxtBxWorldname.Text = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem)
                    TxtBxWorldname.ReadOnly = False
                    BtnWorldnameSet.Enabled = True
                    BtnWorldDelete.Enabled = True
                End If
                For Each scanworld In currentgroup.getworlds
                    If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem) Then
                        TxtBxPrefix.Text = scanworld.prefix
                    End If
                Next
            End If
            TxtBxPrefix.ReadOnly = False
            BtnPrefixSet.Enabled = True
            BtnPrefixUnset.Enabled = True
        Else
            TxtBxWorldname.Text = "No world selected"
            TxtBxWorldname.ReadOnly = True
            BtnWorldnameSet.Enabled = False
            TxtBxPrefix.Text = "No world selected"
            TxtBxPrefix.ReadOnly = True
            BtnPrefixSet.Enabled = False
            BtnPrefixUnset.Enabled = False
            BtnWorldDelete.Enabled = False
        End If
    End Sub
    Private Sub BtnWorldDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnWorldDelete.Click
        If MsgBox("Are you sure you want to delete " & LstBxPrefixWorlds.SelectedItem.ToString & " world and all its content?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle)) = MsgBoxResult.Yes Then
            For Each scanworld In currentgroup.getworlds
                If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem) Then
                    TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(currentgroup.getworlds(currentgroup.getworlds.IndexOf(scanworld)).name).Remove()
                    TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes(currentgroup.getworlds(currentgroup.getworlds.IndexOf(scanworld)).name).Remove()
                    currentgroup.getworlds.RemoveAt(currentgroup.getworlds.IndexOf(scanworld))
                    StatusLabel1.Text = "Deleted world: " & LstBxPrefixWorlds.SelectedItem.ToString
                    LstBxPrefixWorlds.Items.Remove(LstBxPrefixWorlds.SelectedItem)
                    Exit For
                End If
            Next
            refreshprefixtab()
            WriteChanges()
        End If
    End Sub
    Private Sub LstBxPrefixWorlds_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LstBxPrefixWorlds.KeyDown
        If e.KeyCode = Keys.Delete Then
            BtnWorldDelete_Click(sender, e)
        End If
    End Sub
    Private Sub BtnWorldnameSet_Click(sender As System.Object, e As System.EventArgs) Handles BtnWorldnameSet.Click
        If TxtBxWorldname.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If TxtBxWorldname.Text.Contains(CChar(" ")) OrElse TxtBxWorldname.Text.Contains(CChar(":")) OrElse TxtBxWorldname.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(TxtBxWorldname.Text.Contains(" "), "spaces", "")) & CStr(IIf(TxtBxWorldname.Text.Contains(" ") And TxtBxWorldname.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxWorldname.Text.Contains(":"), "colons", "")) & CStr(IIf(TxtBxWorldname.Text.Contains(":") And TxtBxWorldname.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(TxtBxWorldname.Text.Contains(" ") And TxtBxWorldname.Text.Contains(CChar("'")) And Not TxtBxWorldname.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxWorldname.Text.Contains("'"), "apostrophes", "")) & " in world name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        For Each scanworld In currentgroup.getworlds
            If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem) Then
                TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(scanworld.name).Text = TxtBxWorldname.Text & " : " & scanworld.prefix
                TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes(scanworld.name).Text = TxtBxWorldname.Text
                TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes(scanworld.name).Name = TxtBxWorldname.Text
                TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(scanworld.name).Name = TxtBxWorldname.Text
                scanworld.name = TxtBxWorldname.Text
            End If
        Next
        LstBxPrefixWorlds.Items(LstBxPrefixWorlds.SelectedIndex) = TxtBxWorldname.Text
        refreshprefixtab()
        WriteChanges()
    End Sub
    Private Sub TxtBxWorldname_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtBxWorldname.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnWorldnameSet_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub BtnPrefixSet_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrefixSet.Click
        If TxtBxPrefix.Text = "" Then
            MsgBox("Please enter a prefix", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If TxtBxPrefix.Text.Contains(CChar(" ")) OrElse TxtBxPrefix.Text.Contains(CChar(":")) OrElse TxtBxPrefix.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(TxtBxPrefix.Text.Contains(" "), "spaces", "")) & CStr(IIf(TxtBxPrefix.Text.Contains(" ") And TxtBxPrefix.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxPrefix.Text.Contains(":"), "colons", "")) & CStr(IIf(TxtBxPrefix.Text.Contains(":") And TxtBxPrefix.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(TxtBxPrefix.Text.Contains(" ") And TxtBxPrefix.Text.Contains(CChar("'")) And Not TxtBxPrefix.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxPrefix.Text.Contains("'"), "apostrophes", "")) & " in the prefix", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If LstBxPrefixWorlds.SelectedItems.Count > 1 Then
            If MsgBox("This will set the prefix for all selected worlds!" & vbCrLf & "Continue?", CType(MsgBoxStyle.Question + MsgBoxStyle.OkCancel, MsgBoxStyle)) = MsgBoxResult.Ok Then
                For Each scanworld In currentgroup.getworlds
                    For i As Integer = 0 To LstBxPrefixWorlds.SelectedItems.Count - 1
                        If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItems(i)) Then
                            scanworld.prefix = TxtBxPrefix.Text
                            TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                        End If
                    Next
                Next
                WriteChanges()
            End If
        Else
            For Each scanworld In currentgroup.getworlds
                If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem) Then
                    scanworld.prefix = TxtBxPrefix.Text
                    TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                End If
            Next
            WriteChanges()
        End If
        refreshprefixtab()
    End Sub
    Private Sub TxtBxPrefix_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtBxPrefix.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPrefixSet_Click(sender, e)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Control Then
            BtnPrefixUnset_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub BtnPrefixUnset_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrefixUnset.Click
        If LstBxPrefixWorlds.SelectedItems.Count > 1 Then
            If MsgBox("This will clear the prefix for all selected worlds!" & vbCrLf & "Continue?", CType(MsgBoxStyle.Question + MsgBoxStyle.OkCancel, MsgBoxStyle)) = MsgBoxResult.Ok Then
                For Each scanworld In currentgroup.getworlds
                    For i As Integer = 0 To LstBxPrefixWorlds.SelectedItems.Count - 1
                        If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItems(i)) Then
                            scanworld.prefix = "None set"
                            TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                        End If
                    Next
                Next
                TxtBxPrefix.Text = "None set"
                WriteChanges()
            End If
        Else
            For Each scanworld In currentgroup.getworlds
                If scanworld.name = LstBxPrefixWorlds.GetItemText(LstBxPrefixWorlds.SelectedItem) Then
                    scanworld.prefix = "None set"
                    TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                End If
            Next
            TxtBxPrefix.Text = "None set"
            WriteChanges()
        End If
    End Sub

    Private Sub BtnAddWorld_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddWorld.Click
        If ComboNewWorldName.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If ComboNewWorldName.Text.Contains(CChar(" ")) OrElse ComboNewWorldName.Text.Contains(CChar(":")) OrElse ComboNewWorldName.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(ComboNewWorldName.Text.Contains(" "), "spaces", "")) & CStr(IIf(ComboNewWorldName.Text.Contains(" ") And ComboNewWorldName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboNewWorldName.Text.Contains(":"), "colons", "")) & CStr(IIf(ComboNewWorldName.Text.Contains(":") And ComboNewWorldName.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(ComboNewWorldName.Text.Contains(" ") And ComboNewWorldName.Text.Contains(CChar("'")) And Not ComboNewWorldName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboNewWorldName.Text.Contains("'"), "apostrophes", "")) & " in the world name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        For Each scanworld In currentgroup.getworlds
            If ComboNewWorldName.Text = scanworld.name Then
                Exit Sub
            End If
        Next
        currentgroup.getworlds.Add(New World(ComboNewWorldName.Text))
        TreeViewG.Nodes(currentgroup.name).Nodes("prefix").Nodes.Add(ComboNewWorldName.Text, ComboNewWorldName.Text & " : None set")
        TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes.Add(ComboNewWorldName.Text, ComboNewWorldName.Text)
        LstBxPrefixWorlds.Items.Add(ComboNewWorldName.Text)
        ComboPermWorld.Items.Add(ComboNewWorldName.Text)
        LstBxPrefixWorlds.SelectedItem = ComboNewWorldName.Name
        ComboNewWorldName.Text = "New world"
        WriteChanges()
    End Sub
    Private Sub ComboNewWorldName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboNewWorldName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAddWorld_Click(sender, e)
        End If
    End Sub
#End Region
#Region "Perms tab"
    Private Sub LstVwGroupPerms_Resize(sender As Object, e As EventArgs) Handles LstVwGroupPerms.Resize
        'adjust the single column's size to fill the list view
        LstVwGroupPerms.Columns(0).Width = LstVwGroupPerms.Width - 4
    End Sub
    Private Sub TabPageGroups_Permissions_Enter(sender As Object, e As System.EventArgs) Handles TabPageGroups_Permissions.Enter
        If TreeViewG.SelectedNode Is Nothing Then
            MsgBox("Please select a group from treeview first", CType(vbOKOnly + vbExclamation, MsgBoxStyle))
            TabControlGroups.SelectTab(0)
        Else
            TreeViewG.Nodes(currentgroup.name).Expand()
            TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Expand()
            justselect = True
            TreeViewG.SelectedNode = TreeViewG.Nodes(currentgroup.name).Nodes("permissions")
        End If
        refreshpermtab()
    End Sub
    Private Sub ComboPermWorld_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboPermWorld.SelectedIndexChanged
        refreshpermtab()
    End Sub
    Private Sub refreshpermtab()
        If Not ComboPermWorld.SelectedItem Is Nothing Then
            currentworld = currentgroup.world(ComboPermWorld.SelectedItem.ToString)
            BtnAddPerm.Enabled = True
        Else
            currentworld = Nothing
            BtnAddPerm.Enabled = False
        End If
        LstVwGroupPerms.Items.Clear()
        If Not currentworld Is Nothing Then
            For Each readperm As Permission In currentworld.permissions
                Dim newitem As New ListViewItem(readperm.text)
                If readperm.state = True Then
                    newitem.Checked = True
                End If
                LstVwGroupPerms.Items.Add(newitem)
            Next
        End If
    End Sub
    Private Sub CntxtMenuPerms_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles CntxtMenuPerms.Opening
        If LstVwGroupPerms.SelectedItems.Count = 1 Then
            CntxtMenuPerms.Items(0).Enabled = True
            CntxtMenuPerms.Items(1).Enabled = True
            CntxtMenuPerms.Items(2).Enabled = True
        Else
            CntxtMenuPerms.Items(0).Enabled = False
            CntxtMenuPerms.Items(1).Enabled = False
            CntxtMenuPerms.Items(2).Enabled = False
        End If
    End Sub
    Private Sub BtnAddPerm_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddPerm.Click
        Dim permdialog As New PermEditor(permsuggest)
        permdialog.ShowDialog()
        For Each scanperm In LstVwGroupPerms.Items.ToString
            If permdialog.gettext = scanperm Then
                MsgBox("This permission already exists", MsgBoxStyle.Information)
                permdialog = Nothing
                Exit Sub
            End If
        Next
        currentworld.addperm(permdialog.gettext, permdialog.getstate)
        refreshpermtab()
        TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes(currentworld.name).Nodes.Add(permdialog.gettext, permdialog.gettext & " : " + CStr(permdialog.getstate))
        sortlists()
        If Not permsuggest.Contains(permdialog.gettext) Then
            permsuggest.Add(permdialog.gettext)
        End If
        WriteChanges()
        permdialog = Nothing
    End Sub
    Private Sub LstVwGroupPerms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstVwGroupPerms.SelectedIndexChanged
        If Not LstVwGroupPerms.SelectedItems Is Nothing Then
            BtnRmPerm.Enabled = True
        End If
    End Sub
    Private Sub LstBxGroupPerms_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles LstVwGroupPerms.ItemCheck
        Dim changes As Boolean = False
        For Each scanperm In currentworld.permissions
            If scanperm.text = LstVwGroupPerms.Items(e.Index).Text AndAlso CBool(e.NewValue) <> scanperm.state Then
                scanperm.state = CBool(e.NewValue)
                TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes(currentworld.name).Nodes(scanperm.text).Text = scanperm.text & " : " & CStr(scanperm.state)
                changes = True
            End If
        Next
        If changes = True Then
            WriteChanges()
        End If
    End Sub
    Private Sub BtnRmPerm_Click(sender As System.Object, e As System.EventArgs) Handles BtnRmPerm.Click
        If Not LstVwGroupPerms.SelectedItems Is Nothing Then
            Dim toremove As New List(Of Integer)
            For Each scanperm In currentworld.permissions
                If scanperm.text = LstVwGroupPerms.SelectedItems(0).Text Then
                    toremove.Add(currentworld.permissions.IndexOf(scanperm))
                    TreeViewG.Nodes(currentgroup.name).Nodes("permissions").Nodes(currentworld.name).Nodes(scanperm.text).Remove()
                End If
            Next
            For Each index In toremove
                currentworld.permissions.RemoveAt(index)
                LstVwGroupPerms.Items.RemoveAt(index)
            Next
            WriteChanges()
        Else
            MsgBox("No permission selected", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub LstBxGroupPerms_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LstVwGroupPerms.KeyDown
        If e.KeyCode = Keys.Delete Then
            BtnRmPerm_Click(sender, e)
        End If
    End Sub
#End Region
#End Region

#Region "UserSubTabs"
    Private Sub TreeViewU_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewU.AfterSelect
        If justselect = False Then
            For Each scanuser In userslist
                If scanuser.name = TreeViewU.SelectedNode.FullPath.Split(CChar("/"))(0) Then
                    currentuser = scanuser
                End If
            Next
            'set everything that's on the user scope
            TxtBxUName.Text = currentuser.name
            LstBxUPrefixWorlds.Items.Clear()
            ComboPermWorld.Items.Clear()
            LstBxUGroups.Items.Clear()
            For Each scanworld In currentuser.getworlds
                LstBxUPrefixWorlds.Items.Add(scanworld.name)
                ComboUPermWorld.Items.Add(scanworld.name)
            Next
            Select Case TreeViewU.SelectedNode.Level
                Case 0
                    TabControlUsers.SelectTab(0)
                Case 1
                    Select Case TreeViewU.SelectedNode.Name
                        Case "prefix", "groups"
                            TabControlUsers.SelectTab(1)
                        Case "permissions"
                            TabControlUsers.SelectTab(2)
                    End Select
                Case 2
                    Select Case TreeViewU.SelectedNode.Parent.Name
                        Case "prefix"
                            TabControlUsers.SelectTab(1)
                            LstBxUPrefixWorlds.SelectedIndex = TreeViewU.SelectedNode.Index
                        Case "groups"
                            TabControlUsers.SelectTab(1)
                            LstBxUGroups.SelectedIndex = TreeViewU.SelectedNode.Index
                        Case "permissions"
                            TabControlUsers.SelectTab(2)
                            ComboUPermWorld.SelectedItem = TreeViewU.SelectedNode.Name
                    End Select
                Case 3
                    TabControlUsers.SelectTab(2)
                    ComboUPermWorld.SelectedItem = TreeViewU.SelectedNode.Name
                    LstVwUserPerms.Items(TreeViewG.SelectedNode.Index).Selected = True
            End Select
        Else
            justselect = False
        End If
    End Sub
#Region "Actions tab"

#End Region
#Region "Prefix and groups tab"
    Private Sub TabPageUsers_Prefix_Enter(sender As Object, e As EventArgs) Handles TabPageUsers_Prefix.Enter
        If TreeViewU.SelectedNode Is Nothing Then
            MsgBox("Please select a user from treeview first", CType(vbOKOnly + vbExclamation, MsgBoxStyle))
            TabControlUsers.SelectTab(0)
        Else
            TreeViewU.Nodes(currentuser.name).Expand()
            justselect = True
            TreeViewU.Nodes(currentuser.name).Nodes("prefix").Expand()
            refreshuprefixtab()
        End If
    End Sub
    Private Sub refreshuprefixtab()
        If LstBxUPrefixWorlds.SelectedItems.Count > 0 Then
            If LstBxUPrefixWorlds.SelectedItems.Count > 1 Then
                Dim foundprefixes As New List(Of String)
                For Each selecteditem In LstBxUPrefixWorlds.SelectedItems
                    For Each scanworld In currentuser.getworlds
                        If scanworld.name = LstBxUPrefixWorlds.GetItemText(selecteditem) Then
                            foundprefixes.Add(scanworld.prefix)
                        End If
                    Next
                Next
                Dim test As Boolean = False
                For i As Integer = 0 To foundprefixes.Count - 1
                    If foundprefixes(i) <> foundprefixes(0) Then
                        test = True
                    End If
                Next
                If test = False Then
                    TxtBxUPrefix.Text = foundprefixes(0)
                Else
                    TxtBxUPrefix.Text = "Multiple values"
                End If
                TxtBxUWorldname.Text = "Multiple selected"
                TxtBxUWorldname.ReadOnly = True
                BtnUWorldnameSet.Enabled = False
                BtnURmWorld.Enabled = False
            Else
                If LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem) = "All worlds" Then
                    TxtBxUWorldname.Text = "Default values for all worlds"
                    TxtBxUWorldname.ReadOnly = True
                    BtnUWorldnameSet.Enabled = False
                    BtnURmWorld.Enabled = False
                Else
                    TxtBxUWorldname.Text = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem)
                    TxtBxUWorldname.ReadOnly = False
                    BtnUWorldnameSet.Enabled = True
                    BtnURmWorld.Enabled = True
                End If
                For Each scanworld In currentuser.getworlds
                    If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem) Then
                        TxtBxUPrefix.Text = scanworld.prefix
                    End If
                Next
            End If
            TxtBxUPrefix.ReadOnly = False
            BtnUPrefixSet.Enabled = True
            BtnUPrefixClear.Enabled = True
        Else
            TxtBxUWorldname.Text = "No world selected"
            TxtBxUWorldname.ReadOnly = True
            BtnUWorldnameSet.Enabled = False
            TxtBxUPrefix.Text = "No world selected"
            TxtBxUPrefix.ReadOnly = True
            BtnUPrefixSet.Enabled = False
            BtnUPrefixClear.Enabled = False
            BtnURmWorld.Enabled = False
        End If
    End Sub
    Private Sub LstBxUPrefixWorlds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBxUPrefixWorlds.SelectedIndexChanged
        refreshuprefixtab()
    End Sub
    Private Sub BtnURmWorld_Click(sender As System.Object, e As System.EventArgs) Handles BtnURmWorld.Click
        If MsgBox("Are you sure you want to delete " & LstBxUPrefixWorlds.SelectedItem.ToString & " world and all its content?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle)) = MsgBoxResult.Yes Then
            For Each scanworld In currentuser.getworlds
                If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem) Then
                    TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(currentuser.getworlds(currentuser.getworlds.IndexOf(scanworld)).name).Remove()
                    TreeViewU.Nodes(currentuser.name).Nodes("permissions").Nodes(currentuser.getworlds(currentuser.getworlds.IndexOf(scanworld)).name).Remove()
                    currentuser.getworlds.RemoveAt(currentuser.getworlds.IndexOf(scanworld))
                    StatusLabel1.Text = "Deleted world: " & LstBxUPrefixWorlds.SelectedItem.ToString
                    LstBxUPrefixWorlds.Items.Remove(LstBxUPrefixWorlds.SelectedItem)
                    Exit For
                End If
            Next
            refreshuprefixtab()
            WriteChanges()
        End If
    End Sub
    Private Sub LstBxUPrefixWorlds_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LstBxUPrefixWorlds.KeyDown
        If e.KeyCode = Keys.Delete Then
            BtnURmWorld_Click(sender, e)
        End If
    End Sub
    Private Sub BtnUWorldnameSet_Click(sender As System.Object, e As System.EventArgs) Handles BtnUWorldnameSet.Click
        If TxtBxUWorldname.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If TxtBxUWorldname.Text.Contains(CChar(" ")) OrElse TxtBxUWorldname.Text.Contains(CChar(":")) OrElse TxtBxUWorldname.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(TxtBxUWorldname.Text.Contains(" "), "spaces", "")) & CStr(IIf(TxtBxUWorldname.Text.Contains(" ") And TxtBxUWorldname.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxUWorldname.Text.Contains(":"), "colons", "")) & CStr(IIf(TxtBxUWorldname.Text.Contains(":") And TxtBxUWorldname.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(TxtBxUWorldname.Text.Contains(" ") And TxtBxUWorldname.Text.Contains(CChar("'")) And Not TxtBxUWorldname.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxUWorldname.Text.Contains("'"), "apostrophes", "")) & " in world name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        For Each scanworld In currentuser.getworlds
            If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem) Then
                TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(scanworld.name).Text = TxtBxUWorldname.Text & " : " & scanworld.prefix
                TreeViewU.Nodes(currentuser.name).Nodes("permissions").Nodes(scanworld.name).Text = TxtBxUWorldname.Text
                TreeViewU.Nodes(currentuser.name).Nodes("permissions").Nodes(scanworld.name).Name = TxtBxUWorldname.Text
                TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(scanworld.name).Name = TxtBxUWorldname.Text
                scanworld.name = TxtBxUWorldname.Text
            End If
        Next
        LstBxUPrefixWorlds.Items(LstBxUPrefixWorlds.SelectedIndex) = TxtBxUWorldname.Text
        refreshuprefixtab()
        WriteChanges()
    End Sub
    Private Sub TxtBxUWorldname_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtBxUWorldname.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnUWorldnameSet_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub BtnUPrefixSet_Click(sender As System.Object, e As System.EventArgs) Handles BtnUPrefixSet.Click
        If TxtBxUPrefix.Text = "" Then
            MsgBox("Please enter a prefix", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If TxtBxUPrefix.Text.Contains(CChar(" ")) OrElse TxtBxUPrefix.Text.Contains(CChar(":")) OrElse TxtBxUPrefix.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(TxtBxUPrefix.Text.Contains(" "), "spaces", "")) & CStr(IIf(TxtBxUPrefix.Text.Contains(" ") And TxtBxUPrefix.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxUPrefix.Text.Contains(":"), "colons", "")) & CStr(IIf(TxtBxUPrefix.Text.Contains(":") And TxtBxUPrefix.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(TxtBxUPrefix.Text.Contains(" ") And TxtBxUPrefix.Text.Contains(CChar("'")) And Not TxtBxUPrefix.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxUPrefix.Text.Contains("'"), "apostrophes", "")) & " in the prefix", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If LstBxUPrefixWorlds.SelectedItems.Count > 1 Then
            If MsgBox("This will set the prefix for all selected worlds!" & vbCrLf & "Continue?", CType(MsgBoxStyle.Question + MsgBoxStyle.OkCancel, MsgBoxStyle)) = MsgBoxResult.Ok Then
                For Each scanworld In currentuser.getworlds
                    For i As Integer = 0 To LstBxUPrefixWorlds.SelectedItems.Count - 1
                        If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItems(i)) Then
                            scanworld.prefix = TxtBxUPrefix.Text
                            TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                        End If
                    Next
                Next
                WriteChanges()
            End If
        Else
            For Each scanworld In currentuser.getworlds
                If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem) Then
                    scanworld.prefix = TxtBxUPrefix.Text
                    TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                End If
            Next
            WriteChanges()
        End If
        refreshuprefixtab()
    End Sub
    Private Sub TxtBxUPrefix_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtBxUPrefix.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnUPrefixSet_Click(sender, e)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Control Then
            BtnUPrefixClear_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub BtnUPrefixClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnUPrefixClear.Click
        If LstBxUPrefixWorlds.SelectedItems.Count > 1 Then
            If MsgBox("This will clear the prefix for all selected worlds!" & vbCrLf & "Continue?", CType(MsgBoxStyle.Question + MsgBoxStyle.OkCancel, MsgBoxStyle)) = MsgBoxResult.Ok Then
                For Each scanworld In currentuser.getworlds
                    For i As Integer = 0 To LstBxUPrefixWorlds.SelectedItems.Count - 1
                        If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItems(i)) Then
                            scanworld.prefix = "None set"
                            TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                        End If
                    Next
                Next
                TxtBxPrefix.Text = "None set"
                WriteChanges()
            End If
        Else
            For Each scanworld In currentuser.getworlds
                If scanworld.name = LstBxUPrefixWorlds.GetItemText(LstBxUPrefixWorlds.SelectedItem) Then
                    scanworld.prefix = "None set"
                    TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes(scanworld.name).Text = scanworld.name & " : " & scanworld.prefix
                End If
            Next
            TxtBxPrefix.Text = "None set"
            WriteChanges()
        End If
    End Sub
    Private Sub BtnUAddWorld_Click(sender As System.Object, e As System.EventArgs) Handles BtnUAddWorld.Click
        If ComboUNewWorldName.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If ComboUNewWorldName.Text.Contains(CChar(" ")) OrElse ComboUNewWorldName.Text.Contains(CChar(":")) OrElse ComboUNewWorldName.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(ComboUNewWorldName.Text.Contains(" "), "spaces", "")) & CStr(IIf(ComboUNewWorldName.Text.Contains(" ") And ComboUNewWorldName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboUNewWorldName.Text.Contains(":"), "colons", "")) & CStr(IIf(ComboUNewWorldName.Text.Contains(":") And ComboUNewWorldName.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(ComboUNewWorldName.Text.Contains(" ") And ComboUNewWorldName.Text.Contains(CChar("'")) And Not ComboUNewWorldName.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboUNewWorldName.Text.Contains("'"), "apostrophes", "")) & " in the world name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        For Each scanworld In currentuser.getworlds
            If ComboUNewWorldName.Text = scanworld.name Then
                Exit Sub
            End If
        Next
        currentuser.getworlds.Add(New World(ComboUNewWorldName.Text))
        TreeViewU.Nodes(currentuser.name).Nodes("prefix").Nodes.Add(ComboUNewWorldName.Text, ComboUNewWorldName.Text & " : None set")
        TreeViewU.Nodes(currentuser.name).Nodes("permissions").Nodes.Add(ComboUNewWorldName.Text, ComboUNewWorldName.Text)
        LstBxUPrefixWorlds.Items.Add(ComboUNewWorldName.Text)
        ComboUPermWorld.Items.Add(ComboUNewWorldName.Text)
        LstBxUPrefixWorlds.SelectedItem = ComboUNewWorldName.Name
        ComboUNewWorldName.Text = "New world"
        WriteChanges()
    End Sub
    Private Sub ComboUNewWorldName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboUNewWorldName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnUAddWorld_Click(sender, e)
        End If
    End Sub
#End Region
#Region "Perms tab"

#End Region
#End Region

    Private Sub fileopen(ByVal ofilename As String, Optional ByVal isnew As Boolean = False)
        openfile = ofilename
        wasnew = isnew
        StatusProgressBar1.Value = StatusProgressBar1.Minimum
        If File.Exists(appdir & Path.DirectorySeparatorChar & "perms.yml") Then
            File.Delete(appdir & Path.DirectorySeparatorChar & "perms.yml")
        End If
        If File.Exists(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
            File.Delete(appdir & Path.DirectorySeparatorChar & "lastsave.yml")
        End If
        If isnew = False Then
            StatusLabel1.Text = "Opening: " & ofilename
            File.Copy(ofilename, appdir & Path.DirectorySeparatorChar & "perms.yml")
            'if the file was a restore then not writing lastsave.yml will provoke a save prompt
            If ofilename <> appdir & Path.DirectorySeparatorChar & "restore.yml" Then
                File.Copy(ofilename, appdir & Path.DirectorySeparatorChar & "lastsave.yml")
            End If
            File.Delete(appdir & Path.DirectorySeparatorChar & "restore.yml")
        Else
            StatusLabel1.Text = "Creating a brand new file"
        End If
        TabControlGroups.SelectTab(0)
        'clear all values
        userslist.Clear()
        groupslist.Clear()
        TreeViewG.Nodes.Clear()
        TreeViewU.Nodes.Clear()
        ComboPermWorld.Items.Clear()
        ComboInheritsName.Items.Clear()
        ComboNewWorldName.Items.Clear()
        ComboUNewWorldName.Items.Clear()
        ComboRnkLaddr.Items.Clear()
        permsuggest.Clear()
        If isnew = False Then
            Try
                parsefile()
            Catch ex As Exception
                MsgBox("There was an error while reading the file", CType(vbOKOnly + vbQuestion, MsgBoxStyle), "Parsing error")
                StatusLabel1.Text = "Failed to open: " & ofilename + " - Check the number of spaces in tabs is right (adjust it in the options)"
                StatusProgressBar1.Value = StatusProgressBar1.Minimum
                'revert interface to nothing ( useful only if a file was open before the error )
                TabControl1.Visible = False
                EditToolStripMenuItem.Enabled = False
                SaveToolStripMenuItem.Enabled = False
                SaveAsToolStripMenuItem.Enabled = False
                TabControlGroups.Visible = False
                TabControlUsers.Visible = False
                Me.Text = "PexEdit"
                Exit Sub
            End Try
            sortlists()
            populatetreeview(1)
            populatetreeview(2)
            StatusProgressBar1.Value = StatusProgressBar1.Maximum
            StatusLabel1.Text = "Succesfully opened: " & ofilename
            Dim t = False
            For Each filename In My.Settings.recentfiles
                If filename = ofilename Then
                    t = True
                End If
            Next
            If t = False Then
                My.Settings.recentfiles.Insert(0, ofilename)
            Else
                My.Settings.recentfiles.Remove(ofilename)
                My.Settings.recentfiles.Insert(0, ofilename)
            End If
            refreshrecentfiles()
        Else
            StatusLabel1.Text = "Created a brand new file"
            StatusProgressBar1.Value = StatusProgressBar1.Maximum
        End If
        ' interface changes
        TabControl1.Visible = True
        EditToolStripMenuItem.Enabled = True
        SaveToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        TabControlGroups.Visible = True
        TabControlUsers.Visible = True
        Me.Text = "PexEdit - " & ofilename
    End Sub

    Private Sub parsefile()
        lines = File.ReadAllLines(appdir & Path.DirectorySeparatorChar & "perms.yml")
        Dim currentworldname As String = ""
        Dim currentsection As String = "none"
        Dim i As Integer = 0
        StatusProgressBar1.Value = i
        Do
            If lines(i) = "groups:" Then
                currentworldname = ""
                currentsection = "none"
                i += 1
                While i < lines.Length
                    'Find group name
                    If lines(i).StartsWith(tabstring) And Not lines(i).Remove(0, tabstring.Length).StartsWith(" ") Then
                        currentgroup = New Group(lines(i).Remove(lines(i).IndexOf(":")).Remove(0, tabstring.Length))
                        groupslist.Add(currentgroup)
                        ComboInheritsName.Items.Add(currentgroup.name)
                    End If
                    'Find sections
                    If lines(i).StartsWith(tabstring & tabstring & "permissions:") Then
                        currentsection = "permissions"
                    End If
                    If lines(i).StartsWith(tabstring & tabstring & "inheritance:") Then
                        currentsection = "inheritance"
                    End If
                    If lines(i).StartsWith(tabstring & tabstring & "worlds:") Then
                        currentsection = "worlds"
                    End If
                    If lines(i).StartsWith(tabstring & tabstring & "options:") Then
                        currentsection = "options"
                    End If
                    'Find group default prefix for all worlds
                    If lines(i).StartsWith(tabstring & tabstring & "prefix:") Then
                        currentsection = "none"
                        currentgroup.world("all").prefix = lines(i).Split(CChar("'"))(1)
                    End If
                    'Find if group is default
                    If lines(i).StartsWith(tabstring & tabstring & "default:") Then
                        currentsection = "none"
                        currentgroup.isdefault = CBool(lines(i).Split(CChar(":"))(1).Remove(0, 1))
                    End If
                    ' find world names or options
                    If lines(i).StartsWith(tabstring & tabstring & tabstring) AndAlso Not lines(i).Remove(0, tabstring.Length * 3).StartsWith(" ") Then
                        If currentsection = "worlds" Then
                            'find world name + add it to the current group
                            currentworldname = lines(i).Remove(lines(i).IndexOf(":")).Remove(0, tabstring.Length * 3)
                            currentgroup.addworld(currentworldname)
                            If Not (ComboNewWorldName.Items.Contains(currentworldname)) Then
                                ComboNewWorldName.Items.Add(currentworldname)
                                ComboUNewWorldName.Items.Add(currentworldname)
                            End If
                        ElseIf currentsection = "options" Then
                            'find group options
                            Dim optionline() As String = lines(i).Remove(0, tabstring.Length * 3).Split(CChar(":"))
                            If optionline(0) = "rank" Then
                                    currentgroup.getoptions(0).value = optionline(1).Remove(0, 1).Trim(CChar("'"))
                                    '                       ^ Legit since the options have not yet been reordered
                            Else
                                    currentgroup.addoption(optionline(0), optionline(1).Remove(0, 1).Trim(CChar("'")))
                            End If
                            If Not (optionsuggest.Contains(optionline(0))) Then
                                optionsuggest.Add(optionline(0))
                            End If
                        End If
                    End If
                    'find world specific permissions
                    If lines(i).StartsWith(tabstring & tabstring & tabstring & tabstring & "-") Then
                        Dim strperm As String = ""
                        If lines(i).Remove(0, tabstring.Length * 4 + 2).StartsWith("-") Then
                            strperm = lines(i).Remove(0, tabstring.Length * 4 + 3)
                            currentgroup.world(currentworldname).addperm(strperm, False)
                        Else
                            strperm = lines(i).Remove(0, tabstring.Length * 4 + 2)
                            currentgroup.world(currentworldname).addperm(strperm, True)
                        End If
                        If Not permsuggest.Contains(strperm) Then
                            permsuggest.Add(strperm)
                        End If
                    End If
                    'find world specific prefix
                    If lines(i).StartsWith(tabstring & tabstring & tabstring & tabstring & "prefix:") Then
                        currentgroup.world(currentworldname).prefix = lines(i).Split(CChar("'"))(1)
                    End If
                    'Find hyphen nodes
                    If lines(i).StartsWith(tabstring & tabstring & "-") Then
                        If currentsection = "permissions" Then
                            Dim strperm As String = ""
                            If lines(i).Remove(0, tabstring.Length * 2 + 2).StartsWith("-") Then
                                strperm = lines(i).Remove(0, tabstring.Length * 2 + 3)
                                currentgroup.world("all").addperm(strperm, False)
                            Else
                                strperm = lines(i).Remove(0, tabstring.Length * 2 + 2)
                                currentgroup.world("all").addperm(strperm, True)
                            End If
                            If Not permsuggest.Contains(strperm) Then
                                permsuggest.Add(strperm)
                            End If
                        ElseIf currentsection = "inheritance" Then
                            currentgroup.addinherit(lines(i).Remove(0, tabstring.Length * 2 + 2))
                        End If
                    End If
                    If i < lines.Length - 1 Then
                        If lines(i + 1).StartsWith("users:") Then
                            i += 1
                            Exit While
                        End If
                    End If
                    i += 1
                    StatusProgressBar1.Value = CInt(100 * i / lines.Length - 1)
                End While
            End If
            If i < lines.Length AndAlso lines(i) = "users:" Then
                currentworldname = ""
                currentsection = "none"
                Dim currentsubsection As String = ""
                i += 1
                While i < lines.Length
                    If lines(i).StartsWith(tabstring) And Not (lines(i).Remove(0, tabstring.Length).StartsWith(" ")) Then
                        currentuser = New User(lines(i).Remove(lines(i).IndexOf(":")).Remove(0, tabstring.Length))
                        userslist.Add(currentuser)
                    End If
                    'find sections
                    If lines(i).StartsWith(tabstring & tabstring & "permissions:") Then
                        currentsection = "permissions"
                    End If
                    If lines(i).StartsWith(tabstring & tabstring & "group:") Then
                        currentsection = "groups"
                    End If
                    If lines(i).StartsWith(tabstring & tabstring & "worlds:") Then
                        currentsection = "worlds"
                    End If
                    'find world subsections
                    If lines(i).StartsWith(tabstring & tabstring & tabstring & tabstring & "permissions:") Then
                        currentsubsection = "permissions"
                    End If
                    If lines(i).StartsWith(tabstring & tabstring & tabstring & tabstring & "group:") Then
                        currentsubsection = "groups"
                    End If
                    'find hyphen nodes
                    If lines(i).StartsWith(tabstring & tabstring & "-") Then
                        If currentsection = "groups" Then
                            currentuser.world("all").addgroup(lines(i).Split(CChar("-"))(1).Remove(0, 1))
                        ElseIf currentsection = "permissions" Then
                            If lines(i).Remove(0, tabstring.Length * 2 + 2).StartsWith("-") Then
                                currentuser.world("all").addperm(lines(i).Remove(0, tabstring.Length * 2 + 3), False)
                            Else
                                currentuser.world("all").addperm(lines(i).Remove(0, tabstring.Length * 2 + 2), True)
                            End If
                        End If
                    End If
                    'find world name
                    If lines(i).StartsWith(tabstring & tabstring & tabstring) Then
                        'same reason for test split
                        If Not lines(i).Remove(0, tabstring.Length * 3).StartsWith(" ") Then
                            currentworldname = lines(i).Remove(lines(i).IndexOf(":")).Remove(0, tabstring.Length * 3)
                            currentuser.addworld(currentworldname)
                        End If
                    End If

                    'find world specific permissions
                    If lines(i).StartsWith(tabstring & tabstring & tabstring & tabstring & "-") Then
                        If currentsubsection = "permissions" Then
                            If lines(i).Remove(0, tabstring.Length * 4 + 2).StartsWith("-") Then
                                currentuser.world(currentworldname).addperm(lines(i).Remove(0, tabstring.Length * 4 + 3), False)
                            Else
                                currentuser.world(currentworldname).addperm(lines(i).Remove(0, tabstring.Length * 4 + 2), True)
                            End If
                        ElseIf currentsubsection = "groups" Then
                            currentuser.world(currentworldname).addgroup(lines(i).Remove(0, tabstring.Length * 4 + 2))
                        End If
                    End If
                    'find world specific prefix
                    If lines(i).StartsWith(tabstring & tabstring & tabstring & tabstring & "prefix:") Then
                        currentuser.world(currentworldname).prefix = lines(i).Split(CChar("'"))(1)
                    End If
                    If i < lines.Length - 1 Then
                        If lines(i + 1).StartsWith("groups:") Then
                            i += 1
                            Exit While
                        End If
                    End If
                    i += 1
                    StatusProgressBar1.Value = CInt(100 * i / lines.Length - 1)
                End While
            End If
        Loop Until i >= lines.Length
    End Sub

    Private Sub populatetreeview(ByVal treeviewnbr As Integer)
        Select Case treeviewnbr
            Case 1
                TreeViewG.Nodes.Clear()
                For Each treegroup As Group In groupslist
                    TreeViewG.Nodes.Add(treegroup.name, treegroup.name)
                    TreeViewG.Nodes(treegroup.name).Nodes.Add("isdefault", "Default: " & treegroup.isdefault)
                    TreeViewG.Nodes(treegroup.name).Nodes.Add("prefix", "Prefix(es)")
                    TreeViewG.Nodes(treegroup.name).Nodes.Add("inheritance", "Inherits")
                    For Each treeinherit As String In treegroup.inheritsfrom
                        TreeViewG.Nodes(treegroup.name).Nodes("inheritance").Nodes.Add(treeinherit, treeinherit)
                    Next
                    TreeViewG.Nodes(treegroup.name).Nodes.Add("permissions", "Permissions")
                    For Each treeworld In treegroup.getworlds()
                        TreeViewG.Nodes(treegroup.name).Nodes("prefix").Nodes.Add(treeworld.name, treeworld.name & " : " & treeworld.prefix)
                        TreeViewG.Nodes(treegroup.name).Nodes("permissions").Nodes.Add(treeworld.name, treeworld.name)
                        For Each treeperm As Permission In treegroup.world(treeworld.name).permissions()
                            TreeViewG.Nodes(treegroup.name).Nodes("permissions").Nodes(treeworld.name).Nodes.Add(treeperm.text, treeperm.text & " : " & treeperm.state)
                        Next
                    Next
                    TreeViewG.Nodes(treegroup.name).Nodes.Add("options", "Options")
                    For Each treeoption As GroupOption In treegroup.getoptions
                        TreeViewG.Nodes(treegroup.name).Nodes("options").Nodes.Add(treeoption.text, treeoption.text & " : " & treeoption.value)
                    Next
                Next
            Case 2
                TreeViewU.Nodes.Clear()

                For Each treeuser As User In userslist
                    TreeViewU.Nodes.Add(treeuser.name, treeuser.name)
                    TreeViewU.Nodes(treeuser.name).Nodes.Add("prefix", "Prefix(es)")
                    TreeViewU.Nodes(treeuser.name).Nodes.Add("groups", "Groups")
                    TreeViewU.Nodes(treeuser.name).Nodes.Add("permissions", "Permissions")
                    For Each treeworld In treeuser.getworlds()
                        If TreeViewU.Nodes(treeuser.name).Nodes.IndexOfKey("prefix") >= 0 Then
                            TreeViewU.Nodes(treeuser.name).Nodes("prefix").Nodes.Add(treeworld.name, treeworld.name & " : " & treeworld.prefix)
                        End If
                        If TreeViewU.Nodes(treeuser.name).Nodes.IndexOfKey("permissions") >= 0 Then
                            TreeViewU.Nodes(treeuser.name).Nodes("permissions").Nodes.Add(treeworld.name, treeworld.name)
                            For Each treeperm As Permission In treeuser.world(treeworld.name).permissions()
                                TreeViewU.Nodes(treeuser.name).Nodes("permissions").Nodes(treeworld.name).Nodes.Add(treeperm.text, treeperm.text & " : " & treeperm.state)
                            Next
                        End If
                        If TreeViewU.Nodes(treeuser.name).Nodes.IndexOfKey("groups") >= 0 Then
                            TreeViewU.Nodes(treeuser.name).Nodes("groups").Nodes.Add(treeworld.name, treeworld.name)
                            For Each groupname As String In treeworld.getgroups
                                TreeViewU.Nodes(treeuser.name).Nodes("groups").Nodes(treeworld.name).Nodes.Add(groupname, groupname)
                            Next
                        End If
                    Next
                Next
        End Select
    End Sub

    Private Sub sortlists()
        groupslist.Sort()
        userslist.Sort()
        For Each scangroup In groupslist
            scangroup.inheritsfrom.Sort()
            scangroup.getoptions.Sort()
            scangroup.getworlds.Sort()
            For Each scanworld In scangroup.getworlds
                scanworld.permissions.Sort()
            Next
        Next
        For Each scanuser In userslist
            scanuser.getworlds.Sort()
            For Each scanworld In scanuser.getworlds
                scanworld.permissions.Sort()
                scanworld.getgroups.Sort()
            Next
        Next
        Dim prevnode As String

        If Not TreeViewG.SelectedNode Is Nothing Then
            'store previous node path and remove anything after the space e.g. randomperm : True
            prevnode = TreeViewG.SelectedNode.FullPath.Split(CChar(" "))(0)
        Else
            prevnode = Nothing
        End If
        TreeViewG.Sort()
        TreeViewU.Sort()
        If Not prevnode Is Nothing Then
            Dim node As TreeNode = TreeViewG.Nodes(prevnode.Split(CChar("/"))(0))
            For i As Integer = 1 To prevnode.Split(CChar("/")).Count - 1
                node = node.Nodes(prevnode.Split(CChar("/"))(i))
            Next
            TreeViewG.SelectedNode = node
        End If
    End Sub

    Private Sub refreshrecentfiles()  'remove irrelevant files in recent files list
        RecentFilesToolStripMenuItem.DropDownItems.Clear()
        Dim toremove As New List(Of Integer)
        For Each oldfilename As String In My.Settings.recentfiles
            If File.Exists(oldfilename) Then
                RecentFilesToolStripMenuItem.DropDownItems.Add(oldfilename)
            Else
                toremove.Add(My.Settings.recentfiles.IndexOf(oldfilename))
            End If
        Next
        For Each i As Integer In toremove
            My.Settings.recentfiles.RemoveAt(i)
        Next
        My.Settings.Save()
    End Sub

    Private Sub delfiles()    'cleans up all unnecessary files for exit
        If File.Exists(appdir & Path.DirectorySeparatorChar & "perms.yml") Then
            File.Delete(appdir & Path.DirectorySeparatorChar & "perms.yml")
        End If
        If File.Exists(appdir & Path.DirectorySeparatorChar & "lastsave.yml") Then
            File.Delete(appdir & Path.DirectorySeparatorChar & "lastsave.yml")
        End If
        For Each scanfile In Directory.GetFiles(appdir & Path.DirectorySeparatorChar & "temp")
            File.Delete(scanfile)
        Next
        If File.Exists(appdir + "writing.yml") Then
            File.Delete(appdir + "writing.yml")
        End If
    End Sub


#Region "Write to file background worker"
    Private Sub WriteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WriteToolStripMenuItem.Click
        StatusLabel1.Text = "Writing changes..."
        WriteChanges()
    End Sub

    Private Sub WriteChanges()
        If BckGrndWrkWritetofile.IsBusy Then
            BckGrndWrkWritetofile.CancelAsync()
        Else
            BckGrndWrkWritetofile.RunWorkerAsync()
        End If
    End Sub

    Private Sub BckGrndWrkWritetofile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BckGrndWrkWritetofile.DoWork
        Dim temppath As String = appdir + Path.DirectorySeparatorChar + "temp" + Path.DirectorySeparatorChar
        'a new action removes all the redoes
        For Each scanfile In Directory.GetFiles(appdir & Path.DirectorySeparatorChar & "temp")
            If scanfile.Contains(".yml.redo") Then
                File.Delete(scanfile)
            End If
        Next
        If File.Exists(temppath + CStr(My.Settings.maxundoes) + ".yml.undo") Then
            File.Delete(temppath + CStr(My.Settings.maxundoes) + ".yml.undo")
        End If
        For i As Integer = My.Settings.maxundoes - 1 To 1 Step -1
            If File.Exists(temppath + CStr(i) + ".yml.undo") Then
                File.Move(temppath + CStr(i) + ".yml.undo", temppath + CStr(i + 1) + ".yml.undo")
            End If
        Next
        File.Copy(appdir + Path.DirectorySeparatorChar + "perms.yml", temppath + Path.DirectorySeparatorChar + "1.yml.undo")
        temppath = appdir + Path.DirectorySeparatorChar + "writing.yml"
        Dim prcnt As Integer = 0
        BckGrndWrkWritetofile.ReportProgress(prcnt)
        File.WriteAllText(temppath, "groups:")
        For Each writegroup In groupslist
            File.AppendAllText(temppath, vbCrLf & tabstring & writegroup.name & ":" & vbCrLf & tabstring & tabstring & "default:")
            If writegroup.isdefault = True Then
                File.AppendAllText(temppath, " true")
            Else
                File.AppendAllText(temppath, " false")
            End If
            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "prefix: '" & writegroup.world("all").prefix & "'")
            If writegroup.inheritsfrom.Count > 0 Then
                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "inheritance:")
                For Each gname In writegroup.inheritsfrom
                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "- " & gname)
                Next
            End If
            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "permissions:")
            For Each writeperm As Permission In writegroup.world("all").permissions
                If writeperm.state = True Then
                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "- " & writeperm.text)
                Else
                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "- -" & writeperm.text)
                End If
            Next
            If writegroup.getworlds.Count > 1 Then
                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "worlds:")
                For Each writeworld As World In writegroup.getworlds
                    If writeworld.name <> "All worlds" Then
                        File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & writeworld.name & ":")
                        If writeworld.prefix <> "None set" Then
                            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "prefix: '" & writeworld.prefix & "'")
                        End If
                        If writeworld.permissions.Count > 0 Then
                            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "permissions:")
                            For Each perm As Permission In writeworld.permissions
                                If perm.state = True Then
                                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "- " & perm.text)
                                Else
                                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "- -" & perm.text)
                                End If
                            Next
                        End If
                    End If
                Next
            End If
            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "options:")
            For Each writeoption As GroupOption In writegroup.getoptions
                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & writeoption.text & ": '" & writeoption.value & "'")
            Next
            prcnt += CInt(groupslist.Count / 50)
            BckGrndWrkWritetofile.ReportProgress(prcnt)
        Next
        File.AppendAllText(temppath, vbCrLf & "users:")
        prcnt = 50
        BckGrndWrkWritetofile.ReportProgress(prcnt)
        For Each writeuser In userslist
            File.AppendAllText(temppath, vbCrLf & tabstring & writeuser.name & ":")
            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "group:")
            For Each writegroup In writeuser.world("all").getgroups
                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "- " & writegroup)
            Next
            If writeuser.world("all").permissions.Count > 0 Then
                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "permissions:")
                For Each perm In writeuser.world("all").permissions
                    If perm.state = True Then
                        File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "- " & perm.text)
                    Else
                        File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "- -" & perm.text)
                    End If
                Next
            End If
            If writeuser.getworlds.Count > 1 Then
                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & "worlds:")
                For Each writeworld As World In writeuser.getworlds
                    If writeworld.name <> "All worlds" Then
                        File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & writeworld.name & ":")
                        If writeworld.prefix <> "None set" Then
                            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "prefix: '" & writeworld.prefix & "'")
                        End If
                        If writeworld.getgroups.Count > 0 Then
                            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "group:")
                            For Each writegroup In writeworld.getgroups
                                File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "- " & writegroup)
                            Next
                        End If
                        If writeworld.permissions.Count > 0 Then
                            File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "permissions:")
                            For Each perm As Permission In writeworld.permissions
                                If perm.state = True Then
                                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "- " & perm.text)
                                Else
                                    File.AppendAllText(temppath, vbCrLf & tabstring & tabstring & tabstring & tabstring & "- -" & perm.text)
                                End If
                            Next
                        End If
                    End If
                Next
            End If
            prcnt += CInt(userslist.Count / 50)
            BckGrndWrkWritetofile.ReportProgress(prcnt)
        Next
        File.Delete(appdir + Path.DirectorySeparatorChar + "perms.yml")
        File.Move(appdir + Path.DirectorySeparatorChar + "writing.yml", appdir + Path.DirectorySeparatorChar + "perms.yml")
    End Sub

    Private Sub BckGrndWrkWritetofile_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BckGrndWrkWritetofile.ProgressChanged
        StatusProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BckGrndWrkWritetofile_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BckGrndWrkWritetofile.RunWorkerCompleted
        UndoToolStripMenuItem.Enabled = True
        'cannot redo after writing a new change
        RedoToolStripMenuItem.Enabled = False
        StatusProgressBar1.Value = StatusProgressBar1.Maximum
        waitHandle.Set()
    End Sub
#End Region

#Region "Testing area"
    Private Sub TabLengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabLengthToolStripMenuItem.Click
        Dim ok As Boolean = True
        Dim strg As String
        Do
            strg = InputBox("Please enter the length of tabs in your file", "Tab length", CStr(My.Settings.tablength))
            If strg = String.Empty Or strg = CStr(My.Settings.tablength) Then
                Exit Do
            End If
            Try
                If CInt(strg) <= 0 Or CInt(strg) > 10 Then
                    MsgBox("Please do not use " + CStr(IIf(CInt(strg) > 0, "values larger than 10", "negative values")) + ".", MsgBoxStyle.Exclamation, "Error")
                    ok = False
                    Exit Try
                End If
                My.Settings.tablength = CInt(strg)
                ok = True
            Catch ex As Exception
                ok = False
            End Try
        Loop While ok = False

        tabstring = ""
        For i As Integer = 1 To My.Settings.tablength
            tabstring = tabstring & " "
        Next

    End Sub


    Private Sub MaxUndoNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaxUndoNumberToolStripMenuItem.Click
        Dim ok As Boolean = True
        Dim strg As String
        Do
            strg = InputBox("Please enter the max number of undoes" + vbCrLf + "Beware! Setting this to more than 20 can use up disk and slow the program down...", "Maximum possible undoes", CStr(My.Settings.maxundoes))
            If strg = String.Empty Or strg = CStr(My.Settings.maxundoes) Then
                Exit Do
            End If
            Try
                If CInt(strg) <= 0 Or CInt(strg) > 50 Then
                    MsgBox("Please do not use " + CStr(IIf(CInt(strg) > 0, "values larger than 50", "negative values")) + ".", MsgBoxStyle.Exclamation, "Error")
                    ok = False
                    Exit Try
                End If
                My.Settings.maxundoes = CInt(strg)
                ok = True
            Catch ex As Exception
                ok = False
            End Try
        Loop While ok = False
    End Sub
#End Region


End Class

