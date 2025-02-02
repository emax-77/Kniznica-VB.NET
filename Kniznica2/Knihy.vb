﻿Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class Knihy

    Private Sub xKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Kniznica

        ' Zotriedenie podla nazvu knihy
        GridView2.ClearSorting()
        GridView2.Columns("Nazov").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    ' Vratit knihu
    Private Sub btnVratitKnihu_Click(sender As Object, e As EventArgs)
        vratenieKnihy = True
        PozickaVratenie.Show()
    End Sub

    'Nova kniha
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        edit = False
        NovaKniha.Show()
    End Sub

    'Uprava udajov knihy
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        edit = True
        NovaKniha.Show()
    End Sub

    ' Vymazat Knihu
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim Riadok As Object = GridView2.GetFocusedRow()
        Dim vybrataKniha As Kniha = CType(Riadok, XPBaseObject)

        'Kontrola pred vymazanim - ci kniha nie je pozicana
        If vybrataKniha.Pozicana = False Then
            Try
                vybrataKniha.Delete()
                UnitOfWork2.CommitChanges()
                MessageBox.Show($"Kniha {vybrataKniha.Nazov} bola vymazana")

            Catch ex As Exception
                MessageBox.Show($"Chyba pri mazani: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Knihu nemozno vymazat pretoze je pozicana !")

        End If

    End Sub

    'Vytvorit pozicku knihy
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        pozickaKnihy = True
        PozickaVratenie.ShowDialog()
    End Sub

    ' Vratit knihu
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
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
            Dim savePath As String = "C:\Users\wirth\source\repos\Kniznica2\Knihy.xlsx"

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