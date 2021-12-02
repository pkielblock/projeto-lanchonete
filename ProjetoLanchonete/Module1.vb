Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, login As String
    Public cont, id As Integer
    Public preco, total As Double
    Public resp As String

    Sub connectDb()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};Database=lanchonetexande;Server=localhost;port=3306;UID=root;PWD=usbw;")
        Catch ex As Exception
            MsgBox("Conexão com o banco de dados falhou com o seguinte erro: " & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub sair()
        Try
            resp = MsgBox("Deseja Encerrar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

            If resp = MsgBoxResult.Yes Then
                End
            End If
        Catch ex As Exception
            resp = MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limparCadastro()
        Try
            With frmMenu
                .txtCPF.Clear()
                .txtDataNasc.Text = Date.Now
                .txtNome.Clear()
                .txtCEP.Clear()
                .txtEndereco.Clear()
                .txtComplemento.Clear()
                .txtBairro.Clear()
                .txtCidade.Clear()
                .txtUF.Clear()
                .txtTelefone.Clear()
                .txtCelular.Clear()
                .txtEmail.Clear()
                .txtLoginFunc.Clear()
                .txtSenhaFunc.Clear()
                .txtCPF.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub limparClientes()
        Try
            With frmMenu
                .txtCPFCliente.Clear()
                .txtDataNascCliente.Text = Date.Now
                .txtCliente.Clear()
                .txtCEPCliente.Clear()
                .txtEnderecoCliente.Clear()
                .txtComplementoCliente.Clear()
                .txtBairroCliente.Clear()
                .txtCidadeCliente.Clear()
                .txtUFCliente.Clear()
                .txtTelefoneCliente.Clear()
                .txtCelularCliente.Clear()
                .txtEmailCliente.Clear()
                .txtCPFCliente.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregarDados()
        Try
            sql = "select * from tbpedidos order by cliente asc"
            rs = db.Execute(sql)

            With frmMenu.dgvDados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub

    Sub carregarTotal()
        Try
            Try
                sql = "SELECT * FROM tbpedidos WHERE MONTH(data) = " & frmMenu.cmbMes.Text & " AND YEAR(data) = " & frmMenu.cmbAno.Text & ""
                rs = db.Execute(sql)

                With frmMenu.dgvTotal
                    cont = 0
                    total = 0
                    .Rows.Clear()
                    Do While rs.EOF = False
                        total += rs.Fields(5).Value
                        rs.MoveNext()
                        cont += 1
                    Loop
                    .Rows.Add(total)
                End With
                With frmMenu.dgvTotal
                    .Rows.Clear()
                    .Rows.Add(cont, total)
                End With
            Catch ex As Exception
                MsgBox("Error" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
            End Try
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub
End Module
