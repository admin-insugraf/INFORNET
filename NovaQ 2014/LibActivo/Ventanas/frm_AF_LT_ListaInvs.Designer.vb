<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_ListaInvs
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_ListaInvs))
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.col_NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_FEC_INICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_FEC_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_RESPONSABLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_OBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(379, 258)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 27)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'dgv_lista
        '
        Me.dgv_lista.AllowUserToAddRows = False
        Me.dgv_lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_NUMERO, Me.col_FEC_INICIO, Me.col_FEC_FINAL, Me.col_ESTADO, Me.col_RESPONSABLE, Me.col_OBS})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_lista.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_lista.Location = New System.Drawing.Point(12, 8)
        Me.dgv_lista.MultiSelect = False
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.ReadOnly = True
        Me.dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista.Size = New System.Drawing.Size(749, 240)
        Me.dgv_lista.TabIndex = 1
        '
        'col_NUMERO
        '
        Me.col_NUMERO.DataPropertyName = "NUMERO"
        Me.col_NUMERO.HeaderText = "NUMERO"
        Me.col_NUMERO.Name = "col_NUMERO"
        Me.col_NUMERO.ReadOnly = True
        Me.col_NUMERO.Width = 50
        '
        'col_FEC_INICIO
        '
        Me.col_FEC_INICIO.DataPropertyName = "FEC_INICIO"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_FEC_INICIO.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_FEC_INICIO.HeaderText = "FEC_INICIO"
        Me.col_FEC_INICIO.Name = "col_FEC_INICIO"
        Me.col_FEC_INICIO.ReadOnly = True
        '
        'col_FEC_FINAL
        '
        Me.col_FEC_FINAL.DataPropertyName = "FEC_FINAL"
        DataGridViewCellStyle3.Format = "d"
        Me.col_FEC_FINAL.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_FEC_FINAL.HeaderText = "FEC_FINAL"
        Me.col_FEC_FINAL.Name = "col_FEC_FINAL"
        Me.col_FEC_FINAL.ReadOnly = True
        '
        'col_ESTADO
        '
        Me.col_ESTADO.DataPropertyName = "ESTADO"
        Me.col_ESTADO.HeaderText = "ESTADO"
        Me.col_ESTADO.Name = "col_ESTADO"
        Me.col_ESTADO.ReadOnly = True
        '
        'col_RESPONSABLE
        '
        Me.col_RESPONSABLE.DataPropertyName = "RESPONSABLE"
        Me.col_RESPONSABLE.HeaderText = "RESPONSABLE"
        Me.col_RESPONSABLE.Name = "col_RESPONSABLE"
        Me.col_RESPONSABLE.ReadOnly = True
        Me.col_RESPONSABLE.Width = 150
        '
        'col_OBS
        '
        Me.col_OBS.DataPropertyName = "OBS"
        Me.col_OBS.HeaderText = "OBS"
        Me.col_OBS.Name = "col_OBS"
        Me.col_OBS.ReadOnly = True
        Me.col_OBS.Width = 200
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(291, 258)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 27)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_AF_LT_ListaInvs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(773, 293)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgv_lista)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_AF_LT_ListaInvs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Inventarios"
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents dgv_lista As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents col_NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_FEC_INICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_FEC_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_RESPONSABLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_OBS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
