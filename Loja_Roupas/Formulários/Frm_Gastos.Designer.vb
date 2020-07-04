<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Gastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Gastos))
        Me.txJuros = New System.Windows.Forms.TextBox()
        Me.lbDataVencimento = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.dgGastos = New System.Windows.Forms.DataGridView()
        Me.txId = New System.Windows.Forms.TextBox()
        Me.txDescricao = New System.Windows.Forms.TextBox()
        Me.lbDescricao = New System.Windows.Forms.Label()
        Me.btRemover = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.lbVencimento = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.lbE = New System.Windows.Forms.Label()
        Me.lbEntre = New System.Windows.Forms.Label()
        Me.dtBuscarData1 = New System.Windows.Forms.DateTimePicker()
        Me.dtBuscarData2 = New System.Windows.Forms.DateTimePicker()
        Me.rbPago = New System.Windows.Forms.RadioButton()
        Me.lbBuscarStatus = New System.Windows.Forms.Label()
        Me.rbPendente = New System.Windows.Forms.RadioButton()
        Me.gbDadosConta = New System.Windows.Forms.GroupBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txCredor = New System.Windows.Forms.TextBox()
        Me.lbCredor = New System.Windows.Forms.Label()
        Me.dtDataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.dtDataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.txValor = New System.Windows.Forms.TextBox()
        Me.lbValor = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lbJuros = New System.Windows.Forms.Label()
        Me.lbDataEmissao = New System.Windows.Forms.Label()
        Me.btVerTodos = New System.Windows.Forms.Button()
        Me.lbN = New System.Windows.Forms.Label()
        Me.lbNumRegistros = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.Button()
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.gbDadosConta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txJuros
        '
        Me.txJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txJuros.Location = New System.Drawing.Point(518, 53)
        Me.txJuros.MaxLength = 7
        Me.txJuros.Name = "txJuros"
        Me.txJuros.Size = New System.Drawing.Size(90, 26)
        Me.txJuros.TabIndex = 3
        '
        'lbDataVencimento
        '
        Me.lbDataVencimento.AutoSize = True
        Me.lbDataVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataVencimento.Location = New System.Drawing.Point(199, 96)
        Me.lbDataVencimento.Name = "lbDataVencimento"
        Me.lbDataVencimento.Size = New System.Drawing.Size(159, 20)
        Me.lbDataVencimento.TabIndex = 23
        Me.lbDataVencimento.Text = "Data de Vencimento:"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(634, 34)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(60, 20)
        Me.lbStatus.TabIndex = 26
        Me.lbStatus.Text = "Status:"
        '
        'dgGastos
        '
        Me.dgGastos.AllowUserToAddRows = False
        Me.dgGastos.AllowUserToDeleteRows = False
        Me.dgGastos.AllowUserToOrderColumns = True
        Me.dgGastos.BackgroundColor = System.Drawing.Color.White
        Me.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgGastos.Location = New System.Drawing.Point(35, 245)
        Me.dgGastos.MultiSelect = False
        Me.dgGastos.Name = "dgGastos"
        Me.dgGastos.ReadOnly = True
        Me.dgGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGastos.Size = New System.Drawing.Size(1284, 320)
        Me.dgGastos.StandardTab = True
        Me.dgGastos.TabIndex = 15
        '
        'txId
        '
        Me.txId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txId.Location = New System.Drawing.Point(1, 1)
        Me.txId.Name = "txId"
        Me.txId.Size = New System.Drawing.Size(32, 23)
        Me.txId.TabIndex = 47
        Me.txId.Visible = False
        '
        'txDescricao
        '
        Me.txDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDescricao.Location = New System.Drawing.Point(20, 54)
        Me.txDescricao.MaxLength = 50
        Me.txDescricao.Name = "txDescricao"
        Me.txDescricao.Size = New System.Drawing.Size(313, 26)
        Me.txDescricao.TabIndex = 1
        '
        'lbDescricao
        '
        Me.lbDescricao.AutoSize = True
        Me.lbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescricao.Location = New System.Drawing.Point(16, 33)
        Me.lbDescricao.Name = "lbDescricao"
        Me.lbDescricao.Size = New System.Drawing.Size(84, 20)
        Me.lbDescricao.TabIndex = 8
        Me.lbDescricao.Text = "Descrição:"
        '
        'btRemover
        '
        Me.btRemover.BackgroundImage = CType(resources.GetObject("btRemover.BackgroundImage"), System.Drawing.Image)
        Me.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRemover.Location = New System.Drawing.Point(811, 582)
        Me.btRemover.Name = "btRemover"
        Me.btRemover.Size = New System.Drawing.Size(90, 90)
        Me.btRemover.TabIndex = 19
        Me.btRemover.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.BackgroundImage = CType(resources.GetObject("btEditar.BackgroundImage"), System.Drawing.Image)
        Me.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEditar.Location = New System.Drawing.Point(694, 582)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(90, 90)
        Me.btEditar.TabIndex = 18
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = CType(resources.GetObject("btSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalvar.Location = New System.Drawing.Point(572, 582)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 90)
        Me.btSalvar.TabIndex = 17
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.BackgroundImage = CType(resources.GetObject("btNovo.BackgroundImage"), System.Drawing.Image)
        Me.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNovo.Location = New System.Drawing.Point(449, 582)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 90)
        Me.btNovo.TabIndex = 16
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.lbVencimento)
        Me.gbBuscar.Controls.Add(Me.rbTodos)
        Me.gbBuscar.Controls.Add(Me.lbE)
        Me.gbBuscar.Controls.Add(Me.lbEntre)
        Me.gbBuscar.Controls.Add(Me.dtBuscarData1)
        Me.gbBuscar.Controls.Add(Me.dtBuscarData2)
        Me.gbBuscar.Controls.Add(Me.rbPago)
        Me.gbBuscar.Controls.Add(Me.lbBuscarStatus)
        Me.gbBuscar.Controls.Add(Me.rbPendente)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(866, 31)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(453, 175)
        Me.gbBuscar.TabIndex = 51
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscar:"
        '
        'lbVencimento
        '
        Me.lbVencimento.AutoSize = True
        Me.lbVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVencimento.Location = New System.Drawing.Point(10, 79)
        Me.lbVencimento.Name = "lbVencimento"
        Me.lbVencimento.Size = New System.Drawing.Size(98, 20)
        Me.lbVencimento.TabIndex = 53
        Me.lbVencimento.Text = "Vencimento:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(326, 35)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(71, 24)
        Me.rbTodos.TabIndex = 11
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'lbE
        '
        Me.lbE.AutoSize = True
        Me.lbE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbE.Location = New System.Drawing.Point(247, 113)
        Me.lbE.Name = "lbE"
        Me.lbE.Size = New System.Drawing.Size(18, 20)
        Me.lbE.TabIndex = 51
        Me.lbE.Text = "e"
        '
        'lbEntre
        '
        Me.lbEntre.AutoSize = True
        Me.lbEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntre.Location = New System.Drawing.Point(41, 108)
        Me.lbEntre.Name = "lbEntre"
        Me.lbEntre.Size = New System.Drawing.Size(52, 20)
        Me.lbEntre.TabIndex = 50
        Me.lbEntre.Text = "Entre:"
        '
        'dtBuscarData1
        '
        Me.dtBuscarData1.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBuscarData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData1.Location = New System.Drawing.Point(94, 107)
        Me.dtBuscarData1.Name = "dtBuscarData1"
        Me.dtBuscarData1.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData1.TabIndex = 12
        Me.dtBuscarData1.TabStop = False
        Me.dtBuscarData1.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        '
        'dtBuscarData2
        '
        Me.dtBuscarData2.CustomFormat = "dd/MM/yyyy"
        Me.dtBuscarData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBuscarData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBuscarData2.Location = New System.Drawing.Point(285, 108)
        Me.dtBuscarData2.Name = "dtBuscarData2"
        Me.dtBuscarData2.Size = New System.Drawing.Size(129, 26)
        Me.dtBuscarData2.TabIndex = 13
        Me.dtBuscarData2.TabStop = False
        Me.dtBuscarData2.Value = New Date(2019, 7, 27, 0, 0, 0, 0)
        '
        'rbPago
        '
        Me.rbPago.AutoSize = True
        Me.rbPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPago.Location = New System.Drawing.Point(121, 33)
        Me.rbPago.Name = "rbPago"
        Me.rbPago.Size = New System.Drawing.Size(64, 24)
        Me.rbPago.TabIndex = 9
        Me.rbPago.Text = "Pago"
        Me.rbPago.UseVisualStyleBackColor = True
        '
        'lbBuscarStatus
        '
        Me.lbBuscarStatus.AutoSize = True
        Me.lbBuscarStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscarStatus.Location = New System.Drawing.Point(48, 35)
        Me.lbBuscarStatus.Name = "lbBuscarStatus"
        Me.lbBuscarStatus.Size = New System.Drawing.Size(60, 20)
        Me.lbBuscarStatus.TabIndex = 29
        Me.lbBuscarStatus.Text = "Status:"
        '
        'rbPendente
        '
        Me.rbPendente.AutoSize = True
        Me.rbPendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendente.Location = New System.Drawing.Point(211, 35)
        Me.rbPendente.Name = "rbPendente"
        Me.rbPendente.Size = New System.Drawing.Size(96, 24)
        Me.rbPendente.TabIndex = 10
        Me.rbPendente.Text = "Pendente"
        Me.rbPendente.UseVisualStyleBackColor = True
        '
        'gbDadosConta
        '
        Me.gbDadosConta.BackColor = System.Drawing.Color.Transparent
        Me.gbDadosConta.Controls.Add(Me.btBuscar)
        Me.gbDadosConta.Controls.Add(Me.txCredor)
        Me.gbDadosConta.Controls.Add(Me.lbCredor)
        Me.gbDadosConta.Controls.Add(Me.dtDataVencimento)
        Me.gbDadosConta.Controls.Add(Me.dtDataEmissao)
        Me.gbDadosConta.Controls.Add(Me.txValor)
        Me.gbDadosConta.Controls.Add(Me.lbValor)
        Me.gbDadosConta.Controls.Add(Me.cbStatus)
        Me.gbDadosConta.Controls.Add(Me.txJuros)
        Me.gbDadosConta.Controls.Add(Me.lbDataVencimento)
        Me.gbDadosConta.Controls.Add(Me.lbStatus)
        Me.gbDadosConta.Controls.Add(Me.txDescricao)
        Me.gbDadosConta.Controls.Add(Me.lbDescricao)
        Me.gbDadosConta.Controls.Add(Me.lbJuros)
        Me.gbDadosConta.Controls.Add(Me.lbDataEmissao)
        Me.gbDadosConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosConta.Location = New System.Drawing.Point(35, 31)
        Me.gbDadosConta.Name = "gbDadosConta"
        Me.gbDadosConta.Size = New System.Drawing.Size(793, 175)
        Me.gbDadosConta.TabIndex = 49
        Me.gbDadosConta.TabStop = False
        Me.gbDadosConta.Text = "Dados da Conta"
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.White
        Me.btBuscar.BackgroundImage = CType(resources.GetObject("btBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.Location = New System.Drawing.Point(733, 119)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(26, 26)
        Me.btBuscar.TabIndex = 8
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'txCredor
        '
        Me.txCredor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCredor.Location = New System.Drawing.Point(389, 119)
        Me.txCredor.MaxLength = 60
        Me.txCredor.Name = "txCredor"
        Me.txCredor.Size = New System.Drawing.Size(338, 26)
        Me.txCredor.TabIndex = 7
        '
        'lbCredor
        '
        Me.lbCredor.AutoSize = True
        Me.lbCredor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCredor.Location = New System.Drawing.Point(385, 98)
        Me.lbCredor.Name = "lbCredor"
        Me.lbCredor.Size = New System.Drawing.Size(61, 20)
        Me.lbCredor.TabIndex = 32
        Me.lbCredor.Text = "Credor:"
        '
        'dtDataVencimento
        '
        Me.dtDataVencimento.CustomFormat = "dd/MM/yyyy"
        Me.dtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataVencimento.Location = New System.Drawing.Point(203, 117)
        Me.dtDataVencimento.Name = "dtDataVencimento"
        Me.dtDataVencimento.Size = New System.Drawing.Size(130, 26)
        Me.dtDataVencimento.TabIndex = 6
        Me.dtDataVencimento.Value = New Date(2019, 8, 5, 0, 0, 0, 0)
        '
        'dtDataEmissao
        '
        Me.dtDataEmissao.CustomFormat = "dd/MM/yyyy"
        Me.dtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDataEmissao.Location = New System.Drawing.Point(20, 117)
        Me.dtDataEmissao.Name = "dtDataEmissao"
        Me.dtDataEmissao.Size = New System.Drawing.Size(134, 26)
        Me.dtDataEmissao.TabIndex = 5
        Me.dtDataEmissao.Value = New Date(2019, 8, 5, 0, 0, 0, 0)
        '
        'txValor
        '
        Me.txValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txValor.Location = New System.Drawing.Point(389, 53)
        Me.txValor.MaxLength = 10
        Me.txValor.Name = "txValor"
        Me.txValor.Size = New System.Drawing.Size(91, 26)
        Me.txValor.TabIndex = 2
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
        Me.cbStatus.Location = New System.Drawing.Point(638, 53)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 26)
        Me.cbStatus.TabIndex = 4
        '
        'lbJuros
        '
        Me.lbJuros.AutoSize = True
        Me.lbJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJuros.Location = New System.Drawing.Point(514, 35)
        Me.lbJuros.Name = "lbJuros"
        Me.lbJuros.Size = New System.Drawing.Size(76, 20)
        Me.lbJuros.TabIndex = 17
        Me.lbJuros.Text = "Juros(%):"
        '
        'lbDataEmissao
        '
        Me.lbDataEmissao.AutoSize = True
        Me.lbDataEmissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataEmissao.Location = New System.Drawing.Point(16, 96)
        Me.lbDataEmissao.Name = "lbDataEmissao"
        Me.lbDataEmissao.Size = New System.Drawing.Size(133, 20)
        Me.lbDataEmissao.TabIndex = 19
        Me.lbDataEmissao.Text = "Data de emissão:"
        '
        'btVerTodos
        '
        Me.btVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btVerTodos.Image = CType(resources.GetObject("btVerTodos.Image"), System.Drawing.Image)
        Me.btVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btVerTodos.Location = New System.Drawing.Point(1181, 220)
        Me.btVerTodos.Name = "btVerTodos"
        Me.btVerTodos.Size = New System.Drawing.Size(138, 25)
        Me.btVerTodos.TabIndex = 14
        Me.btVerTodos.Text = "Ver todos"
        Me.btVerTodos.UseVisualStyleBackColor = True
        '
        'lbN
        '
        Me.lbN.AutoSize = True
        Me.lbN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbN.Location = New System.Drawing.Point(179, 226)
        Me.lbN.Name = "lbN"
        Me.lbN.Size = New System.Drawing.Size(16, 17)
        Me.lbN.TabIndex = 78
        Me.lbN.Text = "0"
        '
        'lbNumRegistros
        '
        Me.lbNumRegistros.AutoSize = True
        Me.lbNumRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumRegistros.Location = New System.Drawing.Point(34, 225)
        Me.lbNumRegistros.Name = "lbNumRegistros"
        Me.lbNumRegistros.Size = New System.Drawing.Size(150, 17)
        Me.lbNumRegistros.TabIndex = 77
        Me.lbNumRegistros.Text = "Numero de Registros: "
        '
        'btHome
        '
        Me.btHome.BackgroundImage = CType(resources.GetObject("btHome.BackgroundImage"), System.Drawing.Image)
        Me.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btHome.Location = New System.Drawing.Point(35, 582)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(90, 90)
        Me.btHome.TabIndex = 79
        Me.btHome.UseVisualStyleBackColor = True
        '
        'Frm_Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 709)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.lbN)
        Me.Controls.Add(Me.lbNumRegistros)
        Me.Controls.Add(Me.dgGastos)
        Me.Controls.Add(Me.txId)
        Me.Controls.Add(Me.btRemover)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbDadosConta)
        Me.Controls.Add(Me.btVerTodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Gastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Gastos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDadosConta.ResumeLayout(False)
        Me.gbDadosConta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txJuros As TextBox
    Friend WithEvents lbDataVencimento As Label
    Friend WithEvents lbStatus As Label
    Friend WithEvents dgGastos As DataGridView
    Friend WithEvents txId As TextBox
    Friend WithEvents txDescricao As TextBox
    Friend WithEvents lbDescricao As Label
    Friend WithEvents btRemover As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents rbPendente As RadioButton
    Friend WithEvents gbDadosConta As GroupBox
    Friend WithEvents lbJuros As Label
    Friend WithEvents lbDataEmissao As Label
    Friend WithEvents btVerTodos As Button
    Friend WithEvents txValor As TextBox
    Friend WithEvents lbValor As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents dtDataVencimento As DateTimePicker
    Friend WithEvents dtDataEmissao As DateTimePicker
    Friend WithEvents lbBuscarStatus As Label
    Friend WithEvents rbPago As RadioButton
    Friend WithEvents txCredor As TextBox
    Friend WithEvents lbCredor As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents lbE As Label
    Friend WithEvents lbEntre As Label
    Friend WithEvents dtBuscarData1 As DateTimePicker
    Friend WithEvents dtBuscarData2 As DateTimePicker
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents lbVencimento As Label
    Friend WithEvents lbN As Label
    Friend WithEvents lbNumRegistros As Label
    Friend WithEvents btHome As Button
End Class
