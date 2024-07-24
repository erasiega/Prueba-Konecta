<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelTemperature = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelFeelsLike = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxCities = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonFahrenheit = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCelsius = New System.Windows.Forms.RadioButton()
        Me.Ciudad = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTemperature
        '
        Me.LabelTemperature.AutoSize = True
        Me.LabelTemperature.Location = New System.Drawing.Point(13, 60)
        Me.LabelTemperature.Name = "LabelTemperature"
        Me.LabelTemperature.Size = New System.Drawing.Size(70, 13)
        Me.LabelTemperature.TabIndex = 1
        Me.LabelTemperature.Text = "Temperatura:"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(13, 86)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(66, 13)
        Me.LabelDescription.TabIndex = 2
        Me.LabelDescription.Text = "Descripción:"
        '
        'LabelFeelsLike
        '
        Me.LabelFeelsLike.AutoSize = True
        Me.LabelFeelsLike.Location = New System.Drawing.Point(13, 118)
        Me.LabelFeelsLike.Name = "LabelFeelsLike"
        Me.LabelFeelsLike.Size = New System.Drawing.Size(97, 13)
        Me.LabelFeelsLike.TabIndex = 3
        Me.LabelFeelsLike.Text = "Sensación térmica:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(450, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxCities
        '
        Me.ComboBoxCities.FormattingEnabled = True
        Me.ComboBoxCities.Items.AddRange(New Object() {"Bogota", "Medellin", "Cali", "Bucaramanga", "Santa Marta", "Cartagena", "Lima", "Quito", "Buenos Aires", "Madrid", "Ciudad de México", "Santiago", "Montevideo"})
        Me.ComboBoxCities.Location = New System.Drawing.Point(185, 21)
        Me.ComboBoxCities.Name = "ComboBoxCities"
        Me.ComboBoxCities.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCities.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonCelsius)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFahrenheit)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidad "
        '
        'RadioButtonFahrenheit
        '
        Me.RadioButtonFahrenheit.AutoSize = True
        Me.RadioButtonFahrenheit.Location = New System.Drawing.Point(25, 32)
        Me.RadioButtonFahrenheit.Name = "RadioButtonFahrenheit"
        Me.RadioButtonFahrenheit.Size = New System.Drawing.Size(75, 17)
        Me.RadioButtonFahrenheit.TabIndex = 0
        Me.RadioButtonFahrenheit.Text = "Fahrenheit"
        Me.RadioButtonFahrenheit.UseVisualStyleBackColor = True
        '
        'RadioButtonCelsius
        '
        Me.RadioButtonCelsius.AutoSize = True
        Me.RadioButtonCelsius.Checked = True
        Me.RadioButtonCelsius.Location = New System.Drawing.Point(25, 60)
        Me.RadioButtonCelsius.Name = "RadioButtonCelsius"
        Me.RadioButtonCelsius.Size = New System.Drawing.Size(58, 17)
        Me.RadioButtonCelsius.TabIndex = 1
        Me.RadioButtonCelsius.TabStop = True
        Me.RadioButtonCelsius.Text = "Celsius"
        Me.RadioButtonCelsius.UseVisualStyleBackColor = True
        '
        'Ciudad
        '
        Me.Ciudad.AutoSize = True
        Me.Ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciudad.Location = New System.Drawing.Point(12, 22)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(70, 20)
        Me.Ciudad.TabIndex = 7
        Me.Ciudad.Text = "Ciudad:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 172)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBoxCities)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelFeelsLike)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelTemperature)
        Me.Name = "Form1"
        Me.Text = "Clima por Ciudad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTemperature As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelFeelsLike As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxCities As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonCelsius As RadioButton
    Friend WithEvents RadioButtonFahrenheit As RadioButton
    Friend WithEvents Ciudad As Label
End Class
