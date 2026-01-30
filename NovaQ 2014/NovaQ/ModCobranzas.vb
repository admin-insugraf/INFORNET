Imports LibCobranzas
'Imports LibAlmacenes
Module ModCobranzas
    Friend frmcx_planillaCob As frm_CX_LT_PlanillaCobs
    Friend frmcx_planillaCob_CR As Frm_CX_LT_PlanillaCob_CR
    Friend frmcx_planillaCob_PF As Frm_CX_LT_PlanillaCob_PF
    Friend frmcx_clientes As frm_CX_MA_Cliente
    Friend frmcx_TipoPago As frm_CX_MA_TipoPago
    Friend frmcx_vendedor As frm_CX_MA_Vendedores
    Friend frmcx_conceptos_cob As frm_CX_MA_ConcepCob
    Friend frmletras As FrmLetras
    Friend frmPagosLetras As New FrmLetras_Pagos
    Friend frmcx_articulo As frm_CX_MA_Articulo
    Friend frmcx_banco As frm_CX_MA_Bancos
    Friend frmcx_proveedor As frm_CX_MA_Proveedor
    Friend frmcx_familia As frm_CX_MA_Familia
    Friend frmcx_transacion As frm_CX_MA_TransaccionTipo
    Friend frmcx_lotes As frm_CX_MA_Lotes
    Friend frmMantenimiento As FrmAceptacionLetras
    Friend frmestadoletrascobranza As FrmEstadoLetrasCobranzas
    Friend frmestadoletraspagos As FrmEstadoLetrasPagos
    Friend frmmantenimientoletraspagos As FrmAceptacionLetrasPagos
    Friend frmguiaanalisis As LibAlmacenes.frmGuiaAnalisis
    Friend frm_Ingreso_OC As frm_Ingreso_Orden_Compra
    Friend frmlistaprecios As FrmListaPrecios
    Friend frmchequescobranza As FrmCheques
    Friend frmcalendario As FrmCalendario
    Friend frmcentroscostoscompras As FrmCentroCostosCompra
    Friend frmcanjechequespagos As FrmChequesPagos
    Friend frmPreciosMat_Empaque As FrmArticuloAct_Mat_Empaque
    Friend frmTipoDocumento As Frm_Tipo_Documento
    Friend frm_Reporte_Precios_Anual As FrmVentasMensualArticulo
    Friend frmConsultaStock_Anual As FrmConsultaStock_Mensual
    Friend frm_Personal_RRHH As Frm_Personal_RR_HH
    Friend frm_Pr_Calculo_Planilla As Frm_PR_Calculo_Planilla
    Friend frmConceptos_Generales_RRHH As FrmConceptosGenerales
    Friend frm_MA_Establecimientos As Frm_MA_Establecimientos
    Friend frm_MA_Cargos As Frm_MA_Cargos
    Friend frm_MA_Categorias As Frm_MA_Categorias
    Friend frm_MA_Bancos As Frm_MA_Bancos
    Friend frm_MA_Fondo_Pensiones As Frm_MA_Fondo_Pensiones
    Friend frm_MA_Conceptos_Variables As Frm_MA_Conceptos_Variables
    Friend frm_PR_Adelanto_Quincena As Frm_PR_Adelanto_Quincena
    Friend frm_Contabiliza_Planilla As Frm_Contabilizar_Planilla
    Friend frm_oportunidad_clientes As Frm_CX_MA_Oportunidad_clientes
    Friend frm_cierre_modulos As FrmCierresModulos
    Friend frm_Envio_Boletas As Frm_Calculo_Envio_Boletas_Pago
    Friend frm_parte_produccion_orden_desarrollo As Frm_OP_Planta_Parte_Produccion
    Friend frm_Fact_tienda As FrmFacturacion_Tienda
End Module
