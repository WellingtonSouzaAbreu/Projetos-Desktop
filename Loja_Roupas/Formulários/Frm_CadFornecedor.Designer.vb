<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CadFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadFornecedor))
        Me.dgFornecedor = New System.Windows.Forms.DataGridView()
        Me.txIdFornecedor = New System.Windows.Forms.TextBox()
        Me.btVerTodos = New System.Windows.Forms.Button()
        Me.gbDadosFornecedor = New System.Windows.Forms.GroupBox()
        Me.LbUf = New System.Windows.Forms.Label()
        Me.cbUf = New System.Windows.Forms.ComboBox()
        Me.cbCidade = New System.Windows.Forms.ComboBox()
        Me.txCelular2 = New System.Windows.Forms.MaskedTextBox()
        Me.lbCelular2 = New System.Windows.Forms.Label()
        Me.txObs = New System.Windows.Forms.TextBox()
        Me.lbObs = New System.Windows.Forms.Label()
        Me.txCelular1 = New System.Windows.Forms.MaskedTextBox()
        Me.txTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lbCelular1 = New System.Windows.Forms.Label()
        Me.txCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.lbCnpj = New System.Windows.Forms.Label()
        Me.lbCidade = New System.Windows.Forms.Label()
        Me.txEmail = New System.Windows.Forms.TextBox()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.txEndereco = New System.Windows.Forms.TextBox()
        Me.txNumero = New System.Windows.Forms.TextBox()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.txDenominacaoSocial = New System.Windows.Forms.TextBox()
        Me.lbDenominacaoSocial = New System.Windows.Forms.Label()
        Me.rbCidade = New System.Windows.Forms.RadioButton()
        Me.rbCnpj = New System.Windows.Forms.RadioButton()
        Me.btRemover = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.rbDenominacaoSocial = New System.Windows.Forms.RadioButton()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.gbBuscarPor = New System.Windows.Forms.GroupBox()
        Me.lbE = New System.Windows.Forms.Label()
        Me.lbEntre = New System.Windows.Forms.Label()
        Me.dtBuscarData1 = New System.Windows.Forms.DateTimePicker()
        Me.dtBuscarData2 = New System.Windows.Forms.DateTimePicker()
        Me.txBuscarCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.txBuscar = New System.Windows.Forms.TextBox()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.rbDataCadastro = New System.Windows.Forms.RadioButton()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.lbN = New System.Windows.Forms.Label()
        Me.lbNumRegistros = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.Button()
        CType(Me.dgFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDadosFornecedor.SuspendLayout()
        Me.gbBuscarPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFornecedor
        '
        Me.dgFornecedor.AllowUserToAddRows = False
        Me.dgFornecedor.AllowUserToDeleteRows = False
        Me.dgFornecedor.BackgroundColor = System.Drawing.Color.White
        Me.dgFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgFornecedor.Location = New System.Drawing.Point(33, 296)
        Me.dgFornecedor.MultiSelect = False
        Me.dgFornecedor.Name = "dgFornecedor"
        Me.dgFornecedor.ReadOnly = True
        Me.dgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFornecedor.Size = New System.Drawing.Size(1282, 276)
        Me.dgFornecedor.TabIndex = 21
        '
        'txIdFornecedor
        '
        Me.txIdFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdFornecedor.Location = New System.Drawing.Point(6, 2)
        Me.txIdFornecedor.Name = "txIdFornecedor"
        Me.txIdFornecedor.Size = New System.Drawing.Size(30, 23)
        Me.txIdFornecedor.TabIndex = 47
        Me.txIdFornecedor.Visible = False
        '
        'btVerTodos
        '
        Me.btVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btVerTodos.Image = CType(resources.GetObject("btVerTodos.Image"), System.Drawing.Image)
        Me.btVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerTodos.Location = New System.Drawing.Point(1179, 272)
        Me.btVerTodos.Name = "btVerTodos"
        Me.btVerTodos.Size = New System.Drawing.Size(136, 25)
        Me.btVerTodos.TabIndex = 20
        Me.btVerTodos.Text = "Ver todos"
        Me.btVerTodos.UseVisualStyleBackColor = True
        '
        'gbDadosFornecedor
        '
        Me.gbDadosFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.gbDadosFornecedor.Controls.Add(Me.LbUf)
        Me.gbDadosFornecedor.Controls.Add(Me.cbUf)
        Me.gbDadosFornecedor.Controls.Add(Me.cbCidade)
        Me.gbDadosFornecedor.Controls.Add(Me.txCelular2)
        Me.gbDadosFornecedor.Controls.Add(Me.lbCelular2)
        Me.gbDadosFornecedor.Controls.Add(Me.txObs)
        Me.gbDadosFornecedor.Controls.Add(Me.lbObs)
        Me.gbDadosFornecedor.Controls.Add(Me.txCelular1)
        Me.gbDadosFornecedor.Controls.Add(Me.txTelefone)
        Me.gbDadosFornecedor.Controls.Add(Me.lbCelular1)
        Me.gbDadosFornecedor.Controls.Add(Me.txCnpj)
        Me.gbDadosFornecedor.Controls.Add(Me.lbTelefone)
        Me.gbDadosFornecedor.Controls.Add(Me.lbCnpj)
        Me.gbDadosFornecedor.Controls.Add(Me.lbCidade)
        Me.gbDadosFornecedor.Controls.Add(Me.txEmail)
        Me.gbDadosFornecedor.Controls.Add(Me.lbEmail)
        Me.gbDadosFornecedor.Controls.Add(Me.txEndereco)
        Me.gbDadosFornecedor.Controls.Add(Me.txNumero)
        Me.gbDadosFornecedor.Controls.Add(Me.lbNumero)
        Me.gbDadosFornecedor.Controls.Add(Me.lbEndereco)
        Me.gbDadosFornecedor.Controls.Add(Me.txDenominacaoSocial)
        Me.gbDadosFornecedor.Controls.Add(Me.lbDenominacaoSocial)
        Me.gbDadosFornecedor.Enabled = False
        Me.gbDadosFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosFornecedor.Location = New System.Drawing.Point(33, 19)
        Me.gbDadosFornecedor.Name = "gbDadosFornecedor"
        Me.gbDadosFornecedor.Size = New System.Drawing.Size(787, 244)
        Me.gbDadosFornecedor.TabIndex = 49
        Me.gbDadosFornecedor.TabStop = False
        Me.gbDadosFornecedor.Text = "Dados do Fornecedor"
        '
        'LbUf
        '
        Me.LbUf.AutoSize = True
        Me.LbUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUf.Location = New System.Drawing.Point(219, 78)
        Me.LbUf.Name = "LbUf"
        Me.LbUf.Size = New System.Drawing.Size(35, 20)
        Me.LbUf.TabIndex = 46
        Me.LbUf.Text = "UF:"
        '
        'cbUf
        '
        Me.cbUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUf.FormattingEnabled = True
        Me.cbUf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbUf.Location = New System.Drawing.Point(223, 98)
        Me.cbUf.MaxLength = 2
        Me.cbUf.Name = "cbUf"
        Me.cbUf.Size = New System.Drawing.Size(46, 26)
        Me.cbUf.TabIndex = 5
        Me.cbUf.Text = "RO"
        '
        'cbCidade
        '
        Me.cbCidade.AutoCompleteCustomSource.AddRange(New String() {"Alta Floresta d'Oeste", "Alto Alegre do Parecis", "Alto Paraiso", "Alvorada d'Oeste", "Ariquemes", "Buritis", "Cabixi", "Cacaulandia", "Cacoal", "Campo Novo de Rondonia", "Candeias do Jamari", "Castanheiras", "Cerejeiras", "Chupinguaia", "Colorado do Oeste", "Corumbiara", "Costa Marques", "Cujubim", "Espigao d'Oeste", "Governador Jorge Teixeira", "Guajara-Mirim", "Jamari", "Jaru", "Ji-Parana", "Machadinho d'Oeste", "Ministro Andreazza", "Mirante da Serra", "Monte Negro", "Nova Brasilandia d'Oeste", "Nova Mamore", "Nova Uniao", "Novo Horizonte do Oeste", "Ouro Preto do Oeste", "Parecis", "Pimenta Bueno", "Pimenteiras do Oeste", "Porto Velho", "Presidente Medici", "Primavera de Rondonia", "Rio Crespo", "Rolim de Moura", "Santa Luzia d'Oeste", "Sao Felipe d'Oeste", "Sao Francisco do Guapore", "Sao Miguel do Guapore", "Seringueiras", "Teixeiropolis", "Theobroma", "Urupa", "Vale do Anari", "Vale do Paraiso", "Vilhena"})
        Me.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Location = New System.Drawing.Point(23, 98)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(186, 26)
        Me.cbCidade.TabIndex = 4
        '
        'txCelular2
        '
        Me.txCelular2.Location = New System.Drawing.Point(636, 154)
        Me.txCelular2.Mask = "00 00000-0000"
        Me.txCelular2.Name = "txCelular2"
        Me.txCelular2.Size = New System.Drawing.Size(128, 26)
        Me.txCelular2.TabIndex = 10
        '
        'lbCelular2
        '
        Me.lbCelular2.AutoSize = True
        Me.lbCelular2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular2.Location = New System.Drawing.Point(632, 135)
        Me.lbCelular2.Name = "lbCelular2"
        Me.lbCelular2.Size = New System.Drawing.Size(75, 20)
        Me.lbCelular2.TabIndex = 42
        Me.lbCelular2.Text = "Celular 2:"
        '
        'txObs
        '
        Me.txObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txObs.Location = New System.Drawing.Point(23, 202)
        Me.txObs.MaxLength = 100
        Me.txObs.Name = "txObs"
        Me.txObs.Size = New System.Drawing.Size(742, 26)
        Me.txObs.TabIndex = 11
        '
        'lbObs
        '
        Me.lbObs.AutoSize = True
        Me.lbObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObs.Location = New System.Drawing.Point(19, 183)
        Me.lbObs.Name = "lbObs"
        Me.lbObs.Size = New System.Drawing.Size(42, 20)
        Me.lbObs.TabIndex = 40
        Me.lbObs.Text = "Obs:"
        '
        'txCelular1
        '
        Me.txCelular1.Location = New System.Drawing.Point(636, 97)
        Me.txCelular1.Mask = "00 00000-0000"
        Me.txCelular1.Name = "txCelular1"
        Me.txCelular1.Size = New System.Drawing.Size(128, 26)
        Me.txCelular1.TabIndex = 8
        '
        'txTelefone
        '
        Me.txTelefone.Location = New System.Drawing.Point(482, 98)
        Me.txTelefone.Mask = "00 0000-0000"
        Me.txTelefone.Name = "txTelefone"
        Me.txTelefone.Size = New System.Drawing.Size(116, 26)
        Me.txTelefone.TabIndex = 7
        '
        'lbCelular1
        '
        Me.lbCelular1.AutoSize = True
        Me.lbCelular1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular1.Location = New System.Drawing.Point(632, 78)
        Me.lbCelular1.Name = "lbCelular1"
        Me.lbCelular1.Size = New System.Drawing.Size(75, 20)
        Me.lbCelular1.TabIndex = 37
        Me.lbCelular1.Text = "Celular 1:"
        '
        'txCnpj
        '
        Me.txCnpj.Location = New System.Drawing.Point(305, 98)
        Me.txCnpj.Mask = "00,000,000/0000-00"
        Me.txCnpj.Name = "txCnpj"
        Me.txCnpj.Size = New System.Drawing.Size(159, 26)
        Me.txCnpj.TabIndex = 6
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefone.Location = New System.Drawing.Point(478, 78)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(75, 20)
        Me.lbTelefone.TabIndex = 36
        Me.lbTelefone.Text = "Telefone:"
        '
        'lbCnpj
        '
        Me.lbCnpj.AutoSize = True
        Me.lbCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCnpj.Location = New System.Drawing.Point(301, 78)
        Me.lbCnpj.Name = "lbCnpj"
        Me.lbCnpj.Size = New System.Drawing.Size(53, 20)
        Me.lbCnpj.TabIndex = 34
        Me.lbCnpj.Text = "CNPJ:"
        '
        'lbCidade
        '
        Me.lbCidade.AutoSize = True
        Me.lbCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCidade.Location = New System.Drawing.Point(19, 78)
        Me.lbCidade.Name = "lbCidade"
        Me.lbCidade.Size = New System.Drawing.Size(63, 20)
        Me.lbCidade.TabIndex = 33
        Me.lbCidade.Text = "Cidade:"
        '
        'txEmail
        '
        Me.txEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEmail.Location = New System.Drawing.Point(23, 154)
        Me.txEmail.MaxLength = 100
        Me.txEmail.Name = "txEmail"
        Me.txEmail.Size = New System.Drawing.Size(575, 26)
        Me.txEmail.TabIndex = 9
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(19, 135)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(52, 20)
        Me.lbEmail.TabIndex = 31
        Me.lbEmail.Text = "Email:"
        '
        'txEndereco
        '
        Me.txEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEndereco.Location = New System.Drawing.Point(305, 49)
        Me.txEndereco.MaxLength = 60
        Me.txEndereco.Name = "txEndereco"
        Me.txEndereco.Size = New System.Drawing.Size(293, 26)
        Me.txEndereco.TabIndex = 2
        '
        'txNumero
        '
        Me.txNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNumero.Location = New System.Drawing.Point(636, 49)
        Me.txNumero.MaxLength = 8
        Me.txNumero.Name = "txNumero"
        Me.txNumero.Size = New System.Drawing.Size(129, 26)
        Me.txNumero.TabIndex = 3
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumero.Location = New System.Drawing.Point(633, 28)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(30, 20)
        Me.lbNumero.TabIndex = 26
        Me.lbNumero.Text = "Nº:"
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEndereco.Location = New System.Drawing.Point(301, 28)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(82, 20)
        Me.lbEndereco.TabIndex = 28
        Me.lbEndereco.Text = "Endereço:"
        '
        'txDenominacaoSocial
        '
        Me.txDenominacaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDenominacaoSocial.Location = New System.Drawing.Point(23, 49)
        Me.txDenominacaoSocial.MaxLength = 50
        Me.txDenominacaoSocial.Name = "txDenominacaoSocial"
        Me.txDenominacaoSocial.Size = New System.Drawing.Size(246, 26)
        Me.txDenominacaoSocial.TabIndex = 1
        '
        'lbDenominacaoSocial
        '
        Me.lbDenominacaoSocial.AutoSize = True
        Me.lbDenominacaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDenominacaoSocial.Location = New System.Drawing.Point(16, 26)
        Me.lbDenominacaoSocial.Name = "lbDenominacaoSocial"
        Me.lbDenominacaoSocial.Size = New System.Drawing.Size(159, 20)
        Me.lbDenominacaoSocial.TabIndex = 8
        Me.lbDenominacaoSocial.Text = "Denominação Social:"
        '
        'rbCidade
        '
        Me.rbCidade.AutoSize = True
        Me.rbCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCidade.Location = New System.Drawing.Point(260, 56)
        Me.rbCidade.Name = "rbCidade"
        Me.rbCidade.Size = New System.Drawing.Size(77, 24)
        Me.rbCidade.TabIndex = 15
        Me.rbCidade.TabStop = True
        Me.rbCidade.Text = "Cidade"
        Me.rbCidade.UseVisualStyleBackColor = True
        '
        'rbCnpj
        '
        Me.rbCnpj.AutoSize = True
        Me.rbCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCnpj.Location = New System.Drawing.Point(60, 58)
        Me.rbCnpj.Name = "rbCnpj"
        Me.rbCnpj.Size = New System.Drawing.Size(67, 24)
        Me.rbCnpj.TabIndex = 14
        Me.rbCnpj.TabStop = True
        Me.rbCnpj.Text = "CNPJ"
        Me.rbCnpj.UseVisualStyleBackColor = True
        '
        'btRemover
        '
        Me.btRemover.BackgroundImage = CType(resources.GetObject("btRemover.BackgroundImage"), System.Drawing.Image)
        Me.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRemover.Location = New System.Drawing.Point(809, 578)
        Me.btRemover.Name = "btRemover"
        Me.btRemover.Size = New System.Drawing.Size(88, 90)
        Me.btRemover.TabIndex = 25
        Me.btRemover.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.BackgroundImage = CType(resources.GetObject("btEditar.BackgroundImage"), System.Drawing.Image)
        Me.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEditar.Location = New System.Drawing.Point(692, 578)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(88, 90)
        Me.btEditar.TabIndex = 24
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'rbDenominacaoSocial
        '
        Me.rbDenominacaoSocial.AutoSize = True
        Me.rbDenominacaoSocial.Checked = True
        Me.rbDenominacaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDenominacaoSocial.Location = New System.Drawing.Point(60, 34)
        Me.rbDenominacaoSocial.Name = "rbDenominacaoSocial"
        Me.rbDenominacaoSocial.Size = New System.Drawing.Size(173, 24)
        Me.rbDenominacaoSocial.TabIndex = 12
        Me.rbDenominacaoSocial.TabStop = True
        Me.rbDenominacaoSocial.Text = "Denominação Social"
        Me.rbDenominacaoSocial.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.BackgroundImage = CType(resources.GetObject("btNovo.BackgroundImage"), System.Drawing.Image)
        Me.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNovo.Location = New System.Drawing.Point(447, 578)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(88, 90)
        Me.btNovo.TabIndex = 22
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'gbBuscarPor
        '
        Me.gbBuscarPor.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscarPor.Controls.Add(Me.lbE)
        Me.gbBuscarPor.Controls.Add(Me.lbEntre)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData1)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData2)
        Me.gbBuscarPor.Controls.Add(Me.txBuscarCnpj)
        Me.gbBuscarPor.Controls.Add(Me.txBuscar)
        Me.gbBuscarPor.Controls.Add(Me.lbBuscar)
        Me.gbBuscarPor.Controls.Add(Me.rbDataCadastro)
        Me.gbBuscarPor.Controls.Add(Me.rbDenominacaoSocial)
        Me.gbBuscarPor.Controls.Add(Me.rbCidade)
        Me.gbBuscarPor.Controls.Add(Me.rbCnpj)
        Me.gbBuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscarPor.Location = New System.Drawing.Point(864, 19)
        Me.gbBuscarPor.Name = "gbBuscarPor"
        Me.gbBuscarPor.Size = New System.Drawing.Size(451, 244)
        Me.gbBuscarPor.TabIndex = 51
        Me.gbBuscarPor.TabStop = False
        Me.gbBuscarPor.Text = "Buscar Por:"
        '
        'lbE
        '
        Me.lbE.AutoSize = True
        Me.lbE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbE.Location = New System.Drawing.Point(240, 167)
        Me.lbE.Name = "lbE"
        Me.lbE.Size = New System.Drawing.Size(18, 20)
        Me.lbE.TabIndex = 43
        Me.lbE.Text = "e"
        Me.lbE.Visible = False
        '
        'lbEntre
        '
        Me.lbEntre.AutoSize = True
        Me.lbEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntre.Location = New System.Drawing.Point(36, 163)
        Me.lbEntre.Name = "lbEntre"
        Me.lbEntre.Size = New System.Drawing.Size(52, 20)
        Me.lbEntre.TabIndex = 42
        Me.lbEntre.Text = "Entre:"
        Me.lbEntre.Visible = False
        '
        'dtBuscarData1
        '
        Me.dtBuscarData1.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData1.Enabled = False
        Me.dtBuscarData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData1.Location = New System.Drawing.Point(89, 162)
        Me.dtBuscarData1.Name = "dtBuscarData1"
        Me.dtBuscarData1.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData1.TabIndex = 18
        Me.dtBuscarData1.TabStop = False
        Me.dtBuscarData1.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        Me.dtBuscarData1.Visible = False
        '
        'dtBuscarData2
        '
        Me.dtBuscarData2.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData2.Enabled = False
        Me.dtBuscarData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData2.Location = New System.Drawing.Point(282, 162)
        Me.dtBuscarData2.Name = "dtBuscarData2"
        Me.dtBuscarData2.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData2.TabIndex = 19
        Me.dtBuscarData2.TabStop = False
        Me.dtBuscarData2.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        '
        'txBuscarCnpj
        '
        Me.txBuscarCnpj.Enabled = False
        Me.txBuscarCnpj.Location = New System.Drawing.Point(83, 124)
        Me.txBuscarCnpj.Mask = "00,000,000/0000-00"
        Me.txBuscarCnpj.Name = "txBuscarCnpj"
        Me.txBuscarCnpj.Size = New System.Drawing.Size(200, 26)
        Me.txBuscarCnpj.TabIndex = 17
        Me.txBuscarCnpj.Visible = False
        '
        'txBuscar
        '
        Me.txBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBuscar.Location = New System.Drawing.Point(88, 124)
        Me.txBuscar.Name = "txBuscar"
        Me.txBuscar.Size = New System.Drawing.Size(200, 26)
        Me.txBuscar.TabIndex = 16
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(19, 127)
        Me.lbBuscar.Name = "lbBuscar"
        Me.lbBuscar.Size = New System.Drawing.Size(63, 20)
        Me.lbBuscar.TabIndex = 21
        Me.lbBuscar.Text = "Buscar:"
        '
        'rbDataCadastro
        '
        Me.rbDataCadastro.AutoSize = True
        Me.rbDataCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataCadastro.Location = New System.Drawing.Point(260, 31)
        Me.rbDataCadastro.Name = "rbDataCadastro"
        Me.rbDataCadastro.Size = New System.Drawing.Size(153, 24)
        Me.rbDataCadastro.TabIndex = 13
        Me.rbDataCadastro.TabStop = True
        Me.rbDataCadastro.Text = "Data de Cadastro"
        Me.rbDataCadastro.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = CType(resources.GetObject("btSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalvar.Location = New System.Drawing.Point(570, 578)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(88, 90)
        Me.btSalvar.TabIndex = 23
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'lbN
        '
        Me.lbN.AutoSize = True
        Me.lbN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbN.Location = New System.Drawing.Point(175, 277)
        Me.lbN.Name = "lbN"
        Me.lbN.Size = New System.Drawing.Size(16, 17)
        Me.lbN.TabIndex = 78
        Me.lbN.Text = "0"
        '
        'lbNumRegistros
        '
        Me.lbNumRegistros.AutoSize = True
        Me.lbNumRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumRegistros.Location = New System.Drawing.Point(30, 276)
        Me.lbNumRegistros.Name = "lbNumRegistros"
        Me.lbNumRegistros.Size = New System.Drawing.Size(150, 17)
        Me.lbNumRegistros.TabIndex = 77
        Me.lbNumRegistros.Text = "Numero de Registros: "
        '
        'btHome
        '
        Me.btHome.BackgroundImage = CType(resources.GetObject("btHome.BackgroundImage"), System.Drawing.Image)
        Me.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btHome.Location = New System.Drawing.Point(33, 578)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(90, 90)
        Me.btHome.TabIndex = 79
        Me.btHome.UseVisualStyleBackColor = True
        '
        'Frm_CadFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.lbN)
        Me.Controls.Add(Me.lbNumRegistros)
        Me.Controls.Add(Me.dgFornecedor)
        Me.Controls.Add(Me.txIdFornecedor)
        Me.Controls.Add(Me.btVerTodos)
        Me.Controls.Add(Me.gbDadosFornecedor)
        Me.Controls.Add(Me.btRemover)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.gbBuscarPor)
        Me.Controls.Add(Me.btSalvar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Fornecedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDadosFornecedor.ResumeLayout(False)
        Me.gbDadosFornecedor.PerformLayout()
        Me.gbBuscarPor.ResumeLayout(False)
        Me.gbBuscarPor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txIdFornecedor As TextBox
    Friend WithEvents btVerTodos As Button
    Friend WithEvents gbDadosFornecedor As GroupBox
    Friend WithEvents txDenominacaoSocial As TextBox
    Friend WithEvents lbDenominacaoSocial As Label
    Friend WithEvents rbCidade As RadioButton
    Friend WithEvents rbCnpj As RadioButton
    Friend WithEvents btRemover As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents rbDenominacaoSocial As RadioButton
    Friend WithEvents btNovo As Button
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents txBuscar As TextBox
    Friend WithEvents lbBuscar As Label
    Friend WithEvents rbDataCadastro As RadioButton
    Friend WithEvents btSalvar As Button
    Friend WithEvents txEndereco As TextBox
    Friend WithEvents txNumero As TextBox
    Friend WithEvents lbNumero As Label
    Friend WithEvents lbEndereco As Label
    Friend WithEvents lbCidade As Label
    Friend WithEvents txEmail As TextBox
    Friend WithEvents lbEmail As Label
    Friend WithEvents txCelular1 As MaskedTextBox
    Friend WithEvents txTelefone As MaskedTextBox
    Friend WithEvents lbCelular1 As Label
    Friend WithEvents txCnpj As MaskedTextBox
    Friend WithEvents lbTelefone As Label
    Friend WithEvents lbCnpj As Label
    Friend WithEvents txObs As TextBox
    Friend WithEvents lbObs As Label
    Friend WithEvents txCelular2 As MaskedTextBox
    Friend WithEvents lbCelular2 As Label
    Friend WithEvents txBuscarCnpj As MaskedTextBox
    Friend WithEvents cbCidade As ComboBox
    Friend WithEvents cbUf As ComboBox
    Friend WithEvents LbUf As Label
    Friend WithEvents dgFornecedor As DataGridView
    Friend WithEvents lbE As Label
    Friend WithEvents lbEntre As Label
    Friend WithEvents dtBuscarData1 As DateTimePicker
    Friend WithEvents dtBuscarData2 As DateTimePicker
    Friend WithEvents lbN As Label
    Friend WithEvents lbNumRegistros As Label
    Friend WithEvents btHome As Button
End Class
