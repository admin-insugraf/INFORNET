Public Class frm_Unidad
    Private nuevo As Boolean

    Private Sub cargarData()
        Using context = AlmacenContext.CrearContext()
            Dim qry = (From u In context.Unidades
                       Select u)
            Me.bsUnidad.DataSource = qry.ToList()
        End Using
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Dim unidad As New Unidad
        Botonera_Estado_Cambiar(True)
        cargarObjeto(unidad)
        nuevo = True
        TabControl1.SelectedIndex = 1
        txtCodigo.Focus()
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
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

    Private Sub frm_Unidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botonera_Estado_Cambiar(False)
        cargarData()
    End Sub

    Private Sub cargarObjeto(unidad As Unidad)
        txtCodigo.Text = unidad.Codigo
        txtDescripcion.Text = unidad.Nombre
    End Sub

    Private Function Validar() As Boolean
        If String.IsNullOrEmpty(txtCodigo.Text) Then
            Avisar("El codigo es obligatorio")
            txtCodigo.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtDescripcion.Text) Then
            Avisar("La descripcion es obligatoria")
            txtDescripcion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Validar() Then
            Using context = AlmacenContext.CrearContext()
                Dim unidad As Unidad
                If nuevo Then
                    unidad = New Unidad()
                Else
                    unidad = context.Unidades.Find(txtCodigo.Text)
                End If
                unidad.Codigo = txtCodigo.Text
                unidad.Nombre = txtDescripcion.Text
                If nuevo Then context.Unidades.Add(unidad)
                context.SaveChanges()
            End Using
            Avisar("Listo")
            TabControl1.SelectedIndex = 0
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = False
            btn_cancelar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        cargarData()
        TabControl1.SelectedIndex = 0
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Botonera_Estado_Cambiar(True)
        cargarObjeto(bsUnidad.Current)
        nuevo = False
        TabControl1.SelectedIndex = 1
        txtDescripcion.Enabled = True
        txtDescripcion.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Not bsUnidad.Current Is Nothing Then
            If Preguntar("Seguro de eliminar?") Then
                Using context = AlmacenContext.CrearContext()
                    Dim unidad = CType(bsUnidad.Current, Unidad)
                    Dim objeto = context.Unidades.Find(unidad.Codigo)
                    context.Unidades.Remove(objeto)
                    context.SaveChanges()
                End Using
                Avisar("Listo!")
                cargarData()
            End If
        End If
    End Sub

    Private Sub bsUnidad_CurrentChanged(sender As Object, e As EventArgs) Handles bsUnidad.CurrentChanged
        cargarObjeto(bsUnidad.Current)
    End Sub
 
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class