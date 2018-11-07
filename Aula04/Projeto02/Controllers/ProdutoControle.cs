using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Contracts;

namespace Projeto02.Controllers
{
    public class ProdutoControle : IControle<Produto>
    {
        public void imprimirDados(Produto objeto)
        {
            Console.WriteLine("\tDADOS DO PRODUTO:\n.");
            Console.WriteLine("Id: \n." + objeto.IdProduto);
            Console.WriteLine("Nome: \n." + objeto.Nome);
            Console.WriteLine("Preço: \n." + objeto.Preco);

        }
    }
}
