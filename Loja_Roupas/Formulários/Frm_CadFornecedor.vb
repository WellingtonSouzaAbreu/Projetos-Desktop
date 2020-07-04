Imports MySql.Data.MySqlClient

Public Class Frm_CadFornecedor
    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        gbDadosFornecedor.Enabled = True
        edit = False
        LimparCampos()

    End Sub

    Private Sub BuscarTxt()

        txBuscarCnpj.Enabled = False
        txBuscarCnpj.Visible = False

        dtBuscarData1.Enabled = False
        dtBuscarData1.Visible = False
        dtBuscarData2.Enabled = False
        dtBuscarData2.Visible = False
        lbEntre.Visible = False
        lbE.Visible = False

        txBuscar.Enabled = True
        txBuscar.Visible = True
        txBuscar.Text = ""
        txBuscar.Focus()

        Listar()
    End Sub

    Private Sub RbDenominacaoSocial_CheckedChanged(sender As Object, e As EventArgs) Handles rbDenominacaoSocial.CheckedChanged
        If rbDenominacaoSocial.Enabled Then
            BuscarTxt()
        End If
        Listar()
    End Sub

    Private Sub RbCnpj_CheckedChanged(sender As Object, e As EventArgs) Handles rbCnpj.CheckedChanged
        If rbCnpj.Enabled Then
            txBuscar.Enabled = False
            txBuscar.Visible = False

            dtBuscarData1.Enabled = False
            dtBuscarData1.Visible = False
            dtBuscarData2.Enabled = False
            dtBuscarData2.Visible = False

            lbEntre.Visible = False
            lbE.Visible = False

            txBuscarCnpj.Enabled = True
            txBuscarCnpj.Visible = True
            txBuscarCnpj.Text = ""
            txBuscarCnpj.Focus()
        End If

        Listar()
    End Sub

    Private Sub RbDataNascimento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDataCadastro.CheckedChanged
        If rbDataCadastro.Enabled Then
            txBuscar.Enabled = False
            txBuscar.Visible = False

            txBuscarCnpj.Enabled = False
            txBuscarCnpj.Visible = False

            dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
            dtBuscarData2.Visible = True
            dtBuscarData2.Enabled = True

            dtBuscarData1.Value = dtBuscarData2.Value.AddMonths(-1)
            dtBuscarData1.Visible = True
            dtBuscarData1.Enabled = True
            dtBuscarData1.Focus()

            lbEntre.Visible = True
            lbE.Visible = True
        End If

        Listar()
    End Sub

    Private Sub RbCidade_CheckedChanged(sender As Object, e As EventArgs) Handles rbCidade.CheckedChanged
        If rbCidade.Enabled Then
            BuscarTxt()
        End If
    End Sub

    Private Sub LimparCampos()
        txIdFornecedor.Text = ""
        txDenominacaoSocial.Text = ""
        txEndereco.Text = ""
        txNumero.Text = ""
        cbCidade.Text = ""
        cbUf.Text = ""
        txCnpj.Text = ""
        txTelefone.Text = ""
        txCelular1.Text = ""
        txCelular2.Text = ""
        txEmail.Text = ""
        txObs.Text = ""
    End Sub

    Private Sub FormatarDg()
        dgFornecedor.Font = New Font("Microsoft Sans Serif", 11)

        dgFornecedor.Columns(0).HeaderText = "ID"
        dgFornecedor.Columns(1).HeaderText = "DENOMINAÇÃO SOCIAL"
        dgFornecedor.Columns(2).HeaderText = "CNPJ"
        dgFornecedor.Columns(3).HeaderText = "TELEFONE"
        dgFornecedor.Columns(4).HeaderText = "CELULAR 1"
        dgFornecedor.Columns(5).HeaderText = "EMAIL"
        dgFornecedor.Columns(6).HeaderText = "CIDADE"
        dgFornecedor.Columns(7).HeaderText = "UF"
        dgFornecedor.Columns(8).HeaderText = "ENDEREÇO"
        dgFornecedor.Columns(9).HeaderText = "Nº"
        dgFornecedor.Columns(10).HeaderText = "CELULAR 2"
        dgFornecedor.Columns(11).HeaderText = "OBSERVAÇÕES"
        'dgFornecedor.Columns(12).HeaderText = "Data do cadastro"

        dgFornecedor.Columns(7).Visible = False
        dgFornecedor.Columns(8).Visible = False
        dgFornecedor.Columns(9).Visible = False
        dgFornecedor.Columns(10).Visible = False
        dgFornecedor.Columns(11).Visible = False
        ' dgFornecedor.Columns(12).Visible = False

        dgFornecedor.Columns(0).Width = 50
        dgFornecedor.Columns(1).Width = 300
        dgFornecedor.Columns(2).Width = 170
        dgFornecedor.Columns(3).Width = 130
        dgFornecedor.Columns(4).Width = 130
        dgFornecedor.Columns(5).Width = 266
        dgFornecedor.Columns(6).Width = 175
    End Sub

    Sub ContarRegistros()
        lbN.Text = dgFornecedor.Rows.Count
    End Sub

    Private Sub Listar()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL, CNPJ, TELEFONE, CELULAR1, EMAIL, CIDADE, UF, ENDERECO, NUMERO, CELULAR2, OBSERVACAO FROM FORNECEDORES ORDER BY DENOMINACAO_SOCIAL"

            da = New MySqlDataAdapter(sql, con)

            da.Fill(dt)

            dgFornecedor.DataSource = dt

            Fechar()

            If dgFornecedor.Rows.Count > 0 Then
                FormatarDg()
            End If

            ContarRegistros()

        Catch ex As Exception
            MsgBox("Não foi possivel extrair dados do banco! Erro: ", MsgBoxStyle.Information)
        End Try

        Fechar()
    End Sub

    Public edit As Boolean = False

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If gbDadosFornecedor.Enabled Then
            Dim valido As Boolean = True

            If Trim(txDenominacaoSocial.Text) = "" Then
                lbDenominacaoSocial.ForeColor = Color.Red
                valido = False
            End If

            If Trim(txEndereco.Text) = "" Then
                lbEndereco.ForeColor = Color.Red
                valido = False
            End If

            'Validação da Cidade
            If lbCidade.ForeColor = Color.Black Or Trim(cbCidade.Text) = "" Then
                Dim res As Boolean = False

                If Trim(cbCidade.Text) = "" Then
                    lbCidade.ForeColor = Color.Red
                    valido = False
                End If
            End If

            'Validação do UF
            If lbUf.ForeColor = Color.Black Or Trim(cbUf.Text) = "" Then
                Dim res As Boolean = False

                For Each Item In cbUf.Items
                    If Item = Trim(cbUf.Text) Then
                        res = True
                    End If
                Next
                If res = False Then
                    lbUf.ForeColor = Color.Red
                    valido = False
                End If
            End If


            If Len(txCnpj.Text) < 18 Then
                lbCnpj.ForeColor = Color.Red
                valido = False
            End If

            If Len(txCelular1.Text) < 13 Then
                lbCelular1.ForeColor = Color.Red
                valido = False
            End If

            If Trim(txEmail.Text) = "" Then
                lbEmail.ForeColor = Color.Red
                valido = False
            End If

            If valido = True Then
                Try
                    Abrir()
                    Dim reader As MySqlDataReader
                    Dim sql As String
                    Dim cmd As MySqlCommand

                    sql = "SELECT CNPJ FROM FORNECEDORES WHERE CNPJ = '" & txCnpj.Text & "' AND ID_FORNECEDOR <> '" & txIdFornecedor.Text & "' "

                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader()

                    If reader.Read Then
                        reader.Close()
                        MsgBox("Esse CNPJ já está cadastrado!", MsgBoxStyle.Exclamation)
                        txCnpj.Focus()
                        Fechar()
                        Exit Sub
                    End If
                    reader.Close()

                    If edit = False Then
                        sql = "INSERT INTO FORNECEDORES (DENOMINACAO_SOCIAL, ENDERECO, NUMERO, CNPJ, CIDADE, UF, TELEFONE, CELULAR1, CELULAR2, OBSERVACAO, EMAIL, DATA_CADASTRO) VALUES ('" & Trim(txDenominacaoSocial.Text) & "' , '" & Trim(txEndereco.Text) & "', '" & Trim(txNumero.Text) & "', '" & txCnpj.Text & "', '" & Trim(cbCidade.Text) & "',  '" & Trim(cbUf.Text) & "', '" & txTelefone.Text & "', '" & txCelular1.Text & "', '" & txCelular2.Text & "', '" & Trim(txObs.Text) & "', '" & Trim(txEmail.Text) & "', (SELECT CURRENT_DATE()) ) "
                    Else
                        sql = "UPDATE FORNECEDORES SET DENOMINACAO_SOCIAL = '" & Trim(txDenominacaoSocial.Text) & "', ENDERECO = '" & Trim(txEndereco.Text) & "', NUMERO = '" & Trim(txNumero.Text) & "', CNPJ = '" & txCnpj.Text & "', CIDADE = '" & Trim(cbCidade.Text) & "', UF = '" & Trim(cbUf.Text) & "', TELEFONE = '" & txTelefone.Text & "', CELULAR1 = '" & txCelular1.Text & "', CELULAR2 = '" & txCelular2.Text & "', OBSERVACAO = '" & Trim(txObs.Text) & "', EMAIL = '" & Trim(txEmail.Text) & "' WHERE ID_FORNECEDOR = '" & txIdFornecedor.Text & "' "

                    End If

                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    listar()

                    Fechar()
                    LimparCampos()

                    If edit = False Then
                        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Cadastro atualiado com sucesso!", MsgBoxStyle.Information)
                        edit = False
                    End If

                    gbDadosFornecedor.Enabled = False

                Catch ex As Exception
                    MsgBox("Falha ao realizar cadastro! ", MsgBoxStyle.Exclamation + ex.Message)
                End Try

            Else
                MsgBox("Preencha os campos obrigatórios! ", MsgBoxStyle.Exclamation)
            End If

            Fechar()
        End If
    End Sub

    Private Sub TxDenominacaoSocial_Enter(sender As Object, e As EventArgs) Handles txDenominacaoSocial.Enter
        lbDenominacaoSocial.ForeColor = Color.Black
    End Sub

    Private Sub TxEndereco_Enter(sender As Object, e As EventArgs) Handles txEndereco.Enter
        lbEndereco.ForeColor = Color.Black
    End Sub

    Private Sub TxCidade_Enter(sender As Object, e As EventArgs)
        lbCidade.ForeColor = Color.Black
    End Sub

    Private Sub TxCnpj_Enter(sender As Object, e As EventArgs) Handles txCnpj.Enter
        lbCnpj.ForeColor = Color.Black
    End Sub

    Private Sub TxCelular1_Enter(sender As Object, e As EventArgs) Handles txCelular1.Enter
        lbCelular1.ForeColor = Color.Black
    End Sub

    Private Sub TxEmail_Enter(sender As Object, e As EventArgs) Handles txEmail.Enter
        lbEmail.ForeColor = Color.Black
    End Sub

    Private Sub TxNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNumero.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            cbCidade.Focus()
        End If
    End Sub

    Private Sub TxDenominacaoSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDenominacaoSocial.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If InStr("abcdefghijklmnopqrstuvwxyz´^~", e.KeyChar) And Len(txDenominacaoSocial.Text) > 0 Then
            If txDenominacaoSocial.Text.Substring(Len(txDenominacaoSocial.Text) - 1) = " " Then
                e.KeyChar = UCase(e.KeyChar)
                Exit Sub
            End If
        Else
            If txDenominacaoSocial.Text = "" Then
                e.KeyChar = UCase(e.KeyChar)
                Exit Sub
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txEndereco.Focus()
        End If
    End Sub

    Private Sub CbCidade_Enter(sender As Object, e As EventArgs) Handles cbCidade.Enter
        lbCidade.ForeColor = Color.Black

        If cidade_full = False Then
            PreencherCidade()
            cidade_full = True
        End If
    End Sub

    Private Sub CbUf_Enter(sender As Object, e As EventArgs) Handles cbUf.Enter
        LbUf.ForeColor = Color.Black
    End Sub

    Private Sub PreencherCampos()

        txIdFornecedor.Text = dgFornecedor.CurrentRow.Cells(0).Value
        txDenominacaoSocial.Text = dgFornecedor.CurrentRow.Cells(1).Value
        txCnpj.Text = dgFornecedor.CurrentRow.Cells(2).Value
        txTelefone.Text = dgFornecedor.CurrentRow.Cells(3).Value
        txCelular1.Text = dgFornecedor.CurrentRow.Cells(4).Value
        txEmail.Text = dgFornecedor.CurrentRow.Cells(5).Value
        cbCidade.Text = dgFornecedor.CurrentRow.Cells(6).Value
        cbUf.Text = dgFornecedor.CurrentRow.Cells(7).Value
        txEndereco.Text = dgFornecedor.CurrentRow.Cells(8).Value
        txNumero.Text = dgFornecedor.CurrentRow.Cells(9).Value
        txCelular2.Text = dgFornecedor.CurrentRow.Cells(10).Value
        txObs.Text = dgFornecedor.CurrentRow.Cells(11).Value

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If dgFornecedor.Rows.Count > 0 Then
            gbDadosFornecedor.Enabled = True
            PreencherCampos()
            edit = True
        Else
            MsgBox("Impossível editar. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Frm_CadFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDadosFornecedor.Enabled = False
        Listar()
        txBuscar.Focus()
        FormatarDg()
    End Sub

    Private Sub BtRemover_Click(sender As Object, e As EventArgs) Handles btRemover.Click
        edit = False

        Try
            If dgFornecedor.Rows.Count > 0 And dgFornecedor.SelectedRows.Count = 1 Then
                Dim sql As String
                Dim cmd As MySqlCommand

                Dim decisao As String

                decisao = MsgBox("Deseja excluir este registro?", MsgBoxStyle.YesNo)

                If decisao = "6" Then

                    Abrir()

                    sql = "DELETE FROM FORNECEDORES WHERE ID_FORNECEDOR =  '" & txIdFornecedor.Text & "' "
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
        Catch ex As Exception
            Fechar()
            MsgBox("Impossível exluir este Fornecedor. Ele está Ligado ao fornecimento de algum produto", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub DgFornecedor_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgFornecedor.CellEnter
        If dgFornecedor.Rows.Count > 0 Then
            LimparCampos()
            txIdFornecedor.Text = dgFornecedor.CurrentRow.Cells(0).Value
            gbDadosFornecedor.Enabled = False
        End If
    End Sub

    Private Sub Buscar()
        Try
            Abrir()
            Dim sql As String = ""
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If rbDenominacaoSocial.Checked Then
                sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL, CNPJ, TELEFONE, CELULAR1, EMAIL, CIDADE, UF, ENDERECO, NUMERO, CELULAR2, OBSERVACAO FROM FORNECEDORES WHERE DENOMINACAO_SOCIAL LIKE '" & txBuscar.Text & "%'  ORDER BY DENOMINACAO_SOCIAL"

            End If

            If rbCnpj.Checked Then
                sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL, CNPJ, TELEFONE, CELULAR1, EMAIL, CIDADE, UF, ENDERECO, NUMERO, CELULAR2, OBSERVACAO FROM FORNECEDORES WHERE CNPJ = '" & txBuscarCnpj.Text & "'  ORDER BY DENOMINACAO_SOCIAL"
            End If

            If rbDataCadastro.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL, CNPJ, TELEFONE, CELULAR1, EMAIL, CIDADE, UF, ENDERECO, NUMERO, CELULAR2, OBSERVACAO FROM FORNECEDORES WHERE DATA_CADASTRO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "' ORDER BY DENOMINACAO_SOCIAL"
                Else
                    sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL, CNPJ, TELEFONE, CELULAR1, EMAIL, CIDADE, UF, ENDERECO, NUMERO, CELULAR2, OBSERVACAO FROM FORNECEDORES WHERE DATA_CADASTRO BETWEEN '" & dtBuscarData2.Text & "' AND '" & dtBuscarData1.Text & "' ORDER BY DENOMINACAO_SOCIAL"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If

            If rbCidade.Checked Then
                sql = "SELECT ID_FORNECEDOR, DENOMINACAO_SOCIAL, CNPJ, TELEFONE, CELULAR1, EMAIL, CIDADE, UF, ENDERECO, NUMERO, CELULAR2, OBSERVACAO FROM FORNECEDORES WHERE CIDADE LIKE '" & txBuscar.Text & "%'  ORDER BY DENOMINACAO_SOCIAL"
            End If

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgFornecedor.DataSource = dt

            If dgFornecedor.Rows.Count > 0 Then
                FormatarDg()
            End If

            Fechar()

        Catch ex As Exception
            MsgBox("Erro ao buscar registros! erro", MsgBoxStyle.Information + ex.Message)
        End Try

        Fechar()
    End Sub

    Private Sub TxBuscar_TextChanged(sender As Object, e As EventArgs) Handles txBuscar.TextChanged
        If Trim(txBuscar.Text) <> "" Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub TxBuscarCnpj_TextChanged(sender As Object, e As EventArgs) Handles txBuscarCnpj.TextChanged
        If Len(txBuscarCnpj.Text) = 18 Then
            Buscar()
            Exit Sub
        End If
        If txBuscarCnpj.Text = "  .   .   /    -" Then
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

    Private Sub DgFornecedor_DoubleClick(sender As Object, e As EventArgs) Handles dgFornecedor.DoubleClick
        If Frm_Gastos.busca Then
            Frm_Gastos.txCredor.Text = dgFornecedor.CurrentRow.Cells(1).Value
            Frm_Gastos.busca = False
            Me.Close()
        End If
    End Sub

    Private Sub TxEndereco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEndereco.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            Exit Sub
        End If

        If InStr("abcdefghijklmnopqrstuvwxyz´^~", e.KeyChar) And Len(txEndereco.Text) > 0 Then
            If txEndereco.Text.Substring(Len(txEndereco.Text) - 1) = " " Then
                e.KeyChar = UCase(e.KeyChar)
                Exit Sub
            End If
        Else
            If txEndereco.Text = "" Then
                e.KeyChar = UCase(e.KeyChar)
                Exit Sub
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txNumero.Focus()
        End If
    End Sub

    Private Sub CbUf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbUf.KeyPress
        If InStr("abcdefghijklmnopqrstuvwxyz", e.KeyChar) Then
            e.KeyChar = UCase(e.KeyChar)
            Exit Sub
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txCnpj.Focus()
        End If
    End Sub

    Private Sub CbCidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCidade.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cbUf.Focus()
        End If
    End Sub

    Private Sub TxCnpj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCnpj.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txTelefone.Focus()
        End If
    End Sub

    Private Sub TxTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txTelefone.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txCelular1.Focus()
        End If
    End Sub

    Private Sub TxCelular1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCelular1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txEmail.Focus()
        End If
    End Sub

    Private Sub TxEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txCelular2.Focus()
        End If
    End Sub

    Private Sub TxCelular2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCelular2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txObs.Focus()
        End If
    End Sub

    Private Sub TxObs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txObs.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btSalvar.PerformClick()
        End If
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Frm_TelaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub dgFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgFornecedor.KeyPress
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

    Private Sub PreencherCidade()
        Try
            Abrir()
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            sql = "SELECT NOME FROM CIDADE"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cbCidade.DataSource = dt
            cbCidade.DisplayMember = "NOME"

        Catch ex As Exception
            MsgBox("Erro ao preencher ComboBox! Verifique sua conexão com a internet.", MsgBoxStyle.Exclamation + ex.Message)
            Fechar()
        End Try
        Fechar()
    End Sub

    Dim cidade_full As Boolean = False

    Private Sub cbCidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCidade.SelectedIndexChanged

    End Sub
End Class