using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidade;

namespace Projeto02.Impressao
{
    public class SetorImpressao
    {
        //método para imprimir os dados do setor no console
        public void Imprimir(Setor setor)
        {
            Console.WriteLine("\nDados do setor:");
            Console.WriteLine("\tId....: " + setor.IdSetor);
            Console.WriteLine("\tNome....: " + setor.Nome);
        }
    }
}
