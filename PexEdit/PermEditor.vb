Public Class PermEditor
    Sub New(ByVal suggestions As List(Of String))
        InitializeComponent()
        Me.Text = "New permission"
        For Each scanstring In suggestions
            Me.ComboPerm.Items.Add(scanstring)
        Next
    End Sub

    Sub New(ByVal suggestions As List(Of String), ByVal permission As String)
        InitializeComponent()
        Me.Text = "Edit permission"
        For Each scanstring In suggestions
            Me.ComboPerm.Items.Add(scanstring)
        Next
        Me.ComboPerm.Text = permission
    End Sub
    Private Sub BtnAccept_Click(sender As System.Object, e As System.EventArgs) Handles BtnAccept.Click
        If ComboPerm.Text = "" Then
            MsgBox("Please enter a permission", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If ComboPerm.Text.Contains(CChar(" ")) OrElse ComboPerm.Text.Contains(CChar(":")) OrElse ComboPerm.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(ComboPerm.Text.Contains(" "), "spaces", "")) & CStr(IIf(ComboPerm.Text.Contains(" ") And ComboPerm.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboPerm.Text.Contains(":"), "colons", "")) & CStr(IIf(ComboPerm.Text.Contains(":") And ComboPerm.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(ComboPerm.Text.Contains(" ") And ComboPerm.Text.Contains(CChar("'")) And Not ComboPerm.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboPerm.Text.Contains("'"), "apostrophes", "")) & " in permissions", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.ComboPerm.Text = Nothing
        Me.Close()
    End Sub

    Public Function gettext() As String
        Return Me.ComboPerm.Text
    End Function

    Public Function getstate() As Boolean
        Return Me.ChkBxAllowed.Checked
    End Function
End Class