
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pripojenie na lokalnu MySQL databazu
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim connectionString As String = MySqlConnectionProvider.GetConnectionString("localhost", 3306, "root", "peter", "databaza")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, Nothing)

        ' Zotriedenie tabuliek po spusteni
        GridView1.Columns("Priezvisko").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending ' Zotriedi tabulku Citatelia podla priezviska
        GridView2.Columns("Id").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending 'Zotriedi tabulku Knihy podla Id knihy
        GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending 'Zotriedi tabulku Pozicky podla datumu pozicania

        ' Zmena farby vybraneho riadku
        GridView1.Appearance.FocusedRow.BackColor = Color.LightGreen
        GridView2.Appearance.FocusedRow.BackColor = Color.LightGreen
        GridView3.Appearance.FocusedRow.BackColor = Color.LightGreen

        'vymazať zoznam knih pozicanych citatelom
        lbxPozicaneKnihy.Items.Clear()

    End Sub

    Private Sub btnNovyRiadokCitatelia_Click(sender As Object, e As EventArgs) Handles btnNovyRiadokCitatelia.Click
        ' Pridat novy riadok do tabulky Citatelia
        Try
            Dim novyCitatel As XPBaseObject = New Citatelia(UnitOfWork1)
            novyCitatel.Save()
            UnitOfWork1.CommitChanges()

            ' zobrazit tabulku Citatelia s novym riadkom, zotriedenou podla Priezviska
            XpCollection1.Reload()
            GridView1.RefreshData()
            GridView1.ClearSorting()
            GridView1.Columns("Priezvisko").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        Catch ex As Exception
            MessageBox.Show($"Chyba pri vytvarani noveho riadku: {ex.Message}")
        End Try

    End Sub

    Private Sub btnNovyRiadokKnihy_Click(sender As Object, e As EventArgs) Handles btnNovyRiadokKnihy.Click
        ' Pridat novy riadok do tabulky Knihy
        Try
            Dim novaKniha As XPBaseObject = New Knihy(UnitOfWork2)
            novaKniha.Save()
            UnitOfWork2.CommitChanges()

            ' zobrazit tabulku Citatelia s novym riadkom, zotriedenu podla ID
            XpCollection2.Reload()
            GridView2.RefreshData()
            GridView2.ClearSorting()
            GridView2.Columns("Id").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        Catch ex As Exception
            MessageBox.Show($"Chyba pri ukladani: {ex.Message}")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUlozitCitatelia.Click
        ' Ulozenie udajov v tabulke Citatelia
        Try
            GridView1.PostEditor()
            GridView1.UpdateCurrentRow()

            Dim Riadok As Object = GridView1.GetFocusedRow()
            Dim Citatel As Citatelia = CType(Riadok, XPBaseObject)
            Citatel.Save()
            UnitOfWork1.CommitChanges()
            MessageBox.Show($"Citatel {Citatel.Meno} {Citatel.Priezvisko} bol upraveny.")

        Catch ex As Exception
            MessageBox.Show($"Chyba pri ukladaní: {ex.Message}")
        End Try

    End Sub

    Private Sub btnUlozitKnihy_Click(sender As Object, e As EventArgs) Handles btnUlozitKnihy.Click
        ' Ulozenie udajov v tabulke Knihy
        Try
            GridView2.PostEditor()
            GridView2.UpdateCurrentRow()

            Dim Riadok As Object = GridView2.GetFocusedRow()
            Dim Kniha As Knihy = CType(Riadok, XPBaseObject)
            Kniha.Save()
            UnitOfWork2.CommitChanges()
            MessageBox.Show($"Kniha {Kniha.Nazov} bola upravena.")

        Catch ex As Exception
            MessageBox.Show($"Chyba pri ukladaní: {ex.Message}")
        End Try
    End Sub

    Private Sub btnVymazatRiadokCitatelia_Click(sender As Object, e As EventArgs) Handles btnVymazatRiadokCitatelia.Click
        ' Vymazat vybrany riadok z tabulky Citatelia
        Try
            Dim Riadok As Object = GridView1.GetFocusedRow()
            Dim vymazatCitatela As Citatelia = CType(Riadok, XPBaseObject)
            vymazatCitatela.Delete()
            UnitOfWork1.CommitChanges()
            MessageBox.Show($"Citatel: {vymazatCitatela.Meno} {vymazatCitatela.Priezvisko} bol vymazany")

            ' zobrazit aktualizovanu tabulku Citatelia
            XpCollection1.Reload()
            GridView1.RefreshData()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri mazani: {ex.Message}")
        End Try
    End Sub

    Private Sub btnVymazatRiadokKnihy_Click(sender As Object, e As EventArgs) Handles btnVymazatRiadokKnihy.Click
        ' Vymazat vybrany riadok z tabulky Knihy
        Try
            Dim Riadok As Object = GridView2.GetFocusedRow()
            Dim vymazatKnihu As Knihy = CType(Riadok, XPBaseObject)
            vymazatKnihu.Delete()
            UnitOfWork2.CommitChanges()
            MessageBox.Show($"Kniha {vymazatKnihu.Nazov} bola vymazana")

            ' zobrazit aktualizovanu tabulku Knihy
            XpCollection2.Reload()
            GridView2.RefreshData()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri mazani: {ex.Message}")
        End Try
    End Sub

    Private Sub btnVymazatPoziku_Click(sender As Object, e As EventArgs) Handles btnVymazatPoziku.Click
        'Vymazat vybrany riadok z tabulky Pozicky
        Try
            Dim Riadok As Object = GridView3.GetFocusedRow()
            Dim vymazatPozicku As Pozicky = CType(Riadok, XPBaseObject)
            vymazatPozicku.Delete()
            UnitOfWork3.CommitChanges()
            MessageBox.Show("Pozicka bola vymazana")

            ' zobrazit aktualizovanu tabulku Pozicky
            XpCollection3.Reload()
            GridView3.RefreshData()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri mazani: {ex.Message}")

        End Try
    End Sub

    Private Sub btnPozicatKnihu_Click(sender As Object, e As EventArgs) Handles btnPozicatKnihu.Click
        ' Vytvorit pozicku knihy
        Try
            ' overenie vyberu knihy
            Dim vyberKnihy As Object = GridView2.GetFocusedRow()
            Dim vyberCitatela As Object = GridView1.GetFocusedRow()

            If vyberKnihy Is Nothing OrElse vyberCitatela Is Nothing Then
                MessageBox.Show("Vyber knihu aj citatela")
                Return
            End If

            'zmenit stav knihy na pozicanu
            Dim pozicanaKniha As Knihy = CType(vyberKnihy, Knihy)
            pozicanaKniha.Pozicana = True
            pozicanaKniha.Save()
            UnitOfWork2.CommitChanges()
            MessageBox.Show($"Kniha {pozicanaKniha.Nazov} bola pozicana.")

            ' vytvorit objekt pozicky pomocou klucov na knihu a citatela
            Dim keyKnihy As String = GridView2.GetFocusedRowCellValue("Key").ToString()
            Dim keyCitatela As String = GridView1.GetFocusedRowCellValue("Key").ToString()
            Dim kniha As Knihy = UnitOfWork3.FindObject(Of Knihy)(CriteriaOperator.Parse("Key = ?", New Guid(keyKnihy)))
            Dim citatel As Citatelia = UnitOfWork3.FindObject(Of Citatelia)(CriteriaOperator.Parse("Key = ?", New Guid(keyCitatela)))

            ' vytvorit novu pozicku
            Dim novaPozicka As Pozicky = New Pozicky(UnitOfWork3)
            novaPozicka.Kniha = kniha
            novaPozicka.Citatel = citatel
            novaPozicka.Datumpozicania = DateTime.Now
            novaPozicka.Save()
            UnitOfWork3.CommitChanges()
            MessageBox.Show($"Pozicka pre knihu {pozicanaKniha.GetMemberValue("Nazov")} bola vytvorena.")

            ' zobrazit aktualizovanu tabulku Pozicky zotriedenu podla datumu pozicania
            XpCollection3.Reload()
            GridView3.RefreshData()
            GridView3.ClearSorting()
            GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

            ' zobrazit aktualizovanu tabulku Knihy s pridanou pozickou
            XpCollection2.Reload()
            GridView2.RefreshData()

            'zobrazit tabulku Citatelia s pridanou pozickou
            XpCollection1.Reload()
            GridView1.RefreshData()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri poziciavani knihy: {ex.Message}")
        End Try
    End Sub

    Private Sub GridControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseMove
        ' Zobrazenie pozicanych knih pri prejdeni mysou cez tabulku Citatelia
        Try
            ' Získanie aktualneho citatela
            Dim vyberCitatela As Object = GridView1.GetFocusedRow()

            Dim keyCitatela As String = GridView1.GetFocusedRowCellValue("Key").ToString()
            Dim citatel As Citatelia = UnitOfWork3.FindObject(Of Citatelia)(CriteriaOperator.Parse("Key = ?", New Guid(keyCitatela)))

            ' Získanie pozicanych knih
            Dim pozicaneKnihy As XPCollection(Of Pozicky) = citatel.Pozicky

            ' Vytvorenie zoznamu nazvov knih do listboxu
            lbxPozicaneKnihy.Items.Clear()
            For Each pozicka As Pozicky In pozicaneKnihy
                lbxPozicaneKnihy.Items.Add(pozicka.Kniha.Nazov)
            Next

        Catch ex As Exception
            MessageBox.Show($"Chyba pri zobrazeni pozicanych knih: {ex.Message}")

        End Try
    End Sub

    Private Sub btnVratitKnihu_Click(sender As Object, e As EventArgs) Handles btnVratitKnihu.Click
        ' Vratit knihu
        Try

            ' overenie vyberu knihy
            Dim vyberKnihy As Object = GridView2.GetFocusedRow()
            Dim vyberCitatela As Object = GridView1.GetFocusedRow()

            If vyberKnihy Is Nothing OrElse vyberCitatela Is Nothing Then
                MessageBox.Show("Vyber knihu aj citatela pre vratenie knihy")
                Return
            End If

            'nastavit priznak Pozicana na False
            Dim pozicanaKniha As Knihy = CType(vyberKnihy, XPBaseObject)
            pozicanaKniha.Pozicana = False
            pozicanaKniha.Save()
            UnitOfWork2.CommitChanges()
            MessageBox.Show($"Kniha {pozicanaKniha.Nazov} bola vrátená.")

            ' ziskat pozicku knihy
            Dim keyKnihy As String = GridView2.GetFocusedRowCellValue("Key").ToString()
            Dim keyCitatela As String = GridView1.GetFocusedRowCellValue("Key").ToString()
            Dim kniha As Knihy = UnitOfWork3.FindObject(Of Knihy)(CriteriaOperator.Parse("Key = ?", New Guid(keyKnihy)))
            Dim citatel As Citatelia = UnitOfWork3.FindObject(Of Citatelia)(CriteriaOperator.Parse("Key = ?", New Guid(keyCitatela)))
            Dim pozicka As Pozicky = UnitOfWork3.FindObject(Of Pozicky)(CriteriaOperator.Parse("Kniha = ? AND Citatel = ?", kniha, citatel))

            'nastavit datum vratenia knihy
            pozicka.Datumvratenia = DateTime.Now

            ' zobrazit aktualizovanu tabulku Pozicky zotriedenu podla datumu pozicania
            XpCollection3.Reload()
            GridView3.RefreshData()
            GridView3.ClearSorting()
            GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

            ' zobrazit aktualizovanu tabulku Knihy
            XpCollection2.Reload()
            GridView2.RefreshData()

        Catch ex As Exception
            MessageBox.Show($"Chyba pri vracani knihy: {ex.Message}")
        End Try
    End Sub

End Class
