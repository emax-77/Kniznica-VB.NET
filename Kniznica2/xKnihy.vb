Imports DevExpress.Xpo

Public Class xKnihy
    Private Sub xKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = xKniznica
    End Sub

    Private Sub btnNovyRiadokKnihy_Click(sender As Object, e As EventArgs) Handles btnNovyRiadokKnihy.Click
        xNovaKniha.Show()

        'Try
        '    Dim novaKniha As XPBaseObject = New Knihy(UnitOfWork2)
        '    novaKniha.Save()
        '    UnitOfWork2.CommitChanges()

        '    ' zobrazit tabulku Citatelia s novym riadkom, zotriedenu podla ID
        '    XpCollection2.Reload()
        '    GridView2.RefreshData()
        '    GridView2.ClearSorting()
        '    GridView2.Columns("Id").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        'Catch ex As Exception
        '    MessageBox.Show($"Chyba pri ukladani: {ex.Message}")
        'End Try
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

End Class