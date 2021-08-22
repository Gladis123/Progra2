Module Metodo

    Sub limpiarCampos(ByVal formulario As Form1)
        Dim text As Object
        For Each text In formulario.Controls
            If TypeOf text Is TextBox Then
                Dim txtTemp As TextBox = CType(text, TextBox)
                txtTemp.Text = ""

            End If
        Next
    End Sub

End Module
