<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ustawienia
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 43)
        Me.TextBox1.MaximumSize = New System.Drawing.Size(444, 31)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(444, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(444, 31)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "google.pl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Przeglądarka domyślna"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 549)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(553, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UWAGA! Ustawienia na razie nie działają, lecz później się to zmieni "
        '
        'Ustawienia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 597)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(684, 644)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(684, 644)
        Me.Name = "Ustawienia"
        Me.Text = "Ustawienia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
