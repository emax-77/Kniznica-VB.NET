Imports DevExpress.CodeParser
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports Org.BouncyCastle.Asn1

Public Class PozickaVratenie
    Private Sub btnZrusit_Click(sender As Object, e As EventArgs) Handles btnZrusit.Click
        Close()
    End Sub

    Private Sub btnPozicat_Click(sender As Object, e As EventArgs) Handles btnPozicat.Click

        'Pozicanie knihy
        If pozickaKnihy = True Then

            ' Pouzitie jednej session pre vsetky operacie
            Dim uow As New UnitOfWork()

            ' Nacitanie vybranych objektov cez KEY 
            Dim keyKnihy As String = CType(SearchLookUpEdit2.GetSelectedDataRow(), Knihy).Key.ToString()
            Dim keyCitatela As String = CType(SearchLookUpEdit1.GetSelectedDataRow(), Citatelia).Key.ToString()

            Dim pozicanaKniha As Knihy = uow.GetObjectByKey(Of Knihy)(New Guid(keyKnihy))
            Dim vybranyCitatel As Citatelia = uow.GetObjectByKey(Of Citatelia)(New Guid(keyCitatela))

            ' Overenie vybratych objektov
            If pozicanaKniha Is Nothing OrElse vybranyCitatel Is Nothing Then
                MessageBox.Show("Vyber knihu aj čitateľa")
                Return
            End If

            ' Zmeniť stav knihy na pozicanu
            pozicanaKniha.Pozicana = True

            ' Vytvoriť novu vypozicku
            Dim novaPozicka As New Pozicky(uow)
            novaPozicka.Kniha = pozicanaKniha
            novaPozicka.Citatel = vybranyCitatel
            novaPozicka.Datumpozicania = DateTime.Now

            ' Ulozit zmeny
            uow.CommitChanges()

            MessageBox.Show($"Pozicka pre knihu {pozicanaKniha.Nazov} bola vytvorena")
            pozickaKnihy = False

        End If

        'Vratenie knihy
        If vratenieKnihy = True Then

            ' Pouzitie jednej session pre vsetky operacie
            Dim uow As New UnitOfWork()

            ' Nacitanie vybranych objektov cez KEY 
            Dim keyKnihy As String = CType(SearchLookUpEdit2.GetSelectedDataRow(), Knihy).Key.ToString()
            Dim keyCitatela As String = CType(SearchLookUpEdit1.GetSelectedDataRow(), Citatelia).Key.ToString()

            Dim pozicanaKniha As Knihy = uow.GetObjectByKey(Of Knihy)(New Guid(keyKnihy))
            Dim vybranyCitatel As Citatelia = uow.GetObjectByKey(Of Citatelia)(New Guid(keyCitatela))

            ' Overenie vybratych objektov
            If pozicanaKniha Is Nothing OrElse vybranyCitatel Is Nothing Then
                MessageBox.Show("Vyber knihu aj čitateľa")
                Return
            End If

            ' Zmeniť stav knihy na vratenu
            pozicanaKniha.Pozicana = False

            ' Nastavit Datum vratenia knihy v pozicke
            Dim pozicka As Pozicky = uow.FindObject(Of Pozicky)(CriteriaOperator.Parse("Kniha = ? AND Citatel = ?", pozicanaKniha, vybranyCitatel))
            pozicka.Datumvratenia = DateTime.Now

            ' Ulozit zmeny
            uow.CommitChanges()

            MessageBox.Show($"Kniha {pozicanaKniha.Nazov} bola vratena")
            vratenieKnihy = False
        End If


        Close()

    End Sub
End Class