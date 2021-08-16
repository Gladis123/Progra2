Public Class Form1
    Private Sub Button1CALCULAR_Click(sender As Object, e As EventArgs) Handles Button1CALCULAR.Click


        'ahorro'
        If RadioButton3.Checked = True Then
            Select Case Saldo_Nuevo
                Case 1.01 To 1000.99
                    Interes = 1.5 / 100
                Case 1001 To 5000.99
                    Interes = 2.5 / 100
                Case 5001 To 15000.99
                    Interes = 7.5 / 100
                Case Is >= 15001
                    Interes = 10 / 100


            End Select
            Saldo_Nuevo = Val(CheckBox1CP.Text) + Val(CheckBox2COB.Text) + Val(CheckBox3EFEC.Text) + Val(SALDOANTERIORBox4.Text)
            Saldo_Nuevo = Saldo_Nuevo + Saldo_Nuevo * Interes
            Label4SALDONUEVO.Text = Str(Saldo_Nuevo)
        End If

        'premier'
        If RadioButton2.Checked = True Then
            Select Case Val(SALDOANTERIORBox4.Text)
                Case 1.01 To 10000.99
                    Interes = 2.5 / 100
                Case 10001 To 15000.99
                    Interes = 3 / 100
                Case Is >= 15001
                    Interes = 4.5 / 100

            End Select
            Saldo_Nuevo = Val(CheckBox1CP.Text) + Val(CheckBox2COB.Text) + Val(CheckBox3EFEC.Text) + Val(SALDOANTERIORBox4.Text) * Interes
            Label4SALDONUEVO.Text = Str(Saldo_Nuevo)
        End If



        'monetario'
        If RadioButton1.Checked = True Then
            Saldo_Nuevo = Val(CheckBox1CP.Text) + Val(CheckBox2COB.Text) + Val(CheckBox3EFEC.Text) + Val(SALDOANTERIORBox4.Text)
            Label4SALDONUEVO.Text = Str(Saldo_Nuevo)

        End If

        Label4Interes.Text = Str(Interes * 100) + "%"


    End Sub
    'habilita'

    Private Sub CheckBox1CP_CheckedChanged(Sender As Object, e As EventArgs) Handles CheckBox1CP.CheckedChanged

        If RadioButton1.Checked = True Then
            TipoSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            TipoSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            TipoSeleccionado = True

        End If


        If TipoSeleccionado = True Then
            If CheckBox1CP.Checked = True Then
                CheckBox1CP.Enabled = True

            End If

            If CheckBox1CP.Checked = False Then
                CheckBox1CP.Enabled = False

            End If

        End If


    End Sub

    'Habilita2'

    Private Sub CheckBox2COB_CheckedChanged(Sender As Object, e As EventArgs) Handles CheckBox2COB.CheckedChanged

        If RadioButton1.Checked = True Then
            TipoSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            TipoSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            TipoSeleccionado = True

        End If

        If TipoSeleccionado = True Then
            If CheckBox2COB.Checked = True Then
                CheckBox2COB.Enabled = True

            End If

            If CheckBox2COB.Checked = False Then
                CheckBox2COB.Enabled = False

            End If
        End If


    End Sub

    'Habilita 3'

    Private Sub CheckBox3EFEC_CheckedChanged(Sender As Object, e As EventArgs) Handles CheckBox3EFEC.CheckedChanged

        If RadioButton1.Checked = True Then
            TipoSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            TipoSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            TipoSeleccionado = True

        End If

        If TipoSeleccionado = True Then
            If CheckBox3EFEC.Checked = True Then
                CheckBox3EFEC.Enabled = True

            End If

            If CheckBox3EFEC.Checked = False Then
                CheckBox3EFEC.Enabled = False

            End If
        End If

    End Sub

    Private Sub Label4Interes_Click(sender As Object, e As EventArgs) Handles Label4Interes.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2LIMPIAR_Click(sender As Object, e As EventArgs) Handles Button2LIMPIAR.Click
        limpiarCampos(Me)
    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click

        Pregunta = MsgBox("Desea salir", vbYesNo + vbQuestion, "ADVERTENCIA")

        If Pregunta = vbNo Then

            MsgBox("CANCELADO")

        Else
            MsgBox("OK")
            End

        End If

    End Sub
End Class
