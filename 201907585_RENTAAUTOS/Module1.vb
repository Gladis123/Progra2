Module Module1

    Sub Limpiar_entradas()

        Form1.Combo_SeleccioneMarca.SelectedIndex = "-1"
        Form1.Text_Nit.Clear()
        Form1.Text_IngresePlaca.Clear()
        Form1.Text_Efectivo.Clear()
        Form1.Text_Tarjeta.Clear()
        Form1.Text_NoDiasAlquiler.Clear()
        Form1.Check_Efectivo.Checked = "False"
        Form1.Check_Tarjeta.Checked = "False"
        Form1.Text_Efectivo.Enabled = "False"
        Form1.Text_Tarjeta.Enabled = "False"

    End Sub


    Sub mostrar_resultado()

        Form1.List_NIT.Items.Add(Nit(indice))
        Form1.List_Placa.Items.Add(Placa(indice))
        Form1.List_Marca.Items.Add(Marca(indice))
        Form1.List_Dias.Items.Add(Dias(indice))
        Form1.List_Parcial.Items.Add(Parcial(indice))
        Form1.List_Descuento.Items.Add(Descuento(indice))
        Form1.List_Total.Items.Add(Total(indice))

    End Sub


    Sub Limpiar_vectores()

        Form1.List_NIT.Items.Clear()
        Form1.List_Placa.Items.Clear()
        Form1.List_Marca.Items.Clear()
        Form1.List_Dias.Items.Clear()
        Form1.List_Parcial.Items.Clear()
        Form1.List_Descuento.Items.Clear()
        Form1.List_Total.Items.Clear()

        indice = 0


        MsgBox("Se limpiaron los vectores", vbExclamation)

    End Sub


    Sub Limpiar_Listas()

        Form1.List_NIT.Items.Clear()
        Form1.List_Placa.Items.Clear()
        Form1.List_Marca.Items.Clear()
        Form1.List_Dias.Items.Clear()
        Form1.List_Parcial.Items.Clear()
        Form1.List_Descuento.Items.Clear()
        Form1.List_Total.Items.Clear()


        MsgBox("Se limpiaron las listas", vbExclamation)

    End Sub



    Public dias_alquilar As Integer
    Public indice As Byte = 0
    Public Honda_dia As Double = 250.0
    Public Mercedes_dia As Double = 450.0
    Public Toyota_dia As Double = 325.0
    Public Mazda_dia As Double = 300.0
    Public PagoParcial As Double
    Public Nit(6) As String
    Public Placa(6) As String
    Public Marca(6) As String
    Public Dias(6) As Integer
    Public Parcial(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double



End Module
