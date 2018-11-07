using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Abstracts;
using Projeto01.Entities;
using Projeto01.Entities.Types;

namespace Projeto01.Controllers
{
    public class ClienteControleLINQ : ClienteControleAbstract
    {
        public override List<Cliente> FiltrarPorEstadoCivil(EstadoCivil estadoCivil)
        {
            //consulta LINQ
            var query = from c in Clientes
                        where c.EstadoCivil == estadoCivil
                        select c;

            //retornando
            return query.ToList();
        }

        public override List<Cliente> FiltrarPorNome(string nome)
        {
            var query = from c in Clientes
                        where c.Nome.Contains(nome)
                        orderby c.Nome ascending
                        select c;

            //equals -> axatamente igual a 
            //startsWith -> comecando com
            //EndWith -> terminando com
            //Contains -> contendo
            
            return query.ToList();
        }

        public override List<Cliente> FiltrarPorSexo(Sexo sexo)
        {
            var query = from c in Clientes
                        where c.Sexo == sexo
                        select c;

            return query.ToList();
        }

        public override Cliente ObterPorId(int idCliente)
        {
            var query = from c in Clientes
                        where c.Id == idCliente
                        select c;

            return query.FirstOrDefault();
            
        }
    }
}
