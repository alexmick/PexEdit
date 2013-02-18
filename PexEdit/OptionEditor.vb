Public Class OptionEditor
    Private _text As String
    Private _value As String

    Sub New(ByVal suggestions As List(Of String))
        InitializeComponent()
        Me.Text = "New option"
        For Each scanstring In suggestions
            Me.ComboText.Items.Add(scanstring)
        Next
    End Sub

    Sub New(ByVal suggestions As List(Of String), OptionName As String, Optional ByVal OptionValue As String = "0")
        InitializeComponent()
        _text = OptionName
        _value = OptionValue
        Me.ComboText.Text = _text
        Me.TxtBxValue.Text = _value
        For Each scanstring In suggestions
            Me.ComboText.Items.Add(scanstring)
        Next
    End Sub

    Private Sub BtnAccept_Click(sender As System.Object, e As System.EventArgs) Handles BtnAccept.Click
        If ComboText.Text = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If ComboText.Text.Contains(CChar(" ")) OrElse ComboText.Text.Contains(CChar(":")) OrElse ComboText.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(ComboText.Text.Contains(" "), "spaces", "")) & CStr(IIf(ComboText.Text.Contains(" ") And ComboText.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboText.Text.Contains(":"), "colons", "")) & CStr(IIf(ComboText.Text.Contains(":") And ComboText.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(ComboText.Text.Contains(" ") And ComboText.Text.Contains(CChar("'")) And Not ComboText.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(ComboText.Text.Contains("'"), "apostrophes", "")) & " in option name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If TxtBxValue.Text = "" Then
            MsgBox("Please enter a value", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If TxtBxValue.Text.Contains(CChar(" ")) OrElse TxtBxValue.Text.Contains(CChar(":")) OrElse TxtBxValue.Text.Contains(CChar("'")) Then
            MsgBox("Please do not use " & CStr(IIf(TxtBxValue.Text.Contains(" "), "spaces", "")) & CStr(IIf(TxtBxValue.Text.Contains(" ") And TxtBxValue.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxValue.Text.Contains(":"), "colons", "")) & CStr(IIf(TxtBxValue.Text.Contains(":") And TxtBxValue.Text.Contains(CChar("'")), " nor ", "")) & CStr(IIf(TxtBxValue.Text.Contains(" ") And TxtBxValue.Text.Contains(CChar("'")) And Not TxtBxValue.Text.Contains(CChar(":")), " nor ", "")) & CStr(IIf(TxtBxValue.Text.Contains("'"), "apostrophes", "")) & " in option value", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        _text = ComboText.Text
        _value = TxtBxValue.Text
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Function gettext() As String
        Return _text
    End Function
    Public Function getvalue() As String
        Return _value
    End Function
End Class