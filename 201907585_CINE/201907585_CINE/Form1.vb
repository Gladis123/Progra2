Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click














        'Envio de la funcion y cine
        If Indice < 9 Then
            vfuncion(Indice) = BoxFuncion.SelectedItem
            vCine(Indice) = BoxCine.SelectedItem
            Subtotal_pagar(Indice) = calcularSubtotal(vfuncion(Indice), vCine(Indice))
            vDescuento1(Indice) = Subtotal_pagar(Indice) * CalculoDescuento1(vfuncion(Indice), vCine(Indice))


            Funcion.Items.Add(vfuncion(Indice))
            Cine.Items.Add(vCine(Indice))
            Subtotal.Items.Add(Subtotal_pagar(Indice))
            Descuento1.Items.Add(vDescuento1(Indice))



            Subtotal_pagar(Indice) = Subtotal_pagar
            vDescuento1(Indice) = CalculoDescuento1(vfuncion(Indice), vCine(Indice))
            vDescuento2(Indice) = CalculoDescuento2(subtotal_2)

            total_ = Calculo_Subtotal - CalculoDescuento1(vfuncion(Indice), vCine(Indice)) - CalculoDescuento2(subtotal_2)

            vTotal(Indice) = total_



            Indice = Indice + 1




        ElseIf Indice >= 9 Then

        End If



    End Sub







    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click

        LimpiarCampos(Me)


    End Sub

    Private Sub Button_LimpiarL_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click

        Limpiar_Listas()

    End Sub

    Private Sub Button_LimpiarE_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click


        Limpiar_entradas()

    End Sub

    Private Sub Button_LimpiarV_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click

        Limpiar_vectores()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SalirBTN.Click
        If MsgBox("Está seguro que desea salir ?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
