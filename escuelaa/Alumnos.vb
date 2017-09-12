Public Class frm_alumnos

    Enum validacion
        correcta
        erronea
    End Enum

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_alumnos_agregar.Click
        frm_alumnos_nuevo.ShowDialog()

    End Sub

    Private Function Validar() As validacion

        If Me.txt_alumnos_buscar_nombre.Text = "" Then
            If Me.txt_alumnos_buscar_apellido.Text = "" Then
                MsgBox("El nombre o Apellido del alumno está vacio", MsgBoxStyle.OkOnly, _
                       "Error de validación")

                Me.txt_alumnos_buscar_nombre.Focus()
                Return validacion.erronea
            End If
        Else
            Return validacion.correcta
        End If

    End Function

    Private Sub bt_alumnos_salir_Click(sender As Object, e As EventArgs) Handles bt_alumnos_salir.Click
        Me.Close()

    End Sub

    Private Sub grid_alumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_alumnos.CellContentClick

    End Sub

    Private Sub bt_alumnos_buscar_Click(sender As Object, e As EventArgs) Handles bt_alumnos_buscar.Click
        If Me.Validar() = validacion.correcta Then
            'buscar alumno
        End If

    End Sub
End Class