Imports Logica

Public Class FormMatricula

    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewMatricula.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelMatricula.Text = "1"
        Else
            LabelMatricula.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewMatricula.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewMatricula.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelMatricula.Text = itemCount.ToString
            Else
                LabelMatricula.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Sub FormMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewMatricula.DataSource = AccesoLogica.ObtenerInfoMatricula()
        ActualizarID()
        ButtonActualizar.Visible = False

        Dim estudiante As DataTable
        estudiante = AccesoLogica.JoinComboboxMatriculaEstudiantes
        ComboBoxEstudiante.DataSource = estudiante
        ComboBoxEstudiante.ValueMember = "id_cedula"
        ComboBoxEstudiante.DisplayMember = "nombre"

        Dim curso As DataTable
        curso = AccesoLogica.JoinComboboxMatriculaCursos
        ComboboxCurso.DataSource = curso
        ComboboxCurso.ValueMember = "id_curso"
        ComboboxCurso.DisplayMember = "nombre"

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim id_matricula As Integer = Convert.ToInt32(LabelMatricula.Text)
        Dim id_cedula As Integer = Convert.ToInt32(ComboBoxEstudiante.SelectedValue)
        Dim id_curso As Integer = Convert.ToInt32(ComboboxCurso.SelectedValue)
        Dim cuatrimestre As String = ComboBoxCuatrimestre.SelectedItem.ToString

        AccesoLogica.InsertarInfoMatricula(id_matricula, id_cedula, id_curso, DateTimePicker1.Value.Date, cuatrimestre)
        DataGridViewMatricula.DataSource = AccesoLogica.ObtenerInfoMatricula()
        ActualizarID()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewMatricula.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewMatricula.CurrentCell.Value
            AccesoLogica.BorrarInfoMatricula(x)
            DataGridViewMatricula.DataSource = AccesoLogica.ObtenerInfoMatricula()
            ActualizarID()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewMatricula.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewMatricula.CurrentRow.Index
            LabelMatricula.Text = DataGridViewMatricula.Item(0, i).Value
            ComboBoxEstudiante.SelectedValue = DataGridViewMatricula.Item(1, i).Value.ToString()
            ComboboxCurso.SelectedValue = DataGridViewMatricula.Item(2, i).Value.ToString()
            ComboBoxCuatrimestre.SelectedValue = DataGridViewMatricula.Item(4, i).Value.ToString()

            DataGridViewMatricula.DataSource = AccesoLogica.ObtenerInfoMatricula()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True

        Dim id_matricula As Integer = Convert.ToInt32(LabelMatricula.Text)
        Dim id_cedula As Integer = Convert.ToInt32(ComboBoxEstudiante.SelectedValue)
        Dim id_curso As Integer = Convert.ToInt32(ComboboxCurso.SelectedValue)
        Dim cuatrimestre As String = ComboBoxCuatrimestre.SelectedItem.ToString

        AccesoLogica.ActualizarInfoMatricula(id_matricula, id_cedula, id_curso, DateTimePicker1.Value.Date, cuatrimestre)
        ActualizarID()
        DataGridViewMatricula.DataSource = AccesoLogica.ObtenerInfoMatricula()
    End Sub
End Class