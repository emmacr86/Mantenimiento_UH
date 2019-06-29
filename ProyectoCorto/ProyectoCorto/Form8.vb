Imports Logica

Public Class FormNotas

    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewNotas.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelNotas.Text = "1"
        Else
            LabelNotas.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewNotas.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewNotas.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelNotas.Text = itemCount.ToString
            Else
                LabelNotas.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Function LimpiarEspacios()
        TextBoxNotas.Clear()
        TextBoxNotaFinal.Clear()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


    Private Sub TextBoxNotaFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNotaFinal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNotas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FormNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewNotas.DataSource = AccesoLogica.ObtenerInfoNotas()
        ActualizarID()
        ButtonActualizar.Visible = False
        Dim matricula As DataTable
        matricula = AccesoLogica.JoinComboboxNotas
        ComboBoxMatricula.DataSource = matricula
        ComboBoxMatricula.ValueMember = "id_matricula"
        ComboBoxMatricula.DisplayMember = "cuatrimestre"
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim notas As Integer = Convert.ToInt32(LabelNotas.Text)
        Dim matricula As Integer = Convert.ToInt32(ComboBoxMatricula.SelectedValue)
        Dim nota As Integer = Convert.ToInt32(TextBoxNotas.Text)
        Dim notaFinal As Integer = Convert.ToInt32(TextBoxNotaFinal.Text)
        Dim status As String = ComboBoxStatus.SelectedItem.ToString

        AccesoLogica.InsertarInfoNotas(notas, matricula, nota, notaFinal, status)
        DataGridViewNotas.DataSource = AccesoLogica.ObtenerInfoNotas()
        ActualizarID()
        LimpiarEspacios()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewNotas.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewNotas.CurrentCell.Value
            AccesoLogica.BorrarInfoNotas(x)
            DataGridViewNotas.DataSource = AccesoLogica.ObtenerInfoNotas()
            ActualizarID()
            LimpiarEspacios()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewNotas.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewNotas.CurrentRow.Index
            LabelNotas.Text = DataGridViewNotas.Item(0, i).Value
            ComboBoxMatricula.SelectedValue = DataGridViewNotas.Item(1, i).Value.ToString()
            TextBoxNotas.Text = DataGridViewNotas.Item(2, i).Value
            TextBoxNotaFinal.Text = DataGridViewNotas.Item(3, i).Value
            ComboBoxStatus.SelectedValue = DataGridViewNotas.Item(4, i).Value.ToString()

            DataGridViewNotas.DataSource = AccesoLogica.ObtenerInfoNotas()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True

        Dim notas As Integer = Convert.ToInt32(LabelNotas.Text)
        Dim matricula As Integer = Convert.ToInt32(ComboBoxMatricula.SelectedValue)
        Dim nota As Integer = Convert.ToInt32(TextBoxNotas.Text)
        Dim notaFinal As Integer = Convert.ToInt32(TextBoxNotaFinal.Text)
        Dim status As String = ComboBoxStatus.SelectedItem.ToString
        AccesoLogica.ActualizarInfoNotas(notas, matricula, nota, notaFinal, status)
        ActualizarID()
        LimpiarEspacios()
        DataGridViewNotas.DataSource = AccesoLogica.ObtenerInfoNotas()
    End Sub
End Class