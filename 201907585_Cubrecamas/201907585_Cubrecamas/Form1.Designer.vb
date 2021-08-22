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
        Me.RKing = New System.Windows.Forms.RadioButton()
        Me.Rqueen = New System.Windows.Forms.RadioButton()
        Me.Rmatrimonial = New System.Windows.Forms.RadioButton()
        Me.Rimperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.THiloCrudo = New System.Windows.Forms.CheckBox()
        Me.TSeda = New System.Windows.Forms.CheckBox()
        Me.TAlgodon = New System.Windows.Forms.CheckBox()
        Me.TLino = New System.Windows.Forms.CheckBox()
        Me.THilo = New System.Windows.Forms.TextBox()
        Me.TxtLino = New System.Windows.Forms.TextBox()
        Me.TxtSeda = New System.Windows.Forms.TextBox()
        Me.TxtAlgodon = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.precioCostoooo = New System.Windows.Forms.Label()
        Me.LPrecioCosto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RKing)
        Me.GroupBox1.Controls.Add(Me.Rqueen)
        Me.GroupBox1.Controls.Add(Me.Rmatrimonial)
        Me.GroupBox1.Controls.Add(Me.Rimperial)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(62, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de cubrecama"
        '
        'RKing
        '
        Me.RKing.AutoSize = True
        Me.RKing.Location = New System.Drawing.Point(38, 124)
        Me.RKing.Name = "RKing"
        Me.RKing.Size = New System.Drawing.Size(45, 17)
        Me.RKing.TabIndex = 3
        Me.RKing.TabStop = True
        Me.RKing.Text = "king"
        Me.RKing.UseVisualStyleBackColor = True
        '
        'Rqueen
        '
        Me.Rqueen.AutoSize = True
        Me.Rqueen.Location = New System.Drawing.Point(38, 90)
        Me.Rqueen.Name = "Rqueen"
        Me.Rqueen.Size = New System.Drawing.Size(55, 17)
        Me.Rqueen.TabIndex = 2
        Me.Rqueen.TabStop = True
        Me.Rqueen.Text = "queen"
        Me.Rqueen.UseVisualStyleBackColor = True
        '
        'Rmatrimonial
        '
        Me.Rmatrimonial.AutoSize = True
        Me.Rmatrimonial.Location = New System.Drawing.Point(38, 56)
        Me.Rmatrimonial.Name = "Rmatrimonial"
        Me.Rmatrimonial.Size = New System.Drawing.Size(80, 17)
        Me.Rmatrimonial.TabIndex = 1
        Me.Rmatrimonial.TabStop = True
        Me.Rmatrimonial.Text = "matrimonial "
        Me.Rmatrimonial.UseVisualStyleBackColor = True
        '
        'Rimperial
        '
        Me.Rimperial.AutoSize = True
        Me.Rimperial.Location = New System.Drawing.Point(38, 19)
        Me.Rimperial.Name = "Rimperial"
        Me.Rimperial.Size = New System.Drawing.Size(63, 17)
        Me.Rimperial.TabIndex = 0
        Me.Rimperial.TabStop = True
        Me.Rimperial.Text = "imperial "
        Me.Rimperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.THiloCrudo)
        Me.GroupBox2.Controls.Add(Me.TSeda)
        Me.GroupBox2.Controls.Add(Me.TAlgodon)
        Me.GroupBox2.Controls.Add(Me.TLino)
        Me.GroupBox2.Controls.Add(Me.THilo)
        Me.GroupBox2.Controls.Add(Me.TxtLino)
        Me.GroupBox2.Controls.Add(Me.TxtSeda)
        Me.GroupBox2.Controls.Add(Me.TxtAlgodon)
        Me.GroupBox2.Location = New System.Drawing.Point(324, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 167)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Material "
        '
        'THiloCrudo
        '
        Me.THiloCrudo.AutoSize = True
        Me.THiloCrudo.Location = New System.Drawing.Point(47, 124)
        Me.THiloCrudo.Name = "THiloCrudo"
        Me.THiloCrudo.Size = New System.Drawing.Size(74, 17)
        Me.THiloCrudo.TabIndex = 3
        Me.THiloCrudo.Text = "Hilo crudo"
        Me.THiloCrudo.UseVisualStyleBackColor = True
        '
        'TSeda
        '
        Me.TSeda.AutoSize = True
        Me.TSeda.Location = New System.Drawing.Point(47, 90)
        Me.TSeda.Name = "TSeda"
        Me.TSeda.Size = New System.Drawing.Size(51, 17)
        Me.TSeda.TabIndex = 2
        Me.TSeda.Text = "Seda"
        Me.TSeda.UseVisualStyleBackColor = True
        '
        'TAlgodon
        '
        Me.TAlgodon.AutoSize = True
        Me.TAlgodon.Location = New System.Drawing.Point(47, 56)
        Me.TAlgodon.Name = "TAlgodon"
        Me.TAlgodon.Size = New System.Drawing.Size(68, 17)
        Me.TAlgodon.TabIndex = 1
        Me.TAlgodon.Text = "Algodón "
        Me.TAlgodon.UseVisualStyleBackColor = True
        '
        'TLino
        '
        Me.TLino.AutoSize = True
        Me.TLino.Location = New System.Drawing.Point(47, 20)
        Me.TLino.Name = "TLino"
        Me.TLino.Size = New System.Drawing.Size(46, 17)
        Me.TLino.TabIndex = 0
        Me.TLino.Text = "Lino"
        Me.TLino.UseVisualStyleBackColor = True
        '
        'THilo
        '
        Me.THilo.Location = New System.Drawing.Point(169, 124)
        Me.THilo.Name = "THilo"
        Me.THilo.Size = New System.Drawing.Size(100, 20)
        Me.THilo.TabIndex = 3
        Me.THilo.Text = "0"
        '
        'TxtLino
        '
        Me.TxtLino.Location = New System.Drawing.Point(169, 16)
        Me.TxtLino.Name = "TxtLino"
        Me.TxtLino.Size = New System.Drawing.Size(100, 20)
        Me.TxtLino.TabIndex = 0
        Me.TxtLino.Text = "0"
        '
        'TxtSeda
        '
        Me.TxtSeda.Location = New System.Drawing.Point(169, 89)
        Me.TxtSeda.Name = "TxtSeda"
        Me.TxtSeda.Size = New System.Drawing.Size(100, 20)
        Me.TxtSeda.TabIndex = 2
        Me.TxtSeda.Text = "0"
        '
        'TxtAlgodon
        '
        Me.TxtAlgodon.Location = New System.Drawing.Point(169, 55)
        Me.TxtAlgodon.Name = "TxtAlgodon"
        Me.TxtAlgodon.Size = New System.Drawing.Size(100, 20)
        Me.TxtAlgodon.TabIndex = 1
        Me.TxtAlgodon.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(62, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(296, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 48)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Calcular "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(536, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 48)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Salir "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'precioCostoooo
        '
        Me.precioCostoooo.AutoSize = True
        Me.precioCostoooo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.precioCostoooo.Location = New System.Drawing.Point(78, 280)
        Me.precioCostoooo.Name = "precioCostoooo"
        Me.precioCostoooo.Size = New System.Drawing.Size(85, 13)
        Me.precioCostoooo.TabIndex = 10
        Me.precioCostoooo.Text = "Precio de Costo:"
        '
        'LPrecioCosto
        '
        Me.LPrecioCosto.AutoSize = True
        Me.LPrecioCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LPrecioCosto.Location = New System.Drawing.Point(189, 280)
        Me.LPrecioCosto.Name = "LPrecioCosto"
        Me.LPrecioCosto.Size = New System.Drawing.Size(28, 13)
        Me.LPrecioCosto.TabIndex = 13
        Me.LPrecioCosto.Text = "0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LPrecioCosto)
        Me.Controls.Add(Me.precioCostoooo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RKing As RadioButton
    Friend WithEvents Rqueen As RadioButton
    Friend WithEvents Rmatrimonial As RadioButton
    Friend WithEvents Rimperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents THiloCrudo As CheckBox
    Friend WithEvents TSeda As CheckBox
    Friend WithEvents TAlgodon As CheckBox
    Friend WithEvents TLino As CheckBox
    Friend WithEvents THilo As TextBox
    Friend WithEvents TxtLino As TextBox
    Friend WithEvents TxtSeda As TextBox
    Friend WithEvents TxtAlgodon As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents precioCostoooo As Label
    Friend WithEvents LPrecioCosto As Label
End Class
