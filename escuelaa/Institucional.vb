Public Class frm_institucional

    Private Sub bt_cursos_Click(sender As Object, e As EventArgs) Handles bt_cursos.Click
        frm_cursos.ShowDialog()

    End Sub

    Private Sub bt_materias_Click(sender As Object, e As EventArgs) Handles bt_materias.Click
        frm_materias.ShowDialog()

    End Sub

    Private Sub bt_alumnos_Click(sender As Object, e As EventArgs) Handles bt_alumnos.Click
        frm_alumnos.ShowDialog()

    End Sub

    Private Sub bt_institucional_salir_Click(sender As Object, e As EventArgs) Handles bt_institucional_salir.Click
        Me.Close()

    End Sub
End Class