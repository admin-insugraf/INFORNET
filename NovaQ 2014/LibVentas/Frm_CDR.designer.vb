<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CDR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CDR))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_Recepcion = New System.Windows.Forms.TextBox()
        Me.txt_Fecha_recepcion = New System.Windows.Forms.TextBox()
        Me.txt_hora_recepcion = New System.Windows.Forms.TextBox()
        Me.txt_fecha_generacion = New System.Windows.Forms.TextBox()
        Me.txt_hora_generacion = New System.Windows.Forms.TextBox()
        Me.txt_ruc_receptor = New System.Windows.Forms.TextBox()
        Me.txt_documento_electronico = New System.Windows.Forms.TextBox()
        Me.txt_ruc_emisor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_respuesta_sunat = New System.Windows.Forms.TextBox()
        Me.txt_id_Receptor = New System.Windows.Forms.TextBox()
        Me.txt_num_doc = New System.Windows.Forms.TextBox()
        Me.txt_Serie_doc = New System.Windows.Forms.TextBox()
        Me.txt_tipo_doc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_verifica_estado_manual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONSTANCIA DE RECEPCION (CDR)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Recepción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Recepción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora Recepción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(290, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora Generación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha Generación"
        '
        'txt_id_Recepcion
        '
        Me.txt_id_Recepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id_Recepcion.Location = New System.Drawing.Point(140, 53)
        Me.txt_id_Recepcion.Name = "txt_id_Recepcion"
        Me.txt_id_Recepcion.ReadOnly = True
        Me.txt_id_Recepcion.Size = New System.Drawing.Size(139, 20)
        Me.txt_id_Recepcion.TabIndex = 6
        '
        'txt_Fecha_recepcion
        '
        Me.txt_Fecha_recepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Fecha_recepcion.Location = New System.Drawing.Point(140, 78)
        Me.txt_Fecha_recepcion.Name = "txt_Fecha_recepcion"
        Me.txt_Fecha_recepcion.ReadOnly = True
        Me.txt_Fecha_recepcion.Size = New System.Drawing.Size(139, 20)
        Me.txt_Fecha_recepcion.TabIndex = 7
        '
        'txt_hora_recepcion
        '
        Me.txt_hora_recepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hora_recepcion.Location = New System.Drawing.Point(140, 104)
        Me.txt_hora_recepcion.Name = "txt_hora_recepcion"
        Me.txt_hora_recepcion.ReadOnly = True
        Me.txt_hora_recepcion.Size = New System.Drawing.Size(139, 20)
        Me.txt_hora_recepcion.TabIndex = 8
        '
        'txt_fecha_generacion
        '
        Me.txt_fecha_generacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha_generacion.Location = New System.Drawing.Point(423, 78)
        Me.txt_fecha_generacion.Name = "txt_fecha_generacion"
        Me.txt_fecha_generacion.ReadOnly = True
        Me.txt_fecha_generacion.Size = New System.Drawing.Size(139, 20)
        Me.txt_fecha_generacion.TabIndex = 9
        '
        'txt_hora_generacion
        '
        Me.txt_hora_generacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hora_generacion.Location = New System.Drawing.Point(423, 104)
        Me.txt_hora_generacion.Name = "txt_hora_generacion"
        Me.txt_hora_generacion.ReadOnly = True
        Me.txt_hora_generacion.Size = New System.Drawing.Size(139, 20)
        Me.txt_hora_generacion.TabIndex = 10
        '
        'txt_ruc_receptor
        '
        Me.txt_ruc_receptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_receptor.Location = New System.Drawing.Point(423, 155)
        Me.txt_ruc_receptor.Name = "txt_ruc_receptor"
        Me.txt_ruc_receptor.ReadOnly = True
        Me.txt_ruc_receptor.Size = New System.Drawing.Size(139, 20)
        Me.txt_ruc_receptor.TabIndex = 16
        '
        'txt_documento_electronico
        '
        Me.txt_documento_electronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_documento_electronico.Location = New System.Drawing.Point(173, 182)
        Me.txt_documento_electronico.Name = "txt_documento_electronico"
        Me.txt_documento_electronico.ReadOnly = True
        Me.txt_documento_electronico.Size = New System.Drawing.Size(139, 20)
        Me.txt_documento_electronico.TabIndex = 15
        '
        'txt_ruc_emisor
        '
        Me.txt_ruc_emisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_emisor.Location = New System.Drawing.Point(140, 155)
        Me.txt_ruc_emisor.Name = "txt_ruc_emisor"
        Me.txt_ruc_emisor.ReadOnly = True
        Me.txt_ruc_emisor.Size = New System.Drawing.Size(139, 20)
        Me.txt_ruc_emisor.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(290, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "RUC Receptor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Documento Electronico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "RUC Emisor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Respuesta SUNAT"
        '
        'txt_respuesta_sunat
        '
        Me.txt_respuesta_sunat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_respuesta_sunat.Location = New System.Drawing.Point(15, 247)
        Me.txt_respuesta_sunat.Multiline = True
        Me.txt_respuesta_sunat.Name = "txt_respuesta_sunat"
        Me.txt_respuesta_sunat.ReadOnly = True
        Me.txt_respuesta_sunat.Size = New System.Drawing.Size(547, 87)
        Me.txt_respuesta_sunat.TabIndex = 18
        '
        'txt_id_Receptor
        '
        Me.txt_id_Receptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id_Receptor.Location = New System.Drawing.Point(423, 344)
        Me.txt_id_Receptor.Name = "txt_id_Receptor"
        Me.txt_id_Receptor.ReadOnly = True
        Me.txt_id_Receptor.Size = New System.Drawing.Size(139, 20)
        Me.txt_id_Receptor.TabIndex = 26
        '
        'txt_num_doc
        '
        Me.txt_num_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_doc.Location = New System.Drawing.Point(140, 395)
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.ReadOnly = True
        Me.txt_num_doc.Size = New System.Drawing.Size(139, 20)
        Me.txt_num_doc.TabIndex = 25
        '
        'txt_Serie_doc
        '
        Me.txt_Serie_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Serie_doc.Location = New System.Drawing.Point(140, 369)
        Me.txt_Serie_doc.Name = "txt_Serie_doc"
        Me.txt_Serie_doc.ReadOnly = True
        Me.txt_Serie_doc.Size = New System.Drawing.Size(139, 20)
        Me.txt_Serie_doc.TabIndex = 24
        '
        'txt_tipo_doc
        '
        Me.txt_tipo_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipo_doc.Location = New System.Drawing.Point(140, 344)
        Me.txt_tipo_doc.Name = "txt_tipo_doc"
        Me.txt_tipo_doc.ReadOnly = True
        Me.txt_tipo_doc.Size = New System.Drawing.Size(139, 20)
        Me.txt_tipo_doc.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(290, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ID Receptor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "N° Documento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 372)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 15)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Serie Documento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 347)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Tipo Documento"
        '
        'btn_verifica_estado_manual
        '
        Me.btn_verifica_estado_manual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_verifica_estado_manual.BackColor = System.Drawing.Color.LightGray
        Me.btn_verifica_estado_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verifica_estado_manual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verifica_estado_manual.Image = CType(resources.GetObject("btn_verifica_estado_manual.Image"), System.Drawing.Image)
        Me.btn_verifica_estado_manual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_verifica_estado_manual.Location = New System.Drawing.Point(423, 374)
        Me.btn_verifica_estado_manual.Name = "btn_verifica_estado_manual"
        Me.btn_verifica_estado_manual.Size = New System.Drawing.Size(142, 43)
        Me.btn_verifica_estado_manual.TabIndex = 183
        Me.btn_verifica_estado_manual.Text = "CERRA VENTANA"
        Me.btn_verifica_estado_manual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_verifica_estado_manual.UseVisualStyleBackColor = False
        '
        'Frm_CDR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 429)
        Me.Controls.Add(Me.btn_verifica_estado_manual)
        Me.Controls.Add(Me.txt_id_Receptor)
        Me.Controls.Add(Me.txt_num_doc)
        Me.Controls.Add(Me.txt_Serie_doc)
        Me.Controls.Add(Me.txt_tipo_doc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_respuesta_sunat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_ruc_receptor)
        Me.Controls.Add(Me.txt_documento_electronico)
        Me.Controls.Add(Me.txt_ruc_emisor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_hora_generacion)
        Me.Controls.Add(Me.txt_fecha_generacion)
        Me.Controls.Add(Me.txt_hora_recepcion)
        Me.Controls.Add(Me.txt_Fecha_recepcion)
        Me.Controls.Add(Me.txt_id_Recepcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_CDR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de constancia de recepción (CDR)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id_Recepcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Fecha_recepcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora_recepcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_generacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora_generacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_ruc_receptor As System.Windows.Forms.TextBox
    Friend WithEvents txt_documento_electronico As System.Windows.Forms.TextBox
    Friend WithEvents txt_ruc_emisor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_respuesta_sunat As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Receptor As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Serie_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_verifica_estado_manual As System.Windows.Forms.Button
End Class
