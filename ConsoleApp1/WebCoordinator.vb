Imports System.Net

Public Class WebCoordinator
    Public Shared Sub CreateConnection()
        Dim strData As String = ""
        Dim APIKEY As String = ""
        Dim ListKey As String = ""
        Dim VisitorEmail As String = ""

        Dim oWebRequest As HttpWebRequest = CType(WebRequest.Create(New Uri(String.Format("https://campaigns.zoho.com/api/addlistsubscribersinbulk?scope=CampaignsAPI&resfmt=XML&authtoken={0}&listkey={1}&emailids={2}", APIKEY, ListKey, VisitorEmail))), HttpWebRequest)
        oWebRequest.Credentials = New NetworkCredential()

        With oWebRequest
            .Method = "POST"
            .ContentType = "application/x-www-form-urlencoded"
        End With

        Dim Response As HttpWebResponse = CType(oWebRequest.GetResponse(), HttpWebResponse)

        If Response.ContentLength > 0 Then
            Dim bytRes(CInt(Response.ContentLength) - 1) As Byte

            Using stm = Response.GetResponseStream()
                stm.Read(bytRes, 0, CInt(Response.ContentLength))
                stm.Flush()
                stm.Close()
            End Using

            Dim strResult As String = System.Text.Encoding.UTF8.GetString(bytRes)

            strData = strResult

        End If
    End Sub
End Class
