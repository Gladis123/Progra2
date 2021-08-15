Public Class Form1

    Const PrecioArroz As Double = 2.0
    Const PrecioFrijol As Double = 1.75
    Const PrecioAzucar As Double = 2.5


    Dim TotalSinIva As Double
    Dim IVA As Double
    Dim TotalPagar As Double
    Dim Desc1 As Double
    Dim Desc2 As Double
    Dim pregunta As String




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        TotalSinIva = Val(TextcARROZ.Text) * PrecioArroz + Val(TextcFrijol.Text) * PrecioFrijol + Val(TextcAzucar.Text) * PrecioAzucar
        IVA = TotalSinIva * 0.12
        TotalPagar = TotalSinIva + IVA

        LBLPAGOSINIVA.Text += Str(TotalSinIva)
        LBLIVA.Text += Str(IVA)
        LBLPAGOPARCIAL.Text += Str(TotalPagar)

        If TotalPagar > 15.0 Then
            Desc1 = (2.5 * TotalPagar) / 100
            TotalPagar = TotalPagar - Desc1
        End If

        If Val(TextcFrijol.Text) > 5 Then
            Desc2 = (3 * TotalPagar) / 100
            TotalPagar = TotalPagar - Desc2


        End If

        LabelDesc1.Text += Str(Desc1)
        LabelDesc2.Text += Str(Desc2)
        LabelFINAL.Text += Str(TotalPagar)



    End Sub



    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        End


    End Sub



    Private Sub ButtonLIMPIAR_Click_1(sender As Object, e As EventArgs) Handles ButtonLIMPIAR.Click
        limpiarCampos(Me)

    End Sub

    Private Sub ButtonACEPTAR_Click(sender As Object, e As EventArgs) Handles ButtonACEPTAR.Click
        pregunta = MsgBox("Desea aceptar el pago", vbYesNo + vbQuestion, "ADVERTENCIA")

        If pregunta = vbNo Then

            MsgBox("CANCELADO")

        Else
            MsgBox("PAGO ACEPTADO")

        End If



    End Sub
End Class
