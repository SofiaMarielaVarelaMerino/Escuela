Public Class frm_cursos

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub bt_cursos_nuevo_Click(sender As Object, e As EventArgs) Handles bt_cursos_nuevo.Click
        pl_cursos_nuevo.Enabled = True
    End Sub

    Private Sub bt_cursos_aceptar_Click(sender As Object, e As EventArgs) Handles bt_cursos_aceptar.Click

    End Sub

    Private Sub bt_cursos_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cursos_cancelar.Click

    End Sub

    Private Sub bt_cursos_salir_Click(sender As Object, e As EventArgs) Handles bt_cursos_salir.Click
        Me.Close()

    End Sub
End Class