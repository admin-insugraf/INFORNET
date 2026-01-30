Imports System.Windows.Forms
'Imports DllInventario

Public Class FrmRevalorizacionInventario
    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtReporteRecalculo As DataTable

    Dim clsBusquedaBl As ClsBuscar
    Dim dtUltimoMes As DataTable
    Dim dtAlmacen As DataTable
    Dim dtTipoCambio As DataTable
    Dim dtDocumentosSinVal As DataTable
    Dim dtSaldoNegativo As DataTable
    Dim dtStockArticulo As DataTable
    Dim dtRevalorizaLotes As DataTable
    Dim dtDatosCompany As DataTable

    Private Sub UltimoMesRevalorizado()
        Try
            clsBusquedaBl = New ClsBuscar
            dtUltimoMes = New DataTable
            dtUltimoMes = clsBusquedaBl.Get_MesSinRevalorizar()
            If dtUltimoMes.Rows.Count() <> 0 Then
                dtpfechaInicio.Value = dtUltimoMes.Rows(0).Item(0).ToString()
                If dtpfechaInicio.Value > Date.Now() Then
                    dtpfechaFin.MinDate = dtpfechaInicio.Value
                    dtpfechaFin.Value = dtpfechaInicio.Value
                Else
                    dtpfechaFin.MinDate = dtpfechaInicio.Value
                    dtpfechaFin.Value = Date.Now
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function Busca_Documentos_Sin_Valorizar() As Boolean
        Dim estado As Boolean = True
        'Try
        '    Dim RSdocumentos As ADODB.Recordset
        '    Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza

        '    clsBusquedaBl = New ClsBuscar
        '    RSdocumentos = New ADODB.Recordset
        '    objRevaloriza = New DllInventario.ClsProcesoRevaloriza

        '    MessageBox.Show("Ingresa a validar Documentos sin Valorizar!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    dtDatosCompany = New DataTable
        '    dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        '    RSdocumentos = objRevaloriza.Get_Documentos_Sin_Valorizar("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
        '                      "V", "NI", "A", "N", "N", "N")
        '    If RSdocumentos.RecordCount > 0 Then
        '        MsgBox("Existen " & RSdocumentos.RecordCount & " documentos sin Valorizar.", MsgBoxStyle.Exclamation)
        '    End If
        '    RSdocumentos.Close()
        '    RSdocumentos = Nothing
        '    objRevaloriza = Nothing

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Return estado
    End Function

    Private Function Busca_Saldos_Negativos() As Boolean
        Dim estado As Boolean = True
        'Try
        '    Dim RSsaldos As ADODB.Recordset
        '    Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza

        '    RSsaldos = New ADODB.Recordset
        '    objRevaloriza = New DllInventario.ClsProcesoRevaloriza
        '    clsBusquedaBl = New ClsBuscar

        '    MessageBox.Show("Ingresa a validar Saldos Negativos!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    dtDatosCompany = New DataTable
        '    dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        '    RSsaldos = objRevaloriza.Get_Saldos_Negativos("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString)
        '    If RSsaldos.RecordCount > 0 Then
        '        MsgBox("Existen " & RSsaldos.RecordCount & " artículos con saldos negativos", MsgBoxStyle.Exclamation)
        '    End If
        '    RSsaldos.Close()
        '    RSsaldos = Nothing
        '    objRevaloriza = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Return estado
    End Function

    Private Function Validacion_Stock_Articulo() As Boolean
        Dim estado As Boolean = True
        'Try
        '    Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
        '    Dim INTnroreg As Integer
        '    objRevaloriza = New DllInventario.ClsProcesoRevaloriza
        '    clsBusquedaBl = New ClsBuscar

        '    MessageBox.Show("Ingresa a validar el Stock del Articulo!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    dtDatosCompany = New DataTable
        '    dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        '    INTnroreg = objRevaloriza.Validacion_StkArt("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
        '                "N", "N", "N")
        '    objRevaloriza = Nothing

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Return estado
    End Function

    Private Function Revaloriza_lotes() As Boolean
        Dim estado As Boolean = True
        'Try
        '    clsBusquedaBl = New ClsBuscar
        '    Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
        '    objRevaloriza = New DllInventario.ClsProcesoRevaloriza

        '    MessageBox.Show("Ingresa a validar la Revalorización de Lotes!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    dtDatosCompany = New DataTable
        '    dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        '    Call objRevaloriza.Revaloriza_Lotes("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
        '                dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"))
        '    objRevaloriza = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Return estado
    End Function

    Private Function Busca_TipoCambio_Cero() As Boolean
        Dim estado As Boolean = True
        'Try
        '    Dim RStcambio As ADODB.Recordset
        '    Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza

        '    clsBusquedaBl = New ClsBuscar
        '    RStcambio = New ADODB.Recordset
        '    objRevaloriza = New DllInventario.ClsProcesoRevaloriza
        '    dtRevalorizaLotes = New DataTable

        '    If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
        '        MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        dtpfechaInicio.Focus()
        '        estado = False
        '        Exit Try
        '    End If
        '    'AÑO 
        '    Dim fechaInicial As Date = dtpfechaInicio.Value
        '    Dim FechaFinal As Date = dtpfechaFin.Value
        '    MessageBox.Show("Ingresa a validar Tipo de cambio en valor cero!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'Nombre de la Pc
        '    dtDatosCompany = New DataTable
        '    dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        '    RStcambio = objRevaloriza.Get_Documentos_TCambio_Cero("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, "V", "I")
        '    If RStcambio.RecordCount > 0 Then
        '        MessageBox.Show("Existen " & RStcambio.RecordCount & " documentos sin tipo de cambio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End If
        '    RStcambio.Close()
        '    RStcambio = Nothing
        '    objRevaloriza = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Return estado
    End Function

    Private Function Revaloriza_Todos() As Boolean
        Dim estado As Boolean = True
        'Try
        '    clsBusquedaBl = New ClsBuscar
        '    Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
        '    objRevaloriza = New DllInventario.ClsProcesoRevaloriza

        '    MessageBox.Show("Ingresa a validar la Revalorización Total!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    dtDatosCompany = New DataTable
        '    dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        '    Call objRevaloriza.Revaloriza_Total("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
        '                   dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"))
        '    objRevaloriza = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Return estado
    End Function

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim INTreg As Integer
        Dim ide As String
        clsBusquedaBl = New ClsBuscar
        'Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
        'objRevaloriza = New DllInventario.ClsProcesoRevaloriza

        'Me.Cursor = Cursors.WaitCursor

        'Call Busca_TipoCambio_Cero()
        'Call Busca_Documentos_Sin_Valorizar()
        'Call Busca_Saldos_Negativos()
        'Call Validacion_Stock_Articulo()
        'Call Revaloriza_lotes()
        'Call Revaloriza_Todos()


        'dtDatosCompany = New DataTable
        'dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

        'ide = System.Environment.MachineName

        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, "AÑOMESLOTE" & ide)
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "ID_AUTONUM")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "RECALCULO_SERIE")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "RECALCULO_STOCK_LOTE")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPMESCOD")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPMOREMES")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPMOREMES1")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPMORESMESAUX")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPNOSALDOLOTE")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPSTKART")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPSTKARTFINAL")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "TMPVWMORESMESINGSAL")
        'INTreg = objRevaloriza.Delete_Temp("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, ide & "XXX")
        'objRevaloriza = Nothing

        'MessageBox.Show("Proceso concluido correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FrmRevalorizacionInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UltimoMesRevalorizado()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class