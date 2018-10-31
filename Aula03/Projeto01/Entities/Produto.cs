using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome  { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Estoque Estoque { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade, Estoque estoque) 
            : this(idProduto, nome, preco, quantidade)
        {
            Estoque = estoque;
        }

        public override string ToString()
        {
            return $"Id:{IdProduto}, Nome:{ Nome}, Preço: {Preco}, Quantidade:{Quantidade}";
        }
    }
}
