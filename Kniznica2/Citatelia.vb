Imports DevExpress.CodeParser
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class Citatelia

    Private Sub Citatelia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Kniznica

        ' Zotriedenie podla Priezviska
        GridView1.ClearSorting()
        GridView1.Columns("Priezvisko").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending


    End Sub

    Private Sub sbtnNovyCitatel_Click(sender As Object, e As EventArgs) Handles sbtnNovyCitatel.Click
        ' Pridat noveho Citatelia
        edit = False
        NovyCitatel.Show()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ' Editovat citatela
        edit = True
        NovyCitatel.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ' Vymazat vybrany riadok z tabulky Citatelia
        Try
            Dim Riadok As Object = GridView1.GetFocusedRow()
            Dim vymazatCitatela As Citatel = CType(Riadok, XPBaseObject)
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

    ' Zobrazit info o pozickach Citatela
    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        Dim riadok As Citatel = GridView1.GetFocusedRow()
        If riadok Is Nothing Then
            XpCollection2.Criteria = Nothing
            Return
        End If

        XpCollection2.Criteria = CriteriaOperator.Parse("[Citatel.Key] = ?", riadok.Key)

    End Sub

    ' Export Citatelov do Excelu
    Private Sub sbtnExportExcel_Click(sender As Object, e As EventArgs) Handles sbtnExportExcel.Click
        Try
            ' cesta pre ulozenie Excel suboru
            Dim savePath As String = "C:\Users\wirth\Documents\Citatelia.xlsx"

            'kontrola ci GridControl obsahuje udaje na export
            If GridControl1.DataSource IsNot Nothing Then
                ' Export udajov z GridControl do Excelu
                GridControl1.ExportToXlsx(savePath)

                MessageBox.Show("Export OK, subor bol ulozeny do: " & savePath, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("GridControl neobsahuje udaje na export.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Chyba pri exporte: " & ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class