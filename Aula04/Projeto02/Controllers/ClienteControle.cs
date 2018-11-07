using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Contracts;

namespace Projeto02.Controllers
{
    public class ClienteControle : IControle<Cliente>
    {
        public void imprimirDados(Cliente objeto)
        {
            Console.WriteLine("\nDados do Cliente\n");
            Console.WriteLine("Id...:" + objeto.IdCliente);
            Console.WriteLine("Nome...:" + objeto.Nome);
            Console.WriteLine("CPF...:" + objeto.Cpf);

        }
    }
}
