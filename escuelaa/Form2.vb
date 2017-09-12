Public Class frm_profesores

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_profesor_nuevo.Click
        pl_nuevo_profesor.Enabled = True

    End Sub

    Private Sub bt_inasistencia_Click(sender As Object, e As EventArgs)
        frm_cargar_inasistencias.ShowDialog()

    End Sub


    Private Sub bt_cargar_nota_Click(sender As Object, e As EventArgs)
        frm_cargar_calificaciones.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pl_nuevo_profesor.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bt_profesor_materia_nueva.Click
        pl_materias_nuevo_profesor.Enabled = True

    End Sub

    Private Sub pl_cargar_botones_profesores_Paint(sender As Object, e As PaintEventArgs) Handles pl_cargar_botones_profesores.Paint

    End Sub

    Private Sub bt_buscar_profesor_Click(sender As Object, e As EventArgs) Handles bt_profesor_buscar.Click
        pl_cargar_botones_profesores.Visible = True
    End Sub

    Private Sub bt_inasistencia_Click_1(sender As Object, e As EventArgs) Handles bt_profesor_inasistencia.Click
        frm_cargar_inasistencias.ShowDialog()

    End Sub

    Private Sub bt_cargar_nota_Click_1(sender As Object, e As EventArgs) Handles bt_profesor_calificaciones.Click
        frm_cargar_calificaciones.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub pl_materias_nuevo_profesor_Paint(sender As Object, e As PaintEventArgs) Handles pl_materias_nuevo_profesor.Paint

    End Sub

    Private Sub bt_profesores_salir_Click(sender As Object, e As EventArgs) Handles bt_profesores_salir.Click
        Me.Close()

    End Sub
End Class