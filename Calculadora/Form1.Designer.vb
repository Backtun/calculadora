<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOperacion
        '
        Me.txtOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperacion.Location = New System.Drawing.Point(12, 21)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.ReadOnly = True
        Me.txtOperacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOperacion.Size = New System.Drawing.Size(238, 29)
        Me.txtOperacion.TabIndex = 0
        Me.txtOperacion.Tag = ""
        Me.txtOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNum7
        '
        Me.btnNum7.Location = New System.Drawing.Point(13, 69)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(52, 44)
        Me.btnNum7.TabIndex = 1
        Me.btnNum7.Text = "7"
        Me.btnNum7.UseVisualStyleBackColor = True
        '
        'btnNum8
        '
        Me.btnNum8.Location = New System.Drawing.Point(71, 69)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(52, 44)
        Me.btnNum8.TabIndex = 2
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = True
        '
        'btnNum9
        '
        Me.btnNum9.Location = New System.Drawing.Point(129, 69)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(52, 44)
        Me.btnNum9.TabIndex = 3
        Me.btnNum9.Text = "9"
        Me.btnNum9.UseVisualStyleBackColor = True
        '
        'btnNum4
        '
        Me.btnNum4.Location = New System.Drawing.Point(12, 119)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(53, 42)
        Me.btnNum4.TabIndex = 4
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = True
        '
        'btnNum5
        '
        Me.btnNum5.Location = New System.Drawing.Point(71, 119)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(52, 42)
        Me.btnNum5.TabIndex = 5
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = True
        '
        'btnNum6
        '
        Me.btnNum6.Location = New System.Drawing.Point(129, 119)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(52, 42)
        Me.btnNum6.TabIndex = 6
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = True
        '
        'btnNum1
        '
        Me.btnNum1.Location = New System.Drawing.Point(12, 168)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(53, 47)
        Me.btnNum1.TabIndex = 7
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = True
        '
        'btnNum2
        '
        Me.btnNum2.Location = New System.Drawing.Point(71, 168)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(52, 47)
        Me.btnNum2.TabIndex = 8
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = True
        '
        'btnNum3
        '
        Me.btnNum3.Location = New System.Drawing.Point(129, 168)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(52, 47)
        Me.btnNum3.TabIndex = 9
        Me.btnNum3.Text = "3"
        Me.btnNum3.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(187, 70)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(63, 44)
        Me.btnSuma.TabIndex = 10
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(187, 120)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(63, 44)
        Me.btnResta.TabIndex = 11
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(187, 172)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(63, 44)
        Me.btnMulti.TabIndex = 12
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(71, 224)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(52, 44)
        Me.btnResultado.TabIndex = 13
        Me.btnResultado.Text = "="
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(187, 222)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(63, 44)
        Me.btnDivision.TabIndex = 14
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(129, 224)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(52, 44)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "C"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnNum0
        '
        Me.btnNum0.Location = New System.Drawing.Point(13, 224)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(52, 44)
        Me.btnNum0.TabIndex = 16
        Me.btnNum0.Text = "0"
        Me.btnNum0.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(261, 275)
        Me.Controls.Add(Me.btnNum0)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnNum3)
        Me.Controls.Add(Me.btnNum2)
        Me.Controls.Add(Me.btnNum1)
        Me.Controls.Add(Me.btnNum6)
        Me.Controls.Add(Me.btnNum5)
        Me.Controls.Add(Me.btnNum4)
        Me.Controls.Add(Me.btnNum9)
        Me.Controls.Add(Me.btnNum8)
        Me.Controls.Add(Me.btnNum7)
        Me.Controls.Add(Me.txtOperacion)
        Me.Name = "Calculadora"
        Me.Text = "Calculador Omega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperacion As TextBox
    Friend WithEvents btnNum7 As Button
    Friend WithEvents btnNum8 As Button
    Friend WithEvents btnNum9 As Button
    Friend WithEvents btnNum4 As Button
    Friend WithEvents btnNum5 As Button
    Friend WithEvents btnNum6 As Button
    Friend WithEvents btnNum1 As Button
    Friend WithEvents btnNum2 As Button
    Friend WithEvents btnNum3 As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnResultado As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnNum0 As Button
End Class
