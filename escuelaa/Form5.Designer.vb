<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargar_inasistencias
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
        Me.bt_inasistencia_aceptar = New System.Windows.Forms.Button()
        Me.bt_inasistencia_cancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_insastencia_buscar_fecha = New System.Windows.Forms.DateTimePicker()
        Me.bt_inasistencia_buscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_inasistencia_imprimir = New System.Windows.Forms.Button()
        Me.bt_inasistencia_salir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_inasistencia_aceptar
        '
        Me.bt_inasistencia_aceptar.AutoSize = True
        Me.bt_inasistencia_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_inasistencia_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_inasistencia_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar11
        Me.bt_inasistencia_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_inasistencia_aceptar.Location = New System.Drawing.Point(346, 609)
        Me.bt_inasistencia_aceptar.Name = "bt_inasistencia_aceptar"
        Me.bt_inasistencia_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_inasistencia_aceptar.TabIndex = 30
        Me.bt_inasistencia_aceptar.Text = "ACEPTAR"
        Me.bt_inasistencia_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_inasistencia_aceptar.UseVisualStyleBackColor = False
        '
        'bt_inasistencia_cancelar
        '
        Me.bt_inasistencia_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_inasistencia_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_inasistencia_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar1
        Me.bt_inasistencia_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_inasistencia_cancelar.Location = New System.Drawing.Point(199, 609)
        Me.bt_inasistencia_cancelar.Name = "bt_inasistencia_cancelar"
        Me.bt_inasistencia_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_inasistencia_cancelar.TabIndex = 29
        Me.bt_inasistencia_cancelar.Text = "CANCELAR"
        Me.bt_inasistencia_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_inasistencia_cancelar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(551, 451)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Legajo Alumno"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido Alumno"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre Alumno"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Inasistencia"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 33)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CARGAR INASISTENCIA"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtp_insastencia_buscar_fecha)
        Me.Panel1.Controls.Add(Me.bt_inasistencia_buscar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(28, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 539)
        Me.Panel1.TabIndex = 25
        '
        'dtp_insastencia_buscar_fecha
        '
        Me.dtp_insastencia_buscar_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_insastencia_buscar_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_insastencia_buscar_fecha.Location = New System.Drawing.Point(214, 20)
        Me.dtp_insastencia_buscar_fecha.Name = "dtp_insastencia_buscar_fecha"
        Me.dtp_insastencia_buscar_fecha.Size = New System.Drawing.Size(204, 26)
        Me.dtp_insastencia_buscar_fecha.TabIndex = 26
        Me.dtp_insastencia_buscar_fecha.Value = New Date(2017, 8, 31, 0, 0, 0, 0)
        '
        'bt_inasistencia_buscar
        '
        Me.bt_inasistencia_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inasistencia_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inasistencia_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inasistencia_buscar.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_inasistencia_buscar.Location = New System.Drawing.Point(435, 10)
        Me.bt_inasistencia_buscar.Name = "bt_inasistencia_buscar"
        Me.bt_inasistencia_buscar.Size = New System.Drawing.Size(40, 42)
        Me.bt_inasistencia_buscar.TabIndex = 6
        Me.bt_inasistencia_buscar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Fecha: "
        '
        'bt_inasistencia_imprimir
        '
        Me.bt_inasistencia_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inasistencia_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inasistencia_imprimir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inasistencia_imprimir.Image = Global.escuelaa.My.Resources.Resources.impresora
        Me.bt_inasistencia_imprimir.Location = New System.Drawing.Point(590, 21)
        Me.bt_inasistencia_imprimir.Name = "bt_inasistencia_imprimir"
        Me.bt_inasistencia_imprimir.Size = New System.Drawing.Size(38, 39)
        Me.bt_inasistencia_imprimir.TabIndex = 29
        Me.bt_inasistencia_imprimir.UseVisualStyleBackColor = False
        '
        'bt_inasistencia_salir
        '
        Me.bt_inasistencia_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inasistencia_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inasistencia_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inasistencia_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_inasistencia_salir.Location = New System.Drawing.Point(28, 19)
        Me.bt_inasistencia_salir.Name = "bt_inasistencia_salir"
        Me.bt_inasistencia_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_inasistencia_salir.TabIndex = 31
        Me.bt_inasistencia_salir.UseVisualStyleBackColor = False
        '
        'frm_cargar_inasistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_inasistencia_salir)
        Me.Controls.Add(Me.bt_inasistencia_imprimir)
        Me.Controls.Add(Me.bt_inasistencia_aceptar)
        Me.Controls.Add(Me.bt_inasistencia_cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_cargar_inasistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_inasistencia_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_inasistencia_cancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtp_insastencia_buscar_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_inasistencia_buscar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bt_inasistencia_imprimir As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bt_inasistencia_salir As System.Windows.Forms.Button
End Class
