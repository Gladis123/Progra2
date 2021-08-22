Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LPrecioCosto.Text = "0.00"
        precioCosto = 0.00
        sumaYardas = Val(TxtAlgodon.Text) + Val(TxtLino.Text) + Val(THilo.Text) + Val(TxtSeda.Text)
        If RKing.Checked = True Then
            If sumaYardas = MatKing Then
                precioCosto = precio_king + Val(TxtAlgodon.Text) * Precio_Algodon + Val(TxtLino.Text) * Precio_Lino + Val(THilo.Text) * Precio_HiloCrudo + Val(TxtSeda.Text) * Precio_Seda



            End If

        ElseIf Rqueen.Checked = True Then
            If sumaYardas = Matqueen Then
                precioCosto = precio_king + Val(TxtAlgodon.Text) * Precio_Algodon + Val(TxtLino.Text) * Precio_Lino + Val(THilo.Text) * Precio_HiloCrudo + Val(TxtSeda.Text) * Precio_Seda



            End If
        ElseIf Rmatrimonial.Checked = True Then
            If sumaYardas = MatMatrimonial Then
                precioCosto = precio_king + Val(TxtAlgodon.Text) * Precio_Algodon + Val(TxtLino.Text) * Precio_Lino + Val(THilo.Text) * Precio_HiloCrudo + Val(TxtSeda.Text) * Precio_Seda

            End If
        ElseIf Rimperial.Checked = True Then
            If sumaYardas = Matimperial Then
                precioCosto = precio_king + Val(TxtAlgodon.Text) * Precio_Algodon + Val(TxtLino.Text) * Precio_Lino + Val(THilo.Text) * Precio_HiloCrudo + Val(TxtSeda.Text) * Precio_Seda


            End If
        End If

        LPrecioCosto.Text = Str(precioCosto)
    End Sub

    Private Sub THiloCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles THiloCrudo.CheckedChanged
        If THiloCrudo.Checked = True Then
            THilo.Enabled = True
            THilo.Text = "0"

        Else
            THilo.Enabled = False
            THilo.Text = "0"




        End If
    End Sub


    Private Sub TLino_CheckedChanged(sender As Object, e As EventArgs) Handles TLino.CheckedChanged
        If TLino.Checked = True Then
            TxtLino.Enabled = True
            TxtLino.Text = "0"

        Else
            TxtLino.Enabled = False
            TxtLino.Text = "0"




        End If
    End Sub


    Private Sub TAlgodon_CheckedChanged(sender As Object, e As EventArgs) Handles TAlgodon.CheckedChanged
        If TAlgodon.Checked = True Then
            TxtAlgodon.Enabled = True
            TxtAlgodon.Text = "0"

        Else
            TxtAlgodon.Enabled = False
            TxtAlgodon.Text = "0"




        End If
    End Sub


    Private Sub Tseda_CheckedChanged(sender As Object, e As EventArgs) Handles TSeda.CheckedChanged
        If TSeda.Checked = True Then
            TxtSeda.Enabled = True
            TxtSeda.Text = "0"

        Else
            TxtSeda.Enabled = False
            TxtSeda.Text = "0"




        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pregunta = MsgBox("Desea salir", vbYesNo + vbQuestion, "ADVERTENCIA")

        If pregunta = vbNo Then

            MsgBox("CANCELADO")

        Else
            MsgBox("Gracias Por su Visita")
            End

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiarCampos(Me)
        TxtAlgodon.Text = " "
        THilo.Text = " "
        TxtLino.Text = " "
        TxtSeda.Text = " "
    End Sub
End Class
