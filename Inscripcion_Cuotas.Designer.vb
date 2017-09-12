<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alumnos_inscripcion_cuotas
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
        Me.pl_inscripcion = New System.Windows.Forms.Panel()
        Me.txt_inscripcion_buscar_legajo_a = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pl_inscripcion_nueva = New System.Windows.Forms.Panel()
        Me.cmb_inscripcion_estado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_inscripcion_monto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_inscripcion_division = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_inscripcion_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_inscripcion_nivel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_inscripcion_numero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_inscripcion_legajo_a = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pl_cuotas = New System.Windows.Forms.Panel()
        Me.txt_cuota_buscar_legajo_a = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pl_cuota_nueva = New System.Windows.Forms.Panel()
        Me.dtp_cuota_fecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_cuota_estado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cuota_monto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtp_cuota_fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.txt_cuota_numero = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cuota_legajo_a = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_cuota_eliminar = New System.Windows.Forms.Button()
        Me.bt_cuota_nueva = New System.Windows.Forms.Button()
        Me.bt_inscripcion_eliminar = New System.Windows.Forms.Button()
        Me.bt_inscripcion_nueva = New System.Windows.Forms.Button()
        Me.bt_cuota_buscar_legajo_a = New System.Windows.Forms.Button()
        Me.bt_cuota_aceptar = New System.Windows.Forms.Button()
        Me.bt_cuota_cancelar = New System.Windows.Forms.Button()
        Me.bt_inscripcion_buscar_legajo_a = New System.Windows.Forms.Button()
        Me.bt_inscripcion_aceptar = New System.Windows.Forms.Button()
        Me.bt_inscripcion_cancelar = New System.Windows.Forms.Button()
        Me.bt_inscripcion_salir = New System.Windows.Forms.Button()
        Me.pl_inscripcion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_inscripcion_nueva.SuspendLayout()
        Me.pl_cuotas.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_cuota_nueva.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INSCRIPCIÓN"
        '
        'pl_inscripcion
        '
        Me.pl_inscripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_inscripcion.Controls.Add(Me.txt_inscripcion_buscar_legajo_a)
        Me.pl_inscripcion.Controls.Add(Me.Label10)
        Me.pl_inscripcion.Controls.Add(Me.bt_inscripcion_buscar_legajo_a)
        Me.pl_inscripcion.Controls.Add(Me.DataGridView1)
        Me.pl_inscripcion.Controls.Add(Me.pl_inscripcion_nueva)
        Me.pl_inscripcion.Location = New System.Drawing.Point(39, 55)
        Me.pl_inscripcion.Name = "pl_inscripcion"
        Me.pl_inscripcion.Size = New System.Drawing.Size(613, 599)
        Me.pl_inscripcion.TabIndex = 6
        '
        'txt_inscripcion_buscar_legajo_a
        '
        Me.txt_inscripcion_buscar_legajo_a.CausesValidation = False
        Me.txt_inscripcion_buscar_legajo_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inscripcion_buscar_legajo_a.Location = New System.Drawing.Point(255, 15)
        Me.txt_inscripcion_buscar_legajo_a.Name = "txt_inscripcion_buscar_legajo_a"
        Me.txt_inscripcion_buscar_legajo_a.Size = New System.Drawing.Size(189, 26)
        Me.txt_inscripcion_buscar_legajo_a.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Legajo Alumno:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(603, 266)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Legajo Alumno"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nivel"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Division"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Monto"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Estado"
        Me.Column7.Name = "Column7"
        '
        'pl_inscripcion_nueva
        '
        Me.pl_inscripcion_nueva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_inscripcion_nueva.Controls.Add(Me.bt_inscripcion_aceptar)
        Me.pl_inscripcion_nueva.Controls.Add(Me.bt_inscripcion_cancelar)
        Me.pl_inscripcion_nueva.Controls.Add(Me.cmb_inscripcion_estado)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label8)
        Me.pl_inscripcion_nueva.Controls.Add(Me.txt_inscripcion_monto)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label7)
        Me.pl_inscripcion_nueva.Controls.Add(Me.cmb_inscripcion_division)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label3)
        Me.pl_inscripcion_nueva.Controls.Add(Me.dtp_inscripcion_fecha)
        Me.pl_inscripcion_nueva.Controls.Add(Me.cmb_inscripcion_nivel)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label9)
        Me.pl_inscripcion_nueva.Controls.Add(Me.txt_inscripcion_numero)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label4)
        Me.pl_inscripcion_nueva.Controls.Add(Me.txt_inscripcion_legajo_a)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label5)
        Me.pl_inscripcion_nueva.Controls.Add(Me.Label6)
        Me.pl_inscripcion_nueva.Enabled = False
        Me.pl_inscripcion_nueva.Location = New System.Drawing.Point(4, 330)
        Me.pl_inscripcion_nueva.Name = "pl_inscripcion_nueva"
        Me.pl_inscripcion_nueva.Size = New System.Drawing.Size(603, 242)
        Me.pl_inscripcion_nueva.TabIndex = 64
        '
        'cmb_inscripcion_estado
        '
        Me.cmb_inscripcion_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_inscripcion_estado.FormattingEnabled = True
        Me.cmb_inscripcion_estado.Items.AddRange(New Object() {"Paga", "Impaga"})
        Me.cmb_inscripcion_estado.Location = New System.Drawing.Point(381, 131)
        Me.cmb_inscripcion_estado.Name = "cmb_inscripcion_estado"
        Me.cmb_inscripcion_estado.Size = New System.Drawing.Size(202, 26)
        Me.cmb_inscripcion_estado.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Estado:"
        '
        'txt_inscripcion_monto
        '
        Me.txt_inscripcion_monto.CausesValidation = False
        Me.txt_inscripcion_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inscripcion_monto.Location = New System.Drawing.Point(82, 133)
        Me.txt_inscripcion_monto.Name = "txt_inscripcion_monto"
        Me.txt_inscripcion_monto.Size = New System.Drawing.Size(202, 24)
        Me.txt_inscripcion_monto.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Monto: "
        '
        'cmb_inscripcion_division
        '
        Me.cmb_inscripcion_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_inscripcion_division.FormattingEnabled = True
        Me.cmb_inscripcion_division.Location = New System.Drawing.Point(381, 90)
        Me.cmb_inscripcion_division.Name = "cmb_inscripcion_division"
        Me.cmb_inscripcion_division.Size = New System.Drawing.Size(202, 26)
        Me.cmb_inscripcion_division.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "División:"
        '
        'dtp_inscripcion_fecha
        '
        Me.dtp_inscripcion_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inscripcion_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inscripcion_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inscripcion_fecha.Location = New System.Drawing.Point(381, 14)
        Me.dtp_inscripcion_fecha.Name = "dtp_inscripcion_fecha"
        Me.dtp_inscripcion_fecha.Size = New System.Drawing.Size(202, 24)
        Me.dtp_inscripcion_fecha.TabIndex = 69
        '
        'cmb_inscripcion_nivel
        '
        Me.cmb_inscripcion_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_inscripcion_nivel.FormattingEnabled = True
        Me.cmb_inscripcion_nivel.Location = New System.Drawing.Point(82, 91)
        Me.cmb_inscripcion_nivel.Name = "cmb_inscripcion_nivel"
        Me.cmb_inscripcion_nivel.Size = New System.Drawing.Size(202, 26)
        Me.cmb_inscripcion_nivel.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Nivel:"
        '
        'txt_inscripcion_numero
        '
        Me.txt_inscripcion_numero.CausesValidation = False
        Me.txt_inscripcion_numero.Enabled = False
        Me.txt_inscripcion_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inscripcion_numero.Location = New System.Drawing.Point(82, 14)
        Me.txt_inscripcion_numero.Name = "txt_inscripcion_numero"
        Me.txt_inscripcion_numero.Size = New System.Drawing.Size(202, 24)
        Me.txt_inscripcion_numero.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Numero:"
        '
        'txt_inscripcion_legajo_a
        '
        Me.txt_inscripcion_legajo_a.CausesValidation = False
        Me.txt_inscripcion_legajo_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inscripcion_legajo_a.Location = New System.Drawing.Point(124, 51)
        Me.txt_inscripcion_legajo_a.Name = "txt_inscripcion_legajo_a"
        Me.txt_inscripcion_legajo_a.Size = New System.Drawing.Size(160, 24)
        Me.txt_inscripcion_legajo_a.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Legajo Alumno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Fecha:"
        '
        'pl_cuotas
        '
        Me.pl_cuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_cuotas.Controls.Add(Me.txt_cuota_buscar_legajo_a)
        Me.pl_cuotas.Controls.Add(Me.Label18)
        Me.pl_cuotas.Controls.Add(Me.bt_cuota_buscar_legajo_a)
        Me.pl_cuotas.Controls.Add(Me.DataGridView2)
        Me.pl_cuotas.Controls.Add(Me.pl_cuota_nueva)
        Me.pl_cuotas.Location = New System.Drawing.Point(679, 55)
        Me.pl_cuotas.Name = "pl_cuotas"
        Me.pl_cuotas.Size = New System.Drawing.Size(609, 599)
        Me.pl_cuotas.TabIndex = 7
        '
        'txt_cuota_buscar_legajo_a
        '
        Me.txt_cuota_buscar_legajo_a.CausesValidation = False
        Me.txt_cuota_buscar_legajo_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuota_buscar_legajo_a.Location = New System.Drawing.Point(253, 18)
        Me.txt_cuota_buscar_legajo_a.Name = "txt_cuota_buscar_legajo_a"
        Me.txt_cuota_buscar_legajo_a.Size = New System.Drawing.Size(189, 26)
        Me.txt_cuota_buscar_legajo_a.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(118, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 20)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Legajo Alumno:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewComboBoxColumn1, Me.DataGridViewComboBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewComboBoxColumn3})
        Me.DataGridView2.Location = New System.Drawing.Point(1, 61)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(603, 266)
        Me.DataGridView2.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Legajo Alumno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Nivel"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.Width = 70
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.HeaderText = "Division"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewComboBoxColumn3
        '
        Me.DataGridViewComboBoxColumn3.HeaderText = "Estado"
        Me.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3"
        '
        'pl_cuota_nueva
        '
        Me.pl_cuota_nueva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_cuota_nueva.Controls.Add(Me.bt_cuota_aceptar)
        Me.pl_cuota_nueva.Controls.Add(Me.bt_cuota_cancelar)
        Me.pl_cuota_nueva.Controls.Add(Me.dtp_cuota_fecha_vencimiento)
        Me.pl_cuota_nueva.Controls.Add(Me.Label19)
        Me.pl_cuota_nueva.Controls.Add(Me.cmb_cuota_estado)
        Me.pl_cuota_nueva.Controls.Add(Me.Label11)
        Me.pl_cuota_nueva.Controls.Add(Me.txt_cuota_monto)
        Me.pl_cuota_nueva.Controls.Add(Me.Label12)
        Me.pl_cuota_nueva.Controls.Add(Me.dtp_cuota_fecha_pago)
        Me.pl_cuota_nueva.Controls.Add(Me.txt_cuota_numero)
        Me.pl_cuota_nueva.Controls.Add(Me.Label15)
        Me.pl_cuota_nueva.Controls.Add(Me.txt_cuota_legajo_a)
        Me.pl_cuota_nueva.Controls.Add(Me.Label16)
        Me.pl_cuota_nueva.Controls.Add(Me.Label17)
        Me.pl_cuota_nueva.Enabled = False
        Me.pl_cuota_nueva.Location = New System.Drawing.Point(1, 330)
        Me.pl_cuota_nueva.Name = "pl_cuota_nueva"
        Me.pl_cuota_nueva.Size = New System.Drawing.Size(601, 242)
        Me.pl_cuota_nueva.TabIndex = 86
        '
        'dtp_cuota_fecha_vencimiento
        '
        Me.dtp_cuota_fecha_vencimiento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cuota_fecha_vencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cuota_fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cuota_fecha_vencimiento.Location = New System.Drawing.Point(148, 75)
        Me.dtp_cuota_fecha_vencimiento.Name = "dtp_cuota_fecha_vencimiento"
        Me.dtp_cuota_fecha_vencimiento.Size = New System.Drawing.Size(136, 24)
        Me.dtp_cuota_fecha_vencimiento.TabIndex = 97
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 16)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "Fecha Vencimiento:"
        '
        'cmb_cuota_estado
        '
        Me.cmb_cuota_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cuota_estado.FormattingEnabled = True
        Me.cmb_cuota_estado.Items.AddRange(New Object() {"Paga", "Impaga"})
        Me.cmb_cuota_estado.Location = New System.Drawing.Point(382, 114)
        Me.cmb_cuota_estado.Name = "cmb_cuota_estado"
        Me.cmb_cuota_estado.Size = New System.Drawing.Size(202, 26)
        Me.cmb_cuota_estado.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Estado:"
        '
        'txt_cuota_monto
        '
        Me.txt_cuota_monto.CausesValidation = False
        Me.txt_cuota_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuota_monto.Location = New System.Drawing.Point(82, 114)
        Me.txt_cuota_monto.Name = "txt_cuota_monto"
        Me.txt_cuota_monto.Size = New System.Drawing.Size(202, 24)
        Me.txt_cuota_monto.TabIndex = 93
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Monto: "
        '
        'dtp_cuota_fecha_pago
        '
        Me.dtp_cuota_fecha_pago.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cuota_fecha_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_cuota_fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cuota_fecha_pago.Location = New System.Drawing.Point(423, 74)
        Me.dtp_cuota_fecha_pago.Name = "dtp_cuota_fecha_pago"
        Me.dtp_cuota_fecha_pago.Size = New System.Drawing.Size(161, 24)
        Me.dtp_cuota_fecha_pago.TabIndex = 91
        '
        'txt_cuota_numero
        '
        Me.txt_cuota_numero.CausesValidation = False
        Me.txt_cuota_numero.Enabled = False
        Me.txt_cuota_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuota_numero.Location = New System.Drawing.Point(82, 36)
        Me.txt_cuota_numero.Name = "txt_cuota_numero"
        Me.txt_cuota_numero.Size = New System.Drawing.Size(202, 24)
        Me.txt_cuota_numero.TabIndex = 90
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 16)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Numero:"
        '
        'txt_cuota_legajo_a
        '
        Me.txt_cuota_legajo_a.CausesValidation = False
        Me.txt_cuota_legajo_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuota_legajo_a.Location = New System.Drawing.Point(423, 34)
        Me.txt_cuota_legajo_a.Name = "txt_cuota_legajo_a"
        Me.txt_cuota_legajo_a.Size = New System.Drawing.Size(160, 24)
        Me.txt_cuota_legajo_a.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(316, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 16)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Legajo Alumno:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(316, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 16)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "Fecha de Pago:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(673, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CUOTAS"
        '
        'bt_cuota_eliminar
        '
        Me.bt_cuota_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cuota_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cuota_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cuota_eliminar.Image = Global.escuelaa.My.Resources.Resources._002_herramienta
        Me.bt_cuota_eliminar.Location = New System.Drawing.Point(1208, 10)
        Me.bt_cuota_eliminar.Name = "bt_cuota_eliminar"
        Me.bt_cuota_eliminar.Size = New System.Drawing.Size(40, 42)
        Me.bt_cuota_eliminar.TabIndex = 28
        Me.bt_cuota_eliminar.UseVisualStyleBackColor = False
        '
        'bt_cuota_nueva
        '
        Me.bt_cuota_nueva.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cuota_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cuota_nueva.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cuota_nueva.Image = Global.escuelaa.My.Resources.Resources.mas2
        Me.bt_cuota_nueva.Location = New System.Drawing.Point(1248, 10)
        Me.bt_cuota_nueva.Name = "bt_cuota_nueva"
        Me.bt_cuota_nueva.Size = New System.Drawing.Size(40, 42)
        Me.bt_cuota_nueva.TabIndex = 27
        Me.bt_cuota_nueva.UseVisualStyleBackColor = False
        '
        'bt_inscripcion_eliminar
        '
        Me.bt_inscripcion_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inscripcion_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inscripcion_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inscripcion_eliminar.Image = Global.escuelaa.My.Resources.Resources._002_herramienta
        Me.bt_inscripcion_eliminar.Location = New System.Drawing.Point(572, 12)
        Me.bt_inscripcion_eliminar.Name = "bt_inscripcion_eliminar"
        Me.bt_inscripcion_eliminar.Size = New System.Drawing.Size(40, 42)
        Me.bt_inscripcion_eliminar.TabIndex = 26
        Me.bt_inscripcion_eliminar.UseVisualStyleBackColor = False
        '
        'bt_inscripcion_nueva
        '
        Me.bt_inscripcion_nueva.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inscripcion_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inscripcion_nueva.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inscripcion_nueva.Image = Global.escuelaa.My.Resources.Resources.mas2
        Me.bt_inscripcion_nueva.Location = New System.Drawing.Point(612, 12)
        Me.bt_inscripcion_nueva.Name = "bt_inscripcion_nueva"
        Me.bt_inscripcion_nueva.Size = New System.Drawing.Size(40, 42)
        Me.bt_inscripcion_nueva.TabIndex = 25
        Me.bt_inscripcion_nueva.UseVisualStyleBackColor = False
        '
        'bt_cuota_buscar_legajo_a
        '
        Me.bt_cuota_buscar_legajo_a.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cuota_buscar_legajo_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cuota_buscar_legajo_a.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cuota_buscar_legajo_a.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_cuota_buscar_legajo_a.Location = New System.Drawing.Point(458, 11)
        Me.bt_cuota_buscar_legajo_a.Name = "bt_cuota_buscar_legajo_a"
        Me.bt_cuota_buscar_legajo_a.Size = New System.Drawing.Size(40, 42)
        Me.bt_cuota_buscar_legajo_a.TabIndex = 65
        Me.bt_cuota_buscar_legajo_a.UseVisualStyleBackColor = False
        '
        'bt_cuota_aceptar
        '
        Me.bt_cuota_aceptar.AutoSize = True
        Me.bt_cuota_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_cuota_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cuota_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar11
        Me.bt_cuota_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cuota_aceptar.Location = New System.Drawing.Point(301, 181)
        Me.bt_cuota_aceptar.Name = "bt_cuota_aceptar"
        Me.bt_cuota_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_cuota_aceptar.TabIndex = 99
        Me.bt_cuota_aceptar.Text = "ACEPTAR"
        Me.bt_cuota_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cuota_aceptar.UseVisualStyleBackColor = False
        '
        'bt_cuota_cancelar
        '
        Me.bt_cuota_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_cuota_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cuota_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar1
        Me.bt_cuota_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cuota_cancelar.Location = New System.Drawing.Point(162, 181)
        Me.bt_cuota_cancelar.Name = "bt_cuota_cancelar"
        Me.bt_cuota_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_cuota_cancelar.TabIndex = 98
        Me.bt_cuota_cancelar.Text = "CANCELAR"
        Me.bt_cuota_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cuota_cancelar.UseVisualStyleBackColor = False
        '
        'bt_inscripcion_buscar_legajo_a
        '
        Me.bt_inscripcion_buscar_legajo_a.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inscripcion_buscar_legajo_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inscripcion_buscar_legajo_a.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inscripcion_buscar_legajo_a.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_inscripcion_buscar_legajo_a.Location = New System.Drawing.Point(460, 8)
        Me.bt_inscripcion_buscar_legajo_a.Name = "bt_inscripcion_buscar_legajo_a"
        Me.bt_inscripcion_buscar_legajo_a.Size = New System.Drawing.Size(40, 42)
        Me.bt_inscripcion_buscar_legajo_a.TabIndex = 45
        Me.bt_inscripcion_buscar_legajo_a.UseVisualStyleBackColor = False
        '
        'bt_inscripcion_aceptar
        '
        Me.bt_inscripcion_aceptar.AutoSize = True
        Me.bt_inscripcion_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_inscripcion_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_inscripcion_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar11
        Me.bt_inscripcion_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_inscripcion_aceptar.Location = New System.Drawing.Point(306, 181)
        Me.bt_inscripcion_aceptar.Name = "bt_inscripcion_aceptar"
        Me.bt_inscripcion_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_inscripcion_aceptar.TabIndex = 77
        Me.bt_inscripcion_aceptar.Text = "ACEPTAR"
        Me.bt_inscripcion_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_inscripcion_aceptar.UseVisualStyleBackColor = False
        '
        'bt_inscripcion_cancelar
        '
        Me.bt_inscripcion_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_inscripcion_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_inscripcion_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar1
        Me.bt_inscripcion_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_inscripcion_cancelar.Location = New System.Drawing.Point(167, 181)
        Me.bt_inscripcion_cancelar.Name = "bt_inscripcion_cancelar"
        Me.bt_inscripcion_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_inscripcion_cancelar.TabIndex = 76
        Me.bt_inscripcion_cancelar.Text = "CANCELAR"
        Me.bt_inscripcion_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_inscripcion_cancelar.UseVisualStyleBackColor = False
        '
        'bt_inscripcion_salir
        '
        Me.bt_inscripcion_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_inscripcion_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_inscripcion_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_inscripcion_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_inscripcion_salir.Location = New System.Drawing.Point(39, 10)
        Me.bt_inscripcion_salir.Name = "bt_inscripcion_salir"
        Me.bt_inscripcion_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_inscripcion_salir.TabIndex = 29
        Me.bt_inscripcion_salir.UseVisualStyleBackColor = False
        '
        'frm_alumnos_inscripcion_cuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_inscripcion_salir)
        Me.Controls.Add(Me.bt_cuota_eliminar)
        Me.Controls.Add(Me.bt_cuota_nueva)
        Me.Controls.Add(Me.bt_inscripcion_eliminar)
        Me.Controls.Add(Me.bt_inscripcion_nueva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pl_cuotas)
        Me.Controls.Add(Me.pl_inscripcion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_alumnos_inscripcion_cuotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pl_inscripcion.ResumeLayout(False)
        Me.pl_inscripcion.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_inscripcion_nueva.ResumeLayout(False)
        Me.pl_inscripcion_nueva.PerformLayout()
        Me.pl_cuotas.ResumeLayout(False)
        Me.pl_cuotas.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_cuota_nueva.ResumeLayout(False)
        Me.pl_cuota_nueva.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pl_inscripcion As System.Windows.Forms.Panel
    Friend WithEvents pl_cuotas As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bt_inscripcion_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_inscripcion_nueva As System.Windows.Forms.Button
    Friend WithEvents bt_cuota_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_cuota_nueva As System.Windows.Forms.Button
    Friend WithEvents txt_inscripcion_buscar_legajo_a As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bt_inscripcion_buscar_legajo_a As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents txt_cuota_buscar_legajo_a As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents bt_cuota_buscar_legajo_a As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents pl_inscripcion_nueva As System.Windows.Forms.Panel
    Friend WithEvents cmb_inscripcion_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_inscripcion_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_inscripcion_division As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_inscripcion_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_inscripcion_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_inscripcion_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_inscripcion_legajo_a As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pl_cuota_nueva As System.Windows.Forms.Panel
    Friend WithEvents dtp_cuota_fecha_vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_cuota_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_cuota_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtp_cuota_fecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_cuota_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_cuota_legajo_a As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bt_inscripcion_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_inscripcion_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_cuota_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cuota_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_inscripcion_salir As System.Windows.Forms.Button
End Class
