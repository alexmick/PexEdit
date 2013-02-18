Public Class GroupOption
    Implements IComparable
    Private _text As String
    Private _value As String

    Sub New(ByVal text As String, ByVal value As String)
        _text = text
        _value = value
    End Sub

    Function compareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim otheroption As GroupOption = CType(obj, GroupOption)
        Return String.Compare(Me.text, otheroption.text)
    End Function
    Public Property text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Public Property value As String
        Get
            Return _value
        End Get
        Set(input As String)
            _value = input
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _text
    End Function
End Class
