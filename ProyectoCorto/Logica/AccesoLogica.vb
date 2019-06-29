Imports Datos
Public Class AccesoLogica

    '**************************************SEDES**************************************
    Public Shared Function InsertarInfoSede(id_sede, nombre, descripcion, direccion) As DataTable
        Return AccesoDatos.InsertarInfoSede(id_sede, nombre, descripcion, direccion)
    End Function

    Public Shared Function ObtenerInfoSede() As DataTable
        Return AccesoDatos.ObtenerInfoSede()
    End Function

    Public Shared Function BorrarInfoSede(id As String) As Integer
        Return AccesoDatos.BorrarInfoSede(id)
    End Function

    Public Shared Function ActualizarInfoSede(id_sede, nombre, descripcion, direccion) As DataTable
        Return AccesoDatos.ActualizarInfoSede(id_sede, nombre, descripcion, direccion)
    End Function

    '**************************************PROFESORES**************************************
    Public Shared Function InsertarInfoProfesores(id_profesor, nombre, apellido, correo, telefono) As DataTable
        Return AccesoDatos.InsertarInfoProfesores(id_profesor, nombre, apellido, correo, telefono)
    End Function

    Public Shared Function ObtenerInfoProfesores() As DataTable
        Return AccesoDatos.ObtenerInfoProfesores()
    End Function

    Public Shared Function BorrarInfoProfesores(id As String) As Integer
        Return AccesoDatos.BorrarInfoProfesores(id)
    End Function

    Public Shared Function ActualizarInfoProfesores(id_profesor, nombre, apellido, correo, telefono) As DataTable
        Return AccesoDatos.ActualizarInfoProfesores(id_profesor, nombre, apellido, correo, telefono)
    End Function

    '**************************************CARRERAS**************************************
    Public Shared Function InsertarInfoCarreras(id_carrera, nombre, descripcion) As DataTable
        Return AccesoDatos.InsertarInfoCarreras(id_carrera, nombre, descripcion)
    End Function

    Public Shared Function ObtenerInfoCarreras() As DataTable
        Return AccesoDatos.ObtenerInfoCarreras()
    End Function

    Public Shared Function BorrarInfoCarreras(id As String) As Integer
        Return AccesoDatos.BorrarInfoCarreras(id)
    End Function

    Public Shared Function ActualizarInfoCarreras(id_carrera, nombre, descripcion) As DataTable
        Return AccesoDatos.ActualizarInfoCarreras(id_carrera, nombre, descripcion)
    End Function

    '**************************************Estudiantes**************************************
    Public Shared Function InsertarInfoEstudiantes(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carerra) As DataTable
        Return AccesoDatos.InsertarInfoEstudiantes(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carerra)
    End Function

    Public Shared Function ObtenerInfoEstudiantes() As DataTable
        Return AccesoDatos.ObtenerInfoEstudiantes()
    End Function

    Public Shared Function BorrarInfoEstudiantes(id As String) As Integer
        Return AccesoDatos.BorrarInfoEstudiantes(id)
    End Function

    Public Shared Function ActualizarInfoEstudiantes(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carerra) As DataTable
        Return AccesoDatos.ActualizarInfoEstudiantes(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carerra)
    End Function

    Public Shared Function JoinComboboxEstudiantes() As DataTable
        Return AccesoDatos.JoinComboboxEstudiantes()
    End Function

    '**************************************NOTAS**************************************
    Public Shared Function InsertarInfoNotas(id_nota, id_matricula, notas, notas_finales, status) As DataTable
        Return AccesoDatos.InsertarInfoNotas(id_nota, id_matricula, notas, notas_finales, status)
    End Function

    Public Shared Function ObtenerInfoNotas() As DataTable
        Return AccesoDatos.ObtenerInfoNotas()
    End Function

    Public Shared Function BorrarInfoNotas(id As String) As Integer
        Return AccesoDatos.BorrarInfoNotas(id)
    End Function

    Public Shared Function ActualizarInfoNotas(id_nota, id_matricula, notas, notas_finales, status) As DataTable
        Return AccesoDatos.ActualizarInfoNotas(id_nota, id_matricula, notas, notas_finales, status)
    End Function

    Public Shared Function JoinComboboxNotas() As DataTable
        Return AccesoDatos.JoinComboboxNotas()
    End Function

    '**************************************Horarios**************************************
    Public Shared Function InsertarInfoHorarios(id_horario, id_carrera, dia, hora, id_sede) As DataTable
        Return AccesoDatos.InsertarInfoHorarios(id_horario, id_carrera, dia, hora, id_sede)
    End Function

    Public Shared Function ObtenerInfoHorarios() As DataTable
        Return AccesoDatos.ObtenerInfoHorarios()
    End Function

    Public Shared Function BorrarInfoHorarios(id As String) As Integer
        Return AccesoDatos.BorrarInfoHorarios(id)
    End Function

    Public Shared Function ActualizarInfoHorarios(id_horario, id_carrera, dia, hora, id_sede) As DataTable
        Return AccesoDatos.ActualizarInfoHorarios(id_horario, id_carrera, dia, hora, id_sede)
    End Function

    Public Shared Function JoinComboboxHorariosCarreras() As DataTable
        Return AccesoDatos.JoinComboboxHorariosCarreras()
    End Function

    Public Shared Function JoinComboboxHorariosSede() As DataTable
        Return AccesoDatos.JoinComboboxHorariosSede()
    End Function

    '**************************************Cursos**************************************
    Public Shared Function InsertarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos) As DataTable
        Return AccesoDatos.InsertarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos)
    End Function

    Public Shared Function ObtenerInfoCursos() As DataTable
        Return AccesoDatos.ObtenerInfoCursos()
    End Function

    Public Shared Function BorrarInfoCursos(id As String) As Integer
        Return AccesoDatos.BorrarInfoCursos(id)
    End Function

    Public Shared Function ActualizarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos) As DataTable
        Return AccesoDatos.ActualizarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos)
    End Function

    Public Shared Function JoinComboboxCursosCarreras() As DataTable
        Return AccesoDatos.JoinComboboxCursosCarreras()
    End Function

    Public Shared Function JoinComboboxCursosSede() As DataTable
        Return AccesoDatos.JoinComboboxCursosSede()
    End Function

    Public Shared Function JoinComboboxCursosHorarios() As DataTable
        Return AccesoDatos.JoinComboboxCursosHorarios()
    End Function

    Public Shared Function JoinComboboxCursosProfesor() As DataTable
        Return AccesoDatos.JoinComboboxCursosProfesor()
    End Function

    '**************************************Matricula**************************************
    Public Shared Function InsertarInfoMatricula(id_matricula, id_cedula, id_curso, anno, cuatrimestre) As DataTable
        Return AccesoDatos.InsertarInfoMatricula(id_matricula, id_cedula, id_curso, anno, cuatrimestre)
    End Function

    Public Shared Function ObtenerInfoMatricula() As DataTable
        Return AccesoDatos.ObtenerInfoMatricula()
    End Function

    Public Shared Function BorrarInfoMatricula(id As String) As Integer
        Return AccesoDatos.BorrarInfoMatricula(id)
    End Function

    Public Shared Function ActualizarInfoMatricula(id_matricula, id_cedula, id_curso, anno, cuatrimestre) As DataTable
        Return AccesoDatos.ActualizarInfoMatricula(id_matricula, id_cedula, id_curso, anno, cuatrimestre)
    End Function

    Public Shared Function JoinComboboxMatriculaEstudiantes() As DataTable
        Return AccesoDatos.JoinComboboxMatriculaEstudiantes()
    End Function

    Public Shared Function JoinComboboxMatriculaCursos() As DataTable
        Return AccesoDatos.JoinComboboxMatriculaCursos()
    End Function

End Class
