Public Class frm_cargar_calificaciones

    Private Sub frm_cargar_nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_calificaciones_aceptar.Click
        Me.Close()
    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_calificaciones_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_calificaciones_salir_Click(sender As Object, e As EventArgs) Handles bt_calificaciones_salir.Click
        Me.Close()

    End Sub
End Class