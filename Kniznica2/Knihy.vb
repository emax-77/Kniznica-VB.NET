Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class Knihy

    Private Sub xKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Kniznica

        ' Zotriedenie podla nazvu knihy
        GridView2.ClearSorting()
        GridView2.Columns("Nazov").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending


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

    'Zobrazit info kto ma pozicane Knihy
    Private Sub GridView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Dim riadok As Kniha = GridView2.GetFocusedRow()
        If riadok Is Nothing Then
            XpCollection3.Criteria = Nothing
            Return
        End If

        XpCollection3.Criteria = CriteriaOperator.Parse("[Kniha.Key] = ?", riadok.Key)
    End Sub

    'Export Knih do Excelu
    Private Sub sbtnExportExcel_Click(sender As Object, e As EventArgs) Handles sbtnExportExcel.Click
        Try
            ' cesta pre ulozenie Excel suboru
            Dim savePath As String = "C:\Users\wirth\Documents\Knihy.xlsx"

            'kontrola ci GridControl obsahuje udaje na export
            If GridControl2.DataSource IsNot Nothing Then
                ' Export udajov z GridControl do Excelu
                GridControl2.ExportToXlsx(savePath)

                MessageBox.Show("Export OK, subor bol ulozeny do: " & savePath, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("GridControl neobsahuje udaje na export.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Chyba pri exporte: " & ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class