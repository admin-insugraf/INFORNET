Imports System.Windows.Forms

Public Class frmValoresDetalle

    Private STRCodigo As String
    Private STRDescripcion As String
    Private STRLote As String
    Private STREsLote As String
    Private STRSerie As String
    Private STREsSerie As String
    Private STRCodAlmacen As String
    Private DBLCantidad As Double
    Private DBLPrecio As Double
    Private DBLStock As Double
    Private BOLok As Boolean
    Private cVenta As ClsAyudas
    Private dtLote As DataTable
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        STRCodigo = ""
        STRDescripcion = ""
        STRCodAlmacen = ""
        STRLote = ""
        STREsLote = ""
        STRSerie = ""
        STREsSerie = ""
        DBLCantidad = 0
        DBLPrecio = 0
        DBLStock = 0
        BOLok = False
    End Sub

    Public Property EsOK As Boolean
        Get
            Return BOLok
        End Get
        Set(value As Boolean)
            BOLok = value
        End Set
    End Property

    Public Property Stock As Double
        Get
            Return DBLStock
        End Get
        Set(value As Double)
            DBLStock = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return DBLPrecio
        End Get
        Set(value As Double)
            DBLPrecio = value
        End Set
    End Property
    Public Property Cantidad As Double
        Get
            Return DBLCantidad
        End Get
        Set(value As Double)
            DBLCantidad = value
        End Set
    End Property

    Public Property EsLote As String
        Get
            Return STREsLote
        End Get
        Set(value As String)
            STREsLote = value
        End Set
    End Property
    Public Property EsSerie As String
        Get
            Return STREsSerie
        End Get
        Set(value As String)
            STREsSerie = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return STRCodigo
        End Get
        Set(value As String)
            STRCodigo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return STRDescripcion
        End Get
        Set(value As String)
            STRDescripcion = value
        End Set
    End Property

    Public Property Lote As String
        Get
            Return STRLote
        End Get
        Set(value As String)
            STRLote = value
        End Set
    End Property

    Public Property Serie As String
        Get
            Return STRSerie
        End Get
        Set(value As String)
            STRSerie = value
        End Set
    End Property

    Public Property Almacen As String
        Get
            Return STRCodAlmacen
        End Get
        Set(value As String)
            STRCodAlmacen = value
        End Set
    End Property

    Private Sub frmValoresDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = Codigo
        txtDescripcion.Text = Descripcion
        txtCantidad.Text = Cantidad
        txtPrecio.Text = Precio
        txtStock.Text = Stock
        cbLote.SelectedValue = Lote
        cbSerie.SelectedValue = Serie
        If EsLote = "S" Then
            Call Busca_Lote()
        End If
    End Sub

    Private Sub tAgregar_Click(sender As Object, e As EventArgs) Handles tAgregar.Click
        If Val(txtCantidad.Text) > Val(txtStock.Text) Then
            MessageBox.Show("La cantidad no puede ser mayor al stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Descripcion = txtDescripcion.Text.Trim
        Cantidad = Val(txtCantidad.Text)
        Precio = Val(txtPrecio.Text)
        Serie = cbSerie.SelectedValue
        Lote = cbLote.SelectedValue
        EsOK = True
        Me.Close()
    End Sub

    Private Sub Busca_Lote()
        dtLote = New DataTable
        cVenta = New ClsAyudas
        dtLote = cVenta.get_Lote_Parte(Almacen, Codigo)
        cbLote.DataSource = dtLote
        cbLote.ValueMember = dtTable.Columns(0).ToString
        cbLote.DisplayMember = dtTable.Columns(0).ToString
        cbLote.SelectedIndex = -1
        cVenta = Nothing
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        ModFunciones.OnlyNum(sender, e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        ModFunciones.OnlyDecimal(e, sender)
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    

    Private Sub cbLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbLote.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    

    Private Sub cbSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSerie.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    
    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub
End Class