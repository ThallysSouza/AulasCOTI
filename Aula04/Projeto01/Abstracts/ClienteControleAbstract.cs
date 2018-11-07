using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Entities.Types;

namespace Projeto01.Abstracts
{
    //classe abstrata
    public abstract class ClienteControleAbstract
    {
        //propriedade set/get
        public List<Cliente> Clientes { get; set; }

        //métodos abstratos...
        public abstract List<Cliente> FiltrarPorNome(String nome);
        public abstract List<Cliente> FiltrarPorSexo(Sexo sexo);
        public abstract List<Cliente> FiltrarPorEstadoCivil(EstadoCivil estadoCivil);
        public abstract Cliente ObterPorId(int idCliente);
    }




}
