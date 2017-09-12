<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profesores
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_profesor_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pl_nuevo_profesor = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_profesor_nuevo_legajo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_profesor_nuevo_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_profesor_nuevo_apellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pl_materias_nuevo_profesor = New System.Windows.Forms.Panel()
        Me.cmb_profesor_nuevo_division = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_profesor_nuevo_materia = New System.Windows.Forms.ComboBox()
        Me.cmb_profesor_nuevo_nivel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pl_cargar_botones_profesores = New System.Windows.Forms.Panel()
        Me.bt_profesor_calificaciones = New System.Windows.Forms.Button()
        Me.bt_profesor_inasistencia = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_profesores_salir = New System.Windows.Forms.Button()
        Me.bt_profesores_eliminar = New System.Windows.Forms.Button()
        Me.bt_profesor_materia_eliminar = New System.Windows.Forms.Button()
        Me.bt_profesor_materia_nueva = New System.Windows.Forms.Button()
        Me.bt_profesor_aceptar = New System.Windows.Forms.Button()
        Me.bt_profesor_cancelar = New System.Windows.Forms.Button()
        Me.bt_profesor_materia_aceptar = New System.Windows.Forms.Button()
        Me.bt_profesor_materia_cancelar = New System.Windows.Forms.Button()
        Me.bt_profesor_nuevo = New System.Windows.Forms.Button()
        Me.bt_profesor_buscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_nuevo_profesor.SuspendLayout()
        Me.pl_materias_nuevo_profesor.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_cargar_botones_profesores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROFESORES"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.bt_profesor_buscar)
        Me.Panel1.Controls.Add(Me.txt_profesor_buscar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(28, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 412)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 316)
        Me.DataGridView1.TabIndex = 8
        '
        'Column3
        '
        Me.Column3.HeaderText = "Legajo"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Apellido"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'txt_profesor_buscar
        '
        Me.txt_profesor_buscar.CausesValidation = False
        Me.txt_profesor_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profesor_buscar.Location = New System.Drawing.Point(225, 20)
        Me.txt_profesor_buscar.Name = "txt_profesor_buscar"
        Me.txt_profesor_buscar.Size = New System.Drawing.Size(189, 26)
        Me.txt_profesor_buscar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Profesor: "
        '
        'pl_nuevo_profesor
        '
        Me.pl_nuevo_profesor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_nuevo_profesor.Controls.Add(Me.bt_profesor_materia_eliminar)
        Me.pl_nuevo_profesor.Controls.Add(Me.bt_profesor_materia_nueva)
        Me.pl_nuevo_profesor.Controls.Add(Me.Label7)
        Me.pl_nuevo_profesor.Controls.Add(Me.bt_profesor_aceptar)
        Me.pl_nuevo_profesor.Controls.Add(Me.bt_profesor_cancelar)
        Me.pl_nuevo_profesor.Controls.Add(Me.txt_profesor_nuevo_legajo)
        Me.pl_nuevo_profesor.Controls.Add(Me.Label4)
        Me.pl_nuevo_profesor.Controls.Add(Me.txt_profesor_nuevo_nombre)
        Me.pl_nuevo_profesor.Controls.Add(Me.Label5)
        Me.pl_nuevo_profesor.Controls.Add(Me.txt_profesor_nuevo_apellido)
        Me.pl_nuevo_profesor.Controls.Add(Me.Label6)
        Me.pl_nuevo_profesor.Controls.Add(Me.pl_materias_nuevo_profesor)
        Me.pl_nuevo_profesor.Enabled = False
        Me.pl_nuevo_profesor.Location = New System.Drawing.Point(669, 62)
        Me.pl_nuevo_profesor.Name = "pl_nuevo_profesor"
        Me.pl_nuevo_profesor.Size = New System.Drawing.Size(620, 578)
        Me.pl_nuevo_profesor.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Materias en la que va a estar:"
        '
        'txt_profesor_nuevo_legajo
        '
        Me.txt_profesor_nuevo_legajo.CausesValidation = False
        Me.txt_profesor_nuevo_legajo.Enabled = False
        Me.txt_profesor_nuevo_legajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profesor_nuevo_legajo.Location = New System.Drawing.Point(91, 73)
        Me.txt_profesor_nuevo_legajo.Name = "txt_profesor_nuevo_legajo"
        Me.txt_profesor_nuevo_legajo.Size = New System.Drawing.Size(202, 22)
        Me.txt_profesor_nuevo_legajo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Legajo:"
        '
        'txt_profesor_nuevo_nombre
        '
        Me.txt_profesor_nuevo_nombre.CausesValidation = False
        Me.txt_profesor_nuevo_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profesor_nuevo_nombre.Location = New System.Drawing.Point(401, 25)
        Me.txt_profesor_nuevo_nombre.Name = "txt_profesor_nuevo_nombre"
        Me.txt_profesor_nuevo_nombre.Size = New System.Drawing.Size(202, 22)
        Me.txt_profesor_nuevo_nombre.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nombre: "
        '
        'txt_profesor_nuevo_apellido
        '
        Me.txt_profesor_nuevo_apellido.CausesValidation = False
        Me.txt_profesor_nuevo_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profesor_nuevo_apellido.Location = New System.Drawing.Point(91, 25)
        Me.txt_profesor_nuevo_apellido.Name = "txt_profesor_nuevo_apellido"
        Me.txt_profesor_nuevo_apellido.Size = New System.Drawing.Size(202, 22)
        Me.txt_profesor_nuevo_apellido.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Apellido: "
        '
        'pl_materias_nuevo_profesor
        '
        Me.pl_materias_nuevo_profesor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.bt_profesor_materia_aceptar)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.bt_profesor_materia_cancelar)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.cmb_profesor_nuevo_division)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.Label10)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.DataGridView2)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.cmb_profesor_nuevo_materia)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.cmb_profesor_nuevo_nivel)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.Label9)
        Me.pl_materias_nuevo_profesor.Controls.Add(Me.Label8)
        Me.pl_materias_nuevo_profesor.Enabled = False
        Me.pl_materias_nuevo_profesor.Location = New System.Drawing.Point(28, 153)
        Me.pl_materias_nuevo_profesor.Name = "pl_materias_nuevo_profesor"
        Me.pl_materias_nuevo_profesor.Size = New System.Drawing.Size(575, 343)
        Me.pl_materias_nuevo_profesor.TabIndex = 23
        '
        'cmb_profesor_nuevo_division
        '
        Me.cmb_profesor_nuevo_division.FormattingEnabled = True
        Me.cmb_profesor_nuevo_division.Location = New System.Drawing.Point(364, 13)
        Me.cmb_profesor_nuevo_division.Name = "cmb_profesor_nuevo_division"
        Me.cmb_profesor_nuevo_division.Size = New System.Drawing.Size(179, 21)
        Me.cmb_profesor_nuevo_division.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "División:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column4})
        Me.DataGridView2.Location = New System.Drawing.Point(37, 96)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(506, 193)
        Me.DataGridView2.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Legajo Profesor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nivel"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "División"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column4
        '
        Me.Column4.HeaderText = "Materia"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'cmb_profesor_nuevo_materia
        '
        Me.cmb_profesor_nuevo_materia.FormattingEnabled = True
        Me.cmb_profesor_nuevo_materia.Location = New System.Drawing.Point(84, 51)
        Me.cmb_profesor_nuevo_materia.Name = "cmb_profesor_nuevo_materia"
        Me.cmb_profesor_nuevo_materia.Size = New System.Drawing.Size(179, 21)
        Me.cmb_profesor_nuevo_materia.TabIndex = 22
        '
        'cmb_profesor_nuevo_nivel
        '
        Me.cmb_profesor_nuevo_nivel.FormattingEnabled = True
        Me.cmb_profesor_nuevo_nivel.Location = New System.Drawing.Point(84, 12)
        Me.cmb_profesor_nuevo_nivel.Name = "cmb_profesor_nuevo_nivel"
        Me.cmb_profesor_nuevo_nivel.Size = New System.Drawing.Size(179, 21)
        Me.cmb_profesor_nuevo_nivel.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Materia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nivel:"
        '
        'pl_cargar_botones_profesores
        '
        Me.pl_cargar_botones_profesores.Controls.Add(Me.bt_profesor_calificaciones)
        Me.pl_cargar_botones_profesores.Controls.Add(Me.bt_profesor_inasistencia)
        Me.pl_cargar_botones_profesores.Location = New System.Drawing.Point(29, 537)
        Me.pl_cargar_botones_profesores.Name = "pl_cargar_botones_profesores"
        Me.pl_cargar_botones_profesores.Size = New System.Drawing.Size(615, 103)
        Me.pl_cargar_botones_profesores.TabIndex = 20
        Me.pl_cargar_botones_profesores.Visible = False
        '
        'bt_profesor_calificaciones
        '
        Me.bt_profesor_calificaciones.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_calificaciones.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesor_calificaciones.Location = New System.Drawing.Point(326, 12)
        Me.bt_profesor_calificaciones.Name = "bt_profesor_calificaciones"
        Me.bt_profesor_calificaciones.Size = New System.Drawing.Size(244, 72)
        Me.bt_profesor_calificaciones.TabIndex = 22
        Me.bt_profesor_calificaciones.Text = "CARGAR CALIFICACIONES"
        Me.bt_profesor_calificaciones.UseVisualStyleBackColor = False
        '
        'bt_profesor_inasistencia
        '
        Me.bt_profesor_inasistencia.AutoSize = True
        Me.bt_profesor_inasistencia.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_inasistencia.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesor_inasistencia.Location = New System.Drawing.Point(29, 12)
        Me.bt_profesor_inasistencia.Name = "bt_profesor_inasistencia"
        Me.bt_profesor_inasistencia.Size = New System.Drawing.Size(244, 72)
        Me.bt_profesor_inasistencia.TabIndex = 23
        Me.bt_profesor_inasistencia.Text = "CARGAR INASISTENCIA"
        Me.bt_profesor_inasistencia.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 499)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Seleccione profesor para cargar inasistencia o calificaciones"
        '
        'bt_profesores_salir
        '
        Me.bt_profesores_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesores_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesores_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_profesores_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_profesores_salir.Location = New System.Drawing.Point(29, 16)
        Me.bt_profesores_salir.Name = "bt_profesores_salir"
        Me.bt_profesores_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_profesores_salir.TabIndex = 24
        Me.bt_profesores_salir.UseVisualStyleBackColor = False
        '
        'bt_profesores_eliminar
        '
        Me.bt_profesores_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesores_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesores_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_profesores_eliminar.Image = Global.escuelaa.My.Resources.Resources._002_herramienta
        Me.bt_profesores_eliminar.Location = New System.Drawing.Point(559, 16)
        Me.bt_profesores_eliminar.Name = "bt_profesores_eliminar"
        Me.bt_profesores_eliminar.Size = New System.Drawing.Size(40, 42)
        Me.bt_profesores_eliminar.TabIndex = 22
        Me.bt_profesores_eliminar.UseVisualStyleBackColor = False
        '
        'bt_profesor_materia_eliminar
        '
        Me.bt_profesor_materia_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_materia_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesor_materia_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_profesor_materia_eliminar.Image = Global.escuelaa.My.Resources.Resources.eliminar
        Me.bt_profesor_materia_eliminar.Location = New System.Drawing.Point(510, 110)
        Me.bt_profesor_materia_eliminar.Name = "bt_profesor_materia_eliminar"
        Me.bt_profesor_materia_eliminar.Size = New System.Drawing.Size(39, 39)
        Me.bt_profesor_materia_eliminar.TabIndex = 25
        Me.bt_profesor_materia_eliminar.UseVisualStyleBackColor = False
        '
        'bt_profesor_materia_nueva
        '
        Me.bt_profesor_materia_nueva.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_materia_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesor_materia_nueva.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_profesor_materia_nueva.Image = Global.escuelaa.My.Resources.Resources.mas2
        Me.bt_profesor_materia_nueva.Location = New System.Drawing.Point(555, 110)
        Me.bt_profesor_materia_nueva.Name = "bt_profesor_materia_nueva"
        Me.bt_profesor_materia_nueva.Size = New System.Drawing.Size(39, 39)
        Me.bt_profesor_materia_nueva.TabIndex = 24
        Me.bt_profesor_materia_nueva.UseVisualStyleBackColor = False
        '
        'bt_profesor_aceptar
        '
        Me.bt_profesor_aceptar.AutoSize = True
        Me.bt_profesor_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_profesor_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesor_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar12
        Me.bt_profesor_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_profesor_aceptar.Location = New System.Drawing.Point(362, 514)
        Me.bt_profesor_aceptar.Name = "bt_profesor_aceptar"
        Me.bt_profesor_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_profesor_aceptar.TabIndex = 21
        Me.bt_profesor_aceptar.Text = "ACEPTAR"
        Me.bt_profesor_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_profesor_aceptar.UseVisualStyleBackColor = False
        '
        'bt_profesor_cancelar
        '
        Me.bt_profesor_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_profesor_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesor_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar3
        Me.bt_profesor_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_profesor_cancelar.Location = New System.Drawing.Point(215, 514)
        Me.bt_profesor_cancelar.Name = "bt_profesor_cancelar"
        Me.bt_profesor_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_profesor_cancelar.TabIndex = 20
        Me.bt_profesor_cancelar.Text = "CANCELAR"
        Me.bt_profesor_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_profesor_cancelar.UseVisualStyleBackColor = False
        '
        'bt_profesor_materia_aceptar
        '
        Me.bt_profesor_materia_aceptar.AutoSize = True
        Me.bt_profesor_materia_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_materia_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesor_materia_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesor_materia_aceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_materia_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar12
        Me.bt_profesor_materia_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_profesor_materia_aceptar.Location = New System.Drawing.Point(499, 295)
        Me.bt_profesor_materia_aceptar.Name = "bt_profesor_materia_aceptar"
        Me.bt_profesor_materia_aceptar.Size = New System.Drawing.Size(44, 40)
        Me.bt_profesor_materia_aceptar.TabIndex = 27
        Me.bt_profesor_materia_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_profesor_materia_aceptar.UseVisualStyleBackColor = False
        '
        'bt_profesor_materia_cancelar
        '
        Me.bt_profesor_materia_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_materia_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesor_materia_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesor_materia_cancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_materia_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar1
        Me.bt_profesor_materia_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_profesor_materia_cancelar.Location = New System.Drawing.Point(450, 297)
        Me.bt_profesor_materia_cancelar.Name = "bt_profesor_materia_cancelar"
        Me.bt_profesor_materia_cancelar.Size = New System.Drawing.Size(43, 36)
        Me.bt_profesor_materia_cancelar.TabIndex = 26
        Me.bt_profesor_materia_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_profesor_materia_cancelar.UseVisualStyleBackColor = False
        '
        'bt_profesor_nuevo
        '
        Me.bt_profesor_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesor_nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_profesor_nuevo.Image = Global.escuelaa.My.Resources.Resources.mas2
        Me.bt_profesor_nuevo.Location = New System.Drawing.Point(603, 16)
        Me.bt_profesor_nuevo.Name = "bt_profesor_nuevo"
        Me.bt_profesor_nuevo.Size = New System.Drawing.Size(40, 42)
        Me.bt_profesor_nuevo.TabIndex = 9
        Me.bt_profesor_nuevo.UseVisualStyleBackColor = False
        '
        'bt_profesor_buscar
        '
        Me.bt_profesor_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesor_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_profesor_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_profesor_buscar.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_profesor_buscar.Location = New System.Drawing.Point(435, 10)
        Me.bt_profesor_buscar.Name = "bt_profesor_buscar"
        Me.bt_profesor_buscar.Size = New System.Drawing.Size(40, 42)
        Me.bt_profesor_buscar.TabIndex = 3
        Me.bt_profesor_buscar.UseVisualStyleBackColor = False
        '
        'frm_profesores
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_profesores_salir)
        Me.Controls.Add(Me.bt_profesores_eliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pl_nuevo_profesor)
        Me.Controls.Add(Me.bt_profesor_nuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pl_cargar_botones_profesores)
        Me.Controls.Add(Me.Label1)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "frm_profesores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_nuevo_profesor.ResumeLayout(False)
        Me.pl_nuevo_profesor.PerformLayout()
        Me.pl_materias_nuevo_profesor.ResumeLayout(False)
        Me.pl_materias_nuevo_profesor.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_cargar_botones_profesores.ResumeLayout(False)
        Me.pl_cargar_botones_profesores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_profesor_buscar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt_profesor_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_profesor_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pl_nuevo_profesor As System.Windows.Forms.Panel
    Friend WithEvents txt_profesor_nuevo_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_profesor_nuevo_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_profesor_nuevo_legajo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bt_profesor_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_profesor_cancelar As System.Windows.Forms.Button
    Friend WithEvents pl_materias_nuevo_profesor As System.Windows.Forms.Panel
    Friend WithEvents bt_profesor_materia_nueva As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_profesor_nuevo_division As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_profesor_nuevo_materia As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_profesor_nuevo_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bt_profesor_materia_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_profesor_materia_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_profesor_materia_cancelar As System.Windows.Forms.Button
    Friend WithEvents pl_cargar_botones_profesores As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_profesor_calificaciones As System.Windows.Forms.Button
    Friend WithEvents bt_profesor_inasistencia As System.Windows.Forms.Button
    Friend WithEvents bt_profesores_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_profesores_salir As System.Windows.Forms.Button
End Class
