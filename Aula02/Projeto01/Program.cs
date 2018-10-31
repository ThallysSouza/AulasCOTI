using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades; // importando..

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe objeto      espaço em memória/entrada de dados
            Cliente cliente = new Cliente(1,"Ana","12345678900","ana@gmail.com");
            cliente.Endereco = new Endereco(1, "Rua A", "Centro", "Rio de Janeiro", "RJ", "25000-000");            
            
            //imprimindo            
            Console.WriteLine("\nDados do CLiente:");
            Console.WriteLine("\tiD......" + cliente.IdPessoa);
            Console.WriteLine("\tNome......" + cliente.Nome);
            Console.WriteLine("\tCPF......" + cliente.Cpf);
            Console.WriteLine("\tEmail......" + cliente.Email);

            Console.WriteLine("Endereço do Cliente:");
            Console.WriteLine("\tLogradouro......" + cliente.Endereco.Logradouro);
            Console.WriteLine("\tBairro......" + cliente.Endereco.Bairro);
            Console.WriteLine("\tCidade......" + cliente.Endereco.Cidade);
            Console.WriteLine("\tEstado......" + cliente.Endereco.Estado);
            Console.WriteLine("\tCep......" + cliente.Endereco.Cep);
            Console.ReadKey();//pausar..
        }
        
    }
}
