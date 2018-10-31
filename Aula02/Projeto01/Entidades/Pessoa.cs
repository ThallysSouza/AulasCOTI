using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    //public -> acesso total a classe
    public class Pessoa
    {
        //prop + 2x[tab]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }

        //construtor default
        //ctor + 2x[tab]
        public Pessoa()
        {

        }

        //sobrecarga de métodos (overloading)
        public Pessoa(int idPessoa, string nome)
        {
            IdPessoa = idPessoa;
            Nome = nome;
        }
    }
}
