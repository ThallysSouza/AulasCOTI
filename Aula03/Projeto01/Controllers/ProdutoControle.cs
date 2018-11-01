using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Contracts;
using Projeto01.Entities;
using System.Xml;

namespace Projeto01.Controllers
{
    public class ProdutoControle : IProdutoControle
    {
        public void ExportarParaXml(Produto produto)
        {
            //criando um arquivo xml
            XmlWriter xmlWriter = XmlWriter.Create("c:\\temp\\produto.xml");
            //escrevendo o cabecalho do arquivo xml
            xmlWriter.WriteStartDocument();

            //abrindo a TAG <produto>
            xmlWriter.WriteStartElement("produto");

            //escrevendo os dados
            xmlWriter.WriteElementString("idProduto", produto.IdProduto.ToString());
            xmlWriter.WriteElementString("nome", produto.Nome);
            xmlWriter.WriteElementString("preco", produto.Preco.ToString());
            xmlWriter.WriteElementString("quantidade", produto.Quantidade.ToString());

            //abrindo a TAG <estoque>
            xmlWriter.WriteStartElement("estoque");

            xmlWriter.WriteElementString("idestoque", produto.Estoque.IdEstoque.ToString());
            xmlWriter.WriteElementString("nome", produto.Estoque.Nome.ToString());


            //fechando a TAG </estoque>
            xmlWriter.WriteEndElement();

            //fechando a TAG </produto>
            xmlWriter.WriteEndElement();

            //fechando o arquivo
            xmlWriter.Close();
        }
    }
}
