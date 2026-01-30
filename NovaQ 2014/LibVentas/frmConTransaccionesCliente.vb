Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes

Public Class frmConTransaccionesCliente
    Private cConsulta As ClsConsultas
    Private dtFacCab As DataTable
    Private dtFacDet As DataTable
    Private dsFacturas As DataSet
    Private CRep As LibReportes.ClsReporte
    Private cProceso As ClsProcesos

    Private Sub frmConTransaccionesCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaIni.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpFechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)

    End Sub

    Private Sub tSalir_Click(sender As Object, e As EventArgs) Handles tSalir.Click
        cConsulta = Nothing
        Me.Close()
    End Sub

    Private Sub tConsultar_Click(sender As Object, e As EventArgs) Handles tConsultar.Click
        Dim DTFechaInicio As Date, DTFechaFin As Date

        DTFechaInicio = Format(dtpFechaIni.Value, "Short Date")
        DTFechaFin = Format(dtpFechaFin.Value, "Short Date")

        If DTFechaInicio > DTFechaFin Then
            MessageBox.Show("El rango de fechas es incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpFechaIni.Focus()
            Exit Sub
        End If

        cConsulta = New ClsConsultas
        dtFacCab = New DataTable
        dtFacDet = New DataTable

        Dim CabSource As New BindingSource()
        Dim DetSource As New BindingSource()

        dtFacCab = cConsulta.get_Lista_Transacciones_Cab(DTFechaInicio, DTFechaFin)
        dtFacDet = cConsulta.get_Lista_Transacciones_Det(DTFechaInicio, DTFechaFin)

        dtFacCab.TableName = "FacCab"
        dtFacDet.TableName = "FacDet"

        dsFacturas = New DataSet
        dsFacturas.Tables.Add(dtFacCab)
        dsFacturas.Tables.Add(dtFacDet)


        Dim relation As New DataRelation("DetalleFactura", _
            dsFacturas.Tables("FacCab").Columns("ID_CAB"), _
            dsFacturas.Tables("FacDet").Columns("ID_DET"))
        ' dsFacturas.Relations.Add(relation)


        CabSource.DataSource = dsFacturas
        CabSource.DataMember = "FacCab"

        DetSource.DataSource = CabSource
        DetSource.DataMember = "DetalleFactura"

        dgwDocumentoCab.DataSource = CabSource
        dgwDocumentoDet.DataSource = DetSource

        Call FormatoGrid()
        cConsulta = Nothing
    End Sub

    Private Sub FormatoGrid()
        With dgwDocumentoCab
            .Columns(0).HeaderText = "Tipo Doc."
            .Columns(1).HeaderText = "Serie Doc."
            .Columns(2).HeaderText = "Numero Doc."
            .Columns(3).HeaderText = "Fecha"
            .Columns(4).HeaderText = "Vencimiento"
            .Columns(5).HeaderText = "Cod.Cliente"
            .Columns(6).HeaderText = "Nom.Cliente"
            .Columns(7).HeaderText = "Direccion"
            .Columns(8).HeaderText = "Ruc"
            .Columns(9).HeaderText = "Importe"
            .Columns(10).HeaderText = "Tipo Cambio"
            .Columns(11).HeaderText = "Moneda"
            .Columns(12).HeaderText = "Doc.Ref"
            .Columns(13).HeaderText = "Serie.Ref"
            .Columns(14).HeaderText = "Numero Ref"
            .Columns(15).HeaderText = "Pedido"
            .Columns(16).HeaderText = "Comentario"
            .Columns(17).HeaderText = "Igv"
            .Columns(18).HeaderText = "Id"
            .Columns(19).HeaderText = "Pto. Venta"
            .Columns(20).HeaderText = "Estado"

        End With

        With dgwDocumentoDet
            .Columns(0).HeaderText = "Tipo Doc."
            .Columns(1).HeaderText = "Serie Doc."
            .Columns(2).HeaderText = "Numero Doc"
            .Columns(3).HeaderText = "Item"
            .Columns(4).HeaderText = "Codigo Parte"
            .Columns(5).HeaderText = "Descripcion"
            .Columns(6).HeaderText = "Cantidad"
            .Columns(7).HeaderText = "Precio Venta"
            .Columns(8).HeaderText = "Precio Calculo"
            .Columns(9).HeaderText = "Monto IGV"
            .Columns(10).HeaderText = "Porcentaje IGV"
            .Columns(11).HeaderText = "Importe Dolares"
            .Columns(12).HeaderText = "Importe Soles"
            .Columns(13).HeaderText = "Unidad Medida"
        End With
    End Sub

    Private Sub tsImprimirDocumento_Click(sender As Object, e As EventArgs) Handles tsImprimirDocumento.Click
        If dgwDocumentoCab.Rows.Count = 0 Then
            MessageBox.Show("No hay datos por imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim STRTipoDoc As String = String.Empty
        Dim STRSerieDoc As String = String.Empty
        Dim STRNumeroDoc As String = String.Empty

        STRTipoDoc = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("DOCUMENT_ID").Value
        STRSerieDoc = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("NUMBER_SERIE").Value
        STRNumeroDoc = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("NUMBER_DOCUMENT").Value

        CRep = New ClsReporte
        CRep.Muestra_Reporte("Sal_Receivable.rpt", "", "@DOCUMENT_ID;" & STRTipoDoc, "@NUMBER_SERIE;" & STRSerieDoc, "@NUMBER_DOCUMENT;" & STRNumeroDoc)
        CRep = Nothing
    End Sub

    Private Sub tsAnularDocumento_Click(sender As Object, e As EventArgs) Handles tsAnularDocumento.Click
        If dgwDocumentoCab.RowCount = 0 Then
            MessageBox.Show("No hay ningún documento por anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("¿Seguro que desea anular el documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cProceso = New ClsProcesos
            Dim STRTipoDoc As String = String.Empty
            Dim STRSerieDoc As String = String.Empty
            Dim STRNumeroDoc As String = String.Empty
            Dim STRPtoVenta As String = String.Empty

            STRTipoDoc = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("DOCUMENT_ID").Value
            STRSerieDoc = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("NUMBER_SERIE").Value
            STRNumeroDoc = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("NUMBER_DOCUMENT").Value
            STRPtoVenta = dgwDocumentoCab.Rows(dgwDocumentoCab.CurrentRow.Index).Cells("PLACE_SALES").Value

            If cProceso.Anula_Documento(STRTipoDoc, STRSerieDoc, STRNumeroDoc, STRPtoVenta) = True Then
                MessageBox.Show("Documento anulado satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call tConsultar_Click(sender, e)
            End If
            cProceso = Nothing
        End If




    End Sub
End Class