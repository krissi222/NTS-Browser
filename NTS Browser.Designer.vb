<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(19, 54)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1491, 792)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://google.pl", System.UriKind.Absolute)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "←"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 18)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "→"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(401, 18)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "🏠"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(743, 18)
        Me.Button4.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "⟲"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1419, 18)
        Me.Button5.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 30)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "🔍"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NTS Browser"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(842, 18)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(567, 31)
        Me.TextBox1.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(842, 1)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(567, 11)
        Me.ProgressBar1.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1495, 1)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 31)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "⚙"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1546, 880)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Font = New System.Drawing.Font("Wide Latin", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Name = "Form1"
        Me.Text = "NTS Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button6 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
