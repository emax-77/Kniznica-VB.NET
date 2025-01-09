Imports DevExpress.Xpo
Imports Org.BouncyCastle.Asn1

Public Class NovaKniha
    'Vytvorit alebo editivat novu knihu

    Dim Kniha As Kniha
    Dim uow As UnitOfWork

    Private Sub NovaKniha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Zistit aktualny pocet knih v kniznici a nastavit ID novej knihy +1
        Dim idKnihy As Integer
        Dim aktualnyPocetKnih As Integer = GetAktualnyPocetKnih()
        idKnihy = aktualnyPocetKnih + 1
        tedIdKnihy.Text = idKnihy

        'V pripade editacie urobit DataBindings
        If edit = True Then

            uow = New UnitOfWork()

            Dim riadok = TryCast(Knihy.GridView2.GetFocusedRow(), Kniha)
            If riadok IsNot Nothing Then
                Dim Kniha = uow.GetObjectByKey(Of Kniha)(riadok.Key)

                tedNazovKnihy.DataBindings.Add("Text", Kniha, "Nazov")
                tedAutor.DataBindings.Add("Text", Kniha, "Autor")
                spePocetKusov.DataBindings.Add("Value", Kniha, "Pocet")

            End If
        End If
    End Sub

    ' Funkcia na zistenie aktualneho poctu knih v kniznici
    Private Function GetAktualnyPocetKnih() As Integer
        Dim pocetKnih As New XPCollection(Of Kniha)
        Return pocetKnih.Count
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub

    Private Sub btnUlozit_Click(sender As Object, e As EventArgs) Handles btnUlozit.Click
        'Ulozit novu knihu
        If edit = False Then

            Try
                ' nacitat udaje z formularu
                Dim nazovKnihy As String = tedNazovKnihy.Text
                Dim autor As String = tedAutor.Text
                Dim pocet As Integer = spePocetKusov.Text

                ' vlozit udaje do tabulky Knihy
                Dim session As New UnitOfWork()
                Dim novaKniha As New Kniha(session)
                novaKniha.Id = tedIdKnihy.Text
                novaKniha.Pozicana = False
                novaKniha.Nazov = nazovKnihy
                novaKniha.Autor = autor
                novaKniha.Pocet = pocet
                novaKniha.Save()
                session.CommitChanges()
                MessageBox.Show($"Kniha {novaKniha.Nazov} bola ulozena")

                ' zobrazit aktualizovanu tabulku Knihy a zavriet formular
                Knihy.XpCollection2.Reload()
                Knihy.GridView2.RefreshData()
                Close()

            Catch ex As Exception
                MessageBox.Show($"Chyba pri ukladani knihy: {ex.Message}")
            End Try

        End If

        'Editacia knihy
        If edit = True Then

            'upravene udaje sa ulozia 
            uow.CommitChanges()

            'aktualizovat udaje v riadku tabulky a zavriet formular
            Knihy.UnitOfWork2.Reload(Knihy.GridView2.GetFocusedRow())
            Close()

        End If


    End Sub
End Class