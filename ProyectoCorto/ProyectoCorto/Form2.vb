Imports Logica

Public Class FormEstudiantes

    Function LimpiarEspacios()
        TextBoxCedula.Clear()
        TextBoxNombre.Clear()
        TextBoxApellido.Clear()
        TextBoxDireccion.Clear()
        TextBoxTelefono.Clear()
        TextBoxCelular.Clear()
        TextBoxCorreo.Clear()
        ComboBoxCarrera.Refresh()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Sub TextBoxCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCedula.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelefono.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCelular.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FormEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewEstudiantes.DataSource = AccesoLogica.ObtenerInfoEstudiantes()
        ButtonActualizar.Visible = False

        Dim carreras As DataTable
        carreras = AccesoLogica.JoinComboboxEstudiantes
        ComboBoxCarrera.DataSource = carreras
        ComboBoxCarrera.ValueMember = "id_carrera"
        ComboBoxCarrera.DisplayMember = "nombre"

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim cedula As Integer = Convert.ToInt32(TextBoxCedula.Text)
        Dim carrera As Integer = Convert.ToInt32(ComboBoxCarrera.SelectedValue)
        Dim telefono As Integer = Convert.ToInt32(TextBoxTelefono.Text)
        Dim celular As Integer = Convert.ToInt32(TextBoxCelular.Text)
        AccesoLogica.InsertarInfoEstudiantes(cedula, TextBoxNombre.Text, TextBoxApellido.Text, TextBoxDireccion.Text, telefono, celular, TextBoxCorreo.Text, carrera)
        DataGridViewEstudiantes.DataSource = AccesoLogica.ObtenerInfoEstudiantes()
        LimpiarEspacios()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewEstudiantes.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewEstudiantes.CurrentCell.Value
            AccesoLogica.BorrarInfoEstudiantes(x)
            DataGridViewEstudiantes.DataSource = AccesoLogica.ObtenerInfoEstudiantes()
            LimpiarEspacios()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewEstudiantes.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewEstudiantes.CurrentRow.Index
            TextBoxCedula.Text = DataGridViewEstudiantes.Item(0, i).Value
            TextBoxNombre.Text = DataGridViewEstudiantes.Item(1, i).Value
            TextBoxApellido.Text = DataGridViewEstudiantes.Item(2, i).Value
            TextBoxDireccion.Text = DataGridViewEstudiantes.Item(3, i).Value
            TextBoxTelefono.Text = DataGridViewEstudiantes.Item(4, i).Value
            TextBoxCelular.Text = DataGridViewEstudiantes.Item(5, i).Value
            TextBoxCorreo.Text = DataGridViewEstudiantes.Item(6, i).Value
            ComboBoxCarrera.SelectedValue = DataGridViewEstudiantes.Item(7, i).Value.ToString()

            DataGridViewEstudiantes.DataSource = AccesoLogica.ObtenerInfoEstudiantes()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True
        Dim cedula As Integer = Convert.ToInt32(TextBoxCedula.Text)
        Dim carrera As Integer = Convert.ToInt32(ComboBoxCarrera.SelectedValue)
        Dim telefono As Integer = Convert.ToInt32(TextBoxTelefono.Text)
        Dim celular As Integer = Convert.ToInt32(TextBoxCelular.Text)
        AccesoLogica.ActualizarInfoEstudiantes(cedula, TextBoxNombre.Text, TextBoxApellido.Text, TextBoxDireccion.Text, telefono, celular, TextBoxCorreo.Text, carrera)
        LimpiarEspacios()
        DataGridViewEstudiantes.DataSource = AccesoLogica.ObtenerInfoEstudiantes()
    End Sub
End Class