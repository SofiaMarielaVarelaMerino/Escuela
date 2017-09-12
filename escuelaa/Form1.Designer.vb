<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inicio
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
        Me.bt_estadisticas = New System.Windows.Forms.Button()
        Me.bt_reportes = New System.Windows.Forms.Button()
        Me.bt_institucional = New System.Windows.Forms.Button()
        Me.bt_profesores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_estadisticas
        '
        Me.bt_estadisticas.BackColor = System.Drawing.SystemColors.Control
        Me.bt_estadisticas.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_estadisticas.Image = Global.escuelaa.My.Resources.Resources._007_estadisticas
        Me.bt_estadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_estadisticas.Location = New System.Drawing.Point(723, 341)
        Me.bt_estadisticas.Name = "bt_estadisticas"
        Me.bt_estadisticas.Size = New System.Drawing.Size(396, 131)
        Me.bt_estadisticas.TabIndex = 3
        Me.bt_estadisticas.Text = "ESTADISTICAS"
        Me.bt_estadisticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_estadisticas.UseVisualStyleBackColor = False
        '
        'bt_reportes
        '
        Me.bt_reportes.BackColor = System.Drawing.SystemColors.Control
        Me.bt_reportes.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reportes.Image = Global.escuelaa.My.Resources.Resources._005_padnote
        Me.bt_reportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_reportes.Location = New System.Drawing.Point(723, 153)
        Me.bt_reportes.Name = "bt_reportes"
        Me.bt_reportes.Size = New System.Drawing.Size(396, 131)
        Me.bt_reportes.TabIndex = 2
        Me.bt_reportes.Text = "REPORTES"
        Me.bt_reportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_reportes.UseVisualStyleBackColor = False
        '
        'bt_institucional
        '
        Me.bt_institucional.BackColor = System.Drawing.SystemColors.Control
        Me.bt_institucional.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_institucional.Image = Global.escuelaa.My.Resources.Resources._003_ajustes
        Me.bt_institucional.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_institucional.Location = New System.Drawing.Point(208, 341)
        Me.bt_institucional.Name = "bt_institucional"
        Me.bt_institucional.Size = New System.Drawing.Size(396, 131)
        Me.bt_institucional.TabIndex = 1
        Me.bt_institucional.Text = "INSTITUCIONAL"
        Me.bt_institucional.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_institucional.UseVisualStyleBackColor = False
        '
        'bt_profesores
        '
        Me.bt_profesores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bt_profesores.BackColor = System.Drawing.SystemColors.Control
        Me.bt_profesores.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_profesores.Image = Global.escuelaa.My.Resources.Resources.perfil_grande
        Me.bt_profesores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_profesores.Location = New System.Drawing.Point(208, 153)
        Me.bt_profesores.Name = "bt_profesores"
        Me.bt_profesores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_profesores.Size = New System.Drawing.Size(396, 131)
        Me.bt_profesores.TabIndex = 0
        Me.bt_profesores.Text = "PROFESORES"
        Me.bt_profesores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_profesores.UseVisualStyleBackColor = False
        '
        'frm_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 666)
        Me.Controls.Add(Me.bt_estadisticas)
        Me.Controls.Add(Me.bt_reportes)
        Me.Controls.Add(Me.bt_institucional)
        Me.Controls.Add(Me.bt_profesores)
        Me.Name = "frm_inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmaculada Concepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_profesores As System.Windows.Forms.Button
    Friend WithEvents bt_institucional As System.Windows.Forms.Button
    Friend WithEvents bt_reportes As System.Windows.Forms.Button
    Friend WithEvents bt_estadisticas As System.Windows.Forms.Button

End Class
