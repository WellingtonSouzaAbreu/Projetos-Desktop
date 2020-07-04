<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadProduto))
        Me.txQuantidade = New System.Windows.Forms.TextBox()
        Me.lbQuantidade = New System.Windows.Forms.Label()
        Me.txValorVenda = New System.Windows.Forms.TextBox()
        Me.lbValorVenda = New System.Windows.Forms.Label()
        Me.txValorCompra = New System.Windows.Forms.TextBox()
        Me.lbValorCompra = New System.Windows.Forms.Label()
        Me.txDescricao = New System.Windows.Forms.TextBox()
        Me.lbDescricao = New System.Windows.Forms.Label()
        Me.txTaxa = New System.Windows.Forms.TextBox()
        Me.lbTaxa = New System.Windows.Forms.Label()
        Me.txTecido = New System.Windows.Forms.TextBox()
        Me.lbTecido = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.lbCategoria = New System.Windows.Forms.Label()
        Me.lbGenero = New System.Windows.Forms.Label()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.lbTamanho = New System.Windows.Forms.Label()
        Me.txTamanho = New System.Windows.Forms.TextBox()
        Me.dgProduto = New System.Windows.Forms.DataGridView()
        Me.gbDadosProduto = New System.Windows.Forms.GroupBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.txCodigo = New System.Windows.Forms.TextBox()
        Me.lbFornecedor = New System.Windows.Forms.Label()
        Me.cbFornecedor = New System.Windows.Forms.ComboBox()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.rbDescricao = New System.Windows.Forms.RadioButton()
        Me.rbTecido = New System.Windows.Forms.RadioButton()
        Me.rbGenero = New System.Windows.Forms.RadioButton()
        Me.rbTamanho = New System.Windows.Forms.RadioButton()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.rbDataCadastro = New System.Windows.Forms.RadioButton()
        Me.btVerTodos = New System.Windows.Forms.Button()
        Me.gbBuscarPor = New System.Windows.Forms.GroupBox()
        Me.lbE = New System.Windows.Forms.Label()
        Me.txBuscar = New System.Windows.Forms.TextBox()
        Me.lbEntre = New System.Windows.Forms.Label()
        Me.dtBuscarData1 = New System.Windows.Forms.DateTimePicker()
        Me.dtBuscarData2 = New System.Windows.Forms.DateTimePicker()
        Me.cbBuscar = New System.Windows.Forms.ComboBox()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btRemover = New System.Windows.Forms.Button()
        Me.ckMostrarZerados = New System.Windows.Forms.CheckBox()
        Me.lbN = New System.Windows.Forms.Label()
        Me.lbNumRegistros = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.Button()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDadosProduto.SuspendLayout()
        Me.gbBuscarPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txQuantidade
        '
        resources.ApplyResources(Me.txQuantidade, "txQuantidade")
        Me.txQuantidade.Name = "txQuantidade"
        '
        'lbQuantidade
        '
        resources.ApplyResources(Me.lbQuantidade, "lbQuantidade")
        Me.lbQuantidade.Name = "lbQuantidade"
        '
        'txValorVenda
        '
        resources.ApplyResources(Me.txValorVenda, "txValorVenda")
        Me.txValorVenda.Name = "txValorVenda"
        '
        'lbValorVenda
        '
        resources.ApplyResources(Me.lbValorVenda, "lbValorVenda")
        Me.lbValorVenda.Name = "lbValorVenda"
        '
        'txValorCompra
        '
        resources.ApplyResources(Me.txValorCompra, "txValorCompra")
        Me.txValorCompra.Name = "txValorCompra"
        '
        'lbValorCompra
        '
        resources.ApplyResources(Me.lbValorCompra, "lbValorCompra")
        Me.lbValorCompra.Name = "lbValorCompra"
        '
        'txDescricao
        '
        resources.ApplyResources(Me.txDescricao, "txDescricao")
        Me.txDescricao.Name = "txDescricao"
        '
        'lbDescricao
        '
        resources.ApplyResources(Me.lbDescricao, "lbDescricao")
        Me.lbDescricao.Name = "lbDescricao"
        '
        'txTaxa
        '
        resources.ApplyResources(Me.txTaxa, "txTaxa")
        Me.txTaxa.Name = "txTaxa"
        '
        'lbTaxa
        '
        resources.ApplyResources(Me.lbTaxa, "lbTaxa")
        Me.lbTaxa.Name = "lbTaxa"
        '
        'txTecido
        '
        resources.ApplyResources(Me.txTecido, "txTecido")
        Me.txTecido.Name = "txTecido"
        '
        'lbTecido
        '
        resources.ApplyResources(Me.lbTecido, "lbTecido")
        Me.lbTecido.Name = "lbTecido"
        '
        'cbCategoria
        '
        Me.cbCategoria.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("cbCategoria.AutoCompleteCustomSource"), resources.GetString("cbCategoria.AutoCompleteCustomSource1"), resources.GetString("cbCategoria.AutoCompleteCustomSource2")})
        Me.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.cbCategoria, "cbCategoria")
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Items.AddRange(New Object() {resources.GetString("cbCategoria.Items"), resources.GetString("cbCategoria.Items1"), resources.GetString("cbCategoria.Items2")})
        Me.cbCategoria.Name = "cbCategoria"
        '
        'lbCategoria
        '
        resources.ApplyResources(Me.lbCategoria, "lbCategoria")
        Me.lbCategoria.Name = "lbCategoria"
        '
        'lbGenero
        '
        resources.ApplyResources(Me.lbGenero, "lbGenero")
        Me.lbGenero.Name = "lbGenero"
        '
        'cbGenero
        '
        Me.cbGenero.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("cbGenero.AutoCompleteCustomSource"), resources.GetString("cbGenero.AutoCompleteCustomSource1"), resources.GetString("cbGenero.AutoCompleteCustomSource2")})
        Me.cbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.cbGenero, "cbGenero")
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {resources.GetString("cbGenero.Items"), resources.GetString("cbGenero.Items1"), resources.GetString("cbGenero.Items2")})
        Me.cbGenero.Name = "cbGenero"
        '
        'lbTamanho
        '
        resources.ApplyResources(Me.lbTamanho, "lbTamanho")
        Me.lbTamanho.Name = "lbTamanho"
        '
        'txTamanho
        '
        Me.txTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txTamanho, "txTamanho")
        Me.txTamanho.Name = "txTamanho"
        '
        'dgProduto
        '
        Me.dgProduto.AllowUserToAddRows = False
        Me.dgProduto.AllowUserToDeleteRows = False
        Me.dgProduto.AllowUserToOrderColumns = True
        Me.dgProduto.BackgroundColor = System.Drawing.Color.White
        Me.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.dgProduto, "dgProduto")
        Me.dgProduto.MultiSelect = False
        Me.dgProduto.Name = "dgProduto"
        Me.dgProduto.ReadOnly = True
        Me.dgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'gbDadosProduto
        '
        Me.gbDadosProduto.BackColor = System.Drawing.Color.Transparent
        Me.gbDadosProduto.Controls.Add(Me.lbCodigo)
        Me.gbDadosProduto.Controls.Add(Me.txCodigo)
        Me.gbDadosProduto.Controls.Add(Me.lbFornecedor)
        Me.gbDadosProduto.Controls.Add(Me.cbFornecedor)
        Me.gbDadosProduto.Controls.Add(Me.txDescricao)
        Me.gbDadosProduto.Controls.Add(Me.lbDescricao)
        Me.gbDadosProduto.Controls.Add(Me.txTaxa)
        Me.gbDadosProduto.Controls.Add(Me.txQuantidade)
        Me.gbDadosProduto.Controls.Add(Me.txValorVenda)
        Me.gbDadosProduto.Controls.Add(Me.lbValorVenda)
        Me.gbDadosProduto.Controls.Add(Me.lbQuantidade)
        Me.gbDadosProduto.Controls.Add(Me.lbTaxa)
        Me.gbDadosProduto.Controls.Add(Me.cbGenero)
        Me.gbDadosProduto.Controls.Add(Me.lbGenero)
        Me.gbDadosProduto.Controls.Add(Me.txTecido)
        Me.gbDadosProduto.Controls.Add(Me.txTamanho)
        Me.gbDadosProduto.Controls.Add(Me.txValorCompra)
        Me.gbDadosProduto.Controls.Add(Me.lbValorCompra)
        Me.gbDadosProduto.Controls.Add(Me.lbTamanho)
        Me.gbDadosProduto.Controls.Add(Me.lbCategoria)
        Me.gbDadosProduto.Controls.Add(Me.cbCategoria)
        Me.gbDadosProduto.Controls.Add(Me.lbTecido)
        resources.ApplyResources(Me.gbDadosProduto, "gbDadosProduto")
        Me.gbDadosProduto.Name = "gbDadosProduto"
        Me.gbDadosProduto.TabStop = False
        '
        'lbCodigo
        '
        resources.ApplyResources(Me.lbCodigo, "lbCodigo")
        Me.lbCodigo.Name = "lbCodigo"
        '
        'txCodigo
        '
        resources.ApplyResources(Me.txCodigo, "txCodigo")
        Me.txCodigo.Name = "txCodigo"
        Me.txCodigo.TabStop = False
        '
        'lbFornecedor
        '
        resources.ApplyResources(Me.lbFornecedor, "lbFornecedor")
        Me.lbFornecedor.Name = "lbFornecedor"
        '
        'cbFornecedor
        '
        Me.cbFornecedor.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("cbFornecedor.AutoCompleteCustomSource"), resources.GetString("cbFornecedor.AutoCompleteCustomSource1"), resources.GetString("cbFornecedor.AutoCompleteCustomSource2")})
        Me.cbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.cbFornecedor, "cbFornecedor")
        Me.cbFornecedor.FormattingEnabled = True
        Me.cbFornecedor.Name = "cbFornecedor"
        '
        'lbBuscar
        '
        resources.ApplyResources(Me.lbBuscar, "lbBuscar")
        Me.lbBuscar.Name = "lbBuscar"
        '
        'rbDescricao
        '
        resources.ApplyResources(Me.rbDescricao, "rbDescricao")
        Me.rbDescricao.Checked = True
        Me.rbDescricao.Name = "rbDescricao"
        Me.rbDescricao.TabStop = True
        Me.rbDescricao.UseVisualStyleBackColor = True
        '
        'rbTecido
        '
        resources.ApplyResources(Me.rbTecido, "rbTecido")
        Me.rbTecido.Name = "rbTecido"
        Me.rbTecido.UseVisualStyleBackColor = True
        '
        'rbGenero
        '
        resources.ApplyResources(Me.rbGenero, "rbGenero")
        Me.rbGenero.Name = "rbGenero"
        Me.rbGenero.UseVisualStyleBackColor = True
        '
        'rbTamanho
        '
        resources.ApplyResources(Me.rbTamanho, "rbTamanho")
        Me.rbTamanho.Name = "rbTamanho"
        Me.rbTamanho.UseVisualStyleBackColor = True
        '
        'rbCategoria
        '
        resources.ApplyResources(Me.rbCategoria, "rbCategoria")
        Me.rbCategoria.Name = "rbCategoria"
        Me.rbCategoria.UseVisualStyleBackColor = True
        '
        'rbDataCadastro
        '
        resources.ApplyResources(Me.rbDataCadastro, "rbDataCadastro")
        Me.rbDataCadastro.Name = "rbDataCadastro"
        Me.rbDataCadastro.UseVisualStyleBackColor = True
        '
        'btVerTodos
        '
        resources.ApplyResources(Me.btVerTodos, "btVerTodos")
        Me.btVerTodos.Name = "btVerTodos"
        Me.btVerTodos.UseVisualStyleBackColor = True
        '
        'gbBuscarPor
        '
        Me.gbBuscarPor.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscarPor.Controls.Add(Me.lbE)
        Me.gbBuscarPor.Controls.Add(Me.txBuscar)
        Me.gbBuscarPor.Controls.Add(Me.lbBuscar)
        Me.gbBuscarPor.Controls.Add(Me.lbEntre)
        Me.gbBuscarPor.Controls.Add(Me.rbDataCadastro)
        Me.gbBuscarPor.Controls.Add(Me.rbDescricao)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData1)
        Me.gbBuscarPor.Controls.Add(Me.rbCategoria)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData2)
        Me.gbBuscarPor.Controls.Add(Me.cbBuscar)
        Me.gbBuscarPor.Controls.Add(Me.rbTecido)
        Me.gbBuscarPor.Controls.Add(Me.rbTamanho)
        Me.gbBuscarPor.Controls.Add(Me.rbGenero)
        resources.ApplyResources(Me.gbBuscarPor, "gbBuscarPor")
        Me.gbBuscarPor.Name = "gbBuscarPor"
        Me.gbBuscarPor.TabStop = False
        '
        'lbE
        '
        resources.ApplyResources(Me.lbE, "lbE")
        Me.lbE.Name = "lbE"
        '
        'txBuscar
        '
        resources.ApplyResources(Me.txBuscar, "txBuscar")
        Me.txBuscar.Name = "txBuscar"
        '
        'lbEntre
        '
        resources.ApplyResources(Me.lbEntre, "lbEntre")
        Me.lbEntre.Name = "lbEntre"
        '
        'dtBuscarData1
        '
        resources.ApplyResources(Me.dtBuscarData1, "dtBuscarData1")
        Me.dtBuscarData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData1.Name = "dtBuscarData1"
        Me.dtBuscarData1.TabStop = False
        Me.dtBuscarData1.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        '
        'dtBuscarData2
        '
        resources.ApplyResources(Me.dtBuscarData2, "dtBuscarData2")
        Me.dtBuscarData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData2.Name = "dtBuscarData2"
        Me.dtBuscarData2.TabStop = False
        Me.dtBuscarData2.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        '
        'cbBuscar
        '
        Me.cbBuscar.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("cbBuscar.AutoCompleteCustomSource"), resources.GetString("cbBuscar.AutoCompleteCustomSource1"), resources.GetString("cbBuscar.AutoCompleteCustomSource2")})
        Me.cbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.cbBuscar, "cbBuscar")
        Me.cbBuscar.FormattingEnabled = True
        Me.cbBuscar.Name = "cbBuscar"
        '
        'btNovo
        '
        resources.ApplyResources(Me.btNovo, "btNovo")
        Me.btNovo.Name = "btNovo"
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        resources.ApplyResources(Me.btSalvar, "btSalvar")
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        resources.ApplyResources(Me.btEditar, "btEditar")
        Me.btEditar.Name = "btEditar"
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btRemover
        '
        resources.ApplyResources(Me.btRemover, "btRemover")
        Me.btRemover.Name = "btRemover"
        Me.btRemover.UseVisualStyleBackColor = True
        '
        'ckMostrarZerados
        '
        resources.ApplyResources(Me.ckMostrarZerados, "ckMostrarZerados")
        Me.ckMostrarZerados.Name = "ckMostrarZerados"
        Me.ckMostrarZerados.UseVisualStyleBackColor = True
        '
        'lbN
        '
        resources.ApplyResources(Me.lbN, "lbN")
        Me.lbN.Name = "lbN"
        '
        'lbNumRegistros
        '
        resources.ApplyResources(Me.lbNumRegistros, "lbNumRegistros")
        Me.lbNumRegistros.Name = "lbNumRegistros"
        '
        'btHome
        '
        resources.ApplyResources(Me.btHome, "btHome")
        Me.btHome.Name = "btHome"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'Frm_CadProduto
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.lbN)
        Me.Controls.Add(Me.lbNumRegistros)
        Me.Controls.Add(Me.ckMostrarZerados)
        Me.Controls.Add(Me.btRemover)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.gbBuscarPor)
        Me.Controls.Add(Me.btVerTodos)
        Me.Controls.Add(Me.gbDadosProduto)
        Me.Controls.Add(Me.dgProduto)
        Me.Name = "Frm_CadProduto"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDadosProduto.ResumeLayout(False)
        Me.gbDadosProduto.PerformLayout()
        Me.gbBuscarPor.ResumeLayout(False)
        Me.gbBuscarPor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txQuantidade As TextBox
    Friend WithEvents lbQuantidade As Label
    Friend WithEvents txValorVenda As TextBox
    Friend WithEvents lbValorVenda As Label
    Friend WithEvents txValorCompra As TextBox
    Friend WithEvents lbValorCompra As Label
    Friend WithEvents txDescricao As TextBox
    Friend WithEvents lbDescricao As Label
    Friend WithEvents txTaxa As TextBox
    Friend WithEvents lbTaxa As Label
    Friend WithEvents txTecido As TextBox
    Friend WithEvents lbTecido As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents lbCategoria As Label
    Friend WithEvents lbGenero As Label
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents lbTamanho As Label
    Friend WithEvents txTamanho As TextBox
    Friend WithEvents dgProduto As DataGridView
    Friend WithEvents gbDadosProduto As GroupBox
    Friend WithEvents lbBuscar As Label
    Friend WithEvents rbDescricao As RadioButton
    Friend WithEvents rbTecido As RadioButton
    Friend WithEvents rbGenero As RadioButton
    Friend WithEvents rbTamanho As RadioButton
    Friend WithEvents rbCategoria As RadioButton
    Friend WithEvents rbDataCadastro As RadioButton
    Friend WithEvents btVerTodos As Button
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents btNovo As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btRemover As Button
    Friend WithEvents cbBuscar As ComboBox
    Friend WithEvents txBuscar As TextBox
    Friend WithEvents lbFornecedor As Label
    Friend WithEvents cbFornecedor As ComboBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents lbE As Label
    Friend WithEvents lbEntre As Label
    Friend WithEvents dtBuscarData1 As DateTimePicker
    Friend WithEvents dtBuscarData2 As DateTimePicker
    Friend WithEvents ckMostrarZerados As CheckBox
    Friend WithEvents lbN As Label
    Friend WithEvents lbNumRegistros As Label
    Friend WithEvents btHome As Button
End Class
