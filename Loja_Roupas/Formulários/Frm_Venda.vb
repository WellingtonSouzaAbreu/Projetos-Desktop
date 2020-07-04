Imports MySql.Data.MySqlClient
Public Class Frm_Venda
    Private Sub Frm_Venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDadosVenda.Enabled = False
        Listar()
        FormatarDg()
    End Sub

    Private Sub LimparCampos()
        txCodigo.Text = ""
        txQtd.Text = ""
        txCliente.Text = ""
        rbAVista.Checked = True
        txDesconto.Text = ""
        txTotal.Text = ""
        txIdProdutoLista.Text = ""
        txIdVenda.Text = ""
        txTot.Text = ""
        dgListaProdutos.DataSource = ""

    End Sub

    Sub FormatarDg()
        dgVendas.Font = New Font("Microsoft Sans Serif", 11)

        dgVendas.Columns(0).HeaderText = "Codigo"
        dgVendas.Columns(1).HeaderText = "Total"
        dgVendas.Columns(2).HeaderText = "Desconto"
        dgVendas.Columns(3).HeaderText = "Forma de Pagamento"
        dgVendas.Columns(4).HeaderText = "Data da Venda"
        dgVendas.Columns(5).HeaderText = "Cliente"


        dgVendas.Columns(0).Width = 130
        dgVendas.Columns(1).Width = 160
        dgVendas.Columns(2).Width = 110
        dgVendas.Columns(3).Width = 240
        dgVendas.Columns(4).Width = 240
        dgVendas.Columns(5).Width = 338

        dgVendas.Columns(6).Visible = False


    End Sub

    Private Sub Listar()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT  V.ID_VENDA, 
                           V.TOTAL, 
                           V.DESCONTO, 
                           V.FORMA_PAGAMENTO, 
                           V.DATA_VENDA, 
                           C.NOME,
                           V.CLIENTE_ID
                    FROM VENDAS AS V 
                    INNER JOIN CLIENTES AS C 
                    ON C.ID_CLIENTE = V.CLIENTE_ID
                    ORDER BY ID_VENDA"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            dgVendas.DataSource = dt

            ContarRegistros()
            Fechar()

        Catch ex As Exception
            MsgBox("Não foi possivel extrair dados do banco! Erro: " + ex.Message, MsgBoxStyle.Information)
            Fechar()
        End Try
        Fechar()
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If gbDadosVenda.Enabled Then
            Dim valido As Boolean = True

            If txCliente.Visible = True And txCliente.Text = "" Then
                valido = False
                lbCliente.ForeColor = Color.Red
            End If

            If cbStatus.Text <> "Pago" And cbStatus.Text <> "Pendente" Then
                valido = False
                lbStatus.ForeColor = Color.Red
            End If

            If dgListaProdutos.Rows.Count = 0 Then
                valido = False
                MsgBox("A lista de produtos está vazia!", MsgBoxStyle.Exclamation)
            End If

            If rbAPrazo.Checked = True Then
                If txIdCliente.Text = "" Then
                    valido = False
                    lbCliente.ForeColor = Color.Red
                Else
                    Abrir()
                    Dim reader As MySqlDataReader
                    Dim sql As String
                    Dim cmd As MySqlCommand

                    sql = "SELECT ID_CLIENTE FROM CLIENTES WHERE NOME = '" & txCliente.Text & "' "

                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader()

                    If Not reader.Read Then
                        reader.Close()
                        valido = False
                        lbCliente.ForeColor = Color.Red
                        MsgBox("Cliente não cadastrado no sistema!", MsgBoxStyle.Exclamation)
                    End If
                    reader.Close()

                    Fechar()
                End If
            End If

            If valido = True Then
                Try
                    If Trim(txDesconto.Text) = "" Then
                        txDesconto.Text = 0
                    End If
                    If Trim(txCliente.Text) = "" Then
                        txIdCliente.Text = 0
                    End If

                    Abrir()
                    Dim sql As String = ""
                    Dim cmd As MySqlCommand
                    Dim formaPagamento As String
                    Dim idCliente As String

                    If rbAVista.Checked Then
                        formaPagamento = "A Vista"
                        idCliente = 1  'Colocar uma tupla vazia pre definida
                    Else
                        formaPagamento = "A Prazo"
                        idCliente = txIdCliente.Text
                    End If


                    If edit = False Then
                        sql = "UPDATE VENDAS
		                            SET ID_VENDA = '" & txIdVenda.Text & "', 
		                            TOTAL = '" & txTotal.Text & "', 
		                            DESCONTO = '" & Trim(txDesconto.Text) & "', 
		                            FORMA_PAGAMENTO = '" & formaPagamento & "' ,
                                    CLIENTE_ID = '" & idCliente & "',
		                            DATA_VENDA = (SELECT CURRENT_DATE()) 
                                    WHERE ID_VENDA = '" & txIdVenda.Text & "' "
                    Else
                        sql = "UPDATE VENDAS
		                            SET ID_VENDA = '" & txIdVenda.Text & "', 
		                            TOTAL = '" & txTotal.Text & "', 
		                            DESCONTO = '" & Trim(txDesconto.Text) & "', 
		                            FORMA_PAGAMENTO = '" & formaPagamento & "' ,
                                    CLIENTE_ID = '" & idCliente & "',
		                            DATA_VENDA = (SELECT CURRENT_DATE()) 
                                    WHERE ID_VENDA = '" & txIdVendaMan.Text & "' "
                    End If

                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    If rbAPrazo.Checked Then
                        GerarPromissoria()
                    End If

                    Listar()

                    Fechar()

                    If edit = False Then
                        MsgBox("Venda realizada com sucesso!", MsgBoxStyle.Information)
                        LimparCampos()
                    Else
                        MsgBox("Venda atualiada com sucesso!", MsgBoxStyle.Information)
                        edit = False
                    End If




                    gbDadosVenda.Enabled = False

                Catch ex As Exception
                    MsgBox("Falha ao realizar cadastro! " + ex.Message, MsgBoxStyle.Exclamation)
                End Try

            Else
                MsgBox("Preencha os campos obrigatórios! ", MsgBoxStyle.Exclamation)
                End If
                Fechar()
            End If
    End Sub

    Private Sub GerarPromissoria()
        Dim sql As String
        Dim cmd As MySqlCommand

        Try
            Abrir()
            sql = "INSERT INTO PROMISSORIAS(
	            CLIENTE_ID, 
	            VENDA_ID,
	            VALOR, 
	            DATA_EMISSAO, 
	            DATA_VENCIMENTO,
	            JUROS_VENCIMENTO,
	            STATUS
	         )VALUES (
                '" & txIdCliente.Text & "',    
                '" & txIdVenda.Text & "',
                '" & txTotal.Text & "',
                (SELECT CURRENT_DATE()),
                (SELECT DATE_ADD(CURDATE(), INTERVAL 30 DAY)),
                '" & txJuros.Text & "',
                '" & cbStatus.Text & "')"

            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            MsgBox("Promissória gerada com sucesso!")
            Fechar()
        Catch ex As Exception
            Fechar()
            MsgBox("Não foi possível gerar a promissória! " + ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub IniciarVenda()
        Try
            Abrir()
            Dim sql As String
            Dim cmd As New MySqlCommand

            sql = "INSERT INTO VENDAS(
                    ID_VENDA, 
                    DATA_VENDA)
                    VALUES(
                    '" & Trim(txIdVenda.Text) & "',
                    '" & Now.ToString("yyyy-MM-dd") & "')"

            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            Fechar()
        Catch ex As Exception
            Fechar()
            MsgBox("Falha ao iniciar venda! Erro:", MsgBoxStyle.Exclamation + ex.Message)
        End Try

    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        If gbDadosVenda.Enabled = False Or edit = True Then
            gbDadosVenda.Enabled = True
            gbFormaPagamento.Enabled = True
            edit = False

            LimparVendasVazias()
            ZerarContador()
            LimparCampos()

            Try
                Abrir()
                IniciarVenda()
                Dim sql As String
                Dim da As MySqlDataAdapter
                Dim dt As New DataTable

                sql = "SELECT (MAX(ID_VENDA)) FROM VENDAS"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)

                If dt.Rows.Count = 1 Then
                    txIdVenda.Text = dt.Rows(0).Item(0)
                Else
                    MsgBox("Não foi possível extrair o identificador! ")
                End If

                Fechar()
            Catch ex As Exception
                Fechar()
                MsgBox("Falha ao inserir novo código! Verifique a conexão com a internet. Erro: ", MsgBoxStyle.Exclamation + ex.Message)
            End Try

            Listar_ListaProdutos()
        End If
    End Sub

    Private Sub TxCliente_Enter(sender As Object, e As EventArgs) Handles txCliente.Enter
        lbCliente.ForeColor = Color.Black
    End Sub

    Private Sub RbAVista_CheckedChanged(sender As Object, e As EventArgs) Handles rbAVista.CheckedChanged
        If rbAVista.Checked Then
            lbBuscar.ForeColor = Color.Black
            lbStatus.ForeColor = Color.Black

            lbCliente.Visible = False
            txCliente.Visible = False
            btIrCliente.Visible = False
            lbJuros.Visible = False
            txJuros.Visible = False
            lbStatus.Visible = False
            cbStatus.Visible = False
        Else
            lbCliente.Visible = True
            txCliente.Visible = True
            btIrCliente.Visible = True
            lbJuros.Visible = True
            lbStatus.Visible = True
            cbStatus.Visible = True
            txJuros.Visible =
            txCliente.Text = ""
            txJuros.Text = ""

            Try
                Abrir()
                Dim sql As String
                Dim da As MySqlDataAdapter
                Dim dt As New DataTable


                sql = "SELECT NOME FROM CLIENTES ORDER BY NOME"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    txCliente.AutoCompleteCustomSource.Add(dt.ToString)

                    'cbFornecedor.ValueMember = "ID_FORNECEDOR"
                    'cbFornecedor.DisplayMember = "DENOMINACAO_SOCIAL"
                End If
            Catch ex As Exception
                MsgBox("Falha ao consultar clientes!" + ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Fechar()

        End If
    End Sub

    Private Sub RbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        If rbCliente.Checked Then
            txBuscarTxt.Visible = True
            txBuscarTxt.Enabled = True
            txBuscarTxt.Text = ""

            cbBuscarFdp.Visible = False
            cbBuscarFdp.Enabled = False

            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False
            lbEntre.Visible = False
            lbE.Visible = False

            Listar()
        End If
    End Sub

    Private Sub RbFormaPagamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbFormaPagamento.CheckedChanged
        If rbFormaPagamento.Checked Then
            txBuscarTxt.Visible = False
            txBuscarTxt.Enabled = False

            cbBuscarFdp.Visible = True
            cbBuscarFdp.Enabled = True
            cbBuscarFdp.Text = ""

            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False
            lbEntre.Visible = False
            lbE.Visible = False

            Listar()
        End If
    End Sub

    Private Sub RbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        If rbData.Checked Then
            dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
            dtBuscarData2.Visible = True
            dtBuscarData2.Enabled = True

            dtBuscarData1.Value = dtBuscarData2.Value.AddMonths(-1)
            dtBuscarData1.Visible = True
            dtBuscarData1.Enabled = True
            dtBuscarData1.Focus()
            lbEntre.Visible = True
            lbE.Visible = True

            cbBuscarFdp.Visible = False
            cbBuscarFdp.Enabled = False

            txBuscarTxt.Visible = False
            txBuscarTxt.Enabled = False

            Listar()
        End If

    End Sub

    Private Sub TxDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDesconto.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxJuros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txJuros.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Public vBusca As Boolean = False

    Private Sub BtIrProduto_Click(sender As Object, e As EventArgs) Handles btIrProduto.Click
        vBusca = True
        Frm_CadProduto.ShowDialog()
    End Sub

    Sub FormatarDg_ListaProdutos()
        dgListaProdutos.Font = New Font("Microsoft Sans Serif", 11)

        dgListaProdutos.Columns(0).HeaderText = "Cod"
        dgListaProdutos.Columns(1).HeaderText = "Descrição"
        dgListaProdutos.Columns(2).HeaderText = "Valor"
        'dgListaProdutos.Columns(3).HeaderText = "Lista_id"

        dgListaProdutos.Columns(3).Visible = False

        dgListaProdutos.Columns(0).Width = 80
        dgListaProdutos.Columns(1).Width = 248
        dgListaProdutos.Columns(2).Width = 85

    End Sub

    Private Sub Listar_ListaProdutos()
        Abrir()
        Dim sql As String
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable


        sql = "SELECT P.ID_PRODUTO, 
                      P.DESCRICAO, 
                      P.VALOR_VENDA,
                      L.ID_LISTA_PRODUTOS
                      FROM PRODUTOS P 
                      INNER JOIN LISTA_PRODUTOS L
                      ON P.ID_PRODUTO = L.PRODUTO_ID
                      WHERE L.VENDA_ID = '" & txIdVenda.Text & "' "



        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)

        dgListaProdutos.DataSource = dt

        'If dgListaProdutos.Rows.Count > 0 Then
            FormatarDg_ListaProdutos()
        'End If

        ContarItens()

        Fechar()
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If Trim(txCodigo.Text) <> "" Then

            Try
                Abrir()
                Dim reader As MySqlDataReader
                Dim cmd As MySqlCommand
                Dim sql As String
                Dim da As MySqlDataAdapter
                Dim dt As New DataTable
                Dim quantidade As Integer

                sql = "SELECT ID_PRODUTO FROM PRODUTOS WHERE ID_PRODUTO = '" & txCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader()

                If reader.Read Then
                    reader.Close()

                    sql = "SELECT QUANTIDADE FROM PRODUTOS WHERE ID_PRODUTO = '" & txCodigo.Text & "'"
                    da = New MySqlDataAdapter(sql, con)
                    da.Fill(dt)

                    If dt.Rows.Count = 1 Then
                        quantidade = dt.Rows(0).Item(0)
                    Else
                        MsgBox("Não foi possível extrair o identificador! ")
                    End If

                    If txQtd.Text = "" Or txQtd.Text = "0" Then
                        txQtd.Text = "1"
                    End If

                    If quantidade >= txQtd.Text Then
                        Dim qtd As Integer = txQtd.Text

                        For i = 1 To qtd
                            sql = "INSERT INTO LISTA_PRODUTOS( 
	                                PRODUTO_ID, 
	                                VENDA_ID, 
	                                QUANTIDADE)
                                VALUES(
	                                '" & Trim(txCodigo.Text) & "' ,
	                                '" & Trim(txIdVenda.Text) & "' ,
	                                '" & Trim(txQtd.Text) & "'
                                    )"

                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                            'Atualiza Quantidade de produtos
                            sql = "UPDATE PRODUTOS SET QUANTIDADE = QUANTIDADE - 1 WHERE ID_PRODUTO = '" & txCodigo.Text & "' "
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()
                        Next


                        txCodigo.Text = ""
                        txQtd.Text = ""

                        Listar_ListaProdutos()
                        CalcularTotal()
                        Fechar()
                    Else
                        reader.Close()
                        If quantidade > 0 Then
                            MsgBox("Quantidade insuficiente deste produto. Este produto conta apenas com " & quantidade & " Unidades no estoque", MsgBoxStyle.Exclamation)
                        Else
                            MsgBox("Quantidade insuficiente deste produto. Este produto conta com " & quantidade & " Unidades no estoque", MsgBoxStyle.Exclamation)
                        End If
                    End If

                    Else
                        reader.Close()
                    Fechar()
                    MsgBox("Codigo inválido! Não existe nenhum produto cadastrado com esse codigo!", MsgBoxStyle.Exclamation)

                End If
            Catch ex As Exception
                Fechar()
                MsgBox("Erro ao inserir produto na lista! Erro: " + ex.Message, MsgBoxStyle.Exclamation)
            End Try

        End If
    End Sub

    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        Try
            If dgListaProdutos.Rows.Count > 0 Then
                Dim sql As String
                Dim cmd As MySqlCommand

                Abrir()

                'Atualiza Quantidade de produtos
                sql = "UPDATE PRODUTOS SET QUANTIDADE = QUANTIDADE + 1 WHERE ID_PRODUTO = '" & txIdProdutoLista.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                sql = "DELETE FROM LISTA_PRODUTOS WHERE 
                       ID_LISTA_PRODUTOS =  '" & dgListaProdutos.CurrentRow.Cells(3).Value & "' AND 
                       VENDA_ID = '" & txIdVenda.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                Listar_ListaProdutos()

                CalcularTotal()
                Fechar()
                Exit Sub

            Else
                MsgBox("Impossível excluir. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Erro ao remover item da lista!", MsgBoxStyle.Exclamation)
        End Try
        Fechar()
    End Sub

    Public edit As Boolean = False

    Private Sub CalcularTotal()
        If dgListaProdutos.Rows.Count > 0 Then
            Try
                Abrir()
                Dim sql As String
                Dim dt As New DataTable
                Dim da As MySqlDataAdapter

                sql = "SELECT SUM(P.VALOR_VENDA) FROM PRODUTOS P 
                        INNER JOIN LISTA_PRODUTOS L
                        ON P.ID_PRODUTO = L.PRODUTO_ID 
                        WHERE L.VENDA_ID = '" & txIdVenda.Text & "' "

                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)

                txTotal.Text = dt.Rows(0).Item(0)
                txTot.Text = dt.Rows(0).Item(0)

                Fechar()
            Catch ex As Exception
                MsgBox("Erro ao calcular o valor da venda! ", MsgBoxStyle.Exclamation + ex.Message)
            End Try
            Fechar()

        Else
            txTotal.Text = ""
        End If

    End Sub

    Private Sub TxDesconto_TextChanged(sender As Object, e As EventArgs) Handles txDesconto.TextChanged
        If txTotal.Text <> "" Then
            If txDesconto.Text = "" Or txTotal.Text = "" Then
                CalcularTotal()
                Exit Sub
            End If

            txTotal.Text = Convert.ToDecimal(txTot.Text) - ((Convert.ToDecimal(txDesconto.Text) / 100) * Convert.ToDecimal(txTot.Text))
        End If

    End Sub

    Private Sub TxTotal_TextChanged(sender As Object, e As EventArgs) Handles txTotal.TextChanged
        If txTotal.Text = "" Then
            CalcularTotal()
        End If
    End Sub

    Private Sub BtIrCliente_Click(sender As Object, e As EventArgs) Handles btIrCliente.Click
        vBusca = True
        lbCliente.ForeColor = Color.Black
        Me.Hide()
        Frm_CadCliente.ShowDialog()
    End Sub

    Private Sub BtRemover_Click(sender As Object, e As EventArgs) Handles btRemover.Click
        edit = False

        If dgVendas.Rows.Count > 0 And dgVendas.SelectedRows.Count = 1 Then
            Dim sql As String
            Dim cmd As MySqlCommand

            Dim decisao As String

            decisao = MsgBox("Deseja excluir este registro?", MsgBoxStyle.YesNo)

            If decisao = "6" Then

                Abrir()

                sql = "DELETE FROM LISTA_PRODUTOS WHERE LISTA_PRODUTOS.VENDA_ID = '" & txIdVendaMan.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                sql = "DELETE FROM VENDAS WHERE ID_VENDA = '" & txIdVendaMan.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                Listar()

                MsgBox("Registro excluido!", MsgBoxStyle.Information)
            Else
                Fechar()
                Exit Sub
            End If
        Else
            MsgBox("Impossível excluir. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
        Fechar()
    End Sub

    Private Sub DgVendas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgVendas.CellEnter

        If dgVendas.Rows.Count > 0 Then
            LimparCampos()
            txIdVendaMan.Text = dgVendas.CurrentRow.Cells(0).Value
            gbDadosVenda.Enabled = False
        End If
    End Sub

    Sub PreencherCampos()
        txIdVenda.Text = dgVendas.CurrentRow.Cells(0).Value
        txTotal.Text = dgVendas.CurrentRow.Cells(1).Value
        txTot.Text = dgVendas.CurrentRow.Cells(1).Value
        txDesconto.Text = dgVendas.CurrentRow.Cells(2).Value

        Listar_ListaProdutos() 'Listagem diferente da padrão

    End Sub

    Sub LimparVendasVazias()

        Try
            Abrir()
            Dim sql As String
            Dim cmd As MySqlCommand

            'sql = "UPDATE PRODUTOS, LISTA_PRODUTOS, VENDAS SET PRODUTOS.QUANTIDADE = PRODUTOS.QUANTIDADE + 1 WHERE PRODUTOS.ID_PRODUTO =  LISTA_PRODUTOS.PRODUTO_ID AND VENDAS.TOTAL IS NULL"
            'cmd = New MySqlCommand(sql, con)
            'cmd.ExecuteNonQuery()

            sql = "DELETE FROM VENDAS WHERE TOTAL IS NULL"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Fechar()
            MsgBox("Erro ao encerrar venda! Erro: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Fechar()
    End Sub

    Sub ZerarContador()
        Abrir()
        Dim sql As String
        Dim cmd As MySqlCommand

        sql = "ALTER TABLE VENDAS AUTO_INCREMENT = 1;"
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        Fechar()
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If dgVendas.Rows.Count > 0 Then
            gbDadosVenda.Enabled = True
            gbFormaPagamento.Enabled = False
            edit = True
            PreencherCampos()
        Else
            MsgBox("Impossível editar. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub dgListaProdutos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaProdutos.CellEnter
        If dgListaProdutos.Rows.Count > 0 Then
            txIdProdutoLista.Text = dgListaProdutos.CurrentRow.Cells(0).Value
        End If
    End Sub

    Sub Buscar()
        Try
            Abrir()
            Dim sql As String = ""
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If rbCliente.Checked Then
                sql = "SELECT  V.ID_VENDA, 
                           V.TOTAL, 
                           V.DESCONTO, 
                           V.FORMA_PAGAMENTO, 
                           V.DATA_VENDA, 
                           C.NOME,
                           V.CLIENTE_ID
                    FROM VENDAS AS V 
                    INNER JOIN CLIENTES AS C 
                    ON C.ID_CLIENTE = V.CLIENTE_ID
                    WHERE C.NOME LIKE '" & txBuscarTxt.Text & "%'  
                    ORDER BY ID_VENDA"
            End If

            If rbFormaPagamento.Checked Then
                sql = "SELECT  V.ID_VENDA, 
                           V.TOTAL, 
                           V.DESCONTO, 
                           V.FORMA_PAGAMENTO, 
                           V.DATA_VENDA, 
                           C.NOME,
                           V.CLIENTE_ID
                    FROM VENDAS AS V 
                    INNER JOIN CLIENTES AS C 
                    ON C.ID_CLIENTE = V.CLIENTE_ID
                    WHERE V.FORMA_PAGAMENTO = '" & cbBuscarFdp.Text & "'  
                    ORDER BY ID_VENDA"
            End If

            If rbData.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT  V.ID_VENDA, 
                           V.TOTAL, 
                           V.DESCONTO, 
                           V.FORMA_PAGAMENTO, 
                           V.DATA_VENDA, 
                           C.NOME,
                           V.CLIENTE_ID
                    FROM VENDAS AS V 
                    INNER JOIN CLIENTES AS C 
                    ON C.ID_CLIENTE = V.CLIENTE_ID
                    WHERE DATA_VENDA BETWEEN '" & dtBuscarData1.Text & "' AND  '" & dtBuscarData2.Text & "' 
                    ORDER BY ID_VENDA"
                Else
                    sql = "SELECT  V.ID_VENDA, 
                           V.TOTAL, 
                           V.DESCONTO, 
                           V.FORMA_PAGAMENTO, 
                           V.DATA_VENDA, 
                           C.NOME,
                           V.CLIENTE_ID
                    FROM VENDAS AS V 
                    INNER JOIN CLIENTES AS C 
                    ON C.ID_CLIENTE = V.CLIENTE_ID
                    WHERE DATA_VENDA BETWEEN '" & dtBuscarData2.Text & "' AND  '" & dtBuscarData1.Text & "' 
                    ORDER BY ID_VENDA"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgVendas.DataSource = dt

            If dgVendas.Rows.Count > 0 Then
                FormatarDg()
            End If

            Fechar()

        Catch ex As Exception
            MsgBox("Erro ao buscar registros! erro", MsgBoxStyle.Information + ex.Message)
        End Try

        Fechar()
    End Sub

    Private Sub cbBuscarFdp_TextChanged(sender As Object, e As EventArgs) Handles cbBuscarFdp.TextChanged
        If cbBuscarFdp.Text <> "" Then
            buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub txBuscarTxt_TextChanged(sender As Object, e As EventArgs) Handles txBuscarTxt.TextChanged
        If txBuscarTxt.Text <> "" Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub dtBuscarData1_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData1.ValueChanged
        If rbData.Checked Then
            Buscar()
        End If
    End Sub

    Private Sub dtBuscarData2_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData2.ValueChanged
        If rbData.Checked Then
            Buscar()
        End If
    End Sub

    Private Sub btVerTodos_Click(sender As Object, e As EventArgs) Handles btVerTodos.Click
        Listar()
    End Sub

    Sub ContarRegistros()
        lbN.Text = dgVendas.Rows.Count
    End Sub

    Sub ContarItens()
        lbNItens.Text = dgListaProdutos.Rows.Count
    End Sub

    Private Sub dgListaProdutos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgListaProdutos.RowsAdded
        CalcularTotal()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Frm_TelaPrincipal.Show()
        Me.Close()
    End Sub
End Class