<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_institucional
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
        Me.bt_cursos = New System.Windows.Forms.Button()
        Me.bt_materias = New System.Windows.Forms.Button()
        Me.bt_alumnos = New System.Windows.Forms.Button()
        Me.bt_institucional_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "INSTITUCIONAL"
        '
        'bt_cursos
        '
        Me.bt_cursos.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cursos.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cursos.Location = New System.Drawing.Point(484, 268)
        Me.bt_cursos.Name = "bt_cursos"
        Me.bt_cursos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_cursos.Size = New System.Drawing.Size(396, 98)
        Me.bt_cursos.TabIndex = 16
        Me.bt_cursos.Text = "CURSOS"
        Me.bt_cursos.UseVisualStyleBackColor = False
        '
        'bt_materias
        '
        Me.bt_materias.BackColor = System.Drawing.SystemColors.Control
        Me.bt_materias.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_materias.Location = New System.Drawing.Point(484, 141)
        Me.bt_materias.Name = "bt_materias"
        Me.bt_materias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_materias.Size = New System.Drawing.Size(396, 98)
        Me.bt_materias.TabIndex = 15
        Me.bt_materias.Text = "MATERIAS"
        Me.bt_materias.UseVisualStyleBackColor = False
        '
        'bt_alumnos
        '
        Me.bt_alumnos.BackColor = System.Drawing.SystemColors.Control
        Me.bt_alumnos.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_alumnos.Location = New System.Drawing.Point(484, 393)
        Me.bt_alumnos.Name = "bt_alumnos"
        Me.bt_alumnos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_alumnos.Size = New System.Drawing.Size(396, 98)
        Me.bt_alumnos.TabIndex = 14
        Me.bt_alumnos.Text = "ALUMNOS"
        Me.bt_alumnos.UseVisualStyleBackColor = False
        '
        'bt_institucional_salir
        '
        Me.bt_institucional_salir.BackColor = System.Drawing.SystemColors.Control
        Me.bt_institucional_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_institucional_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_institucional_salir.Image = Global.escuelaa.My.Resources.Resources.SALIR11
        Me.bt_institucional_salir.Location = New System.Drawing.Point(27, 40)
        Me.bt_institucional_salir.Name = "bt_institucional_salir"
        Me.bt_institucional_salir.Size = New System.Drawing.Size(40, 42)
        Me.bt_institucional_salir.TabIndex = 25
        Me.bt_institucional_salir.UseVisualStyleBackColor = False
        '
        'frm_institucional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_institucional_salir)
        Me.Controls.Add(Me.bt_cursos)
        Me.Controls.Add(Me.bt_materias)
        Me.Controls.Add(Me.bt_alumnos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_institucional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_cursos As System.Windows.Forms.Button
    Friend WithEvents bt_materias As System.Windows.Forms.Button
    Friend WithEvents bt_alumnos As System.Windows.Forms.Button
    Friend WithEvents bt_institucional_salir As System.Windows.Forms.Button
End Class
