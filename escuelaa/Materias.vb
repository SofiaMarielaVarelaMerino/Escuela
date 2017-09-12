Public Class frm_materias
    Dim cadena_Conexion As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sofiv\Source\Repos\Escuela\escuelaa\Database.mdf;Integrated Security=True"
    Enum validacion
        correcta
        erronea
    End Enum

    Private Sub frm_materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.carga_Grilla()
        Me.carga_Combo(cmb_materias_nueva_nivel, leo_Tabla("Curso"), "nivel", "cod_curso")
        Me.carga_Combo(cmb_materias_nueva_division, leo_Tabla("Curso"), "division", "cod_curso")
    End Sub

    Private Sub bt_materias_nueva_Click(sender As Object, e As EventArgs) Handles bt_materias_nueva.Click
        pl_materias_nueva.Enabled = True
    End Sub

    Private Sub carga_Combo(ByRef combo As ComboBox, ByRef tabla As DataTable, descriptor As String, pk As String)
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub
    Private Function leo_Tabla(ByVal nombre_tabla As String) As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable


        conexion.ConnectionString = cadena_Conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " & nombre_tabla
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function

    Private Function validar() As validacion

        If cmb_materias_nueva_nivel.SelectedIndex = -1 Then
            MessageBox.Show("El Nivel esta sin seleccion", "Error de validacion", MessageBoxButtons.OK)
            Me.cmb_materias_nueva_nivel.Focus()
            Return validacion.erronea
        End If

        If cmb_materias_nueva_division.SelectedIndex = -1 Then
            MessageBox.Show("La division esta sin seleccion", "Error de validacion", MessageBoxButtons.OK)
            Me.cmb_materias_nueva_division.Focus()
            Return validacion.erronea
        End If

        If cmb_materias_nueva_profesor.SelectedIndex = -1 Then
            MessageBox.Show("El profesor esta sin seleccion", "Error de validacion", MessageBoxButtons.OK)
            Me.cmb_materias_nueva_profesor.Focus()
            Return validacion.erronea
        End If

        Return validacion.correcta
    End Function

    Private Sub bt_materias_salir_Click(sender As Object, e As EventArgs) Handles bt_materias_salir.Click
        Me.Close()

    End Sub



End Class