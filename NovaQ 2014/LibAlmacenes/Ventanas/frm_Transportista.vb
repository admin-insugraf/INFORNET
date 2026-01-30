Public Class frm_Transportista
    Private nuevo As Boolean

    Private Sub cargarData()
        Using context = AlmacenContext.CrearContext()
            Dim qry = (From u In context.Transportistas
                       Where u.Estado = "V"
                       Select u)
            Me.bsTransportista.DataSource = qry.ToList()
        End Using
    End Sub

    Private Sub cargarObjeto(chofer As Transportista)
        txtCodigo.Text = chofer.Codigo
        txtRuc.Text = chofer.Ruc
        txtDni.Text = chofer.Dni
        txtNombre.Text = chofer.Nombre
        txtDireccion.Text = chofer.Direccion
        txtTelefono.Text = chofer.Telefono
        txtPlaca.Text = chofer.Placa
        txtBrevete.Text = chofer.Brevete
        txtModelo.Text = chofer.ModeloVehiculo
        txtInscripcion.Text = chofer.NroInscripcion
        txtNomEmpresa.Text = chofer.NombreEmpresa
        txtRucEmpresa.Text = chofer.RucEmpresa
        txtDirEmpresa.Text = chofer.DireccionEmpresa
        txtTelEmpresa.Text = chofer.TelefonoEmpresa
        If chofer.Estado = "V" Then cmbEstado.SelectedIndex = 0 Else cmbEstado.SelectedIndex = 1
    End Sub

    Private Function Validar() As Boolean
        If String.IsNullOrEmpty(txtCodigo.Text) Then
            Avisar("El codigo es obligatorio")
            txtCodigo.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtNombre.Text) Then
            Avisar("El nombre es obligatorio")
            txtNombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ActivarControles(estado As Boolean)
        txtCodigo.Enabled = estado
        txtRuc.Enabled = estado
        txtDni.Enabled = estado
        txtNombre.Enabled = estado
        txtDireccion.Enabled = estado
        txtTelefono.Enabled = estado
        txtPlaca.Enabled = estado
        txtBrevete.Enabled = estado
        txtModelo.Enabled = estado
        txtInscripcion.Enabled = estado
        txtNomEmpresa.Enabled = estado
        txtRucEmpresa.Enabled = estado
        txtDirEmpresa.Enabled = estado
        txtTelEmpresa.Enabled = estado
        cmbEstado.Enabled = estado
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub frm_Transportista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarData()
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub bsTransportista_CurrentChanged(sender As Object, e As EventArgs) Handles bsTransportista.CurrentChanged
        cargarObjeto(bsTransportista.Current)
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Dim chofer As New Transportista
        cargarObjeto(chofer)
        ActivarControles(True)
        TabControl1.SelectedIndex = 1
        txtCodigo.Focus()
        Botonera_Estado_Cambiar(True)
        nuevo = True
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Validar() Then
            Using context = AlmacenContext.CrearContext()
                Dim chofer As Transportista
                If nuevo Then
                    chofer = New Transportista()
                Else
                    chofer = context.Transportistas.Find(txtCodigo.Text)
                End If

                chofer.Codigo = txtCodigo.Text
                chofer.Ruc = txtRuc.Text
                chofer.Dni = txtDni.Text
                chofer.Nombre = txtNombre.Text
                chofer.Direccion = txtDireccion.Text
                chofer.Telefono = txtTelefono.Text
                chofer.Placa = txtPlaca.Text
                chofer.Brevete = txtBrevete.Text
                chofer.ModeloVehiculo = txtModelo.Text
                chofer.NroInscripcion = txtInscripcion.Text
                chofer.NombreEmpresa = txtNomEmpresa.Text
                chofer.RucEmpresa = txtRucEmpresa.Text
                chofer.DireccionEmpresa = txtDirEmpresa.Text
                chofer.TelefonoEmpresa = txtTelEmpresa.Text
                If cmbEstado.SelectedIndex = 0 Then chofer.Estado = "V" Else chofer.Estado = "A"
                If nuevo Then
                    context.Transportistas.Add(chofer)
                End If
                context.SaveChanges()
            End Using
            Avisar("Listo")
            TabControl1.SelectedIndex = 0
            ActivarControles(False)
            btn_cancelar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Botonera_Estado_Cambiar(True)
        nuevo = False
        TabControl1.SelectedIndex = 1
        ActivarControles(True)
        txtCodigo.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        TabControl1.SelectedIndex = 0
        ActivarControles(False)
        Botonera_Estado_Cambiar(False)
        cargarData()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Not bsTransportista.Current Is Nothing Then
            If Preguntar("Seguro de eliminar?") Then
                Using context = AlmacenContext.CrearContext()
                    Dim chofer = CType(bsTransportista.Current, Transportista)
                    Dim objeto = context.Transportistas.Find(chofer.Codigo)
                    context.Transportistas.Remove(objeto)
                    context.SaveChanges()
                End Using
                Avisar("Listo!")
                cargarData()
            End If
        End If
    End Sub
 
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class