<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Promissorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Promissorias))
        Me.dtDataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.dtDataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.txValor = New System.Windows.Forms.TextBox()
        Me.lbValor = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lbJuros = New System.Windows.Forms.Label()
        Me.lbDataEmissao = New System.Windows.Forms.Label()
        Me.gbDadosPromissoria = New System.Windows.Forms.GroupBox()
        Me.btBuscarCliente = New System.Windows.Forms.Button()
        Me.txJuros = New System.Windows.Forms.TextBox()
        Me.lbDataVencimento = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.txCliente = New System.Windows.Forms.TextBox()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.btVerTodos = New System.Windows.Forms.Button()
        Me.lbEntre = New System.Windows.Forms.Label()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.dtBuscarData1 = New System.Windows.Forms.DateTimePicker()
        Me.rbStatus = New System.Windows.Forms.RadioButton()
        Me.btRemover = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.dgPromissoria = New System.Windows.Forms.DataGridView()
        Me.txId = New System.Windows.Forms.TextBox()
        Me.gbBuscarPor = New System.Windows.Forms.GroupBox()
        Me.cbBuscarStatus = New System.Windows.Forms.ComboBox()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.txBuscarTxt = New System.Windows.Forms.TextBox()
        Me.rbDataEmissao = New System.Windows.Forms.RadioButton()
        Me.lbE = New System.Windows.Forms.Label()
        Me.dtBuscarData2 = New System.Windows.Forms.DateTimePicker()
        Me.txIdCliente = New System.Windows.Forms.TextBox()
        Me.lbN = New System.Windows.Forms.Label()
        Me.lbNumRegistros = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.Button()
        Me.gbDadosPromissoria.SuspendLayout()
        CType(Me.dgPromissoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtDataVencimento
        '
        Me.dtDataVencimento.CustomFormat = "dd/MM/yyyy"
        Me.dtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataVencimento.Location = New System.Drawing.Point(203, 112)
        Me.dtDataVencimento.Name = "dtDataVencimento"
        Me.dtDataVencimento.Size = New System.Drawing.Size(130, 26)
        Me.dtDataVencimento.TabIndex = 4
        Me.dtDataVencimento.Value = New Date(2019, 8, 8, 0, 0, 0, 0)
        '
        'dtDataEmissao
        '
        Me.dtDataEmissao.CustomFormat = "dd/MM/yyyy"
        Me.dtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataEmissao.Location = New System.Drawing.Point(20, 112)
        Me.dtDataEmissao.Name = "dtDataEmissao"
        Me.dtDataEmissao.Size = New System.Drawing.Size(134, 26)
        Me.dtDataEmissao.TabIndex = 3
        Me.dtDataEmissao.Value = New Date(2019, 8, 8, 0, 0, 0, 0)
        '
        'txValor
        '
        Me.txValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txValor.Location = New System.Drawing.Point(389, 52)
        Me.txValor.MaxLength = 10
        Me.txValor.Name = "txValor"
        Me.txValor.Size = New System.Drawing.Size(91, 26)
        Me.txValor.TabIndex = 0
        '
        'lbValor
        '
        Me.lbValor.AutoSize = True
        Me.lbValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValor.Location = New System.Drawing.Point(385, 33)
        Me.lbValor.Name = "lbValor"
        Me.lbValor.Size = New System.Drawing.Size(50, 20)
        Me.lbValor.TabIndex = 28
        Me.lbValor.Text = "Valor:"
        '
        'cbStatus
        '
        Me.cbStatus.AutoCompleteCustomSource.AddRange(New String() {"Pago", "Pendente"})
        Me.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Pago", "Pendente"})
        Me.cbStatus.Location = New System.Drawing.Point(638, 52)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 26)
        Me.cbStatus.TabIndex = 2
        '
        'lbJuros
        '
        Me.lbJuros.AutoSize = True
        Me.lbJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJuros.Location = New System.Drawing.Point(514, 33)
        Me.lbJuros.Name = "lbJuros"
        Me.lbJuros.Size = New System.Drawing.Size(76, 20)
        Me.lbJuros.TabIndex = 17
        Me.lbJuros.Text = "Juros(%):"
        '
        'lbDataEmissao
        '
        Me.lbDataEmissao.AutoSize = True
        Me.lbDataEmissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataEmissao.Location = New System.Drawing.Point(16, 91)
        Me.lbDataEmissao.Name = "lbDataEmissao"
        Me.lbDataEmissao.Size = New System.Drawing.Size(133, 20)
        Me.lbDataEmissao.TabIndex = 19
        Me.lbDataEmissao.Text = "Data de emissão:"
        '
        'gbDadosPromissoria
        '
        Me.gbDadosPromissoria.BackColor = System.Drawing.Color.Transparent
        Me.gbDadosPromissoria.Controls.Add(Me.btBuscarCliente)
        Me.gbDadosPromissoria.Controls.Add(Me.dtDataVencimento)
        Me.gbDadosPromissoria.Controls.Add(Me.dtDataEmissao)
        Me.gbDadosPromissoria.Controls.Add(Me.txValor)
        Me.gbDadosPromissoria.Controls.Add(Me.lbValor)
        Me.gbDadosPromissoria.Controls.Add(Me.cbStatus)
        Me.gbDadosPromissoria.Controls.Add(Me.txJuros)
        Me.gbDadosPromissoria.Controls.Add(Me.lbDataVencimento)
        Me.gbDadosPromissoria.Controls.Add(Me.lbStatus)
        Me.gbDadosPromissoria.Controls.Add(Me.txCliente)
        Me.gbDadosPromissoria.Controls.Add(Me.lbCliente)
        Me.gbDadosPromissoria.Controls.Add(Me.lbJuros)
        Me.gbDadosPromissoria.Controls.Add(Me.lbDataEmissao)
        Me.gbDadosPromissoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosPromissoria.Location = New System.Drawing.Point(26, 27)
        Me.gbDadosPromissoria.Name = "gbDadosPromissoria"
        Me.gbDadosPromissoria.Size = New System.Drawing.Size(793, 175)
        Me.gbDadosPromissoria.TabIndex = 58
        Me.gbDadosPromissoria.TabStop = False
        Me.gbDadosPromissoria.Text = "Dados da Promissória"
        '
        'btBuscarCliente
        '
        Me.btBuscarCliente.BackColor = System.Drawing.Color.White
        Me.btBuscarCliente.BackgroundImage = CType(resources.GetObject("btBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btBuscarCliente.Location = New System.Drawing.Point(307, 51)
        Me.btBuscarCliente.Name = "btBuscarCliente"
        Me.btBuscarCliente.Size = New System.Drawing.Size(26, 26)
        Me.btBuscarCliente.TabIndex = 35
        Me.btBuscarCliente.UseVisualStyleBackColor = False
        '
        'txJuros
        '
        Me.txJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txJuros.Location = New System.Drawing.Point(518, 52)
        Me.txJuros.MaxLength = 7
        Me.txJuros.Name = "txJuros"
        Me.txJuros.Size = New System.Drawing.Size(90, 26)
        Me.txJuros.TabIndex = 1
        Me.txJuros.Text = "0"
        '
        'lbDataVencimento
        '
        Me.lbDataVencimento.AutoSize = True
        Me.lbDataVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataVencimento.Location = New System.Drawing.Point(199, 91)
        Me.lbDataVencimento.Name = "lbDataVencimento"
        Me.lbDataVencimento.Size = New System.Drawing.Size(159, 20)
        Me.lbDataVencimento.TabIndex = 23
        Me.lbDataVencimento.Text = "Data de Vencimento:"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(634, 33)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(60, 20)
        Me.lbStatus.TabIndex = 26
        Me.lbStatus.Text = "Status:"
        '
        'txCliente
        '
        Me.txCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCliente.Location = New System.Drawing.Point(20, 52)
        Me.txCliente.MaxLength = 50
        Me.txCliente.Name = "txCliente"
        Me.txCliente.ReadOnly = True
        Me.txCliente.Size = New System.Drawing.Size(281, 26)
        Me.txCliente.TabIndex = 9
        Me.txCliente.TabStop = False
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(16, 33)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(62, 20)
        Me.lbCliente.TabIndex = 8
        Me.lbCliente.Text = "Cliente:"
        '
        'btVerTodos
        '
        Me.btVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btVerTodos.Image = CType(resources.GetObject("btVerTodos.Image"), System.Drawing.Image)
        Me.btVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerTodos.Location = New System.Drawing.Point(1172, 219)
        Me.btVerTodos.Name = "btVerTodos"
        Me.btVerTodos.Size = New System.Drawing.Size(138, 25)
        Me.btVerTodos.TabIndex = 12
        Me.btVerTodos.Text = "Ver todos"
        Me.btVerTodos.UseVisualStyleBackColor = True
        '
        'lbEntre
        '
        Me.lbEntre.AutoSize = True
        Me.lbEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntre.Location = New System.Drawing.Point(54, 121)
        Me.lbEntre.Name = "lbEntre"
        Me.lbEntre.Size = New System.Drawing.Size(52, 20)
        Me.lbEntre.TabIndex = 34
        Me.lbEntre.Text = "Entre:"
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Checked = True
        Me.rbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.Location = New System.Drawing.Point(44, 33)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(76, 24)
        Me.rbCliente.TabIndex = 5
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'dtBuscarData1
        '
        Me.dtBuscarData1.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData1.Location = New System.Drawing.Point(112, 120)
        Me.dtBuscarData1.Name = "dtBuscarData1"
        Me.dtBuscarData1.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData1.TabIndex = 10
        '
        'rbStatus
        '
        Me.rbStatus.AutoSize = True
        Me.rbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStatus.Location = New System.Drawing.Point(160, 33)
        Me.rbStatus.Name = "rbStatus"
        Me.rbStatus.Size = New System.Drawing.Size(74, 24)
        Me.rbStatus.TabIndex = 6
        Me.rbStatus.Text = "Status"
        Me.rbStatus.UseVisualStyleBackColor = True
        '
        'btRemover
        '
        Me.btRemover.BackgroundImage = CType(resources.GetObject("btRemover.BackgroundImage"), System.Drawing.Image)
        Me.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRemover.Location = New System.Drawing.Point(802, 562)
        Me.btRemover.Name = "btRemover"
        Me.btRemover.Size = New System.Drawing.Size(90, 90)
        Me.btRemover.TabIndex = 17
        Me.btRemover.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.BackgroundImage = CType(resources.GetObject("btEditar.BackgroundImage"), System.Drawing.Image)
        Me.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEditar.Location = New System.Drawing.Point(685, 562)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(90, 90)
        Me.btEditar.TabIndex = 16
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = CType(resources.GetObject("btSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalvar.Location = New System.Drawing.Point(563, 562)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 90)
        Me.btSalvar.TabIndex = 15
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.BackgroundImage = CType(resources.GetObject("btNovo.BackgroundImage"), System.Drawing.Image)
        Me.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNovo.Location = New System.Drawing.Point(440, 562)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 90)
        Me.btNovo.TabIndex = 14
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'dgPromissoria
        '
        Me.dgPromissoria.AllowUserToAddRows = False
        Me.dgPromissoria.AllowUserToDeleteRows = False
        Me.dgPromissoria.BackgroundColor = System.Drawing.Color.White
        Me.dgPromissoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPromissoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgPromissoria.Location = New System.Drawing.Point(26, 245)
        Me.dgPromissoria.Name = "dgPromissoria"
        Me.dgPromissoria.ReadOnly = True
        Me.dgPromissoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPromissoria.Size = New System.Drawing.Size(1284, 302)
        Me.dgPromissoria.StandardTab = True
        Me.dgPromissoria.TabIndex = 13
        Me.dgPromissoria.TabStop = False
        '
        'txId
        '
        Me.txId.Enabled = False
        Me.txId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txId.Location = New System.Drawing.Point(2, 4)
        Me.txId.Name = "txId"
        Me.txId.Size = New System.Drawing.Size(32, 23)
        Me.txId.TabIndex = 56
        Me.txId.TabStop = False
        Me.txId.Visible = False
        '
        'gbBuscarPor
        '
        Me.gbBuscarPor.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscarPor.Controls.Add(Me.cbBuscarStatus)
        Me.gbBuscarPor.Controls.Add(Me.lbBuscar)
        Me.gbBuscarPor.Controls.Add(Me.txBuscarTxt)
        Me.gbBuscarPor.Controls.Add(Me.rbDataEmissao)
        Me.gbBuscarPor.Controls.Add(Me.lbE)
        Me.gbBuscarPor.Controls.Add(Me.lbEntre)
        Me.gbBuscarPor.Controls.Add(Me.rbCliente)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData1)
        Me.gbBuscarPor.Controls.Add(Me.dtBuscarData2)
        Me.gbBuscarPor.Controls.Add(Me.rbStatus)
        Me.gbBuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscarPor.Location = New System.Drawing.Point(857, 27)
        Me.gbBuscarPor.Name = "gbBuscarPor"
        Me.gbBuscarPor.Size = New System.Drawing.Size(453, 175)
        Me.gbBuscarPor.TabIndex = 60
        Me.gbBuscarPor.TabStop = False
        Me.gbBuscarPor.Text = "Buscar Por:"
        '
        'cbBuscarStatus
        '
        Me.cbBuscarStatus.AutoCompleteCustomSource.AddRange(New String() {"Pago", "Pendente"})
        Me.cbBuscarStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBuscarStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBuscarStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarStatus.FormattingEnabled = True
        Me.cbBuscarStatus.Items.AddRange(New Object() {"Pago", "Pendente"})
        Me.cbBuscarStatus.Location = New System.Drawing.Point(108, 88)
        Me.cbBuscarStatus.Name = "cbBuscarStatus"
        Me.cbBuscarStatus.Size = New System.Drawing.Size(137, 26)
        Me.cbBuscarStatus.TabIndex = 9
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(8, 88)
        Me.lbBuscar.Name = "lbBuscar"
        Me.lbBuscar.Size = New System.Drawing.Size(98, 20)
        Me.lbBuscar.TabIndex = 38
        Me.lbBuscar.Text = "Vencimento:"
        '
        'txBuscarTxt
        '
        Me.txBuscarTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBuscarTxt.Location = New System.Drawing.Point(108, 88)
        Me.txBuscarTxt.MaxLength = 50
        Me.txBuscarTxt.Name = "txBuscarTxt"
        Me.txBuscarTxt.Size = New System.Drawing.Size(217, 26)
        Me.txBuscarTxt.TabIndex = 8
        '
        'rbDataEmissao
        '
        Me.rbDataEmissao.AutoSize = True
        Me.rbDataEmissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDataEmissao.Location = New System.Drawing.Point(274, 31)
        Me.rbDataEmissao.Name = "rbDataEmissao"
        Me.rbDataEmissao.Size = New System.Drawing.Size(147, 24)
        Me.rbDataEmissao.TabIndex = 7
        Me.rbDataEmissao.Text = "Data de emissão"
        Me.rbDataEmissao.UseVisualStyleBackColor = True
        '
        'lbE
        '
        Me.lbE.AutoSize = True
        Me.lbE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbE.Location = New System.Drawing.Point(263, 125)
        Me.lbE.Name = "lbE"
        Me.lbE.Size = New System.Drawing.Size(18, 20)
        Me.lbE.TabIndex = 35
        Me.lbE.Text = "e"
        '
        'dtBuscarData2
        '
        Me.dtBuscarData2.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData2.Location = New System.Drawing.Point(305, 120)
        Me.dtBuscarData2.Name = "dtBuscarData2"
        Me.dtBuscarData2.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData2.TabIndex = 11
        '
        'txIdCliente
        '
        Me.txIdCliente.Enabled = False
        Me.txIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txIdCliente.Location = New System.Drawing.Point(40, 4)
        Me.txIdCliente.Name = "txIdCliente"
        Me.txIdCliente.Size = New System.Drawing.Size(32, 23)
        Me.txIdCliente.TabIndex = 65
        Me.txIdCliente.TabStop = False
        Me.txIdCliente.Visible = False
        '
        'lbN
        '
        Me.lbN.AutoSize = True
        Me.lbN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbN.Location = New System.Drawing.Point(168, 228)
        Me.lbN.Name = "lbN"
        Me.lbN.Size = New System.Drawing.Size(16, 17)
        Me.lbN.TabIndex = 78
        Me.lbN.Text = "0"
        '
        'lbNumRegistros
        '
        Me.lbNumRegistros.AutoSize = True
        Me.lbNumRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumRegistros.Location = New System.Drawing.Point(23, 227)
        Me.lbNumRegistros.Name = "lbNumRegistros"
        Me.lbNumRegistros.Size = New System.Drawing.Size(150, 17)
        Me.lbNumRegistros.TabIndex = 77
        Me.lbNumRegistros.Text = "Numero de Registros: "
        '
        'btHome
        '
        Me.btHome.BackgroundImage = CType(resources.GetObject("btHome.BackgroundImage"), System.Drawing.Image)
        Me.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btHome.Location = New System.Drawing.Point(26, 562)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(90, 90)
        Me.btHome.TabIndex = 79
        Me.btHome.UseVisualStyleBackColor = True
        '
        'Frm_Promissorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 736)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.lbN)
        Me.Controls.Add(Me.lbNumRegistros)
        Me.Controls.Add(Me.txIdCliente)
        Me.Controls.Add(Me.gbDadosPromissoria)
        Me.Controls.Add(Me.btVerTodos)
        Me.Controls.Add(Me.btRemover)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.dgPromissoria)
        Me.Controls.Add(Me.txId)
        Me.Controls.Add(Me.gbBuscarPor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Promissorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promissórias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbDadosPromissoria.ResumeLayout(False)
        Me.gbDadosPromissoria.PerformLayout()
        CType(Me.dgPromissoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarPor.ResumeLayout(False)
        Me.gbBuscarPor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDataVencimento As DateTimePicker
    Friend WithEvents dtDataEmissao As DateTimePicker
    Friend WithEvents txValor As TextBox
    Friend WithEvents lbValor As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lbJuros As Label
    Friend WithEvents lbDataEmissao As Label
    Friend WithEvents gbDadosPromissoria As GroupBox
    Friend WithEvents txJuros As TextBox
    Friend WithEvents lbDataVencimento As Label
    Friend WithEvents lbStatus As Label
    Friend WithEvents txCliente As TextBox
    Friend WithEvents lbCliente As Label
    Friend WithEvents btVerTodos As Button
    Friend WithEvents lbEntre As Label
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents dtBuscarData1 As DateTimePicker
    Friend WithEvents rbStatus As RadioButton
    Friend WithEvents btRemover As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents dgPromissoria As DataGridView
    Friend WithEvents txId As TextBox
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents rbDataEmissao As RadioButton
    Friend WithEvents lbE As Label
    Friend WithEvents dtBuscarData2 As DateTimePicker
    Friend WithEvents cbBuscarStatus As ComboBox
    Friend WithEvents lbBuscar As Label
    Friend WithEvents txBuscarTxt As TextBox
    Friend WithEvents btBuscarCliente As Button
    Friend WithEvents txIdCliente As TextBox
    Friend WithEvents lbN As Label
    Friend WithEvents lbNumRegistros As Label
    Friend WithEvents btHome As Button
End Class
