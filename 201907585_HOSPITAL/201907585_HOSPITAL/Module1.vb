Module Module1
    Public HOSPITAL(6, 9) As String
    Public indice As Byte = 0
    Public habitacion_seleccionada = 0
    Public habitacion_privada = 350.0
    Public habitacion_semiprivada = 250.0
    Public habitacion_noprivada = 150.0
    Public descuento_final As Double
    Public recargo_final As Double
    Public descuento_efectivo = 0.1
    Public descuento_transfererencia = 0.08
    Public recargo_tarjeta = 0.015
    Public pago_parcial As Double
    Public pago_total As Double
    Public pago_descuento As Double
    Public l As Byte

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        l = 0
        comprobar_repetido = True
        While (l <= 6) And (encontrado)

            If (HOSPITAL(l, 0) <> Nothing) Then

                If (HOSPITAL(l, 1) = Val(Form1.TextBox6.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    l = l + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function

    Public Sub inicializar_ingreso()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox6.Text = ""
    End Sub

    Public Sub mostrar_matriz()

        inicializar_ingreso()

        Form1.DataGridView1.Rows.Clear()

        l = 0
        While (l <= 5)

            If (HOSPITAL(l, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(HOSPITAL(l, 0), HOSPITAL(l, 1), HOSPITAL(l, 2), HOSPITAL(l, 3), HOSPITAL(l, 4), HOSPITAL(l, 5), HOSPITAL(l, 6), HOSPITAL(l, 7), HOSPITAL(l, 8))
            Else
                Exit While
            End If
            l = l + 1
        End While

    End Sub

    Public Sub limpiar_matriz()
        Dim J As Byte
        Form1.DataGridView1.Rows.Clear()
        indice = 0
        l = 0
        J = 0
        While (l <= 5)
            J = 0
            While (J <= 8)
                HOSPITAL(l, J) = Nothing
                J = J + 1
            End While
            l = l + 1
        End While
        MsgBox("Se limpio la Matriz", Title:="Sistema Hospital")

    End Sub

End Module
