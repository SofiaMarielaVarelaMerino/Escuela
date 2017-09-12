Public Class frm_inicio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_profesores.Click
        frm_profesores.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bt_estadisticas.Click

    End Sub

    Private Sub frm_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_institucional_Click(sender As Object, e As EventArgs) Handles bt_institucional.Click
        frm_institucional.ShowDialog()

    End Sub
End Class
