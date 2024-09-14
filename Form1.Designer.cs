
namespace CadastroClientesTDE
{
    partial class FormCadastroClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnAdicionarCliente = new Button();
            btnRemoverCliente = new Button();
            btnAtualizarCliente = new Button();
            ListClienteBox = new ListBox();
            btnSalvarAtualizacao = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(331, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(115, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Cadastro de Clientes";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(44, 63);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(140, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(118, 23);
            txtNome.TabIndex = 2;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(44, 99);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(42, 15);
            lblIdade.TabIndex = 3;
            lblIdade.Text = "Idade: ";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(140, 91);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(118, 23);
            txtIdade.TabIndex = 4;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(44, 133);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(90, 15);
            lblEndereco.TabIndex = 5;
            lblEndereco.Text = "Cidade/Estado: ";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(140, 125);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(118, 23);
            txtEndereco.TabIndex = 6;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(44, 175);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(57, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone: ";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(140, 167);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(118, 23);
            txtTelefone.TabIndex = 8;
            txtTelefone.Text = "(55) - ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 212);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(118, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(44, 258);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(90, 56);
            btnAdicionarCliente.TabIndex = 11;
            btnAdicionarCliente.Text = "Adicionar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // btnRemoverCliente
            // 
            btnRemoverCliente.Location = new Point(168, 258);
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Size = new Size(90, 56);
            btnRemoverCliente.TabIndex = 12;
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.UseVisualStyleBackColor = true;
            btnRemoverCliente.Click += btnRemover_Click;
            // 
            // btnAtualizarCliente
            // 
            btnAtualizarCliente.Location = new Point(112, 319);
            btnAtualizarCliente.Name = "btnAtualizarCliente";
            btnAtualizarCliente.Size = new Size(98, 54);
            btnAtualizarCliente.TabIndex = 13;
            btnAtualizarCliente.Text = "Atualizar";
            btnAtualizarCliente.UseVisualStyleBackColor = true;
            btnAtualizarCliente.Click += btnAtualizarCliente_Click;
            // 
            // ListClienteBox
            // 
            ListClienteBox.FormattingEnabled = true;
            ListClienteBox.HorizontalScrollbar = true;
            ListClienteBox.ItemHeight = 15;
            ListClienteBox.Location = new Point(316, 55);
            ListClienteBox.Name = "ListClienteBox";
            ListClienteBox.ScrollAlwaysVisible = true;
            ListClienteBox.Size = new Size(573, 319);
            ListClienteBox.TabIndex = 16;
            ListClienteBox.SelectedIndexChanged += ListClienteBox_Click;
            // 
            // btnSalvarAtualizacao
            // 
            btnSalvarAtualizacao.Location = new Point(112, 320);
            btnSalvarAtualizacao.Name = "btnSalvarAtualizacao";
            btnSalvarAtualizacao.Size = new Size(98, 62);
            btnSalvarAtualizacao.TabIndex = 15;
            btnSalvarAtualizacao.Text = "Salvar Atualização";
            btnSalvarAtualizacao.UseVisualStyleBackColor = true;
            btnSalvarAtualizacao.Visible = false;
            btnSalvarAtualizacao.Click += btnSalvarAtualizacao_Click;
            // 
            // FormCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(btnSalvarAtualizacao);
            Controls.Add(ListClienteBox);
            Controls.Add(btnAtualizarCliente);
            Controls.Add(btnRemoverCliente);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtIdade);
            Controls.Add(lblIdade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(labelTitle);
            Name = "FormCadastroClientes";
            Text = "Cadastro de Clientes";
            Load += FormCadastroClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
        }

        private void ListClienteBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label labelTitle;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblIdade;
        private TextBox txtIdade;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnAdicionarCliente;
        private Button btnRemoverCliente;
        private Button btnAtualizarCliente;
        private ListBox ListClienteBox;
        private Button btnSalvarAtualizacao;
        private DataGridView dgvClientes;
    }
}
