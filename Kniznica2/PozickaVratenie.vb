Imports DevExpress.CodeParser
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports Org.BouncyCastle.Asn1

Public Class PozickaVratenie
    Private Sub btnZrusit_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub

    'Pozicanie knihy
    Private Sub btnPozicat_Click(sender As Object, e As EventArgs) Handles btnPozicat.Click

        If pozickaKnihy = True Then

            ' Pouzitie jednej session pre vsetky operacie
            Dim uow As New UnitOfWork()

            ' Nacitanie vybranych objektov cez KEY 
            Dim keyKnihy As String = CType(SearchLookUpEdit2.GetSelectedDataRow(), Kniha).Key.ToString()
            Dim keyCitatela As String = CType(SearchLookUpEdit1.GetSelectedDataRow(), Citatel).Key.ToString()

            Dim pozicanaKniha As Kniha = uow.GetObjectByKey(Of Kniha)(New Guid(keyKnihy))
            Dim vybranyCitatel As Citatel = uow.GetObjectByKey(Of Citatel)(New Guid(keyCitatela))

            ' Overenie vybratych objektov
            If pozicanaKniha Is Nothing OrElse vybranyCitatel Is Nothing Then
                MessageBox.Show("Vyber knihu aj citatela")
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

            MessageBox.Show($"Pozicka pre knihu {pozicanaKniha.Nazov} bola vytvorena")
            pozickaKnihy = False

            RefreshData()

        End If

        'Vratenie knihy
        If vratenieKnihy = True Then

            ' Pouzitie jednej session pre vsetky operacie
            Dim uow As New UnitOfWork()

            ' Nacitanie vybranych objektov cez KEY 
            Dim keyKnihy As String = CType(SearchLookUpEdit2.GetSelectedDataRow(), Kniha).Key.ToString()
            Dim keyCitatela As String = CType(SearchLookUpEdit1.GetSelectedDataRow(), Citatel).Key.ToString()

            Dim pozicanaKniha As Kniha = uow.GetObjectByKey(Of Kniha)(New Guid(keyKnihy))
            Dim vybranyCitatel As Citatel = uow.GetObjectByKey(Of Citatel)(New Guid(keyCitatela))

            ' Overenie vybratych objektov
            If pozicanaKniha Is Nothing OrElse vybranyCitatel Is Nothing Then
                MessageBox.Show("Vyber knihu aj citatela")
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

            MessageBox.Show($"Kniha {pozicanaKniha.Nazov} bola vratena")
            vratenieKnihy = False

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

    Private Sub PozickaVratenie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class