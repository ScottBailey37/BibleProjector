





Public Class CustomListView
    Inherits Panel

    Private _images As New List(Of Image)
    Friend Property Images As List(Of Image)
        Get
            Return _images
        End Get
        Set(value As List(Of Image))
            _images = value
        End Set
    End Property

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Dim vsp As Windows.Forms.VScrollProperties = Me.VerticalScroll


    End Sub


    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

    End Sub



End Class
