using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesTDE
{
    internal class GerenciadorClientes
    {
        private List<Cliente> clientes = new List<Cliente>();

        // Metodos
        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Cliente adicionado com sucesso! \n");
        }

        public void RemoverCliente(int id)
        {

            var cliente = clientes.FirstOrDefault(c => c.Id == id); // FirtsOrDefult pega o primeiro elemento que satisfazer a condição, e nele estou utilizando uma expressão lambda para achar o id correto!
            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente Removido com sucesso! \n");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado! \n");
            }
        }
        public Cliente BuscarCliente(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        public List<Cliente> ListarClientes()
        {
            return clientes;
        }

        public void AtualizarCliente(int id, string nome, int idade, string endereco, string telefone, string email)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! \n");
                return;
            }
            cliente.Nome = nome;
            cliente.Idade = idade;
            cliente.Endereco = endereco;
            cliente.Telefone = telefone;
            cliente.Email = email;

            Console.WriteLine("Cliente atualizado com sucesso! \n");
        }
    }
}
