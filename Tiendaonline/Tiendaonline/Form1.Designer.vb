<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cArroz = New System.Windows.Forms.Label()
        Me.cFrijol = New System.Windows.Forms.Label()
        Me.cAzucar = New System.Windows.Forms.Label()
        Me.LBLPAGOSINIVA = New System.Windows.Forms.Label()
        Me.LBLIVA = New System.Windows.Forms.Label()
        Me.LBLPAGOPARCIAL = New System.Windows.Forms.Label()
        Me.LabelDesc1 = New System.Windows.Forms.Label()
        Me.LabelFINAL = New System.Windows.Forms.Label()
        Me.LabelDesc2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextcARROZ = New System.Windows.Forms.TextBox()
        Me.TextcAzucar = New System.Windows.Forms.TextBox()
        Me.TextcFrijol = New System.Windows.Forms.TextBox()
        Me.ButtonLIMPIAR = New System.Windows.Forms.Button()
        Me.ButtonSALIR = New System.Windows.Forms.Button()
        Me.ButtonACEPTAR = New System.Windows.Forms.Button()
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cArroz
        '
        Me.cArroz.AutoSize = True
        Me.cArroz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cArroz.Location = New System.Drawing.Point(124, 53)
        Me.cArroz.Name = "cArroz"
        Me.cArroz.Size = New System.Drawing.Size(136, 13)
        Me.cArroz.TabIndex = 0
        Me.cArroz.Text = "Cantidad de Libras de arroz"
        '
        'cFrijol
        '
        Me.cFrijol.AutoSize = True
        Me.cFrijol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cFrijol.Location = New System.Drawing.Point(124, 82)
        Me.cFrijol.Name = "cFrijol"
        Me.cFrijol.Size = New System.Drawing.Size(127, 13)
        Me.cFrijol.TabIndex = 1
        Me.cFrijol.Text = "Cantidad de libras de frijol"
        '
        'cAzucar
        '
        Me.cAzucar.AutoSize = True
        Me.cAzucar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cAzucar.Location = New System.Drawing.Point(124, 116)
        Me.cAzucar.Name = "cAzucar"
        Me.cAzucar.Size = New System.Drawing.Size(141, 13)
        Me.cAzucar.TabIndex = 2
        Me.cAzucar.Text = "Cantidad de libras de azucar"
        '
        'LBLPAGOSINIVA
        '
        Me.LBLPAGOSINIVA.AutoSize = True
        Me.LBLPAGOSINIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLPAGOSINIVA.Location = New System.Drawing.Point(124, 147)
        Me.LBLPAGOSINIVA.Name = "LBLPAGOSINIVA"
        Me.LBLPAGOSINIVA.Size = New System.Drawing.Size(68, 13)
        Me.LBLPAGOSINIVA.TabIndex = 3
        Me.LBLPAGOSINIVA.Text = "Pago sin iva:"
        '
        'LBLIVA
        '
        Me.LBLIVA.AutoSize = True
        Me.LBLIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLIVA.Location = New System.Drawing.Point(124, 180)
        Me.LBLIVA.Name = "LBLIVA"
        Me.LBLIVA.Size = New System.Drawing.Size(27, 13)
        Me.LBLIVA.TabIndex = 4
        Me.LBLIVA.Text = "IVA:"
        '
        'LBLPAGOPARCIAL
        '
        Me.LBLPAGOPARCIAL.AutoSize = True
        Me.LBLPAGOPARCIAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLPAGOPARCIAL.Location = New System.Drawing.Point(124, 207)
        Me.LBLPAGOPARCIAL.Name = "LBLPAGOPARCIAL"
        Me.LBLPAGOPARCIAL.Size = New System.Drawing.Size(69, 13)
        Me.LBLPAGOPARCIAL.TabIndex = 5
        Me.LBLPAGOPARCIAL.Text = "Pago parcial:"
        '
        'LabelDesc1
        '
        Me.LabelDesc1.AutoSize = True
        Me.LabelDesc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelDesc1.Location = New System.Drawing.Point(124, 236)
        Me.LabelDesc1.Name = "LabelDesc1"
        Me.LabelDesc1.Size = New System.Drawing.Size(71, 13)
        Me.LabelDesc1.TabIndex = 7
        Me.LabelDesc1.Text = "Descuento 1:"
        '
        'LabelFINAL
        '
        Me.LabelFINAL.AutoSize = True
        Me.LabelFINAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelFINAL.Location = New System.Drawing.Point(368, 219)
        Me.LabelFINAL.Name = "LabelFINAL"
        Me.LabelFINAL.Size = New System.Drawing.Size(73, 13)
        Me.LabelFINAL.TabIndex = 8
        Me.LabelFINAL.Text = "PAGO FINAL:"
        '
        'LabelDesc2
        '
        Me.LabelDesc2.AutoSize = True
        Me.LabelDesc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelDesc2.Location = New System.Drawing.Point(124, 267)
        Me.LabelDesc2.Name = "LabelDesc2"
        Me.LabelDesc2.Size = New System.Drawing.Size(71, 13)
        Me.LabelDesc2.TabIndex = 9
        Me.LabelDesc2.Text = "Descuento 2:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(378, 162)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 10
        '
        'TextcARROZ
        '
        Me.TextcARROZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextcARROZ.Location = New System.Drawing.Point(331, 50)
        Me.TextcARROZ.Name = "TextcARROZ"
        Me.TextcARROZ.Size = New System.Drawing.Size(133, 20)
        Me.TextcARROZ.TabIndex = 11
        Me.TextcARROZ.Text = "0"
        '
        'TextcAzucar
        '
        Me.TextcAzucar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextcAzucar.Location = New System.Drawing.Point(331, 113)
        Me.TextcAzucar.Name = "TextcAzucar"
        Me.TextcAzucar.Size = New System.Drawing.Size(133, 20)
        Me.TextcAzucar.TabIndex = 13
        Me.TextcAzucar.Text = "0"
        '
        'TextcFrijol
        '
        Me.TextcFrijol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextcFrijol.Location = New System.Drawing.Point(331, 79)
        Me.TextcFrijol.Name = "TextcFrijol"
        Me.TextcFrijol.Size = New System.Drawing.Size(133, 20)
        Me.TextcFrijol.TabIndex = 14
        Me.TextcFrijol.Text = "0"
        '
        'ButtonLIMPIAR
        '
        Me.ButtonLIMPIAR.BackColor = System.Drawing.Color.Lime
        Me.ButtonLIMPIAR.Location = New System.Drawing.Point(223, 401)
        Me.ButtonLIMPIAR.Name = "ButtonLIMPIAR"
        Me.ButtonLIMPIAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonLIMPIAR.Size = New System.Drawing.Size(135, 37)
        Me.ButtonLIMPIAR.TabIndex = 16
        Me.ButtonLIMPIAR.Text = "LIMPIAR"
        Me.ButtonLIMPIAR.UseVisualStyleBackColor = False
        '
        'ButtonSALIR
        '
        Me.ButtonSALIR.BackColor = System.Drawing.Color.Lime
        Me.ButtonSALIR.Location = New System.Drawing.Point(435, 401)
        Me.ButtonSALIR.Name = "ButtonSALIR"
        Me.ButtonSALIR.Size = New System.Drawing.Size(135, 37)
        Me.ButtonSALIR.TabIndex = 17
        Me.ButtonSALIR.Text = "SALIR"
        Me.ButtonSALIR.UseVisualStyleBackColor = False
        '
        'ButtonACEPTAR
        '
        Me.ButtonACEPTAR.BackColor = System.Drawing.Color.Lime
        Me.ButtonACEPTAR.Location = New System.Drawing.Point(16, 401)
        Me.ButtonACEPTAR.Name = "ButtonACEPTAR"
        Me.ButtonACEPTAR.Size = New System.Drawing.Size(135, 37)
        Me.ButtonACEPTAR.TabIndex = 15
        Me.ButtonACEPTAR.Text = "ACEPTAR "
        Me.ButtonACEPTAR.UseVisualStyleBackColor = False
        '
        'CALCULAR
        '
        Me.CALCULAR.BackColor = System.Drawing.Color.Lime
        Me.CALCULAR.Location = New System.Drawing.Point(625, 401)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(135, 37)
        Me.CALCULAR.TabIndex = 18
        Me.CALCULAR.TabStop = False
        Me.CALCULAR.Text = "CALCULAR "
        Me.CALCULAR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tiendaonline.My.Resources.Resources.tienda_en_linea
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CALCULAR)
        Me.Controls.Add(Me.ButtonSALIR)
        Me.Controls.Add(Me.ButtonLIMPIAR)
        Me.Controls.Add(Me.ButtonACEPTAR)
        Me.Controls.Add(Me.TextcFrijol)
        Me.Controls.Add(Me.TextcAzucar)
        Me.Controls.Add(Me.TextcARROZ)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LabelDesc2)
        Me.Controls.Add(Me.LabelFINAL)
        Me.Controls.Add(Me.LabelDesc1)
        Me.Controls.Add(Me.LBLPAGOPARCIAL)
        Me.Controls.Add(Me.LBLIVA)
        Me.Controls.Add(Me.LBLPAGOSINIVA)
        Me.Controls.Add(Me.cAzucar)
        Me.Controls.Add(Me.cFrijol)
        Me.Controls.Add(Me.cArroz)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cArroz As Label
    Friend WithEvents cFrijol As Label
    Friend WithEvents cAzucar As Label
    Friend WithEvents LBLPAGOSINIVA As Label
    Friend WithEvents LBLIVA As Label
    Friend WithEvents LBLPAGOPARCIAL As Label
    Friend WithEvents LabelDesc1 As Label
    Friend WithEvents LabelFINAL As Label
    Friend WithEvents LabelDesc2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextcARROZ As TextBox
    Friend WithEvents TextcAzucar As TextBox
    Friend WithEvents TextcFrijol As TextBox
    Friend WithEvents ButtonLIMPIAR As Button
    Friend WithEvents ButtonSALIR As Button
    Friend WithEvents ButtonACEPTAR As Button
    Friend WithEvents CALCULAR As Button
End Class
