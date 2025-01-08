Imports DevExpress.Xpo

Public Class xNovyCitatel
    'Vytvorit alebo Editovat  noveho citatela

    Dim Citatel As Citatelia

    Private Sub xNovyCitatel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'v pripade editacie vlozit eixstujuce udaje do formularov
        If edit = True Then

            Dim Riadok As Object = xCitatelia.GridView1.GetFocusedRow()
            Dim Citatel As Citatelia = CType(Riadok, XPBaseObject)

            tedMeno.DataBindings.Add("Text", Citatel, "Meno")
            tedPriezvysko.DataBindings.Add("Text", Citatel, "Priezvisko")
            dedDatumNarodenia.DataBindings.Add("Text", Citatel, "Datumnarodenia")
            tedObciansky.DataBindings.Add("Text", Citatel, "Obciansky")

        End If
        edit = False
    End Sub

    Private Sub btnUlozit_Click(sender As Object, e As EventArgs) Handles btnUlozit.Click
        'Ulozenie citatela 
        Try

            ' nacitat udaje z formularu
            Dim meno As String = tedMeno.Text
            Dim priezvisko As String = tedPriezvysko.Text
            Dim datumNarodenia As String = dedDatumNarodenia.Text
            Dim obcianskyPreukaz As String = tedObciansky.Text

            ' vlozit udaje do tabulky Citatelia
            Dim session As New UnitOfWork()
            Dim novyCitatel As New Citatelia(session)

            novyCitatel.Meno = meno
            novyCitatel.Priezvisko = priezvisko
            novyCitatel.Datumnarodenia = datumNarodenia.ToString
            novyCitatel.Obciansky = obcianskyPreukaz
            novyCitatel.Save()
            session.CommitChanges()
            MessageBox.Show($"Citatel {novyCitatel.Meno} bol ulozeny")

            ' zobrazit aktualizovanu tabulku Citatelia a zavriet formular
            xCitatelia.XpCollection1.Reload()
            xCitatelia.GridView1.RefreshData()
            Close()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri ukladani citatela: {ex.Message}")
        End Try
    End Sub

    Private Sub btnZrusit_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub
End Class