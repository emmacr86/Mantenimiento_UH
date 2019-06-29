Public Class FormInicio
    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMatricula.Click
        Dim Matricula = New FormMatricula()
        Matricula.ShowDialog()
    End Sub

    Private Sub ButtonCarreras_Click(sender As Object, e As EventArgs) Handles ButtonCarreras.Click
        Dim Carrera = New FormCarrera()
        Carrera.ShowDialog()
    End Sub

    Private Sub ButtonCursos_Click(sender As Object, e As EventArgs) Handles ButtonCursos.Click
        Dim Cursos = New FormCursos()
        Cursos.ShowDialog()
    End Sub

    Private Sub ButtonEstudiantes_Click(sender As Object, e As EventArgs) Handles ButtonEstudiantes.Click
        Dim Estudiantes = New FormEstudiantes()
        Estudiantes.ShowDialog()
    End Sub

    Private Sub ButtonHorarios_Click(sender As Object, e As EventArgs) Handles ButtonHorarios.Click
        Dim Horarios = New FormHorarios()
        Horarios.ShowDialog()
    End Sub

    Private Sub ButtonProfesores_Click(sender As Object, e As EventArgs) Handles ButtonProfesores.Click
        Dim Profesores = New FormProfesores()
        Profesores.ShowDialog()
    End Sub

    Private Sub ButtonCalificaciones_Click(sender As Object, e As EventArgs) Handles ButtonCalificaciones.Click
        Dim Notas = New FormNotas()
        Notas.ShowDialog()
    End Sub

    Private Sub ButtonSedes_Click(sender As Object, e As EventArgs) Handles ButtonSedes.Click
        Dim Sede = New FormSedes()
        Sede.ShowDialog()
    End Sub
End Class
