Imports System.IO

Public Class Form1

    Dim BladOtwarciaPliku As String = ("Błąd otwarcia pliku STARTUP.CFG, sprawdź czy to dobra ścieżka lub czy plik istnieje lub czy nie jest otwarty w innym programie")
    Dim PlikDoZapisuSciezki As String = ""

    Private Sub BtnZmienProfil_Click_1(sender As Object, e As EventArgs) Handles BtnZmienProfil.Click
        If File.Exists(TxtBoxPlikKonfiguracyjny.Text) = True Then
            ' MsgBox("Istnieje")
            ZmienProfil()
            OdczytajPlikKonfiguracyjny()
        Else
            MsgBox(BladOtwarciaPliku)
        End If
    End Sub

    Public Sub ZmienProfil()

        Dim profil_aktualny As String = TxtBoxProfil.Text
        Dim profil_nowy As String

        If profil_aktualny = "$ PROFILEID = DEFAULT ;" Then
            profil_nowy = "$ PROFILEID = CAM ;"
        Else
            profil_nowy = "$ PROFILEID = DEFAULT ;"
        End If

        Dim reader As New StreamReader(TxtBoxPlikKonfiguracyjny.Text)

        Dim s = reader.ReadToEnd().Replace(profil_aktualny, profil_nowy)
        reader.Dispose()

        Dim writer As New StreamWriter(TxtBoxPlikKonfiguracyjny.Text)
        writer.Write(s)

        writer.Dispose()
        'MsgBox("Wprowadzono zmiany profilu")
    End Sub

    Public Sub ZmienJezyk()

        Dim jezyk_aktualny As String = TxtBoxJezyk.Text
        Dim jezyk_nowy As String

        If jezyk_aktualny = "$LANGID = ENG;" Then
            jezyk_nowy = "$LANGID = POL;"
        Else
            jezyk_nowy = "$LANGID = ENG;"
        End If

        Dim reader As New StreamReader(TxtBoxPlikKonfiguracyjny.Text)

        Dim s = reader.ReadToEnd().Replace(jezyk_aktualny, jezyk_nowy)
        reader.Dispose()

        Dim writer As New StreamWriter(TxtBoxPlikKonfiguracyjny.Text)
        writer.Write(s)

        writer.Dispose()
        ' MsgBox("Wprowadzono zmiany jezyka")
    End Sub

    Public Sub ZmianyWPliku()

        Dim reader As New StreamReader(TxtBoxPlikKonfiguracyjny.Text)

        Dim s = reader.ReadToEnd().Replace("$ PROFILEID = DEFAULT ;", "$ PROFILEID = CAM ;")
        reader.Dispose()

        Dim writer As New StreamWriter(TxtBoxPlikKonfiguracyjny.Text)
        writer.Write(s)

        writer.Dispose()
        MsgBox("Wprowadzono zmiany")
    End Sub

    Public Sub OdczytajPlikKonfiguracyjny()
        Dim line As String
        Dim profil As String
        Dim jezyk As String
        Dim FilePath As String = TxtBoxPlikKonfiguracyjny.Text
        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader(FilePath)
            ' Read one line from file
            line = reader.ReadLine
            profil = reader.ReadLine
            line = reader.ReadLine
            line = reader.ReadLine
            jezyk = reader.ReadLine
        End Using
        TxtBoxJezyk.Text = jezyk
        TxtBoxProfil.Text = profil

    End Sub

    Public Sub OdczytajPlikLokalizacjiCFG()
        Dim line As String

        Dim FilePath As String = PlikDoZapisuSciezki
        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader(FilePath)
            ' Read one line from file
            line = reader.ReadLine

        End Using

        TxtBoxPlikKonfiguracyjny.Text = line

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If File.Exists(TxtBoxPlikKonfiguracyjny.Text) = True Then
            ' MsgBox("Istnieje")
            OdczytajPlikKonfiguracyjny()
        Else
            ' MsgBox(ErrorOtwarciaPliku)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If File.Exists(TxtBoxPlikKonfiguracyjny.Text) = True Then
            ' MsgBox("Istnieje")
            ZmienJezyk()
            OdczytajPlikKonfiguracyjny()
        Else
            MsgBox(BladOtwarciaPliku)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim root As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath)

        Directory.SetCurrentDirectory(root)

        '  MsgBox(Directory.GetCurrentDirectory())
        PlikDoZapisuSciezki = Directory.GetCurrentDirectory() & "\LokalizacjaPlikuCFG.txt"
        ' MsgBox(PlikDoZapisuSciezki)


        If File.Exists(PlikDoZapisuSciezki) = True Then
            ' MsgBox("Istnieje")

            OdczytajPlikLokalizacjiCFG()
        Else
            MsgBox("Błąd otwarcia pliku LokalizacjaPlikuCFG.txt")
        End If


        If File.Exists(TxtBoxPlikKonfiguracyjny.Text) = True Then
            ' MsgBox("Istnieje")

            OdczytajPlikKonfiguracyjny()
        Else
            MsgBox(BladOtwarciaPliku)
        End If

    End Sub
End Class
