<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Venda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Venda))
        Me.txIdVenda = New System.Windows.Forms.TextBox()
        Me.gbDadosVenda = New System.Windows.Forms.GroupBox()
        Me.lbNItens = New System.Windows.Forms.Label()
        Me.lbNumItens = New System.Windows.Forms.Label()
        Me.txIdCliente = New System.Windows.Forms.TextBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.txIdProdutoLista = New System.Windows.Forms.TextBox()
        Me.txJuros = New System.Windows.Forms.TextBox()
        Me.lbJuros = New System.Windows.Forms.Label()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btIrProduto = New System.Windows.Forms.Button()
        Me.txCodigo = New System.Windows.Forms.TextBox()
        Me.lbQtd = New System.Windows.Forms.Label()
        Me.txQtd = New System.Windows.Forms.TextBox()
        Me.btIrCliente = New System.Windows.Forms.Button()
        Me.txCliente = New System.Windows.Forms.TextBox()
        Me.gbFormaPagamento = New System.Windows.Forms.GroupBox()
        Me.rbAPrazo = New System.Windows.Forms.RadioButton()
        Me.rbAVista = New System.Windows.Forms.RadioButton()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lbDesconto = New System.Windows.Forms.Label()
        Me.txDesconto = New System.Windows.Forms.TextBox()
        Me.dgListaProdutos = New System.Windows.Forms.DataGridView()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.dgVendas = New System.Windows.Forms.DataGridView()
        Me.btRemover = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.gbBuscarPor = New System.Windows.Forms.GroupBox()
        Me.lbE = New System.Windows.Forms.Label()
        Me.lbEntre = New System.Windows.Forms.Label()
        Me.dtBuscarData1 = New System.Windows.Forms.DateTimePicker()
        Me.dtBuscarData2 = New System.Windows.Forms.DateTimePicker()
        Me.cbBuscarFdp = New System.Windows.Forms.ComboBox()
        Me.txBuscarTxt = New System.Windows.Forms.TextBox()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.rbFormaPagamento = New System.Windows.Forms.RadioButton()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.txTot = New System.Windows.Forms.TextBox()
        Me.txIdVendaMan = New System.Windows.Forms.TextBox()
        Me.btVerTodos = New System.Windows.Forms.Button()
        Me.lbNumRegistros = New System.Windows.Forms.Label()
        Me.lbN = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.Button()
        Me.gbDadosVenda.SuspendLayout()
        Me.gbFormaPagamento.SuspendLayout()
        CType(Me.dgListaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txIdVenda
        '
        Me.txIdVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdVenda.Location = New System.Drawing.Point(1, 0)
        Me.txIdVenda.Name = "txIdVenda"
        Me.txIdVenda.Size = New System.Drawing.Size(33, 26)
        Me.txIdVenda.TabIndex = 1
        Me.txIdVenda.UseWaitCursor = True
        Me.txIdVenda.Visible = False
        '
        'gbDadosVenda
        '
        Me.gbDadosVenda.Controls.Add(Me.lbNItens)
        Me.gbDadosVenda.Controls.Add(Me.lbNumItens)
        Me.gbDadosVenda.Controls.Add(Me.txIdCliente)
        Me.gbDadosVenda.Controls.Add(Me.lbStatus)
        Me.gbDadosVenda.Controls.Add(Me.cbStatus)
        Me.gbDadosVenda.Controls.Add(Me.txIdProdutoLista)
        Me.gbDadosVenda.Controls.Add(Me.txJuros)
        Me.gbDadosVenda.Controls.Add(Me.lbJuros)
        Me.gbDadosVenda.Controls.Add(Me.btDel)
        Me.gbDadosVenda.Controls.Add(Me.btIrProduto)
        Me.gbDadosVenda.Controls.Add(Me.txCodigo)
        Me.gbDadosVenda.Controls.Add(Me.lbQtd)
        Me.gbDadosVenda.Controls.Add(Me.txQtd)
        Me.gbDadosVenda.Controls.Add(Me.btIrCliente)
        Me.gbDadosVenda.Controls.Add(Me.txCliente)
        Me.gbDadosVenda.Controls.Add(Me.gbFormaPagamento)
        Me.gbDadosVenda.Controls.Add(Me.btAdd)
        Me.gbDadosVenda.Controls.Add(Me.lbCliente)
        Me.gbDadosVenda.Controls.Add(Me.lbCodigo)
        Me.gbDadosVenda.Controls.Add(Me.lbDesconto)
        Me.gbDadosVenda.Controls.Add(Me.txDesconto)
        Me.gbDadosVenda.Controls.Add(Me.dgListaProdutos)
        Me.gbDadosVenda.Controls.Add(Me.lbTotal)
        Me.gbDadosVenda.Controls.Add(Me.txTotal)
        Me.gbDadosVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosVenda.Location = New System.Drawing.Point(25, 22)
        Me.gbDadosVenda.Name = "gbDadosVenda"
        Me.gbDadosVenda.Size = New System.Drawing.Size(819, 358)
        Me.gbDadosVenda.TabIndex = 2
        Me.gbDadosVenda.TabStop = False
        Me.gbDadosVenda.Text = "Dados da Venda"
        '
        'lbNItens
        '
        Me.lbNItens.AutoSize = True
        Me.lbNItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNItens.Location = New System.Drawing.Point(758, 24)
        Me.lbNItens.Name = "lbNItens"
        Me.lbNItens.Size = New System.Drawing.Size(14, 15)
        Me.lbNItens.TabIndex = 75
        Me.lbNItens.Text = "0"
        '
        'lbNumItens
        '
        Me.lbNumItens.AutoSize = True
        Me.lbNumItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumItens.Location = New System.Drawing.Point(658, 23)
        Me.lbNumItens.Name = "lbNumItens"
        Me.lbNumItens.Size = New System.Drawing.Size(101, 15)
        Me.lbNumItens.TabIndex = 74
        Me.lbNumItens.Text = "Numero de Itens:"
        '
        'txIdCliente
        '
        Me.txIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdCliente.Location = New System.Drawing.Point(-1, 307)
        Me.txIdCliente.Name = "txIdCliente"
        Me.txIdCliente.Size = New System.Drawing.Size(33, 26)
        Me.txIdCliente.TabIndex = 71
        Me.txIdCliente.UseWaitCursor = True
        Me.txIdCliente.Visible = False
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(426, 283)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(60, 20)
        Me.lbStatus.TabIndex = 71
        Me.lbStatus.Text = "Status:"
        Me.lbStatus.Visible = False
        '
        'cbStatus
        '
        Me.cbStatus.AutoCompleteCustomSource.AddRange(New String() {"Pago", "Pendente"})
        Me.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Pago", "Pendente"})
        Me.cbStatus.Location = New System.Drawing.Point(429, 307)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 26)
        Me.cbStatus.TabIndex = 70
        Me.cbStatus.Text = "Pendente"
        Me.cbStatus.Visible = False
        '
        'txIdProdutoLista
        '
        Me.txIdProdutoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdProdutoLista.Location = New System.Drawing.Point(364, 14)
        Me.txIdProdutoLista.Name = "txIdProdutoLista"
        Me.txIdProdutoLista.Size = New System.Drawing.Size(33, 26)
        Me.txIdProdutoLista.TabIndex = 69
        Me.txIdProdutoLista.UseWaitCursor = True
        Me.txIdProdutoLista.Visible = False
        '
        'txJuros
        '
        Me.txJuros.Location = New System.Drawing.Point(329, 309)
        Me.txJuros.MaxLength = 7
        Me.txJuros.Name = "txJuros"
        Me.txJuros.Size = New System.Drawing.Size(66, 26)
        Me.txJuros.TabIndex = 68
        Me.txJuros.Visible = False
        '
        'lbJuros
        '
        Me.lbJuros.AutoSize = True
        Me.lbJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJuros.Location = New System.Drawing.Point(325, 285)
        Me.lbJuros.Name = "lbJuros"
        Me.lbJuros.Size = New System.Drawing.Size(76, 20)
        Me.lbJuros.TabIndex = 67
        Me.lbJuros.Text = "Juros(%):"
        Me.lbJuros.Visible = False
        '
        'btDel
        '
        Me.btDel.BackgroundImage = CType(resources.GetObject("btDel.BackgroundImage"), System.Drawing.Image)
        Me.btDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Location = New System.Drawing.Point(302, 98)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(56, 50)
        Me.btDel.TabIndex = 66
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btIrProduto
        '
        Me.btIrProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIrProduto.Location = New System.Drawing.Point(173, 56)
        Me.btIrProduto.Name = "btIrProduto"
        Me.btIrProduto.Size = New System.Drawing.Size(29, 28)
        Me.btIrProduto.TabIndex = 63
        Me.btIrProduto.Text = "Ir"
        Me.btIrProduto.UseVisualStyleBackColor = True
        '
        'txCodigo
        '
        Me.txCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCodigo.Location = New System.Drawing.Point(38, 57)
        Me.txCodigo.MaxLength = 100
        Me.txCodigo.Name = "txCodigo"
        Me.txCodigo.Size = New System.Drawing.Size(133, 26)
        Me.txCodigo.TabIndex = 21
        '
        'lbQtd
        '
        Me.lbQtd.AutoSize = True
        Me.lbQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQtd.Location = New System.Drawing.Point(215, 35)
        Me.lbQtd.Name = "lbQtd"
        Me.lbQtd.Size = New System.Drawing.Size(39, 20)
        Me.lbQtd.TabIndex = 16
        Me.lbQtd.Text = "Qtd:"
        '
        'txQtd
        '
        Me.txQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txQtd.Location = New System.Drawing.Point(219, 58)
        Me.txQtd.MaxLength = 3
        Me.txQtd.Name = "txQtd"
        Me.txQtd.Size = New System.Drawing.Size(48, 26)
        Me.txQtd.TabIndex = 17
        Me.txQtd.Text = "1"
        '
        'btIrCliente
        '
        Me.btIrCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIrCliente.Location = New System.Drawing.Point(272, 307)
        Me.btIrCliente.Name = "btIrCliente"
        Me.btIrCliente.Size = New System.Drawing.Size(27, 27)
        Me.btIrCliente.TabIndex = 15
        Me.btIrCliente.Text = "Ir"
        Me.btIrCliente.UseVisualStyleBackColor = True
        Me.btIrCliente.Visible = False
        '
        'txCliente
        '
        Me.txCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.txCliente.Location = New System.Drawing.Point(41, 308)
        Me.txCliente.MaxLength = 60
        Me.txCliente.Name = "txCliente"
        Me.txCliente.ReadOnly = True
        Me.txCliente.Size = New System.Drawing.Size(230, 26)
        Me.txCliente.TabIndex = 14
        '
        'gbFormaPagamento
        '
        Me.gbFormaPagamento.Controls.Add(Me.rbAPrazo)
        Me.gbFormaPagamento.Controls.Add(Me.rbAVista)
        Me.gbFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFormaPagamento.Location = New System.Drawing.Point(42, 172)
        Me.gbFormaPagamento.Name = "gbFormaPagamento"
        Me.gbFormaPagamento.Size = New System.Drawing.Size(229, 88)
        Me.gbFormaPagamento.TabIndex = 3
        Me.gbFormaPagamento.TabStop = False
        Me.gbFormaPagamento.Text = "Forma de Pagamento"
        '
        'rbAPrazo
        '
        Me.rbAPrazo.AutoSize = True
        Me.rbAPrazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAPrazo.Location = New System.Drawing.Point(133, 39)
        Me.rbAPrazo.Name = "rbAPrazo"
        Me.rbAPrazo.Size = New System.Drawing.Size(83, 24)
        Me.rbAPrazo.TabIndex = 15
        Me.rbAPrazo.Text = "À Prazo"
        Me.rbAPrazo.UseVisualStyleBackColor = True
        '
        'rbAVista
        '
        Me.rbAVista.AutoSize = True
        Me.rbAVista.Checked = True
        Me.rbAVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAVista.Location = New System.Drawing.Point(23, 39)
        Me.rbAVista.Name = "rbAVista"
        Me.rbAVista.Size = New System.Drawing.Size(74, 24)
        Me.rbAVista.TabIndex = 14
        Me.rbAVista.TabStop = True
        Me.rbAVista.Text = "À vista"
        Me.rbAVista.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.BackgroundImage = CType(resources.GetObject("btAdd.BackgroundImage"), System.Drawing.Image)
        Me.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Location = New System.Drawing.Point(302, 43)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(56, 51)
        Me.btAdd.TabIndex = 12
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(38, 285)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(62, 20)
        Me.lbCliente.TabIndex = 13
        Me.lbCliente.Text = "Cliente:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.Location = New System.Drawing.Point(37, 34)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(63, 20)
        Me.lbCodigo.TabIndex = 8
        Me.lbCodigo.Text = "Codigo:"
        '
        'lbDesconto
        '
        Me.lbDesconto.AutoSize = True
        Me.lbDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDesconto.Location = New System.Drawing.Point(581, 284)
        Me.lbDesconto.Name = "lbDesconto"
        Me.lbDesconto.Size = New System.Drawing.Size(106, 20)
        Me.lbDesconto.TabIndex = 6
        Me.lbDesconto.Text = "Desconto(%):"
        '
        'txDesconto
        '
        Me.txDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDesconto.Location = New System.Drawing.Point(585, 307)
        Me.txDesconto.MaxLength = 5
        Me.txDesconto.Name = "txDesconto"
        Me.txDesconto.Size = New System.Drawing.Size(97, 26)
        Me.txDesconto.TabIndex = 7
        '
        'dgListaProdutos
        '
        Me.dgListaProdutos.AllowUserToAddRows = False
        Me.dgListaProdutos.AllowUserToDeleteRows = False
        Me.dgListaProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgListaProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgListaProdutos.Location = New System.Drawing.Point(364, 42)
        Me.dgListaProdutos.MultiSelect = False
        Me.dgListaProdutos.Name = "dgListaProdutos"
        Me.dgListaProdutos.ReadOnly = True
        Me.dgListaProdutos.RowHeadersWidth = 4
        Me.dgListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaProdutos.Size = New System.Drawing.Size(419, 218)
        Me.dgListaProdutos.TabIndex = 5
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(706, 284)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(48, 20)
        Me.lbTotal.TabIndex = 4
        Me.lbTotal.Text = "Total:"
        '
        'txTotal
        '
        Me.txTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotal.Location = New System.Drawing.Point(710, 307)
        Me.txTotal.MaxLength = 10
        Me.txTotal.Name = "txTotal"
        Me.txTotal.ReadOnly = True
        Me.txTotal.Size = New System.Drawing.Size(73, 26)
        Me.txTotal.TabIndex = 4
        '
        'dgVendas
        '
        Me.dgVendas.AllowUserToAddRows = False
        Me.dgVendas.AllowUserToDeleteRows = False
        Me.dgVendas.AllowUserToOrderColumns = True
        Me.dgVendas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgVendas.Location = New System.Drawing.Point(25, 421)
        Me.dgVendas.MultiSelect = False
        Me.dgVendas.Name = "dgVendas"
        Me.dgVendas.ReadOnly = True
        Me.dgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVendas.Size = New System.Drawing.Size(1279, 259)
        Me.dgVendas.TabIndex = 6
        '
        'btRemover
        '
        Me.btRemover.BackgroundImage = CType(resources.GetObject("btRemover.BackgroundImage"), System.Drawing.Image)
        Me.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRemover.Location = New System.Drawing.Point(1224, 335)
        Me.btRemover.Name = "btRemover"
        Me.btRemover.Size = New System.Drawing.Size(80, 80)
        Me.btRemover.TabIndex = 59
        Me.btRemover.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.BackgroundImage = CType(resources.GetObject("btEditar.BackgroundImage"), System.Drawing.Image)
        Me.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEditar.Location = New System.Drawing.Point(1125, 334)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(80, 80)
        Me.btEditar.TabIndex = 58
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = CType(resources.GetObject("btSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalvar.Location = New System.Drawing.Point(1026, 335)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(80, 80)
        Me.btSalvar.TabIndex = 57
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.BackgroundImage = CType(resources.GetObject("btNovo.BackgroundImage"), System.Drawing.Image)
        Me.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNovo.Location = New System.Drawing.Point(924, 334)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(80, 80)
        Me.btNovo.TabIndex = 56
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'gbBuscarPor
        '
        Me.gbBuscarPor.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscarPor.Controls.Add(Me.lbE)
        Me.gbBuscarPor.Controls.Add(Me.lbEntre)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData1)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData2)
        Me.gbBuscarPor.Controls.Add(Me.cbBuscarFdp)
        Me.gbBuscarPor.Controls.Add(Me.txBuscarTxt)
        Me.gbBuscarPor.Controls.Add(Me.lbBuscar)
        Me.gbBuscarPor.Controls.Add(Me.rbFormaPagamento)
        Me.gbBuscarPor.Controls.Add(Me.rbData)
        Me.gbBuscarPor.Controls.Add(Me.rbCliente)
        Me.gbBuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscarPor.Location = New System.Drawing.Point(883, 22)
        Me.gbBuscarPor.Name = "gbBuscarPor"
        Me.gbBuscarPor.Size = New System.Drawing.Size(421, 178)
        Me.gbBuscarPor.TabIndex = 60
        Me.gbBuscarPor.TabStop = False
        Me.gbBuscarPor.Text = "Buscar Por:"
        '
        'lbE
        '
        Me.lbE.AutoSize = True
        Me.lbE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbE.Location = New System.Drawing.Point(234, 137)
        Me.lbE.Name = "lbE"
        Me.lbE.Size = New System.Drawing.Size(18, 20)
        Me.lbE.TabIndex = 51
        Me.lbE.Text = "e"
        Me.lbE.Visible = False
        '
        'lbEntre
        '
        Me.lbEntre.AutoSize = True
        Me.lbEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbEntre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbEntre.Location = New System.Drawing.Point(30, 132)
        Me.lbEntre.Name = "lbEntre"
        Me.lbEntre.Size = New System.Drawing.Size(52, 20)
        Me.lbEntre.TabIndex = 50
        Me.lbEntre.Text = "Entre:"
        Me.lbEntre.Visible = False
        '
        'dtBuscarData1
        '
        Me.dtBuscarData1.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData1.Enabled = False
        Me.dtBuscarData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtBuscarData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData1.Location = New System.Drawing.Point(83, 131)
        Me.dtBuscarData1.Name = "dtBuscarData1"
        Me.dtBuscarData1.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData1.TabIndex = 48
        Me.dtBuscarData1.TabStop = False
        Me.dtBuscarData1.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        Me.dtBuscarData1.Visible = False
        '
        'dtBuscarData2
        '
        Me.dtBuscarData2.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData2.Enabled = False
        Me.dtBuscarData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtBuscarData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData2.Location = New System.Drawing.Point(276, 131)
        Me.dtBuscarData2.Name = "dtBuscarData2"
        Me.dtBuscarData2.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData2.TabIndex = 49
        Me.dtBuscarData2.TabStop = False
        Me.dtBuscarData2.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        Me.dtBuscarData2.Visible = False
        '
        'cbBuscarFdp
        '
        Me.cbBuscarFdp.AutoCompleteCustomSource.AddRange(New String() {"À Vista", "À Prazo"})
        Me.cbBuscarFdp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBuscarFdp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBuscarFdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarFdp.FormattingEnabled = True
        Me.cbBuscarFdp.Items.AddRange(New Object() {"A Vista", "A Prazo"})
        Me.cbBuscarFdp.Location = New System.Drawing.Point(82, 98)
        Me.cbBuscarFdp.Name = "cbBuscarFdp"
        Me.cbBuscarFdp.Size = New System.Drawing.Size(166, 26)
        Me.cbBuscarFdp.TabIndex = 27
        '
        'txBuscarTxt
        '
        Me.txBuscarTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBuscarTxt.Location = New System.Drawing.Point(82, 98)
        Me.txBuscarTxt.MaxLength = 60
        Me.txBuscarTxt.Name = "txBuscarTxt"
        Me.txBuscarTxt.Size = New System.Drawing.Size(166, 26)
        Me.txBuscarTxt.TabIndex = 21
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(13, 101)
        Me.lbBuscar.Name = "lbBuscar"
        Me.lbBuscar.Size = New System.Drawing.Size(63, 20)
        Me.lbBuscar.TabIndex = 21
        Me.lbBuscar.Text = "Buscar:"
        '
        'rbFormaPagamento
        '
        Me.rbFormaPagamento.AutoSize = True
        Me.rbFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFormaPagamento.Location = New System.Drawing.Point(123, 41)
        Me.rbFormaPagamento.Name = "rbFormaPagamento"
        Me.rbFormaPagamento.Size = New System.Drawing.Size(180, 24)
        Me.rbFormaPagamento.TabIndex = 23
        Me.rbFormaPagamento.Text = "Forma de pagamento"
        Me.rbFormaPagamento.UseVisualStyleBackColor = True
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbData.Location = New System.Drawing.Point(331, 43)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(62, 24)
        Me.rbData.TabIndex = 24
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Checked = True
        Me.rbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.Location = New System.Drawing.Point(17, 41)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(76, 24)
        Me.rbCliente.TabIndex = 26
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'txTot
        '
        Me.txTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTot.Location = New System.Drawing.Point(850, 328)
        Me.txTot.MaxLength = 10
        Me.txTot.Name = "txTot"
        Me.txTot.Size = New System.Drawing.Size(63, 26)
        Me.txTot.TabIndex = 70
        Me.txTot.Visible = False
        '
        'txIdVendaMan
        '
        Me.txIdVendaMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdVendaMan.Location = New System.Drawing.Point(291, 392)
        Me.txIdVendaMan.Name = "txIdVendaMan"
        Me.txIdVendaMan.Size = New System.Drawing.Size(33, 26)
        Me.txIdVendaMan.TabIndex = 71
        Me.txIdVendaMan.UseWaitCursor = True
        Me.txIdVendaMan.Visible = False
        '
        'btVerTodos
        '
        Me.btVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btVerTodos.Image = CType(resources.GetObject("btVerTodos.Image"), System.Drawing.Image)
        Me.btVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerTodos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btVerTodos.Location = New System.Drawing.Point(1166, 203)
        Me.btVerTodos.Name = "btVerTodos"
        Me.btVerTodos.Size = New System.Drawing.Size(138, 25)
        Me.btVerTodos.TabIndex = 72
        Me.btVerTodos.Text = "Ver todos"
        Me.btVerTodos.UseVisualStyleBackColor = True
        '
        'lbNumRegistros
        '
        Me.lbNumRegistros.AutoSize = True
        Me.lbNumRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumRegistros.Location = New System.Drawing.Point(21, 401)
        Me.lbNumRegistros.Name = "lbNumRegistros"
        Me.lbNumRegistros.Size = New System.Drawing.Size(150, 17)
        Me.lbNumRegistros.TabIndex = 73
        Me.lbNumRegistros.Text = "Numero de Registros: "
        '
        'lbN
        '
        Me.lbN.AutoSize = True
        Me.lbN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbN.Location = New System.Drawing.Point(166, 402)
        Me.lbN.Name = "lbN"
        Me.lbN.Size = New System.Drawing.Size(16, 17)
        Me.lbN.TabIndex = 74
        Me.lbN.Text = "0"
        '
        'btHome
        '
        Me.btHome.BackgroundImage = CType(resources.GetObject("btHome.BackgroundImage"), System.Drawing.Image)
        Me.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btHome.Location = New System.Drawing.Point(1224, 245)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(80, 80)
        Me.btHome.TabIndex = 79
        Me.btHome.UseVisualStyleBackColor = True
        '
        'Frm_Venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.lbN)
        Me.Controls.Add(Me.lbNumRegistros)
        Me.Controls.Add(Me.btVerTodos)
        Me.Controls.Add(Me.txIdVendaMan)
        Me.Controls.Add(Me.txTot)
        Me.Controls.Add(Me.gbBuscarPor)
        Me.Controls.Add(Me.btRemover)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.dgVendas)
        Me.Controls.Add(Me.gbDadosVenda)
        Me.Controls.Add(Me.txIdVenda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Venda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Venda"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbDadosVenda.ResumeLayout(False)
        Me.gbDadosVenda.PerformLayout()
        Me.gbFormaPagamento.ResumeLayout(False)
        Me.gbFormaPagamento.PerformLayout()
        CType(Me.dgListaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarPor.ResumeLayout(False)
        Me.gbBuscarPor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txIdVenda As TextBox
    Friend WithEvents gbDadosVenda As GroupBox
    Friend WithEvents btIrCliente As Button
    Friend WithEvents txCliente As TextBox
    Friend WithEvents gbFormaPagamento As GroupBox
    Friend WithEvents rbAPrazo As RadioButton
    Friend WithEvents rbAVista As RadioButton
    Friend WithEvents btAdd As Button
    Friend WithEvents lbCliente As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents lbDesconto As Label
    Friend WithEvents txDesconto As TextBox
    Friend WithEvents dgListaProdutos As DataGridView
    Friend WithEvents lbTotal As Label
    Friend WithEvents txTotal As TextBox
    Friend WithEvents lbQtd As Label
    Friend WithEvents txQtd As TextBox
    Friend WithEvents dgVendas As DataGridView
    Friend WithEvents btRemover As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents txBuscarTxt As TextBox
    Friend WithEvents lbBuscar As Label
    Friend WithEvents rbFormaPagamento As RadioButton
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents btIrProduto As Button
    Friend WithEvents btDel As Button
    Friend WithEvents cbBuscarFdp As ComboBox
    Friend WithEvents txJuros As TextBox
    Friend WithEvents lbJuros As Label
    Friend WithEvents txIdProdutoLista As TextBox
    Friend WithEvents txTot As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents txIdCliente As TextBox
    Friend WithEvents txIdVendaMan As TextBox
    Friend WithEvents lbE As Label
    Friend WithEvents lbEntre As Label
    Friend WithEvents dtBuscarData1 As DateTimePicker
    Friend WithEvents dtBuscarData2 As DateTimePicker
    Friend WithEvents btVerTodos As Button
    Friend WithEvents lbNumRegistros As Label
    Friend WithEvents lbN As Label
    Friend WithEvents lbNItens As Label
    Friend WithEvents lbNumItens As Label
    Friend WithEvents btHome As Button
End Class
