<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrimerNumero = New System.Windows.Forms.TextBox()
        Me.txtSegundoNumero = New System.Windows.Forms.TextBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResiduo = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pirmer Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segundo Numero:"
        '
        'txtPrimerNumero
        '
        Me.txtPrimerNumero.Location = New System.Drawing.Point(137, 11)
        Me.txtPrimerNumero.Name = "txtPrimerNumero"
        Me.txtPrimerNumero.Size = New System.Drawing.Size(116, 22)
        Me.txtPrimerNumero.TabIndex = 0
        '
        'txtSegundoNumero
        '
        Me.txtSegundoNumero.Location = New System.Drawing.Point(137, 43)
        Me.txtSegundoNumero.Name = "txtSegundoNumero"
        Me.txtSegundoNumero.Size = New System.Drawing.Size(116, 22)
        Me.txtSegundoNumero.TabIndex = 1
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(102, 174)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(114, 29)
        Me.btnValidar.TabIndex = 5
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Location = New System.Drawing.Point(16, 133)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(285, 33)
        Me.lblMensaje.TabIndex = 4
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Residuo:"
        '
        'lblResiduo
        '
        Me.lblResiduo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResiduo.Location = New System.Drawing.Point(137, 104)
        Me.lblResiduo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResiduo.Name = "lblResiduo"
        Me.lblResiduo.Size = New System.Drawing.Size(116, 23)
        Me.lblResiduo.TabIndex = 3
        Me.lblResiduo.Text = "0.0"
        Me.lblResiduo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResultado
        '
        Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResultado.Location = New System.Drawing.Point(137, 73)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(116, 23)
        Me.lblResultado.TabIndex = 2
        Me.lblResultado.Text = "0.0"
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 214)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblResiduo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtSegundoNumero)
        Me.Controls.Add(Me.txtPrimerNumero)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divisible"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrimerNumero As TextBox
    Friend WithEvents txtSegundoNumero As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResiduo As Label
    Friend WithEvents lblResultado As Label
End Class
