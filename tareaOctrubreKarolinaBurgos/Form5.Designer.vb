<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lblButacas = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblEntradasCorreo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblButacas
        '
        Me.lblButacas.BackColor = System.Drawing.Color.Transparent
        Me.lblButacas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButacas.ForeColor = System.Drawing.Color.White
        Me.lblButacas.Location = New System.Drawing.Point(552, 122)
        Me.lblButacas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblButacas.Name = "lblButacas"
        Me.lblButacas.Size = New System.Drawing.Size(211, 152)
        Me.lblButacas.TabIndex = 7
        Me.lblButacas.Text = "Butacas:"
        Me.lblButacas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecio
        '
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.White
        Me.lblPrecio.Location = New System.Drawing.Point(604, 28)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(149, 28)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.White
        Me.cmdAceptar.Location = New System.Drawing.Point(282, 325)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(212, 34)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblEntradasCorreo
        '
        Me.lblEntradasCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblEntradasCorreo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradasCorreo.ForeColor = System.Drawing.Color.White
        Me.lblEntradasCorreo.Location = New System.Drawing.Point(36, 28)
        Me.lblEntradasCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntradasCorreo.Name = "lblEntradasCorreo"
        Me.lblEntradasCorreo.Size = New System.Drawing.Size(551, 28)
        Me.lblEntradasCorreo.TabIndex = 10
        Me.lblEntradasCorreo.Text = "Entradas enviadas a: "
        Me.lblEntradasCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEntradasCorreo)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblButacas)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblButacas As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents lblEntradasCorreo As Label
End Class
