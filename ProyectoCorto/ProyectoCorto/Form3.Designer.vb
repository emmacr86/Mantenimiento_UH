<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCarrera))
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewCarreras = New System.Windows.Forms.DataGridView()
        Me.LabelCarrera = New System.Windows.Forms.Label()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(78, 84)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 48
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(78, 121)
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(259, 47)
        Me.TextBoxDescripcion.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Descripción:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Carrera:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 87)
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
        Me.Label4.Size = New System.Drawing.Size(197, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Mantenimento Carreras"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewCarreras
        '
        Me.DataGridViewCarreras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCarreras.Location = New System.Drawing.Point(12, 258)
        Me.DataGridViewCarreras.MultiSelect = False
        Me.DataGridViewCarreras.Name = "DataGridViewCarreras"
        Me.DataGridViewCarreras.Size = New System.Drawing.Size(560, 192)
        Me.DataGridViewCarreras.TabIndex = 32
        '
        'LabelCarrera
        '
        Me.LabelCarrera.AutoSize = True
        Me.LabelCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarrera.Location = New System.Drawing.Point(78, 55)
        Me.LabelCarrera.Name = "LabelCarrera"
        Me.LabelCarrera.Size = New System.Drawing.Size(14, 13)
        Me.LabelCarrera.TabIndex = 53
        Me.LabelCarrera.Text = "0"
        Me.LabelCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(321, 220)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 54
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'FormCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.LabelCarrera)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewCarreras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCarrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Carreras"
        CType(Me.DataGridViewCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewCarreras As DataGridView
    Friend WithEvents LabelCarrera As Label
    Friend WithEvents ButtonActualizar As Button
End Class
