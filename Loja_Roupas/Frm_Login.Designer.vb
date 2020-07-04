<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.txSenha = New System.Windows.Forms.TextBox()
        Me.btEntrar = New System.Windows.Forms.Button()
        Me.lbAviso = New System.Windows.Forms.Label()
        Me.lbAviso2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txUsuario
        '
        Me.txUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txUsuario.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txUsuario.Location = New System.Drawing.Point(265, 197)
        Me.txUsuario.MaxLength = 20
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(313, 16)
        Me.txUsuario.TabIndex = 0
        '
        'txSenha
        '
        Me.txSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txSenha.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txSenha.Location = New System.Drawing.Point(265, 257)
        Me.txSenha.MaxLength = 20
        Me.txSenha.Name = "txSenha"
        Me.txSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txSenha.Size = New System.Drawing.Size(313, 16)
        Me.txSenha.TabIndex = 1
        '
        'btEntrar
        '
        Me.btEntrar.BackColor = System.Drawing.Color.Black
        Me.btEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEntrar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btEntrar.Location = New System.Drawing.Point(478, 304)
        Me.btEntrar.Name = "btEntrar"
        Me.btEntrar.Size = New System.Drawing.Size(108, 37)
        Me.btEntrar.TabIndex = 2
        Me.btEntrar.Text = "Entrar"
        Me.btEntrar.UseVisualStyleBackColor = False
        '
        'lbAviso
        '
        Me.lbAviso.AutoSize = True
        Me.lbAviso.BackColor = System.Drawing.Color.Transparent
        Me.lbAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAviso.ForeColor = System.Drawing.Color.Red
        Me.lbAviso.Location = New System.Drawing.Point(226, 288)
        Me.lbAviso.Name = "lbAviso"
        Me.lbAviso.Size = New System.Drawing.Size(227, 13)
        Me.lbAviso.TabIndex = 3
        Me.lbAviso.Text = "* A senha deve conter no mínimo 8 caracteres"
        Me.lbAviso.Visible = False
        '
        'lbAviso2
        '
        Me.lbAviso2.AutoSize = True
        Me.lbAviso2.BackColor = System.Drawing.Color.Transparent
        Me.lbAviso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAviso2.ForeColor = System.Drawing.Color.Red
        Me.lbAviso2.Location = New System.Drawing.Point(226, 288)
        Me.lbAviso2.Name = "lbAviso2"
        Me.lbAviso2.Size = New System.Drawing.Size(193, 13)
        Me.lbAviso2.TabIndex = 4
        Me.lbAviso2.Text = "* O usuario ou a senha estão incorretos"
        Me.lbAviso2.Visible = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 481)
        Me.Controls.Add(Me.lbAviso2)
        Me.Controls.Add(Me.lbAviso)
        Me.Controls.Add(Me.btEntrar)
        Me.Controls.Add(Me.txSenha)
        Me.Controls.Add(Me.txUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txUsuario As TextBox
    Friend WithEvents txSenha As TextBox
    Friend WithEvents btEntrar As Button
    Friend WithEvents lbAviso As Label
    Friend WithEvents lbAviso2 As Label
End Class
