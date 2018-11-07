using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Entities.Types;
using Projeto01.Abstracts;

namespace Projeto01.Controllers
{
    public class ClienteControleLAMBDA : ClienteControleAbstract
    {
        public override List<Cliente> FiltrarPorEstadoCivil(EstadoCivil estadoCivil)
        {
            return Clientes
                .Where(c => c.EstadoCivil == estadoCivil)
                .ToList();
                
        }

        public override List<Cliente> FiltrarPorNome(string nome)
        {
            return Clientes
                .Where(c => c.Nome.Contains(nome))
                .OrderBy(c => c.Nome)
                .ToList();
        }

        public override List<Cliente> FiltrarPorSexo(Sexo sexo)
        {
            return Clientes
                .Where(c => c.Sexo == sexo)
                .ToList();
        }

        public override Cliente ObterPorId(int idCliente)
        {
            return Clientes
                .FirstOrDefault(c => c.Id == idCliente);
                
        }
    }
}
