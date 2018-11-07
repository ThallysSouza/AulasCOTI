using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Controllers;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.IdProduto = 1;
            p.Nome = "Notebook";
            p.Preco = 2000;

            ProdutoControle pc = new ProdutoControle();
            pc.imprimirDados(p);
            Console.ReadKey();

        }
    }
}
