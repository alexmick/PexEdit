Public Class Permission
    Implements IComparable
    Dim _text As String
    Dim _state As Boolean

    Sub New()

    End Sub

    Sub New(ByVal permission As String)
        _text = permission
        _state = True
    End Sub

    Sub New(ByVal perm As String, allowed As Boolean)
        _text = perm
        _state = allowed
    End Sub

    Property text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Property state As Boolean
        Get
            Return _state
        End Get
        Set(value As Boolean)
            _state = value
        End Set
    End Property

    Public Function compareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim otherperm As Permission = CType(obj, Permission)
        Return String.Compare(Me.text, otherperm.text)
    End Function

    Public Overrides Function ToString() As String
        Return _text
    End Function
End Class

