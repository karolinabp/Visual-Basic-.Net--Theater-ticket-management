<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTeatro = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmdComprar = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Bernard MT Condensed", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.LemonChiffon
        Me.lblTitulo.Location = New System.Drawing.Point(322, 50)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(242, 62)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "MACBETH"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTeatro
        '
        Me.lblTeatro.BackColor = System.Drawing.Color.Transparent
        Me.lblTeatro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeatro.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblTeatro.Location = New System.Drawing.Point(334, 112)
        Me.lblTeatro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTeatro.Name = "lblTeatro"
        Me.lblTeatro.Size = New System.Drawing.Size(220, 26)
        Me.lblTeatro.TabIndex = 2
        Me.lblTeatro.Text = "Teatro del Barrio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblFecha.Location = New System.Drawing.Point(334, 138)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(220, 26)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "19/12/2022"
        '
        'cmdComprar
        '
        Me.cmdComprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdComprar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdComprar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComprar.ForeColor = System.Drawing.Color.PeachPuff
        Me.cmdComprar.Location = New System.Drawing.Point(427, 268)
        Me.cmdComprar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdComprar.Name = "cmdComprar"
        Me.cmdComprar.Size = New System.Drawing.Size(94, 36)
        Me.cmdComprar.TabIndex = 4
        Me.cmdComprar.Text = "Comprar"
        Me.cmdComprar.UseVisualStyleBackColor = False
        '
        'lblHora
        '
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblHora.Location = New System.Drawing.Point(334, 164)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(220, 26)
        Me.lblHora.TabIndex = 5
        Me.lblHora.Text = "20:00"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.ForeColor = System.Drawing.Color.PeachPuff
        Me.cmdSalir.Location = New System.Drawing.Point(330, 268)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(93, 36)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.cmdComprar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblTeatro)
        Me.Controls.Add(Me.lblTitulo)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTeatro As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents cmdComprar As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
