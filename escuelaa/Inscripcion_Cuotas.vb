Public Class frm_alumnos_inscripcion_cuotas
    
   
    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_cuota_nueva_Click(sender As Object, e As EventArgs) Handles bt_cuota_nueva.Click
        pl_cuota_nueva.Enabled = True
    End Sub

    Private Sub bt_inscripcion_nueva_Click(sender As Object, e As EventArgs) Handles bt_inscripcion_nueva.Click
        pl_inscripcion_nueva.Enabled = True
    End Sub

    Private Sub bt_inscripcion_salir_Click(sender As Object, e As EventArgs) Handles bt_inscripcion_salir.Click
        Me.Close()

    End Sub
End Class