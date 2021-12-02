Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDb()
        carregarDados()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtLogin.Text = "" Or txtSenha.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Else
                sql = "SELECT * FROM tbfuncionarios WHERE login = '" & txtLogin.Text & "' AND senha = '" & txtSenha.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    MsgBox("Login Efetuado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    login = txtLogin.Text
                    Me.Hide()
                    txtLogin.Text = ""
                    txtSenha.Text = ""
                    txtLogin.Focus()
                    frmMenu.ShowDialog()
                Else
                    MsgBox("Login e/ou senha errado(s).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    txtLogin.Text = ""
                    txtSenha.Text = ""
                    txtLogin.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        sair()
    End Sub

    Private Sub chkMostrarSenhaLogin_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarSenhaLogin.CheckedChanged
        Try
            If txtSenha.PasswordChar = "•" Then
                txtSenha.PasswordChar = ""
            Else
                txtSenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            MsgBox("Erro" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
