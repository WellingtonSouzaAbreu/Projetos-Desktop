Imports MySql.Data.MySqlClient

Public Class Frm_Login
    Private Sub BtEntrar_Click(sender As Object, e As EventArgs) Handles btEntrar.Click
        If (txUsuario.Text <> "" Or txSenha.Text <> "") Then

            If (txSenha.TextLength >= 8) Then
                Try
                    Abrir()
                    Dim reader As MySqlDataReader
                    Dim sql As String
                    Dim cmd As MySqlCommand

                    sql = "SELECT ID_USUARIO FROM USUARIOS WHERE LOGIN = '" & Trim(txUsuario.Text) & "' AND  SENHA = '" & Trim(txSenha.Text) & "' "
                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader()

                    If reader.Read Then
                        reader.Close()

                        Frm_TelaPrincipal.Show()
                        Me.Close()
                        Fechar()
                        Exit Sub
                    Else
                        reader.Close()
                        lbAviso2.Visible = True
                        txSenha.Focus()
                    End If
                    Fechar()
                Catch ex As Exception
                    MsgBox("Erro ao abrir formulário! Tente Novamente", MsgBoxStyle.Exclamation)
                    Me.Show()
                End Try

            Else
                lbAviso.Visible = True
            End If

        Else
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TxUsuario_Enter(sender As Object, e As EventArgs) Handles txUsuario.Enter

    End Sub

    Private Sub TxSenha_TextChanged(sender As Object, e As EventArgs) Handles txSenha.TextChanged
        lbAviso.Visible = False
        lbAviso2.Visible = False
    End Sub

    Private Sub TxUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txSenha.Focus()
        End If
    End Sub

    Private Sub TxSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txSenha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btEntrar.PerformClick()
        End If
    End Sub
End Class
