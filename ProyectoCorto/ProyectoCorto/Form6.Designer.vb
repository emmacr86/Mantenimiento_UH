<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHorarios))
        Me.LabelHorarios = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewHorarios = New System.Windows.Forms.DataGridView()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxDias = New System.Windows.Forms.ComboBox()
        Me.ComboBoxHoras = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSede = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelHorarios
        '
        Me.LabelHorarios.AutoSize = True
        Me.LabelHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHorarios.Location = New System.Drawing.Point(78, 55)
        Me.LabelHorarios.Name = "LabelHorarios"
        Me.LabelHorarios.Size = New System.Drawing.Size(14, 13)
        Me.LabelHorarios.TabIndex = 64
        Me.LabelHorarios.Text = "0"
        Me.LabelHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(28, 55)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(49, 13)
        Me.Label.TabIndex = 57
        Me.Label.Text = "Horarios:"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(173, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Mantenimento Horarios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewHorarios
        '
        Me.DataGridViewHorarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHorarios.Location = New System.Drawing.Point(12, 258)
        Me.DataGridViewHorarios.MultiSelect = False
        Me.DataGridViewHorarios.Name = "DataGridViewHorarios"
        Me.DataGridViewHorarios.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewHorarios.TabIndex = 54
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(78, 80)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCarrera.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Carrera:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Día:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxDias
        '
        Me.ComboBoxDias.FormattingEnabled = True
        Me.ComboBoxDias.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.ComboBoxDias.Location = New System.Drawing.Point(78, 119)
        Me.ComboBoxDias.Name = "ComboBoxDias"
        Me.ComboBoxDias.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDias.TabIndex = 68
        '
        'ComboBoxHoras
        '
        Me.ComboBoxHoras.FormattingEnabled = True
        Me.ComboBoxHoras.Items.AddRange(New Object() {"1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00"})
        Me.ComboBoxHoras.Location = New System.Drawing.Point(78, 157)
        Me.ComboBoxHoras.Name = "ComboBoxHoras"
        Me.ComboBoxHoras.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxHoras.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Horas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxSede
        '
        Me.ComboBoxSede.FormattingEnabled = True
        Me.ComboBoxSede.Location = New System.Drawing.Point(78, 193)
        Me.ComboBoxSede.Name = "ComboBoxSede"
        Me.ComboBoxSede.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSede.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Sede:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(321, 220)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 73
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ComboBoxSede)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxHoras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxDias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelHorarios)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewHorarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Horarios"
        CType(Me.DataGridViewHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHorarios As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewHorarios As DataGridView
    Friend WithEvents ComboBoxCarrera As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxDias As ComboBox
    Friend WithEvents ComboBoxHoras As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSede As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonActualizar As Button
End Class
