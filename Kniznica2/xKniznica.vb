Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB


Module GlobalVariables
    Public edit As Boolean = False
    Public pozickaKnihy = False
    Public vratenieKnihy = False
End Module

Public Class xKniznica


    Private Sub xKniznica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pripojenie na lokalnu MySQL databazu
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim connectionString As String = MySqlConnectionProvider.GetConnectionString("localhost", 3306, "root", "peter", "databaza")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, Nothing)

        xKnihy.Show()

        'zotriedenie tabuliek po spusteni
        xCitatelia.GridView1.Columns("Priezvisko").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending ' Zotriedi tabulku Citatelia podla priezviska
        xKnihy.GridView2.Columns("Id").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending 'Zotriedi tabulku Knihy podla Id knihy
        xPozicky.GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending 'Zotriedi tabulku Pozicky podla datumu pozicania

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        xPozicky.Close()
        xKnihy.Close()
        xCitatelia.Show()

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        xCitatelia.Close()
        xPozicky.Close()
        xKnihy.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        xCitatelia.Close()
        xKnihy.Close()
        xPozicky.Show()
    End Sub
End Class