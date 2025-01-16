Imports DevExpress.Xpo
Imports System.Xml

Public Class TreeListKnihy
    Private session As Session
    Private stromoveUdaje As List(Of TreeListNode)

    ' Vyyvorenie stromovej struktury
    Private Sub TreeListKnihy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Nacitanie knih
        session = New Session()
        Dim knihy As New XPCollection(Of Kniha)(session)

        'vytvorenie noveho stromu
        stromoveUdaje = New List(Of TreeListNode)()


        For Each kniha In knihy

            Dim knihaKey = Guid.NewGuid()

            ' Pridanie knih
            stromoveUdaje.Add(New TreeListNode With {
                .Key = knihaKey,
                .ParentKey = Nothing,
                .Nazov = kniha.Nazov,
                .Autor = kniha.Autor
            })

            ' Pridanie poziciek ku knihe
            For Each pozicka In kniha.Pozicka
                stromoveUdaje.Add(New TreeListNode With {
                    .Key = Guid.NewGuid(),
                    .ParentKey = knihaKey,
                    .Nazov = kniha.Nazov,
                    .Autor = kniha.Autor,
                    .Meno = pozicka.Citatel?.Meno,
                    .Priezvisko = pozicka.Citatel?.Priezvisko,
                    .DatumPozicania = If(pozicka.Datumpozicania.HasValue, pozicka.Datumpozicania.Value.ToString("d"), String.Empty),
                    .DatumVratenia = If(pozicka.Datumvratenia.HasValue, pozicka.Datumvratenia.Value.ToString("d"), String.Empty)
                })
            Next
        Next

        ' dataSource pre TreeList1
        TreeList1.DataSource = stromoveUdaje

        TreeList1.KeyFieldName = "Key"
        TreeList1.ParentFieldName = "ParentKey"

        ' rozbalenie celeho stromu
        TreeList1.ExpandAll()
    End Sub


    ' Vytvorenei XML z databazy
    Private Sub sbtnExportDatabazaDoXML_Click(sender As Object, e As EventArgs) Handles sbtnExportDatabazaDoXML.Click
        Try

            ' Nacitanie knih z databazy
            Dim session As New Session()
            Dim knihy As New XPCollection(Of Kniha)(session)

            ' Vytvorenie XML struktury
            Dim xmlDoc As New XmlDocument()
            Dim rootElement As XmlElement = xmlDoc.CreateElement("Kniznica")
            xmlDoc.AppendChild(rootElement)

            For Each kniha In knihy
                ' Vytvorenie elementu Kniha
                Dim knihaElement As XmlElement = xmlDoc.CreateElement("Kniha")

                ' Pridanie elementov pre nazov a autora
                Dim nazovElement As XmlElement = xmlDoc.CreateElement("Nazov")
                nazovElement.InnerText = kniha.Nazov
                knihaElement.AppendChild(nazovElement)

                Dim autorElement As XmlElement = xmlDoc.CreateElement("Autor")
                autorElement.InnerText = kniha.Autor
                knihaElement.AppendChild(autorElement)

                ' Nacitanie poziciek pre danu knihu
                For Each pozicka In kniha.Pozicka
                    Dim pozickaElement As XmlElement = xmlDoc.CreateElement("Pozicka")

                    ' Pridanie elementov pre pozicku
                    Dim menoElement As XmlElement = xmlDoc.CreateElement("Meno")
                    menoElement.InnerText = If(pozicka.Citatel?.Meno, String.Empty)
                    pozickaElement.AppendChild(menoElement)

                    Dim priezviskoElement As XmlElement = xmlDoc.CreateElement("Priezvisko")
                    priezviskoElement.InnerText = If(pozicka.Citatel?.Priezvisko, String.Empty)
                    pozickaElement.AppendChild(priezviskoElement)

                    Dim datumPozicaniaElement As XmlElement = xmlDoc.CreateElement("DatumPozicania")
                    datumPozicaniaElement.InnerText = If(pozicka.Datumpozicania.HasValue, pozicka.Datumpozicania.Value.ToString("d"), String.Empty)
                    pozickaElement.AppendChild(datumPozicaniaElement)

                    Dim datumVrateniaElement As XmlElement = xmlDoc.CreateElement("DatumVratenia")
                    datumVrateniaElement.InnerText = If(pozicka.Datumvratenia.HasValue, pozicka.Datumvratenia.Value.ToString("d"), String.Empty)
                    pozickaElement.AppendChild(datumVrateniaElement)

                    ' Pripojenie pozicky ku knihe
                    knihaElement.AppendChild(pozickaElement)
                Next

                ' Pripojenie knihy k ROOT elementu
                rootElement.AppendChild(knihaElement)
            Next

            ' Ulozenie XML do suboru
            Dim exportFilePath As String = "C:\Users\wirth\source\repos\Kniznica2\KniznicaXML.xml"
            xmlDoc.Save(exportFilePath)

            MessageBox.Show($"Udaje boli exportovane do suboru: {exportFilePath}", "Export OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Chyba pocas exportu: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

