<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DATOS_BOX = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtConsumo = New System.Windows.Forms.TextBox()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.TxtSaldoAnterior = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SERVICIO_BOX = New System.Windows.Forms.GroupBox()
        Me.BOXTIPOTARIFA = New System.Windows.Forms.ComboBox()
        Me.BOXTIPOSERVICIO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PAGOTOTAL_BOX = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.List_PagoTotal = New System.Windows.Forms.ListBox()
        Me.List_Descuento = New System.Windows.Forms.ListBox()
        Me.List_PagoParcial = New System.Windows.Forms.ListBox()
        Me.List_PagoConMora = New System.Windows.Forms.ListBox()
        Me.List_Mora = New System.Windows.Forms.ListBox()
        Me.List_PagoInicial = New System.Windows.Forms.ListBox()
        Me.List_SaldoAnterior = New System.Windows.Forms.ListBox()
        Me.List_Tarifa = New System.Windows.Forms.ListBox()
        Me.List_Servicio = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.List_Cliente = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DATOS_BOX.SuspendLayout()
        Me.SERVICIO_BOX.SuspendLayout()
        Me.PAGOTOTAL_BOX.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DATOS_BOX
        '
        Me.DATOS_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DATOS_BOX.Controls.Add(Me.Label4)
        Me.DATOS_BOX.Controls.Add(Me.Label3)
        Me.DATOS_BOX.Controls.Add(Me.TxtConsumo)
        Me.DATOS_BOX.Controls.Add(Me.TxtNit)
        Me.DATOS_BOX.Controls.Add(Me.TxtSaldoAnterior)
        Me.DATOS_BOX.Controls.Add(Me.TxtUsuario)
        Me.DATOS_BOX.Controls.Add(Me.Label2)
        Me.DATOS_BOX.Controls.Add(Me.Label1)
        Me.DATOS_BOX.Location = New System.Drawing.Point(12, 27)
        Me.DATOS_BOX.Name = "DATOS_BOX"
        Me.DATOS_BOX.Size = New System.Drawing.Size(596, 140)
        Me.DATOS_BOX.TabIndex = 0
        Me.DATOS_BOX.TabStop = False
        Me.DATOS_BOX.Text = "INGRESO DE DATOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CONSUMO EN KW"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INGRESE No. NIT"
        '
        'TxtConsumo
        '
        Me.TxtConsumo.Location = New System.Drawing.Point(425, 84)
        Me.TxtConsumo.Name = "TxtConsumo"
        Me.TxtConsumo.Size = New System.Drawing.Size(100, 20)
        Me.TxtConsumo.TabIndex = 5
        '
        'TxtNit
        '
        Me.TxtNit.Location = New System.Drawing.Point(425, 28)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(100, 20)
        Me.TxtNit.TabIndex = 4
        '
        'TxtSaldoAnterior
        '
        Me.TxtSaldoAnterior.Location = New System.Drawing.Point(185, 84)
        Me.TxtSaldoAnterior.Name = "TxtSaldoAnterior"
        Me.TxtSaldoAnterior.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoAnterior.TabIndex = 3
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(185, 24)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INGRESE SALDO ANTERIOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESE USUARIO"
        '
        'SERVICIO_BOX
        '
        Me.SERVICIO_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SERVICIO_BOX.Controls.Add(Me.BOXTIPOTARIFA)
        Me.SERVICIO_BOX.Controls.Add(Me.BOXTIPOSERVICIO)
        Me.SERVICIO_BOX.Controls.Add(Me.Label6)
        Me.SERVICIO_BOX.Controls.Add(Me.Label5)
        Me.SERVICIO_BOX.Location = New System.Drawing.Point(12, 176)
        Me.SERVICIO_BOX.Name = "SERVICIO_BOX"
        Me.SERVICIO_BOX.Size = New System.Drawing.Size(596, 142)
        Me.SERVICIO_BOX.TabIndex = 1
        Me.SERVICIO_BOX.TabStop = False
        Me.SERVICIO_BOX.Text = "SERVICIO"
        '
        'BOXTIPOTARIFA
        '
        Me.BOXTIPOTARIFA.FormattingEnabled = True
        Me.BOXTIPOTARIFA.Items.AddRange(New Object() {"Social", "No Social"})
        Me.BOXTIPOTARIFA.Location = New System.Drawing.Point(251, 84)
        Me.BOXTIPOTARIFA.Name = "BOXTIPOTARIFA"
        Me.BOXTIPOTARIFA.Size = New System.Drawing.Size(121, 21)
        Me.BOXTIPOTARIFA.TabIndex = 4
        '
        'BOXTIPOSERVICIO
        '
        Me.BOXTIPOSERVICIO.FormattingEnabled = True
        Me.BOXTIPOSERVICIO.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.BOXTIPOSERVICIO.Location = New System.Drawing.Point(251, 31)
        Me.BOXTIPOSERVICIO.Name = "BOXTIPOSERVICIO"
        Me.BOXTIPOSERVICIO.Size = New System.Drawing.Size(121, 21)
        Me.BOXTIPOSERVICIO.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "INGRESE TIPO DE TARIFA "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "SELECCIONE TIPO DE SERVICIO"
        '
        'PAGOTOTAL_BOX
        '
        Me.PAGOTOTAL_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label16)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label15)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label14)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label13)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label12)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label11)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label10)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label9)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label8)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_PagoTotal)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_Descuento)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_PagoParcial)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_PagoConMora)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_Mora)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_PagoInicial)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_SaldoAnterior)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_Tarifa)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_Servicio)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.Label7)
        Me.PAGOTOTAL_BOX.Controls.Add(Me.List_Cliente)
        Me.PAGOTOTAL_BOX.Location = New System.Drawing.Point(12, 324)
        Me.PAGOTOTAL_BOX.Name = "PAGOTOTAL_BOX"
        Me.PAGOTOTAL_BOX.Size = New System.Drawing.Size(1108, 197)
        Me.PAGOTOTAL_BOX.TabIndex = 2
        Me.PAGOTOTAL_BOX.TabStop = False
        Me.PAGOTOTAL_BOX.Text = "Pago Total"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(964, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Pago Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(855, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Descuento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(759, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Pago Parcial"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(648, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Pago Con Mora"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(537, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Mora"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(422, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Pago Inicial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(310, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Saldo Anterior"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tipo de Tarifa "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(113, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tipo de Servicio"
        '
        'List_PagoTotal
        '
        Me.List_PagoTotal.FormattingEnabled = True
        Me.List_PagoTotal.Location = New System.Drawing.Point(967, 71)
        Me.List_PagoTotal.Name = "List_PagoTotal"
        Me.List_PagoTotal.Size = New System.Drawing.Size(103, 95)
        Me.List_PagoTotal.TabIndex = 9
        '
        'List_Descuento
        '
        Me.List_Descuento.FormattingEnabled = True
        Me.List_Descuento.Location = New System.Drawing.Point(858, 71)
        Me.List_Descuento.Name = "List_Descuento"
        Me.List_Descuento.Size = New System.Drawing.Size(103, 95)
        Me.List_Descuento.TabIndex = 7
        '
        'List_PagoParcial
        '
        Me.List_PagoParcial.FormattingEnabled = True
        Me.List_PagoParcial.Location = New System.Drawing.Point(762, 71)
        Me.List_PagoParcial.Name = "List_PagoParcial"
        Me.List_PagoParcial.Size = New System.Drawing.Size(90, 95)
        Me.List_PagoParcial.TabIndex = 8
        '
        'List_PagoConMora
        '
        Me.List_PagoConMora.FormattingEnabled = True
        Me.List_PagoConMora.Location = New System.Drawing.Point(651, 71)
        Me.List_PagoConMora.Name = "List_PagoConMora"
        Me.List_PagoConMora.Size = New System.Drawing.Size(105, 95)
        Me.List_PagoConMora.TabIndex = 7
        '
        'List_Mora
        '
        Me.List_Mora.FormattingEnabled = True
        Me.List_Mora.Location = New System.Drawing.Point(540, 71)
        Me.List_Mora.Name = "List_Mora"
        Me.List_Mora.Size = New System.Drawing.Size(105, 95)
        Me.List_Mora.TabIndex = 6
        '
        'List_PagoInicial
        '
        Me.List_PagoInicial.FormattingEnabled = True
        Me.List_PagoInicial.Location = New System.Drawing.Point(425, 71)
        Me.List_PagoInicial.Name = "List_PagoInicial"
        Me.List_PagoInicial.Size = New System.Drawing.Size(100, 95)
        Me.List_PagoInicial.TabIndex = 5
        '
        'List_SaldoAnterior
        '
        Me.List_SaldoAnterior.FormattingEnabled = True
        Me.List_SaldoAnterior.Location = New System.Drawing.Point(313, 71)
        Me.List_SaldoAnterior.Name = "List_SaldoAnterior"
        Me.List_SaldoAnterior.Size = New System.Drawing.Size(103, 95)
        Me.List_SaldoAnterior.TabIndex = 4
        '
        'List_Tarifa
        '
        Me.List_Tarifa.FormattingEnabled = True
        Me.List_Tarifa.Location = New System.Drawing.Point(219, 71)
        Me.List_Tarifa.Name = "List_Tarifa"
        Me.List_Tarifa.Size = New System.Drawing.Size(88, 95)
        Me.List_Tarifa.TabIndex = 3
        '
        'List_Servicio
        '
        Me.List_Servicio.FormattingEnabled = True
        Me.List_Servicio.Location = New System.Drawing.Point(116, 71)
        Me.List_Servicio.Name = "List_Servicio"
        Me.List_Servicio.Size = New System.Drawing.Size(97, 95)
        Me.List_Servicio.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cliente"
        '
        'List_Cliente
        '
        Me.List_Cliente.FormattingEnabled = True
        Me.List_Cliente.Location = New System.Drawing.Point(6, 71)
        Me.List_Cliente.Name = "List_Cliente"
        Me.List_Cliente.Size = New System.Drawing.Size(104, 95)
        Me.List_Cliente.TabIndex = 0
        Me.List_Cliente.Tag = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1138, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "Calcular"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1138, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PAGOTOTAL_BOX)
        Me.Controls.Add(Me.SERVICIO_BOX)
        Me.Controls.Add(Me.DATOS_BOX)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Form1"
        Me.DATOS_BOX.ResumeLayout(False)
        Me.DATOS_BOX.PerformLayout()
        Me.SERVICIO_BOX.ResumeLayout(False)
        Me.SERVICIO_BOX.PerformLayout()
        Me.PAGOTOTAL_BOX.ResumeLayout(False)
        Me.PAGOTOTAL_BOX.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATOS_BOX As GroupBox
    Friend WithEvents SERVICIO_BOX As GroupBox
    Friend WithEvents PAGOTOTAL_BOX As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtConsumo As TextBox
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents TxtSaldoAnterior As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents BOXTIPOTARIFA As ComboBox
    Friend WithEvents BOXTIPOSERVICIO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents List_PagoTotal As ListBox
    Friend WithEvents List_Descuento As ListBox
    Friend WithEvents List_PagoParcial As ListBox
    Friend WithEvents List_PagoConMora As ListBox
    Friend WithEvents List_Mora As ListBox
    Friend WithEvents List_PagoInicial As ListBox
    Friend WithEvents List_SaldoAnterior As ListBox
    Friend WithEvents List_Tarifa As ListBox
    Friend WithEvents List_Servicio As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents List_Cliente As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
