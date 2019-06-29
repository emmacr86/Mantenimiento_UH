Public Class Configuracion
    Shared _cadenaConexion As String = "Data Source=(local);Initial Catalog=proyectoCorto;Integrated Security=True"
    Public Shared ReadOnly Property CadenaConexion() As String
        Get
            Return _cadenaConexion
        End Get
    End Property
End Class
