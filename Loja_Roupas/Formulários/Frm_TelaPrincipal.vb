Public Class Frm_TelaPrincipal

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        Frm_CadProduto.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Frm_CadCliente.Show()
    End Sub

    Private Sub ContaAPagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContaAPagarToolStripMenuItem.Click
        Frm_Gastos.Show()
    End Sub

    Private Sub NovaVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaVendaToolStripMenuItem.Click
        Frm_Venda.Show()
    End Sub

    Private Sub FornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedorToolStripMenuItem.Click
        Frm_CadFornecedor.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Frm_Login.Show()
        Me.Close()
    End Sub

    Private Sub PromissóriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromissóriasToolStripMenuItem.Click
        Frm_Promissorias.show
    End Sub



    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Frm_Relatorio.Show()
    End Sub
End Class