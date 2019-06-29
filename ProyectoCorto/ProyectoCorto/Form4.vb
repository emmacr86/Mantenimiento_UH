Imports Logica

Public Class FormCursos

    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewCursos.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelIdentificacionCurso.Text = "1"
        Else
            LabelIdentificacionCurso.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewCursos.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewCursos.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelIdentificacionCurso.Text = itemCount.ToString
            Else
                LabelIdentificacionCurso.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Function LimpiarEspacios()
        TextBoxNombre.Clear()
        TextBoxDescripcion.Clear()
        TextBoxRequisito.Clear()
        TextBoxCosto.Clear()
        TextBoxCreditos.Clear()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


    Private Sub TextBoxCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCosto.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxCreditos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCreditos.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FormCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewCursos.DataSource = AccesoLogica.ObtenerInfoCursos()
        ActualizarID()
        ButtonActualizar.Visible = False

        Dim horarios As DataTable
        horarios = AccesoLogica.JoinComboboxCursosHorarios
        ComboBoxHorario.DataSource = horarios
        ComboBoxHorario.ValueMember = "id_horario"
        ComboBoxHorario.DisplayMember = "dia"

        Dim profesor As DataTable
        profesor = AccesoLogica.JoinComboboxCursosProfesor
        ComboBoxProfesor.DataSource = profesor
        ComboBoxProfesor.ValueMember = "id_profesor"
        ComboBoxProfesor.DisplayMember = "nombre"

        Dim carrera As DataTable
        carrera = AccesoLogica.JoinComboboxCursosCarreras
        ComboBoxCarrera.DataSource = carrera
        ComboBoxCarrera.ValueMember = "id_carrera"
        ComboBoxCarrera.DisplayMember = "nombre"

        Dim sede As DataTable
        sede = AccesoLogica.JoinComboboxCursosSede
        ComboBoxSede.DataSource = sede
        ComboBoxSede.ValueMember = "id_sede"
        ComboBoxSede.DisplayMember = "nombre"

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click

        Dim id_curso As Integer = Convert.ToInt32(LabelIdentificacionCurso.Text)
        Dim id_carrera As Integer = Convert.ToInt32(ComboBoxCarrera.SelectedValue)
        Dim id_horario As Integer = Convert.ToInt32(ComboBoxHorario.SelectedValue)
        Dim nombre As String = TextBoxNombre.Text
        Dim id_profesor As Integer = Convert.ToInt32(ComboBoxProfesor.SelectedValue)
        Dim descripcion As String = TextBoxDescripcion.Text
        Dim requisito As String = TextBoxRequisito.Text
        Dim id_sede As Integer = Convert.ToInt32(ComboBoxSede.SelectedValue)
        Dim costo As Integer = Convert.ToInt32(TextBoxCosto.Text)
        Dim creditos As Integer = Convert.ToInt32(TextBoxCreditos.Text)

        AccesoLogica.InsertarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos)
        DataGridViewCursos.DataSource = AccesoLogica.ObtenerInfoCursos()
        ActualizarID()
        LimpiarEspacios()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewCursos.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewCursos.CurrentCell.Value
            AccesoLogica.BorrarInfoCursos(x)
            DataGridViewCursos.DataSource = AccesoLogica.ObtenerInfoCursos()
            ActualizarID()
            LimpiarEspacios()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewCursos.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewCursos.CurrentRow.Index
            LabelIdentificacionCurso.Text = DataGridViewCursos.Item(0, i).Value
            ComboBoxCarrera.SelectedValue = DataGridViewCursos.Item(1, i).Value.ToString()
            ComboBoxHorario.SelectedValue = DataGridViewCursos.Item(2, i).Value.ToString()
            TextBoxNombre.Text = DataGridViewCursos.Item(3, i).Value
            ComboBoxProfesor.SelectedValue = DataGridViewCursos.Item(4, i).Value.ToString()
            TextBoxDescripcion.Text = DataGridViewCursos.Item(5, i).Value
            TextBoxRequisito.Text = DataGridViewCursos.Item(6, i).Value
            ComboBoxSede.SelectedValue = DataGridViewCursos.Item(7, i).Value.ToString()
            TextBoxCosto.Text = DataGridViewCursos.Item(8, i).Value
            TextBoxCreditos.Text = DataGridViewCursos.Item(9, i).Value

            DataGridViewCursos.DataSource = AccesoLogica.ObtenerInfoCursos()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True

        Dim id_curso As Integer = Convert.ToInt32(LabelIdentificacionCurso.Text)
        Dim id_carrera As Integer = Convert.ToInt32(ComboBoxCarrera.SelectedValue)
        Dim id_horario As Integer = Convert.ToInt32(ComboBoxHorario.SelectedValue)
        Dim nombre As String = TextBoxNombre.Text
        Dim id_profesor As Integer = Convert.ToInt32(ComboBoxProfesor.SelectedValue)
        Dim descripcion As String = TextBoxDescripcion.Text
        Dim requisito As String = TextBoxRequisito.Text
        Dim id_sede As Integer = Convert.ToInt32(ComboBoxSede.SelectedValue)
        Dim costo As Integer = Convert.ToInt32(TextBoxCosto.Text)
        Dim creditos As Integer = Convert.ToInt32(TextBoxCreditos.Text)

        AccesoLogica.ActualizarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos)
        ActualizarID()
        LimpiarEspacios()
        DataGridViewCursos.DataSource = AccesoLogica.ObtenerInfoCursos()
    End Sub
End Class