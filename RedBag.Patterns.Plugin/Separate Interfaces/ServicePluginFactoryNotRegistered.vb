Public Class ServicePluginFactoryNotRegistered
    Implements ServicePluginFactory

    Public Function Create() As ServicePlugin Implements ServicePluginFactory.Create
        Dim TypeName As String = GetType(ServicePluginFactory).Name
        Throw New Exception(ExceptionMessage)
    End Function

    Private Function ExceptionMessage() As String
        Dim TypeName As String = GetType(ServicePlugin).Name
        Return String.Format("Can't create '{0}' object. No '{0}Factory' implmentation is registered.", TypeName)
    End Function
End Class
