<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CadCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadCliente))
        Me.dgCliente = New System.Windows.Forms.DataGridView()
        Me.txIdCliente = New System.Windows.Forms.TextBox()
        Me.txCelular1 = New System.Windows.Forms.MaskedTextBox()
        Me.lbCelular1 = New System.Windows.Forms.Label()
        Me.txDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.btVerTodos = New System.Windows.Forms.Button()
        Me.rbDataCadastro = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbCidade = New System.Windows.Forms.RadioButton()
        Me.rbCpf = New System.Windows.Forms.RadioButton()
        Me.lbDataNascimento = New System.Windows.Forms.Label()
        Me.gbDadosCliente = New System.Windows.Forms.GroupBox()
        Me.cbCidade = New System.Windows.Forms.ComboBox()
        Me.txCelular2 = New System.Windows.Forms.MaskedTextBox()
        Me.txTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txEndereco = New System.Windows.Forms.TextBox()
        Me.lbCelular2 = New System.Windows.Forms.Label()
        Me.txCpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbCidade = New System.Windows.Forms.Label()
        Me.txObs = New System.Windows.Forms.TextBox()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.lbObs = New System.Windows.Forms.Label()
        Me.txNome = New System.Windows.Forms.TextBox()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.txNumero = New System.Windows.Forms.TextBox()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.lbCpf = New System.Windows.Forms.Label()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.btRemover = New System.Windows.Forms.Button()
        Me.txBuscar = New System.Windows.Forms.TextBox()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.gbBuscarPor = New System.Windows.Forms.GroupBox()
        Me.lbE = New System.Windows.Forms.Label()
        Me.lbEntre = New System.Windows.Forms.Label()
        Me.dtBuscarData1 = New System.Windows.Forms.DateTimePicker()
        Me.dtBuscarData2 = New System.Windows.Forms.DateTimePicker()
        Me.txBuscarCpf = New System.Windows.Forms.MaskedTextBox()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.lbN = New System.Windows.Forms.Label()
        Me.lbNumRegistros = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.Button()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDadosCliente.SuspendLayout()
        Me.gbBuscarPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCliente
        '
        Me.dgCliente.AllowUserToAddRows = False
        Me.dgCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgCliente.Location = New System.Drawing.Point(35, 297)
        Me.dgCliente.MultiSelect = False
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.ReadOnly = True
        Me.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCliente.Size = New System.Drawing.Size(1284, 277)
        Me.dgCliente.TabIndex = 47
        '
        'txIdCliente
        '
        Me.txIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdCliente.Location = New System.Drawing.Point(5, 3)
        Me.txIdCliente.Name = "txIdCliente"
        Me.txIdCliente.Size = New System.Drawing.Size(32, 23)
        Me.txIdCliente.TabIndex = 46
        Me.txIdCliente.TabStop = False
        '
        'txCelular1
        '
        Me.txCelular1.Location = New System.Drawing.Point(464, 99)
        Me.txCelular1.Mask = "00 00000-0000"
        Me.txCelular1.Name = "txCelular1"
        Me.txCelular1.Size = New System.Drawing.Size(128, 26)
        Me.txCelular1.TabIndex = 6
        '
        'lbCelular1
        '
        Me.lbCelular1.AutoSize = True
        Me.lbCelular1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular1.Location = New System.Drawing.Point(459, 76)
        Me.lbCelular1.Name = "lbCelular1"
        Me.lbCelular1.Size = New System.Drawing.Size(75, 20)
        Me.lbCelular1.TabIndex = 36
        Me.lbCelular1.Text = "Celular 1:"
        '
        'txDataNascimento
        '
        Me.txDataNascimento.Location = New System.Drawing.Point(17, 99)
        Me.txDataNascimento.Mask = "00/00/0000"
        Me.txDataNascimento.Name = "txDataNascimento"
        Me.txDataNascimento.Size = New System.Drawing.Size(118, 26)
        Me.txDataNascimento.TabIndex = 5
        Me.txDataNascimento.ValidatingType = GetType(Date)
        '
        'btVerTodos
        '
        Me.btVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btVerTodos.Image = CType(resources.GetObject("btVerTodos.Image"), System.Drawing.Image)
        Me.btVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerTodos.Location = New System.Drawing.Point(1181, 272)
        Me.btVerTodos.Name = "btVerTodos"
        Me.btVerTodos.Size = New System.Drawing.Size(138, 25)
        Me.btVerTodos.TabIndex = 16
        Me.btVerTodos.Text = "Ver todos"
        Me.btVerTodos.UseVisualStyleBackColor = True
        '
        'rbDataCadastro
        '
        Me.rbDataCadastro.AutoSize = True
        Me.rbDataCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataCadastro.Location = New System.Drawing.Point(220, 36)
        Me.rbDataCadastro.Name = "rbDataCadastro"
        Me.rbDataCadastro.Size = New System.Drawing.Size(153, 24)
        Me.rbDataCadastro.TabIndex = 13
        Me.rbDataCadastro.TabStop = True
        Me.rbDataCadastro.Text = "Data de Cadastro"
        Me.rbDataCadastro.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Checked = True
        Me.rbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNome.Location = New System.Drawing.Point(85, 36)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(69, 24)
        Me.rbNome.TabIndex = 12
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCidade
        '
        Me.rbCidade.AutoSize = True
        Me.rbCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCidade.Location = New System.Drawing.Point(220, 61)
        Me.rbCidade.Name = "rbCidade"
        Me.rbCidade.Size = New System.Drawing.Size(77, 24)
        Me.rbCidade.TabIndex = 15
        Me.rbCidade.TabStop = True
        Me.rbCidade.Text = "Cidade"
        Me.rbCidade.UseVisualStyleBackColor = True
        '
        'rbCpf
        '
        Me.rbCpf.AutoSize = True
        Me.rbCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCpf.Location = New System.Drawing.Point(85, 60)
        Me.rbCpf.Name = "rbCpf"
        Me.rbCpf.Size = New System.Drawing.Size(58, 24)
        Me.rbCpf.TabIndex = 14
        Me.rbCpf.TabStop = True
        Me.rbCpf.Text = "CPF"
        Me.rbCpf.UseVisualStyleBackColor = True
        '
        'lbDataNascimento
        '
        Me.lbDataNascimento.AutoSize = True
        Me.lbDataNascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataNascimento.Location = New System.Drawing.Point(13, 78)
        Me.lbDataNascimento.Name = "lbDataNascimento"
        Me.lbDataNascimento.Size = New System.Drawing.Size(158, 20)
        Me.lbDataNascimento.TabIndex = 33
        Me.lbDataNascimento.Text = "Data de Nascimento:"
        '
        'gbDadosCliente
        '
        Me.gbDadosCliente.BackColor = System.Drawing.Color.Transparent
        Me.gbDadosCliente.Controls.Add(Me.cbCidade)
        Me.gbDadosCliente.Controls.Add(Me.txCelular1)
        Me.gbDadosCliente.Controls.Add(Me.lbCelular1)
        Me.gbDadosCliente.Controls.Add(Me.txDataNascimento)
        Me.gbDadosCliente.Controls.Add(Me.lbDataNascimento)
        Me.gbDadosCliente.Controls.Add(Me.txCelular2)
        Me.gbDadosCliente.Controls.Add(Me.txTelefone)
        Me.gbDadosCliente.Controls.Add(Me.txEndereco)
        Me.gbDadosCliente.Controls.Add(Me.lbCelular2)
        Me.gbDadosCliente.Controls.Add(Me.txCpf)
        Me.gbDadosCliente.Controls.Add(Me.lbCidade)
        Me.gbDadosCliente.Controls.Add(Me.txObs)
        Me.gbDadosCliente.Controls.Add(Me.lbTelefone)
        Me.gbDadosCliente.Controls.Add(Me.lbObs)
        Me.gbDadosCliente.Controls.Add(Me.txNome)
        Me.gbDadosCliente.Controls.Add(Me.lbNome)
        Me.gbDadosCliente.Controls.Add(Me.txNumero)
        Me.gbDadosCliente.Controls.Add(Me.lbNumero)
        Me.gbDadosCliente.Controls.Add(Me.lbEndereco)
        Me.gbDadosCliente.Controls.Add(Me.lbCpf)
        Me.gbDadosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosCliente.Location = New System.Drawing.Point(35, 23)
        Me.gbDadosCliente.Name = "gbDadosCliente"
        Me.gbDadosCliente.Size = New System.Drawing.Size(789, 241)
        Me.gbDadosCliente.TabIndex = 1
        Me.gbDadosCliente.TabStop = False
        Me.gbDadosCliente.Text = "Dados do Cliente"
        '
        'cbCidade
        '
        Me.cbCidade.AutoCompleteCustomSource.AddRange(New String() {"Alta Floresta d'Oeste", "Alto Alegre do Parecis", "Alto Paraiso", "Alvorada d'Oeste", "Ariquemes", "Buritis", "Cabixi", "Cacaulandia", "Cacoal", "Campo Novo de Rondonia", "Candeias do Jamari", "Castanheiras", "Cerejeiras", "Chupinguaia", "Colorado do Oeste", "Corumbiara", "Costa Marques", "Cujubim", "Espigao d'Oeste", "Governador Jorge Teixeira", "Guajara-Mirim", "Jamari", "Jaru", "Ji-Parana", "Machadinho d'Oeste", "Ministro Andreazza", "Mirante da Serra", "Monte Negro", "Nova Brasilandia d'Oeste", "Nova Mamore", "Nova Uniao", "Novo Horizonte do Oeste", "Ouro Preto do Oeste", "Parecis", "Pimenta Bueno", "Pimenteiras do Oeste", "Porto Velho", "Presidente Medici", "Primavera de Rondonia", "Rio Crespo", "Rolim de Moura", "Santa Luzia d'Oeste", "Sao Felipe d'Oeste", "Sao Francisco do Guapore", "Sao Miguel do Guapore", "Seringueiras", "Teixeiropolis", "Theobroma", "Urupa", "Vale do Anari", "Vale do Paraiso", "Vilhena"})
        Me.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Items.AddRange(New Object() {"Alta Floresta d'Oeste", "Alto Alegre do Parecis", "Alto Paraiso", "Alvorada d'Oeste", "Ariquemes", "Buritis", "Cabixi", "Cacaulandia", "Cacoal", "Campo Novo de Rondonia", "Candeias do Jamari", "Castanheiras", "Cerejeiras", "Chupinguaia", "Colorado do Oeste", "Corumbiara", "Costa Marques", "Cujubim", "Espigao d'Oeste", "Governador Jorge Teixeira", "Guajara-Mirim", "Jamari", "Jaru", "Ji-Parana", "Machadinho d'Oeste", "Ministro Andreazza", "Mirante da Serra", "Monte Negro", "Nova Brasilandia d'Oeste", "Nova Mamore", "Nova Uniao", "Novo Horizonte do Oeste", "Parecis", "Pimenta Bueno", "Pimenteiras do Oeste", "Porto Velho", "Presidente Medici", "Primavera de Rondonia", "Rio Crespo", "Rolim de Moura", "Santa Luzia d'Oeste", "Sao Felipe d'Oeste", "Sao Francisco do Guapore", "Sao Miguel do Guapore", "Seringueiras", "Teixeiropolis", "Theobroma", "Urupa", "Vale do Anari", "Vale do Paraiso", "Vilhena"})
        Me.cbCidade.Location = New System.Drawing.Point(17, 147)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(248, 26)
        Me.cbCidade.TabIndex = 8
        '
        'txCelular2
        '
        Me.txCelular2.Location = New System.Drawing.Point(631, 98)
        Me.txCelular2.Mask = "00 00000-0000"
        Me.txCelular2.Name = "txCelular2"
        Me.txCelular2.Size = New System.Drawing.Size(128, 26)
        Me.txCelular2.TabIndex = 7
        '
        'txTelefone
        '
        Me.txTelefone.Location = New System.Drawing.Point(630, 46)
        Me.txTelefone.Mask = "00 0000-0000"
        Me.txTelefone.Name = "txTelefone"
        Me.txTelefone.Size = New System.Drawing.Size(128, 26)
        Me.txTelefone.TabIndex = 4
        '
        'txEndereco
        '
        Me.txEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEndereco.Location = New System.Drawing.Point(299, 149)
        Me.txEndereco.MaxLength = 60
        Me.txEndereco.Name = "txEndereco"
        Me.txEndereco.Size = New System.Drawing.Size(293, 26)
        Me.txEndereco.TabIndex = 9
        '
        'lbCelular2
        '
        Me.lbCelular2.AutoSize = True
        Me.lbCelular2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular2.Location = New System.Drawing.Point(626, 75)
        Me.lbCelular2.Name = "lbCelular2"
        Me.lbCelular2.Size = New System.Drawing.Size(75, 20)
        Me.lbCelular2.TabIndex = 28
        Me.lbCelular2.Text = "Celular 2:"
        '
        'txCpf
        '
        Me.txCpf.Location = New System.Drawing.Point(464, 44)
        Me.txCpf.Mask = "999,999,999-99"
        Me.txCpf.Name = "txCpf"
        Me.txCpf.Size = New System.Drawing.Size(128, 26)
        Me.txCpf.TabIndex = 3
        '
        'lbCidade
        '
        Me.lbCidade.AutoSize = True
        Me.lbCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCidade.Location = New System.Drawing.Point(13, 128)
        Me.lbCidade.Name = "lbCidade"
        Me.lbCidade.Size = New System.Drawing.Size(63, 20)
        Me.lbCidade.TabIndex = 23
        Me.lbCidade.Text = "Cidade:"
        '
        'txObs
        '
        Me.txObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txObs.Location = New System.Drawing.Point(17, 199)
        Me.txObs.MaxLength = 100
        Me.txObs.Name = "txObs"
        Me.txObs.Size = New System.Drawing.Size(742, 26)
        Me.txObs.TabIndex = 22
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefone.Location = New System.Drawing.Point(626, 27)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(75, 20)
        Me.lbTelefone.TabIndex = 26
        Me.lbTelefone.Text = "Telefone:"
        '
        'lbObs
        '
        Me.lbObs.AutoSize = True
        Me.lbObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObs.Location = New System.Drawing.Point(13, 180)
        Me.lbObs.Name = "lbObs"
        Me.lbObs.Size = New System.Drawing.Size(42, 20)
        Me.lbObs.TabIndex = 21
        Me.lbObs.Text = "Obs:"
        '
        'txNome
        '
        Me.txNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNome.Location = New System.Drawing.Point(17, 44)
        Me.txNome.MaxLength = 60
        Me.txNome.Name = "txNome"
        Me.txNome.Size = New System.Drawing.Size(410, 26)
        Me.txNome.TabIndex = 2
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNome.Location = New System.Drawing.Point(13, 23)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(55, 20)
        Me.lbNome.TabIndex = 8
        Me.lbNome.Text = "Nome:"
        '
        'txNumero
        '
        Me.txNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNumero.Location = New System.Drawing.Point(630, 149)
        Me.txNumero.MaxLength = 8
        Me.txNumero.Name = "txNumero"
        Me.txNumero.Size = New System.Drawing.Size(129, 26)
        Me.txNumero.TabIndex = 10
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumero.Location = New System.Drawing.Point(627, 128)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(30, 20)
        Me.lbNumero.TabIndex = 2
        Me.lbNumero.Text = "Nº:"
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEndereco.Location = New System.Drawing.Point(295, 128)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(82, 20)
        Me.lbEndereco.TabIndex = 17
        Me.lbEndereco.Text = "Endereço:"
        '
        'lbCpf
        '
        Me.lbCpf.AutoSize = True
        Me.lbCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCpf.Location = New System.Drawing.Point(460, 25)
        Me.lbCpf.Name = "lbCpf"
        Me.lbCpf.Size = New System.Drawing.Size(44, 20)
        Me.lbCpf.TabIndex = 19
        Me.lbCpf.Text = "CPF:"
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(16, 124)
        Me.lbBuscar.Name = "lbBuscar"
        Me.lbBuscar.Size = New System.Drawing.Size(63, 20)
        Me.lbBuscar.TabIndex = 21
        Me.lbBuscar.Text = "Buscar:"
        '
        'btRemover
        '
        Me.btRemover.BackgroundImage = CType(resources.GetObject("btRemover.BackgroundImage"), System.Drawing.Image)
        Me.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRemover.Location = New System.Drawing.Point(811, 583)
        Me.btRemover.Name = "btRemover"
        Me.btRemover.Size = New System.Drawing.Size(90, 90)
        Me.btRemover.TabIndex = 20
        Me.btRemover.UseVisualStyleBackColor = True
        '
        'txBuscar
        '
        Me.txBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBuscar.Location = New System.Drawing.Point(85, 122)
        Me.txBuscar.Name = "txBuscar"
        Me.txBuscar.Size = New System.Drawing.Size(223, 26)
        Me.txBuscar.TabIndex = 21
        Me.txBuscar.TabStop = False
        '
        'btEditar
        '
        Me.btEditar.BackgroundImage = CType(resources.GetObject("btEditar.BackgroundImage"), System.Drawing.Image)
        Me.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEditar.Location = New System.Drawing.Point(694, 583)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(90, 90)
        Me.btEditar.TabIndex = 19
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.BackgroundImage = CType(resources.GetObject("btNovo.BackgroundImage"), System.Drawing.Image)
        Me.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNovo.Location = New System.Drawing.Point(449, 583)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 90)
        Me.btNovo.TabIndex = 17
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'gbBuscarPor
        '
        Me.gbBuscarPor.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscarPor.Controls.Add(Me.lbE)
        Me.gbBuscarPor.Controls.Add(Me.lbEntre)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData1)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData2)
        Me.gbBuscarPor.Controls.Add(Me.txBuscarCpf)
        Me.gbBuscarPor.Controls.Add(Me.txBuscar)
        Me.gbBuscarPor.Controls.Add(Me.lbBuscar)
        Me.gbBuscarPor.Controls.Add(Me.rbDataCadastro)
        Me.gbBuscarPor.Controls.Add(Me.rbNome)
        Me.gbBuscarPor.Controls.Add(Me.rbCidade)
        Me.gbBuscarPor.Controls.Add(Me.rbCpf)
        Me.gbBuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscarPor.Location = New System.Drawing.Point(866, 23)
        Me.gbBuscarPor.Name = "gbBuscarPor"
        Me.gbBuscarPor.Size = New System.Drawing.Size(453, 241)
        Me.gbBuscarPor.TabIndex = 11
        Me.gbBuscarPor.TabStop = False
        Me.gbBuscarPor.Text = "Buscar Por:"
        '
        'lbE
        '
        Me.lbE.AutoSize = True
        Me.lbE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbE.Location = New System.Drawing.Point(236, 154)
        Me.lbE.Name = "lbE"
        Me.lbE.Size = New System.Drawing.Size(18, 20)
        Me.lbE.TabIndex = 39
        Me.lbE.Text = "e"
        Me.lbE.Visible = False
        '
        'lbEntre
        '
        Me.lbEntre.AutoSize = True
        Me.lbEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntre.Location = New System.Drawing.Point(32, 150)
        Me.lbEntre.Name = "lbEntre"
        Me.lbEntre.Size = New System.Drawing.Size(52, 20)
        Me.lbEntre.TabIndex = 38
        Me.lbEntre.Text = "Entre:"
        Me.lbEntre.Visible = False
        '
        'dtBuscarData1
        '
        Me.dtBuscarData1.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData1.Enabled = False
        Me.dtBuscarData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData1.Location = New System.Drawing.Point(85, 149)
        Me.dtBuscarData1.Name = "dtBuscarData1"
        Me.dtBuscarData1.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData1.TabIndex = 37
        Me.dtBuscarData1.TabStop = False
        Me.dtBuscarData1.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        Me.dtBuscarData1.Visible = False
        '
        'dtBuscarData2
        '
        Me.dtBuscarData2.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData2.Enabled = False
        Me.dtBuscarData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData2.Location = New System.Drawing.Point(278, 149)
        Me.dtBuscarData2.Name = "dtBuscarData2"
        Me.dtBuscarData2.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData2.TabIndex = 36
        Me.dtBuscarData2.TabStop = False
        Me.dtBuscarData2.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        '
        'txBuscarCpf
        '
        Me.txBuscarCpf.Enabled = False
        Me.txBuscarCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBuscarCpf.Location = New System.Drawing.Point(85, 123)
        Me.txBuscarCpf.Mask = "999,999,999-99"
        Me.txBuscarCpf.Name = "txBuscarCpf"
        Me.txBuscarCpf.Size = New System.Drawing.Size(194, 24)
        Me.txBuscarCpf.TabIndex = 29
        Me.txBuscarCpf.TabStop = False
        Me.txBuscarCpf.Visible = False
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = CType(resources.GetObject("btSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalvar.Location = New System.Drawing.Point(572, 583)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 90)
        Me.btSalvar.TabIndex = 18
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'lbN
        '
        Me.lbN.AutoSize = True
        Me.lbN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbN.Location = New System.Drawing.Point(177, 278)
        Me.lbN.Name = "lbN"
        Me.lbN.Size = New System.Drawing.Size(16, 17)
        Me.lbN.TabIndex = 76
        Me.lbN.Text = "0"
        '
        'lbNumRegistros
        '
        Me.lbNumRegistros.AutoSize = True
        Me.lbNumRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumRegistros.Location = New System.Drawing.Point(32, 277)
        Me.lbNumRegistros.Name = "lbNumRegistros"
        Me.lbNumRegistros.Size = New System.Drawing.Size(150, 17)
        Me.lbNumRegistros.TabIndex = 75
        Me.lbNumRegistros.Text = "Numero de Registros: "
        '
        'btHome
        '
        Me.btHome.BackgroundImage = CType(resources.GetObject("btHome.BackgroundImage"), System.Drawing.Image)
        Me.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btHome.Location = New System.Drawing.Point(35, 583)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(90, 90)
        Me.btHome.TabIndex = 78
        Me.btHome.UseVisualStyleBackColor = True
        '
        'Frm_CadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.lbN)
        Me.Controls.Add(Me.lbNumRegistros)
        Me.Controls.Add(Me.dgCliente)
        Me.Controls.Add(Me.txIdCliente)
        Me.Controls.Add(Me.btVerTodos)
        Me.Controls.Add(Me.gbDadosCliente)
        Me.Controls.Add(Me.btRemover)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.gbBuscarPor)
        Me.Controls.Add(Me.btSalvar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDadosCliente.ResumeLayout(False)
        Me.gbDadosCliente.PerformLayout()
        Me.gbBuscarPor.ResumeLayout(False)
        Me.gbBuscarPor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgCliente As DataGridView
    Friend WithEvents txIdCliente As TextBox
    Friend WithEvents txCelular1 As MaskedTextBox
    Friend WithEvents lbCelular1 As Label
    Friend WithEvents txDataNascimento As MaskedTextBox
    Friend WithEvents btVerTodos As Button
    Friend WithEvents rbDataCadastro As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbCidade As RadioButton
    Friend WithEvents rbCpf As RadioButton
    Friend WithEvents lbDataNascimento As Label
    Friend WithEvents gbDadosCliente As GroupBox
    Friend WithEvents txCelular2 As MaskedTextBox
    Friend WithEvents txTelefone As MaskedTextBox
    Friend WithEvents txEndereco As TextBox
    Friend WithEvents lbCelular2 As Label
    Friend WithEvents txCpf As MaskedTextBox
    Friend WithEvents lbCidade As Label
    Friend WithEvents txObs As TextBox
    Friend WithEvents lbTelefone As Label
    Friend WithEvents lbObs As Label
    Friend WithEvents txNome As TextBox
    Friend WithEvents lbNome As Label
    Friend WithEvents txNumero As TextBox
    Friend WithEvents lbNumero As Label
    Friend WithEvents lbEndereco As Label
    Friend WithEvents lbCpf As Label
    Friend WithEvents lbBuscar As Label
    Friend WithEvents btRemover As Button
    Friend WithEvents txBuscar As TextBox
    Friend WithEvents btEditar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents txBuscarCpf As MaskedTextBox
    Friend WithEvents btSalvar As Button
    Friend WithEvents cbCidade As ComboBox
    Friend WithEvents lbE As Label
    Friend WithEvents lbEntre As Label
    Friend WithEvents dtBuscarData1 As DateTimePicker
    Friend WithEvents dtBuscarData2 As DateTimePicker
    Friend WithEvents lbN As Label
    Friend WithEvents lbNumRegistros As Label
    Friend WithEvents btHome As Button
End Class
