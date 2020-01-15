<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripTextBox1 = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.goButton = New System.Windows.Forms.Button()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Location = New System.Drawing.Point(276, 34)
		Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(4)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(27, 25)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(761, 507)
		Me.WebBrowser1.TabIndex = 0
		'
		'ToolStrip1
		'
		Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(1067, 25)
		Me.ToolStrip1.TabIndex = 1
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripTextBox1
		'
		Me.ToolStripTextBox1.Location = New System.Drawing.Point(136, 33)
		Me.ToolStripTextBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
		Me.ToolStripTextBox1.Size = New System.Drawing.Size(132, 22)
		Me.ToolStripTextBox1.TabIndex = 2
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(155, 168)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(100, 28)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(136, 83)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(132, 22)
		Me.TextBox1.TabIndex = 4
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(136, 121)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(132, 22)
		Me.TextBox2.TabIndex = 5
		Me.TextBox2.Visible = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 83)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Username"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(16, 121)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 17)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Password"
		Me.Label2.Visible = False
		'
		'goButton
		'
		Me.goButton.Location = New System.Drawing.Point(3, 168)
		Me.goButton.Margin = New System.Windows.Forms.Padding(4)
		Me.goButton.Name = "goButton"
		Me.goButton.Size = New System.Drawing.Size(100, 28)
		Me.goButton.TabIndex = 8
		Me.goButton.Text = "Go"
		Me.goButton.UseVisualStyleBackColor = True
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.ItemHeight = 16
		Me.ListBox1.Location = New System.Drawing.Point(33, 257)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(120, 84)
		Me.ListBox1.TabIndex = 9
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1067, 554)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.goButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.ToolStripTextBox1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents WebBrowser1 As WebBrowser
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripTextBox1 As TextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents goButton As Button
	Friend WithEvents ListBox1 As ListBox
End Class
