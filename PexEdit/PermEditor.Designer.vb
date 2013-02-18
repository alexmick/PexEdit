<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermEditor
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
        Me.ComboPerm = New System.Windows.Forms.ComboBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkBxAllowed = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ComboPerm
        '
        Me.ComboPerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboPerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboPerm.FormattingEnabled = True
        Me.ComboPerm.Location = New System.Drawing.Point(81, 12)
        Me.ComboPerm.Name = "ComboPerm"
        Me.ComboPerm.Size = New System.Drawing.Size(435, 21)
        Me.ComboPerm.Sorted = True
        Me.ComboPerm.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(356, 45)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(78, 28)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAccept
        '
        Me.BtnAccept.Location = New System.Drawing.Point(440, 45)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(76, 29)
        Me.BtnAccept.TabIndex = 3
        Me.BtnAccept.Text = "Accept"
        Me.BtnAccept.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Permission :"
        '
        'ChkBxAllowed
        '
        Me.ChkBxAllowed.AutoSize = True
        Me.ChkBxAllowed.Checked = True
        Me.ChkBxAllowed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBxAllowed.Location = New System.Drawing.Point(12, 31)
        Me.ChkBxAllowed.Name = "ChkBxAllowed"
        Me.ChkBxAllowed.Size = New System.Drawing.Size(63, 17)
        Me.ChkBxAllowed.TabIndex = 4
        Me.ChkBxAllowed.Text = "Allowed"
        Me.ChkBxAllowed.UseVisualStyleBackColor = True
        '
        'PermEditor
        '
        Me.AcceptButton = Me.BtnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(528, 86)
        Me.Controls.Add(Me.ChkBxAllowed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.ComboPerm)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PermEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Permission"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboPerm As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAccept As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkBxAllowed As System.Windows.Forms.CheckBox
End Class
