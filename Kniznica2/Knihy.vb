Imports DevExpress.Xpo

Public Class Knihy
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

    'ID knihy
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(NameOf(Id), _id, value)
        End Set
    End Property

    'Názov knihy
    Private _nazov As String
    <Size(255)>
    Public Property Nazov() As String
        Get
            Return _nazov
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Nazov), _nazov, value)
        End Set
    End Property

    'Autor
    Private _autor As String
    <Size(255)>
    Public Property Autor() As String
        Get
            Return _autor
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Autor), _autor, value)
        End Set
    End Property

    'Priznak "Je pozicana?"
    Private _pozicana As Boolean
    Public Property Pozicana() As Boolean
        Get
            Return _pozicana
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(NameOf(Pozicana), _pozicana, value)
        End Set
    End Property

    'Asociacia na tabulku Pozicky
    <Association("Kniha-Pozicky")>
    Public ReadOnly Property Pozicky() As XPCollection(Of Pozicky)
        Get
            Return GetCollection(Of Pozicky)(NameOf(Pozicky))
        End Get
    End Property
End Class
