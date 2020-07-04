Imports MySql.Data.MySqlClient

Public Class Frm_CadCliente

    Private Sub FormatarDg()

        dgCliente.Font = New Font("Microsoft Sans Serif", 11)

        dgCliente.Columns(0).HeaderText = "Id"
        dgCliente.Columns(1).HeaderText = "Nome"
        dgCliente.Columns(2).HeaderText = "CPF"
        dgCliente.Columns(3).HeaderText = "Data de Nascimento"
        dgCliente.Columns(4).HeaderText = "Cidade"
        dgCliente.Columns(5).HeaderText = "Celular 1"
        dgCliente.Columns(6).HeaderText = "Endereço"
        dgCliente.Columns(7).HeaderText = "Nº"
        dgCliente.Columns(8).HeaderText = "Telefone"
        dgCliente.Columns(9).HeaderText = "Celular 2"
        dgCliente.Columns(10).HeaderText = "Observações"
        dgCliente.Columns(11).HeaderText = "Data do cadastro"

        dgCliente.Columns(7).Visible = False
        dgCliente.Columns(8).Visible = False
        dgCliente.Columns(9).Visible = False
        dgCliente.Columns(10).Visible = False
        dgCliente.Columns(11).Visible = False

        dgCliente.Columns(0).Width = 50
        dgCliente.Columns(1).Width = 300
        dgCliente.Columns(2).Width = 150
        dgCliente.Columns(3).Width = 100
        dgCliente.Columns(4).Width = 200
        dgCliente.Columns(5).Width = 130
        dgCliente.Columns(6).Width = 311

    End Sub
    Sub ContarRegistros()
        lbN.Text = dgCliente.Rows.Count
    End Sub

    Private Sub Listar()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT ID_CLIENTE, 
                        NOME, 
                        CPF,  
                        DATA_NASCIMENTO,
                        CIDADE, 
                        CELULAR1, 
                        ENDERECO,
                        NUM_CASA,
                        TELEFONE,
                        CELULAR2,
                        OBSERVACAO,
                        DATA_CADASTRO
                        FROM CLIENTES 
                        WHERE ID_CLIENTE >= 1
                        ORDER BY NOME"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            dgCliente.DataSource = dt

            Fechar()

            If dgCliente.Rows.Count > 0 Then
                FormatarDg()
            End If

            ContarRegistros()
        Catch ex As Exception
            MsgBox("Não foi possivel extrair dados do banco! Erro: " + ex.Message, MsgBoxStyle.Information)
        End Try

        Fechar()
    End Sub


    Private Sub LimparCampos()
        txIdCliente.Text = ""
        txNome.Text = ""
        txCpf.Text = ""
        txTelefone.Text = ""
        txDataNascimento.Text = ""
        txCelular1.Text = ""
        txCelular2.Text = ""
        cbCidade.Text = ""
        txEndereco.Text = ""
        txNumero.Text = ""
        txObs.Text = ""
    End Sub

    Private Sub AtivarTxBuscar()
        txBuscar.Visible = True
        txBuscar.Enabled = True
        txBuscar.Text = ""
        txBuscar.Focus()

        txBuscarCpf.Visible = False
        txBuscarCpf.Enabled = False

        dtBuscarData1.Visible = False
        dtBuscarData1.Enabled = False

        dtBuscarData2.Visible = False
        dtBuscarData2.Enabled = False

        lbEntre.Visible = False
        lbE.Visible = False
    End Sub

    Sub PreencherCampos()
        If dgCliente.Rows.Count > 0 Then
            txIdCliente.Text = dgCliente.CurrentRow.Cells(0).Value
            txNome.Text = dgCliente.CurrentRow.Cells(1).Value
            txCpf.Text = dgCliente.CurrentRow.Cells(2).Value
            txDataNascimento.Text = dgCliente.CurrentRow.Cells(3).Value
            cbCidade.Text = dgCliente.CurrentRow.Cells(4).Value
            txCelular1.Text = dgCliente.CurrentRow.Cells(5).Value
            txEndereco.Text = dgCliente.CurrentRow.Cells(6).Value
            txNumero.Text = dgCliente.CurrentRow.Cells(7).Value
            txTelefone.Text = dgCliente.CurrentRow.Cells(8).Value
            txCelular2.Text = dgCliente.CurrentRow.Cells(9).Value
            txObs.Text = dgCliente.CurrentRow.Cells(10).Value
        End If
    End Sub

    Private Sub TxNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNumero.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
            Exit Sub
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txObs.Focus()
        End If
    End Sub

    Private Sub Buscar()
        Try
            Abrir()
            Dim sql As String = ""
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If rbNome.Checked Then
                sql = "SELECT ID_CLIENTE, NOME, CPF,  DATA_NASCIMENTO, CIDADE, CELULAR1, ENDERECO, NUM_CASA, TELEFONE, CELULAR2, OBSERVACAO, DATA_CADASTRO FROM CLIENTES WHERE NOME LIKE '" & txBuscar.Text & "%'  ORDER BY NOME"
            End If

            If rbCpf.Checked Then
                sql = "SELECT ID_CLIENTE, NOME, CPF,  DATA_NASCIMENTO, CIDADE, CELULAR1, ENDERECO, NUM_CASA, TELEFONE, CELULAR2, OBSERVACAO, DATA_CADASTRO FROM CLIENTES WHERE CPF = '" & txBuscarCpf.Text & "'  ORDER BY NOME"
            End If

            If rbDataCadastro.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT ID_CLIENTE, NOME, CPF,  DATA_NASCIMENTO, CIDADE, CELULAR1, ENDERECO, NUM_CASA, TELEFONE, CELULAR2, OBSERVACAO, DATA_CADASTRO FROM CLIENTES WHERE DATA_CADASTRO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "' ORDER BY NOME"
                Else
                    sql = "SELECT ID_CLIENTE, NOME, CPF,  DATA_NASCIMENTO, CIDADE, CELULAR1, ENDERECO, NUM_CASA, TELEFONE, CELULAR2, OBSERVACAO, DATA_CADASTRO FROM CLIENTES WHERE DATA_CADASTRO BETWEEN '" & dtBuscarData2.Text & "' AND '" & dtBuscarData1.Text & "' ORDER BY NOME"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                    dtBuscarData2.CustomFormat = "dd/MM/yyyy"
                End If

            If rbCidade.Checked Then
                sql = "SELECT ID_CLIENTE, NOME, CPF,  DATA_NASCIMENTO, CIDADE, CELULAR1, ENDERECO, NUM_CASA, TELEFONE, CELULAR1, OBSERVACAO, DATA_CADASTRO FROM CLIENTES WHERE CIDADE LIKE '" & txBuscar.Text & "%'  ORDER BY NOME"
            End If

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCliente.DataSource = dt

            If dgCliente.Rows.Count > 0 Then
                FormatarDg()
            End If

            Fechar()

        Catch ex As Exception
            MsgBox("Erro ao buscar registros! erro", MsgBoxStyle.Information + ex.Message)
        End Try

        Fechar()
    End Sub

    Private Sub TxCelular1_Enter(sender As Object, e As EventArgs) Handles txCelular1.Enter
        lbCelular1.ForeColor = Color.Black
    End Sub

    Private Sub Frm_CadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If dgCliente.Rows.Count > 0 Then
            gbDadosCliente.Enabled = False
            Listar()
            txBuscar.Focus()
            FormatarDg()
        Else
            MsgBox("Impossível editar. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TxNome_Enter(sender As Object, e As EventArgs) Handles txNome.Enter
        lbNome.ForeColor = Color.Black
    End Sub

    Private Sub TxCpf_Enter(sender As Object, e As EventArgs) Handles txCpf.Enter
        lbCpf.ForeColor = Color.Black
    End Sub

    Private Sub TxDataNascimento_Enter(sender As Object, e As EventArgs) Handles txDataNascimento.Enter
        lbDataNascimento.ForeColor = Color.Black
    End Sub

    Private Sub CbCidade_Enter(sender As Object, e As EventArgs) Handles cbCidade.Enter
        lbCidade.ForeColor = Color.Black
    End Sub

    Private Sub TxEndereco_Enter(sender As Object, e As EventArgs) Handles txEndereco.Enter
        lbEndereco.ForeColor = Color.Black
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        gbDadosCliente.Enabled = True
        limparCampos()
        edit = False
        txNome.Focus()
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If gbDadosCliente.Enabled Then

            Dim valido As Boolean = True

            If Trim(txNome.Text) = "" Then
                lbNome.ForeColor = Color.Red
                valido = False
            End If

            If Len(Trim(txCpf.Text)) < 14 Then
                lbCpf.ForeColor = Color.Red
                valido = False
            End If

            If Len(Trim(txDataNascimento.Text)) < 10 Then
                lbDataNascimento.ForeColor = Color.Red
                valido = False
            End If

            If Len(Trim(txCelular1.Text)) < 13 Then
                lbCelular1.ForeColor = Color.Red
                valido = False
            End If

            If lbCidade.ForeColor = Color.Black Or Trim(cbCidade.Text) = "" Then
                Dim res As Boolean = False

                For Each Item In cbCidade.Items
                    If Item = Trim(cbCidade.Text) Then
                        res = True
                        Exit For
                    End If
                Next
                If res = False Then
                    lbCidade.ForeColor = Color.Red
                    valido = False
                End If
            End If

            If Trim(txEndereco.Text) = "" Then
                lbEndereco.ForeColor = Color.Red
                valido = False
            End If


            If valido = True Then
                Try
                    Abrir()
                    Dim reader As MySqlDataReader
                    Dim sql As String
                    Dim cmd As MySqlCommand

                    sql = "SELECT CPF FROM CLIENTES WHERE CPF = '" & txCpf.Text & "' AND ID_CLIENTE <> '" & txIdCliente.Text & "' "

                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader()

                    If reader.Read Then
                        reader.Close()
                        MsgBox("Esse CPF já está cadastrado!", MsgBoxStyle.Exclamation)
                        txCpf.Focus()
                        Fechar()
                        Exit Sub
                    End If
                    reader.Close()

                    If edit = False Then
                        sql = "INSERT INTO CLIENTES(NOME, DATA_NASCIMENTO, CPF, CIDADE, CELULAR1, ENDERECO, NUM_CASA, TELEFONE, CELULAR2, OBSERVACAO, DATA_CADASTRO) VALUES ('" & Trim(txNome.Text) & "', '" & txDataNascimento.Text & "', '" & txCpf.Text & "', '" & Trim(cbCidade.Text) & "', '" & txCelular1.Text & "', '" & Trim(txEndereco.Text) & "', '" & Trim(txNumero.Text) & "', '" & txTelefone.Text & "', '" & txCelular2.Text & "', '" & Trim(txObs.Text) & "', (SELECT CURRENT_DATE()) ) "
                    Else
                        sql = "UPDATE CLIENTES SET NOME = '" & Trim(txNome.Text) & "', DATA_NASCIMENTO = '" & txDataNascimento.Text & "', CPF = '" & txCpf.Text & "', CIDADE =  '" & Trim(cbCidade.Text) & "', CELULAR1 = '" & txCelular1.Text & "', ENDERECO =  '" & Trim(txEndereco.Text) & "', NUM_CASA  = '" & Trim(txNumero.Text) & "', TELEFONE = '" & txTelefone.Text & "', CELULAR2 =  '" & txCelular2.Text & "', OBSERVACAO =   '" & Trim(txObs.Text) & "' WHERE ID_CLIENTE = '" & txIdCliente.Text & "'"
                    End If

                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Listar()

                    Fechar()

                    If edit = False Then
                        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information)
                        LimparCampos()
                    Else
                        MsgBox("Cadastro atualiado com sucesso!", MsgBoxStyle.Information)
                        edit = False
                    End If

                    gbDadosCliente.Enabled = False

                Catch ex As Exception
                    MsgBox("Falha ao realizar cadastro! ", MsgBoxStyle.Exclamation + ex.Message)
                End Try

            Else
                MsgBox("Preencha os campos obrigatórios! ", MsgBoxStyle.Exclamation)
            End If

            Fechar()
        End If
    End Sub

    Public edit As Boolean = False

    Private Sub BtEditar_Click_1(sender As Object, e As EventArgs) Handles btEditar.Click
        gbDadosCliente.Enabled = True
        PreencherCampos()
        edit = True
    End Sub

    Private Sub BtRemover_Click_1(sender As Object, e As EventArgs) Handles btRemover.Click
        edit = False

        If dgCliente.Rows.Count > 0 Then
            Dim sql As String
            Dim cmd As MySqlCommand

            Dim decisao As String

            decisao = MsgBox("Deseja excluir este registro?", MsgBoxStyle.YesNo)

            If decisao = "6" Then

                Abrir()

                sql = "DELETE FROM CLIENTES WHERE ID_CLIENTE =  '" & txIdCliente.Text & "' "
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

    Private Sub RbNome_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        If rbNome.Enabled Then
            AtivarTxBuscar()
            Listar()
        End If
    End Sub

    Private Sub RbCpf_CheckedChanged(sender As Object, e As EventArgs) Handles rbCpf.CheckedChanged
        If rbCpf.Checked Then
            txBuscar.Visible = False
            txBuscar.Enabled = False

            txBuscarCpf.Visible = True
            txBuscarCpf.Enabled = True
            txBuscarCpf.Text = ""
            txBuscarCpf.Focus()

            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False

            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False

            lbEntre.Visible = False
            lbE.Visible = False

            Listar()
        End If
    End Sub

    Private Sub RbDataCadastro_CheckedChanged(sender As Object, e As EventArgs) Handles rbDataCadastro.CheckedChanged
        If rbDataCadastro.Checked Then
            txBuscar.Visible = False
            txBuscar.Enabled = False

            txBuscarCpf.Visible = False
            txBuscarCpf.Enabled = False

            dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
            dtBuscarData2.Visible = True
            dtBuscarData2.Enabled = True

            dtBuscarData1.Value = dtBuscarData2.Value.AddMonths(-1)
            dtBuscarData1.Visible = True
            dtBuscarData1.Enabled = True
            dtBuscarData1.Focus()

            lbEntre.Visible = True
            lbE.Visible = True

            Listar()
        End If
    End Sub

    Private Sub RbCidade_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbCidade.CheckedChanged
        If rbCidade.Checked Then
            AtivarTxBuscar()
            Listar()
        End If
    End Sub

    Private Sub TxBuscarCpf_TextChanged(sender As Object, e As EventArgs) Handles txBuscarCpf.TextChanged
        If Len(txBuscarCpf.Text) = 14 Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub BtVerTodos_Click(sender As Object, e As EventArgs) Handles btVerTodos.Click
        Listar()
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

    Private Sub DgCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgCliente.KeyPress

        If e.KeyChar = ChrW(Keys.Delete) Or e.KeyChar = "x" Then
            e.KeyChar = ""
            btRemover.PerformClick()
            Exit Sub
        End If

        If e.KeyChar = "a" Then
            e.KeyChar = ""
            btNovo.PerformClick()
            Exit Sub
        End If

        If e.KeyChar = "e" Then
            e.KeyChar = ""
            btEditar.PerformClick()
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Escape) Then
            e.KeyChar = ""
            btHome.PerformClick()
            Exit Sub
        End If

    End Sub

    Private Sub TxNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNome.KeyPress

        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If InStr("abcdefghijklmnopqrstuvwxyz´^~", e.KeyChar) And Len(txNome.Text) > 0 Then
            If txNome.Text.Substring(Len(txNome.Text) - 1) = " " Then
                e.KeyChar = UCase(e.KeyChar)
            End If
        Else
            If txNome.Text = "" Then
                e.KeyChar = UCase(e.KeyChar)
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txCpf.Focus()
        End If
    End Sub

    Private Sub TxCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCpf.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txTelefone.Focus()
        End If
    End Sub

    Private Sub TxTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txTelefone.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txDataNascimento.Focus()
        End If
    End Sub

    Private Sub TxDataNascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDataNascimento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txCelular1.Focus()
        End If
    End Sub

    Private Sub TxCelular1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCelular1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txCelular2.Focus()
        End If
    End Sub

    Private Sub TxCelular2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCelular2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cbCidade.Focus()
        End If
    End Sub

    Private Sub CbCidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCidade.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txEndereco.Focus()
        End If
    End Sub

    Private Sub TxEndereco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEndereco.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txNumero.Focus()
        End If
    End Sub

    Private Sub TxObs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txObs.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.KeyChar = ""
            btSalvar.PerformClick()
        End If
    End Sub

    Private Sub DgCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellDoubleClick

        Try
            If Frm_Promissorias.busca Then
                Frm_Promissorias.txIdCliente.Text = dgCliente.CurrentRow.Cells(0).Value
                Frm_Promissorias.txCliente.Text = dgCliente.CurrentRow.Cells(1).Value

                Frm_Promissorias.busca = False
                Frm_Promissorias.txValor.Focus()
                Me.Close()
                Exit Sub
            End If


            If Frm_Venda.vBusca Then
                Frm_Venda.txIdCliente.Text = dgCliente.CurrentRow.Cells(0).Value
                Frm_Venda.txCliente.Text = dgCliente.CurrentRow.Cells(1).Value

                Frm_Venda.vBusca = False
                Frm_Venda.txJuros.Focus()
                Frm_Venda.Show()
                Me.Close()
                Exit Sub
            End If
        Catch ex As Exception
            Frm_Venda.vBusca = False
        End Try

        If Frm_ClienteDetalhes.WindowState = False Then
            Frm_ClienteDetalhes.ShowDialog()
        End If
    End Sub

    Private Sub TxBuscar_TextChanged(sender As Object, e As EventArgs) Handles txBuscar.TextChanged
        If Trim(txBuscar.Text) <> "" Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Frm_TelaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub dgCliente_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellEnter
        txIdCliente.Text = dgCliente.CurrentRow.Cells(0).Value
        'gbDadosCliente.Enabled = False
        'LimparCampos()
    End Sub
End Class