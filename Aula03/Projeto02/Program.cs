using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Controllers;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente(1, "Ana Paula", "anapaula@gmail.com");

            try
            {
                ClienteControle clienteControle = new ClienteControle(); 
                clienteControle.ExportarParaJson(c);

                Console.WriteLine("\nJson gerado com sucesso");

                Cliente clienteObtido = clienteControle.importarJson();

                Console.WriteLine("Dados gravados: " + clienteObtido.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);                
            }

            Console.ReadKey();
        }
    }
}
