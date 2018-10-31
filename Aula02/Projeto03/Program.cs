using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto03.Entidades;
namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1,"Notebook", 2000, 2);

            Console.WriteLine("\nDados do Produto:");
            Console.WriteLine("\t" + produto.ToString());

            Console.ReadKey();
        }
    }
}
