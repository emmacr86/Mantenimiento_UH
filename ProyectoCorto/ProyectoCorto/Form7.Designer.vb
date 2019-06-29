<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfesores))
        Me.LabelProfesor = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewProfesores = New System.Windows.Forms.DataGridView()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProfesor
        '
        Me.LabelProfesor.AutoSize = True
        Me.LabelProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfesor.Location = New System.Drawing.Point(78, 55)
        Me.LabelProfesor.Name = "LabelProfesor"
        Me.LabelProfesor.Size = New System.Drawing.Size(14, 13)
        Me.LabelProfesor.TabIndex = 64
        Me.LabelProfesor.Text = "0"
        Me.LabelProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(78, 84)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Profesor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 56
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
        Me.Label4.Size = New System.Drawing.Size(215, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Mantenimento Profesores"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewProfesores
        '
        Me.DataGridViewProfesores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProfesores.Location = New System.Drawing.Point(12, 258)
        Me.DataGridViewProfesores.MultiSelect = False
        Me.DataGridViewProfesores.Name = "DataGridViewProfesores"
        Me.DataGridViewProfesores.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewProfesores.TabIndex = 54
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(78, 119)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellido.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Apellido:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(78, 154)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxCorreo.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Correo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(78, 194)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTelefono.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Telefono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'FormProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelProfesor)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewProfesores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProfesores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Profesores"
        CType(Me.DataGridViewProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProfesor As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewProfesores As DataGridView
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonActualizar As Button
End Class
