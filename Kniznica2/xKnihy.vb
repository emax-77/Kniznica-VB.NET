Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class xKnihy

    Private Sub xKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = xKniznica

        ' zobrazit aktualizovanu tabulku Knihy 
        XpCollection2.Reload()
        GridView2.RefreshData()

    End Sub

    'Private Sub btnNovyRiadokKnihy_Click(sender As Object, e As EventArgs) Handles btnNovaKniha.Click
    '    'Nova kniha
    '    xNovaKniha.Show()
    'End Sub

    'Private Sub btnUlozitKnihy_Click(sender As Object, e As EventArgs) Handles btnUpravitKnihu.Click
    '    'Uprava udajov knihy
    '    edit = True
    '    xNovaKniha.Show()
    'End Sub

    'Private Sub btnVymazatRiadokKnihy_Click(sender As Object, e As EventArgs) Handles btnVymazatRiadokKnihy.Click
    '    ' Vymazat vybrany riadok z tabulky Knihy
    '    Try
    '        Dim Riadok As Object = GridView2.GetFocusedRow()
    '        Dim vymazatKnihu As Knihy = CType(Riadok, XPBaseObject)
    '        vymazatKnihu.Delete()
    '        UnitOfWork2.CommitChanges()
    '        MessageBox.Show($"Kniha {vymazatKnihu.Nazov} bola vymazana")

    '        ' zobrazit aktualizovanu tabulku Knihy
    '        XpCollection2.Reload()
    '        GridView2.RefreshData()

    '    Catch ex As Exception
    '        MessageBox.Show($"Chyba pri mazani: {ex.Message}")
    '    End Try
    'End Sub

    'Private Sub btnPozicatKnihu_Click(sender As Object, e As EventArgs) Handles btnPozicatKnihu.Click
    '    'Vytvorit pozicku knihy
    '    pozickaKnihy = True
    '    PozickaVratenie.Show()

    '    ' zobrazit aktualizovanu tabulku Knihy 
    '    XpCollection2.Reload()
    '    GridView2.RefreshData()

    'End Sub

    Private Sub btnVratitKnihu_Click(sender As Object, e As EventArgs)
        ' Vratit knihu
        vratenieKnihy = True
        PozickaVratenie.Show()

        ' zobrazit aktualizovanu tabulku Knihy 
        XpCollection2.Reload()
        GridView2.RefreshData()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Nova kniha
        xNovaKniha.Show()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Uprava udajov knihy
        edit = True
        xNovaKniha.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
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

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        'Vytvorit pozicku knihy
        pozickaKnihy = True
        PozickaVratenie.Show()

        ' zobrazit aktualizovanu tabulku Knihy 
        XpCollection2.Reload()
        GridView2.RefreshData()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        ' Vratit knihu
        vratenieKnihy = True
        PozickaVratenie.Show()

        ' zobrazit aktualizovanu tabulku Knihy 
        XpCollection2.Reload()
        GridView2.RefreshData()
    End Sub
End Class