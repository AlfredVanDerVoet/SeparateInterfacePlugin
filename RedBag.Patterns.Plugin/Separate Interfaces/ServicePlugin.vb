Public Interface ServicePlugin
    Function GetNames(Category As String) As String()
    Function GetLocation(Name As String) As String
End Interface
