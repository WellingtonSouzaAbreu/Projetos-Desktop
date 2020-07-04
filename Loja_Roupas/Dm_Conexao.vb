Imports MySql.Data.MySqlClient

Module Dm_Conexao
    Public con As New MySqlConnection("server=localhost; userid=root; password=; database=loja_roupas; port=3306")

    Sub Abrir()
        Try
            If con.State = 0 Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Erro ao se conectar com o banco! ", MsgBoxStyle.Information + ex.Message)
        End Try
    End Sub

    Sub Fechar()
        Try
            If con.State = 1 Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao se desconectar com o banco! ", MsgBoxStyle.Information + ex.Message)
        End Try
    End Sub


End Module
