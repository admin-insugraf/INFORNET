Module ModPrincipal
    Public STRUserSys As String = ""
    Public STRPassSys As String = ""
    Private FLogin As FrmLogin2
    Private FMenu As frmMenu
    Private BOLValidaOK As Boolean
    Public Sub main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        FLogin = New FrmLogin2
        FLogin.ShowDialog()
        If ValidaOK = True Then
            FMenu = New frmMenu
            Application.Run(FMenu)
        End If
    End Sub
    Public Property ValidaOK() As Boolean
        Get
            ValidaOK = BOLValidaOK
        End Get
        Set(ByVal value As Boolean)
            BOLValidaOK = value
        End Set
    End Property
End Module
