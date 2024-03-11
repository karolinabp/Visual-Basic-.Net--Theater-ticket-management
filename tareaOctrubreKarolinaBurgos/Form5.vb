Public Class Form5

    'Al aceptar se cerrarán todos los formularios y volverá al primero para seguir comprando  o salir
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Me.Close()
    End Sub

End Class