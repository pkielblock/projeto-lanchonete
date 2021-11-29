Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, login As String
    Public cont, id As Integer
    Public preco As Double
    Public resp As String

    Sub connectDb()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};Database=lanchonetexande;Server=localhost;port=3307;UID=root;PWD=usbw;")
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
                .txtCPF.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub limparLogin()
        Try
            With frmMenu
                .txtCadastrarLogin.Clear()
                .txtCadastrarEmail.Clear()
                .txtCadastrarSenha.Clear()
                .chkMostrarSenha.Checked = False
                .txtCadastrarLogin.Focus()
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
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning")
        End Try
    End Sub
End Module
