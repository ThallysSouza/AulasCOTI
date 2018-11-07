using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Entities.Types;
using Projeto01.Controllers;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Ana Paula", "anapaula@gmail.com", Sexo.Feminino, EstadoCivil.Casado);
            Cliente c2 = new Cliente(2, "Ana Maria", "anamaria@gmail.com", Sexo.Feminino, EstadoCivil.Solteiro);
            Cliente c3 = new Cliente(3, "Joao Pedro", "joaopedro@gmail.com", Sexo.Masculino, EstadoCivil.Solteiro);

            //instnciar a classe de controle

            var controle = new ClienteControleLINQ();
            controle.Clientes = new List<Cliente>();

            controle.Clientes.Add(c1);
            controle.Clientes.Add(c2);
            controle.Clientes.Add(c3);

            Console.Write("\nFILTRO DE CLIENTES POR NOME\n");

            Console.Write("Informe um nome.....:");
            string nome = Console.ReadLine();

            var resultado = controle.FiltrarPorNome(nome);
            if (resultado.Count > 0)
            {
                foreach (Cliente c in resultado)
                {
                    Console.WriteLine("\tCliente: " + c.ToString());
                }
            }
            else
            {
                Console.WriteLine("\tNenhum Cliente foi encontrado.");
            }

            Console.ReadKey();

        }
    }
}
