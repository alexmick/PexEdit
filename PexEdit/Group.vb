Public Class Group
    Implements IComparable
    Private _name As String
    Private _isdefault As Boolean
    Private _inheritsfrom As New List(Of String)
    Private _options As New List(Of GroupOption) From {New GroupOption("rank", "0")}
    Private _worlds As New List(Of World) From {New World("All worlds")}

    Sub New()

    End Sub

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

    Property isdefault As Boolean
        Get
            Return _isdefault
        End Get
        Set(value As Boolean)
            _isdefault = value
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

    'Public Property rank As Integer
    '    Get
    '        Try
    '            Return CInt(_options(0).value)
    '        Catch ex As Exception
    '            Return 0
    '        End Try
    '    End Get
    '    Set(value As Integer)
    '        _options(0).value = CStr(value)
    '    End Set
    'End Property

    Public Function getworlds() As List(Of World)
        Return _worlds
    End Function

    Public Function getoptions() As List(Of GroupOption)
        Return _options
    End Function

    Public ReadOnly Property inheritsfrom As List(Of String)
        Get
            Return _inheritsfrom
        End Get
    End Property

    Public Sub addworld(worldtoadd As String)
        _worlds.Add(New World(worldtoadd))
    End Sub

    Public Sub addoption(optiontoadd As String, value As String)
        _options.Add(New GroupOption(optiontoadd, value))
    End Sub

    Public Sub addinherit(group As String)
        If _inheritsfrom.IndexOf(group) < 0 Then
            _inheritsfrom.Add(group)
            'import other inheritances in order
            Dim index As Integer = _inheritsfrom.IndexOf(group)
            For Each scangroup As Group In Main.groupslist
                If scangroup.name = group Then
                    For Each foundgroup As String In scangroup.inheritsfrom
                        _inheritsfrom.Insert(index, foundgroup)
                        index = _inheritsfrom.IndexOf(group)
                    Next
                End If
            Next
        End If
    End Sub

    'rank comparison to implement in the future
    'Public Function compareTo(obj As Object) As Integer Implements IComparable.CompareTo
    'Dim othergroup As Group = CType(obj, Group)
    '   If Me.rank < othergroup.rank Then
    '        Return 1
    '    ElseIf Me.rank = othergroup.rank Then
    '        Return 0
    '   Else
    '      Return -1
    ' End If
    'End Function
    Public Function compareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim othergroup As Group = CType(obj, Group)
        Return String.Compare(Me.name, othergroup.name)
    End Function

End Class
