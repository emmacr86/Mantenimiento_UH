<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstudiantes))
        Me.DataGridViewEstudiantes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxCelular = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewEstudiantes
        '
        Me.DataGridViewEstudiantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEstudiantes.Location = New System.Drawing.Point(12, 257)
        Me.DataGridViewEstudiantes.MultiSelect = False
        Me.DataGridViewEstudiantes.Name = "DataGridViewEstudiantes"
        Me.DataGridViewEstudiantes.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewEstudiantes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cedula:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(173, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mantenimento Estudiantes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nombre:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Carrera:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Celular:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Telefono:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Dirección:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Apellido:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(343, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Correo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(79, 50)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCedula.TabIndex = 21
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(390, 148)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxCorreo.TabIndex = 22
        '
        'TextBoxCelular
        '
        Me.TextBoxCelular.Location = New System.Drawing.Point(237, 148)
        Me.TextBoxCelular.Name = "TextBoxCelular"
        Me.TextBoxCelular.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCelular.TabIndex = 23
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(78, 148)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTelefono.TabIndex = 24
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(79, 86)
        Me.TextBoxDireccion.Multiline = True
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(259, 47)
        Me.TextBoxDireccion.TabIndex = 25
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(390, 50)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellido.TabIndex = 26
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(238, 50)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 27
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(78, 183)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCarrera.TabIndex = 28
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(78, 219)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngresar.TabIndex = 29
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(159, 219)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 30
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(240, 219)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 31
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(322, 219)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 32
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormEstudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxCelular)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewEstudiantes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEstudiantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Estudiantes"
        CType(Me.DataGridViewEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewEstudiantes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxCelular As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ComboBoxCarrera As ComboBox
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonActualizar As Button
End Class
