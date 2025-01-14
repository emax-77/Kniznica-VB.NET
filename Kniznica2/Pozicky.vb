Imports DevExpress.Xpo
Imports DevExpress.XtraGrid

Public Class Pozicky
    Private Sub xPozicky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Kniznica

        ' zobrazit aktualizovanu tabulku Pozicky zotriedenu podla datumu pozicania
        XpCollection3.Reload()
        GridView3.RefreshData()
        GridView3.ClearSorting()
        GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Vymazat vybrany riadok z tabulky Pozicky
        Try
            Dim Riadok As Object = GridView3.GetFocusedRow()
            Dim vymazatPozicku As Pozicka = CType(Riadok, XPBaseObject)
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

    Private Sub sbtnExportExcel_Click(sender As Object, e As EventArgs) Handles sbtnExportExcel.Click
        Try
            ' cesta pre ulozenie Excel suboru
            Dim savePath As String = "C:\Users\wirth\Documents\Pozicky.xlsx"

            'kontrola ci GridControl obsahuje udaje na export
            If GridControl3.DataSource IsNot Nothing Then
                ' Export udajov z GridControl do Excelu
                GridControl3.ExportToXlsx(savePath)

                MessageBox.Show("Export OK, subor bol ulozeny do: " & savePath, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("GridControl neobsahuje udaje na export", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Chyba pri exporte: " & ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class