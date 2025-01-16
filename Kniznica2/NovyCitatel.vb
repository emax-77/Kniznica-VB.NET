Imports DevExpress.Xpo

Public Class NovyCitatel
    'Vytvorit alebo Editovat noveho citatela

    Dim Citatel As Citatel
    Dim UnitOfWork As UnitOfWork

    Private Sub NovyCitatel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'V pripade editacie urobit DataBindings
        If edit = True Then

            UnitOfWork = New UnitOfWork()

            Dim riadok = TryCast(Citatelia.GridView1.GetFocusedRow(), Citatel)
            If riadok IsNot Nothing Then
                Dim Citatel = UnitOfWork.GetObjectByKey(Of Citatel)(riadok.Key)

                tedMeno.DataBindings.Add("Text", Citatel, "Meno")
                tedPriezvysko.DataBindings.Add("Text", Citatel, "Priezvisko")
                dedDatumNarodenia.DataBindings.Add("Text", Citatel, "Datumnarodenia")
                tedObciansky.DataBindings.Add("Text", Citatel, "Obciansky")

            End If
        End If

    End Sub

    'Novy citatel
    Private Sub btnUlozit_Click(sender As Object, e As EventArgs) Handles btnUlozit.Click

        If edit = False Then
            Try

                ' nacitat udaje z formularu
                Dim meno As String = tedMeno.Text
                Dim priezvisko As String = tedPriezvysko.Text
                Dim datumNarodenia As String = dedDatumNarodenia.Text
                Dim obcianskyPreukaz As String = tedObciansky.Text

                ' vlozit udaje do tabulky Citatelia
                Dim session As New UnitOfWork()
                Dim novyCitatel As New Citatel(session)

                novyCitatel.Meno = meno
                novyCitatel.Priezvisko = priezvisko
                novyCitatel.Datumnarodenia = datumNarodenia.ToString
                novyCitatel.Obciansky = obcianskyPreukaz

                novyCitatel.Save()
                session.CommitChanges()
                MessageBox.Show($"Citatel {novyCitatel.Meno} {novyCitatel.Priezvisko} bol ulozeny")

                ' zobrazit aktualizovanu tabulku Citatelia a zavriet formular
                Citatelia.XpCollection1.Reload()
                Citatelia.GridView1.RefreshData()
                Close()

            Catch ex As Exception
                MessageBox.Show($"Chyba pri ukladani citatela: {ex.Message}")
            End Try
        End If


        'Editacia citatela
        If edit = True Then

            'upravene udaje sa ulozia 
            UnitOfWork.CommitChanges()

            'aktualizovat udaje v riadku tabulky a zavriet formular
            Citatelia.UnitOfWork1.Reload(Citatelia.GridView1.GetFocusedRow())
            Close()

        End If

    End Sub

    'tlacidlo Zrusit
    Private Sub btnZrusit_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub

    ' Validacia datumu narodenia pri novom citatelovi  - datum nesmie byt neskorsi ako dnes
    Private Sub dedDatumNarodenia_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dedDatumNarodenia.Properties.Validating
        If dedDatumNarodenia.EditValue > DateTime.Today Then
            MessageBox.Show(DateTime.Today.ToString)
            e.Cancel = True
        End If
    End Sub
End Class