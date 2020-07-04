<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TelaPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContaAPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromissóriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.AToolStripMenuItem, Me.FinanceiroToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutoToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.FornecedorToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Image = CType(resources.GetObject("CadastrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(96, 23)
        Me.CadastrarToolStripMenuItem.Text = "Cadastrar"
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Image = CType(resources.GetObject("ProdutoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.ProdutoToolStripMenuItem.Text = "Produto"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Image = CType(resources.GetObject("ClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'FornecedorToolStripMenuItem
        '
        Me.FornecedorToolStripMenuItem.Image = CType(resources.GetObject("FornecedorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FornecedorToolStripMenuItem.Name = "FornecedorToolStripMenuItem"
        Me.FornecedorToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.FornecedorToolStripMenuItem.Text = "Fornecedor"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem})
        Me.AToolStripMenuItem.Image = CType(resources.GetObject("AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(81, 23)
        Me.AToolStripMenuItem.Text = "Vendas"
        '
        'NovaVendaToolStripMenuItem
        '
        Me.NovaVendaToolStripMenuItem.Image = CType(resources.GetObject("NovaVendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
        Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.NovaVendaToolStripMenuItem.Text = "Nova venda"
        '
        'FinanceiroToolStripMenuItem
        '
        Me.FinanceiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContaAPagarToolStripMenuItem, Me.PromissóriasToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.FinanceiroToolStripMenuItem.Image = CType(resources.GetObject("FinanceiroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        Me.FinanceiroToolStripMenuItem.Size = New System.Drawing.Size(99, 23)
        Me.FinanceiroToolStripMenuItem.Text = "Financeiro"
        '
        'ContaAPagarToolStripMenuItem
        '
        Me.ContaAPagarToolStripMenuItem.Image = CType(resources.GetObject("ContaAPagarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContaAPagarToolStripMenuItem.Name = "ContaAPagarToolStripMenuItem"
        Me.ContaAPagarToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ContaAPagarToolStripMenuItem.Text = "Custos Adicionais"
        '
        'PromissóriasToolStripMenuItem
        '
        Me.PromissóriasToolStripMenuItem.Image = CType(resources.GetObject("PromissóriasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PromissóriasToolStripMenuItem.Name = "PromissóriasToolStripMenuItem"
        Me.PromissóriasToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.PromissóriasToolStripMenuItem.Text = "Promissórias"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContaAPagarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromissóriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
End Class
