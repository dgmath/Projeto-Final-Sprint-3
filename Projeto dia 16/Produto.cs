using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_dia_16
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        
        public Usuario CadastradoPor { get; private set; }

        List<Produto> ListadeProduto = new List<Produto>();

        public string Cadastrar(Usuario user)
        {
            //Usuario user = new Usuario();
            Produto p = new Produto();
            Marca marca = new Marca();
            p.CadastradoPor = user;
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira o código do seu produto: (Em números) ");

Console.ForegroundColor = ConsoleColor.Blue;
            p.Codigo = int.Parse(Console.ReadLine()!);


        Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira o nome do Produto: ");

Console.ForegroundColor = ConsoleColor.Blue;
            p.NomeProduto = Console.ReadLine()!;
            //p.DataCadastro = DateTime.Now;
    Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira o preço do seu produto: (Em números)");

Console.ForegroundColor = ConsoleColor.Blue;
            p.Preco = float.Parse(Console.ReadLine()!);

            p.Marca = marca.Cadastrar();

                            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Esse produto foi cadastrado por {user.Nome}");
            p.DataCadastro = DateTime.Now;
            ListadeProduto.Add(p);
            return "Produto cadastrado";
            
        }
         public void Listar()
         {
            Usuario user = new Usuario();
Console.ForegroundColor = ConsoleColor.Magenta;
                        foreach (var item in ListadeProduto)

            {
Console.WriteLine($@"
---------------------------------------------
| Código: {item.Codigo}                     
| Nome do Produto: {item.NomeProduto}       
| Preço do Produto: {item.Preco:c2}            
| Marca do produto: {item.Marca.NomeMarca}   
| Cadastrado por: {item.CadastradoPor.Nome}               
| Data: {item.DataCadastro}                  
---------------------------------------------
");
}
         }
         public string Deletar(int codigo)
         {
            Produto obj = ListadeProduto.Find( x => x.Codigo == codigo)!;
            ListadeProduto.Remove(obj);
            return "Você removeu uma marca";
         }
    }
}