<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCursos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCursos))
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewCursos = New System.Windows.Forms.DataGridView()
        Me.ComboBoxHorario = New System.Windows.Forms.ComboBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ComboBoxProfesor = New System.Windows.Forms.ComboBox()
        Me.LabelIdentificacionCurso = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxRequisito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxSede = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCosto = New System.Windows.Forms.TextBox()
        Me.TextBoxCreditos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(240, 220)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 52
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(159, 220)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 51
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(78, 220)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngresar.TabIndex = 50
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(78, 62)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCarrera.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(205, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Profesor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Horario:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ID Curso:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Nombre:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(173, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Mantenimento Cursos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Carrera:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewCursos
        '
        Me.DataGridViewCursos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCursos.Location = New System.Drawing.Point(12, 258)
        Me.DataGridViewCursos.MultiSelect = False
        Me.DataGridViewCursos.Name = "DataGridViewCursos"
        Me.DataGridViewCursos.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewCursos.TabIndex = 32
        '
        'ComboBoxHorario
        '
        Me.ComboBoxHorario.FormattingEnabled = True
        Me.ComboBoxHorario.Location = New System.Drawing.Point(265, 62)
        Me.ComboBoxHorario.Name = "ComboBoxHorario"
        Me.ComboBoxHorario.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxHorario.TabIndex = 53
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(77, 99)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 48
        '
        'ComboBoxProfesor
        '
        Me.ComboBoxProfesor.FormattingEnabled = True
        Me.ComboBoxProfesor.Location = New System.Drawing.Point(265, 99)
        Me.ComboBoxProfesor.Name = "ComboBoxProfesor"
        Me.ComboBoxProfesor.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxProfesor.TabIndex = 54
        '
        'LabelIdentificacionCurso
        '
        Me.LabelIdentificacionCurso.AutoSize = True
        Me.LabelIdentificacionCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdentificacionCurso.Location = New System.Drawing.Point(75, 39)
        Me.LabelIdentificacionCurso.Name = "LabelIdentificacionCurso"
        Me.LabelIdentificacionCurso.Size = New System.Drawing.Size(14, 13)
        Me.LabelIdentificacionCurso.TabIndex = 55
        Me.LabelIdentificacionCurso.Text = "0"
        Me.LabelIdentificacionCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(77, 134)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDescripcion.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-2, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Descripción:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxRequisito
        '
        Me.TextBoxRequisito.Location = New System.Drawing.Point(265, 134)
        Me.TextBoxRequisito.Name = "TextBoxRequisito"
        Me.TextBoxRequisito.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRequisito.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Requisito:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxSede
        '
        Me.ComboBoxSede.FormattingEnabled = True
        Me.ComboBoxSede.Location = New System.Drawing.Point(77, 170)
        Me.ComboBoxSede.Name = "ComboBoxSede"
        Me.ComboBoxSede.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSede.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Sede:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxCosto
        '
        Me.TextBoxCosto.Location = New System.Drawing.Point(265, 170)
        Me.TextBoxCosto.Name = "TextBoxCosto"
        Me.TextBoxCosto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCosto.TabIndex = 65
        '
        'TextBoxCreditos
        '
        Me.TextBoxCreditos.Location = New System.Drawing.Point(424, 170)
        Me.TextBoxCreditos.Name = "TextBoxCreditos"
        Me.TextBoxCreditos.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCreditos.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(214, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Costo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(376, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Creditos:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(321, 220)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 66
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.TextBoxCosto)
        Me.Controls.Add(Me.TextBoxCreditos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxSede)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxRequisito)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelIdentificacionCurso)
        Me.Controls.Add(Me.ComboBoxProfesor)
        Me.Controls.Add(Me.ComboBoxHorario)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewCursos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cursos"
        CType(Me.DataGridViewCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents ComboBoxCarrera As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewCursos As DataGridView
    Friend WithEvents ComboBoxHorario As ComboBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ComboBoxProfesor As ComboBox
    Friend WithEvents LabelIdentificacionCurso As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxRequisito As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxSede As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCosto As TextBox
    Friend WithEvents TextBoxCreditos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonActualizar As Button
End Class
