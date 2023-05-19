using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_dia_16
{
    public class Login
    {
        //Usuario usuario = new Usuario();
        public bool Logado { get; private set; }

        public Login()
        {
            Usuario user = new Usuario();
            user.Cadastrar();
            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu(user);
            }
            else
            {
                Console.WriteLine($"Usuario invalido!");

            }
        }

        public string Logar(Usuario user)
        {
            Console.WriteLine($"Insira o seu nome: ");
            string nomeDigitado = Console.ReadLine();

            Console.WriteLine($"Informe o seu email: ");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"Informe a sua senha: ");
            string senhaDigitada = Console.ReadLine();

            if (emailDigitado == user.Email && senhaDigitada == user.Senha)
            {
                this.Logado = true;
                return "Login efetuado com Sucesso! :) ";
            }
            else
            {
                this.Logado = false;
                return "Falha ao efetuar Login! :( ";
            }
        }

        public void Deslogar()
        {
            this.Logado = false;
        }

        public void GerarMenu(Usuario user)
        {
            Marca marca = new Marca();
            Produto produto = new Produto();
            string resposta;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"

------------------------------
|[1] - Cadastrar seu produto |
|[2] - Listar seus produtos  |
|[3] - Remover seu produto   |
|--------------------------- |
|[4] - Cadastrar sua marca   |
|[5] - Listar suas marcas    |
|[6] - Remover sua marca     |
|                            |
|        [0] - Sair          |
------------------------------

 ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                resposta = Console.ReadLine();
                Console.ResetColor();

                switch (resposta)
                {
                    case "1":
                        produto.Cadastrar(user);
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Informe o código do produto que será excluido: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        int codigoProd = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProd);
                        Console.WriteLine($"O Produto com o código {produto.Codigo} foi removido com sucesso!");
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Informe o código da marca que será excluida: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        int codigoMarc = int.Parse(Console.ReadLine());
                        marca.Deletar(codigoMarc);
                        break;
                    case "7":
                        Deslogar();
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Fehando o programa");
                        Console.Write($".");
                        Console.Beep(1000, 500);
                        Console.Write($".");
                        Console.Beep(1000, 500);
                        Console.Write($".");
                        Console.Beep(1000, 500);
                        break;

                    default:
                        Console.WriteLine($"Por favor insira um caractere valido!");

                        break;
                }
            } while (resposta != "0");

        }

    }
}