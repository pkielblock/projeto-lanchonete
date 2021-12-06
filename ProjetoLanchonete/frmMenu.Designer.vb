<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.tbControle = New System.Windows.Forms.TabControl()
        Me.tbInicio = New System.Windows.Forms.TabPage()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.lblFuncao = New System.Windows.Forms.Label()
        Me.cmbFuncao = New System.Windows.Forms.ComboBox()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.txtSenhaFunc = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtLoginFunc = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnCadastar = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtDataNasc = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbClientes = New System.Windows.Forms.TabPage()
        Me.btnPesquisarCliente = New System.Windows.Forms.Button()
        Me.btnAtualizarCliente = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnDeletarCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCelularCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTelefoneCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txtUFCliente = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCidadeCliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBairroCliente = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtComplementoCliente = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtEnderecoCliente = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCEPCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtDataNascCliente = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCPFCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbRegistrarPedido = New System.Windows.Forms.TabPage()
        Me.txtNomePedido = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCadastrarPedido = New System.Windows.Forms.Button()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nmrQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProdutos = New System.Windows.Forms.ComboBox()
        Me.tbVisualizarPedidos = New System.Windows.Forms.TabPage()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precoPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbTotalVendas = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
        Me.qtdVendas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbControle.SuspendLayout()
        Me.tbInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCadastro.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbClientes.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegistrarPedido.SuspendLayout()
        CType(Me.nmrQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbVisualizarPedidos.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTotalVendas.SuspendLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControle
        '
        Me.tbControle.Controls.Add(Me.tbInicio)
        Me.tbControle.Controls.Add(Me.tbCadastro)
        Me.tbControle.Controls.Add(Me.tbClientes)
        Me.tbControle.Controls.Add(Me.tbRegistrarPedido)
        Me.tbControle.Controls.Add(Me.tbVisualizarPedidos)
        Me.tbControle.Controls.Add(Me.tbTotalVendas)
        Me.tbControle.Location = New System.Drawing.Point(1, 0)
        Me.tbControle.Name = "tbControle"
        Me.tbControle.SelectedIndex = 0
        Me.tbControle.Size = New System.Drawing.Size(588, 427)
        Me.tbControle.TabIndex = 0
        '
        'tbInicio
        '
        Me.tbInicio.BackColor = System.Drawing.Color.SkyBlue
        Me.tbInicio.Controls.Add(Me.lblUsuario)
        Me.tbInicio.Controls.Add(Me.Label1)
        Me.tbInicio.Controls.Add(Me.PictureBox1)
        Me.tbInicio.Controls.Add(Me.btnSair)
        Me.tbInicio.Location = New System.Drawing.Point(4, 24)
        Me.tbInicio.Name = "tbInicio"
        Me.tbInicio.Padding = New System.Windows.Forms.Padding(3)
        Me.tbInicio.Size = New System.Drawing.Size(580, 399)
        Me.tbInicio.TabIndex = 0
        Me.tbInicio.Text = "Inicio"
        Me.tbInicio.ToolTipText = "Inicio"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Fira Code", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.ForeColor = System.Drawing.Color.Red
        Me.lblUsuario.Location = New System.Drawing.Point(230, 309)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 43)
        Me.lblUsuario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bem-Vindo, Você Está Logado Como: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(175, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(480, 6)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(94, 43)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'tbCadastro
        '
        Me.tbCadastro.BackColor = System.Drawing.Color.SkyBlue
        Me.tbCadastro.Controls.Add(Me.lblFuncao)
        Me.tbCadastro.Controls.Add(Me.cmbFuncao)
        Me.tbCadastro.Controls.Add(Me.chkMostrar)
        Me.tbCadastro.Controls.Add(Me.txtSenhaFunc)
        Me.tbCadastro.Controls.Add(Me.Label28)
        Me.tbCadastro.Controls.Add(Me.txtLoginFunc)
        Me.tbCadastro.Controls.Add(Me.Label30)
        Me.tbCadastro.Controls.Add(Me.btnPesquisar)
        Me.tbCadastro.Controls.Add(Me.btnAtualizar)
        Me.tbCadastro.Controls.Add(Me.lblTelefone)
        Me.tbCadastro.Controls.Add(Me.Label4)
        Me.tbCadastro.Controls.Add(Me.PictureBox2)
        Me.tbCadastro.Controls.Add(Me.btnDeletar)
        Me.tbCadastro.Controls.Add(Me.btnCadastar)
        Me.tbCadastro.Controls.Add(Me.lblNome)
        Me.tbCadastro.Controls.Add(Me.txtEmail)
        Me.tbCadastro.Controls.Add(Me.lblEmail)
        Me.tbCadastro.Controls.Add(Me.txtCelular)
        Me.tbCadastro.Controls.Add(Me.lblCelular)
        Me.tbCadastro.Controls.Add(Me.txtTelefone)
        Me.tbCadastro.Controls.Add(Me.txtUF)
        Me.tbCadastro.Controls.Add(Me.lblUF)
        Me.tbCadastro.Controls.Add(Me.txtCidade)
        Me.tbCadastro.Controls.Add(Me.lblCidade)
        Me.tbCadastro.Controls.Add(Me.txtBairro)
        Me.tbCadastro.Controls.Add(Me.lblBairro)
        Me.tbCadastro.Controls.Add(Me.txtComplemento)
        Me.tbCadastro.Controls.Add(Me.lblComplemento)
        Me.tbCadastro.Controls.Add(Me.txtEndereco)
        Me.tbCadastro.Controls.Add(Me.lblEndereco)
        Me.tbCadastro.Controls.Add(Me.txtCEP)
        Me.tbCadastro.Controls.Add(Me.lblCEP)
        Me.tbCadastro.Controls.Add(Me.txtNome)
        Me.tbCadastro.Controls.Add(Me.txtDataNasc)
        Me.tbCadastro.Controls.Add(Me.Label3)
        Me.tbCadastro.Controls.Add(Me.txtCPF)
        Me.tbCadastro.Controls.Add(Me.Label2)
        Me.tbCadastro.Location = New System.Drawing.Point(4, 24)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(580, 399)
        Me.tbCadastro.TabIndex = 1
        Me.tbCadastro.Text = "Funcionários"
        Me.tbCadastro.ToolTipText = "Cadastro de Funcionarios"
        '
        'lblFuncao
        '
        Me.lblFuncao.AutoSize = True
        Me.lblFuncao.Location = New System.Drawing.Point(320, 45)
        Me.lblFuncao.Name = "lblFuncao"
        Me.lblFuncao.Size = New System.Drawing.Size(52, 15)
        Me.lblFuncao.TabIndex = 60
        Me.lblFuncao.Text = "Função: "
        '
        'cmbFuncao
        '
        Me.cmbFuncao.FormattingEnabled = True
        Me.cmbFuncao.Items.AddRange(New Object() {"Dono", "Atendente", "Cozinheiro"})
        Me.cmbFuncao.Location = New System.Drawing.Point(320, 63)
        Me.cmbFuncao.Name = "cmbFuncao"
        Me.cmbFuncao.Size = New System.Drawing.Size(160, 23)
        Me.cmbFuncao.TabIndex = 59
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.Location = New System.Drawing.Point(456, 304)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(102, 19)
        Me.chkMostrar.TabIndex = 58
        Me.chkMostrar.Text = "Mostrar Senha"
        Me.chkMostrar.UseVisualStyleBackColor = True
        '
        'txtSenhaFunc
        '
        Me.txtSenhaFunc.Location = New System.Drawing.Point(252, 302)
        Me.txtSenhaFunc.Name = "txtSenhaFunc"
        Me.txtSenhaFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtSenhaFunc.Size = New System.Drawing.Size(198, 23)
        Me.txtSenhaFunc.TabIndex = 57
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(252, 284)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 15)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "Senha: "
        '
        'txtLoginFunc
        '
        Me.txtLoginFunc.Location = New System.Drawing.Point(21, 302)
        Me.txtLoginFunc.Name = "txtLoginFunc"
        Me.txtLoginFunc.Size = New System.Drawing.Size(210, 23)
        Me.txtLoginFunc.TabIndex = 53
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(20, 282)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 15)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Login: "
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(318, 349)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(104, 40)
        Me.btnPesquisar.TabIndex = 51
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Image = CType(resources.GetObject("btnAtualizar.Image"), System.Drawing.Image)
        Me.btnAtualizar.Location = New System.Drawing.Point(454, 349)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(104, 40)
        Me.btnAtualizar.TabIndex = 50
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(71, 232)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(54, 15)
        Me.lblTelefone.TabIndex = 49
        Me.lblTelefone.Text = "Telefone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(97, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 32)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Cadastro de Funcionários"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(496, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'btnDeletar
        '
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.Location = New System.Drawing.Point(171, 349)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(104, 40)
        Me.btnDeletar.TabIndex = 46
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnCadastar
        '
        Me.btnCadastar.Image = CType(resources.GetObject("btnCadastar.Image"), System.Drawing.Image)
        Me.btnCadastar.Location = New System.Drawing.Point(21, 349)
        Me.btnCadastar.Name = "btnCadastar"
        Me.btnCadastar.Size = New System.Drawing.Size(104, 40)
        Me.btnCadastar.TabIndex = 45
        Me.btnCadastar.Text = "Cadastrar"
        Me.btnCadastar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCadastar.UseVisualStyleBackColor = True
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(19, 92)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 15)
        Me.lblNome.TabIndex = 44
        Me.lblNome.Text = "Nome:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(288, 250)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 23)
        Me.txtEmail.TabIndex = 37
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(288, 232)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 43
        Me.lblEmail.Text = "Email:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(171, 250)
        Me.txtCelular.Mask = "(99) 99999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(104, 23)
        Me.txtCelular.TabIndex = 36
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(171, 232)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(47, 15)
        Me.lblCelular.TabIndex = 42
        Me.lblCelular.Text = "Celular:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(71, 250)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(94, 23)
        Me.txtTelefone.TabIndex = 34
        Me.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(21, 250)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(45, 23)
        Me.txtUF.TabIndex = 32
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(21, 232)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 15)
        Me.lblUF.TabIndex = 41
        Me.lblUF.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(333, 199)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(225, 23)
        Me.txtCidade.TabIndex = 31
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(333, 181)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(47, 15)
        Me.lblCidade.TabIndex = 40
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(171, 199)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(156, 23)
        Me.txtBairro.TabIndex = 30
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(171, 181)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(41, 15)
        Me.lblBairro.TabIndex = 39
        Me.lblBairro.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(19, 199)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(144, 23)
        Me.txtComplemento.TabIndex = 28
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(19, 181)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(87, 15)
        Me.lblComplemento.TabIndex = 38
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(117, 155)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(441, 23)
        Me.txtEndereco.TabIndex = 27
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(117, 137)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(59, 15)
        Me.lblEndereco.TabIndex = 35
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(19, 155)
        Me.txtCEP.Mask = "99999-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(83, 23)
        Me.txtCEP.TabIndex = 25
        Me.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(19, 137)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 15)
        Me.lblCEP.TabIndex = 33
        Me.lblCEP.Text = "CEP:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(20, 110)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(538, 23)
        Me.txtNome.TabIndex = 24
        '
        'txtDataNasc
        '
        Me.txtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNasc.Location = New System.Drawing.Point(171, 63)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.Size = New System.Drawing.Size(143, 23)
        Me.txtDataNasc.TabIndex = 29
        Me.txtDataNasc.Value = New Date(2021, 11, 22, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Data Nascimento: "
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(20, 63)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(145, 23)
        Me.txtCPF.TabIndex = 2
        Me.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CPF:"
        '
        'tbClientes
        '
        Me.tbClientes.BackColor = System.Drawing.Color.SkyBlue
        Me.tbClientes.Controls.Add(Me.btnPesquisarCliente)
        Me.tbClientes.Controls.Add(Me.btnAtualizarCliente)
        Me.tbClientes.Controls.Add(Me.Label15)
        Me.tbClientes.Controls.Add(Me.Label16)
        Me.tbClientes.Controls.Add(Me.PictureBox4)
        Me.tbClientes.Controls.Add(Me.btnDeletarCliente)
        Me.tbClientes.Controls.Add(Me.btnCadastrarCliente)
        Me.tbClientes.Controls.Add(Me.Label17)
        Me.tbClientes.Controls.Add(Me.txtEmailCliente)
        Me.tbClientes.Controls.Add(Me.Label18)
        Me.tbClientes.Controls.Add(Me.txtCelularCliente)
        Me.tbClientes.Controls.Add(Me.Label19)
        Me.tbClientes.Controls.Add(Me.txtTelefoneCliente)
        Me.tbClientes.Controls.Add(Me.txtUFCliente)
        Me.tbClientes.Controls.Add(Me.Label20)
        Me.tbClientes.Controls.Add(Me.txtCidadeCliente)
        Me.tbClientes.Controls.Add(Me.Label21)
        Me.tbClientes.Controls.Add(Me.txtBairroCliente)
        Me.tbClientes.Controls.Add(Me.Label22)
        Me.tbClientes.Controls.Add(Me.txtComplementoCliente)
        Me.tbClientes.Controls.Add(Me.Label23)
        Me.tbClientes.Controls.Add(Me.txtEnderecoCliente)
        Me.tbClientes.Controls.Add(Me.Label24)
        Me.tbClientes.Controls.Add(Me.txtCEPCliente)
        Me.tbClientes.Controls.Add(Me.Label25)
        Me.tbClientes.Controls.Add(Me.txtCliente)
        Me.tbClientes.Controls.Add(Me.txtDataNascCliente)
        Me.tbClientes.Controls.Add(Me.Label26)
        Me.tbClientes.Controls.Add(Me.txtCPFCliente)
        Me.tbClientes.Controls.Add(Me.Label27)
        Me.tbClientes.Location = New System.Drawing.Point(4, 24)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClientes.Size = New System.Drawing.Size(580, 399)
        Me.tbClientes.TabIndex = 5
        Me.tbClientes.Text = "Clientes"
        '
        'btnPesquisarCliente
        '
        Me.btnPesquisarCliente.Image = CType(resources.GetObject("btnPesquisarCliente.Image"), System.Drawing.Image)
        Me.btnPesquisarCliente.Location = New System.Drawing.Point(316, 336)
        Me.btnPesquisarCliente.Name = "btnPesquisarCliente"
        Me.btnPesquisarCliente.Size = New System.Drawing.Size(104, 40)
        Me.btnPesquisarCliente.TabIndex = 81
        Me.btnPesquisarCliente.Text = "Pesquisar"
        Me.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPesquisarCliente.UseVisualStyleBackColor = True
        '
        'btnAtualizarCliente
        '
        Me.btnAtualizarCliente.Image = CType(resources.GetObject("btnAtualizarCliente.Image"), System.Drawing.Image)
        Me.btnAtualizarCliente.Location = New System.Drawing.Point(456, 336)
        Me.btnAtualizarCliente.Name = "btnAtualizarCliente"
        Me.btnAtualizarCliente.Size = New System.Drawing.Size(104, 40)
        Me.btnAtualizarCliente.TabIndex = 80
        Me.btnAtualizarCliente.Text = "Atualizar"
        Me.btnAtualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtualizarCliente.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(73, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 15)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Telefone:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(89, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(233, 32)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Cadastro de Clientes"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(441, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(119, 108)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 77
        Me.PictureBox4.TabStop = False
        '
        'btnDeletarCliente
        '
        Me.btnDeletarCliente.Image = CType(resources.GetObject("btnDeletarCliente.Image"), System.Drawing.Image)
        Me.btnDeletarCliente.Location = New System.Drawing.Point(173, 336)
        Me.btnDeletarCliente.Name = "btnDeletarCliente"
        Me.btnDeletarCliente.Size = New System.Drawing.Size(104, 40)
        Me.btnDeletarCliente.TabIndex = 76
        Me.btnDeletarCliente.Text = "Deletar"
        Me.btnDeletarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeletarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeletarCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.Image = CType(resources.GetObject("btnCadastrarCliente.Image"), System.Drawing.Image)
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(23, 336)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(104, 40)
        Me.btnCadastrarCliente.TabIndex = 75
        Me.btnCadastrarCliente.Text = "Cadastrar"
        Me.btnCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 134)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 15)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "Nome:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(273, 292)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(287, 23)
        Me.txtEmailCliente.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(273, 274)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 15)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Email:"
        '
        'txtCelularCliente
        '
        Me.txtCelularCliente.Location = New System.Drawing.Point(173, 292)
        Me.txtCelularCliente.Mask = "(99) 99999-9999"
        Me.txtCelularCliente.Name = "txtCelularCliente"
        Me.txtCelularCliente.Size = New System.Drawing.Size(94, 23)
        Me.txtCelularCliente.TabIndex = 66
        Me.txtCelularCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(173, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Celular:"
        '
        'txtTelefoneCliente
        '
        Me.txtTelefoneCliente.Location = New System.Drawing.Point(73, 292)
        Me.txtTelefoneCliente.Mask = "(99) 9999-9999"
        Me.txtTelefoneCliente.Name = "txtTelefoneCliente"
        Me.txtTelefoneCliente.Size = New System.Drawing.Size(94, 23)
        Me.txtTelefoneCliente.TabIndex = 64
        Me.txtTelefoneCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUFCliente
        '
        Me.txtUFCliente.Location = New System.Drawing.Point(23, 292)
        Me.txtUFCliente.Name = "txtUFCliente"
        Me.txtUFCliente.Size = New System.Drawing.Size(45, 23)
        Me.txtUFCliente.TabIndex = 62
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 274)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 15)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "UF:"
        '
        'txtCidadeCliente
        '
        Me.txtCidadeCliente.Location = New System.Drawing.Point(335, 241)
        Me.txtCidadeCliente.Name = "txtCidadeCliente"
        Me.txtCidadeCliente.Size = New System.Drawing.Size(225, 23)
        Me.txtCidadeCliente.TabIndex = 61
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(335, 223)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 15)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Cidade:"
        '
        'txtBairroCliente
        '
        Me.txtBairroCliente.Location = New System.Drawing.Point(173, 241)
        Me.txtBairroCliente.Name = "txtBairroCliente"
        Me.txtBairroCliente.Size = New System.Drawing.Size(156, 23)
        Me.txtBairroCliente.TabIndex = 60
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(173, 223)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 15)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Bairro:"
        '
        'txtComplementoCliente
        '
        Me.txtComplementoCliente.Location = New System.Drawing.Point(21, 241)
        Me.txtComplementoCliente.Name = "txtComplementoCliente"
        Me.txtComplementoCliente.Size = New System.Drawing.Size(144, 23)
        Me.txtComplementoCliente.TabIndex = 58
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(21, 223)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 15)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Complemento:"
        '
        'txtEnderecoCliente
        '
        Me.txtEnderecoCliente.Location = New System.Drawing.Point(119, 197)
        Me.txtEnderecoCliente.Name = "txtEnderecoCliente"
        Me.txtEnderecoCliente.Size = New System.Drawing.Size(441, 23)
        Me.txtEnderecoCliente.TabIndex = 57
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(119, 179)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 15)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Endereço:"
        '
        'txtCEPCliente
        '
        Me.txtCEPCliente.Location = New System.Drawing.Point(21, 197)
        Me.txtCEPCliente.Mask = "99999-999"
        Me.txtCEPCliente.Name = "txtCEPCliente"
        Me.txtCEPCliente.Size = New System.Drawing.Size(83, 23)
        Me.txtCEPCliente.TabIndex = 55
        Me.txtCEPCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 179)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 15)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "CEP:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(22, 152)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(538, 23)
        Me.txtCliente.TabIndex = 54
        '
        'txtDataNascCliente
        '
        Me.txtDataNascCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNascCliente.Location = New System.Drawing.Point(233, 105)
        Me.txtDataNascCliente.Name = "txtDataNascCliente"
        Me.txtDataNascCliente.Size = New System.Drawing.Size(143, 23)
        Me.txtDataNascCliente.TabIndex = 59
        Me.txtDataNascCliente.Value = New Date(2021, 11, 22, 0, 0, 0, 0)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(233, 87)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 15)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Data Nascimento: "
        '
        'txtCPFCliente
        '
        Me.txtCPFCliente.Location = New System.Drawing.Point(22, 105)
        Me.txtCPFCliente.Mask = "999.999.999-99"
        Me.txtCPFCliente.Name = "txtCPFCliente"
        Me.txtCPFCliente.Size = New System.Drawing.Size(145, 23)
        Me.txtCPFCliente.TabIndex = 53
        Me.txtCPFCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(23, 87)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 15)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "CPF:"
        '
        'tbRegistrarPedido
        '
        Me.tbRegistrarPedido.BackColor = System.Drawing.Color.SkyBlue
        Me.tbRegistrarPedido.Controls.Add(Me.txtNomePedido)
        Me.tbRegistrarPedido.Controls.Add(Me.Label14)
        Me.tbRegistrarPedido.Controls.Add(Me.btnCadastrarPedido)
        Me.tbRegistrarPedido.Controls.Add(Me.lblPreco)
        Me.tbRegistrarPedido.Controls.Add(Me.Label12)
        Me.tbRegistrarPedido.Controls.Add(Me.Label11)
        Me.tbRegistrarPedido.Controls.Add(Me.nmrQuantidade)
        Me.tbRegistrarPedido.Controls.Add(Me.Label10)
        Me.tbRegistrarPedido.Controls.Add(Me.Label9)
        Me.tbRegistrarPedido.Controls.Add(Me.cmbProdutos)
        Me.tbRegistrarPedido.Location = New System.Drawing.Point(4, 24)
        Me.tbRegistrarPedido.Name = "tbRegistrarPedido"
        Me.tbRegistrarPedido.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegistrarPedido.Size = New System.Drawing.Size(580, 399)
        Me.tbRegistrarPedido.TabIndex = 3
        Me.tbRegistrarPedido.Text = "Registrar Pedidos"
        Me.tbRegistrarPedido.ToolTipText = "Registro de Pedidos"
        '
        'txtNomePedido
        '
        Me.txtNomePedido.Location = New System.Drawing.Point(73, 171)
        Me.txtNomePedido.Name = "txtNomePedido"
        Me.txtNomePedido.Size = New System.Drawing.Size(389, 23)
        Me.txtNomePedido.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(73, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 15)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Nome Cliente: "
        '
        'btnCadastrarPedido
        '
        Me.btnCadastrarPedido.Image = CType(resources.GetObject("btnCadastrarPedido.Image"), System.Drawing.Image)
        Me.btnCadastrarPedido.Location = New System.Drawing.Point(198, 307)
        Me.btnCadastrarPedido.Name = "btnCadastrarPedido"
        Me.btnCadastrarPedido.Size = New System.Drawing.Size(155, 68)
        Me.btnCadastrarPedido.TabIndex = 53
        Me.btnCadastrarPedido.Text = "Cadastrar"
        Me.btnCadastrarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCadastrarPedido.UseVisualStyleBackColor = True
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPreco.ForeColor = System.Drawing.Color.Red
        Me.lblPreco.Location = New System.Drawing.Point(368, 234)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(71, 32)
        Me.lblPreco.TabIndex = 52
        Me.lblPreco.Text = "00.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(92, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(231, 32)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Preço:                  R$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(168, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(224, 32)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Registro de Pedidos"
        '
        'nmrQuantidade
        '
        Me.nmrQuantidade.Location = New System.Drawing.Point(319, 109)
        Me.nmrQuantidade.Name = "nmrQuantidade"
        Me.nmrQuantidade.Size = New System.Drawing.Size(143, 23)
        Me.nmrQuantidade.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(319, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Quantidade: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Produto: "
        '
        'cmbProdutos
        '
        Me.cmbProdutos.FormattingEnabled = True
        Me.cmbProdutos.Location = New System.Drawing.Point(73, 108)
        Me.cmbProdutos.Name = "cmbProdutos"
        Me.cmbProdutos.Size = New System.Drawing.Size(225, 23)
        Me.cmbProdutos.TabIndex = 0
        '
        'tbVisualizarPedidos
        '
        Me.tbVisualizarPedidos.BackColor = System.Drawing.Color.SkyBlue
        Me.tbVisualizarPedidos.Controls.Add(Me.dgvDados)
        Me.tbVisualizarPedidos.Location = New System.Drawing.Point(4, 24)
        Me.tbVisualizarPedidos.Name = "tbVisualizarPedidos"
        Me.tbVisualizarPedidos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVisualizarPedidos.Size = New System.Drawing.Size(580, 399)
        Me.tbVisualizarPedidos.TabIndex = 4
        Me.tbVisualizarPedidos.Text = "Visualizar Pedidos"
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cliente, Me.dataPedido, Me.produto, Me.qtdProduto, Me.precoPedido})
        Me.dgvDados.Location = New System.Drawing.Point(0, 0)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.RowTemplate.Height = 25
        Me.dgvDados.Size = New System.Drawing.Size(580, 396)
        Me.dgvDados.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        '
        'dataPedido
        '
        Me.dataPedido.HeaderText = "Data"
        Me.dataPedido.Name = "dataPedido"
        '
        'produto
        '
        Me.produto.HeaderText = "Produto"
        Me.produto.Name = "produto"
        '
        'qtdProduto
        '
        Me.qtdProduto.HeaderText = "Quantidade"
        Me.qtdProduto.Name = "qtdProduto"
        '
        'precoPedido
        '
        Me.precoPedido.HeaderText = "Preço"
        Me.precoPedido.Name = "precoPedido"
        '
        'tbTotalVendas
        '
        Me.tbTotalVendas.Controls.Add(Me.Label7)
        Me.tbTotalVendas.Controls.Add(Me.Label6)
        Me.tbTotalVendas.Controls.Add(Me.cmbAno)
        Me.tbTotalVendas.Controls.Add(Me.cmbMes)
        Me.tbTotalVendas.Controls.Add(Me.dgvTotal)
        Me.tbTotalVendas.Location = New System.Drawing.Point(4, 24)
        Me.tbTotalVendas.Name = "tbTotalVendas"
        Me.tbTotalVendas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTotalVendas.Size = New System.Drawing.Size(580, 399)
        Me.tbTotalVendas.TabIndex = 6
        Me.tbTotalVendas.Text = "Total de Vendas"
        Me.tbTotalVendas.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(460, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Ano"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(334, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mês"
        '
        'cmbAno
        '
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033"})
        Me.cmbAno.Location = New System.Drawing.Point(420, 27)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(121, 23)
        Me.cmbAno.TabIndex = 2
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(293, 27)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 23)
        Me.cmbMes.TabIndex = 1
        '
        'dgvTotal
        '
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.qtdVendas, Me.valorTotal})
        Me.dgvTotal.Location = New System.Drawing.Point(0, 0)
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.RowTemplate.Height = 25
        Me.dgvTotal.Size = New System.Drawing.Size(577, 396)
        Me.dgvTotal.TabIndex = 0
        '
        'qtdVendas
        '
        Me.qtdVendas.HeaderText = "Qtd Vendas"
        Me.qtdVendas.Name = "qtdVendas"
        '
        'valorTotal
        '
        Me.valorTotal.HeaderText = "Valor Total"
        Me.valorTotal.Name = "valorTotal"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 425)
        Me.Controls.Add(Me.tbControle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.tbControle.ResumeLayout(False)
        Me.tbInicio.ResumeLayout(False)
        Me.tbInicio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCadastro.ResumeLayout(False)
        Me.tbCadastro.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegistrarPedido.ResumeLayout(False)
        Me.tbRegistrarPedido.PerformLayout()
        CType(Me.nmrQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbVisualizarPedidos.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTotalVendas.ResumeLayout(False)
        Me.tbTotalVendas.PerformLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbControle As TabControl
    Friend WithEvents tbInicio As TabPage
    Friend WithEvents tbCadastro As TabPage
    Friend WithEvents btnSair As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnCadastar As Button
    Friend WithEvents lblNome As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtUF As TextBox
    Friend WithEvents lblUF As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtDataNasc As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents tbRegistrarPedido As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProdutos As ComboBox
    Friend WithEvents nmrQuantidade As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCadastrarPedido As Button
    Friend WithEvents lblPreco As Label
    Friend WithEvents tbVisualizarPedidos As TabPage
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDataPedido As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents dataPedido As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents qtdProduto As DataGridViewTextBoxColumn
    Friend WithEvents precoPedido As DataGridViewTextBoxColumn
    Friend WithEvents chkMostrar As CheckBox
    Friend WithEvents txtSenhaFunc As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtLoginFunc As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents tbClientes As TabPage
    Friend WithEvents btnPesquisarCliente As Button
    Friend WithEvents btnAtualizarCliente As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnDeletarCliente As Button
    Friend WithEvents btnCadastrarCliente As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCelularCliente As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTelefoneCliente As MaskedTextBox
    Friend WithEvents txtUFCliente As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCidadeCliente As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBairroCliente As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtComplementoCliente As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtEnderecoCliente As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtCEPCliente As MaskedTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtDataNascCliente As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents txtCPFCliente As MaskedTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tbTotalVendas As TabPage
    Friend WithEvents dgvTotal As DataGridView
    Friend WithEvents lblFuncao As Label
    Friend WithEvents cmbFuncao As ComboBox
    Friend WithEvents txtNomePedido As TextBox
    Friend WithEvents qtdVendas As DataGridViewTextBoxColumn
    Friend WithEvents valorTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbAno As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents Label7 As Label
End Class
