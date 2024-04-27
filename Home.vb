Public Class Home
    Private fullname
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal fullName As String)
        InitializeComponent()
        Me.fullname = fullName
    End Sub
    Public Sub New(ByVal mdiFormWidth As Integer, ByVal mdiFormHeight As Integer, ByVal fullName As String)
        InitializeComponent()
        Me.fullname = fullName
        Dim posX As Integer
        Dim posY As Integer
        Dim myWidth = Me.Width
        Dim myHeight = Me.Height

        lbl_fullname.Text = "Hi " & Me.fullname & "!"

        posX = (mdiFormWidth - myWidth) / 2
        posY = (mdiFormHeight - myHeight) / 2
        Me.StartPosition = FormStartPosition.Manual

        Dim newPosition As New Point(posX, posY)
        Me.Location = newPosition
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class