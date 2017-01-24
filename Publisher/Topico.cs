using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Publisher
{
    public class Topico
    {
        private string tituloTopico;
        private List<Titulo> titulos;

        public List<Titulo> Titulos
        {
            get { return titulos; }
            set { titulos = value; }
        }

        public string TituloTopico
        {
            get { return tituloTopico; }
            set { tituloTopico = value; }
        }

        public Topico Desempacotar(byte[] dados)
        {
            // string texto = Encoding.UTF8.GetString(dados);
            // XmlDocument x = new XmlDocument();
            // x.LoadXml(texto);
            XmlSerializer xs = new XmlSerializer(typeof(Topico));
            MemoryStream ms = new MemoryStream(dados);
            Topico ret = (Topico)xs.Deserialize(ms);
            return ret;
        }

        public byte[] Empacotar()
        {
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Topico));
            xs.Serialize(ms, this);
            ms.Flush();
            return ms.ToArray();
        }
    }

    
}
