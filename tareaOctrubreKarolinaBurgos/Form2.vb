Imports System.Runtime.CompilerServices

Public Class Form2
    Dim numEntradas As Integer
    Dim precio As Double

    Public Function getPrecio()
        Return precio
    End Function

    'Función que establece los precios tomando como entrada la cantidad de entradas y su precio
    Private Sub establecerPrecios(lblCantidad As Label, lblPrecio As Label)
        lblTotalEntradas.Text = numEntradas
        lblPrecio.Text = Str(Int(lblCantidad.Text) * 12) & " €"
        precio = (Int(lblGeneralCantidad.Text) * 12) + (Int(lblEstudianteCantidad.Text) * 7.5)
        lblPrecioTotal.Text = Str(precio) & " €"
    End Sub

    'Función que realiza operaciones al hacer click en el botón de sumar, se usará tanto para las entradas generales , como lara las de estudiantes
    Private Sub sumarEntradas(lblCantidad As Label, lblPrecio As Label)
        Dim aforo As Integer
        aforo = 32 - pgbCompleto.Value
        'Si las entradas elegidas son menores que 6 y que las entradas disponibles, se incrementará
        'Si no, resaltará las advertencias (6 entradas máximo o aforo)
        If numEntradas < 6 Then
            If numEntradas < aforo Then
                lblCantidad.Text = lblCantidad.Text + 1
                numEntradas = Int(lblGeneralCantidad.Text) + Int(lblEstudianteCantidad.Text)
                lblTextoEntradas2.ForeColor = Color.FromArgb(240, 240, 210)
            Else
                lblPorcentaje.BackColor = Color.White
                lblPorcentaje.ForeColor = Color.FromArgb(200, 0, 0)
            End If
        Else
            lblTextoEntradas2.ForeColor = Color.FromArgb(200, 0, 0)
            lblTextoEntradas2.BackColor = Color.FromName("white")
        End If
        establecerPrecios(lblCantidad, lblPrecio)
        'Se podrá pasar al siguiente formulario cuando el total de entradas sea mayor que 0
        If lblTotalEntradas.Text <> "0" Then cmdAsientos.Enabled = True
    End Sub

    'Función que resta las entradas tanto generales, como para estudiantes
    Private Sub restarEntradas(lblCantidad As Label, lblPrecio As Label)
        'Si el total de entradas y las entradas que se quieren restar son mayor que 0 se restarán las entradas
        If numEntradas > 0 And lblCantidad.Text > 0 Then
            lblCantidad.Text = lblCantidad.Text - 1
            numEntradas = Int(lblGeneralCantidad.Text) + Int(lblEstudianteCantidad.Text)
            lblTextoEntradas2.ForeColor = Color.FromArgb(240, 240, 210)
            lblTextoEntradas2.BackColor = Color.FromName("Transparent")
            lblPorcentaje.ForeColor = Color.FromArgb(240, 240, 210)
            lblPorcentaje.BackColor = Color.FromName("Transparent")
        End If
        establecerPrecios(lblCantidad, lblPrecio)
        'Si no se selecciona ninguna entrada no se podrá pasar al siguiente Formulario
        If numEntradas = 0 Then
            cmdAsientos.Enabled = False
        End If
    End Sub

    Private Sub cmdGeneralMas_Click(sender As Object, e As EventArgs) Handles cmdGeneralMas.Click

        sumarEntradas(lblGeneralCantidad, lblGeneralPrecio)

    End Sub

    Private Sub cmdEstudianteMas_Click(sender As Object, e As EventArgs) Handles cmdEstudianteMas.Click

        sumarEntradas(lblEstudianteCantidad, lblEstudiantePrecio)

    End Sub


    Private Sub cmdGeneralMenos_Click(sender As Object, e As EventArgs) Handles cmdGeneralMenos.Click
        restarEntradas(lblGeneralCantidad, lblGeneralPrecio)
    End Sub



    Private Sub cmdEstudianteMenos_Click(sender As Object, e As EventArgs) Handles cmdEstudianteMenos.Click
        restarEntradas(lblEstudianteCantidad, lblEstudiantePrecio)
    End Sub

    'Función que resetea el formulario entero
    Public Sub limpiarFormulario()
        lblGeneralCantidad.Text = "0"
        lblEstudianteCantidad.Text = "0"
        lblTotalEntradas.Text = "0"
        lblGeneralPrecio.Text = "0 €"
        lblEstudiantePrecio.Text = "0 €"
        lblPrecioTotal.Text = "0 €"
        lblTextoEntradas2.BackColor = Color.Transparent
        lblTextoEntradas2.ForeColor = Color.FromArgb(240, 240, 210)
        numEntradas = 0
        precio = 0
        cmdAsientos.Enabled = False
    End Sub

    'Al pulsar Atrás se limpia el formulario actual y se cierra
    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        limpiarFormulario()
        Me.Close()
    End Sub

    'Al pulsar el botón Elegir asientos se establece en el Formulario 3 el número total de entradas  y lo muestra
    Private Sub cmdAsientos_Click(sender As Object, e As EventArgs) Handles cmdAsientos.Click
        Form3.lblTotalEntradas.Text = lblTotalEntradas.Text
        Form3.ShowDialog()
    End Sub


End Class