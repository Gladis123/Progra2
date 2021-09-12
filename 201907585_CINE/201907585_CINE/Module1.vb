Module Module1
    Public Subtotal_pagar(8)
    Public vDescuento1(8)
    Public vDescuento2(8)
    Public Total_Pagar(8)
    Public Indice = 0
    Public vfuncion(8)
    Public vCine(8)
    Public NumEntradas(8) As Double
    Public total As Double
    Public subtotal_2 As Double
    Public subtotal_1 As Double
    Public vTotal(8)


    Public total_ As Double
    Public Calculo_Subtotal As Double = 0
    Public Calculo_Descuento1 As Double = 0
    Public Calculo_Descuento2 As Double = 0


    Function calcularSubtotal(Funcion As String, Cine As String) As Double
        Select Case Cine
            Case "A"
                Select Case Funcion

                    Case "1"
                        Calculo_Subtotal = 30

                    Case "2"
                        Calculo_Subtotal = 35

                    Case Else
                        Calculo_Subtotal = 40



                End Select

            Case "B"
                Select Case Funcion

                    Case "1"
                        Calculo_Subtotal = 24

                    Case "2"
                        Calculo_Subtotal = 34

                    Case Else
                        Calculo_Subtotal = 44




                End Select



            Case "C"

                Select Case Funcion

                    Case "1"
                        Calculo_Subtotal = 35

                    Case "2"
                        Calculo_Subtotal = 40

                    Case Else
                        Calculo_Subtotal = 50




                End Select


        End Select




        Return Calculo_Subtotal

    End Function

    Function CalculoDescuento1(Funcion As String, Cine As String) As Double

        If (Funcion = "3" Or Funcion = "4") And (Cine = "C" Or Cine = "B") Then
            CalculoDescuento1 = 0.055

        ElseIf (Funcion = "1") And (Cine = "C" Or Cine = "B") Then
            CalculoDescuento1 = 0.03


        ElseIf (Funcion = "2") And (Cine = "A") Then
            CalculoDescuento1 = 0.015

        End If


        Return CalculoDescuento1
    End Function

    Function CalculoDescuento2(subtotal_2 As Double) As Double

        If (Calculo_Subtotal >= 100 And Calculo_Subtotal <= 300) Then

            CalculoDescuento2 = Calculo_Subtotal * 0.02

        ElseIf (Calculo_Subtotal >= 301 And Calculo_Subtotal <= 500) Then

            CalculoDescuento2 = Calculo_Subtotal * 0.04

        ElseIf (Calculo_Subtotal >= 501 And Calculo_Subtotal <= 1000) Then

            CalculoDescuento2 = Calculo_Subtotal * 0.06

        End If

        Return CalculoDescuento2

    End Function


    Sub Limpiar_entradas()

        Form1.Funcion.SelectedIndex = "-1"
        Form1.Cine.SelectedIndex = "-1"
        Form1.TextBoletos.Clear()

    End Sub


    Sub Limpiar_vectores()

        Form1.Funcion.Items.Clear()
        Form1.Cine.Items.Clear()
        Form1.Subtotal.Items.Clear()
        Form1.Descuento1.Items.Clear()
        Form1.Descuento2.Items.Clear()
        Form1.Total.Items.Clear()

        Indice = 0

    End Sub

    Sub Limpiar_Listas()
        Form1.Funcion.Items.Clear()
        Form1.Cine.Items.Clear()
        Form1.Subtotal.Items.Clear()
        Form1.Descuento1.Items.Clear()
        Form1.Descuento2.Items.Clear()
        Form1.Total.Items.Clear()

    End Sub


End Module
