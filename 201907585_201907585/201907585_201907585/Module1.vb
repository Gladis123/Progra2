Module Module1
    Public indice As Byte = 0
    Public Vector_Etapa(12) As String
    Public Vector_Equipo(12) As String
    Public Vector_Km(12) As Double
    Public Vector_Tiempo(12) As Double
    Public Vector_Penalizacion(12) As Double
    Public Vector_Nacionalidad(12) As String
    Public Vector_Total(12) As Double
    Public penal_benef As Double
    Public penalizacion_120 = 30.0
    Public penalizacion_140 = 40.0
    Public penalizacion_160 = 50.0
    Public beneficio_movistarmenor85 = -15.0
    Public beneficio_proteam = -10.0
    Public t As Byte
    Public i = 0
    Public Sub inicializar_datos()
        Form1.TextBox1.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.TextBox3.Text = ""
        Form1.TextBox2.Text = ""
        Form1.RadioButton2.Checked = False
        Form1.RadioButton1.Checked = False
    End Sub

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        t = 0
        comprobar_repetido = True
        While (t <= 4) And (encontrado)

            If (Vector_Etapa(t) <> Nothing) Then

                If (Vector_Etapa(t) = (Form1.TextBox4.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    t = t + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function

    Public Sub mostrar_matriz()
        Dim x As Byte

        Form1.DataGridView1.Rows.Clear()

        x = 0

        While (x <= 11)

            If (Vector_Etapa(x) <> Nothing) Then

                Form1.DataGridView1.Rows.Add((Vector_Etapa(x)), (Vector_Equipo(x)), (Vector_Nacionalidad(x)), (Vector_Km(x)), (Vector_Tiempo(x)), (Vector_Penalizacion(x)), (Vector_Total(x)))
                x = x + 1
            Else
                Exit While
            End If
        End While
    End Sub

    Public Sub limpiar_vectores()

        Dim j As Byte

        Form1.DataGridView1.Rows.Clear()
        indice = 0


        j = 0
        While (j <= 11)

            Vector_Etapa(j) = Nothing
            Vector_Equipo(j) = Nothing
            Vector_Km(j) = Nothing
            Vector_Tiempo(j) = Nothing
            Vector_Penalizacion(j) = Nothing
            Vector_Nacionalidad(j) = Nothing
            Vector_Total(j) = Nothing

            j = j + 1

        End While

        MsgBox("Matriz se ha limpiado con éxito")

    End Sub

End Module
