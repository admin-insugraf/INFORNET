Imports System.Windows.Forms

Public Class frm_CO_RP_AnalisisCta01


    Dim AsientoContableCabs As ClsOperaciones.Asiento_Contable
    Dim DtDetallesAsientoC As DataTable
    Dim tipoAnexoInicial As String = String.Empty
    Dim tipoAnexofinal As String = String.Empty

    Private Sub frm_CO_RP_AnalisisCta01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtb_fec_des.Text = "01/01/" & Date.Now.Year()
        mtb_fec_has.Text = Date.Now()
        mtb_fec_des.Focus()
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        If Validaciones() = False Then Exit Sub
        Cursor = Cursors.WaitCursor
        Dim reporteBL As New ClsOperaciones.ReportesCO
        Dim fq As New ClsOperaciones.freeQuery
        Dim dt_tmp As DataTable = Nothing
        Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
        Dim ruc As String = String.Empty
        Dim razon As String = String.Empty
        If dt_info_emp.Rows.Count > 0 Then
            ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
        End If
        dt_info_emp = Nothing
        fq = Nothing
        Dim f1 As Date = DateTime.Parse(mtb_fec_des.Text)
        Dim f2 As Date = DateTime.Parse(mtb_fec_has.Text)
        '//grabamos los codigos
        If Grabar_Saldos() = True Then
            dt_tmp = reporteBL.Analisis_Cta01(f1, f2, txtCuentaContableInicial.Text, txtCuentaContableFinal.Text, txtTerceroIni.Text, txtTerceroFin.Text, IIf(chk_SoloPen.Checked, 1, 0), f1.Year)
            Dim crystalBL As New LibReportes.ClsReporte
            crystalBL.Muestra_Reporte("REP_CO_ANALISIS_CUENTA.RPT", dt_tmp, "", "", "@P_ANHO;" & f1.Year, "@P_PC;" & Environment.MachineName, "@P_PENDIENTES;" & IIf(chk_SoloPen.Checked, 1, 0), "@P_ANEXO2;" & txtTerceroFin.Text, "@P_ANEXO1;" & txtTerceroIni.Text, "@P_CUENTA2;" & txtCuentaContableFinal.Text, "@P_CUENTA1;" & txtCuentaContableInicial.Text, "@P_FECHA2;" & f2, "@P_FECHA1;" & f1, "pFecha1;" & mtb_fec_des.Text, "pFecha2;" & mtb_fec_has.Text, "pRazon;" & razon, "pRuc;" & ruc)
            dt_tmp = Nothing
            reporteBL = Nothing
            crystalBL = Nothing
            Cursor = Cursors.Default
        End If
    End Sub
    Private Function Grabar_Codigos() As Boolean
        Dim dt_tmp As DataTable
        Dim reporteBL As New ClsOperaciones.ReportesCO
        Dim fq As New ClsOperaciones.freeQuery
        Dim lista As New List(Of ClsEntidades.CO_TB_CODIGOS_TMP)
        dt_tmp = reporteBL.Get_Cuentas(txtCuentaContableInicial.Text, txtCuentaContableFinal.Text)
        If dt_tmp.Rows.Count > 0 Then
            For i As Integer = 0 To dt_tmp.Rows.Count - 1
                lista.Add(New ClsEntidades.CO_TB_CODIGOS_TMP(dt_tmp.Rows(i).Item("PC_NUM_CTA").ToString(), Environment.MachineName))
            Next
            fq.Insert_Cod_Tmp(lista)
            lista = Nothing
            fq = Nothing
        Else
            MsgBox("El rango de cuentas es invalido.", MsgBoxStyle.Information)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Function Grabar_Saldos() As Boolean
        Dim dt_tmp As DataTable
        Dim reporteBL As New ClsOperaciones.ReportesCO
        Dim fq As New ClsOperaciones.freeQuery
        Dim lista As New List(Of String)
        Dim anio As Integer, mes As Integer

        dt_tmp = reporteBL.Get_Cuentas(txtCuentaContableInicial.Text, txtCuentaContableFinal.Text)
        If dt_tmp.Rows.Count > 0 Then
            For i As Integer = 0 To dt_tmp.Rows.Count - 1
                lista.Add(dt_tmp.Rows(i).Item("PC_NUM_CTA").ToString())
            Next

            anio = Integer.Parse(CDate(mtb_fec_des.Text).Year)
            mes = Integer.Parse(CDate(mtb_fec_des.Text).Month)

            fq.Insert_Saldos_Cuentas(lista, anio, mes, Environment.MachineName, 1)

            lista = Nothing
            fq = Nothing
        Else
            MsgBox("El rango de cuentas es invalido.", MsgBoxStyle.Information)
            Return False
            Exit Function
        End If
        Return True
    End Function
    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Ayuda_Tercero(ByVal Texto As TextBox, ByVal Descripcion As TextBox, Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CONTA_SP_S_ANNEXED"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = IIf(tipoAnexoInicial <> String.Empty, tipoAnexoInicial, tipoAnexofinal)
                frm.Titulo = "Terceros"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                Dim dtdatos As DataTable
                dtdatos = New DataTable("CuentaContable")
                dtdatos = AsientoContableCabs.Get_ManualTercero(_CodigoCliente, IIf(tipoAnexoInicial <> String.Empty, tipoAnexoInicial, tipoAnexofinal))
                Dim codArticulo As String = String.Empty
                If dtdatos.Rows.Count() <> 0 Then
                    Texto.Text = dtdatos.Rows(0).Item(0).ToString
                    Descripcion.Text = dtdatos.Rows(0).Item(1).ToString
                Else
                    Dim frm As New frmBuscar
                    Dim sql As String = String.Empty
                    sql = "CONTA_SP_S_ANNEXED"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = IIf(tipoAnexoInicial <> String.Empty, tipoAnexoInicial, tipoAnexofinal)
                    frm.Titulo = "Terceros"
                    frm._Cadena_Filtro = _CodigoCliente
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                        Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    End If
                    frm.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub CuentaContable(ByVal Texto As TextBox, ByVal Descripcion As TextBox)
    '    Try
    '        Dim frm As New frmBuscar
    '        Dim sql As String = String.Empty
    '        sql = "CO_SP_S_PLANCTAS_MOV"
    '        frm.CadenaConsulta = sql
    '        frm._Flag_Filtro = True
    '        frm.Filtros1 = Date.Now.Year
    '        frm.Titulo = "Plan de Cuentas Contable"
    '        frm.ShowDialog()
    '        If frm.Data_Matriz.Rows.Count > 0 Then
    '            Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
    '            Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
    '            If Texto.Name = "txtCuentaContableInicial" Then
    '                If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
    '                    tipoAnexoInicial = String.Empty
    '                Else
    '                    If frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
    '                        tipoAnexoInicial = ""
    '                    Else
    '                        tipoAnexoInicial = frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
    '                    End If
    '                End If
    '            Else
    '                If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
    '                    tipoAnexofinal = String.Empty
    '                Else
    '                    If frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
    '                        tipoAnexofinal = ""
    '                    Else
    '                        tipoAnexofinal = frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
    '                    End If
    '                End If
    '            End If
    '            txtTerceroIni.Text = String.Empty
    '            txtTerceroFin.Text = String.Empty
    '            txtDescripcionTercero1.Text = String.Empty
    '            txtDescripcionTercero2.Text = String.Empty
    '        End If
    '        frm.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub CuentaContable(ByVal Texto As TextBox, ByVal Descripcion As TextBox, Optional ByVal _CodigoCuentaContable As String = "")
        Try
            If _CodigoCuentaContable = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CO_SP_S_PLANCTAS_MOV"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = Date.Now.Year
                frm.Titulo = "Plan de Cuentas Contable"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    If Texto.Name = "txtCuentaContableInicial" Then
                        If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
                            tipoAnexoInicial = String.Empty
                        Else
                            If frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
                                tipoAnexoInicial = ""
                            Else
                                tipoAnexoInicial = frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
                            End If
                        End If
                    Else
                        If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
                            tipoAnexofinal = String.Empty
                        Else
                            If frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
                                tipoAnexofinal = ""
                            Else
                                tipoAnexofinal = frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
                            End If
                        End If
                    End If
                    txtTerceroIni.Text = String.Empty
                    txtTerceroFin.Text = String.Empty
                    txtDescripcionTercero1.Text = String.Empty
                    txtDescripcionTercero2.Text = String.Empty
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                Dim dtdatos As DataTable
                dtdatos = New DataTable("CuentaContable")
                dtdatos = AsientoContableCabs.Get_ManualCuentaContable(_CodigoCuentaContable)
                Dim codArticulo As String = String.Empty
                If dtdatos.Rows.Count() <> 0 Then
                    Texto.Text = dtdatos.Rows(0).Item(0).ToString
                    Descripcion.Text = dtdatos.Rows(0).Item(1).ToString
                Else
                    Dim frm As New frmBuscar
                    Dim sql As String = String.Empty
                    sql = "CO_SP_S_PLANCTAS_MOV"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = Date.Now.Year
                    frm.Titulo = "Plan de Cuentas Contable"
                    frm._Cadena_Filtro = _CodigoCuentaContable
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                        Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                        If Texto.Name = "txtCuentaContableInicial" Then
                            If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
                                tipoAnexoInicial = String.Empty
                            Else
                                If frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
                                    tipoAnexoInicial = ""
                                Else
                                    tipoAnexoInicial = frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
                                End If
                            End If
                        Else
                            If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
                                tipoAnexofinal = String.Empty
                            Else
                                If frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
                                    tipoAnexofinal = ""
                                Else
                                    tipoAnexofinal = frm.Data_Matriz.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
                                End If
                            End If
                        End If
                        txtTerceroIni.Text = String.Empty
                        txtTerceroFin.Text = String.Empty
                        txtDescripcionTercero1.Text = String.Empty
                        txtDescripcionTercero2.Text = String.Empty
                    End If
                    frm.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DetallesCuentaContable(ByVal _NumeroCuenta As String)
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("DetalleCuentaContable")
            DtDetallesAsientoC = AsientoContableCabs.DetalleCuentaContable(_NumeroCuenta)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                
                If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
                    tipoAnexoInicial = String.Empty
                Else
                    If DtDetallesAsientoC.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
                        tipoAnexoInicial = ""
                    Else
                        tipoAnexoInicial = DtDetallesAsientoC.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validaciones()
        Dim estado As Boolean = True
        Try
            If txtCuentaContableInicial.Text = String.Empty Then
                MsgBox("Debe seleccionar una cuenta contable.", MsgBoxStyle.Information)
                txtCuentaContableInicial.Focus()
                estado = False
                Exit Try
            ElseIf txtCuentaContableFinal.Text = String.Empty Then
                MsgBox("Debe seleccionar una cuenta contable.", MsgBoxStyle.Information)
                txtCuentaContableFinal.Focus()
                estado = False
                Exit Try
            End If
            'If txtTerceroIni.Text = String.Empty Then
            '    MsgBox("Debe seleccionar un Tercero.", MsgBoxStyle.Information)
            '    txtTerceroIni.Focus()
            '    estado = False
            '    Exit Try
            'ElseIf txtTerceroFin.Text = String.Empty Then
            '    MsgBox("Debe seleccionar un Tercero.", MsgBoxStyle.Information)
            '    txtTerceroFin.Focus()
            '    estado = False
            '    Exit Try
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function



    Private Sub txtCuentaContableInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaContableInicial.MouseDoubleClick
        CuentaContable(txtCuentaContableInicial, txtDescripcionCuenta1)
    End Sub

    Private Sub txtCuentaContableFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaContableFinal.MouseDoubleClick
        CuentaContable(txtCuentaContableFinal, txtDescripcionCuenta2)
    End Sub

    Private Sub txtCuentaContableInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContableInicial.KeyDown
        If e.KeyCode = Keys.F1 Then CuentaContable(txtCuentaContableInicial, txtDescripcionCuenta1)
        If e.KeyCode = Keys.Enter Then
            If txtCuentaContableInicial.Text = String.Empty Then
                CuentaContable(txtCuentaContableInicial, txtDescripcionCuenta1)
            Else
                CuentaContable(txtCuentaContableInicial, txtDescripcionCuenta1, txtCuentaContableInicial.Text)
            End If
        End If
    End Sub

    Private Sub txtCuentaContableFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContableFinal.KeyDown

        If e.KeyCode = Keys.F1 Then CuentaContable(txtCuentaContableFinal, txtDescripcionCuenta2)
        If e.KeyCode = Keys.Enter Then
            If txtCuentaContableInicial.Text = String.Empty Then
                CuentaContable(txtCuentaContableFinal, txtDescripcionCuenta2)
            Else
                CuentaContable(txtCuentaContableFinal, txtDescripcionCuenta2, txtCuentaContableFinal.Text)
            End If
        End If
    End Sub

    Private Sub txtTerceroIni_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTerceroIni.MouseDoubleClick
        If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
            If tipoAnexoInicial <> tipoAnexofinal Then
                MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1)
        ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
            Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1)
        Else
            MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtTerceroFin_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTerceroFin.MouseDoubleClick
        If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
            If tipoAnexoInicial <> tipoAnexofinal Then
                MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
        ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
            Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
        Else
            MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub txtTerceroIni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTerceroIni.KeyDown
        If e.KeyCode = Keys.F1 Then
            If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
                If tipoAnexoInicial <> tipoAnexofinal Then
                    MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1)
            ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
                Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1)
            Else
                MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
                If tipoAnexoInicial <> tipoAnexofinal Then
                    MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                If txtCuentaContableInicial.Text = String.Empty Then
                    Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1)
                Else
                    Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1, txtTerceroIni.Text)
                End If
            ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
                If txtCuentaContableInicial.Text = String.Empty Then
                    Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1)
                Else
                    Ayuda_Tercero(txtTerceroIni, txtDescripcionTercero1, txtTerceroIni.Text)
                End If
            Else
                MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub txtTerceroFin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTerceroFin.KeyDown
        'If e.KeyCode = Keys.F1 Then
        '    If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
        '        If tipoAnexoInicial <> tipoAnexofinal Then
        '            MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
        '            Exit Sub
        '        End If
        '        Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
        '    ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
        '        Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
        '    Else
        '        MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
        '    End If
        'End If
        If e.KeyCode = Keys.F1 Then
            If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
                If tipoAnexoInicial <> tipoAnexofinal Then
                    MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
            ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
                Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
            Else
                MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If tipoAnexoInicial <> String.Empty And tipoAnexofinal <> String.Empty Then
                If tipoAnexoInicial <> tipoAnexofinal Then
                    MsgBox("La cuenta contable inicial posee un Tipo Anexo distinto a la cuenta contable final.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                If txtCuentaContableInicial.Text = String.Empty Then
                    Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
                Else
                    Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2, txtTerceroFin.Text)
                End If
            ElseIf tipoAnexoInicial <> String.Empty Or tipoAnexofinal <> String.Empty Then
                If txtCuentaContableInicial.Text = String.Empty Then
                    Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2)
                Else
                    Ayuda_Tercero(txtTerceroFin, txtDescripcionTercero2, txtTerceroFin.Text)
                End If
            Else
                MsgBox("Ambas cuentas contables no poseen un Tipo de Anexo.", MsgBoxStyle.Information)
            End If
        End If
    End Sub
 
    Private Sub mtb_fec_des_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtb_fec_des.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub mtb_fec_has_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtb_fec_has.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCuentaContableInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaContableInicial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCuentaContableFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaContableFinal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtTerceroIni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTerceroIni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtTerceroFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTerceroFin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
End Class