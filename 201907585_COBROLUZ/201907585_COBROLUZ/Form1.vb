Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (TxtUsuario.Text = "") Then

            MsgBox("Ingrese su nombre por favor", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            TxtUsuario.Focus()

        End If

        If (TxtNit.Text = "") Then

            MsgBox("Ingrese su NIT por favor", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            TxtUsuario.Focus()

        End If

        If (TxtConsumo.Text = "") Then

            MsgBox("Ingrese el consumo de kilowatts por favor", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            TxtUsuario.Focus()

        End If

        If (TxtSaldoAnterior.Text = "") Then

            MsgBox("Ingrese el saldo anterior por favor, de no existir colocar 0", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            TxtSaldoAnterior.Focus()

        End If

        If (indice <= 11) Then

            Cliente(indice) = TxtUsuario.Text
            Servicio(indice) = BOXTIPOSERVICIO.Text
            Tarifa(indice) = BOXTIPOTARIFA.Text
            SaldoAnterior(indice) = TxtSaldoAnterior.Text


            If Str(SERVICIO_BOX.Text = "Residencial") Then

                Select Case Val(TxtConsumo.Text)

                    Case 1 To 100
                        total_pagoini = Val(TxtConsumo.Text) * Residencial1
                    Case 101 To 300
                        total_pagoini = Val(TxtConsumo.Text) * Residencial2
                    Case >= 301
                        total_pagoini = Val(TxtConsumo.Text) * Residencial3

                End Select

                PagoInicial(indice) = Math.Round(total_pagoini, 2)

            End If

            If Str(SERVICIO_BOX.Text = "Industrial") Then

                Select Case Val(TxtConsumo.Text)

                    Case 1 To 100
                        total_pagoini = Val(TxtConsumo.Text) * Industrial1
                    Case 101 To 300
                        total_pagoini = Val(TxtConsumo.Text) * Industrial2
                    Case >= 301
                        total_pagoini = Val(TxtConsumo.Text) * Industrial3

                End Select

                PagoInicial(indice) = Math.Round(total_pagoini, 2)

            End If

            If Val(TxtSaldoAnterior.Text) > 0 Then

                total_recargo = (Val(TxtSaldoAnterior.Text) * mora_aplicada)
                Mora(indice) = (mora_aplicada * 100).ToString + "%"

            ElseIf Val(TxtSaldoAnterior.Text) <= 0 Then

                Mora(indice) = "No se aplica mora"

            End If

            total_conmora = Val(TxtSaldoAnterior.Text) + total_recargo
            PMora(indice) = Math.Round(total_conmora, 2)



            Select Case BOXTIPOTARIFA.Text
                Case "Social"


                    total_pagopar = (Val(TxtSaldoAnterior.Text) + total_pagoini) + total_recargo
                    PagoParcial(indice) = total_pagopar


                    total_tarifa = total_pagopar * descuento_social
                    Descuento(indice) = (descuento_social * 100).ToString + "%"

                    total_pagofin = total_pagopar - total_tarifa
                    PagoTotal(indice) = Math.Round(total_pagofin, 2)


                Case "No Social"

                    'Acá me quede programando, únicamente me falta lo último
                    total_tarifa = total_pagoini - (total_pagoini * descuento_nosocial)
                    Descuento(indice) = (descuento_nosocial * 100).ToString + "%"

                    PagoInicial(indice) = Math.Round(total_tarifa, 2)

                    total_pagopar = total_tarifa + total_conmora
                    PagoParcial(indice) = Math.Round(total_pagopar, 2)

                    total_pagofin = total_pagopar

                    PagoTotal(indice) = Math.Round(total_pagofin, 2)

                    MsgBox("Pago por lo realizado", vbExclamation, "Recordatorio")

            End Select

            mostrar()

            indice = indice + 1

        End If

        If (indice > 11) Then

            MsgBox("alcanzo los maximos ingresos")

        End If

        Limpiar_Entradas()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        LimpiarV()

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click

        Limpiar_Entradas()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub

    Private Sub BoxPagoTotal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_PagoTotal.SelectedIndexChanged

    End Sub
End Class
