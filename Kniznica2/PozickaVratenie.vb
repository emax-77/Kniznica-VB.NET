Imports DevExpress.CodeParser
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports Org.BouncyCastle.Asn1

Public Class PozickaVratenie
    Private Sub btnZrusit_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub

    'Pozicanie / Vratenie knihy
    Private Sub btnPozicat_Click(sender As Object, e As EventArgs) Handles btnPozicat.Click

        'Pozicka knihy
        If pozickaKnihy = True Then

            Try
                ' Pouzitie jednej session pre vsetky operacie
                Dim uow As New UnitOfWork()

                ' Nacitanie vybranych objektov cez KEY 
                Dim keyKnihy As String = CType(SearchLookUpEdit2.GetSelectedDataRow(), Kniha).Key.ToString()
                Dim keyCitatela As String = CType(SearchLookUpEdit1.GetSelectedDataRow(), Citatel).Key.ToString()

                Dim pozicanaKniha As Kniha = uow.GetObjectByKey(Of Kniha)(New Guid(keyKnihy))
                Dim vybranyCitatel As Citatel = uow.GetObjectByKey(Of Citatel)(New Guid(keyCitatela))

                ' Overenie vybratych objektov
                If pozicanaKniha Is Nothing OrElse vybranyCitatel Is Nothing Then
                    MessageBox.Show("Vyber knihu aj citatela", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Zmeniť stav knihy na pozicanu
                pozicanaKniha.Pozicana = True

                ' Vytvoriť novu vypozicku
                Dim novaPozicka As New Pozicka(uow)
                novaPozicka.Kniha = pozicanaKniha
                novaPozicka.Citatel = vybranyCitatel
                novaPozicka.Datumpozicania = DateTime.Now

                ' Ulozit zmeny a aktualizovat udaje v tabulkach
                novaPozicka.Save()
                uow.CommitChanges()

                MessageBox.Show($"Pozicka pre knihu {pozicanaKniha.Nazov} bola vytvorena", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pozickaKnihy = False

                RefreshData()

            Catch ex As Exception
                MessageBox.Show($"Chyba pri vytvarani pozicky: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        'Vratenie knihy
        If vratenieKnihy = True Then

            Try
                ' Pouzitie jednej session pre vsetky operacie
                Dim uow As New UnitOfWork()

                ' Nacitanie vybranych objektov cez KEY 
                Dim keyKnihy As String = CType(SearchLookUpEdit2.GetSelectedDataRow(), Kniha).Key.ToString()
                Dim keyCitatela As String = CType(SearchLookUpEdit1.GetSelectedDataRow(), Citatel).Key.ToString()

                Dim pozicanaKniha As Kniha = uow.GetObjectByKey(Of Kniha)(New Guid(keyKnihy))
                Dim vybranyCitatel As Citatel = uow.GetObjectByKey(Of Citatel)(New Guid(keyCitatela))

                ' Overenie vybratych objektov
                If pozicanaKniha Is Nothing OrElse vybranyCitatel Is Nothing Then
                    MessageBox.Show("Vyber knihu aj citatela", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Zmeniť stav knihy na vratenu
                pozicanaKniha.Pozicana = False

                ' Nastavit Datum vratenia knihy v pozicke
                Dim pozicka As Pozicka = uow.FindObject(Of Pozicka)(CriteriaOperator.Parse("Kniha = ? AND Citatel = ?", pozicanaKniha, vybranyCitatel))
                pozicka.Datumvratenia = DateTime.Now

                ' Ulozit zmeny
                pozicka.Save()
                uow.CommitChanges()

                MessageBox.Show($"Kniha {pozicanaKniha.Nazov} bola vratena", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vratenieKnihy = False

            Catch ex As Exception
                MessageBox.Show($"Chyba pri vrateni knihy: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Close()
        'aktualizovat udaje v tabulkach
        RefreshData()

    End Sub

    'funkcia na Aktualizaciu udajov v tabulkach Knihy a Pozicky (ReFresh)
    Private Sub RefreshData()

        Dim uow As New UnitOfWork()

        Dim aktualizovaneKnihy = uow.Query(Of Kniha)().ToList()
        Dim aktualizovanePozicky = uow.Query(Of Pozicka)().ToList()

        Knihy.GridControl2.DataSource = aktualizovaneKnihy
        Pozicky.GridControl3.DataSource = aktualizovanePozicky

        Knihy.GridControl2.RefreshDataSource()
        Pozicky.GridControl3.RefreshDataSource()
    End Sub

End Class