<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMatricula))
        Me.LabelMatricula = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewMatricula = New System.Windows.Forms.DataGridView()
        Me.ComboBoxEstudiante = New System.Windows.Forms.ComboBox()
        Me.ComboboxCurso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxCuatrimestre = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelMatricula
        '
        Me.LabelMatricula.AutoSize = True
        Me.LabelMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMatricula.Location = New System.Drawing.Point(78, 55)
        Me.LabelMatricula.Name = "LabelMatricula"
        Me.LabelMatricula.Size = New System.Drawing.Size(14, 13)
        Me.LabelMatricula.TabIndex = 64
        Me.LabelMatricula.Text = "0"
        Me.LabelMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(240, 220)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 63
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(159, 220)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 62
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(78, 220)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngresar.TabIndex = 61
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Curso:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Matricula:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Estudiante:"
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
        Me.Label4.Size = New System.Drawing.Size(201, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Mantenimento Matricula"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewMatricula
        '
        Me.DataGridViewMatricula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMatricula.Location = New System.Drawing.Point(12, 258)
        Me.DataGridViewMatricula.MultiSelect = False
        Me.DataGridViewMatricula.Name = "DataGridViewMatricula"
        Me.DataGridViewMatricula.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewMatricula.TabIndex = 54
        '
        'ComboBoxEstudiante
        '
        Me.ComboBoxEstudiante.FormattingEnabled = True
        Me.ComboBoxEstudiante.Location = New System.Drawing.Point(81, 84)
        Me.ComboBoxEstudiante.Name = "ComboBoxEstudiante"
        Me.ComboBoxEstudiante.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEstudiante.TabIndex = 65
        '
        'ComboboxCurso
        '
        Me.ComboboxCurso.FormattingEnabled = True
        Me.ComboboxCurso.Location = New System.Drawing.Point(81, 124)
        Me.ComboboxCurso.Name = "ComboboxCurso"
        Me.ComboboxCurso.Size = New System.Drawing.Size(121, 21)
        Me.ComboboxCurso.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Año:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(78, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 68
        '
        'ComboBoxCuatrimestre
        '
        Me.ComboBoxCuatrimestre.FormattingEnabled = True
        Me.ComboBoxCuatrimestre.Items.AddRange(New Object() {"I", "II", "II", "IV"})
        Me.ComboBoxCuatrimestre.Location = New System.Drawing.Point(78, 193)
        Me.ComboBoxCuatrimestre.Name = "ComboBoxCuatrimestre"
        Me.ComboBoxCuatrimestre.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCuatrimestre.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Cuatrimestre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(321, 220)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 71
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ComboBoxCuatrimestre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboboxCurso)
        Me.Controls.Add(Me.ComboBoxEstudiante)
        Me.Controls.Add(Me.LabelMatricula)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewMatricula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matricula Estudiantes"
        CType(Me.DataGridViewMatricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMatricula As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewMatricula As DataGridView
    Friend WithEvents ComboBoxEstudiante As ComboBox
    Friend WithEvents ComboboxCurso As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBoxCuatrimestre As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonActualizar As Button
End Class
