Public Class Form1
    Private Sub Check_Efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Efectivo.CheckedChanged
        If (Check_Efectivo.Checked = "True") Then

            Text_Efectivo.Enabled = True


        Else
            Text_Efectivo.Enabled = False
            Text_Efectivo.Text = ""

        End If
    End Sub

    Private Sub Check_Tarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Tarjeta.CheckedChanged
        If (Check_Tarjeta.Checked = "True") Then

            Text_Tarjeta.Enabled = True


        Else
            Text_Tarjeta.Enabled = False
            Text_Tarjeta.Text = ""

        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (Text_NIT.Text = "") Then

            MsgBox("Ingrese su NIT por favor", vbQuestion)

            Exit Sub

            Text_NIT.Focus()

        End If

        If (Combo_SeleccioneMarca.Text = "") Then

            MsgBox("Seleccione la marca de vehículo por favor", vbQuestion)


            Exit Sub

            Text_NIT.Focus()

        End If

        If (Text_IngresePlaca.Text = "") Then

            MsgBox("Ingrese su placa por favor", vbQuestion)

            Exit Sub

            Text_IngresePlaca.Focus()

        End If


        If (Text_NoDiasAlquiler.Text = "") Then

            MsgBox("Ingrese los días que alquilara el vehículo por favor", vbQuestion)

            Exit Sub

            Text_NoDiasAlquiler.Focus()

        End If


        If (indice < 6) Then

            Nit(indice) = Text_NIT.Text
            Placa(indice) = Text_IngresePlaca.Text
            Marca(indice) = Combo_SeleccioneMarca.SelectedItem
            Dias(indice) = Text_NoDiasAlquiler.Text

            Parcial(indice) = calcularparcial(Parcial(indice))


            If Check_Efectivo.Checked = True And Check_Tarjeta.Checked = False Then

                If Val(Text_Efectivo.Text) <> 100 Then

                    MsgBox("Error el pago no puede ser procesado si no inserta el 100% de su pago a realizar")

                    Exit Sub

                ElseIf Val(Text_efectivo.Text) = 100 Then

                    MsgBox("Descuento aplicado por pagar en efectivo del 5%")

                    Descuento(indice) = calcularparcial(PagoParcial) * 0.05
                    Total(indice) = Math.Round((PagoParcial - Descuento(indice)), 2)

                End If

            End If

            If Check_Efectivo.Checked = False And Check_Tarjeta.Checked = True Then

                If Val(Text_Tarjeta.Text) <> 100 Then

                    MsgBox("Error el pago no puede ser procesado si no inserta el 100% de su pago a realizar")

                    Exit Sub

                ElseIf Val(Text_Tarjeta.Text) = 100 Then

                    MsgBox("Recargo aplicado por pagar con tarjeta del 2.5%")

                    Descuento(indice) = calcularparcial(PagoParcial) * 0.025
                    Total(indice) = Math.Round((PagoParcial + Descuento(indice)), 2)

                End If


            End If

            If Check_Efectivo.Checked = True And Check_Tarjeta.Checked = True Then

                If (Val(Text_Tarjeta.Text) + Val(Text_Efectivo.Text)) <> 100 Then

                    MsgBox("Error el pago no puede ser procesado si no inserta el 100% de su pago a realizar")

                    Exit Sub
                End If

                If (Val(Text_Tarjeta.Text) + Val(Text_Efectivo.Text)) = 100 Then

                    Descuento(indice) = 0
                    Total(indice) = Math.Round(calcularparcial(PagoParcial), 2)

                End If

            End If

            mostrar_resultado()
            indice = indice + 1

        End If

        If (indice >= 6) Then

            MsgBox("Limite de 6 ingresos alcanzado", vbExclamation, Title:="Sistema dice:")

        End If

    End Sub


    Public Function calcularparcial(ByRef PagoParcial As Double) As Double

        If Combo_SeleccioneMarca.Text = "Honda" Then

            PagoParcial = Honda_dia * Val(Text_NoDiasAlquiler.Text)

        ElseIf Combo_SeleccioneMarca.Text = "Mercedes Benz" Then

            PagoParcial = Mercedes_dia * Val(Text_NoDiasAlquiler.Text)

        ElseIf Combo_SeleccioneMarca.Text = "Toyota" Then

            PagoParcial = Toyota_dia * Val(Text_NoDiasAlquiler.Text)


        ElseIf Combo_SeleccioneMarca.Text = "Mazda" Then

            PagoParcial = Mazda_dia * Val(Text_NoDiasAlquiler.Text)

        End If

        Return PagoParcial

    End Function

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_vectores()
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        Limpiar_Listas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Está seguro que desea salir ?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
