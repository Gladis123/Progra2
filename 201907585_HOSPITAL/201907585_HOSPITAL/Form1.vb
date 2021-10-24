Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then

            MsgBox("Por favor ingrese todos los datos ", Title:="Sistema Hospital")
            Exit Sub

        End If

        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Por favor ingrese todos los datos ", Title:="Sistema Hospital")
            Exit Sub
        End If

        If comprobar_repetido() Then
            If (indice <= 5) Then

                HOSPITAL(indice, 0) = (TextBox1.Text)
                HOSPITAL(indice, 1) = Val(TextBox2.Text)
                HOSPITAL(indice, 2) = Val(TextBox3.Text)
                HOSPITAL(indice, 3) = Val(TextBox4.Text)

                Select Case ComboBox1.SelectedIndex
                    Case 0 : HOSPITAL(indice, 4) = "1. PRIVADA"
                        habitacion_seleccionada = habitacion_privada
                    Case 1 : HOSPITAL(indice, 4) = "2. SEMIPRIVADA"
                        habitacion_seleccionada = habitacion_semiprivada
                    Case 2 : HOSPITAL(indice, 4) = "3. NO PRIVADA"
                        habitacion_seleccionada = habitacion_noprivada
                End Select

                Select Case ComboBox2.SelectedIndex


                    Case 0 : HOSPITAL(indice, 5) = "EFECTIVO"
                        descuento_final = descuento_efectivo
                        HOSPITAL(indice, 7) = 0
                        HOSPITAL(indice, 6) = descuento_efectivo
                        pago_parcial = (Val(TextBox4.Text) + (Val(TextBox3.Text) * habitacion_seleccionada))
                        pago_descuento = pago_parcial * descuento_final
                        pago_total = pago_parcial - pago_descuento
                        HOSPITAL(indice, 8) = pago_total

                    Case 1 : HOSPITAL(indice, 5) = "TRANSFERENCIA ACH"
                        descuento_final = descuento_transfererencia
                        HOSPITAL(indice, 7) = 0
                        HOSPITAL(indice, 6) = descuento_transfererencia
                        pago_parcial = (Val(TextBox4.Text) + (Val(TextBox3.Text) * habitacion_seleccionada))
                        pago_descuento = pago_parcial * descuento_final
                        pago_total = pago_parcial - pago_descuento
                        HOSPITAL(indice, 8) = pago_total

                    Case 2 : HOSPITAL(indice, 5) = "DEPÓSITO BANCARIO"
                        descuento_final = descuento_efectivo
                        HOSPITAL(indice, 7) = 0
                        HOSPITAL(indice, 6) = descuento_efectivo
                        pago_parcial = (Val(TextBox4.Text) + (Val(TextBox3.Text) * habitacion_seleccionada))
                        pago_descuento = pago_parcial * descuento_final
                        pago_total = pago_parcial - pago_descuento
                        HOSPITAL(indice, 8) = pago_total

                    Case 3 : HOSPITAL(indice, 5) = "TARJETA DE CRÉDITO"
                        recargo_final = recargo_tarjeta
                        HOSPITAL(indice, 6) = 0
                        HOSPITAL(indice, 7) = recargo_tarjeta
                        pago_parcial = (Val(TextBox4.Text) + (Val(TextBox3.Text) * habitacion_seleccionada))
                        pago_descuento = pago_parcial * recargo_final
                        pago_total = pago_parcial + pago_descuento
                        HOSPITAL(indice, 8) = pago_total


                    Case 4 : HOSPITAL(indice, 5) = "SEGURO MÉDICO"
                        HOSPITAL(indice, 6) = 0
                        HOSPITAL(indice, 7) = 0
                        pago_parcial = (Val(TextBox4.Text) + (Val(TextBox3.Text) * habitacion_seleccionada))
                        HOSPITAL(indice, 8) = pago_parcial
                End Select

                indice = indice + 1
                MsgBox("Registrado con éxito", Title:="Sistema Hospital")
                inicializar_ingreso()
            End If
        Else
            MsgBox("NIT repetido ", Title:="Sistema Hospital")
            TextBox2.Focus()
        End If
        If (indice = 6) Then
            MsgBox("Matriz Llena")
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_matriz()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARoolStripMenuItem.Click
        Dim existe As Boolean = True
        l = 0

        While (l <= 5) And (existe)
            If (HOSPITAL(l, 0) <> Nothing) Then
                If (Val(HOSPITAL(l, 1)) = Val(TextBox6.Text)) Then
                    existe = False
                Else
                    l = l + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("NIT no encontrado", Title:="Sistema Hospital")
            TextBox6.Focus()
        Else

            MsgBox("Registro encontrado", Title:="Sistema Hospital")

            TextBox1.Text = HOSPITAL(l, 0)
            TextBox2.Text = HOSPITAL(l, 1)
            TextBox3.Text = HOSPITAL(l, 2)
            TextBox4.Text = HOSPITAL(l, 3)
            ComboBox1.Text = HOSPITAL(l, 4)
            ComboBox2.Text = HOSPITAL(l, 5)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(HOSPITAL(l, 0), HOSPITAL(l, 1), HOSPITAL(l, 2), HOSPITAL(l, 3), HOSPITAL(l, 4), HOSPITAL(l, 5), HOSPITAL(l, 6), HOSPITAL(l, 7), HOSPITAL(l, 8))
            indice = l
        End If
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        inicializar_ingreso()
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub ESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem.Click

        Dim r1 As Integer = 0
        Dim r2 As Integer = 0
        Dim r3 As Integer = 0

        l = 0

        While (l <= 5)

            If (HOSPITAL(l, 0) <> Nothing) Then

                If HOSPITAL(l, 4) = "1. PRIVADA" Then
                    r1 = r1 + 1

                End If

                If HOSPITAL(l, 5) = "TRANSFERENCIA ACH" Then
                    r2 = r2 + (Val(HOSPITAL(l, 8)))

                End If

                If HOSPITAL(l, 4) = "3. NO PRIVADA" Then
                    r3 = r3 + (Val(HOSPITAL(l, 2)))

                End If

                l = l + 1
            Else
                Exit While
            End If
        End While

        TextBox5.Text = r1
        TextBox7.Text = r2
        TextBox8.Text = r3


    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir ?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub




End Class
