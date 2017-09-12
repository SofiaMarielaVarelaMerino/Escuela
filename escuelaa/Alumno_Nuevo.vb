Public Class frm_alumnos_nuevo

    Enum validacion
        correcta
        erronea
    End Enum

    Private Function Validar() As validacion

        'validar apellido alumno
        If Me.txt_alumno_nuevo_apellido.Text.Trim = "" Then
            MsgBox("El apellido del alumno está vacio", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_apellido.Focus()
            Return validacion.erronea
        End If

        'validar nombre alumno
        If Me.txt_alumno_nuevo_nombre.Text.Trim = "" Then
            MsgBox("El nombre del alumno está vacio", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_nombre.Focus()
            Return validacion.erronea
        End If

        'validar fecha de nacimiento
        If Me.dtp_alumno_nuevo_fecha_nac.Checked = False Then
            MsgBox("La fecha de nacimiento no fue seleccionada", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.dtp_alumno_nuevo_fecha_nac.Focus()
            Return validacion.erronea
        End If

        'validar apellido tutor
        If Me.txt_alumno_nuevo_tutor_apellido.Text.Trim = "" Then
            MsgBox("El apellido del tutor está vacio", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_tutor_apellido.Focus()
            Return validacion.erronea
        End If

        'validar nombre tutor
        If Me.txt_alumno_nuevo_tutor_nombre.Text.Trim = "" Then
            MsgBox("El nombre del tutor está vacio", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_tutor_nombre.Focus()
            Return validacion.erronea
        End If

        'validar tipo Documento tutor
        If Me.cmb_alumno_nuevo_tutor_tipo_doc.SelectedIndex = -1 Then
            MsgBox("El tipo de Documento del tutor no fue seleccionado", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.cmb_alumno_nuevo_tutor_tipo_doc.Focus()
            Return validacion.erronea
        End If

        'validar num documento tutor
        If Me.txt_alumno_nuevo_tutor_num_doc.Text.Trim = "" Then
            MsgBox("El numero de documento del tutor está vacio", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_tutor_num_doc.Focus()
            Return validacion.erronea
        End If

        'validar telefono tutor
        If Me.txt_alumno_nuevo_tutor_tel.Text.Trim = "" Then
            MsgBox("El telefono del tutor está vacio", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_tutor_tel.Focus()
            Return validacion.erronea
        End If

        'validar nivel del curso
        If Me.cmb_alumno_nuevo_nivel.SelectedIndex = -1 Then
            MsgBox("El nivel no fue seleccionado", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.cmb_alumno_nuevo_nivel.Focus()
            Return validacion.erronea
        End If

        'validar division del curso
        If Me.cmb_alumno_nuevo_division.SelectedIndex = -1 Then
            MsgBox("La division no fue seleccionado", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.cmb_alumno_nuevo_division.Focus()
            Return validacion.erronea
        End If

        'validar fecha de la amonestacion
        'no se valida porque generalemente el mismo dia que le ponen la amonestacion es el dia que la cargan

        'validar cantidad de la amonestacion
        If Me.txt_alumno_nuevo_amonestaciones_cantidad.Text.Trim = "" Then
            MsgBox("La cantidad está vacia", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_amonestaciones_cantidad.Focus()
            Return validacion.erronea
        End If

        'validar descripcion de la amonestacion
        If txt_alumno_nuevo_amonestaciones_descripcion.Text.Trim = "" Then
            MsgBox("La descripcion está vacia", MsgBoxStyle.OkOnly, "Error de Validacion")

            Me.txt_alumno_nuevo_amonestaciones_descripcion.Focus()
            Return validacion.erronea
        End If

        Return validacion.correcta
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_alumno_nuevo_aceptar.Click
        If Me.Validar() = validacion.correcta Then
            MsgBox("Todo ok", MsgBoxStyle.OkOnly, "OK")
        End If

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