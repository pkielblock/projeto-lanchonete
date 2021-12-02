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
                cmbFuncao.Text = "" Or
                txtSenhaFunc.Text = "" Or
                txtLoginFunc.Text = "" Or
                txtEmail.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "insert into tbfuncionarios values('" & txtCPF.Text & "', " &
                                                 "'" & txtDataNasc.Text & "', " &
                                                 "'" & cmbFuncao.Text & "', " &
                                                 "'" & txtNome.Text & "', " &
                                                 "'" & txtCEP.Text & "', " &
                                                 "'" & txtEndereco.Text & "', " &
                                                 "'" & txtComplemento.Text & "', " &
                                                 "'" & txtBairro.Text & "', " &
                                                 "'" & txtCidade.Text & "', " &
                                                 "'" & txtUF.Text & "', " &
                                                 "'" & txtTelefone.Text & "', " &
                                                 "'" & txtCelular.Text & "', " &
                                                 "'" & txtEmail.Text & "', " &
                                                 "'" & txtLoginFunc.Text & "', " &
                                                 "'" & txtSenhaFunc.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            sql = "select * from tbfuncionarios where cpf='" & txtCPF.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtDataNasc.Text = rs.Fields(1).Value
                cmbFuncao.Text = rs.Fields(2).Value
                txtNome.Text = rs.Fields(3).Value
                txtCEP.Text = rs.Fields(4).Value
                txtEndereco.Text = rs.Fields(5).Value
                txtComplemento.Text = rs.Fields(6).Value
                txtBairro.Text = rs.Fields(7).Value
                txtCidade.Text = rs.Fields(8).Value
                txtUF.Text = rs.Fields(9).Value
                txtTelefone.Text = rs.Fields(10).Value
                txtCelular.Text = rs.Fields(11).Value
                txtEmail.Text = rs.Fields(12).Value
                txtLoginFunc.Text = rs.Fields(13).Value
                txtSenhaFunc.Text = rs.Fields(14).Value
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
                sql = "delete * from tbfuncionarios where cpf='" & txtCPF.Text & "'"
                rs = db.Execute(sql)
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
                txtEmail.Text = "" Or
                txtLoginFunc.Text = "" Or
                txtSenhaFunc.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "update tbfuncionarios set  cpf = '" & txtCPF.Text & "', " &
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
                                                 "email = '" & txtEmail.Text & "', " &
                                                 "login = '" & txtLoginFunc.Text & "', " &
                                                 "senha = '" & txtSenhaFunc.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados Atualizados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
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
                txtNomePedido.Text = "" Or
                txtDataPedido.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            End If
            sql = "insert into tbpedidos values('" & txtNomePedido.Text & "', " &
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

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        Try
            If txtSenhaFunc.PasswordChar = "•" Then
                txtSenhaFunc.PasswordChar = ""
            Else
                txtSenhaFunc.PasswordChar = "•"
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click
        Try
            If txtCPFCliente.Text = "" Or
                txtDataNascCliente.Text = "" Or
                txtCliente.Text = "" Or
                txtCEPCliente.Text = "" Or
                txtEnderecoCliente.Text = "" Or
                txtComplementoCliente.Text = "" Or
                txtBairroCliente.Text = "" Or
                txtCidadeCliente.Text = "" Or
                txtUFCliente.Text = "" Or
                txtTelefoneCliente.Text = "" Or
                txtCelularCliente.Text = "" Or
                txtEmailCliente.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "insert into tbclientes values('" & txtCPFCliente.Text & "', " &
                                                 "'" & txtDataNascCliente.Text & "', " &
                                                 "'" & txtCliente.Text & "', " &
                                                 "'" & txtCEPCliente.Text & "', " &
                                                 "'" & txtEnderecoCliente.Text & "', " &
                                                 "'" & txtComplementoCliente.Text & "', " &
                                                 "'" & txtBairroCliente.Text & "', " &
                                                 "'" & txtCidadeCliente.Text & "', " &
                                                 "'" & txtUFCliente.Text & "', " &
                                                 "'" & txtTelefoneCliente.Text & "', " &
                                                 "'" & txtCelularCliente.Text & "', " &
                                                 "'" & txtEmailCliente.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados Gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparClientes()
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txtCEPCliente_LostFocus(sender As Object, e As EventArgs) Handles txtCEPCliente.LostFocus
        Try
            sql = "select * from tb_cep where cep='" & txtCEP.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtEnderecoCliente.Text = rs.Fields(1).Value
                txtCidadeCliente.Text = rs.Fields(2).Value
                txtBairroCliente.Text = rs.Fields(3).Value
                txtUFCliente.Text = rs.Fields(4).Value
                txtComplementoCliente.Focus()
            Else
                MsgBox("CEP Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnDeletarCliente_Click(sender As Object, e As EventArgs) Handles btnDeletarCliente.Click
        Try
            If txtCPFCliente.Text = "" Then
                MsgBox("Preencha o Campo do CPF.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                txtCPFCliente.Focus()
                Exit Sub
            End If
            resp = MsgBox("Deseja Realmente Excluir o Registro" + vbCrLf + "CPF: " & txtCPFCliente.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
            If resp = MsgBoxResult.Yes Then
                sql = "delete * from tbclientes where cpf='" & txtCPFCliente.Text & "'"
                rs = db.Execute(sql)
            ElseIf MsgBoxResult.No Then
                Exit Sub
            Else
                MsgBox("CPF Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnPesquisarCliente_Click(sender As Object, e As EventArgs) Handles btnPesquisarCliente.Click
        Try
            sql = "select * from tbclientes where cpf='" & txtCPFCliente.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txtDataNascCliente.Text = rs.Fields(1).Value
                txtCliente.Text = rs.Fields(2).Value
                txtCEPCliente.Text = rs.Fields(3).Value
                txtEnderecoCliente.Text = rs.Fields(4).Value
                txtComplementoCliente.Text = rs.Fields(5).Value
                txtBairroCliente.Text = rs.Fields(6).Value
                txtCidadeCliente.Text = rs.Fields(7).Value
                txtUFCliente.Text = rs.Fields(8).Value
                txtTelefoneCliente.Text = rs.Fields(9).Value
                txtCelularCliente.Text = rs.Fields(10).Value
                txtEmailCliente.Text = rs.Fields(11).Value
            Else
                MsgBox("CPF Não Localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btnAtualizarCliente_Click(sender As Object, e As EventArgs) Handles btnAtualizarCliente.Click
        Try
            If txtCPFCliente.Text = "" Or
                txtDataNascCliente.Text = "" Or
                txtCliente.Text = "" Or
                txtCEPCliente.Text = "" Or
                txtEnderecoCliente.Text = "" Or
                txtComplementoCliente.Text = "" Or
                txtBairroCliente.Text = "" Or
                txtCidadeCliente.Text = "" Or
                txtUFCliente.Text = "" Or
                txtTelefoneCliente.Text = "" Or
                txtCelularCliente.Text = "" Or
                txtEmailCliente.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            Else
                sql = "update tbclientes set  cpf = '" & txtCPFCliente.Text & "', " &
                                                 "dataNasc = '" & txtDataNascCliente.Text & "', " &
                                                 "cliente = '" & txtCliente.Text & "', " &
                                                 "cep = '" & txtCEPCliente.Text & "', " &
                                                 "endereco = '" & txtEnderecoCliente.Text & "', " &
                                                 "comp = '" & txtComplementoCliente.Text & "', " &
                                                 "bairro = '" & txtBairroCliente.Text & "', " &
                                                 "cidade = '" & txtCidadeCliente.Text & "', " &
                                                 "uf = '" & txtUFCliente.Text & "', " &
                                                 "telefone = '" & txtTelefoneCliente.Text & "', " &
                                                 "celular = '" & txtCelularCliente.Text & "', " &
                                                 "email = '" & txtEmailCliente.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados Atualizados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                limparCadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class