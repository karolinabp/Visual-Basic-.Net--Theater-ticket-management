<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.lblEstudiante = New System.Windows.Forms.Label()
        Me.cmdGeneralMenos = New System.Windows.Forms.Button()
        Me.cmdEstudianteMenos = New System.Windows.Forms.Button()
        Me.cmdEstudianteMas = New System.Windows.Forms.Button()
        Me.lblGeneralCantidad = New System.Windows.Forms.Label()
        Me.lblEstudianteCantidad = New System.Windows.Forms.Label()
        Me.cmdGeneralMas = New System.Windows.Forms.Button()
        Me.lblTotalEntradas = New System.Windows.Forms.Label()
        Me.lblGeneralPrecio = New System.Windows.Forms.Label()
        Me.lblEstudiantePrecio = New System.Windows.Forms.Label()
        Me.lblTextoEntradas = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblTextoEntradas2 = New System.Windows.Forms.Label()
        Me.cmdAsientos = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.pgbCompleto = New System.Windows.Forms.ProgressBar()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGeneral
        '
        Me.lblGeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblGeneral.Location = New System.Drawing.Point(148, 114)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(184, 42)
        Me.lblGeneral.TabIndex = 0
        Me.lblGeneral.Text = "Entrada general"
        Me.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstudiante
        '
        Me.lblEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.lblEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudiante.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblEstudiante.Location = New System.Drawing.Point(148, 178)
        Me.lblEstudiante.Name = "lblEstudiante"
        Me.lblEstudiante.Size = New System.Drawing.Size(184, 42)
        Me.lblEstudiante.TabIndex = 2
        Me.lblEstudiante.Text = "Estudiante"
        Me.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdGeneralMenos
        '
        Me.cmdGeneralMenos.BackgroundImage = CType(resources.GetObject("cmdGeneralMenos.BackgroundImage"), System.Drawing.Image)
        Me.cmdGeneralMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGeneralMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGeneralMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGeneralMenos.Location = New System.Drawing.Point(494, 117)
        Me.cmdGeneralMenos.Name = "cmdGeneralMenos"
        Me.cmdGeneralMenos.Size = New System.Drawing.Size(42, 42)
        Me.cmdGeneralMenos.TabIndex = 4
        Me.cmdGeneralMenos.UseVisualStyleBackColor = True
        '
        'cmdEstudianteMenos
        '
        Me.cmdEstudianteMenos.BackgroundImage = CType(resources.GetObject("cmdEstudianteMenos.BackgroundImage"), System.Drawing.Image)
        Me.cmdEstudianteMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEstudianteMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEstudianteMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEstudianteMenos.Location = New System.Drawing.Point(494, 181)
        Me.cmdEstudianteMenos.Name = "cmdEstudianteMenos"
        Me.cmdEstudianteMenos.Size = New System.Drawing.Size(42, 42)
        Me.cmdEstudianteMenos.TabIndex = 6
        Me.cmdEstudianteMenos.UseVisualStyleBackColor = True
        '
        'cmdEstudianteMas
        '
        Me.cmdEstudianteMas.BackgroundImage = CType(resources.GetObject("cmdEstudianteMas.BackgroundImage"), System.Drawing.Image)
        Me.cmdEstudianteMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEstudianteMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEstudianteMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEstudianteMas.Location = New System.Drawing.Point(575, 181)
        Me.cmdEstudianteMas.Name = "cmdEstudianteMas"
        Me.cmdEstudianteMas.Size = New System.Drawing.Size(42, 42)
        Me.cmdEstudianteMas.TabIndex = 7
        Me.cmdEstudianteMas.UseVisualStyleBackColor = True
        '
        'lblGeneralCantidad
        '
        Me.lblGeneralCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblGeneralCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralCantidad.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblGeneralCantidad.Location = New System.Drawing.Point(384, 114)
        Me.lblGeneralCantidad.Name = "lblGeneralCantidad"
        Me.lblGeneralCantidad.Size = New System.Drawing.Size(56, 42)
        Me.lblGeneralCantidad.TabIndex = 7
        Me.lblGeneralCantidad.Text = "0"
        Me.lblGeneralCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEstudianteCantidad
        '
        Me.lblEstudianteCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblEstudianteCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudianteCantidad.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblEstudianteCantidad.Location = New System.Drawing.Point(384, 178)
        Me.lblEstudianteCantidad.Name = "lblEstudianteCantidad"
        Me.lblEstudianteCantidad.Size = New System.Drawing.Size(56, 42)
        Me.lblEstudianteCantidad.TabIndex = 8
        Me.lblEstudianteCantidad.Text = "0"
        Me.lblEstudianteCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdGeneralMas
        '
        Me.cmdGeneralMas.BackgroundImage = CType(resources.GetObject("cmdGeneralMas.BackgroundImage"), System.Drawing.Image)
        Me.cmdGeneralMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGeneralMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGeneralMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGeneralMas.Location = New System.Drawing.Point(575, 117)
        Me.cmdGeneralMas.Name = "cmdGeneralMas"
        Me.cmdGeneralMas.Size = New System.Drawing.Size(42, 42)
        Me.cmdGeneralMas.TabIndex = 5
        Me.cmdGeneralMas.UseVisualStyleBackColor = True
        '
        'lblTotalEntradas
        '
        Me.lblTotalEntradas.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntradas.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblTotalEntradas.Location = New System.Drawing.Point(460, 262)
        Me.lblTotalEntradas.Name = "lblTotalEntradas"
        Me.lblTotalEntradas.Size = New System.Drawing.Size(56, 38)
        Me.lblTotalEntradas.TabIndex = 9
        Me.lblTotalEntradas.Text = "0"
        Me.lblTotalEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGeneralPrecio
        '
        Me.lblGeneralPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblGeneralPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralPrecio.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblGeneralPrecio.Location = New System.Drawing.Point(621, 114)
        Me.lblGeneralPrecio.Name = "lblGeneralPrecio"
        Me.lblGeneralPrecio.Size = New System.Drawing.Size(100, 42)
        Me.lblGeneralPrecio.TabIndex = 11
        Me.lblGeneralPrecio.Text = "0 €"
        Me.lblGeneralPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstudiantePrecio
        '
        Me.lblEstudiantePrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblEstudiantePrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudiantePrecio.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblEstudiantePrecio.Location = New System.Drawing.Point(621, 178)
        Me.lblEstudiantePrecio.Name = "lblEstudiantePrecio"
        Me.lblEstudiantePrecio.Size = New System.Drawing.Size(100, 42)
        Me.lblEstudiantePrecio.TabIndex = 12
        Me.lblEstudiantePrecio.Text = "0 €"
        Me.lblEstudiantePrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextoEntradas
        '
        Me.lblTextoEntradas.BackColor = System.Drawing.Color.Transparent
        Me.lblTextoEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoEntradas.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblTextoEntradas.Location = New System.Drawing.Point(148, 262)
        Me.lblTextoEntradas.Name = "lblTextoEntradas"
        Me.lblTextoEntradas.Size = New System.Drawing.Size(306, 38)
        Me.lblTextoEntradas.TabIndex = 13
        Me.lblTextoEntradas.Text = "Número total de entradas: "
        Me.lblTextoEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblPrecioTotal.Location = New System.Drawing.Point(621, 258)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(100, 42)
        Me.lblPrecioTotal.TabIndex = 14
        Me.lblPrecioTotal.Text = "0 €"
        Me.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextoEntradas2
        '
        Me.lblTextoEntradas2.BackColor = System.Drawing.Color.Transparent
        Me.lblTextoEntradas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoEntradas2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblTextoEntradas2.Location = New System.Drawing.Point(150, 38)
        Me.lblTextoEntradas2.Name = "lblTextoEntradas2"
        Me.lblTextoEntradas2.Size = New System.Drawing.Size(528, 38)
        Me.lblTextoEntradas2.TabIndex = 15
        Me.lblTextoEntradas2.Text = "*Número máximo de entradas por transacción: 6*"
        Me.lblTextoEntradas2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdAsientos
        '
        Me.cmdAsientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAsientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAsientos.Enabled = False
        Me.cmdAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAsientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAsientos.ForeColor = System.Drawing.Color.PeachPuff
        Me.cmdAsientos.Location = New System.Drawing.Point(453, 450)
        Me.cmdAsientos.Name = "cmdAsientos"
        Me.cmdAsientos.Size = New System.Drawing.Size(268, 63)
        Me.cmdAsientos.TabIndex = 8
        Me.cmdAsientos.Text = "Seleccionar asientos"
        Me.cmdAsientos.UseVisualStyleBackColor = False
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.PeachPuff
        Me.cmdAtras.Location = New System.Drawing.Point(153, 450)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(268, 63)
        Me.cmdAtras.TabIndex = 9
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'pgbCompleto
        '
        Me.pgbCompleto.BackColor = System.Drawing.Color.White
        Me.pgbCompleto.Location = New System.Drawing.Point(154, 349)
        Me.pgbCompleto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pgbCompleto.Maximum = 32
        Me.pgbCompleto.Name = "pgbCompleto"
        Me.pgbCompleto.Size = New System.Drawing.Size(382, 46)
        Me.pgbCompleto.Step = 1
        Me.pgbCompleto.TabIndex = 18
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblPorcentaje.Location = New System.Drawing.Point(544, 354)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(177, 42)
        Me.lblPorcentaje.TabIndex = 19
        Me.lblPorcentaje.Text = "Aforo: 100%"
        Me.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(876, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.pgbCompleto)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.cmdAsientos)
        Me.Controls.Add(Me.lblTextoEntradas2)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblTextoEntradas)
        Me.Controls.Add(Me.lblEstudiantePrecio)
        Me.Controls.Add(Me.lblGeneralPrecio)
        Me.Controls.Add(Me.cmdGeneralMas)
        Me.Controls.Add(Me.lblTotalEntradas)
        Me.Controls.Add(Me.lblEstudianteCantidad)
        Me.Controls.Add(Me.lblGeneralCantidad)
        Me.Controls.Add(Me.cmdEstudianteMenos)
        Me.Controls.Add(Me.cmdEstudianteMas)
        Me.Controls.Add(Me.cmdGeneralMenos)
        Me.Controls.Add(Me.lblEstudiante)
        Me.Controls.Add(Me.lblGeneral)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblGeneral As Label
    Friend WithEvents lblEstudiante As Label
    Friend WithEvents cmdGeneralMenos As Button
    Friend WithEvents cmdEstudianteMenos As Button
    Friend WithEvents cmdEstudianteMas As Button
    Friend WithEvents lblGeneralCantidad As Label
    Friend WithEvents lblEstudianteCantidad As Label
    Friend WithEvents cmdGeneralMas As Button
    Friend WithEvents lblTotalEntradas As Label
    Friend WithEvents lblGeneralPrecio As Label
    Friend WithEvents lblEstudiantePrecio As Label
    Friend WithEvents lblTextoEntradas As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblTextoEntradas2 As Label
    Friend WithEvents cmdAsientos As Button
    Friend WithEvents cmdAtras As Button
    Friend WithEvents pgbCompleto As ProgressBar
    Friend WithEvents lblPorcentaje As Label
End Class
