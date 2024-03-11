Public Class Form3
    Dim totalEntradas As Integer
    Dim entradasElegidas = 0

    'Procedimiento que deselecciona las butacas y cierra el formulario
    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        limpiarEleccion("green", "white")
        Me.Close()
    End Sub

    'Procedimiento que recoge las butacas reservadas en un String para imprimirlo en el ticket del Formulario 5
    Private Sub generarButacas()
        Dim butacas, fila, asiento As String
        butacas = ""
        For i = 0 To (listaEntradas.Items.Count - 1)
            fila = Mid(listaEntradas.Items.Item(i), 9, 1)
            asiento = Mid(listaEntradas.Items.Item(i), 8, 1)
            butacas = butacas + "Fila " + fila + ", asiento " + asiento + vbCr
        Next
        Form5.lblButacas.Text = butacas
    End Sub

    'Al pulsar Pagar se llama al procedimiento generarButacas() y abre el Formulario 4
    Private Sub cmdPagar_Click(sender As Object, e As EventArgs) Handles cmdPagar.Click
        generarButacas()
        Form4.ShowDialog()
    End Sub

    'Función que devuelve la cantidad de butacas seleccionadas
    Public Function butacasReservadas()
        Dim numButacas As Integer
        numButacas = 0

        If cmd1A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd2A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd3A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd4A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd5A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd6A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd7A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd8A.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1

        If cmd1B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd2B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd3B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd4B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd5B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd6B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd7B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd8B.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1

        If cmd1C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd2C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd3C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd4C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd5C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd6C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd7C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd8C.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1

        If cmd1D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd2D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd3D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd4D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd5D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd6D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd7D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1
        If cmd8D.BackColor = Color.FromName("gray") Then numButacas = numButacas + 1

        Return numButacas
    End Function

    'Procedimiento que limpia el las seleciones y decide el nuevo color de las butacas
    Public Sub limpiarEleccion(colorAntiguo As String, colorNuevo As String)

        entradasElegidas = 0

        listaEntradas.Items.Clear()

        lblTotalEntradas.ForeColor = Color.FromName("PeachPuff")
        lblTotalEntradas.BackColor = Color.Transparent

        If cmd1A.BackColor = Color.FromName(colorAntiguo) Then cmd1A.BackColor = Color.FromName(colorNuevo)
        If cmd2A.BackColor = Color.FromName(colorAntiguo) Then cmd2A.BackColor = Color.FromName(colorNuevo)
        If cmd3A.BackColor = Color.FromName(colorAntiguo) Then cmd3A.BackColor = Color.FromName(colorNuevo)
        If cmd4A.BackColor = Color.FromName(colorAntiguo) Then cmd4A.BackColor = Color.FromName(colorNuevo)
        If cmd5A.BackColor = Color.FromName(colorAntiguo) Then cmd5A.BackColor = Color.FromName(colorNuevo)
        If cmd6A.BackColor = Color.FromName(colorAntiguo) Then cmd6A.BackColor = Color.FromName(colorNuevo)
        If cmd7A.BackColor = Color.FromName(colorAntiguo) Then cmd7A.BackColor = Color.FromName(colorNuevo)
        If cmd8A.BackColor = Color.FromName(colorAntiguo) Then cmd8A.BackColor = Color.FromName(colorNuevo)

        If cmd1B.BackColor = Color.FromName(colorAntiguo) Then cmd1B.BackColor = Color.FromName(colorNuevo)
        If cmd2B.BackColor = Color.FromName(colorAntiguo) Then cmd2B.BackColor = Color.FromName(colorNuevo)
        If cmd3B.BackColor = Color.FromName(colorAntiguo) Then cmd3B.BackColor = Color.FromName(colorNuevo)
        If cmd4B.BackColor = Color.FromName(colorAntiguo) Then cmd4B.BackColor = Color.FromName(colorNuevo)
        If cmd5B.BackColor = Color.FromName(colorAntiguo) Then cmd5B.BackColor = Color.FromName(colorNuevo)
        If cmd6B.BackColor = Color.FromName(colorAntiguo) Then cmd6B.BackColor = Color.FromName(colorNuevo)
        If cmd7B.BackColor = Color.FromName(colorAntiguo) Then cmd7B.BackColor = Color.FromName(colorNuevo)
        If cmd8B.BackColor = Color.FromName(colorAntiguo) Then cmd8B.BackColor = Color.FromName(colorNuevo)

        If cmd1C.BackColor = Color.FromName(colorAntiguo) Then cmd1C.BackColor = Color.FromName(colorNuevo)
        If cmd2C.BackColor = Color.FromName(colorAntiguo) Then cmd2C.BackColor = Color.FromName(colorNuevo)
        If cmd3C.BackColor = Color.FromName(colorAntiguo) Then cmd3C.BackColor = Color.FromName(colorNuevo)
        If cmd4C.BackColor = Color.FromName(colorAntiguo) Then cmd4C.BackColor = Color.FromName(colorNuevo)
        If cmd5C.BackColor = Color.FromName(colorAntiguo) Then cmd5C.BackColor = Color.FromName(colorNuevo)
        If cmd6C.BackColor = Color.FromName(colorAntiguo) Then cmd6C.BackColor = Color.FromName(colorNuevo)
        If cmd7C.BackColor = Color.FromName(colorAntiguo) Then cmd7C.BackColor = Color.FromName(colorNuevo)
        If cmd8C.BackColor = Color.FromName(colorAntiguo) Then cmd8C.BackColor = Color.FromName(colorNuevo)

        If cmd1D.BackColor = Color.FromName(colorAntiguo) Then cmd1D.BackColor = Color.FromName(colorNuevo)
        If cmd2D.BackColor = Color.FromName(colorAntiguo) Then cmd2D.BackColor = Color.FromName(colorNuevo)
        If cmd3D.BackColor = Color.FromName(colorAntiguo) Then cmd3D.BackColor = Color.FromName(colorNuevo)
        If cmd4D.BackColor = Color.FromName(colorAntiguo) Then cmd4D.BackColor = Color.FromName(colorNuevo)
        If cmd5D.BackColor = Color.FromName(colorAntiguo) Then cmd5D.BackColor = Color.FromName(colorNuevo)
        If cmd6D.BackColor = Color.FromName(colorAntiguo) Then cmd6D.BackColor = Color.FromName(colorNuevo)
        If cmd7D.BackColor = Color.FromName(colorAntiguo) Then cmd7D.BackColor = Color.FromName(colorNuevo)
        If cmd8D.BackColor = Color.FromName(colorAntiguo) Then cmd8D.BackColor = Color.FromName(colorNuevo)

    End Sub

    'Este procedimmiento selecciona y deselecciona las butacas
    Private Sub elegirButaca(cmd As Button)
        Dim butaca As String
        butaca = Mid(cmd.Name, 4)
        totalEntradas = Int(Form2.lblTotalEntradas.Text)
        'Si las butacas son blancas se pueden seleccionar, solamente 6 por transacción
        'También se añadirán a listaEntradas, cada butaca como un item
        If cmd.BackColor = Color.FromName("white") Then
            If entradasElegidas < totalEntradas Then
                cmd.BackColor = Color.FromName("green")
                entradasElegidas = entradasElegidas + 1
                lblTotalEntradas.ForeColor = Color.FromName("PeachPuff")
                lblTotalEntradas.BackColor = Color.Transparent
                listaEntradas.Items.Add("Butaca " + butaca)
            Else
                'Se resaltará el total de entradas posibles en caso de seleccionar más entradas
                lblTotalEntradas.ForeColor = Color.FromName("red")
                lblTotalEntradas.BackColor = Color.White
            End If
        ElseIf cmd.BackColor = Color.FromName("green") Then
            'Si la butaca es verde se deseleccionará y se eliminará de listaEntradas
            cmd.BackColor = Color.FromName("white")
            lblTotalEntradas.ForeColor = Color.FromName("PeachPuff")
            lblTotalEntradas.BackColor = Color.Transparent
            entradasElegidas = entradasElegidas - 1
            listaEntradas.Items.Remove("Butaca " + butaca)
        End If

        'Si las entradas seleccionadas coinciden con el total de entradas exigidas en el anterior Formulario se permitirá pagar
        If listaEntradas.Items.Count < totalEntradas Then
            cmdPagar.Enabled = False
        Else
            cmdPagar.Enabled = True
        End If

    End Sub


    'Al pulsar los siguientes botones se seleccionan o deseleccionan las butacas
    '________________________________FILA A______________________________________

    Private Sub cmd1A_Click(sender As Object, e As EventArgs) Handles cmd1A.Click
        elegirButaca(cmd1A)

    End Sub

    Private Sub cmd2A_Click(sender As Object, e As EventArgs) Handles cmd2A.Click
        elegirButaca(cmd2A)
    End Sub

    Private Sub cmd3A_Click(sender As Object, e As EventArgs) Handles cmd3A.Click
        elegirButaca(cmd3A)
    End Sub

    Private Sub cmd4A_Click(sender As Object, e As EventArgs) Handles cmd4A.Click
        elegirButaca(cmd4A)
    End Sub

    Private Sub cmd5A_Click(sender As Object, e As EventArgs) Handles cmd5A.Click
        elegirButaca(cmd5A)
    End Sub

    Private Sub cmd6A_Click(sender As Object, e As EventArgs) Handles cmd6A.Click
        elegirButaca(cmd6A)
    End Sub

    Private Sub cmd7A_Click(sender As Object, e As EventArgs) Handles cmd7A.Click
        elegirButaca(cmd7A)
    End Sub

    Private Sub cmd8A_Click(sender As Object, e As EventArgs) Handles cmd8A.Click
        elegirButaca(cmd8A)
    End Sub


    '________________________________FILA B______________________________________


    Private Sub cmd1B_Click(sender As Object, e As EventArgs) Handles cmd1B.Click
        elegirButaca(cmd1B)
    End Sub
    Private Sub cmd2B_Click(sender As Object, e As EventArgs) Handles cmd2B.Click
        elegirButaca(cmd2B)
    End Sub
    Private Sub cmd3B_Click(sender As Object, e As EventArgs) Handles cmd3B.Click
        elegirButaca(cmd3B)
    End Sub

    Private Sub cmd4B_Click(sender As Object, e As EventArgs) Handles cmd4B.Click
        elegirButaca(cmd4B)
    End Sub

    Private Sub cmd5B_Click(sender As Object, e As EventArgs) Handles cmd5B.Click
        elegirButaca(cmd5B)
    End Sub

    Private Sub cmd6B_Click(sender As Object, e As EventArgs) Handles cmd6B.Click
        elegirButaca(cmd6B)
    End Sub

    Private Sub cmd7B_Click(sender As Object, e As EventArgs) Handles cmd7B.Click
        elegirButaca(cmd7B)
    End Sub

    Private Sub cmd8B_Click(sender As Object, e As EventArgs) Handles cmd8B.Click
        elegirButaca(cmd8B)
    End Sub


    '________________________________FILA C______________________________________

    Private Sub cmd1C_Click(sender As Object, e As EventArgs) Handles cmd1C.Click
        elegirButaca(cmd1C)
    End Sub

    Private Sub cmd2C_Click(sender As Object, e As EventArgs) Handles cmd2C.Click
        elegirButaca(cmd2C)
    End Sub

    Private Sub cmd3C_Click(sender As Object, e As EventArgs) Handles cmd3C.Click
        elegirButaca(cmd3C)
    End Sub

    Private Sub cmd4C_Click(sender As Object, e As EventArgs) Handles cmd4C.Click
        elegirButaca(cmd4C)
    End Sub

    Private Sub cmd5C_Click(sender As Object, e As EventArgs) Handles cmd5C.Click
        elegirButaca(cmd5C)
    End Sub

    Private Sub cmd6C_Click(sender As Object, e As EventArgs) Handles cmd6C.Click
        elegirButaca(cmd6C)
    End Sub

    Private Sub cmd7C_Click(sender As Object, e As EventArgs) Handles cmd7C.Click
        elegirButaca(cmd7C)
    End Sub

    Private Sub cmd8C_Click(sender As Object, e As EventArgs) Handles cmd8C.Click
        elegirButaca(cmd8C)
    End Sub


    '________________________________FILA D______________________________________

    Private Sub cmd1D_Click(sender As Object, e As EventArgs) Handles cmd1D.Click
        elegirButaca(cmd1D)
    End Sub

    Private Sub cmd2D_Click(sender As Object, e As EventArgs) Handles cmd2D.Click
        elegirButaca(cmd2D)
    End Sub

    Private Sub cmd3D_Click(sender As Object, e As EventArgs) Handles cmd3D.Click
        elegirButaca(cmd3D)
    End Sub

    Private Sub cmd4D_Click(sender As Object, e As EventArgs) Handles cmd4D.Click
        elegirButaca(cmd4D)
    End Sub

    Private Sub cmd5D_Click(sender As Object, e As EventArgs) Handles cmd5D.Click
        elegirButaca(cmd5D)
    End Sub

    Private Sub cmd6D_Click(sender As Object, e As EventArgs) Handles cmd6D.Click
        elegirButaca(cmd6D)
    End Sub

    Private Sub cmd7D_Click(sender As Object, e As EventArgs) Handles cmd7D.Click
        elegirButaca(cmd7D)
    End Sub

    Private Sub cmd8D_Click(sender As Object, e As EventArgs) Handles cmd8D.Click
        elegirButaca(cmd8D)
    End Sub

End Class