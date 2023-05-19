using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_dia_16
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> marcas = new List<Marca>();

        //metodos
        public Marca Cadastrar()
        {

            Marca m = new Marca();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira o código de sua marca: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            m.Codigo = int.Parse(Console.ReadLine()!);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira o nome da marca: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            m.NomeMarca = Console.ReadLine()!;
            m.DataCadastro = DateTime.Now;
            marcas.Add(m);
            return m;

        }
        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var item in marcas)
            {
                Console.WriteLine($@"
<=><=><=><=><=><=><=><=><=><=><=>

Código: {item.Codigo} 
Nome da Marca: {item.NomeMarca}
Data: {item.DataCadastro}

<=><=><=><=><=><=><=><=><=><=><=>
");
}
        }
         public string Deletar(int codigo)
         {  Console.ForegroundColor = ConsoleColor.Magenta;
            Marca obj = marcas.Find( x => x.Codigo == codigo);
            marcas.Remove(obj);
            return "Você removeu uma marca";
         }
    }
}