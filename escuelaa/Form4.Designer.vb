<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cargar_calificaciones
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_calificaciones_aceptar = New System.Windows.Forms.Button()
        Me.bt_calificaciones_cancelar = New System.Windows.Forms.Button()
        Me.cmb_calificaciones_buscar_curso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_calificaciones_bscar_materia = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_calificaciones_buscar_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_calificaciones_buscar = New System.Windows.Forms.Button()
        Me.bt_calificaciones_imprimir = New System.Windows.Forms.Button()
        Me.bt_calificaciones_salir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CARGAR CALIFICACIONES"
        '
        'bt_calificaciones_aceptar
        '
        Me.bt_calificaciones_aceptar.AutoSize = True
        Me.bt_calificaciones_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_calificaciones_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_calificaciones_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar11
        Me.bt_calificaciones_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_calificaciones_aceptar.Location = New System.Drawing.Point(389, 616)
        Me.bt_calificaciones_aceptar.Name = "bt_calificaciones_aceptar"
        Me.bt_calificaciones_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_calificaciones_aceptar.TabIndex = 30
        Me.bt_calificaciones_aceptar.Text = "ACEPTAR"
        Me.bt_calificaciones_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_calificaciones_aceptar.UseVisualStyleBackColor = False
        '
        'bt_calificaciones_cancelar
        '
        Me.bt_calificaciones_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_calificaciones_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_calificaciones_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar1
        Me.bt_calificaciones_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_calificaciones_cancelar.Location = New System.Drawing.Point(242, 616)
        Me.bt_calificaciones_cancelar.Name = "bt_calificaciones_cancelar"
        Me.bt_calificaciones_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_calificaciones_cancelar.TabIndex = 29
        Me.bt_calificaciones_cancelar.Text = "CANCELAR"
        Me.bt_calificaciones_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_calificaciones_cancelar.UseVisualStyleBackColor = False
        '
        'cmb_calificaciones_buscar_curso
        '
        Me.cmb_calificaciones_buscar_curso.DisplayMember = "Seleccionar uno..."
        Me.cmb_calificaciones_buscar_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_calificaciones_buscar_curso.FormattingEnabled = True
        Me.cmb_calificaciones_buscar_curso.Location = New System.Drawing.Point(87, 24)
        Me.cmb_calificaciones_buscar_curso.Name = "cmb_calificaciones_buscar_curso"
        Me.cmb_calificaciones_buscar_curso.Size = New System.Drawing.Size(96, 26)
        Me.cmb_calificaciones_buscar_curso.TabIndex = 0
        Me.cmb_calificaciones_buscar_curso.ValueMember = "Seleccionar uno..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Curso: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Materia: "
        '
        'cmb_calificaciones_bscar_materia
        '
        Me.cmb_calificaciones_bscar_materia.DisplayMember = "Seleccionar una..."
        Me.cmb_calificaciones_bscar_materia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_calificaciones_bscar_materia.FormattingEnabled = True
        Me.cmb_calificaciones_bscar_materia.Location = New System.Drawing.Point(267, 24)
        Me.cmb_calificaciones_bscar_materia.Name = "cmb_calificaciones_bscar_materia"
        Me.cmb_calificaciones_bscar_materia.Size = New System.Drawing.Size(182, 26)
        Me.cmb_calificaciones_bscar_materia.TabIndex = 22
        Me.cmb_calificaciones_bscar_materia.ValueMember = "Seleccionar una..."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtp_calificaciones_buscar_fecha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.bt_calificaciones_buscar)
        Me.Panel1.Controls.Add(Me.cmb_calificaciones_buscar_curso)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_calificaciones_bscar_materia)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(28, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 546)
        Me.Panel1.TabIndex = 21
        '
        'dtp_calificaciones_buscar_fecha
        '
        Me.dtp_calificaciones_buscar_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_calificaciones_buscar_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_calificaciones_buscar_fecha.Location = New System.Drawing.Point(528, 25)
        Me.dtp_calificaciones_buscar_fecha.Name = "dtp_calificaciones_buscar_fecha"
        Me.dtp_calificaciones_buscar_fecha.Size = New System.Drawing.Size(120, 26)
        Me.dtp_calificaciones_buscar_fecha.TabIndex = 31
        Me.dtp_calificaciones_buscar_fecha.Value = New Date(2017, 8, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Fecha: "
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(690, 457)
        Me.DataGridView1.TabIndex = 32
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
        Me.Column4.HeaderText = "N.1"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 30
        '
        'Column5
        '
        Me.Column5.HeaderText = "N.2"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 30
        '
        'Column6
        '
        Me.Column6.HeaderText = "N.3"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 30
        '
        'Column7
        '
        Me.Column7.HeaderText = "N.4"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 30
        '
        'Column8
        '
        Me.Column8.HeaderText = "N.5"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 30
        '
        'Column9
        '
        Me.Column9.HeaderText = "N.6"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 30
        '
        'Column10
        '
        Me.Column10.HeaderText = "N.7"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 30
        '
        'Column11
        '
        Me.Column11.HeaderText = "N.8"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 30
        '
        'bt_calificaciones_buscar
        '
        Me.bt_calificaciones_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_calificaciones_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_calificaciones_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_calificaciones_buscar.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_calificaciones_buscar.Location = New System.Drawing.Point(661, 16)
        Me.bt_calificaciones_buscar.Name = "bt_calificaciones_buscar"
        Me.bt_calificaciones_buscar.Size = New System.Drawing.Size(40, 42)
        Me.bt_calificaciones_buscar.TabIndex = 33
        Me.bt_calificaciones_buscar.UseVisualStyleBackColor = False
        '
        'bt_calificaciones_imprimir
        '
        Me.bt_calificaciones_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_calificaciones_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_calificaciones_imprimir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_calificaciones_imprimir.Image = Global.escuelaa.My.Resources.Resources.impresora
        Me.bt_calificaciones_imprimir.Location = New System.Drawing.Point(721, 19)
        Me.bt_calificaciones_imprimir.Name = "bt_calificaciones_imprimir"
        Me.bt_calificaciones_imprimir.Size = New System.Drawing.Size(38, 39)
        Me.bt_calificaciones_imprimir.TabIndex = 31
        Me.bt_calificaciones_imprimir.UseVisualStyleBackColor = False
        '
        'bt_calificaciones_salir
        '
        Me.bt_calificaciones_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_calificaciones_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_calificaciones_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_calificaciones_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_calificaciones_salir.Location = New System.Drawing.Point(28, 16)
        Me.bt_calificaciones_salir.Name = "bt_calificaciones_salir"
        Me.bt_calificaciones_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_calificaciones_salir.TabIndex = 32
        Me.bt_calificaciones_salir.UseVisualStyleBackColor = False
        '
        'frm_cargar_calificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_calificaciones_salir)
        Me.Controls.Add(Me.bt_calificaciones_imprimir)
        Me.Controls.Add(Me.bt_calificaciones_aceptar)
        Me.Controls.Add(Me.bt_calificaciones_cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_cargar_calificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_calificaciones_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_calificaciones_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_calificaciones_buscar_curso As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_calificaciones_bscar_materia As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bt_calificaciones_buscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_calificaciones_buscar_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_calificaciones_imprimir As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_calificaciones_salir As System.Windows.Forms.Button
End Class
