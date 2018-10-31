using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Contracts;
using Projeto01.Entities;
using System.IO;

namespace Projeto01.Controllers
{
    //implementando a interface
    public class EstoqueControle : IEstoqueControle
    {
        //implementando o metodo abstrato da interface
        public void ExportarParaTxt(Estoque estoque)
        {
            StreamWriter streamWriter = new StreamWriter("c:\\temp\\estoques.txt", true);

            streamWriter.WriteLine("Id do Estoque...:" + estoque.IdEstoque);
            streamWriter.WriteLine("Nome............:" + estoque.Nome);

            //verificar se o objeto contem produtos..
            if (estoque.Produtos.Count > 0)
            {
                //varrer a lista de produtos
                foreach(Produto produto in estoque.Produtos)
                {
                    streamWriter.WriteLine("\tId do Produto........:" + produto.IdProduto);
                    streamWriter.WriteLine("\tNome........:" + produto.Nome);
                    streamWriter.WriteLine("\tPreço........:" + produto.Preco);
                    streamWriter.WriteLine("\tQuantidade........:" + produto.Quantidade);
                }
            }

            streamWriter.Close();
        }
    }
}
