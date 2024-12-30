Imports DevExpress.Xpo

Public Class Pozicky
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

    'Cudzi kluc na knihu
    Private _kniha As Knihy
    <Association("Kniha-Pozicky")>
    Public Property Kniha() As Knihy
        Get
            Return _kniha
        End Get
        Set(ByVal value As Knihy)
            SetPropertyValue(NameOf(Kniha), _kniha, value)
        End Set
    End Property

    'Cudzi kluc na citatela
    Private _citatel As Citatelia
    <Association("Citatel-Pozicky")>
    Public Property Citatel() As Citatelia
        Get
            Return _citatel
        End Get
        Set(ByVal value As Citatelia)
            SetPropertyValue(NameOf(Citatel), _citatel, value)
        End Set
    End Property

    'Datum pozicania knihy
    Private _datumpozicania As DateTime
    Public Property Datumpozicania() As DateTime
        Get
            Return _datumpozicania
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(NameOf(Datumpozicania), _datumpozicania, value)
        End Set
    End Property

    'Datum vratenia knihy
    Private _datumvratenia As DateTime?
    Public Property Datumvratenia() As DateTime?
        Get
            Return _datumvratenia
        End Get
        Set(ByVal value As DateTime?)
            SetPropertyValue(NameOf(Datumvratenia), _datumvratenia, value)
        End Set
    End Property
End Class
