using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;

namespace Projeto02.Contracts
{
    public interface IControle<T>
        where T : class
    {
        //método abstrato
        void imprimirDados(T objeto);

    }
}
