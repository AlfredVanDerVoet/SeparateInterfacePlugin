Public Class ServiceUser

    Private NoLocals As Long
    Private NoRemotes As Long

    Public Sub SetNoUSers()
        Dim Service As New RedBag.Service.PlugInUser

        NoLocals = Service.NoOfLocalUser()
        NoRemotes = Service.NoOfRemoteUser()



    End Sub

End Class
