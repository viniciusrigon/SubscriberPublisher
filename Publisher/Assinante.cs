using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Publisher
{
    public class Assinante
    {
        private string nome;
        private List<Assinaturas> assinaturas;

        public List<Assinaturas> Assinaturas
        {
            get { return assinaturas; }
            set { assinaturas = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Assinante Desempacotar(byte[] dados)
        {
            // string texto = Encoding.UTF8.GetString(dados);
            // XmlDocument x = new XmlDocument();
            // x.LoadXml(texto);
            XmlSerializer xs = new XmlSerializer(typeof(Assinante));
            MemoryStream ms = new MemoryStream(dados);
            Assinante ret = (Assinante)xs.Deserialize(ms);
            return ret;
        }

        public byte[] Empacotar()
        {
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Assinante));
            xs.Serialize(ms, this);
            ms.Flush();
            return ms.ToArray();
        }

    }
}
