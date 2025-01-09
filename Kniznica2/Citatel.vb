Imports DevExpress.Xpo

Public Class Citatel
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    'Primarny kluc
    Private _key As Guid
    <Key(True)>
    Public Property Key() As Guid
        Get
            Return _key
        End Get
        Set(ByVal value As Guid)
            SetPropertyValue(NameOf(Key), _key, value)
        End Set
    End Property

    'Cislo obcianskeho preukazu
    Private _obciansky As String
    <Size(255)>
    Public Property Obciansky() As String
        Get
            Return _obciansky
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Obciansky), _obciansky, value)
        End Set
    End Property

    'Meno
    Private _meno As String
    <Size(255)>
    Public Property Meno() As String
        Get
            Return _meno
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Meno), _meno, value)
        End Set
    End Property

    'Priezvisko
    Private _priezvisko As String
    <Size(255)>
    Public Property Priezvisko() As String
        Get
            Return _priezvisko
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Priezvisko), _priezvisko, value)
        End Set
    End Property

    'Datum narodenia
    Private _datumnarodenia As DateTime
    Public Property Datumnarodenia() As DateTime
        Get
            Return _datumnarodenia
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(NameOf(Datumnarodenia), _datumnarodenia, value)
        End Set
    End Property

    'Asociacia na tabulku Pozicky
    <Association("Citatel-Pozicka")>
    Public ReadOnly Property Pozicka() As XPCollection(Of Pozicka)
        Get
            Return GetCollection(Of Pozicka)(NameOf(Pozicka))
        End Get
    End Property
End Class
