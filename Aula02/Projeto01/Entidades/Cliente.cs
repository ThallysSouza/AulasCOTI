using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Cliente : Pessoa
    {
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; } //Associação

        //construtor default
        //ctor+ 2x[tab]
        public Cliente()
        {
                //vazio
        }
        //método de sobrecarga (overloading)
        public Cliente(int idPessoa, string nome, string cpf, string email)
            : base(idPessoa,nome) // executando o contrutor da superclasse
        {
            
            Cpf = cpf;
            Email = email;
        }
    }
}
