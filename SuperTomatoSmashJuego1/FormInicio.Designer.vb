<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Me.ButtonJugar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonOpciones = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonJugar
        '
        Me.ButtonJugar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonJugar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJugar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonJugar.FlatAppearance.BorderSize = 0
        Me.ButtonJugar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJugar.Font = New System.Drawing.Font("Retro Gaming", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJugar.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonJugar.Location = New System.Drawing.Point(428, 274)
        Me.ButtonJugar.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonJugar.Name = "ButtonJugar"
        Me.ButtonJugar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonJugar.Size = New System.Drawing.Size(168, 48)
        Me.ButtonJugar.TabIndex = 3
        Me.ButtonJugar.Text = "Jugar"
        Me.ButtonJugar.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonSalir.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Font = New System.Drawing.Font("Retro Gaming", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonSalir.Location = New System.Drawing.Point(428, 370)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSalir.Size = New System.Drawing.Size(168, 48)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SuperTomatoSmashJuego1.My.Resources.Resources.Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(148, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SuperTomatoSmashJuego1.My.Resources.Resources.Taco
        Me.PictureBox2.Location = New System.Drawing.Point(855, 633)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Retro Gaming", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(12, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Versión 1.0"
        '
        'ButtonOpciones
        '
        Me.ButtonOpciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonOpciones.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOpciones.FlatAppearance.BorderSize = 0
        Me.ButtonOpciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ButtonOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpciones.Font = New System.Drawing.Font("Retro Gaming", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpciones.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ButtonOpciones.Location = New System.Drawing.Point(428, 322)
        Me.ButtonOpciones.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonOpciones.Name = "ButtonOpciones"
        Me.ButtonOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonOpciones.Size = New System.Drawing.Size(168, 48)
        Me.ButtonOpciones.TabIndex = 10
        Me.ButtonOpciones.Text = "Opciones"
        Me.ButtonOpciones.UseVisualStyleBackColor = False
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BackgroundImage = Global.SuperTomatoSmashJuego1.My.Resources.Resources.Fondo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 745)
        Me.Controls.Add(Me.ButtonOpciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonJugar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonJugar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonOpciones As Button
End Class
