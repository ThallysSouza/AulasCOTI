using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Contracts;
using Projeto02.Entities;
using Newtonsoft.Json;
using System.IO;
namespace Projeto02.Controllers
{
    public class ClienteControle : IClienteControle
    {
        public void ExportarParaJson(Cliente cliente)
        {
            //abrindo o arquivo
            StreamWriter streamWriter = new StreamWriter("c:\\temp\\cliente.json");

            //escrevendo os dados do cliente no arquivo em formato Json
            streamWriter.WriteLine(JsonConvert.SerializeObject(cliente));
            //fehcgando o arquivo
            streamWriter.Close();            
        }

        public Cliente importarJson()
        {
            //abrindo o arquivo
            StreamReader streamReader = new StreamReader("c:\\temp\\cliente.json");

            //ler todo o texto contido no arquivo
            string conteudo = streamReader.ReadToEnd();

        //fechando o arquivo
            streamReader.Close();

            //
            return JsonConvert.DeserializeObject<Cliente>(conteudo);
        }
    }
}
