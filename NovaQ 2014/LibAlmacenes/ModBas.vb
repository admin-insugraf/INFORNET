Imports System.Windows.Forms

Module ModBas
    Friend dtTable As DataTable
    Dim str_titulo_msgbox As String = "Sistema Cobranza"

    Public Sub Avisar(msg_ As String)
        MessageBox.Show(msg_, str_titulo_msgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function Preguntar(msg_ As String) As Boolean
        Dim rpta As Boolean = False
        If MessageBox.Show(msg_, str_titulo_msgbox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            rpta = Not rpta
        End If
        Return rpta
    End Function

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub

    'Public Sub Botonera_Estado_Inicio(frm As Form)
    '    frm.Controls("btn_Nuevo").Enabled = True
    '    frm.Controls("btn_grabar").Enabled = False
    '    frm.Controls("btn_Editar").Enabled = True
    '    frm.Controls("btn_cancelar").Enabled = False
    '    frm.Controls("btn_eliminar").Enabled = True
    '    frm.Controls("btn_salir").Enabled = True
    'End Sub

    'Public Sub Botonera_Estado_Cambiar(frm As Form)
    '    frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
    '    frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
    '    frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
    '    frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
    '    frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
    '    frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
    'End Sub
    Public Sub Limpiar_Controles(gb As System.Windows.Forms.GroupBox)

        For Each c As System.Windows.Forms.Control In gb.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If

            If TypeOf c Is MaskedTextBox Then
                c.Text = ""
            End If

            If TypeOf c Is ComboBox Then
                DirectCast(c, ComboBox).SelectedIndex = -1
            End If
        Next

    End Sub
End Module
