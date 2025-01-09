Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Module GlobalVariables
    Public edit As Boolean = False
    Public pozickaKnihy As Boolean = False
    Public vratenieKnihy As Boolean = False
End Module

Public Class xKniznica

    Private Sub xKniznica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pripojenie na lokalnu MySQL databazu
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim connectionString As String = MySqlConnectionProvider.GetConnectionString("localhost", 3306, "root", "peter", "databaza")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, Nothing)

        ' rozbalit okna 
        xCitatelia.Show()
        xKnihy.Show()
        xPozicky.Show()
        xKnihy.Activate()

        'zotriedenie tabuliek po spusteni
        xCitatelia.GridView1.Columns("Priezvisko").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending ' Zotriedi tabulku Citatelia podla priezviska
        xKnihy.GridView2.Columns("Id").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending 'Zotriedi tabulku Knihy podla Id knihy
        xPozicky.GridView3.Columns("Datumpozicania").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending 'Zotriedi tabulku Pozicky podla datumu pozicania

    End Sub

    ' Bocne menu (vertikalne)
    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        xCitatelia.Activate()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        xKnihy.Activate()
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        xPozicky.Activate()
    End Sub

    'Horne menu (horizontalne)
    Private Sub BarSubItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem5.ItemClick
        xCitatelia.Activate()
    End Sub

    Private Sub BarSubItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem6.ItemClick
        xKnihy.Activate()
    End Sub

    Private Sub BarSubItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem7.ItemClick
        xPozicky.Activate()
    End Sub
End Class