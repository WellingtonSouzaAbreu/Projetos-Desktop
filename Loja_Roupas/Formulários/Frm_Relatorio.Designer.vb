<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Relatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Relatorio))
        Me.gbGanhos = New System.Windows.Forms.GroupBox()
        Me.lbVendaBrutaR = New System.Windows.Forms.Label()
        Me.lbVendaBruta = New System.Windows.Forms.Label()
        Me.lbGanhoEstimadoR = New System.Windows.Forms.Label()
        Me.lbGanhoEstimado = New System.Windows.Forms.Label()
        Me.btGerarRelatorio = New System.Windows.Forms.Button()
        Me.dtData2 = New System.Windows.Forms.DateTimePicker()
        Me.dtData1 = New System.Windows.Forms.DateTimePicker()
        Me.gbGastos = New System.Windows.Forms.GroupBox()
        Me.lbCompraProdutosR = New System.Windows.Forms.Label()
        Me.lbCustosAdicionaisR = New System.Windows.Forms.Label()
        Me.lbCustosAdicionais = New System.Windows.Forms.Label()
        Me.lbCompraProdutos = New System.Windows.Forms.Label()
        Me.gbResultados = New System.Windows.Forms.GroupBox()
        Me.lbTotalGanho = New System.Windows.Forms.Label()
        Me.lbLucroLiquidoR = New System.Windows.Forms.Label()
        Me.lbLucroLiquido = New System.Windows.Forms.Label()
        Me.lbTotalGastoR = New System.Windows.Forms.Label()
        Me.lbTotalGasto = New System.Windows.Forms.Label()
        Me.lbTotalGanhoR = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbDetalhesVendas = New System.Windows.Forms.GroupBox()
        Me.lbPecasAdultasR = New System.Windows.Forms.Label()
        Me.lbPecasAdultas = New System.Windows.Forms.Label()
        Me.lbPecasInfantisR = New System.Windows.Forms.Label()
        Me.lbPecasInfantis = New System.Windows.Forms.Label()
        Me.lbPecasUnissexR = New System.Windows.Forms.Label()
        Me.lbPecasUnissex = New System.Windows.Forms.Label()
        Me.lbPecasFemininasR = New System.Windows.Forms.Label()
        Me.lbPecasFemininas = New System.Windows.Forms.Label()
        Me.lbPecasMasculinasR = New System.Windows.Forms.Label()
        Me.lbPecasMasculinas = New System.Windows.Forms.Label()
        Me.gbBusca = New System.Windows.Forms.GroupBox()
        Me.lbPecasVendidas = New System.Windows.Forms.Label()
        Me.lbPecasVendidasR = New System.Windows.Forms.Label()
        Me.lbCOntasReceberR = New System.Windows.Forms.Label()
        Me.lbContasReceber = New System.Windows.Forms.Label()
        Me.lbPromissoriasGeradasR = New System.Windows.Forms.Label()
        Me.lbPromissoriasGeradas = New System.Windows.Forms.Label()
        Me.lbContasPagarR = New System.Windows.Forms.Label()
        Me.lbContasPagar = New System.Windows.Forms.Label()
        Me.gbGanhos.SuspendLayout()
        Me.gbGastos.SuspendLayout()
        Me.gbResultados.SuspendLayout()
        Me.gbDetalhesVendas.SuspendLayout()
        Me.gbBusca.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGanhos
        '
        Me.gbGanhos.Controls.Add(Me.lbCOntasReceberR)
        Me.gbGanhos.Controls.Add(Me.lbContasReceber)
        Me.gbGanhos.Controls.Add(Me.lbVendaBrutaR)
        Me.gbGanhos.Controls.Add(Me.lbVendaBruta)
        Me.gbGanhos.Controls.Add(Me.lbGanhoEstimadoR)
        Me.gbGanhos.Controls.Add(Me.lbGanhoEstimado)
        Me.gbGanhos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGanhos.Location = New System.Drawing.Point(66, 147)
        Me.gbGanhos.Name = "gbGanhos"
        Me.gbGanhos.Size = New System.Drawing.Size(382, 173)
        Me.gbGanhos.TabIndex = 0
        Me.gbGanhos.TabStop = False
        Me.gbGanhos.Text = "Ganhos:"
        '
        'lbVendaBrutaR
        '
        Me.lbVendaBrutaR.AutoSize = True
        Me.lbVendaBrutaR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVendaBrutaR.Location = New System.Drawing.Point(231, 86)
        Me.lbVendaBrutaR.Name = "lbVendaBrutaR"
        Me.lbVendaBrutaR.Size = New System.Drawing.Size(57, 20)
        Me.lbVendaBrutaR.TabIndex = 5
        Me.lbVendaBrutaR.Text = "Label5"
        '
        'lbVendaBruta
        '
        Me.lbVendaBruta.AutoSize = True
        Me.lbVendaBruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVendaBruta.Location = New System.Drawing.Point(40, 86)
        Me.lbVendaBruta.Name = "lbVendaBruta"
        Me.lbVendaBruta.Size = New System.Drawing.Size(103, 20)
        Me.lbVendaBruta.TabIndex = 4
        Me.lbVendaBruta.Text = "Venda Bruta:"
        '
        'lbGanhoEstimadoR
        '
        Me.lbGanhoEstimadoR.AutoSize = True
        Me.lbGanhoEstimadoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGanhoEstimadoR.Location = New System.Drawing.Point(231, 57)
        Me.lbGanhoEstimadoR.Name = "lbGanhoEstimadoR"
        Me.lbGanhoEstimadoR.Size = New System.Drawing.Size(57, 20)
        Me.lbGanhoEstimadoR.TabIndex = 3
        Me.lbGanhoEstimadoR.Text = "Label3"
        '
        'lbGanhoEstimado
        '
        Me.lbGanhoEstimado.AutoSize = True
        Me.lbGanhoEstimado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGanhoEstimado.Location = New System.Drawing.Point(40, 57)
        Me.lbGanhoEstimado.Name = "lbGanhoEstimado"
        Me.lbGanhoEstimado.Size = New System.Drawing.Size(137, 20)
        Me.lbGanhoEstimado.TabIndex = 2
        Me.lbGanhoEstimado.Text = "Ganho Estimado: "
        '
        'btGerarRelatorio
        '
        Me.btGerarRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarRelatorio.Location = New System.Drawing.Point(367, 30)
        Me.btGerarRelatorio.Name = "btGerarRelatorio"
        Me.btGerarRelatorio.Size = New System.Drawing.Size(133, 26)
        Me.btGerarRelatorio.TabIndex = 1
        Me.btGerarRelatorio.Text = "Gerar Relatório"
        Me.btGerarRelatorio.UseVisualStyleBackColor = True
        '
        'dtData2
        '
        Me.dtData2.CustomFormat = "dd/MM/yyyy"
        Me.dtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtData2.Location = New System.Drawing.Point(199, 30)
        Me.dtData2.Name = "dtData2"
        Me.dtData2.Size = New System.Drawing.Size(130, 26)
        Me.dtData2.TabIndex = 8
        Me.dtData2.Value = New Date(2019, 8, 5, 0, 0, 0, 0)
        '
        'dtData1
        '
        Me.dtData1.CustomFormat = "dd/MM/yyyy"
        Me.dtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtData1.Location = New System.Drawing.Point(23, 30)
        Me.dtData1.Name = "dtData1"
        Me.dtData1.Size = New System.Drawing.Size(134, 26)
        Me.dtData1.TabIndex = 7
        Me.dtData1.Value = New Date(2019, 8, 5, 0, 0, 0, 0)
        '
        'gbGastos
        '
        Me.gbGastos.Controls.Add(Me.lbContasPagarR)
        Me.gbGastos.Controls.Add(Me.lbContasPagar)
        Me.gbGastos.Controls.Add(Me.lbCompraProdutosR)
        Me.gbGastos.Controls.Add(Me.lbCustosAdicionaisR)
        Me.gbGastos.Controls.Add(Me.lbCustosAdicionais)
        Me.gbGastos.Controls.Add(Me.lbCompraProdutos)
        Me.gbGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGastos.Location = New System.Drawing.Point(496, 147)
        Me.gbGastos.Name = "gbGastos"
        Me.gbGastos.Size = New System.Drawing.Size(382, 173)
        Me.gbGastos.TabIndex = 9
        Me.gbGastos.TabStop = False
        Me.gbGastos.Text = "Gastos:"
        '
        'lbCompraProdutosR
        '
        Me.lbCompraProdutosR.AutoSize = True
        Me.lbCompraProdutosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompraProdutosR.Location = New System.Drawing.Point(227, 48)
        Me.lbCompraProdutosR.Name = "lbCompraProdutosR"
        Me.lbCompraProdutosR.Size = New System.Drawing.Size(66, 20)
        Me.lbCompraProdutosR.TabIndex = 1
        Me.lbCompraProdutosR.Text = "Label15"
        '
        'lbCustosAdicionaisR
        '
        Me.lbCustosAdicionaisR.AutoSize = True
        Me.lbCustosAdicionaisR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustosAdicionaisR.Location = New System.Drawing.Point(227, 86)
        Me.lbCustosAdicionaisR.Name = "lbCustosAdicionaisR"
        Me.lbCustosAdicionaisR.Size = New System.Drawing.Size(66, 20)
        Me.lbCustosAdicionaisR.TabIndex = 11
        Me.lbCustosAdicionaisR.Text = "Label13"
        '
        'lbCustosAdicionais
        '
        Me.lbCustosAdicionais.AutoSize = True
        Me.lbCustosAdicionais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustosAdicionais.Location = New System.Drawing.Point(36, 86)
        Me.lbCustosAdicionais.Name = "lbCustosAdicionais"
        Me.lbCustosAdicionais.Size = New System.Drawing.Size(139, 20)
        Me.lbCustosAdicionais.TabIndex = 10
        Me.lbCustosAdicionais.Text = "Custos Adicionais:"
        '
        'lbCompraProdutos
        '
        Me.lbCompraProdutos.AutoSize = True
        Me.lbCompraProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompraProdutos.Location = New System.Drawing.Point(36, 48)
        Me.lbCompraProdutos.Name = "lbCompraProdutos"
        Me.lbCompraProdutos.Size = New System.Drawing.Size(158, 20)
        Me.lbCompraProdutos.TabIndex = 0
        Me.lbCompraProdutos.Text = "Compra de produtos:"
        '
        'gbResultados
        '
        Me.gbResultados.Controls.Add(Me.lbTotalGanho)
        Me.gbResultados.Controls.Add(Me.lbLucroLiquidoR)
        Me.gbResultados.Controls.Add(Me.lbLucroLiquido)
        Me.gbResultados.Controls.Add(Me.lbTotalGastoR)
        Me.gbResultados.Controls.Add(Me.lbTotalGasto)
        Me.gbResultados.Controls.Add(Me.lbTotalGanhoR)
        Me.gbResultados.Controls.Add(Me.Label22)
        Me.gbResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResultados.Location = New System.Drawing.Point(913, 147)
        Me.gbResultados.Name = "gbResultados"
        Me.gbResultados.Size = New System.Drawing.Size(382, 173)
        Me.gbResultados.TabIndex = 12
        Me.gbResultados.TabStop = False
        Me.gbResultados.Text = "Resultados:"
        '
        'lbTotalGanho
        '
        Me.lbTotalGanho.AutoSize = True
        Me.lbTotalGanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalGanho.Location = New System.Drawing.Point(53, 48)
        Me.lbTotalGanho.Name = "lbTotalGanho"
        Me.lbTotalGanho.Size = New System.Drawing.Size(119, 20)
        Me.lbTotalGanho.TabIndex = 8
        Me.lbTotalGanho.Text = "Total de ganho:"
        '
        'lbLucroLiquidoR
        '
        Me.lbLucroLiquidoR.AutoSize = True
        Me.lbLucroLiquidoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLucroLiquidoR.Location = New System.Drawing.Point(244, 119)
        Me.lbLucroLiquidoR.Name = "lbLucroLiquidoR"
        Me.lbLucroLiquidoR.Size = New System.Drawing.Size(66, 20)
        Me.lbLucroLiquidoR.TabIndex = 7
        Me.lbLucroLiquidoR.Text = "Label17"
        '
        'lbLucroLiquido
        '
        Me.lbLucroLiquido.AutoSize = True
        Me.lbLucroLiquido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLucroLiquido.Location = New System.Drawing.Point(53, 119)
        Me.lbLucroLiquido.Name = "lbLucroLiquido"
        Me.lbLucroLiquido.Size = New System.Drawing.Size(108, 20)
        Me.lbLucroLiquido.TabIndex = 6
        Me.lbLucroLiquido.Text = "Lucro Líquido:"
        '
        'lbTotalGastoR
        '
        Me.lbTotalGastoR.AutoSize = True
        Me.lbTotalGastoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalGastoR.Location = New System.Drawing.Point(241, 86)
        Me.lbTotalGastoR.Name = "lbTotalGastoR"
        Me.lbTotalGastoR.Size = New System.Drawing.Size(66, 20)
        Me.lbTotalGastoR.TabIndex = 5
        Me.lbTotalGastoR.Text = "Label19"
        '
        'lbTotalGasto
        '
        Me.lbTotalGasto.AutoSize = True
        Me.lbTotalGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalGasto.Location = New System.Drawing.Point(53, 86)
        Me.lbTotalGasto.Name = "lbTotalGasto"
        Me.lbTotalGasto.Size = New System.Drawing.Size(122, 20)
        Me.lbTotalGasto.TabIndex = 4
        Me.lbTotalGasto.Text = "Total de gastos:"
        '
        'lbTotalGanhoR
        '
        Me.lbTotalGanhoR.AutoSize = True
        Me.lbTotalGanhoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalGanhoR.Location = New System.Drawing.Point(244, 48)
        Me.lbTotalGanhoR.Name = "lbTotalGanhoR"
        Me.lbTotalGanhoR.Size = New System.Drawing.Size(66, 20)
        Me.lbTotalGanhoR.TabIndex = 1
        Me.lbTotalGanhoR.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(50, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 20)
        Me.Label22.TabIndex = 0
        '
        'gbDetalhesVendas
        '
        Me.gbDetalhesVendas.Controls.Add(Me.lbPromissoriasGeradasR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPromissoriasGeradas)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasAdultasR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasAdultas)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasVendidasR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasVendidas)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasInfantisR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasInfantis)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasUnissexR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasUnissex)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasFemininasR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasFemininas)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasMasculinasR)
        Me.gbDetalhesVendas.Controls.Add(Me.lbPecasMasculinas)
        Me.gbDetalhesVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetalhesVendas.Location = New System.Drawing.Point(66, 353)
        Me.gbDetalhesVendas.Name = "gbDetalhesVendas"
        Me.gbDetalhesVendas.Size = New System.Drawing.Size(1229, 189)
        Me.gbDetalhesVendas.TabIndex = 13
        Me.gbDetalhesVendas.TabStop = False
        Me.gbDetalhesVendas.Text = "Detalhes das Vendas:"
        '
        'lbPecasAdultasR
        '
        Me.lbPecasAdultasR.AutoSize = True
        Me.lbPecasAdultasR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasAdultasR.Location = New System.Drawing.Point(643, 94)
        Me.lbPecasAdultasR.Name = "lbPecasAdultasR"
        Me.lbPecasAdultasR.Size = New System.Drawing.Size(26, 20)
        Me.lbPecasAdultasR.TabIndex = 17
        Me.lbPecasAdultasR.Text = "as"
        '
        'lbPecasAdultas
        '
        Me.lbPecasAdultas.AutoSize = True
        Me.lbPecasAdultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasAdultas.Location = New System.Drawing.Point(509, 94)
        Me.lbPecasAdultas.Name = "lbPecasAdultas"
        Me.lbPecasAdultas.Size = New System.Drawing.Size(115, 20)
        Me.lbPecasAdultas.TabIndex = 16
        Me.lbPecasAdultas.Text = "Peças Adultas:"
        '
        'lbPecasInfantisR
        '
        Me.lbPecasInfantisR.AutoSize = True
        Me.lbPecasInfantisR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasInfantisR.Location = New System.Drawing.Point(641, 52)
        Me.lbPecasInfantisR.Name = "lbPecasInfantisR"
        Me.lbPecasInfantisR.Size = New System.Drawing.Size(66, 20)
        Me.lbPecasInfantisR.TabIndex = 13
        Me.lbPecasInfantisR.Text = "Label26"
        '
        'lbPecasInfantis
        '
        Me.lbPecasInfantis.AutoSize = True
        Me.lbPecasInfantis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasInfantis.Location = New System.Drawing.Point(508, 52)
        Me.lbPecasInfantis.Name = "lbPecasInfantis"
        Me.lbPecasInfantis.Size = New System.Drawing.Size(114, 20)
        Me.lbPecasInfantis.TabIndex = 12
        Me.lbPecasInfantis.Text = "Peças Infantis:"
        '
        'lbPecasUnissexR
        '
        Me.lbPecasUnissexR.AutoSize = True
        Me.lbPecasUnissexR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasUnissexR.Location = New System.Drawing.Point(234, 133)
        Me.lbPecasUnissexR.Name = "lbPecasUnissexR"
        Me.lbPecasUnissexR.Size = New System.Drawing.Size(66, 20)
        Me.lbPecasUnissexR.TabIndex = 11
        Me.lbPecasUnissexR.Text = "Label10"
        '
        'lbPecasUnissex
        '
        Me.lbPecasUnissex.AutoSize = True
        Me.lbPecasUnissex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasUnissex.Location = New System.Drawing.Point(89, 133)
        Me.lbPecasUnissex.Name = "lbPecasUnissex"
        Me.lbPecasUnissex.Size = New System.Drawing.Size(117, 20)
        Me.lbPecasUnissex.TabIndex = 10
        Me.lbPecasUnissex.Text = "Peças Unissex:"
        '
        'lbPecasFemininasR
        '
        Me.lbPecasFemininasR.AutoSize = True
        Me.lbPecasFemininasR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasFemininasR.Location = New System.Drawing.Point(234, 94)
        Me.lbPecasFemininasR.Name = "lbPecasFemininasR"
        Me.lbPecasFemininasR.Size = New System.Drawing.Size(57, 20)
        Me.lbPecasFemininasR.TabIndex = 9
        Me.lbPecasFemininasR.Text = "Label2"
        '
        'lbPecasFemininas
        '
        Me.lbPecasFemininas.AutoSize = True
        Me.lbPecasFemininas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasFemininas.Location = New System.Drawing.Point(89, 94)
        Me.lbPecasFemininas.Name = "lbPecasFemininas"
        Me.lbPecasFemininas.Size = New System.Drawing.Size(134, 20)
        Me.lbPecasFemininas.TabIndex = 8
        Me.lbPecasFemininas.Text = "Peças Femininas:"
        '
        'lbPecasMasculinasR
        '
        Me.lbPecasMasculinasR.AutoSize = True
        Me.lbPecasMasculinasR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasMasculinasR.Location = New System.Drawing.Point(235, 52)
        Me.lbPecasMasculinasR.Name = "lbPecasMasculinasR"
        Me.lbPecasMasculinasR.Size = New System.Drawing.Size(57, 20)
        Me.lbPecasMasculinasR.TabIndex = 7
        Me.lbPecasMasculinasR.Text = "Label8"
        '
        'lbPecasMasculinas
        '
        Me.lbPecasMasculinas.AutoSize = True
        Me.lbPecasMasculinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasMasculinas.Location = New System.Drawing.Point(89, 52)
        Me.lbPecasMasculinas.Name = "lbPecasMasculinas"
        Me.lbPecasMasculinas.Size = New System.Drawing.Size(140, 20)
        Me.lbPecasMasculinas.TabIndex = 6
        Me.lbPecasMasculinas.Text = "Peças Masculinas:"
        '
        'gbBusca
        '
        Me.gbBusca.Controls.Add(Me.dtData1)
        Me.gbBusca.Controls.Add(Me.btGerarRelatorio)
        Me.gbBusca.Controls.Add(Me.dtData2)
        Me.gbBusca.Location = New System.Drawing.Point(66, 32)
        Me.gbBusca.Name = "gbBusca"
        Me.gbBusca.Size = New System.Drawing.Size(539, 89)
        Me.gbBusca.TabIndex = 14
        Me.gbBusca.TabStop = False
        '
        'lbPecasVendidas
        '
        Me.lbPecasVendidas.AutoSize = True
        Me.lbPecasVendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasVendidas.Location = New System.Drawing.Point(508, 133)
        Me.lbPecasVendidas.Name = "lbPecasVendidas"
        Me.lbPecasVendidas.Size = New System.Drawing.Size(124, 20)
        Me.lbPecasVendidas.TabIndex = 14
        Me.lbPecasVendidas.Text = "Peças Vendidas"
        '
        'lbPecasVendidasR
        '
        Me.lbPecasVendidasR.AutoSize = True
        Me.lbPecasVendidasR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPecasVendidasR.Location = New System.Drawing.Point(641, 133)
        Me.lbPecasVendidasR.Name = "lbPecasVendidasR"
        Me.lbPecasVendidasR.Size = New System.Drawing.Size(66, 20)
        Me.lbPecasVendidasR.TabIndex = 15
        Me.lbPecasVendidasR.Text = "Label24"
        '
        'lbCOntasReceberR
        '
        Me.lbCOntasReceberR.AutoSize = True
        Me.lbCOntasReceberR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCOntasReceberR.Location = New System.Drawing.Point(231, 119)
        Me.lbCOntasReceberR.Name = "lbCOntasReceberR"
        Me.lbCOntasReceberR.Size = New System.Drawing.Size(66, 20)
        Me.lbCOntasReceberR.TabIndex = 23
        Me.lbCOntasReceberR.Text = "Label30"
        '
        'lbContasReceber
        '
        Me.lbContasReceber.AutoSize = True
        Me.lbContasReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContasReceber.Location = New System.Drawing.Point(43, 119)
        Me.lbContasReceber.Name = "lbContasReceber"
        Me.lbContasReceber.Size = New System.Drawing.Size(142, 20)
        Me.lbContasReceber.TabIndex = 22
        Me.lbContasReceber.Text = "Contas a Receber:"
        '
        'lbPromissoriasGeradasR
        '
        Me.lbPromissoriasGeradasR.AutoSize = True
        Me.lbPromissoriasGeradasR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPromissoriasGeradasR.Location = New System.Drawing.Point(1068, 52)
        Me.lbPromissoriasGeradasR.Name = "lbPromissoriasGeradasR"
        Me.lbPromissoriasGeradasR.Size = New System.Drawing.Size(66, 20)
        Me.lbPromissoriasGeradasR.TabIndex = 25
        Me.lbPromissoriasGeradasR.Text = "Label32"
        '
        'lbPromissoriasGeradas
        '
        Me.lbPromissoriasGeradas.AutoSize = True
        Me.lbPromissoriasGeradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPromissoriasGeradas.Location = New System.Drawing.Point(880, 52)
        Me.lbPromissoriasGeradas.Name = "lbPromissoriasGeradas"
        Me.lbPromissoriasGeradas.Size = New System.Drawing.Size(169, 20)
        Me.lbPromissoriasGeradas.TabIndex = 24
        Me.lbPromissoriasGeradas.Text = "Promissorias Geradas:"
        '
        'lbContasPagarR
        '
        Me.lbContasPagarR.AutoSize = True
        Me.lbContasPagarR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContasPagarR.Location = New System.Drawing.Point(224, 119)
        Me.lbContasPagarR.Name = "lbContasPagarR"
        Me.lbContasPagarR.Size = New System.Drawing.Size(66, 20)
        Me.lbContasPagarR.TabIndex = 25
        Me.lbContasPagarR.Text = "Label28"
        '
        'lbContasPagar
        '
        Me.lbContasPagar.AutoSize = True
        Me.lbContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContasPagar.Location = New System.Drawing.Point(36, 119)
        Me.lbContasPagar.Name = "lbContasPagar"
        Me.lbContasPagar.Size = New System.Drawing.Size(123, 20)
        Me.lbContasPagar.TabIndex = 24
        Me.lbContasPagar.Text = "Contas a Pagar:"
        '
        'Frm_Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.gbBusca)
        Me.Controls.Add(Me.gbDetalhesVendas)
        Me.Controls.Add(Me.gbResultados)
        Me.Controls.Add(Me.gbGastos)
        Me.Controls.Add(Me.gbGanhos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relatórios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbGanhos.ResumeLayout(False)
        Me.gbGanhos.PerformLayout()
        Me.gbGastos.ResumeLayout(False)
        Me.gbGastos.PerformLayout()
        Me.gbResultados.ResumeLayout(False)
        Me.gbResultados.PerformLayout()
        Me.gbDetalhesVendas.ResumeLayout(False)
        Me.gbDetalhesVendas.PerformLayout()
        Me.gbBusca.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbGanhos As GroupBox
    Friend WithEvents btGerarRelatorio As Button
    Friend WithEvents dtData2 As DateTimePicker
    Friend WithEvents dtData1 As DateTimePicker
    Friend WithEvents lbVendaBrutaR As Label
    Friend WithEvents lbVendaBruta As Label
    Friend WithEvents lbGanhoEstimadoR As Label
    Friend WithEvents lbGanhoEstimado As Label
    Friend WithEvents gbGastos As GroupBox
    Friend WithEvents lbCompraProdutosR As Label
    Friend WithEvents lbCustosAdicionaisR As Label
    Friend WithEvents lbCustosAdicionais As Label
    Friend WithEvents lbCompraProdutos As Label
    Friend WithEvents gbResultados As GroupBox
    Friend WithEvents lbTotalGanho As Label
    Friend WithEvents lbLucroLiquidoR As Label
    Friend WithEvents lbLucroLiquido As Label
    Friend WithEvents lbTotalGastoR As Label
    Friend WithEvents lbTotalGasto As Label
    Friend WithEvents lbTotalGanhoR As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents gbDetalhesVendas As GroupBox
    Friend WithEvents lbPecasAdultasR As Label
    Friend WithEvents lbPecasAdultas As Label
    Friend WithEvents lbPecasInfantisR As Label
    Friend WithEvents lbPecasInfantis As Label
    Friend WithEvents lbPecasUnissexR As Label
    Friend WithEvents lbPecasUnissex As Label
    Friend WithEvents lbPecasFemininasR As Label
    Friend WithEvents lbPecasFemininas As Label
    Friend WithEvents lbPecasMasculinasR As Label
    Friend WithEvents lbPecasMasculinas As Label
    Friend WithEvents gbBusca As GroupBox
    Friend WithEvents lbCOntasReceberR As Label
    Friend WithEvents lbContasReceber As Label
    Friend WithEvents lbPecasVendidasR As Label
    Friend WithEvents lbPecasVendidas As Label
    Friend WithEvents lbContasPagarR As Label
    Friend WithEvents lbContasPagar As Label
    Friend WithEvents lbPromissoriasGeradasR As Label
    Friend WithEvents lbPromissoriasGeradas As Label
End Class
