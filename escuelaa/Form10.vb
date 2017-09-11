Public Class frm_alumnos


    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_alumnos_agregar.Click
        frm_alumnos_nuevo.ShowDialog()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub bt_alumnos_salir_Click(sender As Object, e As EventArgs) Handles bt_alumnos_salir.Click
        Me.Close()

    End Sub
End Class