Imports MySql.Data.MySqlClient
Public Class Frm_Relatorio
    Private Sub btGerarPromissoria_Click(sender As Object, e As EventArgs) Handles btGerarRelatorio.Click

        ConverterData()

        GanhoEstimado()
        VendaBruta()
        ContasAReceber()

        CompraProdutos()
        CustosAdicionais()
        ContasAPagar()

        TotalGanho()
        TotalGasto()
        LucroLiquido()

        PecasMasculinas()
        PecasFemininas()
        PecasUnissex()

        PecasAdultos()
        PecasInfantis()
        PecasVendidas()

        PromissoriasGeradas()
    End Sub

    Public data1 As String
    Public data2 As String

    Sub ConverterData()
        dtData1.CustomFormat = "yyyy-MM-dd"
        dtData2.CustomFormat = "yyyy-MM-dd"
        data1 = dtData1.Text
        data2 = dtData2.Text
        dtData1.CustomFormat = "dd/MM/yyyy"
        dtData2.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub Frm_Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtData2.Value = Now.ToString("dd/MM/yyyy")
        dtData1.Value = dtData2.Value.AddMonths(-1)
    End Sub

    Sub GanhoEstimado()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Ganho Estimado
            sql = " SELECT SUM(VALOR_VENDA * QUANTIDADE) FROM PRODUTOS 
                    WHERE DATA_CADASTRO BETWEEN '" & data1 & "' AND '" & data2 & "'
	                OR DATA_CADASTRO BETWEEN '" & data2 & "' AND '" & data1 & "'
                    AND QUANTIDADE > 0;"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbGanhoEstimadoR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbGanhoEstimadoR.Text) Then
                lbGanhoEstimadoR.Text = Format(Convert.ToDecimal(lbGanhoEstimadoR.Text), "0.00")
            Else
                lbGanhoEstimadoR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. 'Ganho Estimado' " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub VendaBruta()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Venda Bruta
            sql = "SELECT SUM(TOTAL) FROM VENDAS 
                   WHERE DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "'
                   OR DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'
                   AND FORMA_PAGAMENTO = 'A VISTA';"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbVendaBrutaR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbVendaBrutaR.Text) Then
                lbVendaBrutaR.Text = Format(Convert.ToDecimal(lbVendaBrutaR.Text), "0.00")
            Else
                lbVendaBrutaR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub ContasAReceber()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Contas a receber
            sql = "SELECT SUM(VALOR) FROM PROMISSORIAS 
                    WHERE DATA_EMISSAO BETWEEN '" & data1 & "' AND '" & data2 & "'
                   OR DATA_EMISSAO BETWEEN '" & data2 & "' AND '" & data1 & "' 
                    AND STATUS = 'PENDENTE';"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbContasReceberR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbContasReceberR.Text) Then
                lbContasReceberR.Text = Format(Convert.ToDecimal(lbContasReceberR.Text), "0.00")
            Else
                lbContasReceberR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub CompraProdutos()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Compra de produtos
            sql = "SELECT SUM(VALOR_COMPRA * QUANTIDADE) FROM PRODUTOS 
                   WHERE DATA_CADASTRO BETWEEN '" & data1 & "' AND '" & data2 & "'
                   OR DATA_CADASTRO BETWEEN '" & data2 & "' AND '" & data1 & "' ;"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbCompraProdutosR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbCompraProdutosR.Text) Then
                lbCompraProdutosR.Text = Format(Convert.ToDecimal(lbCompraProdutosR.Text), "0.00")
            Else
                lbCompraProdutosR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub CustosAdicionais()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Custos adicionais
            sql = "SELECT SUM(VALOR) FROM CONTAS 
                    WHERE DATA_EMISSAO BETWEEN '" & data1 & "' AND '" & data2 & "'
                   OR DATA_EMISSAO BETWEEN '" & data2 & "' AND '" & data1 & "' 
                   AND STATUS = 'PAGO';"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbCustosAdicionaisR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbCustosAdicionaisR.Text) Then
                lbCustosAdicionaisR.Text = Format(Convert.ToDecimal(lbCustosAdicionaisR.Text), "0.00")
            Else
                lbCustosAdicionaisR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub ContasAPagar()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'XXXXXXXXXXX
            'COntas a pagar
            sql = " SELECT SUM(VALOR) FROM CONTAS     
                    WHERE  STATUS = 'PENDENTE' 
                    AND DATA_EMISSAO BETWEEN '" & data1 & "' AND '" & data2 & "'
                    OR DATA_EMISSAO BETWEEN '" & data2 & "' AND '" & data1 & "';"
            dt.Clear()
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbContasPagarR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbContasPagarR.Text) Then
                lbContasPagarR.Text = Format(Convert.ToDecimal(lbContasPagarR.Text), "0.00")
            Else
                lbContasPagarR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub TotalGanho()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Total de ganho
            sql = " SELECT SUM(TOTAL) FROM VENDAS 
                    WHERE DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "'
                   OR DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "' 
                    AND FORMA_PAGAMENTO = 'A VISTA'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbTotalGanhoR.Text = dt.Rows(0).Item(0).ToString
            If IsNumeric(lbTotalGanhoR.Text) Then
                lbTotalGanhoR.Text = Format(Convert.ToDecimal(lbTotalGanhoR.Text), "0.00")
            Else
                lbTotalGanhoR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub TotalGasto()
        'Total de gastos
        lbTotalGastoR.Text = Convert.ToString(Convert.ToDecimal(lbCompraProdutosR.Text) + Convert.ToDecimal(lbCustosAdicionaisR.Text))

    End Sub

    Sub LucroLiquido()
        'Ganho Líquido
        lbLucroLiquidoR.Text = Convert.ToString(Convert.ToDecimal(lbVendaBrutaR.Text) - Convert.ToDecimal(lbTotalGastoR.Text))

    End Sub

    Sub PecasMasculinas()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Peças Masculinas
            sql = " SELECT COUNT(L.id_lista_produtos) FROM LISTA_PRODUTOS L
                 INNER JOIN VENDAS V 
                 ON V.ID_VENDA = L.VENDA_ID
                 INNER JOIN PRODUTOS P 
                 ON P.ID_PRODUTO = L.PRODUTO_ID
                 WHERE P.GENERO = 'MASCULINO'
                 AND V.DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "' 
                    OR V.DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPecasMasculinasR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPecasMasculinasR.Text) Then
                lbPecasMasculinasR.Text = "0"
            End If


        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub PecasFemininas()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Peças Femininas
            sql = " SELECT COUNT(L.id_lista_produtos) FROM LISTA_PRODUTOS L
                 INNER JOIN VENDAS V 
                 ON V.ID_VENDA = L.VENDA_ID
                 INNER JOIN PRODUTOS P 
                 ON P.ID_PRODUTO = L.PRODUTO_ID
                 WHERE P.GENERO = 'FEMININO'
                 AND V.DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "' 
                 OR V.DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPecasFemininasR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPecasFemininasR.Text) Then
                lbPecasFemininasR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub PecasUnissex()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Peças Unissex
            sql = " SELECT COUNT(L.id_lista_produtos) FROM LISTA_PRODUTOS L
                 INNER JOIN VENDAS V 
                 ON V.ID_VENDA = L.VENDA_ID
                 INNER JOIN PRODUTOS P 
                 ON P.ID_PRODUTO = L.PRODUTO_ID
                 WHERE P.GENERO = 'UNISSEX'
                 AND V.DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "' 
                 OR V.DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPecasUnissexR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPecasUnissexR.Text) Then
                lbPecasUnissexR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub PecasInfantis()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Peças Infantis
            sql = " SELECT COUNT(L.id_lista_produtos) FROM LISTA_PRODUTOS L
	                INNER JOIN VENDAS V 
	                ON V.ID_VENDA = L.VENDA_ID
	                INNER JOIN PRODUTOS P 
	                ON P.ID_PRODUTO = L.PRODUTO_ID
	                WHERE P.CATEGORIA = 'INFANTIL'
                    AND V.DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "' 
                    OR V.DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPecasInfantisR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPecasInfantisR.Text) Then
                lbPecasInfantisR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. 'Peças Infantis' " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub PecasAdultos()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Peças Adultos
            sql = " SELECT COUNT(L.id_lista_produtos) FROM LISTA_PRODUTOS L
	                INNER JOIN VENDAS V 
	                ON V.ID_VENDA = L.VENDA_ID
	                INNER JOIN PRODUTOS P 
	                ON P.ID_PRODUTO = L.PRODUTO_ID
	                WHERE P.CATEGORIA = 'ADULTO'
                    AND V.DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "' 
                    OR V.DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPecasAdultasR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPecasAdultasR.Text) Then
                lbPecasAdultasR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. 'Peças Adultos' " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub PecasVendidas()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Peças Vendidas
            sql = " SELECT COUNT(L.id_lista_produtos) FROM LISTA_PRODUTOS L
	                INNER JOIN VENDAS V 
	                ON V.ID_VENDA = L.VENDA_ID
                    AND V.DATA_VENDA BETWEEN '" & data1 & "' AND '" & data2 & "' 
                    OR V.DATA_VENDA BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPecasVendidasR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPecasVendidasR.Text) Then
                lbPecasVendidasR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. 'Peças Vendidas' " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

    Sub PromissoriasGeradas()
        Abrir()
        Try
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable

            'Promissorias Geradas
            sql = "  SELECT COUNT(*) FROM PROMISSORIAS
                     WHERE DATA_EMISSAO BETWEEN '" & data1 & "' AND '" & data2 & "' 
                     OR DATA_EMISSAO BETWEEN '" & data2 & "' AND '" & data1 & "'; "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbPromissoriasGeradasR.Text = dt.Rows(0).Item(0).ToString
            If Not IsNumeric(lbPromissoriasGeradasR.Text) Then
                lbPromissoriasGeradasR.Text = "0"
            End If

        Catch ex As Exception
            MsgBox("Erro ao emitir relatório. 'Promissorias Geradas' " + ex.Message, MsgBoxStyle.Exclamation)
            Fechar()
        End Try
        Fechar()
    End Sub

End Class