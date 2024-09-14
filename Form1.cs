namespace CadastroClientesTDE
{
    public partial class FormCadastroClientes : Form
    {
        private GerenciadorClientes gerenciador = new GerenciadorClientes();
        private int clienteIdAtual = -1; // Inicialiando um id cliente sendo não selecionado

        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtIdade.Text, out int idade))
            {
                if (idade >= 0 && idade <= 120)
                {
                    string telefone = txtTelefone.Text;
                    int id = gerenciador.ListarClientes().Count + 1; // Gerando um ID simples
                    Cliente novoCliente = new Cliente(id, txtNome.Text, idade, txtEndereco.Text, telefone, txtEmail.Text);
                    gerenciador.AdicionarCliente(novoCliente);
                    AtualizaListaClientes();

                    // Após adicionar o cliente
                    MessageBox.Show("Cliente adicionado com Sucesso!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Digite uma idade válida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Atenção! Digite valores válidos para idade e telefone!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string inputId = Microsoft.VisualBasic.Interaction.InputBox("Digite o id do cliente que deseja remover: "); // a função  Microsoft.VisualBasic.Interaction.InputBox abre um modal na tela para que o usuario digite algo (nesse caso o id) para remover o cliente
            if (int.TryParse(inputId, out int id))
            {
                Cliente clienteRemover = gerenciador.ListarClientes().FirstOrDefault(c => c.Id == id); // busca o primeiro elemento id que é igual ao digitado
                if (clienteRemover != null)
                {
                    gerenciador.RemoverCliente(id);
                    AtualizaListaClientes();

                    // Após a remocão
                    MessageBox.Show("Cliente removido com Sucesso!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Atenção! Digite um Id válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            string inputId = Microsoft.VisualBasic.Interaction.InputBox("Digite o Id do cliente que deseja atualizar: ");
            if (int.TryParse(inputId, out int id))
            {
                Cliente clienteAtualizar = gerenciador.ListarClientes().FirstOrDefault(c => c.Id == id);
                if (clienteAtualizar != null)
                {
                    clienteIdAtual = id; // Armazenando o id do cliente selecionado para atualizar

                    txtNome.Text = clienteAtualizar.Nome;
                    txtIdade.Text = clienteAtualizar.Idade.ToString();
                    txtEndereco.Text = clienteAtualizar.Endereco;
                    txtEmail.Text = clienteAtualizar.Email;
                    txtTelefone.Text = clienteAtualizar.Telefone;
                    MessageBox.Show("Dados do cliente carregados. Faça as alterações e clique em Salvar atualização!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ocultando o botão atualizar e mostrando o botão salvar atualização
                    btnAtualizarCliente.Visible = false;
                    btnSalvarAtualizacao.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Atenção! Digite um Id válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvarAtualizacao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdade.Text, out int idade))
            {
                string telefone = txtTelefone.Text;
                if (idade >= 0 && idade <= 120)
                {
                    gerenciador.AtualizarCliente(clienteIdAtual, txtNome.Text, idade, txtEndereco.Text, txtEmail.Text, telefone);

                    AtualizaListaClientes();
                    MessageBox.Show("Cliente atualizado com sucesso!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    btnSalvarAtualizacao.Visible = false;
                    btnAtualizarCliente.Visible = true;
                }
                else
                {
                    MessageBox.Show("Digite uma idade válida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Atenção! Digite valores válidos para idade e telefone!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizaListaClientes()
        {
            ListClienteBox.Items.Clear();
            ListClienteBox.Items.Add("======== Informações dos Clientes ========\n");
            foreach (var cliente in gerenciador.ListarClientes())
            {
                ListClienteBox.Items.Add(cliente.ToString());
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "(55) - ";
            txtEmail.Text = "";
            clienteIdAtual = -1; //resetando o id após a atualização
        }
    }
}
