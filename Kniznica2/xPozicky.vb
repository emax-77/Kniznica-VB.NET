﻿Imports DevExpress.Xpo

Public Class xPozicky
    Private Sub xPozicky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = xKniznica

        ' zobrazit aktualizovanu tabulku Pozicky zotriedenu podla datumu pozicania
        XpCollection3.Reload()
        GridView3.RefreshData()
        GridView3.ClearSorting()
        GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

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
End Class