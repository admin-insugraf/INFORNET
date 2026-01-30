Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.SqlClient

Public Class AlmacenContext
    Inherits DbContext
    Public Shared Function CrearContext() As AlmacenContext
        Dim cls As New LibConexion.ClsData
        Dim cn = cls.CadenaConexion()

        Dim cntx = New AlmacenContext(cn)
        Return cntx
    End Function



    Public Property Monedas As DbSet(Of Moneda)
    Public Property Articulos As DbSet(Of Articulo)
    Public Property Almacenes As DbSet(Of Almacen)
    Public Property Clientes As DbSet(Of Cliente)
    Public Property Proveedores As DbSet(Of Proveedor)
    Public Property CentrosCosto As DbSet(Of CentroCosto)
    Public Property TiposDeCambio As DbSet(Of TipoCambio)
    Public Property Unidades As DbSet(Of Unidad)
    Public Property NotasPedido As DbSet(Of NotaPedido)
    Public Property TiposMovimiento As DbSet(Of TipoMovimiento)
    Public Property Transportistas As DbSet(Of Transportista)
    Public Property Lotes As DbSet(Of Lote)

    Public Sub New(cadenaConexion As String)
        MyBase.New(cadenaConexion)
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
        modelBuilder.Conventions.Remove(Of KeyDiscoveryConvention)()

        With modelBuilder.Entity(Of Moneda)()
            .ToTable("CURRENCY_TYPE")
            .HasKey(Function(p) p.ID)
            .Property(Function(p) p.ID).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
            .Property(Function(p) p.Simbolo).HasColumnName("SYMBOL")
        End With

        With modelBuilder.Entity(Of Articulo)()
            .ToTable("PART")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Descripcion).HasColumnName("DESCRIPTION")
            .Property(Function(p) p.Unidad).HasColumnName("UNIT_OF_MEASUREMENT")
            .Property(Function(p) p.IsLot).HasColumnName("IS_LOT")
            .HasMany(Function(p) p.Lotes).WithRequired(Function(l) l.Articulo).HasForeignKey(Function(l) l.IDArticulo)
        End With

        With modelBuilder.Entity(Of Lote)()
            .ToTable("LOT")
            .HasKey(Function(p) New With {p.IDAlmacen, p.IDArticulo, p.Codigo})
            .Property(Function(p) p.IDAlmacen).HasColumnName("WHO_ID")
            .Property(Function(p) p.IDArticulo).HasColumnName("PART_ID")
            .Property(Function(p) p.Codigo).HasColumnName("LOT_ID")
        End With

        With modelBuilder.Entity(Of TipoArticulo)()
            .ToTable("PART_TYPE")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
        End With

        With modelBuilder.Entity(Of Almacen)()
            .ToTable("WAREHOUSE")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
            .Property(Function(p) p.Direccion).HasColumnName("ADDR_WHO")
            .Property(Function(p) p.Distrito).HasColumnName("STATE_ID")
            .Property(Function(p) p.IdTipoArticulo).HasColumnName("TYPE_PART")
            .Property(Function(p) p.Telefono).HasColumnName("PHONE")
            .Property(Function(p) p.UltimoIngreso).HasColumnName("LAST_NUM_IN")
            .Property(Function(p) p.UltimaSalida).HasColumnName("LAST_NUM_OUT")
            .Property(Function(p) p.Estado).HasColumnName("STATUS")
        End With

        With modelBuilder.Entity(Of Cliente)()
            .ToTable("CUSTOMER")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
        End With

        With modelBuilder.Entity(Of Proveedor)()
            .ToTable("VENDOR")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
        End With

        With modelBuilder.Entity(Of CentroCosto)()
            .ToTable("CCOST")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
        End With

        With modelBuilder.Entity(Of TipoCambio)()
            .ToTable("CURRENCY_EXCHANGE")
            .HasKey(Function(p) New With {p.Moneda, p.Fecha})
            .Property(Function(p) p.Moneda).HasColumnName("CURRENCY_ID")
            .Property(Function(p) p.Fecha).HasColumnName("CURRENCY_DATE")
            .Property(Function(p) p.Compra).HasColumnName("BUY_RATE")
            .Property(Function(p) p.Venta).HasColumnName("SELL_RATE")
            .Property(Function(p) p.CompraInversa).HasColumnName("BUY_EQUIV")
            .Property(Function(p) p.VentaInversa).HasColumnName("SELL_EQUIV")
        End With

        With modelBuilder.Entity(Of Unidad)()
            .ToTable("UNITS")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
        End With



        With modelBuilder.Entity(Of NotaPedido)()
            .ToTable("WAREHOUSE_TRANS")
            .HasKey(Function(p) New With {p.IDAlmacen, p.TipoDocumento, p.NumeroDocumento})
            .Property(Function(p) p.IDAlmacen).HasColumnName("WAREHOUSE_ID")
            .Property(Function(p) p.Fecha).HasColumnName("DATE_DOCUMENT")
            .Property(Function(p) p.IDMoneda).HasColumnName("CURRENCY_TYPE")
            .Property(Function(p) p.TipoCambio).HasColumnName("CURRENCY_EXCHANGE")
            .Property(Function(p) p.IDCliente).HasColumnName("CUSTOMER_ID")
            .Property(Function(p) p.Cliente).HasColumnName("CUSTOMER_NAME")
            .Property(Function(p) p.TipoDocumento).HasColumnName("DOCUMENT_ID")
            .Property(Function(p) p.NumeroDocumento).HasColumnName("NUMBER_DOCUMENT")
            .Property(Function(p) p.TipoDocReferencia).HasColumnName("DOC_ID_REF")
            .Property(Function(p) p.NumeroDocReferencia).HasColumnName("NUM_ID_REF")
            .Property(Function(p) p.OrdenCompra).HasColumnName("ORDER_REF")
            .Property(Function(p) p.TipoNota).HasColumnName("TYPE_TRANS")
            .Property(Function(p) p.IDProveedor).HasColumnName("VENDOR_ID")
            .Property(Function(p) p.Proveedor).HasColumnName("VENDOR_NAME")
            .Property(Function(p) p.IDCentroCosto).HasColumnName("CCOST_ID")
            .Property(Function(p) p.Monto).HasColumnName("AMOUNT")
            .Property(Function(p) p.TipoMovimiento).HasColumnName("TRANS_ID")
            .Property(Function(p) p.FechaActualizado).HasColumnName("UPDATE_DATE")
            .Property(Function(p) p.Hora).HasColumnName("HOUR")
            .Property(Function(p) p.Usuario).HasColumnName("USER_ID")
            .Property(Function(p) p.Estado).HasColumnName("STATUS_GUIA")
            .Property(Function(p) p.NUM_ORDER_MANUFACT).HasColumnName("NUM_ORDER_MANUFACT")
            .Property(Function(p) p.NUMBER_PURCHASE).HasColumnName("NUMBER_PURCHASE")
            .Property(Function(p) p.COMMENT).HasColumnName("COMMENT")
            .HasMany(Function(p) p.Lineas).WithRequired(Function(l) l.NotaPedido).HasForeignKey(Function(l) New With {l.IDAlmacen, l.TipoDocumento, l.NumeroDocumento})
        End With

        With modelBuilder.Entity(Of LineaNotaPedido)()
            .ToTable("WAREHOUSE_TRANS_LINE")
            .HasKey(Function(p) New With {p.IDAlmacen, p.TipoDocumento, p.NumeroDocumento, p.NumeroLinea})
            .Property(Function(p) p.IDAlmacen).HasColumnName("WAREHOUSE_ID")
            .Property(Function(p) p.TipoDocumento).HasColumnName("DOCUMENT_ID")
            .Property(Function(p) p.NumeroDocumento).HasColumnName("NUMBER_DOCUMENT")
            .Property(Function(p) p.NumeroLinea).HasColumnName("ITEM")
            .Property(Function(p) p.IDArticulo).HasColumnName("PART_ID")
            .Property(Function(p) p.Articulo).HasColumnName("PART_DESCRIPTION")
            .Property(Function(p) p.Cantidad).HasColumnName("QTY")
            .Property(Function(p) p.UnitArticulo).HasColumnName("UNIT_PART")
            .Property(Function(p) p.PrecioUnitario).HasColumnName("UNIT_PRICE")
            .Property(Function(p) p.CostoPromedio).HasColumnName("AVERAGE_COST")
            .Property(Function(p) p.Monto).HasColumnName("AMOUNT")
            .Property(Function(p) p.MontoEnDolares).HasColumnName("AMOUNT_US")
            .Property(Function(p) p.IDMoneda).HasColumnName("CURRENCY_ID")
            .Property(Function(p) p.TipoCambio).HasColumnName("TYPE_EXCHANGE")
            .Property(Function(p) p.EsValorizado).HasColumnName("STATUS_VALUE")
            .Property(Function(p) p.Lote).HasColumnName("NUMBER_LOT")
            .Property(Function(p) p.QT_BULTOS).HasColumnName("QT_BULTOS")
            .Property(Function(p) p.OPT_ENTREGA).HasColumnName("OPT_ENTREGA")
            .Property(Function(p) p.NUM_PROTOCOLOS).HasColumnName("NUM_PROTOCOLOS")
        End With


        With modelBuilder.Entity(Of TipoMovimiento)()
            .ToTable("TRANSACTION_TYPE")
            .HasKey(Function(p) New With {p.Tipo, p.Codigo})
            .Property(Function(p) p.Tipo).HasColumnName("TYPE_ID")
            .Property(Function(p) p.Codigo).HasColumnName("MOV_ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME")
        End With

        With modelBuilder.Entity(Of Transportista)()
            .ToTable("CARRIER")
            .HasKey(Function(p) p.Codigo)
            .Property(Function(p) p.Codigo).HasColumnName("ID")
            .Property(Function(p) p.Nombre).HasColumnName("NAME_CARRIER")
            .Property(Function(p) p.Ruc).HasColumnName("VAT_REGISTRATION")
            .Property(Function(p) p.Dni).HasColumnName("NUMBER_DOCUMENT")
            .Property(Function(p) p.Direccion).HasColumnName("ADDR")
            .Property(Function(p) p.Telefono).HasColumnName("PHONE")
            .Property(Function(p) p.Placa).HasColumnName("NUMBER_REGISTRATION")
            .Property(Function(p) p.Brevete).HasColumnName("NUMBER_LICENSE")
            .Property(Function(p) p.ModeloVehiculo).HasColumnName("MODEL_VEH")
            .Property(Function(p) p.NroInscripcion).HasColumnName("NUMBER_INSCRIP")
            .Property(Function(p) p.NombreEmpresa).HasColumnName("NAME")
            .Property(Function(p) p.RucEmpresa).HasColumnName("VAT_REGISTRATION_COMP")
            .Property(Function(p) p.DireccionEmpresa).HasColumnName("ADDR_COMP")
            .Property(Function(p) p.TelefonoEmpresa).HasColumnName("PHONE_COMP")
            .Property(Function(p) p.Estado).HasColumnName("STATUS")
        End With
    End Sub
End Class
