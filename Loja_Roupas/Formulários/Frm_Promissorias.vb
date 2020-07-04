Imports MySql.Data.MySqlClient

Public Class Frm_Promissorias
    Private Sub Form_Promissorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDadosPromissoria.Enabled = False
        Listar()
        txBuscarTxt.Focus()

        dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
        dtBuscarData1.Value = dtBuscarData2.Value.AddMonths(-1)
        dtBuscarData1.Focus()

        FormatarDg()
    End Sub

    Private Sub FormatarDg()

        dgPromissoria.Font = New Font("Microsoft Sans Serif", 11)

        dgPromissoria.Columns(0).HeaderText = "ID"
        dgPromissoria.Columns(1).HeaderText = "CLIENTE"
        dgPromissoria.Columns(2).HeaderText = "VALOR"
        dgPromissoria.Columns(3).HeaderText = "DATA DE EMISSÃO"
        dgPromissoria.Columns(4).HeaderText = "DATA DE VENCIMENTO"
        dgPromissoria.Columns(5).HeaderText = "JUROS(%)"
        dgPromissoria.Columns(6).HeaderText = "STATUS"
        dgPromissoria.Columns(7).HeaderText = "CLIENTE_ID"
        dgPromissoria.Columns(8).HeaderText = "VENDA_ID"

        dgPromissoria.Columns(7).Visible = False
        dgPromissoria.Columns(8).Visible = False

        dgPromissoria.Columns(0).Width = 60
        dgPromissoria.Columns(1).Width = 400
        dgPromissoria.Columns(2).Width = 130
        dgPromissoria.Columns(3).Width = 180
        dgPromissoria.Columns(4).Width = 200
        dgPromissoria.Columns(5).Width = 120
        dgPromissoria.Columns(6).Width = 150
    End Sub

    Sub ContarRegistros()
        lbN.Text = dgPromissoria.Rows.Count
    End Sub

    Private Sub Listar()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT 
                      P.ID_PROMISSORIA,
                      C.NOME, 
                      P.VALOR, 
                      P.DATA_EMISSAO, 
                      P.DATA_VENCIMENTO,
                      P.JUROS_VENCIMENTO, 
                      P.STATUS,
                      C.ID_CLIENTE,
                      P.VENDA_ID 
                      FROM PROMISSORIAS P 
                      INNER JOIN CLIENTES C 
                      ON P.CLIENTE_ID = C.ID_CLIENTE
                      ORDER BY DATA_VENCIMENTO"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgPromissoria.DataSource = dt

            Fechar()

            If dgPromissoria.Rows.Count > 0 Then
                FormatarDg()
            End If

            ContarRegistros()
        Catch ex As Exception
            MsgBox("Não foi possivel extrair dados do banco! Erro: " + ex.Message, MsgBoxStyle.Information)
        End Try

        Fechar()
    End Sub


    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        gbDadosPromissoria.Enabled = True
        dtDataEmissao.Value = Now.ToString("dd/MM/yyyy")
        dtDataVencimento.Value = dtDataEmissao.Value.AddMonths(1)
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        txId.Text = ""
        txIdCliente.Text = ""
        txCliente.Text = ""
        txValor.Text = ""
        txJuros.Text = ""
        cbStatus.Text = ""
        dtDataEmissao.Value = Now.ToShortDateString()
        dtDataVencimento.Value = Now.ToShortDateString()
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If gbDadosPromissoria.Enabled Then
            Dim valido As Boolean = True

            If txCliente.Text = "" Then
                valido = False
                lbCliente.ForeColor = Color.Red
            End If

            If txValor.Text = "" Then
                valido = False
                lbValor.ForeColor = Color.Red
            End If

            If txJuros.Text = "" Then
                valido = False
                txJuros.Text = 0
            End If

            If cbStatus.Text = "" Or cbStatus.Text <> "Pago" And cbStatus.Text <> "Pendente" Then
                valido = False
                lbStatus.ForeColor = Color.Red
            End If

            If valido = True Then
                Try
                    Abrir()
                    Dim sql As String = ""
                    Dim cmd As MySqlCommand

                    dtDataEmissao.CustomFormat = ("yyyy-MM-dd")
                    dtDataVencimento.CustomFormat = ("yyyy-MM-dd")
                    If edit = False Then
                        sql = "INSERT INTO PROMISSORIAS(
	                                CLIENTE_ID, 
	                                VALOR, 
	                                DATA_EMISSAO, 
	                                DATA_VENCIMENTO, 
	                                JUROS_VENCIMENTO, 
	                                STATUS) 
                                VALUES(
	                                '" & Trim(txIdCliente.Text) & "', 
                                    '" & Trim(txValor.Text) & "', 
                                    '" & Trim(dtDataEmissao.Text) & "', 
                                    '" & Trim(dtDataVencimento.Text) & "', 
                                    '" & Trim(txJuros.Text) & "',
                                    '" & Trim(cbStatus.Text) & "') "
                    Else
                        sql = "UPDATE PROMISSORIAS
		                            SET CLIENTE_ID = '" & Trim(txIdCliente.Text) & "', 
		                            VALOR = '" & Trim(txValor.Text) & "', 
		                            DATA_EMISSAO = '" & Trim(dtDataEmissao.Text) & "', 
		                            DATA_VENCIMENTO = '" & Trim(dtDataVencimento.Text) & "', 
		                            JUROS_VENCIMENTO = '" & Trim(txJuros.Text) & "', 
		                            STATUS = '" & Trim(cbStatus.Text) & "' 
                                    WHERE ID_PROMISSORIA = '" & txId.Text & "' "
                    End If
                    dtDataEmissao.CustomFormat = ("dd/MM/yyyy")
                    dtDataVencimento.CustomFormat = ("dd/MM/yyyy")

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

                    gbDadosPromissoria.Enabled = False

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

    Private Sub RbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        If rbCliente.Checked Then
            txBuscarTxt.Visible = True
            txBuscarTxt.Enabled = True
            txBuscarTxt.Text = ""

            cbBuscarStatus.Visible = False
            cbBuscarStatus.Enabled = False

            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            lbEntre.Visible = False
            lbE.Visible = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False

            Listar()
        End If
    End Sub

    Private Sub RbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles rbStatus.CheckedChanged
        If rbStatus.Checked Then
            txBuscarTxt.Visible = False
            txBuscarTxt.Enabled = False

            cbBuscarStatus.Visible = True
            cbBuscarStatus.Enabled = True
            cbBuscarStatus.Text = ""

            dtBuscarData1.Visible = False
            dtBuscarData1.Enabled = False
            lbEntre.Visible = False
            lbE.Visible = False
            dtBuscarData2.Visible = False
            dtBuscarData2.Enabled = False

            Listar()
        End If

    End Sub

    Private Sub TdDataEmissao_CheckedChanged(sender As Object, e As EventArgs) Handles rbDataEmissao.CheckedChanged
        If rbDataEmissao.Checked Then
            txBuscarTxt.Visible = False
            txBuscarTxt.Enabled = False

            cbBuscarStatus.Visible = False
            cbBuscarStatus.Enabled = False

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

    Private Sub TxCliente_Enter(sender As Object, e As EventArgs) Handles txCliente.Enter
        lbCliente.ForeColor = Color.Black
    End Sub

    Private Sub TxValor_Enter(sender As Object, e As EventArgs) Handles txValor.Enter
        lbValor.ForeColor = Color.Black
    End Sub

    Private Sub CbStatus_Enter(sender As Object, e As EventArgs) Handles cbStatus.Enter
        lbStatus.ForeColor = Color.Black
    End Sub

    Private Sub PreencherCampos()
        txId.Text = dgPromissoria.CurrentRow.Cells(0).Value
        txCliente.Text = dgPromissoria.CurrentRow.Cells(1).Value
        txValor.Text = dgPromissoria.CurrentRow.Cells(2).Value
        dtDataEmissao.Value = dgPromissoria.CurrentRow.Cells(3).Value
        dtDataVencimento.Value = dgPromissoria.CurrentRow.Cells(4).Value
        txJuros.Text = dgPromissoria.CurrentRow.Cells(5).Value
        cbStatus.Text = dgPromissoria.CurrentRow.Cells(6).Value

        txIdCliente.Text = dgPromissoria.CurrentRow.Cells(7).Value
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If dgPromissoria.Rows.Count > 0 Then
            gbDadosPromissoria.Enabled = True
            PreencherCampos()
            edit = True
        Else
            MsgBox("Impossível editar. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DgPromissoria_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgPromissoria.CellEnter
        txId.Text = dgPromissoria.CurrentRow.Cells(0).Value
        'txIdCliente.Text = dgPromissoria.CurrentRow.Cells(7).Value
    End Sub

    Private Sub BtRemover_Click(sender As Object, e As EventArgs) Handles btRemover.Click
        edit = False

        If dgPromissoria.Rows.Count > 0 Then
            Dim sql As String
            Dim cmd As MySqlCommand

            Dim decisao As String

            decisao = MsgBox("Deseja excluir este registro?", MsgBoxStyle.YesNo)

            If decisao = "6" Then

                Abrir()

                sql = "DELETE FROM PROMISSORIAS WHERE ID_PROMISSORIA =  '" & txId.Text & "' "
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

    Private Sub BtVerTodos_Click(sender As Object, e As EventArgs) Handles btVerTodos.Click
        Listar()
        dtBuscarData1.Value = Now.ToString("dd/MM/yyyy")
        dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
        cbBuscarStatus.Text = ""
        txBuscarTxt.Text = ""
    End Sub

    Private Sub Buscar()
        Try
            Abrir()
            Dim sql As String = ""
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If rbCliente.Checked Then
                sql = "SELECT 
                      P.ID_PROMISSORIA,
                      C.NOME, 
                      P.VALOR, 
                      P.DATA_EMISSAO, 
                      P.DATA_VENCIMENTO,
                      P.JUROS_VENCIMENTO, 
                      P.STATUS,
                      C.ID_CLIENTE,
                      P.VENDA_ID
                      FROM PROMISSORIAS P 
                      INNER JOIN CLIENTES C 
                      ON P.CLIENTE_ID = C.ID_CLIENTE 
                      WHERE C.NOME LIKE '" & txBuscarTxt.Text & "%'
                      ORDER BY DATA_VENCIMENTO"
            End If

            If rbStatus.Checked Then
                sql = "SELECT 
                      P.ID_PROMISSORIA,
                      C.NOME, 
                      P.VALOR, 
                      P.DATA_EMISSAO, 
                      P.DATA_VENCIMENTO,
                      P.JUROS_VENCIMENTO, 
                      P.STATUS, 
                      C.ID_CLIENTE,
                      P.VENDA_ID 
                      FROM PROMISSORIAS P 
                      INNER JOIN CLIENTES C 
                      ON P.CLIENTE_ID = C.ID_CLIENTE
                      WHERE P.STATUS = '" & cbBuscarStatus.Text & "' 
                      ORDER BY DATA_VENCIMENTO"
            End If

            If rbDataEmissao.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT 
                              P.ID_PROMISSORIA,
                              C.NOME, 
                              P.VALOR, 
                              P.DATA_EMISSAO, 
                              P.DATA_VENCIMENTO,
                              P.JUROS_VENCIMENTO, 
                              P.STATUS,
                              C.ID_CLIENTE,
                              P.VENDA_ID FROM PROMISSORIAS P 
                              INNER JOIN CLIENTES C 
                              ON P.CLIENTE_ID = C.ID_CLIENTE
                              WHERE DATA_EMISSAO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "' 
                              ORDER BY DATA_VENCIMENTO"
                Else
                    sql = "SELECT 
                              P.ID_PROMISSORIA,
                              C.NOME, 
                              P.VALOR, 
                              P.DATA_EMISSAO, 
                              P.DATA_VENCIMENTO,
                              P.JUROS_VENCIMENTO, 
                              P.STATUS, 
                              C.ID_CLIENTE,
                              P.VENDA_ID FROM PROMISSORIAS P 
                              INNER JOIN CLIENTES C 
                              ON P.CLIENTE_ID = C.ID_CLIENTE
                              WHERE DATA_EMISSAO BETWEEN '" & dtBuscarData2.Text & "' AND '" & dtBuscarData1.Text & "' 
                              ORDER BY DATA_VENCIMENTO"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgPromissoria.DataSource = dt

            If dgPromissoria.Rows.Count > 0 Then
                FormatarDg()
            End If

            Fechar()

        Catch ex As Exception
            MsgBox("Erro ao buscar registros! erro", MsgBoxStyle.Information + ex.Message)
        End Try

        Fechar()

    End Sub

    Private Sub TxBuscarTxt_TextChanged(sender As Object, e As EventArgs) Handles txBuscarTxt.TextChanged
        If txBuscarTxt.Text <> "" Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub CbBuscarStatus_TextChanged(sender As Object, e As EventArgs) Handles cbBuscarStatus.TextChanged
        If cbBuscarStatus.Text <> "" Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub DtBuscarData1_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData1.ValueChanged
        If rbDataEmissao.Checked Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Private Sub DtBuscarData2_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData2.ValueChanged
        If rbDataEmissao.Checked Then
            Buscar()
        Else
            Listar()
        End If
    End Sub

    Public busca As Boolean = False

    Private Sub BtBuscarCliente_Click(sender As Object, e As EventArgs) Handles btBuscarCliente.Click
        busca = True
        Frm_CadCliente.ShowDialog()
    End Sub

    Private Sub TxJuros_Enter(sender As Object, e As EventArgs) Handles txJuros.Enter
        lbJuros.ForeColor = Color.Black
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Frm_TelaPrincipal.Show()
        Me.Close()
    End Sub
End Class