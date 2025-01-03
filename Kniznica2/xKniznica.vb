Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public Class xKniznica
    Private Sub xKniznica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pripojenie na lokalnu MySQL databazu
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim connectionString As String = MySqlConnectionProvider.GetConnectionString("localhost", 3306, "root", "peter", "databaza")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, Nothing)

        'nacitanie okien
        xCitatelia.SetDesktopLocation(0, 0)
        xCitatelia.Show()
        xKnihy.SetDesktopLocation(500, 50)
        xKnihy.Show()
        xPozicky.SetDesktopLocation(100, 300)
        xPozicky.Show()

        'prepnutie do okna Citatelia
        xKnihy.Activate()
    End Sub
End Class