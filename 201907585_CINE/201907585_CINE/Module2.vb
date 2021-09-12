Module Module2

    Sub LimpiarCampos(ByVal Formulario As Form)
        Dim text As Object
        For Each text In Formulario.Controls
            If TypeOf text Is TextBox Then

                Dim txtTemp As TextBox = CType(text, TextBox)
                txtTemp.Text = ""




            End If
        Next

    End Sub


End Module
