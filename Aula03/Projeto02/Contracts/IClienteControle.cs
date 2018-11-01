using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
namespace Projeto02.Contracts
{
   public interface IClienteControle
    {
        //métodos abstratos
        void ExportarParaJson(Cliente cliente);

        //método abstrato
        Cliente importarJson();
    }
}
