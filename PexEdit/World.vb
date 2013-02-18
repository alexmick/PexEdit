Public Class World
    Implements IComparable
    Private _name As String
    Private _prefix As String = "None set"
    Private _permissions As New List(Of Permission)
    Private _groups As New List(Of String)

    Sub New(ByVal givenname As String)
        _name = givenname
    End Sub

    Property prefix As String
        Get
            Return _prefix
        End Get
        Set(value As String)
            _prefix = value
        End Set
    End Property

    Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public ReadOnly Property permissions() As List(Of Permission)
        Get
            Return _permissions
        End Get
    End Property

    Public Sub addperm(ByVal perm As String, ByVal allowed As Boolean)
        _permissions.Add(New Permission(perm, allowed))
    End Sub

    Public Sub setstate(ByVal permission As String, ByVal state As Boolean)
        For Each scanperm As Permission In _permissions
            If scanperm.text = permission Then
                scanperm.state = state
            End If
        Next
    End Sub

    Public Sub addgroup(ByVal name As String)
        If _groups.IndexOf(name) < 0 Then
            _groups.Add(name)
        End If
    End Sub

    Public Function getgroups() As List(Of String)
        Return _groups
    End Function

    Function compareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim otherworld As World = CType(obj, World)
        Return String.Compare(Me.name, otherworld.name)
    End Function

    Public Overrides Function ToString() As String
        Return _name
    End Function

End Class
