Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "admin"
        TextBox2.Text = "Blastb3ats"
        Dim wb As WebBrowser = New WebBrowser()
        wb.AllowNavigation = True
        'wb.DocumentCompleted += New WebBrowserDocumentCompletedEventHandler(AddressOf wb_DocumentCompleted)
        wb.Navigate("http://www.google.com")
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
        MsgBox(WebBrowser1.ReadyState.ToString)
        theElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
        For Each curElement As HtmlElement In theElementCollection
            Dim controlName As String = curElement.GetAttribute("name").ToString
            If controlName = "UserNameTextBox" Then
                curElement.SetAttribute("Value", "admin")
            ElseIf controlName = "PasswordTextBox" Then
                curElement.SetAttribute("Value", "Blastb3ats")
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
        WebBrowser1.Document.GetElementById("AuthPassword").SetAttribute("value", TextBox2.Text)
        WebBrowser1.Document.GetElementById(".save").InvokeMember("click")
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
