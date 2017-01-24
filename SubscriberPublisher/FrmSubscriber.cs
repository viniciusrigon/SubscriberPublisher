using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using Publisher;

namespace SubscriberPublisher
{
    public partial class FrmSubscriber : Form
    {        
        private Socket socket;
        private IPAddress endereco;
        private int portaSubServer = 51100;
        private int portaTopico = 51200;
        private int portaTitulo = 51300;

        public FrmSubscriber()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {           
            if (IPAddress.TryParse(txtServer.Text, out endereco))
            {
                PopulaTitulo();
                PopulaTopico();
            }
            else
                MessageBox.Show("Endereço inválido.");
        }

        
        private void PopulaTitulo()
        {
            socket.Connect(endereco, portaTitulo);

            byte[] dadosRecebidos = new byte[1024];

            int qtdeDadosRecebidos = socket.Receive(dadosRecebidos);
            Titulo titulo = new Titulo();
            titulo.Desempacotar(dadosRecebidos);

            cbxTopicos.Items.Add(titulo);

            socket.Disconnect(true);
        }

        private void PopulaTopico()
        {
            socket.Connect(endereco, portaTopico);

            byte[] dadosRecebidos = new byte[1024];

            int qtdeDadosRecebidos = socket.Receive(dadosRecebidos);
            Topico topico = new Topico();
            topico.Desempacotar(dadosRecebidos);

            cbxTopicos.Items.Add(topico);

            socket.Disconnect(true);
        }        

        private void btnAssinar_Click(object sender, EventArgs e)
        {

        }
                        
        private void ReceberDados(byte[] dados)
        {
            if (socket.Connected)
            {
                socket.Send(dados);
            }
            else
            {
                MessageBox.Show("Favor conectar no servidor.");
            }   
        }

        private void EnviarDados(byte[] dados)
        {
            if (socket.Connected)
            {
                socket.Send(dados);
            }
            else
            {
                MessageBox.Show("Favor conectar no servidor.");
            }
        }

        

    }
}
