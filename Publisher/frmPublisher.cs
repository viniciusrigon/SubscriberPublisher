using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Publisher
{
    public partial class frmPublisher : Form
    {
        private Socket socket;
        private int portaPubServer = 51000;
        
        public frmPublisher()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (tabTopicosTitulos.SelectedTab.Equals(tabTopicos))
            {
                SalvarTopicos();
            }
            else if (tabTopicosTitulos.SelectedTab.Equals(tabTitulos))
            {
                SalvarTitulos();
            }

        }

        private void SalvarTitulos()
        {
            try
            {
                Titulo titulo = new Titulo();
                titulo.Nome = txtTitulo.Text;
                titulo.Mensagem = txtMensagem.Text;
                titulo.Topico = (Topico)cbxTopicos.SelectedItem;

                byte[] objTitulo = titulo.Empacotar();
                EnviarDados(objTitulo);
            }
            catch (Exception ex)
            {
                Debug.Write("Falha ao enviar os dados: " + ex.Message);
            }

        }

        private void SalvarTopicos()
        {
            try
            {
                Topico topico = new Topico();
                topico.TituloTopico = txtTitTopico.Text;              

                byte[] objTitulo = topico.Empacotar();
                EnviarDados(objTitulo);
            }
            catch (Exception ex)
            {
                Debug.Write("Falha ao enviar os dados: " + ex.Message);
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {

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

        private void btnConectar_Click(object sender, EventArgs e)
        {
            IPAddress endereco;

            if (IPAddress.TryParse(txtServer.Text, out endereco))
            {
                socket.Connect(endereco, portaPubServer);               
            }
            else
                MessageBox.Show("Endereço inválido.");


        }

        private void btnAssinar_Click(object sender, EventArgs e)
        {
            
        }


        
    }
}
