Imports LibCobranzas.ClsOperaciones
Public Class frm_Mantenimiento_Usuario

    Private _Usuario As String
    Dim clsUsuarioBl As LibCobranzas.ClsOperaciones.USUARIO
    Dim Dt_detalle_user As DataTable
    Dim ClsUsuario As LibAdministracion.ClsUsuarios
    Dim EncriptadoBl As LibConexion.ClsData
    Public flag_salir As Boolean = False

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Private Sub DatosUsuario()
        Try
            clsUsuarioBl = New LibCobranzas.ClsOperaciones.USUARIO
            Dt_detalle_user = New DataTable
            Dt_detalle_user = clsUsuarioBl.DatosGeneralesUsuario(_Usuario)
            clsUsuarioBl = Nothing
            If Dt_detalle_user.Rows().Count() <> 0 Then
                txtCodUsuario.Text = Dt_detalle_user.Rows(0).Item("CODUSUARIO").ToString
                txtNombreUsuario.Text = Dt_detalle_user.Rows(0).Item("NOMUSUARIO").ToString
                txtPassword.Text = Dt_detalle_user.Rows(0).Item("PASSUSUARIO").ToString
                txtConfirmaPassword.Text = Dt_detalle_user.Rows(0).Item("PASSUSUARIO").ToString
                cboNivel.SelectedValue = Dt_detalle_user.Rows(0).Item("NIVEL_ACCESO").ToString
                cboPerfil.SelectedValue = Dt_detalle_user.Rows(0).Item("COD_PERFIL").ToString
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Niveles()
        Try
            ClsUsuario = New LibAdministracion.ClsUsuarios
            Dim dtNivelAcceso As New DataTable
            dtNivelAcceso = ClsUsuario.Niveles_Acceso_Usuarios("")
            cboNivel.DataSource = dtNivelAcceso
            cboNivel.ValueMember = dtNivelAcceso.Columns(0).ToString
            cboNivel.DisplayMember = dtNivelAcceso.Columns(1).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Mostrar_Perfiles()
        Try
            ClsUsuario = New LibAdministracion.ClsUsuarios
            Dim dtdetalles As New DataTable("Perfiles")
            dtdetalles = ClsUsuario.Lista_DatosPerfiles()
            If dtdetalles.Rows.Count() <> 0 Then
                cboPerfil.DataSource = Nothing
                cboPerfil.DataSource = dtdetalles
                cboPerfil.DisplayMember = "DESCRIPCION"
                cboPerfil.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_Mantenimiento_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Perfiles()
        Niveles()
        DatosUsuario()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If txtPassword.Text = "" Then
            MsgBox("Debe ingresar una contraseña.", MsgBoxStyle.Critical)
            txtPassword.Select()
            Exit Sub
        End If
        If txtConfirmaPassword.Text = "" Then
            MsgBox("Debe ingresar una contraseña.", MsgBoxStyle.Critical)
            txtConfirmaPassword.Select()
            Exit Sub
        End If
        If txtPassword.Text <> txtConfirmaPassword.Text Then
            MsgBox("La contraseña de confirmacion, debe ser igual a la del password.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        clsUsuarioBl = New LibCobranzas.ClsOperaciones.USUARIO
        EncriptadoBl = New LibConexion.ClsData
        Dim PassEncriptado = EncriptadoBl.EncryptString(txtPassword.Text)
        If clsUsuarioBl.Actualizar_DatosUsuario(_Usuario, PassEncriptado) Then
            MsgBox("Cambio de password realizado exitosamente.", MsgBoxStyle.Information)
            flag_salir = False
            Me.Close()
        End If
        clsUsuarioBl = Nothing
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        flag_salir = True
    End Sub
End Class