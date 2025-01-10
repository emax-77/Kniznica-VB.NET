Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class Knihy

    Private Sub xKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Kniznica

        ' zobrazit aktualizovanu tabulku Knihy 
        XpCollection2.Reload()
        GridView2.RefreshData()

    End Sub

    Private Sub btnVratitKnihu_Click(sender As Object, e As EventArgs)
        ' Vratit knihu
        vratenieKnihy = True
        PozickaVratenie.Show()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Nova kniha
        edit = False
        NovaKniha.Show()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Uprava udajov knihy
        edit = True
        NovaKniha.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ' Vymazat Knihu
        Try
            Dim Riadok As Object = GridView2.GetFocusedRow()
            Dim vymazatKnihu As Kniha = CType(Riadok, XPBaseObject)
            vymazatKnihu.Delete()
            UnitOfWork2.CommitChanges()
            MessageBox.Show($"Kniha {vymazatKnihu.Nazov} bola vymazana")

        Catch ex As Exception
            MessageBox.Show($"Chyba pri mazani: {ex.Message}")
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        'Vytvorit pozicku knihy
        pozickaKnihy = True
        PozickaVratenie.ShowDialog()

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        ' Vratit knihu
        vratenieKnihy = True
        PozickaVratenie.Show()

    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Dim riadok As Kniha = GridView2.GetFocusedRow()
        If riadok Is Nothing Then
            XpCollection3.Criteria = Nothing
            Return
        End If

        XpCollection3.Criteria = CriteriaOperator.Parse("[Kniha.Key] = ?", riadok.Key)
    End Sub
End Class