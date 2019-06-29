Imports Logica

Public Class FormCarrera
    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewCarreras.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelCarrera.Text = "1"
        Else
            LabelCarrera.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewCarreras.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewCarreras.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelCarrera.Text = itemCount.ToString
            Else
                LabelCarrera.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Function LimpiarEspacios()
        TextBoxNombre.Clear()
        TextBoxDescripcion.Clear()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


    Private Sub FormCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewCarreras.DataSource = AccesoLogica.ObtenerInfoCarreras()
        ActualizarID()
        ButtonActualizar.Visible = False
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim carrera As Integer = Convert.ToInt32(LabelCarrera.Text)
        AccesoLogica.InsertarInfoCarreras(carrera, TextBoxNombre.Text, TextBoxDescripcion.Text)
        DataGridViewCarreras.DataSource = AccesoLogica.ObtenerInfoCarreras()
        ActualizarID()
        LimpiarEspacios()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewCarreras.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewCarreras.CurrentCell.Value
            AccesoLogica.BorrarInfoCarreras(x)
            DataGridViewCarreras.DataSource = AccesoLogica.ObtenerInfoCarreras()
            ActualizarID()
            LimpiarEspacios()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewCarreras.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewCarreras.CurrentRow.Index
            LabelCarrera.Text = DataGridViewCarreras.Item(0, i).Value
            TextBoxNombre.Text = DataGridViewCarreras.Item(1, i).Value
            TextBoxDescripcion.Text = DataGridViewCarreras.Item(2, i).Value

            DataGridViewCarreras.DataSource = AccesoLogica.ObtenerInfoCarreras()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True
        Dim carrera As Integer = Convert.ToInt32(LabelCarrera.Text)
        AccesoLogica.ActualizarInfoCarreras(carrera, TextBoxNombre.Text, TextBoxDescripcion.Text)
        ActualizarID()
        LimpiarEspacios()
        DataGridViewCarreras.DataSource = AccesoLogica.ObtenerInfoCarreras()
    End Sub
End Class