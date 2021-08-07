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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cantidad.Location = New System.Drawing.Point(143, 124)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(52, 40)
        Me.txt_cantidad.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(3, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Menu 1", "Menu 2", "Menu 3", "Menu 4"})
        Me.cmb_tipo.Location = New System.Drawing.Point(143, 58)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(151, 39)
        Me.cmb_tipo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(592, 84)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Restaurante 092❤"
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_agregar.Location = New System.Drawing.Point(113, 347)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(175, 38)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Agregar ❤"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_sub
        '
        Me.txt_sub.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_sub.Location = New System.Drawing.Point(148, 56)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(125, 40)
        Me.txt_sub.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_total)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_sub)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(456, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 278)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_total.Location = New System.Drawing.Point(121, 194)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(125, 40)
        Me.txt_total.TabIndex = 8
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.Location = New System.Drawing.Point(208, 153)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 35)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(7, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 31)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "¿Cuenta con tarjeta privilegio?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.Location = New System.Drawing.Point(57, 153)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 35)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sí"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sub Total"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(294, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(379, 59)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "¡Gracias por visitarnos! ❤"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 504)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_sub As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
