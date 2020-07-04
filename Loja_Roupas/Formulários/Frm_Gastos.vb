Imports MySql.Data.MySqlClient

Public Class Frm_Gastos

    Private Sub Frm_Gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDadosConta.Enabled = False

        dtBuscarData2.Value = Now.ToString("dd/MM/yyyy")
        dtBuscarData1.Value = dtBuscarData2.Value.AddMonths(-1)
        dtBuscarData1.Focus()
        FormatarDg()
        Listar()
    End Sub

    Private Sub FormatarDg()
        dgGastos.Font = New Font("Microsoft Sans Serif", 11)

        dgGastos.Columns(0).HeaderText = "Id"
        dgGastos.Columns(1).HeaderText = "Descrição"
        dgGastos.Columns(2).HeaderText = "Valor"
        dgGastos.Columns(3).HeaderText = "Juros"
        dgGastos.Columns(4).HeaderText = "Data de Emissão"
        dgGastos.Columns(5).HeaderText = "Data de Vencimento"
        dgGastos.Columns(6).HeaderText = "Situação"
        dgGastos.Columns(7).HeaderText = "Credor"

        dgGastos.Columns(0).Width = 80
        dgGastos.Columns(1).Width = 265
        dgGastos.Columns(2).Width = 100
        dgGastos.Columns(3).Width = 80
        dgGastos.Columns(4).Width = 170
        dgGastos.Columns(5).Width = 170
        dgGastos.Columns(6).Width = 120
        dgGastos.Columns(7).Width = 256

    End Sub

    Sub ContarRegistros()
        lbN.Text = dgGastos.Rows.Count
    End Sub

    Private Sub Listar()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS ORDER BY DATA_VENCIMENTO"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            dgGastos.DataSource = dt

            Fechar()

            If dgGastos.Rows.Count > 0 Then
                FormatarDg()
            End If

            ContarRegistros()
        Catch ex As Exception
            MsgBox("Não foi possivel extrair dados do banco! Erro: ", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        gbDadosConta.Enabled = True
        dtDataEmissao.Value = Now.ToString("dd/MM/yyyy")
        dtDataVencimento.Value = dtDataEmissao.Value.AddMonths(1)
        Limparcampos()
    End Sub

    Private Sub Limparcampos()
        txDescricao.Text = ""
        txValor.Text = ""
        txJuros.Text = ""
        dtDataEmissao.Value = Now.ToString("dd/MM/yyyy")
        dtDataVencimento.Value = dtDataEmissao.Value.AddMonths(1)
        txCredor.Text = ""
        cbStatus.Text = ""

    End Sub

    Dim edit As Boolean = False

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim valido As Boolean = True

        If gbDadosConta.Enabled Then
            If Trim(txDescricao.Text) = "" Then
                lbDescricao.ForeColor = Color.Red
                valido = False
            End If

            If Trim(txValor.Text) = "" Then
                lbValor.ForeColor = Color.Red
                valido = False
            End If

            If Trim(txJuros.Text) = "" Then
                lbJuros.ForeColor = Color.Red
                valido = False
            End If

            If Trim(txCredor.Text) = "" Then
                lbCredor.ForeColor = Color.Red
                valido = False
            End If

            If Trim(cbStatus.Text) <> "Pago" And Trim(cbStatus.Text) <> "Pendente" Then
                lbStatus.ForeColor = Color.Red
                valido = False
            End If

            If valido = True Then
                Try
                    Abrir()
                    Dim sql As String = ""
                    Dim cmd As MySqlCommand

                    dtDataEmissao.CustomFormat = "yyyy-MM-dd"
                    dtDataVencimento.CustomFormat = "yyyy-MM-dd"
                    If edit = False Then
                        sql = "INSERT INTO CONTAS(DESCRICAO, VALOR, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, JUROS, CREDOR) VALUES( '" & Trim(txDescricao.Text) & "',  '" & Trim(txValor.Text) & "',  '" & Trim(dtDataEmissao.Text) & "',  '" & Trim(dtDataVencimento.Text) & "',  '" & cbStatus.Text & "',  '" & Trim(txJuros.Text) & "',  '" & Trim(txCredor.Text) & "' )"
                    Else
                        sql = "UPDATE CONTAS SET DESCRICAO = '" & Trim(txDescricao.Text) & "' , VALOR = '" & Trim(txValor.Text) & "' , DATA_EMISSAO = '" & Trim(dtDataEmissao.Text) & "' , DATA_VENCIMENTO = '" & Trim(dtDataVencimento.Text) & "' ,STATUS = '" & Trim(cbStatus.Text) & "' ,JUROS = '" & Trim(txJuros.Text) & "' ,CREDOR = '" & Trim(txCredor.Text) & "'  WHERE ID_CONTA = '" & txId.Text & "' "
                    End If
                    dtDataEmissao.CustomFormat = "dd/MM/yyyy"
                    dtDataVencimento.CustomFormat = "dd/MM/yyyy"

                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Listar()
                    Fechar()
                    Limparcampos()

                    If edit = False Then
                        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Cadastro atualiado com sucesso!", MsgBoxStyle.Information)
                        edit = False
                    End If

                    gbDadosConta.Enabled = False

                Catch ex As Exception
                    MsgBox("Falha ao realizar cadastro! ", MsgBoxStyle.Exclamation + ex.Message)
                End Try

            Else
                MsgBox("Preencha os campos obrigatórios! ", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub


    Private Sub TxDescricao_Enter(sender As Object, e As EventArgs) Handles txDescricao.Enter
        lbDescricao.ForeColor = Color.Black
    End Sub

    Private Sub TxValor_Enter(sender As Object, e As EventArgs) Handles txValor.Enter
        lbValor.ForeColor = Color.Black
    End Sub

    Private Sub TxJuros_Enter(sender As Object, e As EventArgs) Handles txJuros.Enter
        lbJuros.ForeColor = Color.Black
    End Sub

    Private Sub TxCredor_Enter(sender As Object, e As EventArgs) Handles txCredor.Enter
        lbCredor.ForeColor = Color.Black
    End Sub

    Private Sub CbStatus_Enter(sender As Object, e As EventArgs) Handles cbStatus.Enter
        lbStatus.ForeColor = Color.Black
    End Sub

    Private Sub TxJuros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txJuros.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            e.KeyChar = ","
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.Handled = True
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txValor.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "," And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BtVerTodos_Click(sender As Object, e As EventArgs) Handles btVerTodos.Click
        Listar()

        rbPago.Checked = False
        rbPendente.Checked = False
        rbTodos.Checked = False
        dtBuscarData1.Value = Now.ToString("dd/MM/yyyy")
        dtBuscarData2.Value = dtBuscarData1.Value.AddMonths(1)
    End Sub

    Private Sub PreencherCampos()
        txId.Text = dgGastos.CurrentRow.Cells(0).Value
        txDescricao.Text = dgGastos.CurrentRow.Cells(1).Value
        txValor.Text = dgGastos.CurrentRow.Cells(2).Value
        txJuros.Text = dgGastos.CurrentRow.Cells(3).Value
        dtDataEmissao.Value = dgGastos.CurrentRow.Cells(4).Value
        dtDataVencimento.Value = dgGastos.CurrentRow.Cells(5).Value
        cbStatus.Text = dgGastos.CurrentRow.Cells(6).Value
        txCredor.Text = dgGastos.CurrentRow.Cells(7).Value
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If dgGastos.Rows.Count > 0 Then
            gbDadosConta.Enabled = True
            PreencherCampos()
            edit = True
        Else
            MsgBox("Impossível editar. Não há nenhum registro selecionado!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtRemover_Click(sender As Object, e As EventArgs) Handles btRemover.Click
        If dgGastos.Rows.Count > 0 And dgGastos.SelectedRows.Count = 1 Then
            Dim sql As String
            Dim cmd As MySqlCommand

            Dim decisao As String

            decisao = MsgBox("Deseja excluir este registro?", MsgBoxStyle.YesNo)

            If decisao = "6" Then

                Abrir()

                sql = "DELETE FROM CONTAS WHERE ID_CONTA =  '" & txId.Text & "' "
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

    Private Sub DgGastos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgGastos.CellEnter
        If dgGastos.Rows.Count > 0 Then
            txId.Text = dgGastos.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub Buscar()
        Try
            Abrir()
            Dim sql As String = ""
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            If rbPago.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS WHERE STATUS = 'Pago' AND DATA_VENCIMENTO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "'ORDER BY DATA_VENCIMENTO "
                Else
                    sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS WHERE STATUS = 'Pago' AND DATA_VENCIMENTO BETWEEN '" & dtBuscarData2.Text & "' AND '" & dtBuscarData1.Text & "' ORDER BY DATA_VENCIMENTO"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If

            If rbPendente.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS WHERE STATUS = 'Pendente' AND DATA_VENCIMENTO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "' ORDER BY DATA_VENCIMENTO "
                Else
                    sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS WHERE STATUS = 'Pendente' AND DATA_VENCIMENTO BETWEEN '" & dtBuscarData2.Text & "' AND '" & dtBuscarData1.Text & "' ORDER BY DATA_VENCIMENTO"
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If

            If rbTodos.Checked Then
                dtBuscarData1.CustomFormat = "yyyy-MM-dd"
                dtBuscarData2.CustomFormat = "yyyy-MM-dd"
                If dtBuscarData1.Value < dtBuscarData2.Value Then
                    sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS WHERE DATA_VENCIMENTO BETWEEN '" & dtBuscarData1.Text & "' AND '" & dtBuscarData2.Text & "'  ORDER BY DATA_VENCIMENTO "
                Else
                    sql = "SELECT ID_CONTA, DESCRICAO, VALOR, JUROS, DATA_EMISSAO, DATA_VENCIMENTO, STATUS, CREDOR FROM CONTAS WHERE DATA_VENCIMENTO BETWEEN '" & dtBuscarData2.Text & "' AND '" & dtBuscarData1.Text & "'  ORDER BY DATA_VENCIMENTO "
                End If
                dtBuscarData1.CustomFormat = "dd/MM/yyyy"
                dtBuscarData2.CustomFormat = "dd/MM/yyyy"
            End If



            If sql <> "" Then
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                dgGastos.DataSource = dt
            End If

            If dgGastos.Rows.Count > 0 Then
                'FormatarDg()
            End If

            Fechar()

        Catch ex As Exception
            MsgBox("Erro ao buscar registros! erro", MsgBoxStyle.Information + ex.Message)
        End Try

        Fechar()
    End Sub

    Private Sub DtBuscarData1_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData1.ValueChanged
        If rbPago.Checked Or rbPendente.Checked Or rbTodos.Checked Then
            Buscar()
        End If
    End Sub

    Private Sub DtBuscarData2_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscarData2.ValueChanged
        If rbPago.Checked Or rbPendente.Checked Or rbTodos.Checked Then
            Buscar()
        End If
    End Sub

    Private Sub RbPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbPago.CheckedChanged
        Buscar()
    End Sub

    Private Sub RbPendente_CheckedChanged(sender As Object, e As EventArgs) Handles rbPendente.CheckedChanged
        Buscar()
    End Sub

    Private Sub RbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        Buscar()
    End Sub

    Public busca As Boolean = False

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        busca = True
        Frm_CadFornecedor.ShowDialog()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Frm_TelaPrincipal.Show()
        Me.Close()
    End Sub


End Class