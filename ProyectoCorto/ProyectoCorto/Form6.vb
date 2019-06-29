Imports Logica

Public Class FormHorarios

    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewHorarios.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelHorarios.Text = "1"
        Else
            LabelHorarios.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewHorarios.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewHorarios.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelHorarios.Text = itemCount.ToString
            Else
                LabelHorarios.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Sub FormHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewHorarios.DataSource = AccesoLogica.ObtenerInfoHorarios()
        ActualizarID()
        ButtonActualizar.Visible = False
        Dim carreras As DataTable
        carreras = AccesoLogica.JoinComboboxHorariosCarreras
        Dim sedes As DataTable
        sedes = AccesoLogica.JoinComboboxHorariosSede
        ComboBoxCarrera.DataSource = carreras
        ComboBoxCarrera.ValueMember = "id_carrera"
        ComboBoxCarrera.DisplayMember = "nombre"
        ComboBoxSede.DataSource = sedes
        ComboBoxSede.ValueMember = "id_sede"
        ComboBoxSede.DisplayMember = "nombre"

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim horario As Integer = Convert.ToInt32(LabelHorarios.Text)
        Dim carrera As Integer = Convert.ToInt32(ComboBoxCarrera.SelectedValue)
        Dim dia As String = ComboBoxDias.SelectedItem.ToString
        Dim horas As String = ComboBoxHoras.SelectedItem.ToString
        Dim sede As Integer = Convert.ToInt32(ComboBoxSede.SelectedValue)

        AccesoLogica.InsertarInfoHorarios(horario, carrera, dia, horas, sede)
        DataGridViewHorarios.DataSource = AccesoLogica.ObtenerInfoHorarios()
        ActualizarID()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewHorarios.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewHorarios.CurrentCell.Value
            AccesoLogica.BorrarInfoHorarios(x)
            DataGridViewHorarios.DataSource = AccesoLogica.ObtenerInfoHorarios()
            ActualizarID()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewHorarios.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewHorarios.CurrentRow.Index
            LabelHorarios.Text = DataGridViewHorarios.Item(0, i).Value
            ComboBoxCarrera.SelectedValue = DataGridViewHorarios.Item(1, i).Value.ToString()
            ComboBoxDias.SelectedValue = DataGridViewHorarios.Item(2, i).Value.ToString()
            ComboBoxHoras.SelectedValue = DataGridViewHorarios.Item(3, i).Value.ToString()
            ComboBoxSede.SelectedValue = DataGridViewHorarios.Item(4, i).Value.ToString()

            DataGridViewHorarios.DataSource = AccesoLogica.ObtenerInfoHorarios()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True

        Dim horario As Integer = Convert.ToInt32(LabelHorarios.Text)
        Dim carrera As Integer = Convert.ToInt32(ComboBoxCarrera.SelectedValue)
        Dim dia As String = ComboBoxDias.SelectedItem.ToString
        Dim hora As String = ComboBoxHoras.SelectedItem.ToString
        Dim sede As String = Convert.ToInt32(ComboBoxSede.SelectedValue)
        AccesoLogica.ActualizarInfoHorarios(horario, carrera, dia, hora, sede)
        ActualizarID()
        DataGridViewHorarios.DataSource = AccesoLogica.ObtenerInfoHorarios()
    End Sub
End Class