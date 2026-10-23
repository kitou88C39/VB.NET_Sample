Class ServiceClass

    Private strPvtVar As String

    Public Property PropertyName() As String
    Get
        Return strPvtVar
    End Get
    Set(Value As String)
        strPvtVar = Value
      End Set
    End Property

End Class
