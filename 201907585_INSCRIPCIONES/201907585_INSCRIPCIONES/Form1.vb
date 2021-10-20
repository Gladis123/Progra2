


Public Class Form1

    Private Sub ButtonACEPTAR_Click(sender As Object, e As EventArgs) Handles ButtonACEPTAR.Click

        If TextNOMBRE.Text = "" Or TextCARNET.Text = "" Then
            MsgBox("ERROR DE INGRESO", Title:="Sistema Camino del Saber")
            Exit Sub
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("POR FAVOR SELECCIONE EL NIVEL", Title:="Sistema Camino del Saber")
            Exit Sub

        End If

        If ComboBoxPAGO.SelectedItem = Nothing Then
            MsgBox("ERROR DE INGRESO", Title:="Sistema Camino del Saber")
            Exit Sub
        End If


        If (INDICE1 <= 6) Then

            INSCRIPCIONES(INDICE1, 0) = TextNOMBRE.Text
            INSCRIPCIONES(INDICE1, 1) = TextCARNET.Text

            If RadioButton1.Checked = True Then

                INSCRIPCIONES(INDICE1, 2) = RadioButton1.Text
                INSCRIPCIONES(INDICE1, 4) = INSCRIPCION_BASICO
                INSCRIPCIONES(INDICE1, 5) = MENSUAL_BASICO
                PAGOPARCIAL = INSCRIPCION_BASICO + MENSUAL_BASICO
                INSCRIPCIONES(INDICE1, 6) = PAGOPARCIAL

                Select Case ComboBoxPAGO.SelectedIndex
                    Case 0 : INSCRIPCIONES(INDICE1, 7) = "EFECTIVO"
                    Case 1 : INSCRIPCIONES(INDICE1, 7) = "TARJETA DE CREDITO"
                    Case 2 : INSCRIPCIONES(INDICE1, 7) = "TRANSFERENCIA "
                    Case 3 : INSCRIPCIONES(INDICE1, 7) = "DEPOSITO BANCARIO"

                End Select

                Select Case ComboBoxPAGO.SelectedIndex
                    Case 1 : INSCRIPCIONES(INDICE1, 8) = PAGOPARCIAL * 0.1
                    Case Else : INSCRIPCIONES(INDICE1, 8) = 0
                End Select

                INSCRIPCIONES(INDICE1, 9) = Val(INSCRIPCIONES(INDICE1, 6)) + Val(INSCRIPCIONES(INDICE1, 8))

            End If

            If RadioButton2.Checked = True Then

                INSCRIPCIONES(INDICE1, 2) = RadioButton2.Text
                INSCRIPCIONES(INDICE1, 4) = INSCRIPCION_DIVER
                INSCRIPCIONES(INDICE1, 5) = MENSUAL_DIVER
                PAGOPARCIAL = INSCRIPCION_DIVER + MENSUAL_DIVER
                INSCRIPCIONES(INDICE1, 6) = PAGOPARCIAL

                Select Case ComboBoxPAGO.SelectedIndex
                    Case 0 : INSCRIPCIONES(INDICE1, 7) = "EFECTIVO"
                    Case 1 : INSCRIPCIONES(INDICE1, 7) = "TARJETA DE CREDITO"
                    Case 2 : INSCRIPCIONES(INDICE1, 7) = "TRANSFERENCIA "
                    Case 3 : INSCRIPCIONES(INDICE1, 7) = "DEPOSITO BANCARIO"

                End Select

                Select Case ComboBoxPAGO.SelectedIndex
                    Case 1 : INSCRIPCIONES(INDICE1, 8) = PAGOPARCIAL * 0.1
                    Case Else : INSCRIPCIONES(INDICE1, 8) = 0
                End Select

                INSCRIPCIONES(INDICE1, 9) = Val(INSCRIPCIONES(INDICE1, 6)) + Val(INSCRIPCIONES(INDICE1, 8))

            End If

            If RadioButton1.Checked = True Then

                ComboBox1.Enabled = True

            End If

            Select Case ComboBox1.SelectedIndex
                Case 0 : INSCRIPCIONES(INDICE1, 3) = "PERITO CONTADOR"
                Case 1 : INSCRIPCIONES(INDICE1, 3) = "BACHILLERATO"
                Case 2 : INSCRIPCIONES(INDICE1, 3) = "ELECTRONICA"
                Case 3 : INSCRIPCIONES(INDICE1, 3) = "DISEÑO GRAFICO"
            End Select

            INDICE1 = INDICE1 + 1

        End If

        If (INDICE1 = 7) Then

            MsgBox("LA MATRIZ ESTÁ LLENA")

        End If

        LIMPIAR_ENTRADAS()

    End Sub

    Sub MOSTRAR_MATRIZ()

            Dim i As Byte
        DataGridView1.Rows.Clear()

        For i = 0 To 6

            If (INSCRIPCIONES(i, 0) <> Nothing) Then

                DataGridView1.Rows.Add(INSCRIPCIONES(i, 0), INSCRIPCIONES(i, 1), INSCRIPCIONES(i, 2), INSCRIPCIONES(i, 3), INSCRIPCIONES(i, 4), INSCRIPCIONES(i, 5), INSCRIPCIONES(i, 6), INSCRIPCIONES(i, 7), INSCRIPCIONES(i, 8), INSCRIPCIONES(i, 9))

            Else
                Exit For
            End If
        Next i
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If

    End Sub

    Private Sub ButtonMOSTRAR_Click(sender As Object, e As EventArgs) Handles ButtonMOSTRAR.Click
        MOSTRAR_MATRIZ()
    End Sub

    Private Sub ButtoLIMPIARMATRIZ_Click(sender As Object, e As EventArgs) Handles ButtonLIMPIARMATRIZ.Click
        Dim i As Byte, J As Byte

        DataGridView1.Rows.Clear()
        'instrucción que colocar a cero la variable que controla las posiciones o filas de la matriz, para poder
        'iniciar a ingresar datos desde la primera posición de la matriz
        For i = 0 To 6
            For J = 0 To 9
                INSCRIPCIONES(i, J) = Nothing
            Next J
        Next i
        INDICE1 = 0

        MsgBox("LA MATRIZ SE HA LIMPIADO", Title:="Sistema Camino del Saber")

    End Sub

    Private Sub ButtonResultados_Click(sender As Object, e As EventArgs) Handles ButtonRESULTADOS.Click
        Dim r As Byte = 0

        Dim r1 As Double = 0
        Dim r2 As Double = 0
        Dim r3 As Double = 0
        Dim r4 As Double = 0
        Dim r5 As Double = 0
        Dim r6 As Double = 0
        Dim r7 As Double = 0
        Dim r8 As Double = 0
        Dim r9 As Double = 0
        Dim r10 As Double = 0
        Dim r11 As Double = 0

        For r = 0 To 7

            r1 = r1 + Val(INSCRIPCIONES(r, 9))

            If (Str(INSCRIPCIONES(r, 7) = "EFECTIVO")) Then
                r2 = r2 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 7) = "TARJETA DE CREDITO")) Then
                r3 = r3 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 7) = "TRANSFERENCIA ACH")) Then
                r4 = r4 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 7) = "DEPOSITO BANCARIO")) Then
                r5 = r5 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 2) = "BÁSICO")) Then
                r6 = r6 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 2) = "DIVERSIFICADO")) Then
                r7 = r7 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 3) = "PERITO CONTADOR")) Then
                r8 = r8 + 1
            End If

            If (Str(INSCRIPCIONES(r, 3) = "BACHILLERATO")) Then
                r9 = r9 + 1
            End If

            If (Str(INSCRIPCIONES(r, 3) = "ELECTRONICA")) Then
                r10 = r10 + 1
            End If

            If (Str(INSCRIPCIONES(r, 3) = "DISEÑO GRAFICO")) Then
                r11 = r11 + 1
            End If

        Next r

        TextGENERAL.Text = Math.Round(r1, 2).ToString
        TextEFECTIVO.Text = Math.Round(r2, 2).ToString
        TextTARJETA.Text = Math.Round(r3, 2).ToString
        TextTRANSFERENCIA.Text = Math.Round(r4, 2).ToString
        TextDEPOSITO.Text = Math.Round(r5, 2).ToString
        TextTOTALBASICO.Text = Math.Round(r6, 2).ToString
        TextBoxTOTALDIVERSIFICADO.Text = Math.Round(r7, 2).ToString
        TextINSCRIPCION.Text = Str(r8)

    End Sub

    Private Sub ButtonLIMPIAR_Click(sender As Object, e As EventArgs) Handles ButtonLIMPIAR.Click
        TextGENERAL.Text = ""
        TextEFECTIVO.Text = ""
        TextTARJETA.Text = ""
        TextTRANSFERENCIA.Text = ""
        TextDEPOSITO.Text = ""
        TextTOTALBASICO.Text = ""
        TextBoxTOTALDIVERSIFICADO.Text = ""
        TextINSCRIPCION.Text = ""

    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        If MsgBox("  salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonACEPTAR.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub ButtonELIMINARFILA_Click(sender As Object, e As EventArgs) Handles ButtonELIMINARFILA.Click
        Dim i As Integer

        i = DataGridView1.SelectedRows(0).Index
        DataGridView1.Rows.RemoveAt(i)

        MsgBox("El registro se elimino con éxito", vbOKOnly, Title:="Sistema Camino del Saber")
    End Sub


End Class



