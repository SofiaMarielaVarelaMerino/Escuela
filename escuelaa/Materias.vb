Public Class frm_materias

    Private Sub bt_materias_nueva_Click(sender As Object, e As EventArgs) Handles bt_materias_nueva.Click
        pl_materias_nueva.Enabled = True
    End Sub

    Private Sub bt_materias_salir_Click(sender As Object, e As EventArgs) Handles bt_materias_salir.Click
        Me.Close()

    End Sub
End Class