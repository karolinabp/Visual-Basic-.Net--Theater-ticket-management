Public Class Form4

    'Al pulsar Atrás se volverá a codificar el campo CVC y se cerrará el formulario
    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        txtCvc.PasswordChar = "*"
        Me.Close()
    End Sub

    'Procedimiento que comprueba si el número de tarjeta es válido
    'Comprueba la longitud, si está vacío y si es numérico, si no activará un mensaje de error
    Private Sub comprobarNumero(txt As TextBox, lbl As Label, txtLenght As Integer)
        If txt.Text <> "" Then
            If IsNumeric(txt.Text) And Len(txt.Text) = txtLenght Then
                lbl.Visible = False
            Else
                txt.Text = ""
                lbl.Text = "Formato no válido"
                lbl.Visible = True
            End If
        Else
            lbl.Text = "Campo obligatorio"
            lbl.Visible = True
        End If
    End Sub

    'Procedimiento que comprueba si el titular de la tarjeta es válido
    'Comprueba si esta vacío, si no activará un mensaje de error
    Private Sub comprobarTitular()
        If txtTitular.Text <> "" Then
            lblTitularError.Visible = False
        Else
            txtTitular.Text = ""
            lblTitularError.Visible = True
        End If
    End Sub

    'Procedimiento que comprueba si una cadena contiene otra
    Private Function contieneCadena(cadena As String, letra As String)
        Dim encontrado As Boolean
        encontrado = False
        For Each i In cadena
            If i = letra Then encontrado = True
        Next
        Return encontrado

    End Function

    'Procedimiento que comprueba si el correo es válido
    'Comprueba si esta vacío y si contiene el caracter @, si no activará un mensaje de error
    Private Sub comprobarCorreo()
        If txtCorreo.Text <> "" And contieneCadena(txtCorreo.Text, "@") Then
            lblCorreoError.Visible = False
        Else
            txtCorreo.Text = ""
            lblCorreoError.Visible = True
        End If
    End Sub
    'Procedimiento que comprueba si la fecha es válida
    'Comprueba si la fecha es mayor que el día actual, si no activará un mensaje de error
    Private Sub comprobarFecha()
        If DateTimePicker1.Value < Date.Now() Then
            lblFechaError.Visible = True
        Else
            lblFechaError.Visible = False
        End If
    End Sub

    'Procedimiento que limpia el formulario vaciando todos los campos
    Private Sub limpiarFormulario()
        txtNumero.Text = ""
        DateTimePicker1.ResetText()
        txtTitular.Text = ""
        txtCvc.Text = ""
        txtCvc.PasswordChar = "*"
        txtCorreo.Text = ""

    End Sub

    'Al pulsar en Pagar se comprueba si no ha saltado ningún mensaje de error
    'Genera un ticket de compra en el Formulario 5
    'Limpia los Formularios 2 y 3
    'Si se ha seleccionado No, se limpia el formulario actual (Los datos de compra)
    'Activa el Formulario 5 con el Ticket
    Private Sub cmdPagar_Click(sender As Object, e As EventArgs) Handles cmdPagar.Click
        comprobarNumero(txtNumero, lblNumeroError, 16)
        comprobarTitular()
        comprobarCorreo()
        comprobarFecha()
        comprobarNumero(txtCvc, lblCvcError, 3)
        If lblNumeroError.Visible = False And
                lblTitularError.Visible = False And
                lblCorreoError.Visible = False And
                lblFechaError.Visible = False And
                lblCvcError.Visible = False Then

            txtCvc.PasswordChar = "*"
            Form5.lblPrecio.Text = "Total: " + Str(Form2.getPrecio()) + " €"
            Form5.lblEntradasCorreo.Text = "Entradas enviadas a:   " + txtCorreo.Text
            Form3.limpiarEleccion("green", "gray")
            Form2.limpiarFormulario()
            If rbNo.Checked = True Then limpiarFormulario()
            Form5.Show()

        End If
    End Sub

    'Al pulsar el botón se descodifica el campo CVC y si ya estaba visible, se codifica
    Private Sub cmdVer_Click(sender As Object, e As EventArgs) Handles cmdVer.Click
        If txtCvc.PasswordChar = "*" Then
            txtCvc.PasswordChar = ""
        Else
            txtCvc.PasswordChar = "*"
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class