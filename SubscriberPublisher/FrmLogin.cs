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
    public partial class FrmLogin : Form
    {
        private Socket socket;
        private int portaAssinante = 51400;
        private IPAddress endereco;

        public FrmLogin()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                FrmPrincipal f = new FrmPrincipal();
                f.Assinante = CarregaAssinante();
                if (f.Assinante != null)
                {
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Usuario inexistente");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Assinante CarregaAssinante()
        {   
            Assinante assinante = new Assinante();

            socket.Connect(endereco, portaAssinante);

            assinante.Nome = textApelido.Text;

            byte[] usuario = assinante.Empacotar();

            socket.Send(usuario);

            byte[] dadosRecebidos = new byte[1024];

            int qtdeDadosRecebidos = socket.Receive(dadosRecebidos);
            
            
            assinante.Desempacotar(dadosRecebidos);
                       
            socket.Disconnect(true);

            return assinante;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(txtServer.Text, out endereco))
            {
                
            }
            else
                MessageBox.Show("Endereço inválido.");
        }

        
    }
}
