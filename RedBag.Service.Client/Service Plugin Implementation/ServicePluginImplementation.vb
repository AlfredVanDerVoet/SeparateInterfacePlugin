Public Class ServicePluginImplementation
    Implements RedBag.Service.ServicePlugin


    Private Locals As String() = {"John", "Askan", "May", "Wilson"}
    Private Remotes As String() = {"Indy", "Jeffery", "Marc"}

    Public Function GetLocation(Name As String) As String Implements ServicePlugin.GetLocation
        If Locals.Contains(Name) Then
            Return "Local"
        Else
            Return "Remote"
        End If
    End Function

    Public Function GetNames(Category As String) As String() Implements ServicePlugin.GetNames
        If String.Compare(Category, "Local", True) = 0 Then
            Return Locals
        Else
            Return Remotes
        End If
    End Function


End Class
