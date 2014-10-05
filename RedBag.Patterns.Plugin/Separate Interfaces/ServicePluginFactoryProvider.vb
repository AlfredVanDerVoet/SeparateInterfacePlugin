Public Class ServicePluginFactoryProvider

    Private Shared _Instance As New ServicePluginFactoryProvider
    Private _Factory As ServicePluginFactory = New ServicePluginFactoryNotRegistered

    Private Sub New()
        ' Private -> Singleton
    End Sub

    Public Shared ReadOnly Property Factory() As ServicePluginFactory
        Get
            Return _Instance._Factory
        End Get
    End Property



    Public Shared Sub Register(Factory As ServicePluginFactory)
        _Instance._Factory = Factory
    End Sub
End Class
