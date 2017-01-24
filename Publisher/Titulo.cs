using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Publisher
{
    public class Titulo
    {
        private Topico topico;
        private string nome;
        private string mensagem;

        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Topico Topico
        {
            get { return topico; }
            set { topico = value; }
        }

        public Titulo Desempacotar(byte[] dados)
        {
            // string texto = Encoding.UTF8.GetString(dados);
            // XmlDocument x = new XmlDocument();
            // x.LoadXml(texto);
            XmlSerializer xs = new XmlSerializer(typeof(Titulo));
            MemoryStream ms = new MemoryStream(dados);
            Titulo ret = (Titulo)xs.Deserialize(ms);
            return ret;
        }

        public byte[] Empacotar()
        {
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Titulo));
            xs.Serialize(ms, this);
            ms.Flush();
            return ms.ToArray();
        }
    }


}
