Public Class frm_alumnos_nuevo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_alumno_nuevo_aceptar.Click
        Me.Close()

    End Sub

    Private Sub bt_alumno_nuevo_amonestaciones_nueva_Click(sender As Object, e As EventArgs) Handles bt_alumno_nuevo_amonestaciones_nueva.Click
        pl_alumno_nuevo_amonestaciones.Enabled = True

    End Sub

    Private Sub bt_alumno_nuevo_inscripcion_Click(sender As Object, e As EventArgs) Handles bt_alumno_nuevo_inscripcion.Click
        frm_alumnos_inscripcion_cuotas.ShowDialog()


    End Sub

    Private Sub bt_alumno_nuevo_cuota_Click(sender As Object, e As EventArgs) Handles bt_alumno_nuevo_cuota.Click
        frm_alumnos_inscripcion_cuotas.ShowDialog()


    End Sub

    Private Sub bt_alumnos_nuevo_salir_Click(sender As Object, e As EventArgs) Handles bt_alumnos_nuevo_salir.Click
        Me.Close()

    End Sub
End Class