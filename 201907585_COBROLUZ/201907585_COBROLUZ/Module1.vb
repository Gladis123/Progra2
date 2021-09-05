Module Module1

    Public Const Residencial1 As Double = 0.99
    Public Const Residencial2 As Double = 1.2
    Public Const Residencial3 As Double = 3.0

    Public Const Industrial1 As Double = 1.99
    Public Const Industrial2 As Double = 2.2
    Public Const Industrial3 As Double = 4.0

    Public indice As Byte = 0

    Public total_pagoini As Double
    Public total_pagopar As Double
    Public total_pagopar1 As Double
    Public total_pagofin As Double
    Public total_pagofin1 As Double
    Public total_conmora As Double
    Public total_recargo As Double
    Public total_tarifa As Double
    Public mora_aplicada As Double = 0.02

    Public descuento_social = 0.2
    Public descuento_nosocial = 0.1

    Public Cliente(11) As String
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public SaldoAnterior(11) As Double
    Public PagoInicial(11) As Double
    Public Mora(11) As String
    Public PMora(11) As String
    Public PagoParcial(11) As Double
    Public Descuento(11) As String
    Public PagoTotal(11) As Double




    Sub Limpiar_Entradas()

        Form1.TxtUsuario.Clear()
        Form1.TxtNit.Clear()
        Form1.TxtSaldoAnterior.Clear()
        Form1.TxtConsumo.Clear()
        Form1.TxtUsuario.Focus()

    End Sub

    Sub mostrar()

        Form1.List_Cliente.Items.Add(Cliente(indice))
        Form1.List_Servicio.Items.Add(Servicio(indice))
        Form1.List_Tarifa.Items.Add(Tarifa(indice))
        Form1.List_SaldoAnterior.Items.Add(SaldoAnterior(indice))
        Form1.List_PagoInicial.Items.Add(PagoInicial(indice))
        Form1.List_Mora.Items.Add(Mora(indice))
        Form1.List_PagoConMora.Items.Add(PMora(indice))
        Form1.List_PagoParcial.Items.Add(PagoParcial(indice))
        Form1.List_Descuento.Items.Add(Descuento(indice))
        Form1.List_PagoTotal.Items.Add(PagoTotal(indice))

    End Sub


    Sub LimpiarV()

        Form1.List_Cliente.Items.Clear()
        Form1.List_Servicio.Items.Clear()
        Form1.List_Tarifa.Items.Clear()
        Form1.List_SaldoAnterior.Items.Clear()
        Form1.List_PagoInicial.Items.Clear()
        Form1.List_Mora.Items.Clear()
        Form1.List_PagoConMora.Items.Clear()
        Form1.List_PagoParcial.Items.Clear()
        Form1.List_Descuento.Items.Clear()
        Form1.List_PagoTotal.Items.Clear()

        indice = 0

    End Sub





End Module
