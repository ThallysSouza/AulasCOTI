using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Controllers;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando objetos
            Estoque estoque = new Estoque(1, "Informatica");
            estoque.Produtos = new List<Produto>();

            Produto produto1 = new Produto(1, "Monitor", 400, 2, estoque);
            Produto produto2 = new Produto(2, "Teclado", 100, 4, estoque);

            //adicionar os produtos na lista
            estoque.Produtos.Add(produto1);
            estoque.Produtos.Add(produto2);

            //gerando os arquivos 
            EstoqueControle estoqueControle = new EstoqueControle();
            ProdutoControle produtoControle = new ProdutoControle();

            try
            {
                estoqueControle.ExportarParaTxt(estoque);
                Console.WriteLine("\nEstoque gravado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                throw;
            }


            try
            {
                produtoControle.ExportarParaXml(produto1);
                Console.WriteLine("\nProduto gravado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                throw;
            }

            //pausar...
            Console.ReadKey();
        }
    }
}
