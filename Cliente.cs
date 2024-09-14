using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesTDE
{
    internal class Cliente
    {

        // Attributes
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Constructor
        public Cliente(int id, string nome, int idade, string endereco, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        // To string -> saida visualização
        public override string ToString()
        {
            return $"[ ID: {Id}, Nome: {Nome}, Idade: {Idade} anos, Localização: {Endereco}, Telefone: {Telefone}; E-mail: {Email} ]";
        }

    }


}
