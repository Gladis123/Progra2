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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoxCine = New System.Windows.Forms.ComboBox()
        Me.BoxFuncion = New System.Windows.Forms.ComboBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cine = New System.Windows.Forms.ListBox()
        Me.Funcion = New System.Windows.Forms.ListBox()
        Me.Subtotal = New System.Windows.Forms.ListBox()
        Me.Descuento1 = New System.Windows.Forms.ListBox()
        Me.Descuento2 = New System.Windows.Forms.ListBox()
        Me.Total = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoletos = New System.Windows.Forms.TextBox()
        Me.SalirBTN = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextBoletos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BoxCine)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BoxFuncion)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elije Cine y Funcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Funcion"
        '
        'BoxCine
        '
        Me.BoxCine.FormattingEnabled = True
        Me.BoxCine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.BoxCine.Location = New System.Drawing.Point(75, 39)
        Me.BoxCine.Name = "BoxCine"
        Me.BoxCine.Size = New System.Drawing.Size(121, 21)
        Me.BoxCine.TabIndex = 2
        '
        'BoxFuncion
        '
        Me.BoxFuncion.FormattingEnabled = True
        Me.BoxFuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.BoxFuncion.Location = New System.Drawing.Point(194, 94)
        Me.BoxFuncion.Name = "BoxFuncion"
        Me.BoxFuncion.Size = New System.Drawing.Size(121, 21)
        Me.BoxFuncion.TabIndex = 3
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonCalcular.ForeColor = System.Drawing.Color.Black
        Me.ButtonCalcular.Location = New System.Drawing.Point(728, 203)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(136, 74)
        Me.ButtonCalcular.TabIndex = 4
        Me.ButtonCalcular.Text = "Aceptar"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonLimpiar.ForeColor = System.Drawing.Color.Black
        Me.ButtonLimpiar.Location = New System.Drawing.Point(728, 68)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(136, 85)
        Me.ButtonLimpiar.TabIndex = 5
        Me.ButtonLimpiar.Text = "Limpiar Entradas"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento2)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.Subtotal)
        Me.GroupBox2.Controls.Add(Me.Funcion)
        Me.GroupBox2.Controls.Add(Me.Cine)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 188)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'Cine
        '
        Me.Cine.FormattingEnabled = True
        Me.Cine.Location = New System.Drawing.Point(6, 28)
        Me.Cine.Name = "Cine"
        Me.Cine.Size = New System.Drawing.Size(92, 147)
        Me.Cine.TabIndex = 0
        '
        'Funcion
        '
        Me.Funcion.FormattingEnabled = True
        Me.Funcion.Location = New System.Drawing.Point(122, 28)
        Me.Funcion.Name = "Funcion"
        Me.Funcion.Size = New System.Drawing.Size(92, 147)
        Me.Funcion.TabIndex = 1
        '
        'Subtotal
        '
        Me.Subtotal.FormattingEnabled = True
        Me.Subtotal.Location = New System.Drawing.Point(241, 28)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(92, 147)
        Me.Subtotal.TabIndex = 2
        '
        'Descuento1
        '
        Me.Descuento1.FormattingEnabled = True
        Me.Descuento1.Location = New System.Drawing.Point(351, 28)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(92, 147)
        Me.Descuento1.TabIndex = 3
        '
        'Descuento2
        '
        Me.Descuento2.FormattingEnabled = True
        Me.Descuento2.Location = New System.Drawing.Point(470, 28)
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Size = New System.Drawing.Size(92, 147)
        Me.Descuento2.TabIndex = 4
        '
        'Total
        '
        Me.Total.FormattingEnabled = True
        Me.Total.Location = New System.Drawing.Point(573, 28)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(69, 147)
        Me.Total.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad de boletos"
        '
        'TextBoletos
        '
        Me.TextBoletos.Location = New System.Drawing.Point(268, 40)
        Me.TextBoletos.Name = "TextBoletos"
        Me.TextBoletos.Size = New System.Drawing.Size(157, 20)
        Me.TextBoletos.TabIndex = 5
        '
        'SalirBTN
        '
        Me.SalirBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SalirBTN.ForeColor = System.Drawing.Color.Black
        Me.SalirBTN.Location = New System.Drawing.Point(728, 313)
        Me.SalirBTN.Name = "SalirBTN"
        Me.SalirBTN.Size = New System.Drawing.Size(136, 85)
        Me.SalirBTN.TabIndex = 6
        Me.SalirBTN.Text = "Salir"
        Me.SalirBTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(876, 450)
        Me.Controls.Add(Me.SalirBTN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxCine As ComboBox
    Friend WithEvents BoxFuncion As ComboBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Total As ListBox
    Friend WithEvents Descuento2 As ListBox
    Friend WithEvents Descuento1 As ListBox
    Friend WithEvents Subtotal As ListBox
    Friend WithEvents Funcion As ListBox
    Friend WithEvents Cine As ListBox
    Friend WithEvents TextBoletos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SalirBTN As Button
End Class
