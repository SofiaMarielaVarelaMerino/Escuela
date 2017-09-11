<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alumnos
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_alumnos_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.grid_alumnos = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_alumnos_buscar_apellido = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_alumnos_buscar = New System.Windows.Forms.Button()
        Me.bt_alumnos_eliminar = New System.Windows.Forms.Button()
        Me.bt_alumnos_agregar = New System.Windows.Forms.Button()
        Me.bt_alumnos_salir = New System.Windows.Forms.Button()
        CType(Me.grid_alumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ALUMNOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'txt_alumnos_buscar_nombre
        '
        Me.txt_alumnos_buscar_nombre.CausesValidation = False
        Me.txt_alumnos_buscar_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumnos_buscar_nombre.Location = New System.Drawing.Point(326, 21)
        Me.txt_alumnos_buscar_nombre.Name = "txt_alumnos_buscar_nombre"
        Me.txt_alumnos_buscar_nombre.Size = New System.Drawing.Size(189, 26)
        Me.txt_alumnos_buscar_nombre.TabIndex = 1
        '
        'grid_alumnos
        '
        Me.grid_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_alumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column8, Me.Column7, Me.Column6, Me.Column9})
        Me.grid_alumnos.Location = New System.Drawing.Point(24, 74)
        Me.grid_alumnos.Name = "grid_alumnos"
        Me.grid_alumnos.Size = New System.Drawing.Size(1151, 443)
        Me.grid_alumnos.TabIndex = 8
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
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha Nacimiento"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Estado"
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Cantidad de Amonestaciones"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Apellido Tutor"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Nombre Tutor"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "Telefono Tutor"
        Me.Column9.Name = "Column9"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(531, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellido:"
        '
        'txt_alumnos_buscar_apellido
        '
        Me.txt_alumnos_buscar_apellido.CausesValidation = False
        Me.txt_alumnos_buscar_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alumnos_buscar_apellido.Location = New System.Drawing.Point(610, 21)
        Me.txt_alumnos_buscar_apellido.Name = "txt_alumnos_buscar_apellido"
        Me.txt_alumnos_buscar_apellido.Size = New System.Drawing.Size(189, 26)
        Me.txt_alumnos_buscar_apellido.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_alumnos_buscar_apellido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.grid_alumnos)
        Me.Panel1.Controls.Add(Me.bt_alumnos_buscar)
        Me.Panel1.Controls.Add(Me.txt_alumnos_buscar_nombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(29, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 565)
        Me.Panel1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(857, 529)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hacer doble clik sobre el alumno para ir a él."
        '
        'bt_alumnos_buscar
        '
        Me.bt_alumnos_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumnos_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumnos_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumnos_buscar.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_alumnos_buscar.Location = New System.Drawing.Point(815, 14)
        Me.bt_alumnos_buscar.Name = "bt_alumnos_buscar"
        Me.bt_alumnos_buscar.Size = New System.Drawing.Size(40, 42)
        Me.bt_alumnos_buscar.TabIndex = 3
        Me.bt_alumnos_buscar.UseVisualStyleBackColor = False
        '
        'bt_alumnos_eliminar
        '
        Me.bt_alumnos_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumnos_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumnos_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumnos_eliminar.Image = Global.escuelaa.My.Resources.Resources._002_herramienta
        Me.bt_alumnos_eliminar.Location = New System.Drawing.Point(1152, 19)
        Me.bt_alumnos_eliminar.Name = "bt_alumnos_eliminar"
        Me.bt_alumnos_eliminar.Size = New System.Drawing.Size(40, 42)
        Me.bt_alumnos_eliminar.TabIndex = 24
        Me.bt_alumnos_eliminar.UseVisualStyleBackColor = False
        '
        'bt_alumnos_agregar
        '
        Me.bt_alumnos_agregar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumnos_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumnos_agregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumnos_agregar.Image = Global.escuelaa.My.Resources.Resources.mas2
        Me.bt_alumnos_agregar.Location = New System.Drawing.Point(1192, 19)
        Me.bt_alumnos_agregar.Name = "bt_alumnos_agregar"
        Me.bt_alumnos_agregar.Size = New System.Drawing.Size(40, 42)
        Me.bt_alumnos_agregar.TabIndex = 23
        Me.bt_alumnos_agregar.UseVisualStyleBackColor = False
        '
        'bt_alumnos_salir
        '
        Me.bt_alumnos_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumnos_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_alumnos_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_alumnos_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_alumnos_salir.Location = New System.Drawing.Point(29, 19)
        Me.bt_alumnos_salir.Name = "bt_alumnos_salir"
        Me.bt_alumnos_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_alumnos_salir.TabIndex = 25
        Me.bt_alumnos_salir.UseVisualStyleBackColor = False
        '
        'frm_alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_alumnos_salir)
        Me.Controls.Add(Me.bt_alumnos_eliminar)
        Me.Controls.Add(Me.bt_alumnos_agregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_alumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid_alumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_alumnos_agregar As System.Windows.Forms.Button
    Friend WithEvents bt_alumnos_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_alumnos_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents bt_alumnos_buscar As System.Windows.Forms.Button
    Friend WithEvents grid_alumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_alumnos_buscar_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_alumnos_salir As System.Windows.Forms.Button
End Class
