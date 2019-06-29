Imports Logica
Public Class FormProfesores

    Function ActualizarID()
        Dim itemCount As Integer
        For i As Integer = 0 To DataGridViewProfesores.Rows.Count - 1
            itemCount = itemCount + 1
        Next
        If itemCount = 0 Then
            LabelProfesor.Text = "1"
        Else
            LabelProfesor.Text = itemCount.ToString
        End If

        For i As Integer = 0 To DataGridViewProfesores.Rows.Count - 1
            If itemCount = Convert.ToInt32(DataGridViewProfesores.Rows(i).Cells(0).Value) Then
                itemCount = itemCount + 1
                LabelProfesor.Text = itemCount.ToString
            Else
                LabelProfesor.Text = itemCount.ToString
            End If
        Next

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Function LimpiarEspacios()
        TextBoxNombre.Clear()
        TextBoxApellido.Clear()
        TextBoxCorreo.Clear()
        TextBoxTelefono.Clear()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


    Private Sub TextBoxTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelefono.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FormProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewProfesores.DataSource = AccesoLogica.ObtenerInfoProfesores()
        ActualizarID()
        ButtonActualizar.Visible = False
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim profesor As Integer = Convert.ToInt32(LabelProfesor.Text)
        Dim telefono As Integer = Convert.ToInt32(TextBoxTelefono.Text)
        AccesoLogica.InsertarInfoProfesores(profesor, TextBoxNombre.Text, TextBoxApellido.Text, TextBoxCorreo.Text, telefono)
        DataGridViewProfesores.DataSource = AccesoLogica.ObtenerInfoProfesores()
        ActualizarID()
        LimpiarEspacios()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridViewProfesores.SelectedRows.Count > 0 Then
            Dim x As Integer
            x = DataGridViewProfesores.CurrentCell.Value
            AccesoLogica.BorrarInfoProfesores(x)
            DataGridViewProfesores.DataSource = AccesoLogica.ObtenerInfoProfesores()
            ActualizarID()
            LimpiarEspacios()
        Else
            MessageBox.Show("Seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridViewProfesores.SelectedRows.Count > 0 Then

            ButtonEliminar.Visible = False
            ButtonActualizar.Visible = True
            ButtonIngresar.Visible = False
            ButtonModificar.Visible = False

            Dim i = DataGridViewProfesores.CurrentRow.Index
            LabelProfesor.Text = DataGridViewProfesores.Item(0, i).Value
            TextBoxNombre.Text = DataGridViewProfesores.Item(1, i).Value
            TextBoxApellido.Text = DataGridViewProfesores.Item(2, i).Value
            TextBoxCorreo.Text = DataGridViewProfesores.Item(3, i).Value
            TextBoxTelefono.Text = DataGridViewProfesores.Item(4, i).Value

            DataGridViewProfesores.DataSource = AccesoLogica.ObtenerInfoProfesores()
        Else
            MessageBox.Show("Seleccione una fila para modificar")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonEliminar.Visible = True
        ButtonActualizar.Visible = False
        ButtonIngresar.Visible = True
        ButtonModificar.Visible = True
        Dim profesor As Integer = Convert.ToInt32(LabelProfesor.Text)
        Dim telefono As Integer = Convert.ToInt32(TextBoxTelefono.Text)
        AccesoLogica.ActualizarInfoProfesores(profesor, TextBoxNombre.Text, TextBoxApellido.Text, TextBoxCorreo.Text, telefono)
        ActualizarID()
        LimpiarEspacios()
        DataGridViewProfesores.DataSource = AccesoLogica.ObtenerInfoProfesores()
    End Sub
End Class