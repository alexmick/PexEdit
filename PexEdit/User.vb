Public Class User
    Implements IComparable
    Private _name As String
    Private _worlds As New List(Of World) From {New World("All worlds")}

    Sub New(ByVal givenname As String)
        _name = givenname
    End Sub

    Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _name
    End Function

    Public ReadOnly Property world(ByVal worldname As String) As World
        Get
            Dim str As String = worldname
            If worldname = "all" Then
                str = "All worlds"
            End If
            For Each scanworld As World In _worlds
                If scanworld.name = str Then
                    Return scanworld
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public Function getworlds() As List(Of World)
        Return _worlds
    End Function

    Public Sub addworld(worldtoadd As String)
        _worlds.Add(New World(worldtoadd))
    End Sub

    Public Function compareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim otheruser As User = CType(obj, User)
        Return String.Compare(Me.name, otheruser.name)
    End Function

End Class
