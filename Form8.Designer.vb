<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cursos
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
        Me.cmb_cursos_buscar_division = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_cursos_buscar_nivel = New System.Windows.Forms.ComboBox()
        Me.bt_cursos_buscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pl_cursos_nuevo = New System.Windows.Forms.Panel()
        Me.txt_cursos_nuevo_codigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_cursos_nuevo_division = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_cursos_nuevo_nivel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_cursos_aceptar = New System.Windows.Forms.Button()
        Me.bt_cursos_cancelar = New System.Windows.Forms.Button()
        Me.bt_cursos_eliminar = New System.Windows.Forms.Button()
        Me.bt_cursos_nuevo = New System.Windows.Forms.Button()
        Me.bt_cursos_salir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_cursos_nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CURSOS"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmb_cursos_buscar_division)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_cursos_buscar_nivel)
        Me.Panel1.Controls.Add(Me.bt_cursos_buscar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(28, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 563)
        Me.Panel1.TabIndex = 19
        '
        'cmb_cursos_buscar_division
        '
        Me.cmb_cursos_buscar_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cursos_buscar_division.FormattingEnabled = True
        Me.cmb_cursos_buscar_division.Location = New System.Drawing.Point(338, 27)
        Me.cmb_cursos_buscar_division.Name = "cmb_cursos_buscar_division"
        Me.cmb_cursos_buscar_division.Size = New System.Drawing.Size(121, 28)
        Me.cmb_cursos_buscar_division.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "División: "
        '
        'cmb_cursos_buscar_nivel
        '
        Me.cmb_cursos_buscar_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cursos_buscar_nivel.FormattingEnabled = True
        Me.cmb_cursos_buscar_nivel.Location = New System.Drawing.Point(112, 25)
        Me.cmb_cursos_buscar_nivel.Name = "cmb_cursos_buscar_nivel"
        Me.cmb_cursos_buscar_nivel.Size = New System.Drawing.Size(121, 28)
        Me.cmb_cursos_buscar_nivel.TabIndex = 17
        '
        'bt_cursos_buscar
        '
        Me.bt_cursos_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cursos_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cursos_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cursos_buscar.Image = Global.escuelaa.My.Resources.Resources.buscar1
        Me.bt_cursos_buscar.Location = New System.Drawing.Point(491, 19)
        Me.bt_cursos_buscar.Name = "bt_cursos_buscar"
        Me.bt_cursos_buscar.Size = New System.Drawing.Size(40, 42)
        Me.bt_cursos_buscar.TabIndex = 16
        Me.bt_cursos_buscar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nivel: "
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(47, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 452)
        Me.DataGridView1.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nivel"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Division"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'pl_cursos_nuevo
        '
        Me.pl_cursos_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_cursos_nuevo.Controls.Add(Me.txt_cursos_nuevo_codigo)
        Me.pl_cursos_nuevo.Controls.Add(Me.Label7)
        Me.pl_cursos_nuevo.Controls.Add(Me.cmb_cursos_nuevo_division)
        Me.pl_cursos_nuevo.Controls.Add(Me.Label6)
        Me.pl_cursos_nuevo.Controls.Add(Me.cmb_cursos_nuevo_nivel)
        Me.pl_cursos_nuevo.Controls.Add(Me.Label5)
        Me.pl_cursos_nuevo.Controls.Add(Me.bt_cursos_aceptar)
        Me.pl_cursos_nuevo.Controls.Add(Me.bt_cursos_cancelar)
        Me.pl_cursos_nuevo.Enabled = False
        Me.pl_cursos_nuevo.Location = New System.Drawing.Point(661, 64)
        Me.pl_cursos_nuevo.Name = "pl_cursos_nuevo"
        Me.pl_cursos_nuevo.Size = New System.Drawing.Size(608, 281)
        Me.pl_cursos_nuevo.TabIndex = 20
        '
        'txt_cursos_nuevo_codigo
        '
        Me.txt_cursos_nuevo_codigo.Enabled = False
        Me.txt_cursos_nuevo_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cursos_nuevo_codigo.Location = New System.Drawing.Point(250, 32)
        Me.txt_cursos_nuevo_codigo.Name = "txt_cursos_nuevo_codigo"
        Me.txt_cursos_nuevo_codigo.Size = New System.Drawing.Size(190, 22)
        Me.txt_cursos_nuevo_codigo.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(170, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Codigo: "
        '
        'cmb_cursos_nuevo_division
        '
        Me.cmb_cursos_nuevo_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cursos_nuevo_division.FormattingEnabled = True
        Me.cmb_cursos_nuevo_division.Location = New System.Drawing.Point(250, 132)
        Me.cmb_cursos_nuevo_division.Name = "cmb_cursos_nuevo_division"
        Me.cmb_cursos_nuevo_division.Size = New System.Drawing.Size(190, 24)
        Me.cmb_cursos_nuevo_division.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "División: "
        '
        'cmb_cursos_nuevo_nivel
        '
        Me.cmb_cursos_nuevo_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cursos_nuevo_nivel.FormattingEnabled = True
        Me.cmb_cursos_nuevo_nivel.Location = New System.Drawing.Point(250, 78)
        Me.cmb_cursos_nuevo_nivel.Name = "cmb_cursos_nuevo_nivel"
        Me.cmb_cursos_nuevo_nivel.Size = New System.Drawing.Size(190, 24)
        Me.cmb_cursos_nuevo_nivel.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(170, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nivel: "
        '
        'bt_cursos_aceptar
        '
        Me.bt_cursos_aceptar.AutoSize = True
        Me.bt_cursos_aceptar.BackColor = System.Drawing.Color.Silver
        Me.bt_cursos_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cursos_aceptar.Image = Global.escuelaa.My.Resources.Resources.aceptar11
        Me.bt_cursos_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cursos_aceptar.Location = New System.Drawing.Point(324, 208)
        Me.bt_cursos_aceptar.Name = "bt_cursos_aceptar"
        Me.bt_cursos_aceptar.Size = New System.Drawing.Size(116, 45)
        Me.bt_cursos_aceptar.TabIndex = 18
        Me.bt_cursos_aceptar.Text = "ACEPTAR"
        Me.bt_cursos_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cursos_aceptar.UseVisualStyleBackColor = False
        '
        'bt_cursos_cancelar
        '
        Me.bt_cursos_cancelar.BackColor = System.Drawing.Color.Silver
        Me.bt_cursos_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cursos_cancelar.Image = Global.escuelaa.My.Resources.Resources.cancelar4
        Me.bt_cursos_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_cursos_cancelar.Location = New System.Drawing.Point(177, 208)
        Me.bt_cursos_cancelar.Name = "bt_cursos_cancelar"
        Me.bt_cursos_cancelar.Size = New System.Drawing.Size(120, 45)
        Me.bt_cursos_cancelar.TabIndex = 17
        Me.bt_cursos_cancelar.Text = "CANCELAR"
        Me.bt_cursos_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_cursos_cancelar.UseVisualStyleBackColor = False
        '
        'bt_cursos_eliminar
        '
        Me.bt_cursos_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cursos_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cursos_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cursos_eliminar.Image = Global.escuelaa.My.Resources.Resources._002_herramienta
        Me.bt_cursos_eliminar.Location = New System.Drawing.Point(537, 19)
        Me.bt_cursos_eliminar.Name = "bt_cursos_eliminar"
        Me.bt_cursos_eliminar.Size = New System.Drawing.Size(40, 42)
        Me.bt_cursos_eliminar.TabIndex = 16
        Me.bt_cursos_eliminar.UseVisualStyleBackColor = False
        '
        'bt_cursos_nuevo
        '
        Me.bt_cursos_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cursos_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cursos_nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cursos_nuevo.Image = Global.escuelaa.My.Resources.Resources.mas3
        Me.bt_cursos_nuevo.Location = New System.Drawing.Point(583, 19)
        Me.bt_cursos_nuevo.Name = "bt_cursos_nuevo"
        Me.bt_cursos_nuevo.Size = New System.Drawing.Size(40, 42)
        Me.bt_cursos_nuevo.TabIndex = 14
        Me.bt_cursos_nuevo.UseVisualStyleBackColor = False
        '
        'bt_cursos_salir
        '
        Me.bt_cursos_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cursos_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cursos_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cursos_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_cursos_salir.Location = New System.Drawing.Point(29, 19)
        Me.bt_cursos_salir.Name = "bt_cursos_salir"
        Me.bt_cursos_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_cursos_salir.TabIndex = 25
        Me.bt_cursos_salir.UseVisualStyleBackColor = False
        '
        'frm_cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_cursos_salir)
        Me.Controls.Add(Me.pl_cursos_nuevo)
        Me.Controls.Add(Me.bt_cursos_eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_cursos_nuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_cursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_cursos_nuevo.ResumeLayout(False)
        Me.pl_cursos_nuevo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cursos_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cursos_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_cursos_nuevo As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bt_cursos_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmb_cursos_buscar_division As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_cursos_buscar_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents bt_cursos_buscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pl_cursos_nuevo As System.Windows.Forms.Panel
    Friend WithEvents cmb_cursos_nuevo_division As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_cursos_nuevo_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cursos_nuevo_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents bt_cursos_salir As System.Windows.Forms.Button
End Class
