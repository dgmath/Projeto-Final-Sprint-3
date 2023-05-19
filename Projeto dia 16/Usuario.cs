using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_dia_16
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        // public Usuario()
        // {
        //     Cadastrar();
        // }
        //Metodos

        public string Cadastrar()
        {
            Console.WriteLine($"Insira seu Nome de usuario:");
            this.Nome = Console.ReadLine();
            Console.WriteLine($"Insira seu email:");

            this.Email = Console.ReadLine();
            Console.WriteLine($"Insira sua senha:");

            this.Senha = Console.ReadLine();

            this.DataCadastro = DateTime.UtcNow;
            return "Usuario cadastrado";
        }
        public string Deletar(Usuario usuario)
        {

            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
            return "Usuario Deletado";
        }

    }
}