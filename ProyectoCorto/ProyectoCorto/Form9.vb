Imports Logica
Public Class FormSedes

    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewSedes.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelSede.Text = "1"
        Else
            LabelSede.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewSedes.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewSedes.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelSede.Text = itemCount.ToString
            Else
                LabelSede.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Function LimpiarEspacios()
        TextBoxNombre.Clear()
        TextBoxDescripcion.Clear()
        TextBoxDireccion.Clear()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim sede As Integer = Convert.ToInt32(LabelSede.Text)
        AccesoLogica.InsertarInfoSede(sede, TextBoxNombre.Text, TextBoxDescripcion.Text, TextBoxDireccion.Text)
        DataGridViewSedes.DataSource = AccesoLogica.ObtenerInfoSede()
        ActualizarID()
        LimpiarEspacios()
    End Sub

    Private Sub FormSedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewSedes.DataSource = AccesoLogica.ObtenerInfoSede()
        ActualizarID()
        ButtonActualizar.Visible = False
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewSedes.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewSedes.CurrentCell.Value
            AccesoLogica.BorrarInfoSede(x)
            DataGridViewSedes.DataSource = AccesoLogica.ObtenerInfoSede()
            ActualizarID()
            LimpiarEspacios()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If

    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click

        If DataGridViewSedes.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewSedes.CurrentRow.Index
            LabelSede.Text = DataGridViewSedes.Item(0, i).Value
            TextBoxNombre.Text = DataGridViewSedes.Item(1, i).Value
            TextBoxDescripcion.Text = DataGridViewSedes.Item(2, i).Value
            TextBoxDireccion.Text = DataGridViewSedes.Item(3, i).Value

            DataGridViewSedes.DataSource = AccesoLogica.ObtenerInfoSede()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click

        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True
        Dim sede As Integer = Convert.ToInt32(LabelSede.Text)
        AccesoLogica.ActualizarInfoSede(sede, TextBoxNombre.Text, TextBoxDescripcion.Text, TextBoxDireccion.Text)
        ActualizarID()
        LimpiarEspacios()
        DataGridViewSedes.DataSource = AccesoLogica.ObtenerInfoSede()
    End Sub
End Class