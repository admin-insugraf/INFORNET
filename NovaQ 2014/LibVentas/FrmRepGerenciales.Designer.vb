<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepGerenciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepGerenciales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReporte8 = New System.Windows.Forms.Button()
        Me.btnReporte7 = New System.Windows.Forms.Button()
        Me.btnReporte4 = New System.Windows.Forms.Button()
        Me.btnReporte6 = New System.Windows.Forms.Button()
        Me.btnReporte5 = New System.Windows.Forms.Button()
        Me.btnReporte2 = New System.Windows.Forms.Button()
        Me.btnReporte1 = New System.Windows.Forms.Button()
        Me.btnReporte3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 664)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte8, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte7, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte6, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte3, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1022, 645)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnReporte8
        '
        Me.btnReporte8.BackColor = System.Drawing.Color.Black
        Me.btnReporte8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte8.Location = New System.Drawing.Point(768, 325)
        Me.btnReporte8.Name = "btnReporte8"
        Me.btnReporte8.Size = New System.Drawing.Size(251, 317)
        Me.btnReporte8.TabIndex = 7
        Me.btnReporte8.Tag = "Reporte8"
        Me.btnReporte8.UseVisualStyleBackColor = False
        '
        'btnReporte7
        '
        Me.btnReporte7.BackColor = System.Drawing.Color.White
        Me.btnReporte7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnReporte7.Image = CType(resources.GetObject("btnReporte7.Image"), System.Drawing.Image)
        Me.btnReporte7.Location = New System.Drawing.Point(513, 325)
        Me.btnReporte7.Name = "btnReporte7"
        Me.btnReporte7.Size = New System.Drawing.Size(249, 317)
        Me.btnReporte7.TabIndex = 6
        Me.btnReporte7.Tag = "Reporte7"
        Me.btnReporte7.Text = "Reporte Cobranza"
        Me.btnReporte7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte7.UseVisualStyleBackColor = False
        '
        'btnReporte4
        '
        Me.btnReporte4.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReporte4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte4.Image = CType(resources.GetObject("btnReporte4.Image"), System.Drawing.Image)
        Me.btnReporte4.Location = New System.Drawing.Point(768, 3)
        Me.btnReporte4.Name = "btnReporte4"
        Me.btnReporte4.Size = New System.Drawing.Size(251, 316)
        Me.btnReporte4.TabIndex = 5
        Me.btnReporte4.Tag = "Reporte4"
        Me.btnReporte4.Text = "&Stock Valorizado"
        Me.btnReporte4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte4.UseVisualStyleBackColor = False
        '
        'btnReporte6
        '
        Me.btnReporte6.BackColor = System.Drawing.Color.Pink
        Me.btnReporte6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte6.Image = CType(resources.GetObject("btnReporte6.Image"), System.Drawing.Image)
        Me.btnReporte6.Location = New System.Drawing.Point(258, 325)
        Me.btnReporte6.Name = "btnReporte6"
        Me.btnReporte6.Size = New System.Drawing.Size(249, 317)
        Me.btnReporte6.TabIndex = 3
        Me.btnReporte6.Tag = "Reporte6"
        Me.btnReporte6.Text = "&Pendiente por Cliente"
        Me.btnReporte6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte6.UseVisualStyleBackColor = False
        '
        'btnReporte5
        '
        Me.btnReporte5.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnReporte5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReporte5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReporte5.Image = CType(resources.GetObject("btnReporte5.Image"), System.Drawing.Image)
        Me.btnReporte5.Location = New System.Drawing.Point(3, 325)
        Me.btnReporte5.Name = "btnReporte5"
        Me.btnReporte5.Size = New System.Drawing.Size(249, 317)
        Me.btnReporte5.TabIndex = 2
        Me.btnReporte5.Tag = "Reporte5"
        Me.btnReporte5.Text = "Reporte por Producto"
        Me.btnReporte5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte5.UseVisualStyleBackColor = False
        '
        'btnReporte2
        '
        Me.btnReporte2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReporte2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReporte2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte2.Image = CType(resources.GetObject("btnReporte2.Image"), System.Drawing.Image)
        Me.btnReporte2.Location = New System.Drawing.Point(258, 3)
        Me.btnReporte2.Name = "btnReporte2"
        Me.btnReporte2.Size = New System.Drawing.Size(249, 316)
        Me.btnReporte2.TabIndex = 1
        Me.btnReporte2.Tag = "Reporte2"
        Me.btnReporte2.Text = "Reporte por Cliente"
        Me.btnReporte2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte2.UseVisualStyleBackColor = False
        '
        'btnReporte1
        '
        Me.btnReporte1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReporte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReporte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReporte1.Image = CType(resources.GetObject("btnReporte1.Image"), System.Drawing.Image)
        Me.btnReporte1.Location = New System.Drawing.Point(3, 3)
        Me.btnReporte1.Name = "btnReporte1"
        Me.btnReporte1.Size = New System.Drawing.Size(249, 316)
        Me.btnReporte1.TabIndex = 0
        Me.btnReporte1.Tag = "Reporte1"
        Me.btnReporte1.Text = "Reporte por Vendedor"
        Me.btnReporte1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte1.UseVisualStyleBackColor = False
        '
        'btnReporte3
        '
        Me.btnReporte3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReporte3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporte3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte3.Image = CType(resources.GetObject("btnReporte3.Image"), System.Drawing.Image)
        Me.btnReporte3.Location = New System.Drawing.Point(513, 3)
        Me.btnReporte3.Name = "btnReporte3"
        Me.btnReporte3.Size = New System.Drawing.Size(249, 316)
        Me.btnReporte3.TabIndex = 4
        Me.btnReporte3.Tag = "Reporte3"
        Me.btnReporte3.Text = "&Ventas por dia"
        Me.btnReporte3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte3.UseVisualStyleBackColor = False
        '
        'FrmRepGerenciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 664)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRepGerenciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmRepGerenciales"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReporte6 As System.Windows.Forms.Button
    Friend WithEvents btnReporte5 As System.Windows.Forms.Button
    Friend WithEvents btnReporte2 As System.Windows.Forms.Button
    Friend WithEvents btnReporte1 As System.Windows.Forms.Button
    Friend WithEvents btnReporte3 As System.Windows.Forms.Button
    Friend WithEvents btnReporte8 As System.Windows.Forms.Button
    Friend WithEvents btnReporte7 As System.Windows.Forms.Button
    Friend WithEvents btnReporte4 As System.Windows.Forms.Button
End Class
