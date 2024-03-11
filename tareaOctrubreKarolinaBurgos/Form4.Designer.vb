<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblTitular = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCvc = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCvc = New System.Windows.Forms.TextBox()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cmdPagar = New System.Windows.Forms.Button()
        Me.lblNumeroError = New System.Windows.Forms.Label()
        Me.lblTitularError = New System.Windows.Forms.Label()
        Me.lblCvcError = New System.Windows.Forms.Label()
        Me.PictureBoxMaster = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVisa = New System.Windows.Forms.PictureBox()
        Me.cmdVer = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCorreoError = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblComprar = New System.Windows.Forms.Label()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.lblFechaError = New System.Windows.Forms.Label()
        CType(Me.PictureBoxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.ForeColor = System.Drawing.Color.White
        Me.lblNumero.Location = New System.Drawing.Point(82, 20)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(296, 34)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Número Tarjeta:"
        '
        'lblTitular
        '
        Me.lblTitular.BackColor = System.Drawing.Color.Transparent
        Me.lblTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitular.ForeColor = System.Drawing.Color.White
        Me.lblTitular.Location = New System.Drawing.Point(82, 125)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(178, 34)
        Me.lblTitular.TabIndex = 1
        Me.lblTitular.Text = "Titular:"
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(568, 20)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(254, 34)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha expiración:"
        '
        'lblCvc
        '
        Me.lblCvc.BackColor = System.Drawing.Color.Transparent
        Me.lblCvc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCvc.ForeColor = System.Drawing.Color.White
        Me.lblCvc.Location = New System.Drawing.Point(568, 125)
        Me.lblCvc.Name = "lblCvc"
        Me.lblCvc.Size = New System.Drawing.Size(142, 34)
        Me.lblCvc.TabIndex = 3
        Me.lblCvc.Text = "CVC"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(86, 57)
        Me.txtNumero.MaxLength = 16
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(462, 35)
        Me.txtNumero.TabIndex = 4
        '
        'txtTitular
        '
        Me.txtTitular.BackColor = System.Drawing.Color.White
        Me.txtTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.ForeColor = System.Drawing.Color.Black
        Me.txtTitular.Location = New System.Drawing.Point(86, 162)
        Me.txtTitular.MaxLength = 40
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(462, 35)
        Me.txtTitular.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(573, 58)
        Me.DateTimePicker1.MinDate = New Date(2022, 10, 16, 21, 29, 31, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(193, 35)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(2022, 11, 1, 0, 0, 0, 0)
        '
        'txtCvc
        '
        Me.txtCvc.BackColor = System.Drawing.Color.White
        Me.txtCvc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCvc.Location = New System.Drawing.Point(574, 162)
        Me.txtCvc.MaxLength = 3
        Me.txtCvc.Name = "txtCvc"
        Me.txtCvc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCvc.Size = New System.Drawing.Size(192, 35)
        Me.txtCvc.TabIndex = 7
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.White
        Me.cmdAtras.Location = New System.Drawing.Point(153, 449)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(268, 63)
        Me.cmdAtras.TabIndex = 13
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cmdPagar
        '
        Me.cmdPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPagar.ForeColor = System.Drawing.Color.White
        Me.cmdPagar.Location = New System.Drawing.Point(453, 449)
        Me.cmdPagar.Name = "cmdPagar"
        Me.cmdPagar.Size = New System.Drawing.Size(268, 63)
        Me.cmdPagar.TabIndex = 12
        Me.cmdPagar.Text = "Pagar"
        Me.cmdPagar.UseVisualStyleBackColor = False
        '
        'lblNumeroError
        '
        Me.lblNumeroError.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumeroError.Location = New System.Drawing.Point(86, 91)
        Me.lblNumeroError.Name = "lblNumeroError"
        Me.lblNumeroError.Size = New System.Drawing.Size(462, 34)
        Me.lblNumeroError.TabIndex = 10
        Me.lblNumeroError.Text = "Campo obligatorio"
        Me.lblNumeroError.Visible = False
        '
        'lblTitularError
        '
        Me.lblTitularError.BackColor = System.Drawing.Color.Transparent
        Me.lblTitularError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTitularError.Location = New System.Drawing.Point(86, 200)
        Me.lblTitularError.Name = "lblTitularError"
        Me.lblTitularError.Size = New System.Drawing.Size(462, 34)
        Me.lblTitularError.TabIndex = 11
        Me.lblTitularError.Text = "Campo obligatorio"
        Me.lblTitularError.Visible = False
        '
        'lblCvcError
        '
        Me.lblCvcError.BackColor = System.Drawing.Color.Transparent
        Me.lblCvcError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCvcError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCvcError.Location = New System.Drawing.Point(568, 200)
        Me.lblCvcError.Name = "lblCvcError"
        Me.lblCvcError.Size = New System.Drawing.Size(213, 32)
        Me.lblCvcError.TabIndex = 12
        Me.lblCvcError.Text = "Campo obligatorio"
        Me.lblCvcError.Visible = False
        '
        'PictureBoxMaster
        '
        Me.PictureBoxMaster.BackColor = System.Drawing.Color.White
        Me.PictureBoxMaster.Image = CType(resources.GetObject("PictureBoxMaster.Image"), System.Drawing.Image)
        Me.PictureBoxMaster.Location = New System.Drawing.Point(496, 62)
        Me.PictureBoxMaster.Name = "PictureBoxMaster"
        Me.PictureBoxMaster.Size = New System.Drawing.Size(51, 31)
        Me.PictureBoxMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMaster.TabIndex = 14
        Me.PictureBoxMaster.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBoxMaster, "hola")
        '
        'PictureBoxVisa
        '
        Me.PictureBoxVisa.BackColor = System.Drawing.Color.White
        Me.PictureBoxVisa.Image = CType(resources.GetObject("PictureBoxVisa.Image"), System.Drawing.Image)
        Me.PictureBoxVisa.Location = New System.Drawing.Point(422, 62)
        Me.PictureBoxVisa.Name = "PictureBoxVisa"
        Me.PictureBoxVisa.Size = New System.Drawing.Size(69, 31)
        Me.PictureBoxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVisa.TabIndex = 15
        Me.PictureBoxVisa.TabStop = False
        '
        'cmdVer
        '
        Me.cmdVer.BackColor = System.Drawing.Color.White
        Me.cmdVer.BackgroundImage = CType(resources.GetObject("cmdVer.BackgroundImage"), System.Drawing.Image)
        Me.cmdVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdVer.Location = New System.Drawing.Point(730, 162)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(36, 35)
        Me.cmdVer.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.cmdVer, "Ver CVC")
        Me.cmdVer.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.UseFading = False
        '
        'lblCorreoError
        '
        Me.lblCorreoError.BackColor = System.Drawing.Color.Transparent
        Me.lblCorreoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCorreoError.Location = New System.Drawing.Point(86, 309)
        Me.lblCorreoError.Name = "lblCorreoError"
        Me.lblCorreoError.Size = New System.Drawing.Size(462, 34)
        Me.lblCorreoError.TabIndex = 19
        Me.lblCorreoError.Text = "Campo obligatorio"
        Me.lblCorreoError.Visible = False
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.Black
        Me.txtCorreo.Location = New System.Drawing.Point(86, 271)
        Me.txtCorreo.MaxLength = 40
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(680, 35)
        Me.txtCorreo.TabIndex = 9
        '
        'lblCorreo
        '
        Me.lblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.Location = New System.Drawing.Point(82, 234)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(296, 34)
        Me.lblCorreo.TabIndex = 17
        Me.lblCorreo.Text = "Correo electrónico:"
        '
        'lblComprar
        '
        Me.lblComprar.BackColor = System.Drawing.Color.Transparent
        Me.lblComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComprar.ForeColor = System.Drawing.Color.White
        Me.lblComprar.Location = New System.Drawing.Point(86, 371)
        Me.lblComprar.Name = "lblComprar"
        Me.lblComprar.Size = New System.Drawing.Size(544, 34)
        Me.lblComprar.TabIndex = 20
        Me.lblComprar.Text = "Guardar los datos para seguir comprando: "
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.BackColor = System.Drawing.Color.Transparent
        Me.rbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSi.ForeColor = System.Drawing.Color.White
        Me.rbSi.Location = New System.Drawing.Point(620, 369)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(60, 33)
        Me.rbSi.TabIndex = 10
        Me.rbSi.Text = "Si"
        Me.rbSi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbSi.UseVisualStyleBackColor = False
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.BackColor = System.Drawing.Color.Transparent
        Me.rbNo.Checked = True
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.ForeColor = System.Drawing.Color.White
        Me.rbNo.Location = New System.Drawing.Point(706, 369)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(70, 33)
        Me.rbNo.TabIndex = 11
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbNo.UseVisualStyleBackColor = False
        '
        'lblFechaError
        '
        Me.lblFechaError.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFechaError.Location = New System.Drawing.Point(570, 92)
        Me.lblFechaError.Name = "lblFechaError"
        Me.lblFechaError.Size = New System.Drawing.Size(213, 32)
        Me.lblFechaError.TabIndex = 21
        Me.lblFechaError.Text = "Fecha no válida"
        Me.lblFechaError.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(876, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFechaError)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.rbSi)
        Me.Controls.Add(Me.lblComprar)
        Me.Controls.Add(Me.lblCorreoError)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.cmdVer)
        Me.Controls.Add(Me.PictureBoxVisa)
        Me.Controls.Add(Me.PictureBoxMaster)
        Me.Controls.Add(Me.lblCvcError)
        Me.Controls.Add(Me.lblTitularError)
        Me.Controls.Add(Me.lblNumeroError)
        Me.Controls.Add(Me.cmdPagar)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.txtCvc)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblCvc)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblTitular)
        Me.Controls.Add(Me.lblNumero)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBoxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents lblTitular As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCvc As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtCvc As TextBox
    Friend WithEvents cmdAtras As Button
    Friend WithEvents cmdPagar As Button
    Friend WithEvents lblNumeroError As Label
    Friend WithEvents lblTitularError As Label
    Friend WithEvents lblCvcError As Label
    Friend WithEvents PictureBoxMaster As PictureBox
    Friend WithEvents PictureBoxVisa As PictureBox
    Friend WithEvents cmdVer As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblCorreoError As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblComprar As Label
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents lblFechaError As Label
End Class
