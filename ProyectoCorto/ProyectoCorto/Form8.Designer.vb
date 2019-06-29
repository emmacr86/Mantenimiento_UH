<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNotas))
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxMatricula = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelNotas = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewNotas = New System.Windows.Forms.DataGridView()
        Me.TextBoxNotaFinal = New System.Windows.Forms.TextBox()
        Me.TextBoxNotas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Aprobado", "Reprobado"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(78, 193)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxStatus.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Status:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Nota Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxMatricula
        '
        Me.ComboBoxMatricula.FormattingEnabled = True
        Me.ComboBoxMatricula.Location = New System.Drawing.Point(78, 80)
        Me.ComboBoxMatricula.Name = "ComboBoxMatricula"
        Me.ComboBoxMatricula.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMatricula.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Materia:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelNotas
        '
        Me.LabelNotas.AutoSize = True
        Me.LabelNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotas.Location = New System.Drawing.Point(78, 55)
        Me.LabelNotas.Name = "LabelNotas"
        Me.LabelNotas.Size = New System.Drawing.Size(14, 13)
        Me.LabelNotas.TabIndex = 79
        Me.LabelNotas.Text = "0"
        Me.LabelNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(240, 220)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 78
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(159, 220)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 77
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(78, 220)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngresar.TabIndex = 76
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(28, 55)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(52, 13)
        Me.Label.TabIndex = 75
        Me.Label.Text = "ID Notas:"
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
        Me.Label4.Size = New System.Drawing.Size(175, 20)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Mantenimento Notas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewNotas
        '
        Me.DataGridViewNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNotas.Location = New System.Drawing.Point(12, 258)
        Me.DataGridViewNotas.MultiSelect = False
        Me.DataGridViewNotas.Name = "DataGridViewNotas"
        Me.DataGridViewNotas.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewNotas.TabIndex = 73
        '
        'TextBoxNotaFinal
        '
        Me.TextBoxNotaFinal.Location = New System.Drawing.Point(81, 157)
        Me.TextBoxNotaFinal.Name = "TextBoxNotaFinal"
        Me.TextBoxNotaFinal.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxNotaFinal.TabIndex = 88
        '
        'TextBoxNotas
        '
        Me.TextBoxNotas.Location = New System.Drawing.Point(81, 121)
        Me.TextBoxNotas.Name = "TextBoxNotas"
        Me.TextBoxNotas.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxNotas.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Notas :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(321, 220)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 91
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.TextBoxNotas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNotaFinal)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxMatricula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelNotas)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewNotas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Notas"
        CType(Me.DataGridViewNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxMatricula As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelNotas As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewNotas As DataGridView
    Friend WithEvents TextBoxNotaFinal As TextBox
    Friend WithEvents TextBoxNotas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonActualizar As Button
End Class
