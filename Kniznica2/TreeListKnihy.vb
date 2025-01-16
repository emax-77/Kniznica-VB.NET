Imports DevExpress.Xpo
Imports System.Xml

Public Class TreeListKnihy
    Private session As Session
    Private stromoveUdaje As List(Of TreeListNode)

    ' Vyyvorenie stromovej struktury
    Private Sub TreeListKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        session = New Session()
        stromoveUdaje = New List(Of TreeListNode)()

        ' Nacitanie knih
        Dim knihy As New XPCollection(Of Kniha)(session)
        For Each kniha In knihy

            ' Vytvorenie unikatneho identifikatora pre knihu
            Dim knihaKey = Guid.NewGuid()
            stromoveUdaje.Add(New TreeListNode With {
                .Key = knihaKey,
                .Nazov = kniha.Nazov,
                .ParentKey = Nothing,
                .Autor = kniha.Autor
            })

            ' Pridanie poziciek ku knihe
            For Each pozicka In kniha.Pozicka
                stromoveUdaje.Add(New TreeListNode With {
                    .Key = Guid.NewGuid(),
                    .Nazov = kniha.Nazov & " - Pozicka",
                    .ParentKey = knihaKey,
                    .Autor = kniha.Autor,
                    .Meno = pozicka.Citatel?.Meno,
                    .Priezvisko = pozicka.Citatel?.Priezvisko,
                    .DatumPozicania = If(pozicka.Datumpozicania.HasValue, pozicka.Datumpozicania.Value.ToString("d"), String.Empty),
                    .DatumVratenia = If(pozicka.Datumvratenia.HasValue, pozicka.Datumvratenia.Value.ToString("d"), String.Empty)
                })
            Next
        Next

        ' Nastavenie DataSource pre TreeList1
        TreeList1.DataSource = stromoveUdaje

        ' Nastavenie klucovych poli
        TreeList1.KeyFieldName = "Key"
        TreeList1.ParentFieldName = "ParentKey"

        ' Rozbalenie celeho stromu
        TreeList1.ExpandAll()
    End Sub


    ' Vytvorenie XML suboru
    Public Sub ExportToXML(treeListNodes As List(Of TreeListNode), exportFilePath As String)
        Try
            ' Vytvorenie XML dokumentu
            Dim xmlDoc As New XmlDocument()
            Dim rootElement As XmlElement = xmlDoc.CreateElement("Kniznica") ' ROOT uzol
            xmlDoc.AppendChild(rootElement)

            ' Nacitanie unikatnych knih
            Dim knihy = treeListNodes.Where(Function(node) node.ParentKey Is Nothing).ToList()


            For Each kniha In knihy
                ' Vytvorenie XML elementu pre knihu
                Dim knihaElement As XmlElement = xmlDoc.CreateElement("Kniha")
                knihaElement.SetAttribute("Nazov", kniha.Nazov)
                knihaElement.SetAttribute("Autor", kniha.Autor)

                ' Pridanie CHILD uzlov pre pozicky
                Dim pozicky = treeListNodes.Where(Function(node) node.ParentKey.HasValue AndAlso node.ParentKey = kniha.Key).ToList()
                For Each pozicka In pozicky
                    Dim pozickaElement As XmlElement = xmlDoc.CreateElement("Pozicka")
                    pozickaElement.SetAttribute("Meno", If(pozicka.Meno, String.Empty))
                    pozickaElement.SetAttribute("Priezvisko", If(pozicka.Priezvisko, String.Empty))
                    pozickaElement.SetAttribute("DatumPozicania", If(Not String.IsNullOrEmpty(pozicka.DatumPozicania), pozicka.DatumPozicania, String.Empty))
                    pozickaElement.SetAttribute("DatumVratenia", If(Not String.IsNullOrEmpty(pozicka.DatumVratenia), pozicka.DatumVratenia, String.Empty))
                    knihaElement.AppendChild(pozickaElement)
                Next

                ' Pripojenie knihy k ROOT uzlu
                rootElement.AppendChild(knihaElement)
            Next

            ' Ulozenie XML dokumentu do suboru
            xmlDoc.Save(exportFilePath)

            MessageBox.Show($"Udaje boli exportovane do suboru: {exportFilePath}", "Export OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            MessageBox.Show($"Nastala chyba pocas exportu:  {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Kniznica do XML 
    Private Sub sbtnExportXML_Click(sender As Object, e As EventArgs) Handles sbtnExportXML.Click
        ' cesta ku suboru
        Dim exportFilePath As String = "C:\Users\wirth\source\repos\Kniznica2\KniznicaXML.xml"

        ExportToXML(stromoveUdaje, exportFilePath)
    End Sub
End Class

Public Class TreeListNode
    Public Property Key As Guid ' Unikatne ID pre uzol
    Public Property ParentKey As Guid? ' Odkaz na rodica (Parent)
    Public Property Nazov As String
    Public Property Autor As String
    Public Property Meno As String
    Public Property Priezvisko As String
    Public Property DatumPozicania As String
    Public Property DatumVratenia As String
End Class

