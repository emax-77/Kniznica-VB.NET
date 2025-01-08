Imports DevExpress.Xpo
Imports Org.BouncyCastle.Asn1

Public Class xNovaKniha

    Dim Kniha As Knihy
    Private Sub xNovaKniha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Zistit aktualny pocet knih v kniznici a nastavit ID novej knihy +1
        Dim idKnihy As Integer
        Dim aktualnyPocetKnih As Integer = GetAktualnyPocetKnih()
        idKnihy = aktualnyPocetKnih + 1
        tedIdKnihy.Text = idKnihy

        'V pripade editacie vlozit eixstujuce udaje do formularov
        If edit = True Then

            Dim Riadok As Object = xKnihy.GridView2.GetFocusedRow()
            Dim Kniha As Knihy = CType(Riadok, XPBaseObject)

            tedNazovKnihy.DataBindings.Add("Text", Kniha, "Nazov")
            tedAutor.DataBindings.Add("Text", Kniha, "Autor")
            spePocetKusov.DataBindings.Add("Value", Kniha, "Pocet")

        End If
        edit = False
    End Sub

    ' Funkcia na zistenie aktualneho poctu knih v kniznici
    Private Function GetAktualnyPocetKnih() As Integer
        Dim pocetKnih As New XPCollection(Of Knihy)
        Return pocetKnih.Count
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub

    Private Sub btnUlozit_Click(sender As Object, e As EventArgs) Handles btnUlozit.Click
        'Ulozit novu knihu
        Try
            ' nacitat udaje z formularu
            Dim nazovKnihy As String = tedNazovKnihy.Text
            Dim autor As String = tedAutor.Text
            Dim pocet As Integer = spePocetKusov.Text

            ' vlozit udaje do tabulky Knihy
            Dim session As New UnitOfWork()
            Dim novaKniha As New Knihy(session)
            novaKniha.Id = tedIdKnihy.Text
            novaKniha.Pozicana = False
            novaKniha.Nazov = nazovKnihy
            novaKniha.Autor = autor
            novaKniha.Pocet = pocet
            novaKniha.Save()
            session.CommitChanges()
            MessageBox.Show($"Kniha {novaKniha.Nazov} bola ulozena")

            ' zobrazit aktualizovanu tabulku Knihy a zavriet formular
            xKnihy.XpCollection2.Reload()
            xKnihy.GridView2.RefreshData()
            Close()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri ukladani knihy: {ex.Message}")
        End Try
    End Sub
End Class