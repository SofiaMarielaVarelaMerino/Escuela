<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alumnos_nuevo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmb_alumno_nuevo_division = New System.Windows.Forms.ComboBox()
        Me.cmb_alumno_nuevo_nivel = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_alumno_nuevo_tutor_tel = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_tutor_num_doc = New System.Windows.Forms.TextBox()
        Me.cmb_alumno_nuevo_tutor_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_tutor_nombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_tutor_apellido = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_alumno_nuevo_estado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_alumno_nuevo_fecha_nac = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_legajo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_apellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pl_alumno_nuevo_amonestaciones = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_alumno_nuevo_amonestaciones_descripcion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_alumno_nuevo_amonestaciones_cantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtp_alumno_nuevo_amonestaciones_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_alumno_nuevo_cuota = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_inscripcion = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_amonestaciones_eliminar = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_amonestaciones_nueva = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_amonestaciones_aceptar = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_amonestaciones_cancelar = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_aceptar = New System.Windows.Forms.Button()
        Me.bt_alumno_nuevo_cancelar = New System.Windows.Forms.Button()
        Me.bt_alumnos_nuevo_salir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pl_alumno_nuevo_amonestaciones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cmb_alumno_nuevo_estado)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dtp_alumno_nuevo_fecha_nac)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_alumno_nuevo_legajo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_alumno_nuevo_nombre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_alumno_nuevo_apellido)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(29, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 499)
        Me.Panel1.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(37, 350)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "En Curso:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.cmb_alumno_nuevo_division)
        Me.Panel4.Controls.Add(Me.cmb_alumno_nuevo_nivel)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(38, 375)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(579, 87)
        Me.Panel4.TabIndex = 41
        '
        'cmb_alumno_nuevo_division
        '
        Me.cmb_alumno_nuevo_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_alumno_nuevo_division.FormattingEnabled = True
        Me.cmb_alumno_nuevo_division.Location = New System.Drawing.Point(359, 33)
        Me.cmb_alumno_nuevo_division.Name = "cmb_alumno_nuevo_division"
        Me.cmb_alumno_nuevo_division.Size = New System.Drawing.Size(202, 26)
        Me.cmb_alumno_nuevo_division.TabIndex = 31
        '
        'cmb_alumno_nuevo_nivel
        '
        Me.cmb_alumno_nuevo_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_alumno_nuevo_nivel.FormattingEnabled = True
        Me.cmb_alumno_nuevo_nivel.Location = New System.Drawing.Point(75, 34)
        Me.cmb_alumno_nuevo_nivel.Name = "cmb_alumno_nuevo_nivel"
        Me.cmb_alumno_nuevo_nivel.Size = New System.Drawing.Size(202, 26)
        Me.cmb_alumno_nuevo_nivel.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Nivel:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(294, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 16)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "División:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Tutor:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txt_alumno_nuevo_tutor_tel)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.txt_alumno_nuevo_tutor_num_doc)
        Me.Panel3.Controls.Add(Me.cmb_alumno_nuevo_tutor_tipo_doc)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_alumno_nuevo_tutor_nombre)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txt_alumno_nuevo_tutor_apellido)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Location = New System.Drawing.Point(38, 176)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(579, 152)
        Me.Panel3.TabIndex = 30
        '
        'txt_alumno_nuevo_tutor_tel
        '
        Me.txt_alumno_nuevo_tutor_tel.CausesValidation = False
        Me.txt_alumno_nuevo_tutor_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_tutor_tel.Location = New System.Drawing.Point(74, 107)
        Me.txt_alumno_nuevo_tutor_tel.Name = "txt_alumno_nuevo_tutor_tel"
        Me.txt_alumno_nuevo_tutor_tel.Size = New System.Drawing.Size(202, 24)
        Me.txt_alumno_nuevo_tutor_tel.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 16)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Telefono:"
        '
        'txt_alumno_nuevo_tutor_num_doc
        '
        Me.txt_alumno_nuevo_tutor_num_doc.CausesValidation = False
        Me.txt_alumno_nuevo_tutor_num_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_tutor_num_doc.Location = New System.Drawing.Point(413, 65)
        Me.txt_alumno_nuevo_tutor_num_doc.Name = "txt_alumno_nuevo_tutor_num_doc"
        Me.txt_alumno_nuevo_tutor_num_doc.Size = New System.Drawing.Size(147, 24)
        Me.txt_alumno_nuevo_tutor_num_doc.TabIndex = 38
        '
        'cmb_alumno_nuevo_tutor_tipo_doc
        '
        Me.cmb_alumno_nuevo_tutor_tipo_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_alumno_nuevo_tutor_tipo_doc.FormattingEnabled = True
        Me.cmb_alumno_nuevo_tutor_tipo_doc.Location = New System.Drawing.Point(123, 65)
        Me.cmb_alumno_nuevo_tutor_tipo_doc.Name = "cmb_alumno_nuevo_tutor_tipo_doc"
        Me.cmb_alumno_nuevo_tutor_tipo_doc.Size = New System.Drawing.Size(153, 26)
        Me.cmb_alumno_nuevo_tutor_tipo_doc.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Num Documento: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Tipo Documento:"
        '
        'txt_alumno_nuevo_tutor_nombre
        '
        Me.txt_alumno_nuevo_tutor_nombre.CausesValidation = False
        Me.txt_alumno_nuevo_tutor_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_tutor_nombre.Location = New System.Drawing.Point(358, 25)
        Me.txt_alumno_nuevo_tutor_nombre.Name = "txt_alumno_nuevo_tutor_nombre"
        Me.txt_alumno_nuevo_tutor_nombre.Size = New System.Drawing.Size(202, 24)
        Me.txt_alumno_nuevo_tutor_nombre.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(293, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Nombre: "
        '
        'txt_alumno_nuevo_tutor_apellido
        '
        Me.txt_alumno_nuevo_tutor_apellido.CausesValidation = False
        Me.txt_alumno_nuevo_tutor_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_tutor_apellido.Location = New System.Drawing.Point(74, 25)
        Me.txt_alumno_nuevo_tutor_apellido.Name = "txt_alumno_nuevo_tutor_apellido"
        Me.txt_alumno_nuevo_tutor_apellido.Size = New System.Drawing.Size(202, 24)
        Me.txt_alumno_nuevo_tutor_apellido.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Apellido: "
        '
        'cmb_alumno_nuevo_estado
        '
        Me.cmb_alumno_nuevo_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_alumno_nuevo_estado.FormattingEnabled = True
        Me.cmb_alumno_nuevo_estado.Location = New System.Drawing.Point(413, 106)
        Me.cmb_alumno_nuevo_estado.Name = "cmb_alumno_nuevo_estado"
        Me.cmb_alumno_nuevo_estado.Size = New System.Drawing.Size(202, 26)
        Me.cmb_alumno_nuevo_estado.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(348, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Estado: "
        '
        'dtp_alumno_nuevo_fecha_nac
        '
        Me.dtp_alumno_nuevo_fecha_nac.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_alumno_nuevo_fecha_nac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_alumno_nuevo_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_alumno_nuevo_fecha_nac.Location = New System.Drawing.Point(193, 108)
        Me.dtp_alumno_nuevo_fecha_nac.Name = "dtp_alumno_nuevo_fecha_nac"
        Me.dtp_alumno_nuevo_fecha_nac.Size = New System.Drawing.Size(123, 24)
        Me.dtp_alumno_nuevo_fecha_nac.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Fecha de Nacimiento:"
        '
        'txt_alumno_nuevo_legajo
        '
        Me.txt_alumno_nuevo_legajo.CausesValidation = False
        Me.txt_alumno_nuevo_legajo.Enabled = False
        Me.txt_alumno_nuevo_legajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_legajo.Location = New System.Drawing.Point(114, 25)
        Me.txt_alumno_nuevo_legajo.Name = "txt_alumno_nuevo_legajo"
        Me.txt_alumno_nuevo_legajo.Size = New System.Drawing.Size(202, 24)
        Me.txt_alumno_nuevo_legajo.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Legajo:"
        '
        'txt_alumno_nuevo_nombre
        '
        Me.txt_alumno_nuevo_nombre.CausesValidation = False
        Me.txt_alumno_nuevo_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_nombre.Location = New System.Drawing.Point(413, 65)
        Me.txt_alumno_nuevo_nombre.Name = "txt_alumno_nuevo_nombre"
        Me.txt_alumno_nuevo_nombre.Size = New System.Drawing.Size(202, 24)
        Me.txt_alumno_nuevo_nombre.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(348, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nombre: "
        '
        'txt_alumno_nuevo_apellido
        '
        Me.txt_alumno_nuevo_apellido.CausesValidation = False
        Me.txt_alumno_nuevo_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_apellido.Location = New System.Drawing.Point(114, 67)
        Me.txt_alumno_nuevo_apellido.Name = "txt_alumno_nuevo_apellido"
        Me.txt_alumno_nuevo_apellido.Size = New System.Drawing.Size(202, 24)
        Me.txt_alumno_nuevo_apellido.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Apellido: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 33)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ALUMNO"
        '
        'pl_alumno_nuevo_amonestaciones
        '
        Me.pl_alumno_nuevo_amonestaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.bt_alumno_nuevo_amonestaciones_aceptar)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.bt_alumno_nuevo_amonestaciones_cancelar)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.DataGridView1)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.txt_alumno_nuevo_amonestaciones_descripcion)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.Label12)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.Label13)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.txt_alumno_nuevo_amonestaciones_cantidad)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.Label11)
        Me.pl_alumno_nuevo_amonestaciones.Controls.Add(Me.dtp_alumno_nuevo_amonestaciones_fecha)
        Me.pl_alumno_nuevo_amonestaciones.Enabled = False
        Me.pl_alumno_nuevo_amonestaciones.Location = New System.Drawing.Point(709, 104)
        Me.pl_alumno_nuevo_amonestaciones.Name = "pl_alumno_nuevo_amonestaciones"
        Me.pl_alumno_nuevo_amonestaciones.Size = New System.Drawing.Size(599, 303)
        Me.pl_alumno_nuevo_amonestaciones.TabIndex = 35
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(41, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(520, 163)
        Me.DataGridView1.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "Legajo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descripción"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 170
        '
        'txt_alumno_nuevo_amonestaciones_descripcion
        '
        Me.txt_alumno_nuevo_amonestaciones_descripcion.CausesValidation = False
        Me.txt_alumno_nuevo_amonestaciones_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_amonestaciones_descripcion.Location = New System.Drawing.Point(143, 45)
        Me.txt_alumno_nuevo_amonestaciones_descripcion.Name = "txt_alumno_nuevo_amonestaciones_descripcion"
        Me.txt_alumno_nuevo_amonestaciones_descripcion.Size = New System.Drawing.Size(401, 24)
        Me.txt_alumno_nuevo_amonestaciones_descripcion.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(323, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Cantidad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(58, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Descripción:"
        '
        'txt_alumno_nuevo_amonestaciones_cantidad
        '
        Me.txt_alumno_nuevo_amonestaciones_cantidad.CausesValidation = False
        Me.txt_alumno_nuevo_amonestaciones_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumno_nuevo_amonestaciones_cantidad.Location = New System.Drawing.Point(391, 10)
        Me.txt_alumno_nuevo_amonestaciones_cantidad.Name = "txt_alumno_nuevo_amonestaciones_cantidad"
        Me.txt_alumno_nuevo_amonestaciones_cantidad.Size = New System.Drawing.Size(153, 24)
        Me.txt_alumno_nuevo_amonestaciones_cantidad.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(58, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Fecha:"
        '
        'dtp_alumno_nuevo_amonestaciones_fecha
        '
        Me.dtp_alumno_nuevo_amonestaciones_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_alumno_nuevo_amonestaciones_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_alumno_nuevo_amonestaciones_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_alumno_nuevo_amonestaciones_fecha.Location = New System.Drawing.Point(143, 10)
        Me.dtp_alumno_nuevo_amonestaciones_fecha.Name = "dtp_alumno_nuevo_amonestaciones_fecha"
        Me.dtp_alumno_nuevo_amonestaciones_fecha.Size = New System.Drawing.Size(123, 24)
        Me.dtp_alumno_nuevo_amonestaciones_fecha.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(708, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Amonestaciones:"
        '
        'bt_alumno_nuevo_cuota
        '
        Me.bt_alumno_nuevo_cuota.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_cuota.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumno_nuevo_cuota.Location = New System.Drawing.Point(709, 504)
        Me.bt_alumno_nuevo_cuota.Name = "bt_alumno_nuevo_cuota"
        Me.bt_alumno_nuevo_cuota.Size = New System.Drawing.Size(585, 59)
        Me.bt_alumno_nuevo_cuota.TabIndex = 45
        Me.bt_alumno_nuevo_cuota.Text = "CUOTAS"
        Me.bt_alumno_nuevo_cuota.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_inscripcion
        '
        Me.bt_alumno_nuevo_inscripcion.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_inscripcion.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumno_nuevo_inscripcion.Location = New System.Drawing.Point(711, 425)
        Me.bt_alumno_nuevo_inscripcion.Name = "bt_alumno_nuevo_inscripcion"
        Me.bt_alumno_nuevo_inscripcion.Size = New System.Drawing.Size(585, 59)
        Me.bt_alumno_nuevo_inscripcion.TabIndex = 46
        Me.bt_alumno_nuevo_inscripcion.Text = "INSCRIPCIÓN"
        Me.bt_alumno_nuevo_inscripcion.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_amonestaciones_eliminar
        '
        Me.bt_alumno_nuevo_amonestaciones_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_amonestaciones_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumno_nuevo_amonestaciones_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumno_nuevo_amonestaciones_eliminar.Image = Global.escuelaa.My.Resources.Resources.eliminar
        Me.bt_alumno_nuevo_amonestaciones_eliminar.Location = New System.Drawing.Point(1216, 59)
        Me.bt_alumno_nuevo_amonestaciones_eliminar.Name = "bt_alumno_nuevo_amonestaciones_eliminar"
        Me.bt_alumno_nuevo_amonestaciones_eliminar.Size = New System.Drawing.Size(39, 39)
        Me.bt_alumno_nuevo_amonestaciones_eliminar.TabIndex = 39
        Me.bt_alumno_nuevo_amonestaciones_eliminar.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_amonestaciones_nueva
        '
        Me.bt_alumno_nuevo_amonestaciones_nueva.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_amonestaciones_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumno_nuevo_amonestaciones_nueva.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumno_nuevo_amonestaciones_nueva.Image = Global.escuelaa.My.Resources.Resources.mas2
        Me.bt_alumno_nuevo_amonestaciones_nueva.Location = New System.Drawing.Point(1256, 57)
        Me.bt_alumno_nuevo_amonestaciones_nueva.Name = "bt_alumno_nuevo_amonestaciones_nueva"
        Me.bt_alumno_nuevo_amonestaciones_nueva.Size = New System.Drawing.Size(40, 42)
        Me.bt_alumno_nuevo_amonestaciones_nueva.TabIndex = 38
        Me.bt_alumno_nuevo_amonestaciones_nueva.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_amonestaciones_aceptar
        '
        Me.bt_alumno_nuevo_amonestaciones_aceptar.AutoSize = True
        Me.bt_alumno_nuevo_amonestaciones_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_amonestaciones_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumno_nuevo_amonestaciones_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumno_nuevo_amonestaciones_aceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_amonestaciones_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar12
        Me.bt_alumno_nuevo_amonestaciones_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_alumno_nuevo_amonestaciones_aceptar.Location = New System.Drawing.Point(541, 254)
        Me.bt_alumno_nuevo_amonestaciones_aceptar.Name = "bt_alumno_nuevo_amonestaciones_aceptar"
        Me.bt_alumno_nuevo_amonestaciones_aceptar.Size = New System.Drawing.Size(44, 40)
        Me.bt_alumno_nuevo_amonestaciones_aceptar.TabIndex = 35
        Me.bt_alumno_nuevo_amonestaciones_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_alumno_nuevo_amonestaciones_aceptar.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_amonestaciones_cancelar
        '
        Me.bt_alumno_nuevo_amonestaciones_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_amonestaciones_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumno_nuevo_amonestaciones_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumno_nuevo_amonestaciones_cancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.bt_alumno_nuevo_amonestaciones_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar2
        Me.bt_alumno_nuevo_amonestaciones_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_alumno_nuevo_amonestaciones_cancelar.Location = New System.Drawing.Point(492, 256)
        Me.bt_alumno_nuevo_amonestaciones_cancelar.Name = "bt_alumno_nuevo_amonestaciones_cancelar"
        Me.bt_alumno_nuevo_amonestaciones_cancelar.Size = New System.Drawing.Size(43, 36)
        Me.bt_alumno_nuevo_amonestaciones_cancelar.TabIndex = 34
        Me.bt_alumno_nuevo_amonestaciones_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_alumno_nuevo_amonestaciones_cancelar.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_aceptar
        '
        Me.bt_alumno_nuevo_aceptar.AutoSize = True
        Me.bt_alumno_nuevo_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_alumno_nuevo_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumno_nuevo_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar11
        Me.bt_alumno_nuevo_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_alumno_nuevo_aceptar.Location = New System.Drawing.Point(709, 598)
        Me.bt_alumno_nuevo_aceptar.Name = "bt_alumno_nuevo_aceptar"
        Me.bt_alumno_nuevo_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_alumno_nuevo_aceptar.TabIndex = 33
        Me.bt_alumno_nuevo_aceptar.Text = "ACEPTAR"
        Me.bt_alumno_nuevo_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_alumno_nuevo_aceptar.UseVisualStyleBackColor = False
        '
        'bt_alumno_nuevo_cancelar
        '
        Me.bt_alumno_nuevo_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_alumno_nuevo_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumno_nuevo_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar1
        Me.bt_alumno_nuevo_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_alumno_nuevo_cancelar.Location = New System.Drawing.Point(570, 598)
        Me.bt_alumno_nuevo_cancelar.Name = "bt_alumno_nuevo_cancelar"
        Me.bt_alumno_nuevo_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_alumno_nuevo_cancelar.TabIndex = 32
        Me.bt_alumno_nuevo_cancelar.Text = "CANCELAR"
        Me.bt_alumno_nuevo_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_alumno_nuevo_cancelar.UseVisualStyleBackColor = False
        '
        'bt_alumnos_nuevo_salir
        '
        Me.bt_alumnos_nuevo_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumnos_nuevo_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumnos_nuevo_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumnos_nuevo_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_alumnos_nuevo_salir.Location = New System.Drawing.Point(29, 16)
        Me.bt_alumnos_nuevo_salir.Name = "bt_alumnos_nuevo_salir"
        Me.bt_alumnos_nuevo_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_alumnos_nuevo_salir.TabIndex = 47
        Me.bt_alumnos_nuevo_salir.UseVisualStyleBackColor = False
        '
        'frm_alumnos_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_alumnos_nuevo_salir)
        Me.Controls.Add(Me.bt_alumno_nuevo_inscripcion)
        Me.Controls.Add(Me.bt_alumno_nuevo_cuota)
        Me.Controls.Add(Me.bt_alumno_nuevo_amonestaciones_eliminar)
        Me.Controls.Add(Me.bt_alumno_nuevo_amonestaciones_nueva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pl_alumno_nuevo_amonestaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bt_alumno_nuevo_aceptar)
        Me.Controls.Add(Me.bt_alumno_nuevo_cancelar)
        Me.Name = "frm_alumnos_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pl_alumno_nuevo_amonestaciones.ResumeLayout(False)
        Me.pl_alumno_nuevo_amonestaciones.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_alumno_nuevo_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_alumno_nuevo_aceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_legajo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pl_alumno_nuevo_amonestaciones As System.Windows.Forms.Panel
    Friend WithEvents dtp_alumno_nuevo_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_alumno_nuevo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_amonestaciones_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtp_alumno_nuevo_amonestaciones_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_amonestaciones_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents bt_alumno_nuevo_amonestaciones_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_alumno_nuevo_amonestaciones_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmb_alumno_nuevo_division As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_alumno_nuevo_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_tutor_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_tutor_num_doc As System.Windows.Forms.TextBox
    Friend WithEvents cmb_alumno_nuevo_tutor_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_tutor_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_alumno_nuevo_tutor_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents bt_alumno_nuevo_amonestaciones_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_alumno_nuevo_amonestaciones_nueva As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_alumno_nuevo_cuota As System.Windows.Forms.Button
    Friend WithEvents bt_alumno_nuevo_inscripcion As System.Windows.Forms.Button
    Friend WithEvents bt_alumnos_nuevo_salir As System.Windows.Forms.Button
End Class
