using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities.Types;

namespace Projeto01.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

        //construtor 
        public Cliente()
        {

        }
        //sobrecarga de construtores (overloading)
        public Cliente(int id, string nome, string email, Sexo sexo, EstadoCivil estadoCivil)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Email: {Email}, Sexo: {Sexo},Estado Civil: {EstadoCivil}";
        }
    }

}
