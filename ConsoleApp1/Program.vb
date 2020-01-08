Imports System
Imports System.Security

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        StartIExplorer()
        'NavigateWebURL("http://159.253.72.79/login/login.html", "default")
    End Sub
    Public Sub StartIExplorer()
        Dim info = New ProcessStartInfo("iexplore")

        info.UseShellExecute = False
        info.RedirectStandardInput = True
        info.RedirectStandardOutput = True
        info.RedirectStandardError = True
        Dim password As String = "Blastb3ats"
        Dim URL As String = "http://159.253.72.79/login/login.html"
        Dim securePassword As SecureString = New SecureString()

        For i As Integer = 0 To password.Length - 1
            securePassword.AppendChar(Convert.ToChar(password(i)))
        Next

        info.FileName = "C:\Program Files\Internet Explorer\iexplore.exe"
        info.Arguments = "http://159.253.72.79/login/login.html"
        info.UserName = "admin"
        info.Password = securePassword
        info.Domain = "http://159.253.72.79/login/login.html"

        Try
            Process.Start(info)
            'Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", URL)
        Catch ex As System.ComponentModel.Win32Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub NavigateWebURL(ByVal URL As String, Optional browser As String = "default")

        If Not (browser = "default") Then
            Try
                '// try set browser if there was an error (browser not installed)
                Process.Start(browser, URL)
            Catch ex As Exception
                '// use default browser
                Process.Start(URL)
            End Try

        Else
            '// use default browser
            Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", URL)

        End If
    End Sub
End Module
