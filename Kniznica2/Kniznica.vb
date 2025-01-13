Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraReports.UI
Imports System.IO


'Zobrazit report 1
Module Report1
    Sub ZobrazReport1()

        ' Cesta k suboru
        Dim filePath As String = "C:\Users\wirth\Documents\XtraReport1.repx"

        ' kontorola ci subor existuje
        If File.Exists(filePath) Then
            Try
                ' Vytvorenie inštancie XtraReport
                Dim report As New XtraReport()

                ' Načítanie reportu zo súboru .repx
                report.LoadLayout(filePath)

                ' Zobrazenie reportu v náhľade
                Dim printTool As New ReportPrintTool(report)
                printTool.ShowPreviewDialog()
            Catch ex As Exception
                Console.WriteLine("Chyba pri načítavaní reportu: " & ex.Message)
            End Try
        Else
            Console.WriteLine("Subor neexistuje: " & filePath)
        End If
    End Sub
End Module

Module Report2
    Sub ZobrazReport2()

        ' Cesta k suboru
        Dim filePath As String = "C:\Users\wirth\Documents\XtraReport2.repx"

        ' kontorola ci subor existuje
        If File.Exists(filePath) Then
            Try
                ' Vytvorenie instancie XtraReport
                Dim report2 As New XtraReport()

                ' Nacitanie reportu zo suboru .repx
                report2.LoadLayout(filePath)

                ' Zobrazenie reportu 
                Dim printTool As New ReportPrintTool(report2)
                printTool.ShowPreviewDialog()
            Catch ex As Exception
                Console.WriteLine("Chyba pri nacitani reportu: " & ex.Message)
            End Try
        Else
            Console.WriteLine("Subor neexistuje: " & filePath)
        End If
    End Sub
End Module


Module GlobalVariables
    Public edit As Boolean = False
    Public pozickaKnihy As Boolean = False
    Public vratenieKnihy As Boolean = False
End Module

Public Class Kniznica

    Private Sub Kniznica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pripojenie na lokalnu MySQL databazu
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim connectionString As String = MySqlConnectionProvider.GetConnectionString("localhost", 3306, "root", "peter", "databaza")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, Nothing)

        ' rozbalit okna 
        Citatelia.Show()
        Knihy.Show()
        Pozicky.Show()
        Knihy.Activate()

    End Sub

    ' Bocne menu (vertikalne)
    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        Citatelia.Activate()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Knihy.Activate()
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Pozicky.Activate()
    End Sub

    ' Zobrazit report c.1
    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        ZobrazReport1()
    End Sub

    ' Zobrazit report c.2
    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        ZobrazReport2()
    End Sub

    ' Designer
    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Dim report As New XtraReport1
        Dim reportView As New ReportDesignTool(report)
        reportView.ShowDesigner()
    End Sub
End Class