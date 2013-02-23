<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageGroups = New System.Windows.Forms.TabPage()
        Me.SplitContainerGroupsTab = New System.Windows.Forms.SplitContainer()
        Me.TreeViewG = New System.Windows.Forms.TreeView()
        Me.TabControlGroups = New System.Windows.Forms.TabControl()
        Me.TabPageGroups_General = New System.Windows.Forms.TabPage()
        Me.SplitContainerGroupActions = New System.Windows.Forms.SplitContainer()
        Me.GpBxNewGroup = New System.Windows.Forms.GroupBox()
        Me.ComboNewGroupName = New System.Windows.Forms.ComboBox()
        Me.BtnGroupNew = New System.Windows.Forms.Button()
        Me.GpBxRank = New System.Windows.Forms.GroupBox()
        Me.SplitContainerRankMgmt = New System.Windows.Forms.SplitContainer()
        Me.ComboRnkLaddr = New System.Windows.Forms.ComboBox()
        Me.BtnLaddrAdd = New System.Windows.Forms.Button()
        Me.TxtBxNewLaddr = New System.Windows.Forms.TextBox()
        Me.BtnRmRnk = New System.Windows.Forms.Button()
        Me.BtnAddRank = New System.Windows.Forms.Button()
        Me.LstBxRankedGrps = New System.Windows.Forms.ListBox()
        Me.LstBoxAllGroups = New System.Windows.Forms.ListBox()
        Me.TabPageGroups_Info = New System.Windows.Forms.TabPage()
        Me.SplitContainerGroupSettings = New System.Windows.Forms.SplitContainer()
        Me.GpBxGroupInherit = New System.Windows.Forms.GroupBox()
        Me.SplitContainerGroupInherit = New System.Windows.Forms.SplitContainer()
        Me.LstBxGroupInherit = New System.Windows.Forms.ListBox()
        Me.ComboInheritsName = New System.Windows.Forms.ComboBox()
        Me.BtnAddInherit = New System.Windows.Forms.Button()
        Me.BtnRemoveInherit = New System.Windows.Forms.Button()
        Me.GpBxGroupOptions = New System.Windows.Forms.GroupBox()
        Me.SplitContainerGroupOptions = New System.Windows.Forms.SplitContainer()
        Me.LstVwGrpOptions = New System.Windows.Forms.ListView()
        Me.OptionColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValueColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CntxtMenuOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CntxtMenuOptionsEditItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtMenuOptionsDuplicateItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtMenuOptionsRemoveItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblOptions = New System.Windows.Forms.Label()
        Me.BtnAddOption = New System.Windows.Forms.Button()
        Me.BtnRmOption = New System.Windows.Forms.Button()
        Me.GpBxGroupGeneral = New System.Windows.Forms.GroupBox()
        Me.BtnGroupDuplicate = New System.Windows.Forms.Button()
        Me.LblGroupname = New System.Windows.Forms.Label()
        Me.ChckBxDefault = New System.Windows.Forms.CheckBox()
        Me.BtnGroupDelete = New System.Windows.Forms.Button()
        Me.TxtBxGroupname = New System.Windows.Forms.TextBox()
        Me.BtnGroupNameSet = New System.Windows.Forms.Button()
        Me.TabPageGroups_Prefixes = New System.Windows.Forms.TabPage()
        Me.SplitContainerWorldSettings = New System.Windows.Forms.SplitContainer()
        Me.GpBxWorld = New System.Windows.Forms.GroupBox()
        Me.BtnWorldnameSet = New System.Windows.Forms.Button()
        Me.TxtBxWorldname = New System.Windows.Forms.TextBox()
        Me.GpBxPrefix = New System.Windows.Forms.GroupBox()
        Me.TxtBxPrefix = New System.Windows.Forms.TextBox()
        Me.BtnPrefixUnset = New System.Windows.Forms.Button()
        Me.LblFormattedPrefix = New System.Windows.Forms.Label()
        Me.BtnPrefixSet = New System.Windows.Forms.Button()
        Me.GpBxSelectWorld = New System.Windows.Forms.GroupBox()
        Me.SplitContainerWorldSelection = New System.Windows.Forms.SplitContainer()
        Me.LstBxPrefixWorlds = New System.Windows.Forms.ListBox()
        Me.ComboNewWorldName = New System.Windows.Forms.ComboBox()
        Me.BtnWorldDelete = New System.Windows.Forms.Button()
        Me.BtnAddWorld = New System.Windows.Forms.Button()
        Me.TabPageGroups_Permissions = New System.Windows.Forms.TabPage()
        Me.SplitContainerPermsTab = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerPermsTab2 = New System.Windows.Forms.SplitContainer()
        Me.GpbBxSlctWorldPerm = New System.Windows.Forms.GroupBox()
        Me.ComboPermWorld = New System.Windows.Forms.ComboBox()
        Me.LblPermissions1 = New System.Windows.Forms.Label()
        Me.LstVwGroupPerms = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CntxtMenuPerms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CntxtMenuPermsEditItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtMenuPermsDuplicateItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtMenuPermsRemoveItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRmPerm = New System.Windows.Forms.Button()
        Me.BtnAddPerm = New System.Windows.Forms.Button()
        Me.TabPageUsers = New System.Windows.Forms.TabPage()
        Me.SplitContainerUsersTab = New System.Windows.Forms.SplitContainer()
        Me.TreeViewU = New System.Windows.Forms.TreeView()
        Me.TabControlUsers = New System.Windows.Forms.TabControl()
        Me.TabPageUsers_Actions = New System.Windows.Forms.TabPage()
        Me.GrpBxUCurrent = New System.Windows.Forms.GroupBox()
        Me.BtnUDuplicate = New System.Windows.Forms.Button()
        Me.LblUName = New System.Windows.Forms.Label()
        Me.BtnURm = New System.Windows.Forms.Button()
        Me.TxtBxUName = New System.Windows.Forms.TextBox()
        Me.BtnUNameSet = New System.Windows.Forms.Button()
        Me.GpBxNewUser = New System.Windows.Forms.GroupBox()
        Me.ComboNewUser = New System.Windows.Forms.ComboBox()
        Me.BtnAddUser = New System.Windows.Forms.Button()
        Me.TabPageUsers_Prefix = New System.Windows.Forms.TabPage()
        Me.SplitContainerUWorldSettings = New System.Windows.Forms.SplitContainer()
        Me.GpBxUWorldSettings = New System.Windows.Forms.GroupBox()
        Me.BtnUWorldnameSet = New System.Windows.Forms.Button()
        Me.TxtBxUWorldname = New System.Windows.Forms.TextBox()
        Me.SplitContainerU = New System.Windows.Forms.SplitContainer()
        Me.GpbxUPrefix = New System.Windows.Forms.GroupBox()
        Me.TxtBxUPrefix = New System.Windows.Forms.TextBox()
        Me.BtnUPrefixClear = New System.Windows.Forms.Button()
        Me.LlbUFormattedprefix = New System.Windows.Forms.Label()
        Me.BtnUPrefixSet = New System.Windows.Forms.Button()
        Me.GpBxUGroups = New System.Windows.Forms.GroupBox()
        Me.LstBxUGroups = New System.Windows.Forms.CheckedListBox()
        Me.GpbxUWorldselect = New System.Windows.Forms.GroupBox()
        Me.SplitContainerUWorldSelection = New System.Windows.Forms.SplitContainer()
        Me.LstBxUPrefixWorlds = New System.Windows.Forms.ListBox()
        Me.ComboUNewWorldName = New System.Windows.Forms.ComboBox()
        Me.BtnURmWorld = New System.Windows.Forms.Button()
        Me.BtnUAddWorld = New System.Windows.Forms.Button()
        Me.TabPageUsers_Permissions = New System.Windows.Forms.TabPage()
        Me.SplitContainerUPermsTab1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerUPermsTab2 = New System.Windows.Forms.SplitContainer()
        Me.GpBxUSelectWorld = New System.Windows.Forms.GroupBox()
        Me.ComboUPermWorld = New System.Windows.Forms.ComboBox()
        Me.LblUPermissions1 = New System.Windows.Forms.Label()
        Me.LstVwUserPerms = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnURmPerm = New System.Windows.Forms.Button()
        Me.BtnUAddPerm = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClrHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabLengthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaxUndoNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpSubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BckGrndWrkWritetofile = New System.ComponentModel.BackgroundWorker()
        Me.ToolTipGroup = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPageGroups.SuspendLayout()
        CType(Me.SplitContainerGroupsTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGroupsTab.Panel1.SuspendLayout()
        Me.SplitContainerGroupsTab.Panel2.SuspendLayout()
        Me.SplitContainerGroupsTab.SuspendLayout()
        Me.TabControlGroups.SuspendLayout()
        Me.TabPageGroups_General.SuspendLayout()
        CType(Me.SplitContainerGroupActions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGroupActions.Panel1.SuspendLayout()
        Me.SplitContainerGroupActions.Panel2.SuspendLayout()
        Me.SplitContainerGroupActions.SuspendLayout()
        Me.GpBxNewGroup.SuspendLayout()
        Me.GpBxRank.SuspendLayout()
        CType(Me.SplitContainerRankMgmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerRankMgmt.Panel1.SuspendLayout()
        Me.SplitContainerRankMgmt.Panel2.SuspendLayout()
        Me.SplitContainerRankMgmt.SuspendLayout()
        Me.TabPageGroups_Info.SuspendLayout()
        CType(Me.SplitContainerGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGroupSettings.Panel1.SuspendLayout()
        Me.SplitContainerGroupSettings.Panel2.SuspendLayout()
        Me.SplitContainerGroupSettings.SuspendLayout()
        Me.GpBxGroupInherit.SuspendLayout()
        CType(Me.SplitContainerGroupInherit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGroupInherit.Panel1.SuspendLayout()
        Me.SplitContainerGroupInherit.Panel2.SuspendLayout()
        Me.SplitContainerGroupInherit.SuspendLayout()
        Me.GpBxGroupOptions.SuspendLayout()
        CType(Me.SplitContainerGroupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerGroupOptions.Panel1.SuspendLayout()
        Me.SplitContainerGroupOptions.Panel2.SuspendLayout()
        Me.SplitContainerGroupOptions.SuspendLayout()
        Me.CntxtMenuOptions.SuspendLayout()
        Me.GpBxGroupGeneral.SuspendLayout()
        Me.TabPageGroups_Prefixes.SuspendLayout()
        CType(Me.SplitContainerWorldSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerWorldSettings.Panel1.SuspendLayout()
        Me.SplitContainerWorldSettings.Panel2.SuspendLayout()
        Me.SplitContainerWorldSettings.SuspendLayout()
        Me.GpBxWorld.SuspendLayout()
        Me.GpBxPrefix.SuspendLayout()
        Me.GpBxSelectWorld.SuspendLayout()
        CType(Me.SplitContainerWorldSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerWorldSelection.Panel1.SuspendLayout()
        Me.SplitContainerWorldSelection.Panel2.SuspendLayout()
        Me.SplitContainerWorldSelection.SuspendLayout()
        Me.TabPageGroups_Permissions.SuspendLayout()
        CType(Me.SplitContainerPermsTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPermsTab.Panel1.SuspendLayout()
        Me.SplitContainerPermsTab.Panel2.SuspendLayout()
        Me.SplitContainerPermsTab.SuspendLayout()
        CType(Me.SplitContainerPermsTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPermsTab2.Panel1.SuspendLayout()
        Me.SplitContainerPermsTab2.Panel2.SuspendLayout()
        Me.SplitContainerPermsTab2.SuspendLayout()
        Me.GpbBxSlctWorldPerm.SuspendLayout()
        Me.CntxtMenuPerms.SuspendLayout()
        Me.TabPageUsers.SuspendLayout()
        CType(Me.SplitContainerUsersTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUsersTab.Panel1.SuspendLayout()
        Me.SplitContainerUsersTab.Panel2.SuspendLayout()
        Me.SplitContainerUsersTab.SuspendLayout()
        Me.TabControlUsers.SuspendLayout()
        Me.TabPageUsers_Actions.SuspendLayout()
        Me.GrpBxUCurrent.SuspendLayout()
        Me.GpBxNewUser.SuspendLayout()
        Me.TabPageUsers_Prefix.SuspendLayout()
        CType(Me.SplitContainerUWorldSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUWorldSettings.Panel1.SuspendLayout()
        Me.SplitContainerUWorldSettings.Panel2.SuspendLayout()
        Me.SplitContainerUWorldSettings.SuspendLayout()
        Me.GpBxUWorldSettings.SuspendLayout()
        CType(Me.SplitContainerU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerU.Panel1.SuspendLayout()
        Me.SplitContainerU.Panel2.SuspendLayout()
        Me.SplitContainerU.SuspendLayout()
        Me.GpbxUPrefix.SuspendLayout()
        Me.GpBxUGroups.SuspendLayout()
        Me.GpbxUWorldselect.SuspendLayout()
        CType(Me.SplitContainerUWorldSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUWorldSelection.Panel1.SuspendLayout()
        Me.SplitContainerUWorldSelection.Panel2.SuspendLayout()
        Me.SplitContainerUWorldSelection.SuspendLayout()
        Me.TabPageUsers_Permissions.SuspendLayout()
        CType(Me.SplitContainerUPermsTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUPermsTab1.Panel1.SuspendLayout()
        Me.SplitContainerUPermsTab1.Panel2.SuspendLayout()
        Me.SplitContainerUPermsTab1.SuspendLayout()
        CType(Me.SplitContainerUPermsTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUPermsTab2.Panel1.SuspendLayout()
        Me.SplitContainerUPermsTab2.Panel2.SuspendLayout()
        Me.SplitContainerUPermsTab2.SuspendLayout()
        Me.GpBxUSelectWorld.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "yaml files|*.yml"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageGroups)
        Me.TabControl1.Controls.Add(Me.TabPageUsers)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(933, 438)
        Me.TabControl1.TabIndex = 1
        '
        'TabPageGroups
        '
        Me.TabPageGroups.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageGroups.Controls.Add(Me.SplitContainerGroupsTab)
        Me.TabPageGroups.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGroups.Name = "TabPageGroups"
        Me.TabPageGroups.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGroups.Size = New System.Drawing.Size(925, 412)
        Me.TabPageGroups.TabIndex = 0
        Me.TabPageGroups.Text = "Groups"
        '
        'SplitContainerGroupsTab
        '
        Me.SplitContainerGroupsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerGroupsTab.IsSplitterFixed = True
        Me.SplitContainerGroupsTab.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerGroupsTab.Name = "SplitContainerGroupsTab"
        '
        'SplitContainerGroupsTab.Panel1
        '
        Me.SplitContainerGroupsTab.Panel1.Controls.Add(Me.TreeViewG)
        '
        'SplitContainerGroupsTab.Panel2
        '
        Me.SplitContainerGroupsTab.Panel2.Controls.Add(Me.TabControlGroups)
        Me.SplitContainerGroupsTab.Size = New System.Drawing.Size(919, 406)
        Me.SplitContainerGroupsTab.SplitterDistance = 272
        Me.SplitContainerGroupsTab.TabIndex = 1
        '
        'TreeViewG
        '
        Me.TreeViewG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewG.HideSelection = False
        Me.TreeViewG.Indent = 20
        Me.TreeViewG.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewG.Name = "TreeViewG"
        Me.TreeViewG.PathSeparator = "/"
        Me.TreeViewG.Size = New System.Drawing.Size(272, 406)
        Me.TreeViewG.TabIndex = 0
        '
        'TabControlGroups
        '
        Me.TabControlGroups.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlGroups.Controls.Add(Me.TabPageGroups_General)
        Me.TabControlGroups.Controls.Add(Me.TabPageGroups_Info)
        Me.TabControlGroups.Controls.Add(Me.TabPageGroups_Prefixes)
        Me.TabControlGroups.Controls.Add(Me.TabPageGroups_Permissions)
        Me.TabControlGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlGroups.Location = New System.Drawing.Point(0, 0)
        Me.TabControlGroups.Multiline = True
        Me.TabControlGroups.Name = "TabControlGroups"
        Me.TabControlGroups.SelectedIndex = 0
        Me.TabControlGroups.Size = New System.Drawing.Size(643, 406)
        Me.TabControlGroups.TabIndex = 0
        Me.TabControlGroups.Visible = False
        '
        'TabPageGroups_General
        '
        Me.TabPageGroups_General.Controls.Add(Me.SplitContainerGroupActions)
        Me.TabPageGroups_General.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGroups_General.Name = "TabPageGroups_General"
        Me.TabPageGroups_General.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGroups_General.Size = New System.Drawing.Size(635, 377)
        Me.TabPageGroups_General.TabIndex = 2
        Me.TabPageGroups_General.Text = "Group actions"
        Me.TabPageGroups_General.UseVisualStyleBackColor = True
        '
        'SplitContainerGroupActions
        '
        Me.SplitContainerGroupActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerGroupActions.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerGroupActions.Name = "SplitContainerGroupActions"
        Me.SplitContainerGroupActions.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerGroupActions.Panel1
        '
        Me.SplitContainerGroupActions.Panel1.Controls.Add(Me.GpBxNewGroup)
        '
        'SplitContainerGroupActions.Panel2
        '
        Me.SplitContainerGroupActions.Panel2.Controls.Add(Me.GpBxRank)
        Me.SplitContainerGroupActions.Size = New System.Drawing.Size(629, 371)
        Me.SplitContainerGroupActions.SplitterDistance = 49
        Me.SplitContainerGroupActions.TabIndex = 2
        '
        'GpBxNewGroup
        '
        Me.GpBxNewGroup.Controls.Add(Me.ComboNewGroupName)
        Me.GpBxNewGroup.Controls.Add(Me.BtnGroupNew)
        Me.GpBxNewGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxNewGroup.Location = New System.Drawing.Point(0, 0)
        Me.GpBxNewGroup.Name = "GpBxNewGroup"
        Me.GpBxNewGroup.Size = New System.Drawing.Size(629, 49)
        Me.GpBxNewGroup.TabIndex = 0
        Me.GpBxNewGroup.TabStop = False
        Me.GpBxNewGroup.Text = "New group"
        '
        'ComboNewGroupName
        '
        Me.ComboNewGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboNewGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboNewGroupName.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboNewGroupName.FormattingEnabled = True
        Me.ComboNewGroupName.Items.AddRange(New Object() {"Admin", "Default", "Moderator"})
        Me.ComboNewGroupName.Location = New System.Drawing.Point(6, 19)
        Me.ComboNewGroupName.Name = "ComboNewGroupName"
        Me.ComboNewGroupName.Size = New System.Drawing.Size(163, 21)
        Me.ComboNewGroupName.Sorted = True
        Me.ComboNewGroupName.TabIndex = 1
        Me.ComboNewGroupName.Text = "Add new group"
        '
        'BtnGroupNew
        '
        Me.BtnGroupNew.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnGroupNew.Location = New System.Drawing.Point(175, 13)
        Me.BtnGroupNew.Name = "BtnGroupNew"
        Me.BtnGroupNew.Size = New System.Drawing.Size(37, 31)
        Me.BtnGroupNew.TabIndex = 0
        Me.ToolTipGroup.SetToolTip(Me.BtnGroupNew, "Add group (Enter)")
        Me.BtnGroupNew.UseVisualStyleBackColor = True
        '
        'GpBxRank
        '
        Me.GpBxRank.Controls.Add(Me.SplitContainerRankMgmt)
        Me.GpBxRank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxRank.Location = New System.Drawing.Point(0, 0)
        Me.GpBxRank.Name = "GpBxRank"
        Me.GpBxRank.Size = New System.Drawing.Size(629, 318)
        Me.GpBxRank.TabIndex = 0
        Me.GpBxRank.TabStop = False
        Me.GpBxRank.Text = "Rank management"
        Me.GpBxRank.Visible = False
        '
        'SplitContainerRankMgmt
        '
        Me.SplitContainerRankMgmt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerRankMgmt.IsSplitterFixed = True
        Me.SplitContainerRankMgmt.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerRankMgmt.Name = "SplitContainerRankMgmt"
        Me.SplitContainerRankMgmt.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerRankMgmt.Panel1
        '
        Me.SplitContainerRankMgmt.Panel1.Controls.Add(Me.ComboRnkLaddr)
        Me.SplitContainerRankMgmt.Panel1.Controls.Add(Me.BtnLaddrAdd)
        Me.SplitContainerRankMgmt.Panel1.Controls.Add(Me.TxtBxNewLaddr)
        '
        'SplitContainerRankMgmt.Panel2
        '
        Me.SplitContainerRankMgmt.Panel2.Controls.Add(Me.BtnRmRnk)
        Me.SplitContainerRankMgmt.Panel2.Controls.Add(Me.BtnAddRank)
        Me.SplitContainerRankMgmt.Panel2.Controls.Add(Me.LstBxRankedGrps)
        Me.SplitContainerRankMgmt.Panel2.Controls.Add(Me.LstBoxAllGroups)
        Me.SplitContainerRankMgmt.Size = New System.Drawing.Size(623, 299)
        Me.SplitContainerRankMgmt.SplitterDistance = 37
        Me.SplitContainerRankMgmt.TabIndex = 0
        '
        'ComboRnkLaddr
        '
        Me.ComboRnkLaddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboRnkLaddr.FormattingEnabled = True
        Me.ComboRnkLaddr.Location = New System.Drawing.Point(0, 8)
        Me.ComboRnkLaddr.Name = "ComboRnkLaddr"
        Me.ComboRnkLaddr.Size = New System.Drawing.Size(162, 21)
        Me.ComboRnkLaddr.TabIndex = 0
        '
        'BtnLaddrAdd
        '
        Me.BtnLaddrAdd.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnLaddrAdd.Location = New System.Drawing.Point(355, 3)
        Me.BtnLaddrAdd.Name = "BtnLaddrAdd"
        Me.BtnLaddrAdd.Size = New System.Drawing.Size(37, 31)
        Me.BtnLaddrAdd.TabIndex = 2
        Me.BtnLaddrAdd.UseVisualStyleBackColor = True
        '
        'TxtBxNewLaddr
        '
        Me.TxtBxNewLaddr.Location = New System.Drawing.Point(168, 9)
        Me.TxtBxNewLaddr.Name = "TxtBxNewLaddr"
        Me.TxtBxNewLaddr.Size = New System.Drawing.Size(181, 20)
        Me.TxtBxNewLaddr.TabIndex = 1
        '
        'BtnRmRnk
        '
        Me.BtnRmRnk.Image = Global.WindowsApplication1.My.Resources.Resources.go_previous
        Me.BtnRmRnk.Location = New System.Drawing.Point(258, 117)
        Me.BtnRmRnk.Name = "BtnRmRnk"
        Me.BtnRmRnk.Size = New System.Drawing.Size(62, 58)
        Me.BtnRmRnk.TabIndex = 3
        Me.BtnRmRnk.UseVisualStyleBackColor = True
        '
        'BtnAddRank
        '
        Me.BtnAddRank.Image = Global.WindowsApplication1.My.Resources.Resources.go_next
        Me.BtnAddRank.Location = New System.Drawing.Point(258, 39)
        Me.BtnAddRank.Name = "BtnAddRank"
        Me.BtnAddRank.Size = New System.Drawing.Size(62, 59)
        Me.BtnAddRank.TabIndex = 2
        Me.BtnAddRank.UseVisualStyleBackColor = True
        '
        'LstBxRankedGrps
        '
        Me.LstBxRankedGrps.Dock = System.Windows.Forms.DockStyle.Right
        Me.LstBxRankedGrps.FormattingEnabled = True
        Me.LstBxRankedGrps.Location = New System.Drawing.Point(403, 0)
        Me.LstBxRankedGrps.Name = "LstBxRankedGrps"
        Me.LstBxRankedGrps.Size = New System.Drawing.Size(220, 258)
        Me.LstBxRankedGrps.TabIndex = 1
        '
        'LstBoxAllGroups
        '
        Me.LstBoxAllGroups.Dock = System.Windows.Forms.DockStyle.Left
        Me.LstBoxAllGroups.FormattingEnabled = True
        Me.LstBoxAllGroups.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxAllGroups.Name = "LstBoxAllGroups"
        Me.LstBoxAllGroups.Size = New System.Drawing.Size(181, 258)
        Me.LstBoxAllGroups.TabIndex = 0
        '
        'TabPageGroups_Info
        '
        Me.TabPageGroups_Info.Controls.Add(Me.SplitContainerGroupSettings)
        Me.TabPageGroups_Info.Controls.Add(Me.GpBxGroupGeneral)
        Me.TabPageGroups_Info.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGroups_Info.Name = "TabPageGroups_Info"
        Me.TabPageGroups_Info.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGroups_Info.Size = New System.Drawing.Size(635, 377)
        Me.TabPageGroups_Info.TabIndex = 0
        Me.TabPageGroups_Info.Text = "Group settings"
        Me.TabPageGroups_Info.UseVisualStyleBackColor = True
        '
        'SplitContainerGroupSettings
        '
        Me.SplitContainerGroupSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerGroupSettings.IsSplitterFixed = True
        Me.SplitContainerGroupSettings.Location = New System.Drawing.Point(3, 66)
        Me.SplitContainerGroupSettings.Name = "SplitContainerGroupSettings"
        '
        'SplitContainerGroupSettings.Panel1
        '
        Me.SplitContainerGroupSettings.Panel1.Controls.Add(Me.GpBxGroupInherit)
        '
        'SplitContainerGroupSettings.Panel2
        '
        Me.SplitContainerGroupSettings.Panel2.Controls.Add(Me.GpBxGroupOptions)
        Me.SplitContainerGroupSettings.Size = New System.Drawing.Size(629, 308)
        Me.SplitContainerGroupSettings.SplitterDistance = 226
        Me.SplitContainerGroupSettings.TabIndex = 1
        '
        'GpBxGroupInherit
        '
        Me.GpBxGroupInherit.Controls.Add(Me.SplitContainerGroupInherit)
        Me.GpBxGroupInherit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxGroupInherit.Location = New System.Drawing.Point(0, 0)
        Me.GpBxGroupInherit.Name = "GpBxGroupInherit"
        Me.GpBxGroupInherit.Size = New System.Drawing.Size(226, 308)
        Me.GpBxGroupInherit.TabIndex = 0
        Me.GpBxGroupInherit.TabStop = False
        Me.GpBxGroupInherit.Text = "Inheritance"
        '
        'SplitContainerGroupInherit
        '
        Me.SplitContainerGroupInherit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerGroupInherit.IsSplitterFixed = True
        Me.SplitContainerGroupInherit.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerGroupInherit.Name = "SplitContainerGroupInherit"
        Me.SplitContainerGroupInherit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerGroupInherit.Panel1
        '
        Me.SplitContainerGroupInherit.Panel1.Controls.Add(Me.LstBxGroupInherit)
        '
        'SplitContainerGroupInherit.Panel2
        '
        Me.SplitContainerGroupInherit.Panel2.Controls.Add(Me.ComboInheritsName)
        Me.SplitContainerGroupInherit.Panel2.Controls.Add(Me.BtnAddInherit)
        Me.SplitContainerGroupInherit.Panel2.Controls.Add(Me.BtnRemoveInherit)
        Me.SplitContainerGroupInherit.Size = New System.Drawing.Size(220, 289)
        Me.SplitContainerGroupInherit.SplitterDistance = 248
        Me.SplitContainerGroupInherit.TabIndex = 0
        '
        'LstBxGroupInherit
        '
        Me.LstBxGroupInherit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBxGroupInherit.FormattingEnabled = True
        Me.LstBxGroupInherit.HorizontalScrollbar = True
        Me.LstBxGroupInherit.Location = New System.Drawing.Point(0, 0)
        Me.LstBxGroupInherit.Name = "LstBxGroupInherit"
        Me.LstBxGroupInherit.Size = New System.Drawing.Size(220, 248)
        Me.LstBxGroupInherit.Sorted = True
        Me.LstBxGroupInherit.TabIndex = 0
        '
        'ComboInheritsName
        '
        Me.ComboInheritsName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboInheritsName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboInheritsName.FormattingEnabled = True
        Me.ComboInheritsName.Location = New System.Drawing.Point(3, 9)
        Me.ComboInheritsName.Name = "ComboInheritsName"
        Me.ComboInheritsName.Size = New System.Drawing.Size(128, 21)
        Me.ComboInheritsName.Sorted = True
        Me.ComboInheritsName.TabIndex = 10
        Me.ComboInheritsName.Text = "Add group"
        '
        'BtnAddInherit
        '
        Me.BtnAddInherit.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnAddInherit.Location = New System.Drawing.Point(137, 3)
        Me.BtnAddInherit.Name = "BtnAddInherit"
        Me.BtnAddInherit.Size = New System.Drawing.Size(37, 31)
        Me.BtnAddInherit.TabIndex = 8
        Me.ToolTipGroup.SetToolTip(Me.BtnAddInherit, "Add group for inherit (Enter)")
        Me.BtnAddInherit.UseVisualStyleBackColor = True
        '
        'BtnRemoveInherit
        '
        Me.BtnRemoveInherit.Enabled = False
        Me.BtnRemoveInherit.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnRemoveInherit.Location = New System.Drawing.Point(180, 3)
        Me.BtnRemoveInherit.Name = "BtnRemoveInherit"
        Me.BtnRemoveInherit.Size = New System.Drawing.Size(37, 31)
        Me.BtnRemoveInherit.TabIndex = 9
        Me.ToolTipGroup.SetToolTip(Me.BtnRemoveInherit, "Remove selected inheritance (Delete)")
        Me.BtnRemoveInherit.UseVisualStyleBackColor = True
        '
        'GpBxGroupOptions
        '
        Me.GpBxGroupOptions.Controls.Add(Me.SplitContainerGroupOptions)
        Me.GpBxGroupOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxGroupOptions.Location = New System.Drawing.Point(0, 0)
        Me.GpBxGroupOptions.Name = "GpBxGroupOptions"
        Me.GpBxGroupOptions.Size = New System.Drawing.Size(399, 308)
        Me.GpBxGroupOptions.TabIndex = 0
        Me.GpBxGroupOptions.TabStop = False
        Me.GpBxGroupOptions.Text = "Options"
        '
        'SplitContainerGroupOptions
        '
        Me.SplitContainerGroupOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerGroupOptions.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerGroupOptions.Name = "SplitContainerGroupOptions"
        Me.SplitContainerGroupOptions.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerGroupOptions.Panel1
        '
        Me.SplitContainerGroupOptions.Panel1.Controls.Add(Me.LstVwGrpOptions)
        '
        'SplitContainerGroupOptions.Panel2
        '
        Me.SplitContainerGroupOptions.Panel2.Controls.Add(Me.LblOptions)
        Me.SplitContainerGroupOptions.Panel2.Controls.Add(Me.BtnAddOption)
        Me.SplitContainerGroupOptions.Panel2.Controls.Add(Me.BtnRmOption)
        Me.SplitContainerGroupOptions.Size = New System.Drawing.Size(393, 289)
        Me.SplitContainerGroupOptions.SplitterDistance = 246
        Me.SplitContainerGroupOptions.TabIndex = 0
        '
        'LstVwGrpOptions
        '
        Me.LstVwGrpOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OptionColumn, Me.ValueColumn})
        Me.LstVwGrpOptions.ContextMenuStrip = Me.CntxtMenuOptions
        Me.LstVwGrpOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstVwGrpOptions.FullRowSelect = True
        Me.LstVwGrpOptions.GridLines = True
        Me.LstVwGrpOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstVwGrpOptions.HideSelection = False
        Me.LstVwGrpOptions.Location = New System.Drawing.Point(0, 0)
        Me.LstVwGrpOptions.MultiSelect = False
        Me.LstVwGrpOptions.Name = "LstVwGrpOptions"
        Me.LstVwGrpOptions.ShowItemToolTips = True
        Me.LstVwGrpOptions.Size = New System.Drawing.Size(393, 246)
        Me.LstVwGrpOptions.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVwGrpOptions.TabIndex = 0
        Me.LstVwGrpOptions.UseCompatibleStateImageBehavior = False
        Me.LstVwGrpOptions.View = System.Windows.Forms.View.Details
        '
        'OptionColumn
        '
        Me.OptionColumn.Text = "Option"
        Me.OptionColumn.Width = 328
        '
        'ValueColumn
        '
        Me.ValueColumn.Text = "Value"
        '
        'CntxtMenuOptions
        '
        Me.CntxtMenuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntxtMenuOptionsEditItem, Me.CntxtMenuOptionsDuplicateItem, Me.CntxtMenuOptionsRemoveItem})
        Me.CntxtMenuOptions.Name = "CntxtMenuOptions"
        Me.CntxtMenuOptions.Size = New System.Drawing.Size(125, 70)
        '
        'CntxtMenuOptionsEditItem
        '
        Me.CntxtMenuOptionsEditItem.Name = "CntxtMenuOptionsEditItem"
        Me.CntxtMenuOptionsEditItem.Size = New System.Drawing.Size(124, 22)
        Me.CntxtMenuOptionsEditItem.Text = "Edit"
        Me.CntxtMenuOptionsEditItem.ToolTipText = "Edit this option's title and value"
        '
        'CntxtMenuOptionsDuplicateItem
        '
        Me.CntxtMenuOptionsDuplicateItem.Name = "CntxtMenuOptionsDuplicateItem"
        Me.CntxtMenuOptionsDuplicateItem.Size = New System.Drawing.Size(124, 22)
        Me.CntxtMenuOptionsDuplicateItem.Text = "Duplicate"
        '
        'CntxtMenuOptionsRemoveItem
        '
        Me.CntxtMenuOptionsRemoveItem.Name = "CntxtMenuOptionsRemoveItem"
        Me.CntxtMenuOptionsRemoveItem.Size = New System.Drawing.Size(124, 22)
        Me.CntxtMenuOptionsRemoveItem.Text = "Remove"
        Me.CntxtMenuOptionsRemoveItem.ToolTipText = "Remove this option"
        '
        'LblOptions
        '
        Me.LblOptions.AutoSize = True
        Me.LblOptions.Location = New System.Drawing.Point(3, 13)
        Me.LblOptions.Name = "LblOptions"
        Me.LblOptions.Size = New System.Drawing.Size(222, 13)
        Me.LblOptions.TabIndex = 12
        Me.LblOptions.Text = "Double click option to edit, right click for more"
        '
        'BtnAddOption
        '
        Me.BtnAddOption.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnAddOption.Location = New System.Drawing.Point(310, 4)
        Me.BtnAddOption.Name = "BtnAddOption"
        Me.BtnAddOption.Size = New System.Drawing.Size(37, 31)
        Me.BtnAddOption.TabIndex = 10
        Me.ToolTipGroup.SetToolTip(Me.BtnAddOption, "New Option")
        Me.BtnAddOption.UseVisualStyleBackColor = True
        '
        'BtnRmOption
        '
        Me.BtnRmOption.Enabled = False
        Me.BtnRmOption.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnRmOption.Location = New System.Drawing.Point(353, 4)
        Me.BtnRmOption.Name = "BtnRmOption"
        Me.BtnRmOption.Size = New System.Drawing.Size(37, 31)
        Me.BtnRmOption.TabIndex = 11
        Me.ToolTipGroup.SetToolTip(Me.BtnRmOption, "Remove selected")
        Me.BtnRmOption.UseVisualStyleBackColor = True
        '
        'GpBxGroupGeneral
        '
        Me.GpBxGroupGeneral.Controls.Add(Me.BtnGroupDuplicate)
        Me.GpBxGroupGeneral.Controls.Add(Me.LblGroupname)
        Me.GpBxGroupGeneral.Controls.Add(Me.ChckBxDefault)
        Me.GpBxGroupGeneral.Controls.Add(Me.BtnGroupDelete)
        Me.GpBxGroupGeneral.Controls.Add(Me.TxtBxGroupname)
        Me.GpBxGroupGeneral.Controls.Add(Me.BtnGroupNameSet)
        Me.GpBxGroupGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpBxGroupGeneral.Location = New System.Drawing.Point(3, 3)
        Me.GpBxGroupGeneral.Name = "GpBxGroupGeneral"
        Me.GpBxGroupGeneral.Size = New System.Drawing.Size(629, 63)
        Me.GpBxGroupGeneral.TabIndex = 0
        Me.GpBxGroupGeneral.TabStop = False
        Me.GpBxGroupGeneral.Text = "General"
        '
        'BtnGroupDuplicate
        '
        Me.BtnGroupDuplicate.Image = Global.WindowsApplication1.My.Resources.Resources.duplicate
        Me.BtnGroupDuplicate.Location = New System.Drawing.Point(302, 7)
        Me.BtnGroupDuplicate.Name = "BtnGroupDuplicate"
        Me.BtnGroupDuplicate.Size = New System.Drawing.Size(37, 31)
        Me.BtnGroupDuplicate.TabIndex = 9
        Me.ToolTipGroup.SetToolTip(Me.BtnGroupDuplicate, "Duplicate group")
        Me.BtnGroupDuplicate.UseVisualStyleBackColor = True
        '
        'LblGroupname
        '
        Me.LblGroupname.AutoSize = True
        Me.LblGroupname.Location = New System.Drawing.Point(6, 16)
        Me.LblGroupname.Name = "LblGroupname"
        Me.LblGroupname.Size = New System.Drawing.Size(68, 13)
        Me.LblGroupname.TabIndex = 0
        Me.LblGroupname.Text = "Group name:"
        '
        'ChckBxDefault
        '
        Me.ChckBxDefault.AutoCheck = False
        Me.ChckBxDefault.AutoSize = True
        Me.ChckBxDefault.Location = New System.Drawing.Point(9, 39)
        Me.ChckBxDefault.Name = "ChckBxDefault"
        Me.ChckBxDefault.Size = New System.Drawing.Size(90, 17)
        Me.ChckBxDefault.TabIndex = 2
        Me.ChckBxDefault.Text = "Default group"
        Me.ChckBxDefault.UseVisualStyleBackColor = True
        '
        'BtnGroupDelete
        '
        Me.BtnGroupDelete.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnGroupDelete.Location = New System.Drawing.Point(259, 7)
        Me.BtnGroupDelete.Name = "BtnGroupDelete"
        Me.BtnGroupDelete.Size = New System.Drawing.Size(37, 31)
        Me.BtnGroupDelete.TabIndex = 5
        Me.ToolTipGroup.SetToolTip(Me.BtnGroupDelete, "Delete Group (Delete)")
        Me.BtnGroupDelete.UseVisualStyleBackColor = True
        '
        'TxtBxGroupname
        '
        Me.TxtBxGroupname.Location = New System.Drawing.Point(80, 13)
        Me.TxtBxGroupname.Name = "TxtBxGroupname"
        Me.TxtBxGroupname.Size = New System.Drawing.Size(130, 20)
        Me.TxtBxGroupname.TabIndex = 3
        '
        'BtnGroupNameSet
        '
        Me.BtnGroupNameSet.Image = Global.WindowsApplication1.My.Resources.Resources.dialog_ok
        Me.BtnGroupNameSet.Location = New System.Drawing.Point(216, 7)
        Me.BtnGroupNameSet.Name = "BtnGroupNameSet"
        Me.BtnGroupNameSet.Size = New System.Drawing.Size(37, 31)
        Me.BtnGroupNameSet.TabIndex = 4
        Me.ToolTipGroup.SetToolTip(Me.BtnGroupNameSet, "Accept changes (Enter)")
        Me.BtnGroupNameSet.UseVisualStyleBackColor = True
        '
        'TabPageGroups_Prefixes
        '
        Me.TabPageGroups_Prefixes.Controls.Add(Me.SplitContainerWorldSettings)
        Me.TabPageGroups_Prefixes.Controls.Add(Me.GpBxSelectWorld)
        Me.TabPageGroups_Prefixes.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGroups_Prefixes.Name = "TabPageGroups_Prefixes"
        Me.TabPageGroups_Prefixes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGroups_Prefixes.Size = New System.Drawing.Size(635, 377)
        Me.TabPageGroups_Prefixes.TabIndex = 3
        Me.TabPageGroups_Prefixes.Text = "Worlds & Prefixes"
        Me.TabPageGroups_Prefixes.UseVisualStyleBackColor = True
        '
        'SplitContainerWorldSettings
        '
        Me.SplitContainerWorldSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerWorldSettings.Location = New System.Drawing.Point(185, 3)
        Me.SplitContainerWorldSettings.Name = "SplitContainerWorldSettings"
        Me.SplitContainerWorldSettings.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerWorldSettings.Panel1
        '
        Me.SplitContainerWorldSettings.Panel1.Controls.Add(Me.GpBxWorld)
        '
        'SplitContainerWorldSettings.Panel2
        '
        Me.SplitContainerWorldSettings.Panel2.Controls.Add(Me.GpBxPrefix)
        Me.SplitContainerWorldSettings.Size = New System.Drawing.Size(447, 371)
        Me.SplitContainerWorldSettings.SplitterDistance = 157
        Me.SplitContainerWorldSettings.TabIndex = 10
        '
        'GpBxWorld
        '
        Me.GpBxWorld.Controls.Add(Me.BtnWorldnameSet)
        Me.GpBxWorld.Controls.Add(Me.TxtBxWorldname)
        Me.GpBxWorld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxWorld.Location = New System.Drawing.Point(0, 0)
        Me.GpBxWorld.Name = "GpBxWorld"
        Me.GpBxWorld.Size = New System.Drawing.Size(447, 157)
        Me.GpBxWorld.TabIndex = 9
        Me.GpBxWorld.TabStop = False
        Me.GpBxWorld.Text = "World settings"
        '
        'BtnWorldnameSet
        '
        Me.BtnWorldnameSet.Enabled = False
        Me.BtnWorldnameSet.Image = Global.WindowsApplication1.My.Resources.Resources.dialog_ok
        Me.BtnWorldnameSet.Location = New System.Drawing.Point(169, 10)
        Me.BtnWorldnameSet.Name = "BtnWorldnameSet"
        Me.BtnWorldnameSet.Size = New System.Drawing.Size(37, 31)
        Me.BtnWorldnameSet.TabIndex = 8
        Me.BtnWorldnameSet.UseVisualStyleBackColor = True
        '
        'TxtBxWorldname
        '
        Me.TxtBxWorldname.Location = New System.Drawing.Point(6, 16)
        Me.TxtBxWorldname.Name = "TxtBxWorldname"
        Me.TxtBxWorldname.ReadOnly = True
        Me.TxtBxWorldname.Size = New System.Drawing.Size(156, 20)
        Me.TxtBxWorldname.TabIndex = 0
        Me.TxtBxWorldname.Text = "No world selected"
        '
        'GpBxPrefix
        '
        Me.GpBxPrefix.Controls.Add(Me.TxtBxPrefix)
        Me.GpBxPrefix.Controls.Add(Me.BtnPrefixUnset)
        Me.GpBxPrefix.Controls.Add(Me.LblFormattedPrefix)
        Me.GpBxPrefix.Controls.Add(Me.BtnPrefixSet)
        Me.GpBxPrefix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxPrefix.Location = New System.Drawing.Point(0, 0)
        Me.GpBxPrefix.Name = "GpBxPrefix"
        Me.GpBxPrefix.Size = New System.Drawing.Size(447, 210)
        Me.GpBxPrefix.TabIndex = 8
        Me.GpBxPrefix.TabStop = False
        Me.GpBxPrefix.Text = "Prefix"
        '
        'TxtBxPrefix
        '
        Me.TxtBxPrefix.Location = New System.Drawing.Point(7, 19)
        Me.TxtBxPrefix.Name = "TxtBxPrefix"
        Me.TxtBxPrefix.ReadOnly = True
        Me.TxtBxPrefix.Size = New System.Drawing.Size(156, 20)
        Me.TxtBxPrefix.TabIndex = 3
        Me.TxtBxPrefix.Text = "No world selected"
        '
        'BtnPrefixUnset
        '
        Me.BtnPrefixUnset.Enabled = False
        Me.BtnPrefixUnset.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.BtnPrefixUnset.Location = New System.Drawing.Point(169, 13)
        Me.BtnPrefixUnset.Name = "BtnPrefixUnset"
        Me.BtnPrefixUnset.Size = New System.Drawing.Size(37, 31)
        Me.BtnPrefixUnset.TabIndex = 6
        Me.BtnPrefixUnset.UseVisualStyleBackColor = True
        '
        'LblFormattedPrefix
        '
        Me.LblFormattedPrefix.AutoSize = True
        Me.LblFormattedPrefix.Location = New System.Drawing.Point(6, 53)
        Me.LblFormattedPrefix.Name = "LblFormattedPrefix"
        Me.LblFormattedPrefix.Size = New System.Drawing.Size(87, 13)
        Me.LblFormattedPrefix.TabIndex = 7
        Me.LblFormattedPrefix.Text = "Formated output:"
        '
        'BtnPrefixSet
        '
        Me.BtnPrefixSet.Enabled = False
        Me.BtnPrefixSet.Image = Global.WindowsApplication1.My.Resources.Resources.dialog_ok
        Me.BtnPrefixSet.Location = New System.Drawing.Point(212, 13)
        Me.BtnPrefixSet.Name = "BtnPrefixSet"
        Me.BtnPrefixSet.Size = New System.Drawing.Size(37, 31)
        Me.BtnPrefixSet.TabIndex = 5
        Me.BtnPrefixSet.UseVisualStyleBackColor = True
        '
        'GpBxSelectWorld
        '
        Me.GpBxSelectWorld.Controls.Add(Me.SplitContainerWorldSelection)
        Me.GpBxSelectWorld.Dock = System.Windows.Forms.DockStyle.Left
        Me.GpBxSelectWorld.Location = New System.Drawing.Point(3, 3)
        Me.GpBxSelectWorld.Name = "GpBxSelectWorld"
        Me.GpBxSelectWorld.Size = New System.Drawing.Size(182, 371)
        Me.GpBxSelectWorld.TabIndex = 2
        Me.GpBxSelectWorld.TabStop = False
        Me.GpBxSelectWorld.Text = "Please select world(s):"
        '
        'SplitContainerWorldSelection
        '
        Me.SplitContainerWorldSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerWorldSelection.IsSplitterFixed = True
        Me.SplitContainerWorldSelection.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerWorldSelection.Name = "SplitContainerWorldSelection"
        Me.SplitContainerWorldSelection.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerWorldSelection.Panel1
        '
        Me.SplitContainerWorldSelection.Panel1.Controls.Add(Me.LstBxPrefixWorlds)
        '
        'SplitContainerWorldSelection.Panel2
        '
        Me.SplitContainerWorldSelection.Panel2.Controls.Add(Me.ComboNewWorldName)
        Me.SplitContainerWorldSelection.Panel2.Controls.Add(Me.BtnWorldDelete)
        Me.SplitContainerWorldSelection.Panel2.Controls.Add(Me.BtnAddWorld)
        Me.SplitContainerWorldSelection.Size = New System.Drawing.Size(176, 352)
        Me.SplitContainerWorldSelection.SplitterDistance = 311
        Me.SplitContainerWorldSelection.TabIndex = 0
        '
        'LstBxPrefixWorlds
        '
        Me.LstBxPrefixWorlds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBxPrefixWorlds.FormattingEnabled = True
        Me.LstBxPrefixWorlds.HorizontalScrollbar = True
        Me.LstBxPrefixWorlds.Location = New System.Drawing.Point(0, 0)
        Me.LstBxPrefixWorlds.Name = "LstBxPrefixWorlds"
        Me.LstBxPrefixWorlds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LstBxPrefixWorlds.Size = New System.Drawing.Size(176, 311)
        Me.LstBxPrefixWorlds.Sorted = True
        Me.LstBxPrefixWorlds.TabIndex = 0
        '
        'ComboNewWorldName
        '
        Me.ComboNewWorldName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboNewWorldName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboNewWorldName.FormattingEnabled = True
        Me.ComboNewWorldName.Location = New System.Drawing.Point(3, 8)
        Me.ComboNewWorldName.Name = "ComboNewWorldName"
        Me.ComboNewWorldName.Size = New System.Drawing.Size(84, 21)
        Me.ComboNewWorldName.Sorted = True
        Me.ComboNewWorldName.TabIndex = 7
        Me.ComboNewWorldName.Text = "New world"
        '
        'BtnWorldDelete
        '
        Me.BtnWorldDelete.Enabled = False
        Me.BtnWorldDelete.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnWorldDelete.Location = New System.Drawing.Point(136, 2)
        Me.BtnWorldDelete.Name = "BtnWorldDelete"
        Me.BtnWorldDelete.Size = New System.Drawing.Size(37, 31)
        Me.BtnWorldDelete.TabIndex = 6
        Me.BtnWorldDelete.UseVisualStyleBackColor = True
        '
        'BtnAddWorld
        '
        Me.BtnAddWorld.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnAddWorld.Location = New System.Drawing.Point(93, 2)
        Me.BtnAddWorld.Name = "BtnAddWorld"
        Me.BtnAddWorld.Size = New System.Drawing.Size(37, 31)
        Me.BtnAddWorld.TabIndex = 1
        Me.BtnAddWorld.UseVisualStyleBackColor = True
        '
        'TabPageGroups_Permissions
        '
        Me.TabPageGroups_Permissions.Controls.Add(Me.SplitContainerPermsTab)
        Me.TabPageGroups_Permissions.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGroups_Permissions.Name = "TabPageGroups_Permissions"
        Me.TabPageGroups_Permissions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGroups_Permissions.Size = New System.Drawing.Size(635, 377)
        Me.TabPageGroups_Permissions.TabIndex = 4
        Me.TabPageGroups_Permissions.Text = "Permissions"
        Me.TabPageGroups_Permissions.UseVisualStyleBackColor = True
        '
        'SplitContainerPermsTab
        '
        Me.SplitContainerPermsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPermsTab.IsSplitterFixed = True
        Me.SplitContainerPermsTab.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerPermsTab.Name = "SplitContainerPermsTab"
        Me.SplitContainerPermsTab.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPermsTab.Panel1
        '
        Me.SplitContainerPermsTab.Panel1.Controls.Add(Me.SplitContainerPermsTab2)
        '
        'SplitContainerPermsTab.Panel2
        '
        Me.SplitContainerPermsTab.Panel2.Controls.Add(Me.BtnRmPerm)
        Me.SplitContainerPermsTab.Panel2.Controls.Add(Me.BtnAddPerm)
        Me.SplitContainerPermsTab.Size = New System.Drawing.Size(629, 371)
        Me.SplitContainerPermsTab.SplitterDistance = 328
        Me.SplitContainerPermsTab.TabIndex = 12
        '
        'SplitContainerPermsTab2
        '
        Me.SplitContainerPermsTab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPermsTab2.IsSplitterFixed = True
        Me.SplitContainerPermsTab2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerPermsTab2.Name = "SplitContainerPermsTab2"
        Me.SplitContainerPermsTab2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPermsTab2.Panel1
        '
        Me.SplitContainerPermsTab2.Panel1.Controls.Add(Me.GpbBxSlctWorldPerm)
        '
        'SplitContainerPermsTab2.Panel2
        '
        Me.SplitContainerPermsTab2.Panel2.Controls.Add(Me.LstVwGroupPerms)
        Me.SplitContainerPermsTab2.Size = New System.Drawing.Size(629, 328)
        Me.SplitContainerPermsTab2.SplitterDistance = 57
        Me.SplitContainerPermsTab2.TabIndex = 2
        '
        'GpbBxSlctWorldPerm
        '
        Me.GpbBxSlctWorldPerm.Controls.Add(Me.ComboPermWorld)
        Me.GpbBxSlctWorldPerm.Controls.Add(Me.LblPermissions1)
        Me.GpbBxSlctWorldPerm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpbBxSlctWorldPerm.Location = New System.Drawing.Point(0, 0)
        Me.GpbBxSlctWorldPerm.Name = "GpbBxSlctWorldPerm"
        Me.GpbBxSlctWorldPerm.Size = New System.Drawing.Size(629, 57)
        Me.GpbBxSlctWorldPerm.TabIndex = 1
        Me.GpbBxSlctWorldPerm.TabStop = False
        Me.GpbBxSlctWorldPerm.Text = "Please select a world from list"
        '
        'ComboPermWorld
        '
        Me.ComboPermWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPermWorld.FormattingEnabled = True
        Me.ComboPermWorld.Items.AddRange(New Object() {"All worlds"})
        Me.ComboPermWorld.Location = New System.Drawing.Point(6, 19)
        Me.ComboPermWorld.Name = "ComboPermWorld"
        Me.ComboPermWorld.Size = New System.Drawing.Size(207, 21)
        Me.ComboPermWorld.Sorted = True
        Me.ComboPermWorld.TabIndex = 9
        '
        'LblPermissions1
        '
        Me.LblPermissions1.AutoSize = True
        Me.LblPermissions1.Location = New System.Drawing.Point(219, 22)
        Me.LblPermissions1.Name = "LblPermissions1"
        Me.LblPermissions1.Size = New System.Drawing.Size(286, 13)
        Me.LblPermissions1.TabIndex = 11
        Me.LblPermissions1.Text = "Note: To add a new world please use the worlds tab above"
        '
        'LstVwGroupPerms
        '
        Me.LstVwGroupPerms.CheckBoxes = True
        Me.LstVwGroupPerms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LstVwGroupPerms.ContextMenuStrip = Me.CntxtMenuPerms
        Me.LstVwGroupPerms.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVwGroupPerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstVwGroupPerms.FullRowSelect = True
        Me.LstVwGroupPerms.GridLines = True
        Me.LstVwGroupPerms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LstVwGroupPerms.HideSelection = False
        Me.LstVwGroupPerms.LabelEdit = True
        Me.LstVwGroupPerms.Location = New System.Drawing.Point(0, 0)
        Me.LstVwGroupPerms.Name = "LstVwGroupPerms"
        Me.LstVwGroupPerms.ShowItemToolTips = True
        Me.LstVwGroupPerms.Size = New System.Drawing.Size(629, 267)
        Me.LstVwGroupPerms.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVwGroupPerms.TabIndex = 1
        Me.LstVwGroupPerms.UseCompatibleStateImageBehavior = False
        Me.LstVwGroupPerms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 626
        '
        'CntxtMenuPerms
        '
        Me.CntxtMenuPerms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntxtMenuPermsEditItem, Me.CntxtMenuPermsDuplicateItem, Me.CntxtMenuPermsRemoveItem})
        Me.CntxtMenuPerms.Name = "CntxtMenuPerms"
        Me.CntxtMenuPerms.Size = New System.Drawing.Size(153, 92)
        '
        'CntxtMenuPermsEditItem
        '
        Me.CntxtMenuPermsEditItem.Name = "CntxtMenuPermsEditItem"
        Me.CntxtMenuPermsEditItem.Size = New System.Drawing.Size(152, 22)
        Me.CntxtMenuPermsEditItem.Text = "Edit"
        '
        'CntxtMenuPermsDuplicateItem
        '
        Me.CntxtMenuPermsDuplicateItem.Name = "CntxtMenuPermsDuplicateItem"
        Me.CntxtMenuPermsDuplicateItem.Size = New System.Drawing.Size(152, 22)
        Me.CntxtMenuPermsDuplicateItem.Text = "Duplicate"
        '
        'CntxtMenuPermsRemoveItem
        '
        Me.CntxtMenuPermsRemoveItem.Name = "CntxtMenuPermsRemoveItem"
        Me.CntxtMenuPermsRemoveItem.Size = New System.Drawing.Size(152, 22)
        Me.CntxtMenuPermsRemoveItem.Text = "Remove"
        '
        'BtnRmPerm
        '
        Me.BtnRmPerm.Enabled = False
        Me.BtnRmPerm.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnRmPerm.Location = New System.Drawing.Point(589, 3)
        Me.BtnRmPerm.Name = "BtnRmPerm"
        Me.BtnRmPerm.Size = New System.Drawing.Size(37, 31)
        Me.BtnRmPerm.TabIndex = 8
        Me.BtnRmPerm.UseVisualStyleBackColor = True
        '
        'BtnAddPerm
        '
        Me.BtnAddPerm.Enabled = False
        Me.BtnAddPerm.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnAddPerm.Location = New System.Drawing.Point(546, 3)
        Me.BtnAddPerm.Name = "BtnAddPerm"
        Me.BtnAddPerm.Size = New System.Drawing.Size(37, 31)
        Me.BtnAddPerm.TabIndex = 7
        Me.BtnAddPerm.UseVisualStyleBackColor = True
        '
        'TabPageUsers
        '
        Me.TabPageUsers.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageUsers.Controls.Add(Me.SplitContainerUsersTab)
        Me.TabPageUsers.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUsers.Name = "TabPageUsers"
        Me.TabPageUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers.Size = New System.Drawing.Size(925, 412)
        Me.TabPageUsers.TabIndex = 1
        Me.TabPageUsers.Text = "Users"
        '
        'SplitContainerUsersTab
        '
        Me.SplitContainerUsersTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUsersTab.IsSplitterFixed = True
        Me.SplitContainerUsersTab.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerUsersTab.Name = "SplitContainerUsersTab"
        '
        'SplitContainerUsersTab.Panel1
        '
        Me.SplitContainerUsersTab.Panel1.Controls.Add(Me.TreeViewU)
        '
        'SplitContainerUsersTab.Panel2
        '
        Me.SplitContainerUsersTab.Panel2.Controls.Add(Me.TabControlUsers)
        Me.SplitContainerUsersTab.Size = New System.Drawing.Size(919, 406)
        Me.SplitContainerUsersTab.SplitterDistance = 272
        Me.SplitContainerUsersTab.TabIndex = 1
        '
        'TreeViewU
        '
        Me.TreeViewU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewU.HideSelection = False
        Me.TreeViewU.Indent = 10
        Me.TreeViewU.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewU.Name = "TreeViewU"
        Me.TreeViewU.PathSeparator = "/"
        Me.TreeViewU.Size = New System.Drawing.Size(272, 406)
        Me.TreeViewU.TabIndex = 0
        '
        'TabControlUsers
        '
        Me.TabControlUsers.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlUsers.Controls.Add(Me.TabPageUsers_Actions)
        Me.TabControlUsers.Controls.Add(Me.TabPageUsers_Prefix)
        Me.TabControlUsers.Controls.Add(Me.TabPageUsers_Permissions)
        Me.TabControlUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlUsers.Location = New System.Drawing.Point(0, 0)
        Me.TabControlUsers.Name = "TabControlUsers"
        Me.TabControlUsers.SelectedIndex = 0
        Me.TabControlUsers.Size = New System.Drawing.Size(643, 406)
        Me.TabControlUsers.TabIndex = 0
        Me.TabControlUsers.Visible = False
        '
        'TabPageUsers_Actions
        '
        Me.TabPageUsers_Actions.Controls.Add(Me.GrpBxUCurrent)
        Me.TabPageUsers_Actions.Controls.Add(Me.GpBxNewUser)
        Me.TabPageUsers_Actions.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUsers_Actions.Name = "TabPageUsers_Actions"
        Me.TabPageUsers_Actions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers_Actions.Size = New System.Drawing.Size(635, 377)
        Me.TabPageUsers_Actions.TabIndex = 0
        Me.TabPageUsers_Actions.Text = "User actions"
        Me.TabPageUsers_Actions.UseVisualStyleBackColor = True
        '
        'GrpBxUCurrent
        '
        Me.GrpBxUCurrent.Controls.Add(Me.BtnUDuplicate)
        Me.GrpBxUCurrent.Controls.Add(Me.LblUName)
        Me.GrpBxUCurrent.Controls.Add(Me.BtnURm)
        Me.GrpBxUCurrent.Controls.Add(Me.TxtBxUName)
        Me.GrpBxUCurrent.Controls.Add(Me.BtnUNameSet)
        Me.GrpBxUCurrent.Location = New System.Drawing.Point(3, 69)
        Me.GrpBxUCurrent.Name = "GrpBxUCurrent"
        Me.GrpBxUCurrent.Size = New System.Drawing.Size(349, 63)
        Me.GrpBxUCurrent.TabIndex = 2
        Me.GrpBxUCurrent.TabStop = False
        Me.GrpBxUCurrent.Text = "Current user"
        '
        'BtnUDuplicate
        '
        Me.BtnUDuplicate.Image = Global.WindowsApplication1.My.Resources.Resources.duplicate
        Me.BtnUDuplicate.Location = New System.Drawing.Point(302, 7)
        Me.BtnUDuplicate.Name = "BtnUDuplicate"
        Me.BtnUDuplicate.Size = New System.Drawing.Size(37, 31)
        Me.BtnUDuplicate.TabIndex = 9
        Me.ToolTipGroup.SetToolTip(Me.BtnUDuplicate, "Duplicate group")
        Me.BtnUDuplicate.UseVisualStyleBackColor = True
        '
        'LblUName
        '
        Me.LblUName.AutoSize = True
        Me.LblUName.Location = New System.Drawing.Point(6, 16)
        Me.LblUName.Name = "LblUName"
        Me.LblUName.Size = New System.Drawing.Size(61, 13)
        Me.LblUName.TabIndex = 0
        Me.LblUName.Text = "User name:"
        '
        'BtnURm
        '
        Me.BtnURm.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnURm.Location = New System.Drawing.Point(259, 7)
        Me.BtnURm.Name = "BtnURm"
        Me.BtnURm.Size = New System.Drawing.Size(37, 31)
        Me.BtnURm.TabIndex = 5
        Me.ToolTipGroup.SetToolTip(Me.BtnURm, "Delete Group (Delete)")
        Me.BtnURm.UseVisualStyleBackColor = True
        '
        'TxtBxUName
        '
        Me.TxtBxUName.Location = New System.Drawing.Point(80, 13)
        Me.TxtBxUName.Name = "TxtBxUName"
        Me.TxtBxUName.Size = New System.Drawing.Size(130, 20)
        Me.TxtBxUName.TabIndex = 3
        '
        'BtnUNameSet
        '
        Me.BtnUNameSet.Image = Global.WindowsApplication1.My.Resources.Resources.dialog_ok
        Me.BtnUNameSet.Location = New System.Drawing.Point(216, 7)
        Me.BtnUNameSet.Name = "BtnUNameSet"
        Me.BtnUNameSet.Size = New System.Drawing.Size(37, 31)
        Me.BtnUNameSet.TabIndex = 4
        Me.ToolTipGroup.SetToolTip(Me.BtnUNameSet, "Accept changes (Enter)")
        Me.BtnUNameSet.UseVisualStyleBackColor = True
        '
        'GpBxNewUser
        '
        Me.GpBxNewUser.Controls.Add(Me.ComboNewUser)
        Me.GpBxNewUser.Controls.Add(Me.BtnAddUser)
        Me.GpBxNewUser.Location = New System.Drawing.Point(3, 3)
        Me.GpBxNewUser.Name = "GpBxNewUser"
        Me.GpBxNewUser.Size = New System.Drawing.Size(236, 60)
        Me.GpBxNewUser.TabIndex = 1
        Me.GpBxNewUser.TabStop = False
        Me.GpBxNewUser.Text = "New User"
        '
        'ComboNewUser
        '
        Me.ComboNewUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboNewUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboNewUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboNewUser.FormattingEnabled = True
        Me.ComboNewUser.Items.AddRange(New Object() {"Admin", "Default", "Moderator"})
        Me.ComboNewUser.Location = New System.Drawing.Point(6, 19)
        Me.ComboNewUser.Name = "ComboNewUser"
        Me.ComboNewUser.Size = New System.Drawing.Size(163, 21)
        Me.ComboNewUser.Sorted = True
        Me.ComboNewUser.TabIndex = 1
        Me.ComboNewUser.Text = "Add new user"
        '
        'BtnAddUser
        '
        Me.BtnAddUser.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnAddUser.Location = New System.Drawing.Point(175, 13)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.Size = New System.Drawing.Size(37, 31)
        Me.BtnAddUser.TabIndex = 0
        Me.BtnAddUser.UseVisualStyleBackColor = True
        '
        'TabPageUsers_Prefix
        '
        Me.TabPageUsers_Prefix.Controls.Add(Me.SplitContainerUWorldSettings)
        Me.TabPageUsers_Prefix.Controls.Add(Me.GpbxUWorldselect)
        Me.TabPageUsers_Prefix.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUsers_Prefix.Name = "TabPageUsers_Prefix"
        Me.TabPageUsers_Prefix.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers_Prefix.Size = New System.Drawing.Size(635, 377)
        Me.TabPageUsers_Prefix.TabIndex = 1
        Me.TabPageUsers_Prefix.Text = "Worlds & Prefixes"
        Me.TabPageUsers_Prefix.UseVisualStyleBackColor = True
        '
        'SplitContainerUWorldSettings
        '
        Me.SplitContainerUWorldSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUWorldSettings.Location = New System.Drawing.Point(185, 3)
        Me.SplitContainerUWorldSettings.Name = "SplitContainerUWorldSettings"
        Me.SplitContainerUWorldSettings.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerUWorldSettings.Panel1
        '
        Me.SplitContainerUWorldSettings.Panel1.Controls.Add(Me.GpBxUWorldSettings)
        '
        'SplitContainerUWorldSettings.Panel2
        '
        Me.SplitContainerUWorldSettings.Panel2.Controls.Add(Me.SplitContainerU)
        Me.SplitContainerUWorldSettings.Size = New System.Drawing.Size(447, 371)
        Me.SplitContainerUWorldSettings.SplitterDistance = 46
        Me.SplitContainerUWorldSettings.TabIndex = 11
        '
        'GpBxUWorldSettings
        '
        Me.GpBxUWorldSettings.Controls.Add(Me.BtnUWorldnameSet)
        Me.GpBxUWorldSettings.Controls.Add(Me.TxtBxUWorldname)
        Me.GpBxUWorldSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxUWorldSettings.Location = New System.Drawing.Point(0, 0)
        Me.GpBxUWorldSettings.Name = "GpBxUWorldSettings"
        Me.GpBxUWorldSettings.Size = New System.Drawing.Size(447, 46)
        Me.GpBxUWorldSettings.TabIndex = 9
        Me.GpBxUWorldSettings.TabStop = False
        Me.GpBxUWorldSettings.Text = "World settings"
        '
        'BtnUWorldnameSet
        '
        Me.BtnUWorldnameSet.Enabled = False
        Me.BtnUWorldnameSet.Image = Global.WindowsApplication1.My.Resources.Resources.dialog_ok
        Me.BtnUWorldnameSet.Location = New System.Drawing.Point(169, 10)
        Me.BtnUWorldnameSet.Name = "BtnUWorldnameSet"
        Me.BtnUWorldnameSet.Size = New System.Drawing.Size(37, 31)
        Me.BtnUWorldnameSet.TabIndex = 8
        Me.BtnUWorldnameSet.UseVisualStyleBackColor = True
        '
        'TxtBxUWorldname
        '
        Me.TxtBxUWorldname.Location = New System.Drawing.Point(6, 16)
        Me.TxtBxUWorldname.Name = "TxtBxUWorldname"
        Me.TxtBxUWorldname.ReadOnly = True
        Me.TxtBxUWorldname.Size = New System.Drawing.Size(156, 20)
        Me.TxtBxUWorldname.TabIndex = 0
        Me.TxtBxUWorldname.Text = "No world selected"
        '
        'SplitContainerU
        '
        Me.SplitContainerU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerU.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerU.Name = "SplitContainerU"
        Me.SplitContainerU.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerU.Panel1
        '
        Me.SplitContainerU.Panel1.Controls.Add(Me.GpbxUPrefix)
        '
        'SplitContainerU.Panel2
        '
        Me.SplitContainerU.Panel2.Controls.Add(Me.GpBxUGroups)
        Me.SplitContainerU.Size = New System.Drawing.Size(447, 321)
        Me.SplitContainerU.SplitterDistance = 92
        Me.SplitContainerU.TabIndex = 9
        '
        'GpbxUPrefix
        '
        Me.GpbxUPrefix.Controls.Add(Me.TxtBxUPrefix)
        Me.GpbxUPrefix.Controls.Add(Me.BtnUPrefixClear)
        Me.GpbxUPrefix.Controls.Add(Me.LlbUFormattedprefix)
        Me.GpbxUPrefix.Controls.Add(Me.BtnUPrefixSet)
        Me.GpbxUPrefix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpbxUPrefix.Location = New System.Drawing.Point(0, 0)
        Me.GpbxUPrefix.Name = "GpbxUPrefix"
        Me.GpbxUPrefix.Size = New System.Drawing.Size(447, 92)
        Me.GpbxUPrefix.TabIndex = 8
        Me.GpbxUPrefix.TabStop = False
        Me.GpbxUPrefix.Text = "Prefix"
        '
        'TxtBxUPrefix
        '
        Me.TxtBxUPrefix.Location = New System.Drawing.Point(7, 19)
        Me.TxtBxUPrefix.Name = "TxtBxUPrefix"
        Me.TxtBxUPrefix.ReadOnly = True
        Me.TxtBxUPrefix.Size = New System.Drawing.Size(156, 20)
        Me.TxtBxUPrefix.TabIndex = 3
        Me.TxtBxUPrefix.Text = "No world selected"
        '
        'BtnUPrefixClear
        '
        Me.BtnUPrefixClear.Enabled = False
        Me.BtnUPrefixClear.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.BtnUPrefixClear.Location = New System.Drawing.Point(169, 13)
        Me.BtnUPrefixClear.Name = "BtnUPrefixClear"
        Me.BtnUPrefixClear.Size = New System.Drawing.Size(37, 31)
        Me.BtnUPrefixClear.TabIndex = 6
        Me.BtnUPrefixClear.UseVisualStyleBackColor = True
        '
        'LlbUFormattedprefix
        '
        Me.LlbUFormattedprefix.AutoSize = True
        Me.LlbUFormattedprefix.Location = New System.Drawing.Point(6, 53)
        Me.LlbUFormattedprefix.Name = "LlbUFormattedprefix"
        Me.LlbUFormattedprefix.Size = New System.Drawing.Size(87, 13)
        Me.LlbUFormattedprefix.TabIndex = 7
        Me.LlbUFormattedprefix.Text = "Formated output:"
        '
        'BtnUPrefixSet
        '
        Me.BtnUPrefixSet.Enabled = False
        Me.BtnUPrefixSet.Image = Global.WindowsApplication1.My.Resources.Resources.dialog_ok
        Me.BtnUPrefixSet.Location = New System.Drawing.Point(212, 13)
        Me.BtnUPrefixSet.Name = "BtnUPrefixSet"
        Me.BtnUPrefixSet.Size = New System.Drawing.Size(37, 31)
        Me.BtnUPrefixSet.TabIndex = 5
        Me.BtnUPrefixSet.UseVisualStyleBackColor = True
        '
        'GpBxUGroups
        '
        Me.GpBxUGroups.Controls.Add(Me.LstBxUGroups)
        Me.GpBxUGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxUGroups.Location = New System.Drawing.Point(0, 0)
        Me.GpBxUGroups.Name = "GpBxUGroups"
        Me.GpBxUGroups.Size = New System.Drawing.Size(447, 225)
        Me.GpBxUGroups.TabIndex = 1
        Me.GpBxUGroups.TabStop = False
        Me.GpBxUGroups.Text = "User's groups"
        '
        'LstBxUGroups
        '
        Me.LstBxUGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBxUGroups.FormattingEnabled = True
        Me.LstBxUGroups.Location = New System.Drawing.Point(3, 16)
        Me.LstBxUGroups.Name = "LstBxUGroups"
        Me.LstBxUGroups.Size = New System.Drawing.Size(441, 206)
        Me.LstBxUGroups.TabIndex = 0
        '
        'GpbxUWorldselect
        '
        Me.GpbxUWorldselect.Controls.Add(Me.SplitContainerUWorldSelection)
        Me.GpbxUWorldselect.Dock = System.Windows.Forms.DockStyle.Left
        Me.GpbxUWorldselect.Location = New System.Drawing.Point(3, 3)
        Me.GpbxUWorldselect.Name = "GpbxUWorldselect"
        Me.GpbxUWorldselect.Size = New System.Drawing.Size(182, 371)
        Me.GpbxUWorldselect.TabIndex = 10
        Me.GpbxUWorldselect.TabStop = False
        Me.GpbxUWorldselect.Text = "Please select world(s):"
        '
        'SplitContainerUWorldSelection
        '
        Me.SplitContainerUWorldSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUWorldSelection.IsSplitterFixed = True
        Me.SplitContainerUWorldSelection.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerUWorldSelection.Name = "SplitContainerUWorldSelection"
        Me.SplitContainerUWorldSelection.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerUWorldSelection.Panel1
        '
        Me.SplitContainerUWorldSelection.Panel1.Controls.Add(Me.LstBxUPrefixWorlds)
        '
        'SplitContainerUWorldSelection.Panel2
        '
        Me.SplitContainerUWorldSelection.Panel2.Controls.Add(Me.ComboUNewWorldName)
        Me.SplitContainerUWorldSelection.Panel2.Controls.Add(Me.BtnURmWorld)
        Me.SplitContainerUWorldSelection.Panel2.Controls.Add(Me.BtnUAddWorld)
        Me.SplitContainerUWorldSelection.Size = New System.Drawing.Size(176, 352)
        Me.SplitContainerUWorldSelection.SplitterDistance = 311
        Me.SplitContainerUWorldSelection.TabIndex = 0
        '
        'LstBxUPrefixWorlds
        '
        Me.LstBxUPrefixWorlds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBxUPrefixWorlds.FormattingEnabled = True
        Me.LstBxUPrefixWorlds.HorizontalScrollbar = True
        Me.LstBxUPrefixWorlds.Location = New System.Drawing.Point(0, 0)
        Me.LstBxUPrefixWorlds.Name = "LstBxUPrefixWorlds"
        Me.LstBxUPrefixWorlds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LstBxUPrefixWorlds.Size = New System.Drawing.Size(176, 311)
        Me.LstBxUPrefixWorlds.Sorted = True
        Me.LstBxUPrefixWorlds.TabIndex = 0
        '
        'ComboUNewWorldName
        '
        Me.ComboUNewWorldName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboUNewWorldName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboUNewWorldName.FormattingEnabled = True
        Me.ComboUNewWorldName.Location = New System.Drawing.Point(3, 8)
        Me.ComboUNewWorldName.Name = "ComboUNewWorldName"
        Me.ComboUNewWorldName.Size = New System.Drawing.Size(84, 21)
        Me.ComboUNewWorldName.Sorted = True
        Me.ComboUNewWorldName.TabIndex = 7
        Me.ComboUNewWorldName.Text = "New world"
        '
        'BtnURmWorld
        '
        Me.BtnURmWorld.Enabled = False
        Me.BtnURmWorld.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnURmWorld.Location = New System.Drawing.Point(136, 2)
        Me.BtnURmWorld.Name = "BtnURmWorld"
        Me.BtnURmWorld.Size = New System.Drawing.Size(37, 31)
        Me.BtnURmWorld.TabIndex = 6
        Me.BtnURmWorld.UseVisualStyleBackColor = True
        '
        'BtnUAddWorld
        '
        Me.BtnUAddWorld.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnUAddWorld.Location = New System.Drawing.Point(93, 2)
        Me.BtnUAddWorld.Name = "BtnUAddWorld"
        Me.BtnUAddWorld.Size = New System.Drawing.Size(37, 31)
        Me.BtnUAddWorld.TabIndex = 1
        Me.BtnUAddWorld.UseVisualStyleBackColor = True
        '
        'TabPageUsers_Permissions
        '
        Me.TabPageUsers_Permissions.Controls.Add(Me.SplitContainerUPermsTab1)
        Me.TabPageUsers_Permissions.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUsers_Permissions.Name = "TabPageUsers_Permissions"
        Me.TabPageUsers_Permissions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers_Permissions.Size = New System.Drawing.Size(635, 377)
        Me.TabPageUsers_Permissions.TabIndex = 2
        Me.TabPageUsers_Permissions.Text = "Permissions"
        Me.TabPageUsers_Permissions.UseVisualStyleBackColor = True
        '
        'SplitContainerUPermsTab1
        '
        Me.SplitContainerUPermsTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUPermsTab1.IsSplitterFixed = True
        Me.SplitContainerUPermsTab1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerUPermsTab1.Name = "SplitContainerUPermsTab1"
        Me.SplitContainerUPermsTab1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerUPermsTab1.Panel1
        '
        Me.SplitContainerUPermsTab1.Panel1.Controls.Add(Me.SplitContainerUPermsTab2)
        '
        'SplitContainerUPermsTab1.Panel2
        '
        Me.SplitContainerUPermsTab1.Panel2.Controls.Add(Me.BtnURmPerm)
        Me.SplitContainerUPermsTab1.Panel2.Controls.Add(Me.BtnUAddPerm)
        Me.SplitContainerUPermsTab1.Size = New System.Drawing.Size(629, 371)
        Me.SplitContainerUPermsTab1.SplitterDistance = 328
        Me.SplitContainerUPermsTab1.TabIndex = 13
        '
        'SplitContainerUPermsTab2
        '
        Me.SplitContainerUPermsTab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUPermsTab2.IsSplitterFixed = True
        Me.SplitContainerUPermsTab2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerUPermsTab2.Name = "SplitContainerUPermsTab2"
        Me.SplitContainerUPermsTab2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerUPermsTab2.Panel1
        '
        Me.SplitContainerUPermsTab2.Panel1.Controls.Add(Me.GpBxUSelectWorld)
        '
        'SplitContainerUPermsTab2.Panel2
        '
        Me.SplitContainerUPermsTab2.Panel2.Controls.Add(Me.LstVwUserPerms)
        Me.SplitContainerUPermsTab2.Size = New System.Drawing.Size(629, 328)
        Me.SplitContainerUPermsTab2.SplitterDistance = 57
        Me.SplitContainerUPermsTab2.TabIndex = 2
        '
        'GpBxUSelectWorld
        '
        Me.GpBxUSelectWorld.Controls.Add(Me.ComboUPermWorld)
        Me.GpBxUSelectWorld.Controls.Add(Me.LblUPermissions1)
        Me.GpBxUSelectWorld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBxUSelectWorld.Location = New System.Drawing.Point(0, 0)
        Me.GpBxUSelectWorld.Name = "GpBxUSelectWorld"
        Me.GpBxUSelectWorld.Size = New System.Drawing.Size(629, 57)
        Me.GpBxUSelectWorld.TabIndex = 1
        Me.GpBxUSelectWorld.TabStop = False
        Me.GpBxUSelectWorld.Text = "Please select a world from list"
        '
        'ComboUPermWorld
        '
        Me.ComboUPermWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboUPermWorld.FormattingEnabled = True
        Me.ComboUPermWorld.Items.AddRange(New Object() {"All worlds"})
        Me.ComboUPermWorld.Location = New System.Drawing.Point(6, 19)
        Me.ComboUPermWorld.Name = "ComboUPermWorld"
        Me.ComboUPermWorld.Size = New System.Drawing.Size(207, 21)
        Me.ComboUPermWorld.Sorted = True
        Me.ComboUPermWorld.TabIndex = 9
        '
        'LblUPermissions1
        '
        Me.LblUPermissions1.AutoSize = True
        Me.LblUPermissions1.Location = New System.Drawing.Point(219, 22)
        Me.LblUPermissions1.Name = "LblUPermissions1"
        Me.LblUPermissions1.Size = New System.Drawing.Size(286, 13)
        Me.LblUPermissions1.TabIndex = 11
        Me.LblUPermissions1.Text = "Note: To add a new world please use the worlds tab above"
        '
        'LstVwUserPerms
        '
        Me.LstVwUserPerms.CheckBoxes = True
        Me.LstVwUserPerms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.LstVwUserPerms.ContextMenuStrip = Me.CntxtMenuPerms
        Me.LstVwUserPerms.Cursor = System.Windows.Forms.Cursors.Default
        Me.LstVwUserPerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstVwUserPerms.FullRowSelect = True
        Me.LstVwUserPerms.GridLines = True
        Me.LstVwUserPerms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LstVwUserPerms.HideSelection = False
        Me.LstVwUserPerms.LabelEdit = True
        Me.LstVwUserPerms.Location = New System.Drawing.Point(0, 0)
        Me.LstVwUserPerms.Name = "LstVwUserPerms"
        Me.LstVwUserPerms.ShowItemToolTips = True
        Me.LstVwUserPerms.Size = New System.Drawing.Size(629, 267)
        Me.LstVwUserPerms.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVwUserPerms.TabIndex = 2
        Me.LstVwUserPerms.UseCompatibleStateImageBehavior = False
        Me.LstVwUserPerms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 626
        '
        'BtnURmPerm
        '
        Me.BtnURmPerm.Image = Global.WindowsApplication1.My.Resources.Resources.list_remove
        Me.BtnURmPerm.Location = New System.Drawing.Point(589, 3)
        Me.BtnURmPerm.Name = "BtnURmPerm"
        Me.BtnURmPerm.Size = New System.Drawing.Size(37, 31)
        Me.BtnURmPerm.TabIndex = 8
        Me.BtnURmPerm.UseVisualStyleBackColor = True
        '
        'BtnUAddPerm
        '
        Me.BtnUAddPerm.Image = Global.WindowsApplication1.My.Resources.Resources.list_add
        Me.BtnUAddPerm.Location = New System.Drawing.Point(546, 3)
        Me.BtnUAddPerm.Name = "BtnUAddPerm"
        Me.BtnUAddPerm.Size = New System.Drawing.Size(37, 31)
        Me.BtnUAddPerm.TabIndex = 7
        Me.BtnUAddPerm.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "permissions.yml"
        Me.SaveFileDialog1.Filter = """Yaml file""|*.yml"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.RecentFilesToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'RecentFilesToolStripMenuItem
        '
        Me.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem"
        Me.RecentFilesToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.RecentFilesToolStripMenuItem.Text = "Recent Files"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(183, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.application_exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Enabled = False
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Enabled = False
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Enabled = False
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Enabled = False
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Enabled = False
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClrHistoryToolStripMenuItem, Me.RefreshAllToolStripMenuItem, Me.WriteToolStripMenuItem, Me.OptionsToolStripMenuItem1})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'ClrHistoryToolStripMenuItem
        '
        Me.ClrHistoryToolStripMenuItem.Name = "ClrHistoryToolStripMenuItem"
        Me.ClrHistoryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClrHistoryToolStripMenuItem.Text = "&Clear recent files"
        '
        'RefreshAllToolStripMenuItem
        '
        Me.RefreshAllToolStripMenuItem.Name = "RefreshAllToolStripMenuItem"
        Me.RefreshAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshAllToolStripMenuItem.Text = "&Refresh all"
        Me.RefreshAllToolStripMenuItem.ToolTipText = "If the interface has any bugs, click here to refresh everything"
        '
        'WriteToolStripMenuItem
        '
        Me.WriteToolStripMenuItem.Name = "WriteToolStripMenuItem"
        Me.WriteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.WriteToolStripMenuItem.Text = "&Write all changes"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabLengthToolStripMenuItem, Me.MaxUndoNumberToolStripMenuItem})
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.OptionsToolStripMenuItem1.Text = "&Options"
        '
        'TabLengthToolStripMenuItem
        '
        Me.TabLengthToolStripMenuItem.Name = "TabLengthToolStripMenuItem"
        Me.TabLengthToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TabLengthToolStripMenuItem.Text = "Tab Length"
        '
        'MaxUndoNumberToolStripMenuItem
        '
        Me.MaxUndoNumberToolStripMenuItem.Name = "MaxUndoNumberToolStripMenuItem"
        Me.MaxUndoNumberToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.MaxUndoNumberToolStripMenuItem.Text = "Max undo number"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpSubToolStripMenuItem, Me.ReportBugToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(24, 20)
        Me.HelpToolStripMenuItem.Text = "&?"
        '
        'HelpSubToolStripMenuItem
        '
        Me.HelpSubToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.help_contents
        Me.HelpSubToolStripMenuItem.Name = "HelpSubToolStripMenuItem"
        Me.HelpSubToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HelpSubToolStripMenuItem.Text = "&Help"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ReportBugToolStripMenuItem.Text = "Report bug"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.help_about
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusProgressBar1, Me.StatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(933, 23)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusProgressBar1
        '
        Me.StatusProgressBar1.Name = "StatusProgressBar1"
        Me.StatusProgressBar1.Size = New System.Drawing.Size(100, 17)
        Me.StatusProgressBar1.Step = 1
        '
        'StatusLabel1
        '
        Me.StatusLabel1.AutoToolTip = True
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(112, 18)
        Me.StatusLabel1.Text = "Welcome to PexEdit"
        Me.StatusLabel1.ToolTipText = "Current status"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 438)
        Me.Panel1.TabIndex = 7
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(23, 23)
        '
        'BckGrndWrkWritetofile
        '
        Me.BckGrndWrkWritetofile.WorkerReportsProgress = True
        Me.BckGrndWrkWritetofile.WorkerSupportsCancellation = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(933, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(781, 515)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PexEdit"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageGroups.ResumeLayout(False)
        Me.SplitContainerGroupsTab.Panel1.ResumeLayout(False)
        Me.SplitContainerGroupsTab.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerGroupsTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGroupsTab.ResumeLayout(False)
        Me.TabControlGroups.ResumeLayout(False)
        Me.TabPageGroups_General.ResumeLayout(False)
        Me.SplitContainerGroupActions.Panel1.ResumeLayout(False)
        Me.SplitContainerGroupActions.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerGroupActions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGroupActions.ResumeLayout(False)
        Me.GpBxNewGroup.ResumeLayout(False)
        Me.GpBxRank.ResumeLayout(False)
        Me.SplitContainerRankMgmt.Panel1.ResumeLayout(False)
        Me.SplitContainerRankMgmt.Panel1.PerformLayout()
        Me.SplitContainerRankMgmt.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerRankMgmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerRankMgmt.ResumeLayout(False)
        Me.TabPageGroups_Info.ResumeLayout(False)
        Me.SplitContainerGroupSettings.Panel1.ResumeLayout(False)
        Me.SplitContainerGroupSettings.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGroupSettings.ResumeLayout(False)
        Me.GpBxGroupInherit.ResumeLayout(False)
        Me.SplitContainerGroupInherit.Panel1.ResumeLayout(False)
        Me.SplitContainerGroupInherit.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerGroupInherit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGroupInherit.ResumeLayout(False)
        Me.GpBxGroupOptions.ResumeLayout(False)
        Me.SplitContainerGroupOptions.Panel1.ResumeLayout(False)
        Me.SplitContainerGroupOptions.Panel2.ResumeLayout(False)
        Me.SplitContainerGroupOptions.Panel2.PerformLayout()
        CType(Me.SplitContainerGroupOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerGroupOptions.ResumeLayout(False)
        Me.CntxtMenuOptions.ResumeLayout(False)
        Me.GpBxGroupGeneral.ResumeLayout(False)
        Me.GpBxGroupGeneral.PerformLayout()
        Me.TabPageGroups_Prefixes.ResumeLayout(False)
        Me.SplitContainerWorldSettings.Panel1.ResumeLayout(False)
        Me.SplitContainerWorldSettings.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerWorldSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerWorldSettings.ResumeLayout(False)
        Me.GpBxWorld.ResumeLayout(False)
        Me.GpBxWorld.PerformLayout()
        Me.GpBxPrefix.ResumeLayout(False)
        Me.GpBxPrefix.PerformLayout()
        Me.GpBxSelectWorld.ResumeLayout(False)
        Me.SplitContainerWorldSelection.Panel1.ResumeLayout(False)
        Me.SplitContainerWorldSelection.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerWorldSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerWorldSelection.ResumeLayout(False)
        Me.TabPageGroups_Permissions.ResumeLayout(False)
        Me.SplitContainerPermsTab.Panel1.ResumeLayout(False)
        Me.SplitContainerPermsTab.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPermsTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPermsTab.ResumeLayout(False)
        Me.SplitContainerPermsTab2.Panel1.ResumeLayout(False)
        Me.SplitContainerPermsTab2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPermsTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPermsTab2.ResumeLayout(False)
        Me.GpbBxSlctWorldPerm.ResumeLayout(False)
        Me.GpbBxSlctWorldPerm.PerformLayout()
        Me.CntxtMenuPerms.ResumeLayout(False)
        Me.TabPageUsers.ResumeLayout(False)
        Me.SplitContainerUsersTab.Panel1.ResumeLayout(False)
        Me.SplitContainerUsersTab.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUsersTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUsersTab.ResumeLayout(False)
        Me.TabControlUsers.ResumeLayout(False)
        Me.TabPageUsers_Actions.ResumeLayout(False)
        Me.GrpBxUCurrent.ResumeLayout(False)
        Me.GrpBxUCurrent.PerformLayout()
        Me.GpBxNewUser.ResumeLayout(False)
        Me.TabPageUsers_Prefix.ResumeLayout(False)
        Me.SplitContainerUWorldSettings.Panel1.ResumeLayout(False)
        Me.SplitContainerUWorldSettings.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUWorldSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUWorldSettings.ResumeLayout(False)
        Me.GpBxUWorldSettings.ResumeLayout(False)
        Me.GpBxUWorldSettings.PerformLayout()
        Me.SplitContainerU.Panel1.ResumeLayout(False)
        Me.SplitContainerU.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerU.ResumeLayout(False)
        Me.GpbxUPrefix.ResumeLayout(False)
        Me.GpbxUPrefix.PerformLayout()
        Me.GpBxUGroups.ResumeLayout(False)
        Me.GpbxUWorldselect.ResumeLayout(False)
        Me.SplitContainerUWorldSelection.Panel1.ResumeLayout(False)
        Me.SplitContainerUWorldSelection.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUWorldSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUWorldSelection.ResumeLayout(False)
        Me.TabPageUsers_Permissions.ResumeLayout(False)
        Me.SplitContainerUPermsTab1.Panel1.ResumeLayout(False)
        Me.SplitContainerUPermsTab1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUPermsTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUPermsTab1.ResumeLayout(False)
        Me.SplitContainerUPermsTab2.Panel1.ResumeLayout(False)
        Me.SplitContainerUPermsTab2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUPermsTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUPermsTab2.ResumeLayout(False)
        Me.GpBxUSelectWorld.ResumeLayout(False)
        Me.GpBxUSelectWorld.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGroups As System.Windows.Forms.TabPage
    Friend WithEvents TabPageUsers As System.Windows.Forms.TabPage
    Friend WithEvents TreeViewG As System.Windows.Forms.TreeView
    Friend WithEvents TreeViewU As System.Windows.Forms.TreeView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClrHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerGroupsTab As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerUsersTab As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents RecentFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControlGroups As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGroups_Info As System.Windows.Forms.TabPage
    Friend WithEvents TabPageGroups_General As System.Windows.Forms.TabPage
    Friend WithEvents TabPageGroups_Prefixes As System.Windows.Forms.TabPage
    Friend WithEvents ComboNewGroupName As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGroupNew As System.Windows.Forms.Button
    Friend WithEvents LstBxPrefixWorlds As System.Windows.Forms.ListBox
    Friend WithEvents GpBxSelectWorld As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrefixUnset As System.Windows.Forms.Button
    Friend WithEvents BtnPrefixSet As System.Windows.Forms.Button
    Friend WithEvents TxtBxPrefix As System.Windows.Forms.TextBox
    Friend WithEvents LblFormattedPrefix As System.Windows.Forms.Label
    Friend WithEvents GpBxPrefix As System.Windows.Forms.GroupBox
    Friend WithEvents TabPageGroups_Permissions As System.Windows.Forms.TabPage
    Friend WithEvents GpBxWorld As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerWorldSelection As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnAddWorld As System.Windows.Forms.Button
    Friend WithEvents BtnWorldDelete As System.Windows.Forms.Button
    Friend WithEvents TxtBxWorldname As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainerWorldSettings As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnWorldnameSet As System.Windows.Forms.Button
    Friend WithEvents ComboNewWorldName As System.Windows.Forms.ComboBox
    Friend WithEvents GpBxGroupInherit As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerGroupInherit As System.Windows.Forms.SplitContainer
    Friend WithEvents LstBxGroupInherit As System.Windows.Forms.ListBox
    Friend WithEvents ComboInheritsName As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddInherit As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveInherit As System.Windows.Forms.Button
    Friend WithEvents GpBxGroupOptions As System.Windows.Forms.GroupBox
    Friend WithEvents GpBxGroupGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents LblGroupname As System.Windows.Forms.Label
    Friend WithEvents ChckBxDefault As System.Windows.Forms.CheckBox
    Friend WithEvents BtnGroupDelete As System.Windows.Forms.Button
    Friend WithEvents TxtBxGroupname As System.Windows.Forms.TextBox
    Friend WithEvents BtnGroupNameSet As System.Windows.Forms.Button
    Friend WithEvents SplitContainerGroupSettings As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnRmPerm As System.Windows.Forms.Button
    Friend WithEvents BtnAddPerm As System.Windows.Forms.Button
    Friend WithEvents SplitContainerPermsTab As System.Windows.Forms.SplitContainer
    Friend WithEvents GpbBxSlctWorldPerm As System.Windows.Forms.GroupBox
    Friend WithEvents ComboPermWorld As System.Windows.Forms.ComboBox
    Friend WithEvents LblPermissions1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainerPermsTab2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerGroupActions As System.Windows.Forms.SplitContainer
    Friend WithEvents GpBxNewGroup As System.Windows.Forms.GroupBox
    Friend WithEvents GpBxRank As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerRankMgmt As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboRnkLaddr As System.Windows.Forms.ComboBox
    Friend WithEvents BtnLaddrAdd As System.Windows.Forms.Button
    Friend WithEvents TxtBxNewLaddr As System.Windows.Forms.TextBox
    Friend WithEvents BtnRmRnk As System.Windows.Forms.Button
    Friend WithEvents BtnAddRank As System.Windows.Forms.Button
    Friend WithEvents LstBxRankedGrps As System.Windows.Forms.ListBox
    Friend WithEvents LstBoxAllGroups As System.Windows.Forms.ListBox
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpSubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerGroupOptions As System.Windows.Forms.SplitContainer
    Friend WithEvents BckGrndWrkWritetofile As System.ComponentModel.BackgroundWorker
    Friend WithEvents LstVwGrpOptions As System.Windows.Forms.ListView
    Friend WithEvents OptionColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValueColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnAddOption As System.Windows.Forms.Button
    Friend WithEvents BtnRmOption As System.Windows.Forms.Button
    Friend WithEvents CntxtMenuOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CntxtMenuOptionsEditItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtMenuOptionsRemoveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabLengthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents BtnGroupDuplicate As System.Windows.Forms.Button
    Friend WithEvents ToolTipGroup As System.Windows.Forms.ToolTip
    Friend WithEvents CntxtMenuOptionsDuplicateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblOptions As System.Windows.Forms.Label
    Friend WithEvents TabControlUsers As System.Windows.Forms.TabControl
    Friend WithEvents TabPageUsers_Actions As System.Windows.Forms.TabPage
    Friend WithEvents GpBxNewUser As System.Windows.Forms.GroupBox
    Friend WithEvents ComboNewUser As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddUser As System.Windows.Forms.Button
    Friend WithEvents TabPageUsers_Prefix As System.Windows.Forms.TabPage
    Friend WithEvents GpBxUWorldSettings As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUWorldnameSet As System.Windows.Forms.Button
    Friend WithEvents TxtBxUWorldname As System.Windows.Forms.TextBox
    Friend WithEvents GpbxUPrefix As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBxUPrefix As System.Windows.Forms.TextBox
    Friend WithEvents BtnUPrefixClear As System.Windows.Forms.Button
    Friend WithEvents LlbUFormattedprefix As System.Windows.Forms.Label
    Friend WithEvents BtnUPrefixSet As System.Windows.Forms.Button
    Friend WithEvents TabPageUsers_Permissions As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainerUPermsTab1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerUPermsTab2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GpBxUSelectWorld As System.Windows.Forms.GroupBox
    Friend WithEvents ComboUPermWorld As System.Windows.Forms.ComboBox
    Friend WithEvents LblUPermissions1 As System.Windows.Forms.Label
    Friend WithEvents BtnURmPerm As System.Windows.Forms.Button
    Friend WithEvents BtnUAddPerm As System.Windows.Forms.Button
    Friend WithEvents SplitContainerUWorldSettings As System.Windows.Forms.SplitContainer
    Friend WithEvents GpbxUWorldselect As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerUWorldSelection As System.Windows.Forms.SplitContainer
    Friend WithEvents LstBxUPrefixWorlds As System.Windows.Forms.ListBox
    Friend WithEvents ComboUNewWorldName As System.Windows.Forms.ComboBox
    Friend WithEvents BtnURmWorld As System.Windows.Forms.Button
    Friend WithEvents BtnUAddWorld As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrpBxUCurrent As System.Windows.Forms.GroupBox
    Private WithEvents BtnUDuplicate As System.Windows.Forms.Button
    Friend WithEvents LblUName As System.Windows.Forms.Label
    Friend WithEvents BtnURm As System.Windows.Forms.Button
    Friend WithEvents TxtBxUName As System.Windows.Forms.TextBox
    Friend WithEvents BtnUNameSet As System.Windows.Forms.Button
    Friend WithEvents SplitContainerU As System.Windows.Forms.SplitContainer
    Friend WithEvents GpBxUGroups As System.Windows.Forms.GroupBox
    Friend WithEvents LstBxUGroups As System.Windows.Forms.CheckedListBox
    Friend WithEvents MaxUndoNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtMenuPerms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CntxtMenuPermsEditItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtMenuPermsDuplicateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtMenuPermsRemoveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstVwGroupPerms As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LstVwUserPerms As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader

End Class
