Public Class Form1
    'Función que comprueba las butacas disponibles con una función del Formulario 3 (butacasReservadas())
    Private Sub comprobarAforo()
        Form2.pgbCompleto.Value = Form3.butacasReservadas()
        Form2.lblPorcentaje.Text = "Aforo: " + Str(Math.Round(Form3.butacasReservadas() * 100 / 32)) + "%"
    End Sub

    'Al darle click al botón, comprueba el aforo y abre el Formulario 2
    Private Sub cmdComprar_Click(sender As Object, e As EventArgs) Handles cmdComprar.Click
        comprobarAforo()
        Form2.ShowDialog()
    End Sub

    'El botón de salir cierra el Formulario
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

End Class
