<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_LT_BuscaAnexo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.cmb_campo = New System.Windows.Forms.ComboBox()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.dgv_Anexos = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_Anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(487, 249)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Aceptar.TabIndex = 7
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'cmb_campo
        '
        Me.cmb_campo.FormattingEnabled = True
        Me.cmb_campo.Items.AddRange(New Object() {"RUC", "DESCRIPCION"})
        Me.cmb_campo.Location = New System.Drawing.Point(12, 11)
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_campo.TabIndex = 6
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(139, 12)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(423, 20)
        Me.txt_filtro.TabIndex = 5
        '
        'dgv_Anexos
        '
        Me.dgv_Anexos.AllowUserToAddRows = False
        Me.dgv_Anexos.AllowUserToDeleteRows = False
        Me.dgv_Anexos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_Anexos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Anexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Anexos.Location = New System.Drawing.Point(12, 35)
        Me.dgv_Anexos.MultiSelect = False
        Me.dgv_Anexos.Name = "dgv_Anexos"
        Me.dgv_Anexos.ReadOnly = True
        Me.dgv_Anexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Anexos.Size = New System.Drawing.Size(550, 208)
        Me.dgv_Anexos.TabIndex = 4
        '
        'frm_CO_LT_BuscaAnexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(573, 277)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.cmb_campo)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.dgv_Anexos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CO_LT_BuscaAnexo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.dgv_Anexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btn_Aceptar As System.Windows.Forms.Button
    Private WithEvents cmb_campo As System.Windows.Forms.ComboBox
    Private WithEvents txt_filtro As System.Windows.Forms.TextBox
    Private WithEvents dgv_Anexos As System.Windows.Forms.DataGridView
End Class
