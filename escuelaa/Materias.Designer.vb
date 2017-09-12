<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_materias
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
        Me.grid_materias = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_materias_buscar_nombre = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_materias_buscar_nivel = New System.Windows.Forms.ComboBox()
        Me.bt_materias_buscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_materias_nueva_codigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_materias_nueva_nivel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pl_materias_nueva = New System.Windows.Forms.Panel()
        Me.txt_materia_nueva_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_materias_aceptar = New System.Windows.Forms.Button()
        Me.bt_materias_cancelar = New System.Windows.Forms.Button()
        Me.bt_materias_eliminar = New System.Windows.Forms.Button()
        Me.bt_materias_nueva = New System.Windows.Forms.Button()
        Me.bt_materias_salir = New System.Windows.Forms.Button()
        CType(Me.grid_materias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pl_materias_nueva.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MATERIAS"
        '
        'grid_materias
        '
        Me.grid_materias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_materias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grid_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_materias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.grid_materias.Location = New System.Drawing.Point(48, 81)
        Me.grid_materias.Name = "grid_materias"
        Me.grid_materias.Size = New System.Drawing.Size(407, 448)
        Me.grid_materias.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nivel"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmb_materias_buscar_nombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_materias_buscar_nivel)
        Me.Panel1.Controls.Add(Me.bt_materias_buscar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.grid_materias)
        Me.Panel1.Location = New System.Drawing.Point(28, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 572)
        Me.Panel1.TabIndex = 23
        '
        'cmb_materias_buscar_nombre
        '
        Me.cmb_materias_buscar_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_materias_buscar_nombre.FormattingEnabled = True
        Me.cmb_materias_buscar_nombre.Location = New System.Drawing.Point(101, 26)
        Me.cmb_materias_buscar_nombre.Name = "cmb_materias_buscar_nombre"
        Me.cmb_materias_buscar_nombre.Size = New System.Drawing.Size(121, 28)
        Me.cmb_materias_buscar_nombre.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nombre:"
        '
        'cmb_materias_buscar_nivel
        '
        Me.cmb_materias_buscar_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_materias_buscar_nivel.FormattingEnabled = True
        Me.cmb_materias_buscar_nivel.Location = New System.Drawing.Point(298, 27)
        Me.cmb_materias_buscar_nivel.Name = "cmb_materias_buscar_nivel"
        Me.cmb_materias_buscar_nivel.Size = New System.Drawing.Size(121, 28)
        Me.cmb_materias_buscar_nivel.TabIndex = 22
        '
        'bt_materias_buscar
        '
        Me.bt_materias_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_materias_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_materias_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_materias_buscar.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_materias_buscar.Location = New System.Drawing.Point(444, 20)
        Me.bt_materias_buscar.Name = "bt_materias_buscar"
        Me.bt_materias_buscar.Size = New System.Drawing.Size(40, 42)
        Me.bt_materias_buscar.TabIndex = 21
        Me.bt_materias_buscar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nivel: "
        '
        'txt_materias_nueva_codigo
        '
        Me.txt_materias_nueva_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_materias_nueva_codigo.Location = New System.Drawing.Point(213, 33)
        Me.txt_materias_nueva_codigo.Name = "txt_materias_nueva_codigo"
        Me.txt_materias_nueva_codigo.Size = New System.Drawing.Size(190, 22)
        Me.txt_materias_nueva_codigo.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Codigo: "
        '
        'cmb_materias_nueva_nivel
        '
        Me.cmb_materias_nueva_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_materias_nueva_nivel.FormattingEnabled = True
        Me.cmb_materias_nueva_nivel.Location = New System.Drawing.Point(213, 125)
        Me.cmb_materias_nueva_nivel.Name = "cmb_materias_nueva_nivel"
        Me.cmb_materias_nueva_nivel.Size = New System.Drawing.Size(190, 24)
        Me.cmb_materias_nueva_nivel.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nivel: "
        '
        'pl_materias_nueva
        '
        Me.pl_materias_nueva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_materias_nueva.Controls.Add(Me.txt_materia_nueva_nombre)
        Me.pl_materias_nueva.Controls.Add(Me.Label4)
        Me.pl_materias_nueva.Controls.Add(Me.bt_materias_aceptar)
        Me.pl_materias_nueva.Controls.Add(Me.bt_materias_cancelar)
        Me.pl_materias_nueva.Controls.Add(Me.txt_materias_nueva_codigo)
        Me.pl_materias_nueva.Controls.Add(Me.Label7)
        Me.pl_materias_nueva.Controls.Add(Me.cmb_materias_nueva_nivel)
        Me.pl_materias_nueva.Controls.Add(Me.Label5)
        Me.pl_materias_nueva.Enabled = False
        Me.pl_materias_nueva.Location = New System.Drawing.Point(595, 64)
        Me.pl_materias_nueva.Name = "pl_materias_nueva"
        Me.pl_materias_nueva.Size = New System.Drawing.Size(519, 290)
        Me.pl_materias_nueva.TabIndex = 24
        '
        'txt_materia_nueva_nombre
        '
        Me.txt_materia_nueva_nombre.Enabled = False
        Me.txt_materia_nueva_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_materia_nueva_nombre.Location = New System.Drawing.Point(213, 81)
        Me.txt_materia_nueva_nombre.Name = "txt_materia_nueva_nombre"
        Me.txt_materia_nueva_nombre.Size = New System.Drawing.Size(190, 22)
        Me.txt_materia_nueva_nombre.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nombre: "
        '
        'bt_materias_aceptar
        '
        Me.bt_materias_aceptar.AutoSize = True
        Me.bt_materias_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_materias_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_materias_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar13
        Me.bt_materias_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_materias_aceptar.Location = New System.Drawing.Point(287, 189)
        Me.bt_materias_aceptar.Name = "bt_materias_aceptar"
        Me.bt_materias_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_materias_aceptar.TabIndex = 29
        Me.bt_materias_aceptar.Text = "ACEPTAR"
        Me.bt_materias_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_materias_aceptar.UseVisualStyleBackColor = False
        '
        'bt_materias_cancelar
        '
        Me.bt_materias_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_materias_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_materias_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar5
        Me.bt_materias_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_materias_cancelar.Location = New System.Drawing.Point(152, 189)
        Me.bt_materias_cancelar.Name = "bt_materias_cancelar"
        Me.bt_materias_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_materias_cancelar.TabIndex = 28
        Me.bt_materias_cancelar.Text = "CANCELAR"
        Me.bt_materias_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_materias_cancelar.UseVisualStyleBackColor = False
        '
        'bt_materias_eliminar
        '
        Me.bt_materias_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_materias_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_materias_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_materias_eliminar.Image = Global.escuelaa.My.Resources.Resources._002_herramienta
        Me.bt_materias_eliminar.Location = New System.Drawing.Point(464, 14)
        Me.bt_materias_eliminar.Name = "bt_materias_eliminar"
        Me.bt_materias_eliminar.Size = New System.Drawing.Size(40, 42)
        Me.bt_materias_eliminar.TabIndex = 16
        Me.bt_materias_eliminar.UseVisualStyleBackColor = False
        '
        'bt_materias_nueva
        '
        Me.bt_materias_nueva.BackColor = System.Drawing.SystemColors.Control
        Me.bt_materias_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_materias_nueva.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_materias_nueva.Image = Global.escuelaa.My.Resources.Resources.mas3
        Me.bt_materias_nueva.Location = New System.Drawing.Point(510, 14)
        Me.bt_materias_nueva.Name = "bt_materias_nueva"
        Me.bt_materias_nueva.Size = New System.Drawing.Size(40, 42)
        Me.bt_materias_nueva.TabIndex = 14
        Me.bt_materias_nueva.UseVisualStyleBackColor = False
        '
        'bt_materias_salir
        '
        Me.bt_materias_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_materias_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_materias_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_materias_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_materias_salir.Location = New System.Drawing.Point(29, 16)
        Me.bt_materias_salir.Name = "bt_materias_salir"
        Me.bt_materias_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_materias_salir.TabIndex = 25
        Me.bt_materias_salir.UseVisualStyleBackColor = False
        '
        'frm_materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_materias_salir)
        Me.Controls.Add(Me.pl_materias_nueva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_materias_eliminar)
        Me.Controls.Add(Me.bt_materias_nueva)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_materias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid_materias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pl_materias_nueva.ResumeLayout(False)
        Me.pl_materias_nueva.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_materias_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_materias_nueva As System.Windows.Forms.Button
    Friend WithEvents grid_materias As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_materias_buscar_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_materias_buscar_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents bt_materias_buscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_materias_nueva_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_materias_nueva_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pl_materias_nueva As System.Windows.Forms.Panel
    Friend WithEvents bt_materias_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_materias_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_materias_salir As System.Windows.Forms.Button
    Friend WithEvents txt_materia_nueva_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
