Imports System.Data.SqlClient
Imports System.Data
Public Class AccesoDatos

    '**************************************SEDES**************************************
    Public Shared Function InsertarInfoSede(id_sede, nombre, descripcion, direccion) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into sede values (@id_sede, @nombre,@descripcion,@direccion)"

        comandoInsertar.Parameters.Add("@id_sede", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@direccion", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_sede").Value = Convert.ToInt32(id_sede)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@descripcion").Value = descripcion
        comandoInsertar.Parameters("@direccion").Value = direccion

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoSede() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM sede"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoSede(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM sede where id_sede =@id_sede"
        _comando.Parameters.Add("@id_sede", SqlDbType.NVarChar)
        _comando.Parameters("@id_sede").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoSede(id_sede, nombre, descripcion, direccion) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update sede set nombre = @nombre, descripcion = @descripcion, direccion = @direccion where id_sede = @id_sede"

        comandoInsertar.Parameters.Add("@id_sede", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@direccion", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_sede").Value = Convert.ToInt32(id_sede)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@descripcion").Value = descripcion
        comandoInsertar.Parameters("@direccion").Value = direccion

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    '**************************************PROFESORES**************************************

    Public Shared Function InsertarInfoProfesores(id_profesor, nombre, apellido, correo, telefono) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into profesores values (@id_profesor, @nombre, @apellido, @correo, @telefono)"

        comandoInsertar.Parameters.Add("@id_profesor", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@apellido", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@correo", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@telefono", SqlDbType.Int)

        comandoInsertar.Parameters("@id_profesor").Value = Convert.ToInt32(id_profesor)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@apellido").Value = apellido
        comandoInsertar.Parameters("@correo").Value = correo
        comandoInsertar.Parameters("@telefono").Value = Convert.ToInt32(telefono)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoProfesores() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM profesores"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoProfesores(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM profesores where id_profesor =@id_profesor"
        _comando.Parameters.Add("@id_profesor", SqlDbType.NVarChar)
        _comando.Parameters("@id_profesor").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoProfesores(id_profesor, nombre, apellido, correo, telefono) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update profesores set nombre = @nombre, apellido = @apellido, correo = @correo, telefono = @telefono where id_profesor = @id_profesor"

        comandoInsertar.Parameters.Add("@id_profesor", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@apellido", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@correo", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@telefono", SqlDbType.Int)

        comandoInsertar.Parameters("@id_profesor").Value = Convert.ToInt32(id_profesor)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@apellido").Value = apellido
        comandoInsertar.Parameters("@correo").Value = correo
        comandoInsertar.Parameters("@telefono").Value = Convert.ToInt32(telefono)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    '**************************************CARRERAS**************************************
    Public Shared Function InsertarInfoCarreras(id_carrera, nombre, descripcion) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into carreras values (@id_carrera, @nombre, @descripcion)"

        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@descripcion", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carrera)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@descripcion").Value = descripcion

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoCarreras() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM carreras"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoCarreras(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM carreras where id_carrera =@id_carrera"
        _comando.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        _comando.Parameters("@id_carrera").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoCarreras(id_carrera, nombre, descripcion) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update carreras set nombre = @nombre, descripcion = @descripcion where id_carrera = @id_carrera"

        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@descripcion", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carrera)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@descripcion").Value = descripcion

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    '**************************************ESTUDIANTES**************************************
    Public Shared Function InsertarInfoEstudiantes(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carerra) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into estudiantes values (@id_cedula, @nombre,@apellido,@direccion, @telefono, @celular, @correo, @id_carrera)"

        comandoInsertar.Parameters.Add("@id_cedula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@apellido", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@direccion", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@telefono", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@celular", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@correo", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)

        comandoInsertar.Parameters("@id_cedula").Value = Convert.ToInt32(id_cedula)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@apellido").Value = apellido
        comandoInsertar.Parameters("@direccion").Value = direccion
        comandoInsertar.Parameters("@telefono").Value = Convert.ToInt32(telefono)
        comandoInsertar.Parameters("@celular").Value = Convert.ToInt32(celular)
        comandoInsertar.Parameters("@correo").Value = correo
        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carerra)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoEstudiantes() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM estudiantes"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoEstudiantes(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM estudiantes where id_cedula =@id_cedula"
        _comando.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        _comando.Parameters("@id_cedula").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoEstudiantes(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carerra) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update estudiantes set nombre = @nombre, apellido = @apellido, direccion = @direccion, telefono = @telefono, celular = @celular, correo = @correo, id_carrera = @id_carrera where id_cedula = @id_cedula"

        comandoInsertar.Parameters.Add("@id_cedula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@apellido", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@direccion", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@telefono", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@celular", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@correo", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)

        comandoInsertar.Parameters("@id_cedula").Value = Convert.ToInt32(id_cedula)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@apellido").Value = apellido
        comandoInsertar.Parameters("@direccion").Value = direccion
        comandoInsertar.Parameters("@telefono").Value = Convert.ToInt32(telefono)
        comandoInsertar.Parameters("@celular").Value = Convert.ToInt32(celular)
        comandoInsertar.Parameters("@correo").Value = correo
        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carerra)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function JoinComboboxEstudiantes() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_carrera, L.nombre" &
                       " FROM carreras L" &
                       " FULL JOIN estudiantes R ON L.id_carrera = R.id_carrera"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    '**************************************NOTAS**************************************
    Public Shared Function InsertarInfoNotas(id_nota, id_matricula, notas, notas_finales, status) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into notas values (@id_nota, @id_matricula,@notas,@nota_final, @status)"

        comandoInsertar.Parameters.Add("@id_nota", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_matricula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@notas", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nota_final", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@status", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_nota").Value = Convert.ToInt32(id_nota)
        comandoInsertar.Parameters("@id_matricula").Value = Convert.ToInt32(id_matricula)
        comandoInsertar.Parameters("@notas").Value = Convert.ToInt32(notas)
        comandoInsertar.Parameters("@nota_final").Value = Convert.ToInt32(notas_finales)
        comandoInsertar.Parameters("@status").Value = status

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoNotas() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM notas"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoNotas(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM notas where id_nota =@id_nota"
        _comando.Parameters.Add("@id_nota", SqlDbType.NVarChar)
        _comando.Parameters("@id_nota").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoNotas(id_nota, id_matricula, notas, notas_finales, status) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update notas set id_matricula = @id_matricula, notas = @notas, nota_final = @nota_final, status = @status where id_nota = @id_nota"

        comandoInsertar.Parameters.Add("@id_nota", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_matricula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@notas", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@nota_final", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@status", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_nota").Value = Convert.ToInt32(id_nota)
        comandoInsertar.Parameters("@id_matricula").Value = Convert.ToInt32(id_matricula)
        comandoInsertar.Parameters("@notas").Value = Convert.ToInt32(notas)
        comandoInsertar.Parameters("@nota_final").Value = Convert.ToInt32(notas_finales)
        comandoInsertar.Parameters("@status").Value = status

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function JoinComboboxNotas() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_matricula, L.cuatrimestre" &
                       " FROM matricula L" &
                       " LEFT JOIN notas R ON L.id_matricula = R.id_matricula"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    '**************************************Horarios**************************************
    Public Shared Function InsertarInfoHorarios(id_horario, id_carrera, dia, hora, id_sede) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into horarios values (@id_horario, @id_carrera,@dia,@hora, @id_sede)"

        comandoInsertar.Parameters.Add("@id_horario", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@dia", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@hora", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_sede", SqlDbType.Int)

        comandoInsertar.Parameters("@id_horario").Value = Convert.ToInt32(id_horario)
        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carrera)
        comandoInsertar.Parameters("@dia").Value = dia
        comandoInsertar.Parameters("@hora").Value = hora
        comandoInsertar.Parameters("@id_sede").Value = Convert.ToInt32(id_sede)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoHorarios() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM horarios"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoHorarios(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM horarios where id_horario =@id_horario"
        _comando.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        _comando.Parameters("@id_horario").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoHorarios(id_horario, id_carrera, dia, hora, id_sede) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update horarios set id_carrera = @id_carrera, dia = @dia, hora = @hora, id_sede = @id_sede where id_horario = @id_horario"

        comandoInsertar.Parameters.Add("@id_horario", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@dia", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@hora", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_sede", SqlDbType.Int)

        comandoInsertar.Parameters("@id_horario").Value = Convert.ToInt32(id_horario)
        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carrera)
        comandoInsertar.Parameters("@dia").Value = dia
        comandoInsertar.Parameters("@hora").Value = hora
        comandoInsertar.Parameters("@id_sede").Value = Convert.ToInt32(id_sede)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function JoinComboboxHorariosCarreras() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_carrera, L.nombre" &
                       " FROM carreras L" &
                       " LEFT JOIN horarios R ON L.id_carrera = R.id_carrera"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function JoinComboboxHorariosSede() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_sede, L.nombre" &
                       " FROM sede L" &
                       " LEFT JOIN horarios R ON L.id_sede = R.id_sede"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    '**************************************Cursos**************************************
    Public Shared Function InsertarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into cursos values (@id_curso, @id_carrera,@id_horario,@nombre, @id_profesor, @descripcion, @requisito, @id_sede, @costo, @creditos)"

        comandoInsertar.Parameters.Add("@id_curso", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_profesor", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@requisito", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_sede", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@costo", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@creditos", SqlDbType.Int)

        comandoInsertar.Parameters("@id_curso").Value = Convert.ToInt32(id_curso)
        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carrera)
        comandoInsertar.Parameters("@id_horario").Value = Convert.ToInt32(id_horario)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@id_profesor").Value = Convert.ToInt32(id_profesor)
        comandoInsertar.Parameters("@descripcion").Value = descripcion
        comandoInsertar.Parameters("@requisito").Value = requisito
        comandoInsertar.Parameters("@id_sede").Value = Convert.ToInt32(id_sede)
        comandoInsertar.Parameters("@costo").Value = Convert.ToInt32(costo)
        comandoInsertar.Parameters("@creditos").Value = Convert.ToInt32(creditos)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoCursos() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM cursos"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoCursos(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM cursos where id_curso =@id_curso"
        _comando.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        _comando.Parameters("@id_curso").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoCursos(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update cursos set id_carrera = @id_carrera, id_horario = @id_horario, nombre = @nombre, id_profesor = @id_profesor, descripcion = @descripcion, requisito = @requisito, id_sede = @id_sede, costo = @costo, creditos = @creditos where id_curso = @id_curso"

        comandoInsertar.Parameters.Add("@id_curso", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_carrera", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_profesor", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@requisito", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@id_sede", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@costo", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@creditos", SqlDbType.Int)

        comandoInsertar.Parameters("@id_curso").Value = Convert.ToInt32(id_curso)
        comandoInsertar.Parameters("@id_carrera").Value = Convert.ToInt32(id_carrera)
        comandoInsertar.Parameters("@id_horario").Value = Convert.ToInt32(id_horario)
        comandoInsertar.Parameters("@nombre").Value = nombre
        comandoInsertar.Parameters("@id_profesor").Value = Convert.ToInt32(id_profesor)
        comandoInsertar.Parameters("@descripcion").Value = descripcion
        comandoInsertar.Parameters("@requisito").Value = requisito
        comandoInsertar.Parameters("@id_sede").Value = Convert.ToInt32(id_sede)
        comandoInsertar.Parameters("@costo").Value = Convert.ToInt32(costo)
        comandoInsertar.Parameters("@creditos").Value = Convert.ToInt32(creditos)

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function JoinComboboxCursosCarreras() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_carrera, L.nombre" &
                       " FROM carreras L" &
                       " LEFT JOIN cursos R ON L.id_carrera = R.id_carrera"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function JoinComboboxCursosSede() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_sede, L.nombre" &
                       " FROM sede L" &
                       " LEFT JOIN cursos R ON L.id_sede = R.id_sede"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function JoinComboboxCursosHorarios() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_horario, L.dia" &
                       " FROM horarios L" &
                       " LEFT JOIN cursos R ON L.id_horario = R.id_horario"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function JoinComboboxCursosProfesor() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_profesor, L.nombre" &
                       " FROM profesores L" &
                       " LEFT JOIN cursos R ON L.id_profesor = R.id_profesor"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    '**************************************Matricula**************************************
    Public Shared Function InsertarInfoMatricula(id_matricula, id_cedula, id_curso, anno, cuatrimestre) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into matricula values (@id_matricula, @id_cedula,@id_curso,@anno, @cuatrimestre)"

        comandoInsertar.Parameters.Add("@id_matricula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_cedula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_curso", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@anno", SqlDbType.Date)
        comandoInsertar.Parameters.Add("@cuatrimestre", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_matricula").Value = Convert.ToInt32(id_matricula)
        comandoInsertar.Parameters("@id_cedula").Value = Convert.ToInt32(id_cedula)
        comandoInsertar.Parameters("@id_curso").Value = Convert.ToInt32(id_curso)
        comandoInsertar.Parameters("@anno").Value = Convert.ToDateTime(anno)
        comandoInsertar.Parameters("@cuatrimestre").Value = cuatrimestre

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function ObtenerInfoMatricula() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "SELECT * FROM matricula"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfoMatricula(ByVal id As String) As Integer
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "Delete FROM matricula where id_matricula =@id_matricula"
        _comando.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        _comando.Parameters("@id_matricula").Value = id
        Return MetodosDatos.EjecutarComandoBorrar(_comando)
    End Function

    Public Shared Function ActualizarInfoMatricula(id_matricula, id_cedula, id_curso, anno, cuatrimestre) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Update matricula set id_cedula = @id_cedula, id_curso = @id_curso, anno = @anno, cuatrimestre = @cuatrimestre where id_matricula = @id_matricula"

        comandoInsertar.Parameters.Add("@id_matricula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_cedula", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@id_curso", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@anno", SqlDbType.Date)
        comandoInsertar.Parameters.Add("@cuatrimestre", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@id_matricula").Value = Convert.ToInt32(id_matricula)
        comandoInsertar.Parameters("@id_cedula").Value = Convert.ToInt32(id_cedula)
        comandoInsertar.Parameters("@id_curso").Value = Convert.ToInt32(id_curso)
        comandoInsertar.Parameters("@anno").Value = Convert.ToDateTime(anno)
        comandoInsertar.Parameters("@cuatrimestre").Value = cuatrimestre

        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

    Public Shared Function JoinComboboxMatriculaEstudiantes() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_cedula, L.nombre" &
                       " FROM estudiantes L" &
                       " FULL JOIN matricula R ON L.id_cedula = R.id_cedula"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function JoinComboboxMatriculaCursos() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT L.id_curso, L.nombre" &
                       " FROM cursos L" &
                       " LEFT JOIN matricula R ON L.id_curso = R.id_curso"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

End Class
