Public Class PlugInUser
    Private LocalUsers As String()
    Private RemoteUsers As String()

    Sub New()

        LocalUsers = GetUsersByLocation("Local")
        RemoteUsers = GetUsersByLocation("Remote")
    End Sub

    Private Function GetUsersByLocation(Location As String) As String()
        Dim PlugIn As ServicePlugin = ServicePluginFactoryProvider.Factory.Create()

        Return PlugIn.GetNames(Location)
    End Function

    Public Function NoOfLocalUser() As Integer
        Return LocalUsers.Count
    End Function

    Public Function NoOfRemoteUser() As Integer
        Return RemoteUsers.Count
    End Function

End Class
