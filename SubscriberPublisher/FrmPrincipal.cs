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
    public partial class FrmPrincipal : Form
    {
        private Assinante assinante;

        public Assinante Assinante
        {
            get { return assinante; }
            set { assinante = value; }
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubscriber f = new FrmSubscriber();
            f.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAssinaturas f = new FrmAssinaturas();
            f.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAdicionarAssinante f = new FrmAdicionarAssinante();
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
