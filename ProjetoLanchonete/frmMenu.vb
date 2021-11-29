Public Class frmMenu
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        sair()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblUsuario.Text = login

            If login = "admin" Then
                tbControle.TabPages(1).Enabled = True
                tbControle.TabPages(2).Enabled = True
            Else
                tbControle.TabPages(1).Enabled = False
                tbControle.TabPages(2).Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
        Try
            For index = 1 To 10
                sql = "select * from tbprodutos where id=" & index & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    cmbProdutos.Items.Add(rs.Fields(1).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("Erro" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnCadastar_Click(sender As Object, e As EventArgs) Handles btnCadastar.Click
        Try
            If txtCPF.Text = "" Or
                txtDataNasc.Text = "" Or
                txtNome.Text = "" Or
                txtCEP.Text = "" Or
                txtEndereco.Text = "" Or
                txtComplemento.Text = "" Or
                txtBairro.Text = "" Or
                txtCidade.Text = "" Or
                txtUF.Text = "" Or
                txtTelefone.Text = "" Or
                txtCelular.Text = "" Or
                txtEmail.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "insert into tbCadastro values('" & txtCPF.Text & "', " &
                                                 "'" & txtDataNasc.Text & "', " &
                                                 "'" & txtNome.Text & "', " &
                                                 "'" & txtCEP.Text & "', " &
                                                 "'" & txtEndereco.Text & "', " &
                                                 "'" & txtComplemento.Text & "', " &
                                                 "'" & txtBairro.Text & "', " &
                                                 "'" & txtCidade.Text & "', " &
                                                 "'" & txtUF.Text & "', " &
                                                 "'" & txtTelefone.Text & "', " &
                                                 "'" & txtCelular.Text & "', " &
                                                 "'" & txtEmail.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            sql = "select * from tbCadastro where cpf='" & txtCPF.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtDataNasc.Text = rs.Fields(1).Value
                txtNome.Text = rs.Fields(2).Value
                txtCEP.Text = rs.Fields(3).Value
                txtEndereco.Text = rs.Fields(4).Value
                txtComplemento.Text = rs.Fields(5).Value
                txtBairro.Text = rs.Fields(6).Value
                txtCidade.Text = rs.Fields(7).Value
                txtUF.Text = rs.Fields(8).Value
                txtTelefone.Text = rs.Fields(9).Value
                txtCelular.Text = rs.Fields(10).Value
                txtEmail.Text = rs.Fields(11).Value
            Else
                MsgBox("CPF Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try
            If txtCPF.Text = "" Then
                MsgBox("Preencha o Campo do CPF.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                txtCPF.Focus()
                Exit Sub
            End If
            resp = MsgBox("Deseja Realmente Excluir o Registro" + vbCrLf + "CPF: " & txtCPF.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
            If resp = MsgBoxResult.Yes Then
                sql = "delete * from tbCadastro where cpf='" & txtCPF.Text & "'"
                rs = db.Execute(UCase(sql))
            ElseIf MsgBoxResult.No Then
                Exit Sub
            Else
                MsgBox("CPF Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txtCEP_LostFocus(sender As Object, e As EventArgs) Handles txtCEP.LostFocus
        Try
            sql = "select * from tb_cep where cep='" & txtCEP.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtEndereco.Text = rs.Fields(1).Value
                txtCidade.Text = rs.Fields(2).Value
                txtBairro.Text = rs.Fields(3).Value
                txtUF.Text = rs.Fields(4).Value
                txtComplemento.Focus()
            Else
                MsgBox("CEP Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Try
            If txtCPF.Text = "" Or
                txtDataNasc.Text = "" Or
                txtNome.Text = "" Or
                txtCEP.Text = "" Or
                txtEndereco.Text = "" Or
                txtComplemento.Text = "" Or
                txtBairro.Text = "" Or
                txtCidade.Text = "" Or
                txtUF.Text = "" Or
                txtTelefone.Text = "" Or
                txtCelular.Text = "" Or
                txtEmail.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "update tbCadastro set  cpf = '" & txtCPF.Text & "', " &
                                                 "dataNasc = '" & txtDataNasc.Text & "', " &
                                                 "nome = '" & txtNome.Text & "', " &
                                                 "cep = '" & txtCEP.Text & "', " &
                                                 "endereco = '" & txtEndereco.Text & "', " &
                                                 "comp = '" & txtComplemento.Text & "', " &
                                                 "bairro = '" & txtBairro.Text & "', " &
                                                 "cidade = '" & txtCidade.Text & "', " &
                                                 "uf = '" & txtUF.Text & "', " &
                                                 "telefone = '" & txtTelefone.Text & "', " &
                                                 "celular = '" & txtCelular.Text & "', " &
                                                 "email = '" & txtEmail.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Atualizados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnCadastrarLogin_Click(sender As Object, e As EventArgs) Handles btnCadastrarLogin.Click
        Try
            If txtCadastrarLogin.Text = "" Or
                txtCadastrarEmail.Text = "" Or
                txtCadastrarSenha.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "SELECT * FROM tblogin WHERE login = '" & txtCadastrarLogin.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    MsgBox("Login Já Existente, Escolha Outro!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                    limparLogin()
                    Exit Sub
                End If
                sql = "insert into tblogin values('" & txtCadastrarLogin.Text & "', " &
                                                 "'" & txtCadastrarEmail.Text & "', " &
                                                 "'" & txtCadastrarSenha.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    limparLogin()
                End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub chkMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarSenha.CheckedChanged
        Try
            If txtCadastrarSenha.PasswordChar = "•" Then
                txtCadastrarSenha.PasswordChar = ""
            Else
                txtCadastrarSenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnDeletarLogin_Click(sender As Object, e As EventArgs) Handles btnDeletarLogin.Click
        Try
            If txtCadastrarLogin.Text = "" Then
                MsgBox("Preencha o Campo do Login.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                txtCadastrarLogin.Focus()
                Exit Sub
            End If
            resp = MsgBox("Deseja Realmente Excluir o Registro" + vbCrLf + "Login: " & txtCadastrarLogin.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
            If resp = MsgBoxResult.Yes Then
                sql = "delete * from tblogin where login='" & txtCadastrarLogin.Text & "'"
                rs = db.Execute(sql)
            ElseIf MsgBoxResult.No Then
                Exit Sub
            Else
                MsgBox("Login Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnPesquisarLogin_Click(sender As Object, e As EventArgs) Handles btnPesquisarLogin.Click
        Try
            If txtCadastrarLogin.Text = "" Then
                MsgBox("Preencha o Campo de Login!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            End If
            sql = "select * from tblogin where login='" & txtCadastrarLogin.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtCadastrarEmail.Text = rs.Fields(1).Value
                txtCadastrarSenha.Text = rs.Fields(2).Value
            Else
                MsgBox("Login não localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro" & ex.Message(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnAtualizarLogin_Click(sender As Object, e As EventArgs) Handles btnAtualizarLogin.Click
        Try
            If txtCadastrarLogin.Text = "" Or
                txtCadastrarEmail.Text = "" Or
                txtCadastrarSenha.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "update tblogin set login = '" & txtCadastrarLogin.Text & "', " &
                                                   "email = '" & txtCadastrarEmail.Text & "', " &
                                                   "senha = '" & txtCadastrarSenha.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados Atualizados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparLogin()
            End If
        Catch ex As Exception
            MsgBox("Erro" & ex.Message(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub nmrQuantidade_ValueChanged(sender As Object, e As EventArgs) Handles nmrQuantidade.ValueChanged
        Try
            If cmbProdutos.Text = "" Then
                MsgBox("Preencha o Produto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
            sql = "select * from tbprodutos where produtos='" & cmbProdutos.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lblPreco.Text = (rs.Fields(2).Value) * nmrQuantidade.Value
                preco = lblPreco.Text
            Else
                MsgBox("Login não localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnCadastrarPedido_Click(sender As Object, e As EventArgs) Handles btnCadastrarPedido.Click
        Try
            If cmbProdutos.Text = "" Or
                nmrQuantidade.Value = 0 Or
                txtNomeCliente.Text = "" Or
                txtDataPedido.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            End If
            sql = "insert into tbpedidos values('" & txtNomeCliente.Text & "', " &
                                                 "'" & txtDataPedido.Text & "', " &
                                                 "'" & cmbProdutos.Text & "', " &
                                                 "'" & nmrQuantidade.Value & "', " &
                                                 "'" & preco & "')"
            rs = db.Execute(sql)
            carregarDados()
            MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        Catch ex As Exception
            MsgBox("Erro" & ex.Message(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class