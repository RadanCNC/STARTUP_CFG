<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtBoxPlikKonfiguracyjny = New System.Windows.Forms.TextBox()
        Me.BtnZmienProfil = New System.Windows.Forms.Button()
        Me.TxtBoxProfil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxJezyk = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBoxPlikKonfiguracyjny
        '
        Me.TxtBoxPlikKonfiguracyjny.Location = New System.Drawing.Point(12, 40)
        Me.TxtBoxPlikKonfiguracyjny.Name = "TxtBoxPlikKonfiguracyjny"
        Me.TxtBoxPlikKonfiguracyjny.Size = New System.Drawing.Size(296, 20)
        Me.TxtBoxPlikKonfiguracyjny.TabIndex = 1
        Me.TxtBoxPlikKonfiguracyjny.Text = "C:\VISI2022.0\System\STARTUP.CFG"
        '
        'Button1
        '
        Me.BtnZmienProfil.Location = New System.Drawing.Point(13, 226)
        Me.BtnZmienProfil.Name = "Button1"
        Me.BtnZmienProfil.Size = New System.Drawing.Size(101, 23)
        Me.BtnZmienProfil.TabIndex = 2
        Me.BtnZmienProfil.Text = "Zmień Profil"
        Me.BtnZmienProfil.UseVisualStyleBackColor = True
        '
        'TxtBoxProfil
        '
        Me.TxtBoxProfil.Location = New System.Drawing.Point(12, 98)
        Me.TxtBoxProfil.Name = "TxtBoxProfil"
        Me.TxtBoxProfil.Size = New System.Drawing.Size(296, 20)
        Me.TxtBoxProfil.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ścieżka pliku konfiguracyjnego:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aktualny profil:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Język:"
        '
        'TxtBoxJezyk
        '
        Me.TxtBoxJezyk.Location = New System.Drawing.Point(12, 161)
        Me.TxtBoxJezyk.Name = "TxtBoxJezyk"
        Me.TxtBoxJezyk.Size = New System.Drawing.Size(296, 20)
        Me.TxtBoxJezyk.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(12, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Odczytaj plik"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(233, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Wyjście"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(14, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Zmien Język"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "By K. Paprocki Verashape Sp. z o.o. Sp. k. All Rights Reserved"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 298)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtBoxJezyk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxProfil)
        Me.Controls.Add(Me.BtnZmienProfil)
        Me.Controls.Add(Me.TxtBoxPlikKonfiguracyjny)
        Me.Name = "Form1"
        Me.Text = "Konfigurator VISI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxPlikKonfiguracyjny As TextBox
    Friend WithEvents BtnZmienProfil As Button
    Friend WithEvents TxtBoxProfil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxJezyk As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
End Class
