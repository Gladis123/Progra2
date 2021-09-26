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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Combo_SeleccioneMarca = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_NoDiasAlquiler = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_NIT = New System.Windows.Forms.TextBox()
        Me.Text_IngresePlaca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Text_Tarjeta = New System.Windows.Forms.TextBox()
        Me.Text_Efectivo = New System.Windows.Forms.TextBox()
        Me.Check_Tarjeta = New System.Windows.Forms.CheckBox()
        Me.Check_Efectivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.List_Total = New System.Windows.Forms.ListBox()
        Me.List_Descuento = New System.Windows.Forms.ListBox()
        Me.List_Parcial = New System.Windows.Forms.ListBox()
        Me.List_Dias = New System.Windows.Forms.ListBox()
        Me.List_Marca = New System.Windows.Forms.ListBox()
        Me.List_Placa = New System.Windows.Forms.ListBox()
        Me.List_NIT = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combo_SeleccioneMarca
        '
        Me.Combo_SeleccioneMarca.FormattingEnabled = True
        Me.Combo_SeleccioneMarca.Items.AddRange(New Object() {"Honda", "Mercedez", "Toyota", "Mazda"})
        Me.Combo_SeleccioneMarca.Location = New System.Drawing.Point(170, 113)
        Me.Combo_SeleccioneMarca.Name = "Combo_SeleccioneMarca"
        Me.Combo_SeleccioneMarca.Size = New System.Drawing.Size(132, 21)
        Me.Combo_SeleccioneMarca.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Text_NoDiasAlquiler)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Text_NIT)
        Me.GroupBox1.Controls.Add(Me.Text_IngresePlaca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Combo_SeleccioneMarca)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 192)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'Text_NoDiasAlquiler
        '
        Me.Text_NoDiasAlquiler.Location = New System.Drawing.Point(170, 163)
        Me.Text_NoDiasAlquiler.Name = "Text_NoDiasAlquiler"
        Me.Text_NoDiasAlquiler.Size = New System.Drawing.Size(132, 20)
        Me.Text_NoDiasAlquiler.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No. Dias que alquilara:"
        '
        'Text_NIT
        '
        Me.Text_NIT.Location = New System.Drawing.Point(170, 70)
        Me.Text_NIT.Name = "Text_NIT"
        Me.Text_NIT.Size = New System.Drawing.Size(132, 20)
        Me.Text_NIT.TabIndex = 7
        '
        'Text_IngresePlaca
        '
        Me.Text_IngresePlaca.Location = New System.Drawing.Point(170, 36)
        Me.Text_IngresePlaca.Name = "Text_IngresePlaca"
        Me.Text_IngresePlaca.Size = New System.Drawing.Size(132, 20)
        Me.Text_IngresePlaca.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Seleccione la marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese su placa:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Text_Tarjeta)
        Me.GroupBox2.Controls.Add(Me.Text_Efectivo)
        Me.GroupBox2.Controls.Add(Me.Check_Tarjeta)
        Me.GroupBox2.Controls.Add(Me.Check_Efectivo)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 125)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma De Pago"
        '
        'Text_Tarjeta
        '
        Me.Text_Tarjeta.Location = New System.Drawing.Point(102, 101)
        Me.Text_Tarjeta.Name = "Text_Tarjeta"
        Me.Text_Tarjeta.Size = New System.Drawing.Size(132, 20)
        Me.Text_Tarjeta.TabIndex = 8
        '
        'Text_Efectivo
        '
        Me.Text_Efectivo.Location = New System.Drawing.Point(106, 29)
        Me.Text_Efectivo.Name = "Text_Efectivo"
        Me.Text_Efectivo.Size = New System.Drawing.Size(132, 20)
        Me.Text_Efectivo.TabIndex = 7
        '
        'Check_Tarjeta
        '
        Me.Check_Tarjeta.AutoSize = True
        Me.Check_Tarjeta.Location = New System.Drawing.Point(35, 99)
        Me.Check_Tarjeta.Name = "Check_Tarjeta"
        Me.Check_Tarjeta.Size = New System.Drawing.Size(59, 17)
        Me.Check_Tarjeta.TabIndex = 5
        Me.Check_Tarjeta.Text = "Tarjeta"
        Me.Check_Tarjeta.UseVisualStyleBackColor = True
        '
        'Check_Efectivo
        '
        Me.Check_Efectivo.AutoSize = True
        Me.Check_Efectivo.Location = New System.Drawing.Point(35, 31)
        Me.Check_Efectivo.Name = "Check_Efectivo"
        Me.Check_Efectivo.Size = New System.Drawing.Size(65, 17)
        Me.Check_Efectivo.TabIndex = 0
        Me.Check_Efectivo.Text = "Efectivo"
        Me.Check_Efectivo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.List_Total)
        Me.GroupBox3.Controls.Add(Me.List_Descuento)
        Me.GroupBox3.Controls.Add(Me.List_Parcial)
        Me.GroupBox3.Controls.Add(Me.List_Dias)
        Me.GroupBox3.Controls.Add(Me.List_Marca)
        Me.GroupBox3.Controls.Add(Me.List_Placa)
        Me.GroupBox3.Controls.Add(Me.List_NIT)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(869, 188)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'List_Total
        '
        Me.List_Total.FormattingEnabled = True
        Me.List_Total.Location = New System.Drawing.Point(701, 35)
        Me.List_Total.Name = "List_Total"
        Me.List_Total.Size = New System.Drawing.Size(120, 134)
        Me.List_Total.TabIndex = 6
        '
        'List_Descuento
        '
        Me.List_Descuento.FormattingEnabled = True
        Me.List_Descuento.Location = New System.Drawing.Point(577, 35)
        Me.List_Descuento.Name = "List_Descuento"
        Me.List_Descuento.Size = New System.Drawing.Size(103, 134)
        Me.List_Descuento.TabIndex = 5
        '
        'List_Parcial
        '
        Me.List_Parcial.FormattingEnabled = True
        Me.List_Parcial.Location = New System.Drawing.Point(442, 35)
        Me.List_Parcial.Name = "List_Parcial"
        Me.List_Parcial.Size = New System.Drawing.Size(100, 134)
        Me.List_Parcial.TabIndex = 4
        '
        'List_Dias
        '
        Me.List_Dias.FormattingEnabled = True
        Me.List_Dias.Location = New System.Drawing.Point(325, 35)
        Me.List_Dias.Name = "List_Dias"
        Me.List_Dias.Size = New System.Drawing.Size(91, 134)
        Me.List_Dias.TabIndex = 3
        '
        'List_Marca
        '
        Me.List_Marca.FormattingEnabled = True
        Me.List_Marca.Location = New System.Drawing.Point(214, 35)
        Me.List_Marca.Name = "List_Marca"
        Me.List_Marca.Size = New System.Drawing.Size(92, 134)
        Me.List_Marca.TabIndex = 2
        '
        'List_Placa
        '
        Me.List_Placa.FormattingEnabled = True
        Me.List_Placa.Location = New System.Drawing.Point(110, 35)
        Me.List_Placa.Name = "List_Placa"
        Me.List_Placa.Size = New System.Drawing.Size(98, 134)
        Me.List_Placa.TabIndex = 1
        '
        'List_NIT
        '
        Me.List_NIT.FormattingEnabled = True
        Me.List_NIT.Location = New System.Drawing.Point(6, 35)
        Me.List_NIT.Name = "List_NIT"
        Me.List_NIT.Size = New System.Drawing.Size(98, 134)
        Me.List_NIT.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarListasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(916, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular "
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas "
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores "
        '
        'LimpiarListasToolStripMenuItem
        '
        Me.LimpiarListasToolStripMenuItem.Name = "LimpiarListasToolStripMenuItem"
        Me.LimpiarListasToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.LimpiarListasToolStripMenuItem.Text = "Limpiar Listas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(916, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "RENTA_AUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Combo_SeleccioneMarca As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Text_NoDiasAlquiler As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_NIT As TextBox
    Friend WithEvents Text_IngresePlaca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Text_Tarjeta As TextBox
    Friend WithEvents Text_Efectivo As TextBox
    Friend WithEvents Check_Tarjeta As CheckBox
    Friend WithEvents Check_Efectivo As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents List_Total As ListBox
    Friend WithEvents List_Descuento As ListBox
    Friend WithEvents List_Parcial As ListBox
    Friend WithEvents List_Dias As ListBox
    Friend WithEvents List_Marca As ListBox
    Friend WithEvents List_Placa As ListBox
    Friend WithEvents List_NIT As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
