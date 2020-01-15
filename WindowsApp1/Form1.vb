Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "admin"
        TextBox2.Text = My.Settings.SitePassword
        ToolStripTextBox1.Text = "http://159.253.72.79/login/login.html"
        Dim wb As WebBrowser = New WebBrowser()
        wb.AllowNavigation = True
        'wb.Navigate("http://www.google.com")
    End Sub

    Private Sub DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Dim wb As WebBrowser = TryCast(sender, WebBrowser)
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        Dim wb As WebBrowser = TryCast(sender, WebBrowser)
    End Sub
    Private Sub goButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles goButton.Click
        ' Part 1: Use WebBrowser control to load web page
        WebBrowser1.Navigate("http://159.253.72.79/login/login.html")
        System.Threading.Thread.Sleep(2000) ' Delay 2 seconds to render login page
        Navigate(ToolStripTextBox1.Text)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Part 2: Automatically input username and password
        Dim theElementCollection As HtmlElementCollection
        theElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
        For Each curElement As HtmlElement In theElementCollection
            Dim controlName As String = curElement.GetAttribute("name").ToString
            If controlName = "UserNameTextBox" Then
                curElement.SetAttribute("Value", "admin")
            ElseIf controlName = "PasswordTextBox" Then
                curElement.SetAttribute("Value", My.Settings.SitePassword)
                'In addition,you can get element value like this:
                'MessageBox.Show(curElement.GetAttribute("Value"))
            End If
        Next

        ' Part 3: Automatically clck that Login button
        theElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
        For Each curElement As HtmlElement In theElementCollection
            If curElement.GetAttribute("value").Equals("Login") Then
                curElement.InvokeMember("click")
                ' javascript has a click method for you need to invoke on button and hyperlink elements.
            End If
        Next

        WebBrowser1.Document.GetElementById("AuthName").SetAttribute("value", TextBox1.Text)
        WebBrowser1.Document.GetElementById("Display").SetAttribute("value", TextBox2.Text)
        WebBrowser1.Document.GetElementById("submit").InvokeMember("click")
        'WebBrowser1.Document.GetElementById("network").InvokeMember("click")
        System.Threading.Thread.Sleep(10000)

        MsgBox(WebBrowser1.DocumentTitle.ToString)
        MsgBox(WebBrowser1.Url.ToString)
        LoadPages()
        If WebBrowser1.Url.ToString.Contains("index") Then
            LoadPages()
            AddHandler WebBrowser1.DocumentCompleted, AddressOf DocumentCompleted
        End If

    End Sub
    Private Sub LoadPages()
        'WebBrowser1.Navigate("http://159.253.72.79/login/login.html")
        WebBrowser1.Document.GetElementById("network-homeNetworking").InvokeMember("click")
        WebBrowser1.Document.GetElementById("network-homeNetworking").InvokeMember("click")

        System.Threading.Thread.Sleep(10000)
        MsgBox("1")
        WebBrowser1.Document.GetElementById("t6").InvokeMember("click")
        MsgBox("2")
        WebBrowser1.Document.GetElementById("wakeOnLanIPAddr").SetAttribute("value", "192.168.1.52")
        WebBrowser1.Document.GetElementById("str1").SetAttribute("value", "00")
        WebBrowser1.Document.GetElementById("str2").SetAttribute("value", "e0")
        WebBrowser1.Document.GetElementById("str3").SetAttribute("value", "4c")
        WebBrowser1.Document.GetElementById("str4").SetAttribute("value", "29")
        WebBrowser1.Document.GetElementById("str5").SetAttribute("value", "13")
        WebBrowser1.Document.GetElementById("str6").SetAttribute("value", "8c")
        WebBrowser1.Document.GetElementById("wakeUpBtn").InvokeMember("click")
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim allelements As HtmlElementCollection = WebBrowser1.Document.All

        For Each webpageelement As HtmlElement In allelements
            ListBox1.Items.Add(webpageelement.GetAttribute("src"))
        Next
    End Sub
    Private Sub webBrowser1_Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
        ToolStripTextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged

    End Sub
    Private Sub toolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Navigate(ToolStripTextBox1.Text)
        End If
    End Sub
    Private Sub Navigate(ByVal address As String)
        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") AndAlso Not address.StartsWith("https://") Then
            address = "http://" & address
        End If

        Try
            WebBrowser1.Navigate(New Uri(address))
        Catch __unusedUriFormatException1__ As System.UriFormatException
            MsgBox(__unusedUriFormatException1__.ToString)
            Return
        End Try
    End Sub
End Class
