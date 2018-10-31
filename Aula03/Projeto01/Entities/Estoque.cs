using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto01.Entities
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }

        //construtor Default
        public Estoque()
        {

        }

        //sobrecarga de construtores - Overloading
        public Estoque(int idEstoque, string nome)
        {
            IdEstoque = idEstoque;
            Nome = nome;
        }

        public Estoque(int idEstoque, string nome, List<Produto> produtos)
            : this(idEstoque, nome)
        {
            IdEstoque = idEstoque;
            Nome = nome;
            Produtos = produtos;
        }

        public override string ToString()
        {
            return $"Id: {IdEstoque}, Nome: {Nome}";
        }
    }
}
