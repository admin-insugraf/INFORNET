<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_Ops_Vs_Descargas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consulta_Ops_Vs_Descargas))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_numero_op = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle_insumos = New System.Windows.Forms.DataGridView()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle_descargas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgv_detalle_insumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_detalle_descargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(24, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "N° O.P."
        '
        'txt_numero_op
        '
        Me.txt_numero_op.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_numero_op.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero_op.Location = New System.Drawing.Point(73, 22)
        Me.txt_numero_op.Name = "txt_numero_op"
        Me.txt_numero_op.ReadOnly = True
        Me.txt_numero_op.Size = New System.Drawing.Size(113, 20)
        Me.txt_numero_op.TabIndex = 35
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox9, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(27, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(870, 456)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dgv_detalle_insumos)
        Me.GroupBox9.Controls.Add(Me.Label44)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(429, 450)
        Me.GroupBox9.TabIndex = 198
        Me.GroupBox9.TabStop = False
        '
        'dgv_detalle_insumos
        '
        Me.dgv_detalle_insumos.AllowUserToAddRows = False
        Me.dgv_detalle_insumos.AllowUserToDeleteRows = False
        Me.dgv_detalle_insumos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle_insumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_insumos.Location = New System.Drawing.Point(7, 41)
        Me.dgv_detalle_insumos.Name = "dgv_detalle_insumos"
        Me.dgv_detalle_insumos.ReadOnly = True
        Me.dgv_detalle_insumos.Size = New System.Drawing.Size(416, 401)
        Me.dgv_detalle_insumos.TabIndex = 47
        '
        'Label44
        '
        Me.Label44.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.BackColor = System.Drawing.Color.Navy
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(-3, 7)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(436, 19)
        Me.Label44.TabIndex = 36
        Me.Label44.Text = " Detalle de Insumos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_detalle_descargas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(438, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 450)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        '
        'dgv_detalle_descargas
        '
        Me.dgv_detalle_descargas.AllowUserToAddRows = False
        Me.dgv_detalle_descargas.AllowUserToDeleteRows = False
        Me.dgv_detalle_descargas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle_descargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_descargas.Location = New System.Drawing.Point(7, 41)
        Me.dgv_detalle_descargas.Name = "dgv_detalle_descargas"
        Me.dgv_detalle_descargas.ReadOnly = True
        Me.dgv_detalle_descargas.Size = New System.Drawing.Size(416, 401)
        Me.dgv_detalle_descargas.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = " Detalle de Descargas"
        '
        'btn_consultar
        '
        Me.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.ForeColor = System.Drawing.Color.Navy
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_consultar.Location = New System.Drawing.Point(193, 21)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(99, 23)
        Me.btn_consultar.TabIndex = 38
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'Frm_Consulta_Ops_Vs_Descargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(916, 537)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_numero_op)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Consulta_Ops_Vs_Descargas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de O.P. vs Descargas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgv_detalle_insumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_detalle_descargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_op As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_insumos As System.Windows.Forms.DataGridView
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle_descargas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
End Class
