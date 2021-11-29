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
        Me.tbLogin = New System.Windows.Forms.TabPage()
        Me.btnPesquisarLogin = New System.Windows.Forms.Button()
        Me.btnAtualizarLogin = New System.Windows.Forms.Button()
        Me.btnDeletarLogin = New System.Windows.Forms.Button()
        Me.chkMostrarSenha = New System.Windows.Forms.CheckBox()
        Me.btnCadastrarLogin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtCadastrarSenha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCadastrarEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCadastrarLogin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRegistrarPedido = New System.Windows.Forms.TabPage()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDataPedido = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.tbControle.SuspendLayout()
        Me.tbInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCadastro.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbLogin.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegistrarPedido.SuspendLayout()
        CType(Me.nmrQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbVisualizarPedidos.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControle
        '
        Me.tbControle.Controls.Add(Me.tbInicio)
        Me.tbControle.Controls.Add(Me.tbCadastro)
        Me.tbControle.Controls.Add(Me.tbLogin)
        Me.tbControle.Controls.Add(Me.tbRegistrarPedido)
        Me.tbControle.Controls.Add(Me.tbVisualizarPedidos)
        Me.tbControle.Location = New System.Drawing.Point(1, 1)
        Me.tbControle.Name = "tbControle"
        Me.tbControle.SelectedIndex = 0
        Me.tbControle.Size = New System.Drawing.Size(588, 424)
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
        Me.tbInicio.Size = New System.Drawing.Size(580, 396)
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
        Me.tbCadastro.Size = New System.Drawing.Size(580, 396)
        Me.tbCadastro.TabIndex = 1
        Me.tbCadastro.Text = "Cadastro"
        Me.tbCadastro.ToolTipText = "Cadastro de Funcionarios"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(314, 338)
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
        Me.btnAtualizar.Location = New System.Drawing.Point(454, 338)
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
        Me.lblTelefone.Location = New System.Drawing.Point(71, 276)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(54, 15)
        Me.lblTelefone.TabIndex = 49
        Me.lblTelefone.Text = "Telefone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(87, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 32)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Cadastro de Funcionários"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(439, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'btnDeletar
        '
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.Location = New System.Drawing.Point(171, 338)
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
        Me.btnCadastar.Location = New System.Drawing.Point(21, 338)
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
        Me.lblNome.Location = New System.Drawing.Point(19, 136)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 15)
        Me.lblNome.TabIndex = 44
        Me.lblNome.Text = "Nome:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(271, 294)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(287, 23)
        Me.txtEmail.TabIndex = 37
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(271, 276)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 43
        Me.lblEmail.Text = "Email:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(171, 294)
        Me.txtCelular.Mask = "(99) 99999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(94, 23)
        Me.txtCelular.TabIndex = 36
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(171, 276)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(47, 15)
        Me.lblCelular.TabIndex = 42
        Me.lblCelular.Text = "Celular:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(71, 294)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(94, 23)
        Me.txtTelefone.TabIndex = 34
        Me.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(21, 294)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(45, 23)
        Me.txtUF.TabIndex = 32
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(21, 276)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 15)
        Me.lblUF.TabIndex = 41
        Me.lblUF.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(333, 243)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(225, 23)
        Me.txtCidade.TabIndex = 31
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(333, 225)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(47, 15)
        Me.lblCidade.TabIndex = 40
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(171, 243)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(156, 23)
        Me.txtBairro.TabIndex = 30
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(171, 225)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(41, 15)
        Me.lblBairro.TabIndex = 39
        Me.lblBairro.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(19, 243)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(144, 23)
        Me.txtComplemento.TabIndex = 28
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(19, 225)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(87, 15)
        Me.lblComplemento.TabIndex = 38
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(117, 199)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(441, 23)
        Me.txtEndereco.TabIndex = 27
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(117, 181)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(59, 15)
        Me.lblEndereco.TabIndex = 35
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(19, 199)
        Me.txtCEP.Mask = "99999-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(83, 23)
        Me.txtCEP.TabIndex = 25
        Me.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(19, 181)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 15)
        Me.lblCEP.TabIndex = 33
        Me.lblCEP.Text = "CEP:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(20, 154)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(538, 23)
        Me.txtNome.TabIndex = 24
        '
        'txtDataNasc
        '
        Me.txtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNasc.Location = New System.Drawing.Point(231, 107)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.Size = New System.Drawing.Size(143, 23)
        Me.txtDataNasc.TabIndex = 29
        Me.txtDataNasc.Value = New Date(2021, 11, 22, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Data Nascimento: "
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(20, 107)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(145, 23)
        Me.txtCPF.TabIndex = 2
        Me.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CPF:"
        '
        'tbLogin
        '
        Me.tbLogin.BackColor = System.Drawing.Color.SkyBlue
        Me.tbLogin.Controls.Add(Me.btnPesquisarLogin)
        Me.tbLogin.Controls.Add(Me.btnAtualizarLogin)
        Me.tbLogin.Controls.Add(Me.btnDeletarLogin)
        Me.tbLogin.Controls.Add(Me.chkMostrarSenha)
        Me.tbLogin.Controls.Add(Me.btnCadastrarLogin)
        Me.tbLogin.Controls.Add(Me.Label8)
        Me.tbLogin.Controls.Add(Me.PictureBox3)
        Me.tbLogin.Controls.Add(Me.txtCadastrarSenha)
        Me.tbLogin.Controls.Add(Me.Label7)
        Me.tbLogin.Controls.Add(Me.txtCadastrarEmail)
        Me.tbLogin.Controls.Add(Me.Label6)
        Me.tbLogin.Controls.Add(Me.txtCadastrarLogin)
        Me.tbLogin.Controls.Add(Me.Label5)
        Me.tbLogin.Location = New System.Drawing.Point(4, 24)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLogin.Size = New System.Drawing.Size(580, 396)
        Me.tbLogin.TabIndex = 2
        Me.tbLogin.Text = "Login"
        Me.tbLogin.ToolTipText = "Cadastro de Login"
        '
        'btnPesquisarLogin
        '
        Me.btnPesquisarLogin.Image = CType(resources.GetObject("btnPesquisarLogin.Image"), System.Drawing.Image)
        Me.btnPesquisarLogin.Location = New System.Drawing.Point(306, 315)
        Me.btnPesquisarLogin.Name = "btnPesquisarLogin"
        Me.btnPesquisarLogin.Size = New System.Drawing.Size(104, 40)
        Me.btnPesquisarLogin.TabIndex = 54
        Me.btnPesquisarLogin.Text = "Pesquisar"
        Me.btnPesquisarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisarLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPesquisarLogin.UseVisualStyleBackColor = True
        '
        'btnAtualizarLogin
        '
        Me.btnAtualizarLogin.Image = CType(resources.GetObject("btnAtualizarLogin.Image"), System.Drawing.Image)
        Me.btnAtualizarLogin.Location = New System.Drawing.Point(431, 315)
        Me.btnAtualizarLogin.Name = "btnAtualizarLogin"
        Me.btnAtualizarLogin.Size = New System.Drawing.Size(104, 40)
        Me.btnAtualizarLogin.TabIndex = 53
        Me.btnAtualizarLogin.Text = "Atualizar"
        Me.btnAtualizarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizarLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtualizarLogin.UseVisualStyleBackColor = True
        '
        'btnDeletarLogin
        '
        Me.btnDeletarLogin.Image = CType(resources.GetObject("btnDeletarLogin.Image"), System.Drawing.Image)
        Me.btnDeletarLogin.Location = New System.Drawing.Point(181, 315)
        Me.btnDeletarLogin.Name = "btnDeletarLogin"
        Me.btnDeletarLogin.Size = New System.Drawing.Size(104, 40)
        Me.btnDeletarLogin.TabIndex = 52
        Me.btnDeletarLogin.Text = "Deletar"
        Me.btnDeletarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeletarLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeletarLogin.UseVisualStyleBackColor = True
        '
        'chkMostrarSenha
        '
        Me.chkMostrarSenha.AutoSize = True
        Me.chkMostrarSenha.Location = New System.Drawing.Point(105, 272)
        Me.chkMostrarSenha.Name = "chkMostrarSenha"
        Me.chkMostrarSenha.Size = New System.Drawing.Size(102, 19)
        Me.chkMostrarSenha.TabIndex = 51
        Me.chkMostrarSenha.Text = "Mostrar Senha"
        Me.chkMostrarSenha.UseVisualStyleBackColor = True
        '
        'btnCadastrarLogin
        '
        Me.btnCadastrarLogin.Image = CType(resources.GetObject("btnCadastrarLogin.Image"), System.Drawing.Image)
        Me.btnCadastrarLogin.Location = New System.Drawing.Point(58, 315)
        Me.btnCadastrarLogin.Name = "btnCadastrarLogin"
        Me.btnCadastrarLogin.Size = New System.Drawing.Size(104, 40)
        Me.btnCadastrarLogin.TabIndex = 50
        Me.btnCadastrarLogin.Text = "Cadastrar"
        Me.btnCadastrarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrarLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCadastrarLogin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(58, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 32)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Cadastro de Login"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(316, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(244, 227)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'txtCadastrarSenha
        '
        Me.txtCadastrarSenha.Location = New System.Drawing.Point(58, 228)
        Me.txtCadastrarSenha.Name = "txtCadastrarSenha"
        Me.txtCadastrarSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtCadastrarSenha.Size = New System.Drawing.Size(207, 23)
        Me.txtCadastrarSenha.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Senha: "
        '
        'txtCadastrarEmail
        '
        Me.txtCadastrarEmail.Location = New System.Drawing.Point(58, 178)
        Me.txtCadastrarEmail.Name = "txtCadastrarEmail"
        Me.txtCadastrarEmail.Size = New System.Drawing.Size(207, 23)
        Me.txtCadastrarEmail.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Email: "
        '
        'txtCadastrarLogin
        '
        Me.txtCadastrarLogin.Location = New System.Drawing.Point(58, 126)
        Me.txtCadastrarLogin.Name = "txtCadastrarLogin"
        Me.txtCadastrarLogin.Size = New System.Drawing.Size(207, 23)
        Me.txtCadastrarLogin.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Login: "
        '
        'tbRegistrarPedido
        '
        Me.tbRegistrarPedido.BackColor = System.Drawing.Color.SkyBlue
        Me.tbRegistrarPedido.Controls.Add(Me.txtNomeCliente)
        Me.tbRegistrarPedido.Controls.Add(Me.Label14)
        Me.tbRegistrarPedido.Controls.Add(Me.txtDataPedido)
        Me.tbRegistrarPedido.Controls.Add(Me.Label13)
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
        Me.tbRegistrarPedido.Size = New System.Drawing.Size(580, 396)
        Me.tbRegistrarPedido.TabIndex = 3
        Me.tbRegistrarPedido.Text = "Registrar Pedidos"
        Me.tbRegistrarPedido.ToolTipText = "Registro de Pedidos"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(73, 171)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(225, 23)
        Me.txtNomeCliente.TabIndex = 57
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
        'txtDataPedido
        '
        Me.txtDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataPedido.Location = New System.Drawing.Point(319, 171)
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.Size = New System.Drawing.Size(143, 23)
        Me.txtDataPedido.TabIndex = 55
        Me.txtDataPedido.Value = New Date(2021, 11, 22, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(319, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 15)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Data Pedido:"
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
        Me.tbVisualizarPedidos.Size = New System.Drawing.Size(580, 396)
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
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 425)
        Me.Controls.Add(Me.tbControle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        Me.tbLogin.ResumeLayout(False)
        Me.tbLogin.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegistrarPedido.ResumeLayout(False)
        Me.tbRegistrarPedido.PerformLayout()
        CType(Me.nmrQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbVisualizarPedidos.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbLogin As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtCadastrarSenha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCadastrarEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCadastrarLogin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCadastrarLogin As Button
    Friend WithEvents chkMostrarSenha As CheckBox
    Friend WithEvents btnPesquisarLogin As Button
    Friend WithEvents btnAtualizarLogin As Button
    Friend WithEvents btnDeletarLogin As Button
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
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDataPedido As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents dataPedido As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents qtdProduto As DataGridViewTextBoxColumn
    Friend WithEvents precoPedido As DataGridViewTextBoxColumn
End Class
