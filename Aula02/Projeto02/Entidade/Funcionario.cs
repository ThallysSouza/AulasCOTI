using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidade
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public Setor Setor { get; set; }


        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario)

        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
        }

        public Funcionario(int idFuncionario, string nome, decimal salario, Setor setor) 
            : this(idFuncionario, nome, salario) //This . construtor da propria classe -- Base construtor da classe  pai
        {
            Setor = setor;
        }
    }
}
