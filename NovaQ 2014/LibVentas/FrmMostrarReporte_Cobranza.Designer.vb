<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarReporte_Cobranza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarReporte_Cobranza))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.checkTodos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 53)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DETALLE DE REPORTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnMostrar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(9, 447)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 99)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(406, 25)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(254, 59)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "REGRESAR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Palatino Linotype", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnMostrar.Location = New System.Drawing.Point(71, 25)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(254, 59)
        Me.btnMostrar.TabIndex = 8
        Me.btnMostrar.Text = "MOSTRAR REPORTE"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.txtFiltro)
        Me.gbFiltros.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltros.Location = New System.Drawing.Point(9, 94)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(745, 47)
        Me.gbFiltros.TabIndex = 177
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(722, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(9, 149)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(745, 298)
        Me.dgvDocumentos.TabIndex = 176
        '
        'checkTodos
        '
        Me.checkTodos.AutoSize = True
        Me.checkTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkTodos.Location = New System.Drawing.Point(600, 78)
        Me.checkTodos.Name = "checkTodos"
        Me.checkTodos.Size = New System.Drawing.Size(154, 17)
        Me.checkTodos.TabIndex = 178
        Me.checkTodos.Text = "Marcar todos los Registros."
        Me.checkTodos.UseVisualStyleBackColor = True
        '
        'FrmMostrarReporte_Cobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(766, 558)
        Me.Controls.Add(Me.checkTodos)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.dgvDocumentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMostrarReporte_Cobranza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMostrarReporte_Cobranza"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents checkTodos As System.Windows.Forms.CheckBox
End Class
