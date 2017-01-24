using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Publisher;

namespace SubscriberPublisher
{
    public partial class FrmAssinaturas : Form
    {
        private Assinante assinante;

        public Assinante Assinante
        {
            get { return assinante; }
            set { assinante = value; }
        }

        public FrmAssinaturas()
        {
            InitializeComponent();            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAssinaturas_Load(object sender, EventArgs e)
        {
            cbxAssinaturas.DisplayMember = "Nome";
            cbxAssinaturas.ValueMember = "IdAssinatura";
            cbxAssinaturas.DataSource = assinante.Assinaturas;
            
        }

        private void cboxAssinaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assinaturas objAssinate = (Assinaturas)sender;
            
            cboxTopicos.DisplayMember = "Nome";
            cboxTopicos.ValueMember = "IdTopico";
            cboxTopicos.DataSource = objAssinate.Topicos;
        }

        private void cboxTopicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Topico objTopico = (Topico)sender;

            cboxTitulos.DisplayMember = "Titulo";
            cboxTitulos.ValueMember = "IdTitulo";
            cboxTitulos.DataSource = objTopico.Titulos;
        }

        private void cboxTitulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titulo objTitulo = (Titulo)sender;
            
            textMensagem.Text = objTitulo.Mensagem;

           
        }

        
    }
}
