using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Publisher
{
    public class Assinaturas
    {
        private bool lido;        
        private List<Assinante> assinantes;
        private List<Topico> topicos;
        private string nome;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Topico> Topicos
        {
            get { return topicos; }
            set { topicos = value; }
        }

        public List<Assinante> Assinantes
        {
            get { return assinantes; }
            set { assinantes = value; }
        }

        public bool Lido
        {
            get { return lido; }
            set { lido = value; }
        }

        public Assinaturas Desempacotar(byte[] dados)
        {
            // string texto = Encoding.UTF8.GetString(dados);
            // XmlDocument x = new XmlDocument();
            // x.LoadXml(texto);
            XmlSerializer xs = new XmlSerializer(typeof(Assinaturas));
            MemoryStream ms = new MemoryStream(dados);
            Assinaturas ret = (Assinaturas)xs.Deserialize(ms);
            return ret;
        }

        public byte[] Empacotar()
        {
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Assinaturas));
            xs.Serialize(ms, this);
            ms.Flush();
            return ms.ToArray();
        }


    }
}
