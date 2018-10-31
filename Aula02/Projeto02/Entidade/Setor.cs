using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidade
{
    public class Setor
    {
        public int IdSetor { get; set; }
        public string Nome{ get; set; }
        public List<Funcionario> Funcionarios { get; set; } // Associação (TER - Muitos)


        public Setor()
        {

        }

        public Setor(int idSetor, string nome)
        {
            IdSetor = idSetor;
            Nome = nome;
        }

        public Setor(int idSetor, string nome, List<Funcionario> funcionarios) : this(idSetor, nome)
        {
            Funcionarios = funcionarios;
        }
    }
}
