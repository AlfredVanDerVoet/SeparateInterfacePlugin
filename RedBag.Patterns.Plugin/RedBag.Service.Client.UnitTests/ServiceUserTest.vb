Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports RedBag.Service.Client

<TestClass()>
Public Class ServiceUserTest


    <TestMethod()>
    Public Sub SetNoUSersTestWithoutREgisteredFactory()
        Dim target As ServiceUser = New ServiceUser()
        Dim ExceptionThrown As Boolean = False
        Try
            target.SetNoUSers()

        Catch ex As Exception
            ExceptionThrown = True
        End Try

        Assert.IsTrue(ExceptionThrown)

    End Sub
End Class
