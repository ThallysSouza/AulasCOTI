using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidade;

namespace Projeto02.Impressao
{
    public class FuncionarioImpressao
    {
        //metodos para imprimir os dados no console
        public void Imprimir(Funcionario funcionario)
        {
            Console.WriteLine("\nDados do Funcionario");
            Console.WriteLine("\tId..........:" + funcionario.IdFuncionario);
            Console.WriteLine("\tNome........:" + funcionario.Nome);
            Console.WriteLine("\tSalario.....:" + funcionario.Salario);

        }
    }
}
