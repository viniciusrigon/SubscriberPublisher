using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Publisher;
using System.Net.Sockets;
using System.Net;

namespace SubscriberPublisher
{
    public partial class FrmAdicionarAssinante : Form
    {
        private Socket socket;
        private int portaAssinante = 51400;
        private IPAddress endereco;

        public FrmAdicionarAssinante()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Assinante assinante = new Assinante();
            assinante.Nome = textNome.Text;
            byte[] dados = assinante.Empacotar();

            socket.Connect(endereco, portaAssinante);

            if (socket.Connected)
            {
                socket.Send(dados);
            }
        }
    }
}
