Imports DevExpress.Xpo

Public Class xCitatelia
    Private Sub xCitatelia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = xKniznica
        'zobrazit aktualizovanmu tabulku Citatelia 
        XpCollection1.Reload()
        GridView1.RefreshData()

    End Sub

    Private Sub btnNovyRiadokCitatelia_Click(sender As Object, e As EventArgs) Handles btnNovyRiadokCitatelia.Click
        ' Pridat novy riadok do tabulky Citatelia
        xNovyCitatel.Show()
    End Sub

    Private Sub btnUlozitCitatelia_Click(sender As Object, e As EventArgs) Handles btnUpravitCitatela.Click
        ' Editovat citatela
        edit = True
        xNovyCitatel.Show()
        ' Ulozenie udajov v tabulke Citatelia
        'Try
        '    Dim Riadok As Object = GridView1.GetFocusedRow()
        '    Dim Citatel As Citatelia = CType(Riadok, XPBaseObject)
        '    Citatel.Save()
        '    UnitOfWork1.CommitChanges()
        '    MessageBox.Show($"Citatel {Citatel.Meno} {Citatel.Priezvisko} bol upraveny.")

        'Catch ex As Exception
        '    MessageBox.Show($"Chyba pri ukladaní: {ex.Message}")
        'End Try
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
End Class