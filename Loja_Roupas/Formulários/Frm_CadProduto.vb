Imports MySql.Data.MySqlClient

Public Class Frm_CadProduto

    Private Sub Frm_CadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gbDadosProduto.Enabled = False
            Listar()
            txBuscar.Focus()

            FormatarDg()

            Abrir()
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable


            sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL FROM FORNECEDORES"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then
                cbFornecedor.DataSource = dt
                cbFornecedor.ValueMember = "ID_FORNECEDOR"
                cbFornecedor.DisplayMember = "DENOMINACAO_SOCIAL"
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir formulário! Verifique sua conexão com a internet.", MsgBoxStyle.Exclamation)
        End Try
        Fechar()
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        gbDadosProduto.Enabled = True
        edit = False
        LimparCampos()

        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            sql = "SELECT MAX(ID_PRODUTO) FROM PRODUTOS"
            da = New MySqlDataAdapter(sql, con)
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If Not IsNumeric(dt.Rows(0).Item(0)) Then
                txCodigo.Text = 1
            Else
                txCodigo.Text = dt.Rows(0).Item(0) + 1
            End If
        Catch ex As Exception
            MsgBox("Falha ao inserir novo código! Verifique a conexão com a internet.", MsgBoxStyle.Exclamation + ex.Message)
        End Try
    End Sub

    Private Sub LimparCampos()
        txCodigo.Text = ""
        txDescricao.Text = ""
        txTamanho.Text = ""
        cbGenero.Text = ""
        txQuantidade.Text = ""
        txTecido.Text = ""
        cbCategoria.Text = ""
        txValorCompra.Text = ""
        txTaxa.Text = ""
        txValorVenda.Text = ""
    End Sub

    Private Sub FormatarDg()
        dgProduto.Font = New Font("Microsoft Sans Serif", 11)

        dgProduto.Columns(0).HeaderText = "Codigo"
        dgProduto.Columns(1).HeaderText = "Descrição"
        dgProduto.Columns(2).HeaderText = "Tamanho"
        dgProduto.Columns(3).HeaderText = "Quantidade"
        dgProduto.Columns(4).HeaderText = "Gênero"
        dgProduto.Columns(5).HeaderText = "Categoria"
        dgProduto.Columns(6).HeaderText = "Tecido"
        dgProduto.Columns(7).HeaderText = "Fornecedor"
        dgProduto.Columns(8).HeaderText = "Valor de Compra"
        dgProduto.Columns(9).HeaderText = "Taxa(%)"
        dgProduto.Columns(10).HeaderText = "Valor de Venda"
        dgProduto.Columns(11).HeaderText = "Data de Cadastro"

        dgProduto.Columns(0).Width = 80
        dgProduto.Columns(1).Width = 265
        dgProduto.Columns(2).Width = 80
        dgProduto.Columns(3).Width = 90
        dgProduto.Columns(4).Width = 80
        dgProduto.Columns(5).Width = 80
        dgProduto.Columns(6).Width = 80
        dgProduto.Columns(7).Width = 160
        dgProduto.Columns(8).Width = 80
        dgProduto.Columns(9).Width = 80
        dgProduto.Columns(10).Width = 80
        dgProduto.Columns(11).Width = 86
    End Sub

    Sub ContarRegistros()
        lbN.Text = dgProduto.Rows.Count
    End Sub

    Private Sub Listar()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If ckMostrarZerados.Checked Then
                sql = "SELECT P.ID_PRODUTO, 
                            P.DESCRICAO, 
                            P.TAMANHO, 
                            P.QUANTIDADE, 
                            P.GENERO, 
                            P.CATEGORIA,
                            P.TECIDO, 
                            F.DENOMINACAO_SOCIAL, 
                            P.VALOR_COMPRA, 
                            P.TAXA, P.VALOR_VENDA, 
                            P.DATA_CADASTRO, 
                            FROM PRODUTOS AS P 
                            INNER JOIN FORNECEDORES AS F 
                            ON F.ID_FORNECEDOR = P.FORNECEDOR_ID 
                            ORDER BY P.DESCRICAO"
            Else
                sql = "SELECT P.ID_PRODUTO, 
                        P.DESCRICAO, 
                        P.TAMANHO, 
                        P.QUANTIDADE, 
                        P.GENERO, 
                        P.CATEGORIA,
                        P.TECIDO, 
                        F.DENOMINACAO_SOCIAL, 
                        P.VALOR_COMPRA, 
                        P.TAXA, P.VALOR_VENDA, 
                        P.DATA_CADASTRO 
                        FROM PRODUTOS AS P 
                        INNER JOIN FORNECEDORES AS F 
                        ON F.ID_FORNECEDOR = P.FORNECEDOR_ID 
                        WHERE QUANTIDADE > 0 
                        ORDER BY P.DESCRICAO"
            End If

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            dgProduto.DataSource = dt

            Fechar()

            If dgProduto.Rows.Count > 0 Then
                FormatarDg()
            End If

            ContarRegistros()
        Catch ex As Exception
            MsgBox("Não foi possivel extrair dados do banco! Erro: ", MsgBoxStyle.Information)
        End Try
    End Sub

    Public edit As Boolean = False

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If gbDadosProduto.Enabled Then
            Dim valido As Boolean = True

            If Trim(txDescricao.Text) = "" Then
                valido = False
                lbDescricao.ForeColor = Color.Red
            End If

            If Trim(txTamanho.Text) = "" Then
                valido = False
                lbTamanho.ForeColor = Color.Red
            End If

            If Trim(cbGenero.Text) = "" Or cbGenero.Text <> "Masculino" And cbGenero.Text <> "Feminino" And cbGenero.Text <> "Unissex" Then
                valido = False
                lbGenero.ForeColor = Color.Red
            End If

            If Trim(txQuantidade.Text) = "" Then
                valido = False
                lbQuantidade.ForeColor = Color.Red
            End If

            If Trim(cbCategoria.Text) = "" Or cbCategoria.Text <> "Infantil" And cbCategoria.Text <> "Juvenil" And cbCategoria.Text <> "Adulto" Then
                valido = False
                lbCategoria.ForeColor = Color.Red
            End If

            If Trim(txValorCompra.Text) = "" Then
                valido = False
                lbValorCompra.ForeColor = Color.Red
            End If

            If Trim(txTaxa.Text) = "" Then
                valido = False
                lbTaxa.ForeColor = Color.Red
            End If

            If Trim(txValorVenda.Text) = "" Then
                valido = False
                lbValorVenda.ForeColor = Color.Red
            End If

            If lbFornecedor.ForeColor = Color.Black Or Trim(cbFornecedor.Text) = "" Then
                Dim res As Boolean = False
                If cbFornecedor.Text <> "" Then

                    For Each Item In cbFornecedor.Items
                        If Item = Trim(cbFornecedor.ValueMember) Then
                            res = True
                            Exit For
                        End If
                    Next
                End If
                If res = False Then
                    lbFornecedor.ForeColor = Color.Red
                    valido = False
                End If
            End If

            If valido = True Then
                Try
                    Abrir()
                    Dim reader As MySqlDataReader
                    Dim sql As String = ""
                    Dim cmd As MySqlCommand

                    sql = "SELECT ID_PRODUTO FROM PRODUTOS WHERE ID_PRODUTO = '" & txCodigo.Text & "' "

                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader()

                    If reader.Read And edit = False Then
                        reader.Close()
                        MsgBox("Esse Código já está cadastrado!", MsgBoxStyle.Exclamation)
                        txCodigo.Focus()
                        Fechar()
                        Exit Sub
                    End If
                    reader.Close()


                    If edit = False Then
                        sql = "INSERT INTO PRODUTOS (ID_PRODUTO, DESCRICAO, TAMANHO, CATEGORIA, GENERO, VALOR_COMPRA, VALOR_VENDA, QUANTIDADE, TAXA, TECIDO, DATA_CADASTRO, FORNECEDOR_ID) VALUES ('" & txCodigo.Text & "', '" & Trim(txDescricao.Text) & "', '" & Trim(txTamanho.Text) & "', '" & cbCategoria.Text & "', '" & cbGenero.Text & "', '" & Trim(txValorCompra.Text) & "', '" & Trim(txValorVenda.Text) & "', '" & Trim(txQuantidade.Text) & "', '" & Trim(txTaxa.Text) & "', '" & Trim(txTecido.Text) & "', (SELECT CURRENT_DATE()),  '" & cbFornecedor.SelectedValue & "')"
                    Else
                        sql = "UPDATE PRODUTOS SET DESCRICAO = '" & Trim(txDescricao.Text) & "', TAMANHO = '" & Trim(txTamanho.Text) & "', CATEGORIA = '" & cbCategoria.Text & "', GENERO =  '" & cbGenero.Text & "', VALOR_COMPRA = '" & Trim(txValorCompra.Text) & "', VALOR_VENDA = '" & Trim(txValorVenda.Text) & "',  QUANTIDADE = '" & Trim(txQuantidade.Text) & "', TAXA = '" & Trim(txTaxa.Text) & "', TECIDO = '" & Trim(txTecido.Text) & "', DATA_CADASTRO = (SELECT CURRENT_DATE()), FORNECEDOR_ID = '" & cbFornecedor.SelectedValue & "' WHERE ID_PRODUTO = '" & txCodigo.Text & "' "

                    End If

                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Listar()
                    Fechar()
                    LimparCampos()

                    If edit = False Then
                        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Cadastro atualiado com sucesso!", MsgBoxStyle.Information)
                        edit = False
                    End If

                    gbDadosProduto.Enabled = False

                Catch ex As Exception
                    MsgBox("Falha ao realizar cadastro! ", MsgBoxStyle.Exclamation + ex.Message)
                End Try

            Else
                MsgBox("Preencha os campos obrigatórios! ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub TxQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQuantidade.KeyPress

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txTecido.Focus()
        End If

    End Sub


    Private Sub TxValorCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txValorCompra.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
            Exit Sub
        End If

        If e.KeyChar = "," Then
            Dim i As Integer
            For i = 0 To Len(txValorCompra.Text) - 1
                If txValorCompra.Text.Substring(i, 1) = "," Then
                    e.KeyChar = ""
                    Exit Sub
                End If
            Next i
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txTaxa.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub TxTaxa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txTaxa.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
            Exit Sub
        End If

        If e.KeyChar = "," Then
            Dim i As Integer
            For i = 0 To Len(txTaxa.Text) - 1
                If txTaxa.Text.Substring(i, 1) = "," Then
                    e.KeyChar = ""
                    Exit Sub
                End If
            Next i
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txValorVenda.Focus()
        End If
    End Sub

    Private Sub TxValorVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txValorVenda.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
            Exit Sub
        End If

        If e.KeyChar = "," Then
            Dim i As Integer
            For i = 0 To Len(txValorVenda.Text) - 1
                If txValorVenda.Text.Substring(i, 1) = "," Then
                    e.KeyChar = ""
                    Exit Sub
                End If
            Next i
            Exit Sub
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            cbFornecedor.Focus()
        End If
    End Sub

    Private Sub TxTaxa_TextChanged(sender As Object, e As EventArgs) Handles txTaxa.TextChanged

        If txTaxa.Text <> "" And txValorCompra.Text <> "" Then
            Dim vcompra As Decimal = Convert.ToDecimal(txValorCompra.Text)
            Dim tx As Decimal = Convert.ToDecimal(txTaxa.Text)

            txValorVenda.Text = (((tx / 100) * vcompra) + vcompra)
        End If
    End Sub

    Private Sub RbDescricao_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescricao.CheckedChanged
        If rbDescricao.Checked Then
            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False

            cbBuscar.Visible = False
            cbBuscar.Enabled = False

            txBuscar.Visible = True
            txBuscar.Enabled = True
            txBuscar.Text = ""
            txBuscar.Focus()

            Listar()
        End If
    End Sub

    Private Sub CarregarCb(Tipo As String)
        dtBuscarData1.Visible = False
        dtBuscarData1.Enabled = False
        dtBuscarData2.Visible = False
        dtBuscarData2.Enabled = False

        cbBuscar.Visible = True
        cbBuscar.Enabled = True
        cbBuscar.DisplayMember = ""
        cbBuscar.Text = ""
        cbBuscar.Focus()

        txBuscar.Visible = False
        txBuscar.Enabled = False

        Abrir()
        Dim sql As String
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable

        If Tipo = "Tam" Then
            sql = "SELECT TAMANHO FROM PRODUTOS GROUP BY TAMANHO ORDER BY TAMANHO"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cbBuscar.DataSource = dt

            If dt.Rows.Count > 0 Then
                cbBuscar.DisplayMember = "TAMANHO"
                cbBuscar.ValueMember = "TAMANHO"
            Else
                cbBuscar.Text = "Cadastre um produto..."
            End If
            cbBuscar.Text = ""

            Fechar()
            Exit Sub
        End If


        If Tipo = "Tec" Then
            sql = "SELECT TECIDO FROM PRODUTOS GROUP BY TECIDO ORDER BY TECIDO"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cbBuscar.DataSource = dt

            If dt.Rows.Count > 0 Then
                cbBuscar.DisplayMember = "TECIDO"
                cbBuscar.ValueMember = "TECIDO"
            Else
                cbBuscar.Text = "Cadastre um produto..."
            End If
            cbBuscar.Text = ""

            Fechar()
            Exit Sub
        End If

        Listar()
        Fechar()
    End Sub

    Private Sub RbTamanho_CheckedChanged(sender As Object, e As EventArgs) Handles rbTamanho.CheckedChanged
        If rbTamanho.Checked Then
            CarregarCb("Tam")
        End If
    End Sub

    Private Sub RbCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbCategoria.CheckedChanged
        If rbCategoria.Checked Then
            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False

            Dim lsGenero As New ArrayList()

            With lsGenero
                .Add("Infantil")
                .Add("Juvenil")
                .Add("Adulto")
            End With

            cbBuscar.DataSource = lsGenero

            cbBuscar.Visible = True
            cbBuscar.Enabled = True
            cbBuscar.Text = ""
            cbBuscar.Focus()

            txBuscar.Visible = False
            txBuscar.Enabled = False

            Listar()
        End If
    End Sub

    Private Sub RbGenero_CheckedChanged(sender As Object, e As EventArgs) Handles rbGenero.CheckedChanged
        If rbGenero.Checked Then
            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False

            Dim lsGenero As New ArrayList()

            With lsGenero
                .Add("Masculino")
                .Add("Feminino")
                .Add("Unissex")
            End With

            cbBuscar.DataSource = lsGenero

            cbBuscar.Visible = True
            cbBuscar.Enabled = True
            cbBuscar.Text = ""
            cbBuscar.Focus()

            txBuscar.Visible = False
            txBuscar.Enabled = False

            Listar()
        End If
    End Sub

    Private Sub RbTecido_CheckedChanged(sender As Object, e As EventArgs) Handles rbTecido.CheckedChanged
        If rbTecido.Checked Then
            CarregarCb("Tec")
        End If
    End Sub

    Private Sub RbDataCadastro_CheckedChanged(sender As Object, e As EventArgs) Handles rbDataCadastro.CheckedChanged
        If rbDataCadastro.Checked Then
            dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
            dtBuscarData2.Visible = True
            dtBuscarData2.Enabled = True

            dtBuscarData1.Value = dtBuscarData2.Value.AddMonths(-1)
            dtBuscarData1.Visible = True
            dtBuscarData1.Enabled = True
            dtBuscarData1.Focus()

            cbBuscar.Visible = False
            cbBuscar.Enabled = False

            txBuscar.Visible = False
            txBuscar.Enabled = False
            txBuscar.Text = ""

            Listar()
        End If
    End Sub

    Private Sub TxDescricao_Enter(sender As Object, e As EventArgs) Handles txDescricao.Enter
        lbDescricao.ForeColor = Color.Black
    End Sub

    Private Sub TxTamanho_Enter(sender As Object, e As EventArgs) Handles txTamanho.Enter
        lbTamanho.ForeColor = Color.Black
    End Sub

    Private Sub CbGenero_Enter(sender As Object, e As EventArgs) Handles cbGenero.Enter
        lbGenero.ForeColor = Color.Black
    End Sub

    Private Sub TxQuantidade_Enter(sender As Object, e As EventArgs) Handles txQuantidade.Enter
        lbQuantidade.ForeColor = Color.Black
    End Sub

    Private Sub CbCategoria_Enter(sender As Object, e As EventArgs) Handles cbCategoria.Enter
        lbCategoria.ForeColor = Color.Black
    End Sub

    Private Sub TxTaxa_Enter(sender As Object, e As EventArgs) Handles txTaxa.Enter
        lbTaxa.ForeColor = Color.Black
    End Sub

    Private Sub TxValorCompra_Enter(sender As Object, e As EventArgs) Handles txValorCompra.Enter
        lbValorCompra.ForeColor = Color.Black
    End Sub

    Private Sub TxValorVenda_Enter(sender As Object, e As EventArgs) Handles txValorVenda.Enter
        lbValorVenda.ForeColor = Color.Black
    End Sub

    Private Sub PreencherCampos()
        txCodigo.Text = dgProduto.CurrentRow.Cells(0).Value
        txDescricao.Text = dgProduto.CurrentRow.Cells(1).Value
        txTamanho.Text = dgProduto.CurrentRow.Cells(2).Value
        txQuantidade.Text = dgProduto.CurrentRow.Cells(3).Value
        cbGenero.Text = dgProduto.CurrentRow.Cells(4).Value
        cbCategoria.Text = dgProduto.CurrentRow.Cells(5).Value
        txTecido.Text = dgProduto.CurrentRow.Cells(6).Value
        cbFornecedor.Text = dgProduto.CurrentRow.Cells(7).Value
        txValorCompra.Text = dgProduto.CurrentRow.Cells(8).Value
        txTaxa.Text = dgProduto.CurrentRow.Cells(9).Value
        txValorVenda.Text = dgProduto.CurrentRow.Cells(10).Value

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If dgProduto.Rows.Count > 0 Then
            gbDadosProduto.Enabled = True
            PreencherCampos()
            edit = True
        Else
            MsgBox("Impossível editar. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DgProduto_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgProduto.CellEnter
        If dgProduto.Rows.Count > 0 Then
            LimparCampos()
            txCodigo.Text = dgProduto.CurrentRow.Cells(0).Value
            gbDadosProduto.Enabled = False
        End If
    End Sub

    Private Sub BtRemover_Click(sender As Object, e As EventArgs) Handles btRemover.Click
        edit = False

        If dgProduto.Rows.Count > 0 And dgProduto.SelectedRows.Count = 1 Then
            Dim sql As String
            Dim cmd As MySqlCommand

            Dim decisao As String

            decisao = MsgBox("Deseja excluir este registro?", MsgBoxStyle.YesNo)

            If decisao = "6" Then

                Abrir()

                sql = "DELETE FROM PRODUTOS WHERE ID_PRODUTO =  '" & txCodigo.Text & "' "
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

    Private Sub Buscar()
        Try
            Abrir()
            Dim sql As String = ""
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If rbDescricao.Checked Then
                sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE DESCRICAO LIKE '" & txBuscar.Text & "%' ORDER BY P.DESCRICAO"
            End If

            If rbTamanho.Checked Then
                sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE TAMANHO = '" & cbBuscar.Text & "' ORDER BY P.DESCRICAO"
            End If

            If rbDataCadastro.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE P.DATA_CADASTRO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "' ORDER BY P.DESCRICAO"
                Else
                    sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE P.DATA_CADASTRO BETWEEN '" & dtBuscarData2.Text & "' AND  '" & dtBuscarData1.Text & "' ORDER BY P.DESCRICAO"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If

            If rbCategoria.Checked Then
                sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE CATEGORIA = '" & cbBuscar.Text & "' ORDER BY P.DESCRICAO"
            End If

            If rbGenero.Checked Then
                sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE GENERO = '" & cbBuscar.Text & "' ORDER BY P.DESCRICAO"
            End If

            If rbTecido.Checked Then
                sql = "SELECT P.ID_PRODUTO, P.DESCRICAO, P.TAMANHO, P.QUANTIDADE, P.GENERO, P.CATEGORIA, P.TECIDO, F.DENOMINACAO_SOCIAL, P.VALOR_COMPRA, P.TAXA, P.VALOR_VENDA, P.DATA_CADASTRO FROM PRODUTOS AS P INNER JOIN FORNECEDORES AS F ON F.ID_FORNECEDOR = P.FORNECEDOR_ID WHERE TECIDO = '" & cbBuscar.Text & "' ORDER BY P.DESCRICAO"
            End If

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgProduto.DataSource = dt

            If dgProduto.Rows.Count > 0 Then
                FormatarDg()
            End If

            Fechar()

        Catch ex As Exception
            MsgBox("Erro ao buscar registros! erro", MsgBoxStyle.Information + ex.Message)
        End Try

        Fechar()
    End Sub

    Private Sub TxBuscar_TextChanged(sender As Object, e As EventArgs) Handles txBuscar.TextChanged
        If txBuscar.Text <> "" Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub CbBuscar_TextChanged(sender As Object, e As EventArgs) Handles cbBuscar.TextChanged
        If cbBuscar.Text <> "" And cbBuscar.DisplayMember.Count > 0 Or cbBuscar.Items.Count > 0 Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub DtBuscarData1_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData1.ValueChanged
        If rbDataCadastro.Checked Then
            Buscar()
        End If
    End Sub

    Private Sub DtBuscarData2_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData2.ValueChanged
        If rbDataCadastro.Checked Then
            Buscar()
        End If
    End Sub

    Private Sub BtVerTodos_Click(sender As Object, e As EventArgs) Handles btVerTodos.Click
        Listar()
    End Sub

    Private Sub TxDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDescricao.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txTamanho.Focus()
        End If
    End Sub

    Private Sub TxTamanho_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txTamanho.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cbGenero.Focus()
        End If
    End Sub

    Private Sub CbGenero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbGenero.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txQuantidade.Focus()
        End If
    End Sub

    Private Sub TxTecido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txTecido.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cbCategoria.Focus()
        End If
    End Sub

    Private Sub CbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCategoria.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txValorCompra.Focus()
        End If
    End Sub

    Private Sub CbFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFornecedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btSalvar.PerformClick()
        End If
    End Sub

    Private Sub DgProduto_DoubleClick(sender As Object, e As EventArgs) Handles dgProduto.DoubleClick
        If Frm_Venda.vBusca Then
            Frm_Venda.txCodigo.Text = dgProduto.CurrentRow.Cells(0).Value
            Frm_Venda.vBusca = False
            Frm_Venda.btAdd.Focus()
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Frm_TelaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub ckMostrarZerados_CheckedChanged(sender As Object, e As EventArgs) Handles ckMostrarZerados.CheckedChanged
        Listar()
        Buscar()
    End Sub

    Private Sub txCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodigo.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub

End Class
