using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Entidades
{
    public class Produto
    {
        public int Idproduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(int idproduto, string nome, decimal preco, int quantidade)
        {
            Idproduto = idproduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Id: {Idproduto}, Nome: {Nome}, Preço {Preco}, Quantidade: {Quantidade}";
        }
    }
}
