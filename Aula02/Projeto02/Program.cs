using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidade;
using Projeto02.Impressao;


namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando objetos para a classe funcionario
            Funcionario funcionario1 = new Funcionario(1,"Ana", 3000);
            Funcionario funcionario2 = new Funcionario(2, "Bia", 2500);
            Funcionario funcionario3 = new Funcionario(3, "Rui", 4000);
            Funcionario funcionario4 = new Funcionario(4, "Leo", 5000);

            //declarando um objeto para a classe setor..
            Setor setor = new Setor(1, "Desenvolvimento de Sistemas");
            setor.Funcionarios = new List<Funcionario>();

            //adicionar funcionarios
            setor.Funcionarios.Add(funcionario1);
            setor.Funcionarios.Add(funcionario2);
            setor.Funcionarios.Add(funcionario3);
            setor.Funcionarios.Add(funcionario4);

            //imprimir o setor
            SetorImpressao setorImpressao = new SetorImpressao();
            setorImpressao.Imprimir(setor);

            //imprimir os funcionarios
            FuncionarioImpressao funcionarioImpressao = new FuncionarioImpressao();
                      //classe     declaracao        classe onde esta sendo referenciada
            foreach (Funcionario funcionario in setor.Funcionarios)
            {
                funcionarioImpressao.Imprimir(funcionario);
            }

            for (int i = 0; i < setor.Funcionarios.Count; i++)
            {
                Funcionario funcionario = setor.Funcionarios.ElementAt(i);
                funcionarioImpressao.Imprimir(funcionario);
            }

            Console.ReadKey();//pausar...
        }
    }
}
