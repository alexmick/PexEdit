<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionEditor
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
        Me.LblText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBxValue = New System.Windows.Forms.TextBox()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ComboText = New System.Windows.Forms.ComboBox()
        Me.ErrLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.Location = New System.Drawing.Point(10, 11)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(59, 13)
        Me.LblText.TabIndex = 0
        Me.LblText.Text = "OptionText"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Value"
        '
        'TxtBxValue
        '
        Me.TxtBxValue.Location = New System.Drawing.Point(75, 33)
        Me.TxtBxValue.Name = "TxtBxValue"
        Me.TxtBxValue.Size = New System.Drawing.Size(301, 20)
        Me.TxtBxValue.TabIndex = 2
        '
        'BtnAccept
        '
        Me.BtnAccept.Location = New System.Drawing.Point(310, 59)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(76, 29)
        Me.BtnAccept.TabIndex = 4
        Me.BtnAccept.Text = "Accept"
        Me.BtnAccept.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(226, 59)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(78, 28)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ComboText
        '
        Me.ComboText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboText.FormattingEnabled = True
        Me.ComboText.Location = New System.Drawing.Point(75, 11)
        Me.ComboText.Name = "ComboText"
        Me.ComboText.Size = New System.Drawing.Size(301, 21)
        Me.ComboText.Sorted = True
        Me.ComboText.TabIndex = 1
        '
        'ErrLbl
        '
        Me.ErrLbl.AutoSize = True
        Me.ErrLbl.ForeColor = System.Drawing.Color.Crimson
        Me.ErrLbl.Location = New System.Drawing.Point(12, 67)
        Me.ErrLbl.Name = "ErrLbl"
        Me.ErrLbl.Size = New System.Drawing.Size(29, 13)
        Me.ErrLbl.TabIndex = 0
        Me.ErrLbl.Text = "Error"
        Me.ErrLbl.Visible = False
        '
        'OptionEditor
        '
        Me.AcceptButton = Me.BtnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(388, 92)
        Me.Controls.Add(Me.ErrLbl)
        Me.Controls.Add(Me.ComboText)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.TxtBxValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblText)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblText As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtBxValue As System.Windows.Forms.TextBox
    Friend WithEvents BtnAccept As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ComboText As System.Windows.Forms.ComboBox
    Friend WithEvents ErrLbl As System.Windows.Forms.Label
End Class
