namespace Publisher
{
    partial class frmPublisher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTopicosTitulos = new System.Windows.Forms.TabControl();
            this.tabTopicos = new System.Windows.Forms.TabPage();
            this.txtTitTopico = new System.Windows.Forms.TextBox();
            this.lblTitTopico = new System.Windows.Forms.Label();
            this.tabTitulos = new System.Windows.Forms.TabPage();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.cbxTopicos = new System.Windows.Forms.ComboBox();
            this.lblTopico = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabAssinatura = new System.Windows.Forms.TabPage();
            this.btnAssinar = new System.Windows.Forms.Button();
            this.listTitulos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Novo = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.tabTopicosTitulos.SuspendLayout();
            this.tabTopicos.SuspendLayout();
            this.tabTitulos.SuspendLayout();
            this.tabAssinatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTopicosTitulos
            // 
            this.tabTopicosTitulos.Controls.Add(this.tabTopicos);
            this.tabTopicosTitulos.Controls.Add(this.tabTitulos);
            this.tabTopicosTitulos.Controls.Add(this.tabAssinatura);
            this.tabTopicosTitulos.Location = new System.Drawing.Point(12, 88);
            this.tabTopicosTitulos.Name = "tabTopicosTitulos";
            this.tabTopicosTitulos.SelectedIndex = 0;
            this.tabTopicosTitulos.Size = new System.Drawing.Size(651, 469);
            this.tabTopicosTitulos.TabIndex = 0;
            // 
            // tabTopicos
            // 
            this.tabTopicos.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTopicos.Controls.Add(this.txtTitTopico);
            this.tabTopicos.Controls.Add(this.lblTitTopico);
            this.tabTopicos.Location = new System.Drawing.Point(4, 29);
            this.tabTopicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTopicos.Name = "tabTopicos";
            this.tabTopicos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTopicos.Size = new System.Drawing.Size(643, 436);
            this.tabTopicos.TabIndex = 2;
            this.tabTopicos.Text = "Tópicos";
            // 
            // txtTitTopico
            // 
            this.txtTitTopico.Location = new System.Drawing.Point(108, 22);
            this.txtTitTopico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitTopico.Name = "txtTitTopico";
            this.txtTitTopico.Size = new System.Drawing.Size(148, 26);
            this.txtTitTopico.TabIndex = 1;
            // 
            // lblTitTopico
            // 
            this.lblTitTopico.AutoSize = true;
            this.lblTitTopico.Location = new System.Drawing.Point(10, 26);
            this.lblTitTopico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitTopico.Name = "lblTitTopico";
            this.lblTitTopico.Size = new System.Drawing.Size(56, 20);
            this.lblTitTopico.TabIndex = 0;
            this.lblTitTopico.Text = "Topico";
            // 
            // tabTitulos
            // 
            this.tabTitulos.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTitulos.Controls.Add(this.txtMensagem);
            this.tabTitulos.Controls.Add(this.lblMensagem);
            this.tabTitulos.Controls.Add(this.cbxTopicos);
            this.tabTitulos.Controls.Add(this.lblTopico);
            this.tabTitulos.Controls.Add(this.txtTitulo);
            this.tabTitulos.Controls.Add(this.lblTitulo);
            this.tabTitulos.Location = new System.Drawing.Point(4, 29);
            this.tabTitulos.Name = "tabTitulos";
            this.tabTitulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitulos.Size = new System.Drawing.Size(643, 436);
            this.tabTitulos.TabIndex = 1;
            this.tabTitulos.Text = "Títulos";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(14, 203);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(566, 206);
            this.txtMensagem.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(14, 165);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(88, 20);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Mensagem";
            // 
            // cbxTopicos
            // 
            this.cbxTopicos.FormattingEnabled = true;
            this.cbxTopicos.Location = new System.Drawing.Point(93, 86);
            this.cbxTopicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTopicos.Name = "cbxTopicos";
            this.cbxTopicos.Size = new System.Drawing.Size(180, 28);
            this.cbxTopicos.TabIndex = 3;
            // 
            // lblTopico
            // 
            this.lblTopico.AutoSize = true;
            this.lblTopico.Location = new System.Drawing.Point(14, 86);
            this.lblTopico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopico.Name = "lblTopico";
            this.lblTopico.Size = new System.Drawing.Size(56, 20);
            this.lblTopico.TabIndex = 2;
            this.lblTopico.Text = "Topico";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(93, 25);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(180, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 29);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // tabAssinatura
            // 
            this.tabAssinatura.BackColor = System.Drawing.Color.LightGray;
            this.tabAssinatura.Controls.Add(this.btnAssinar);
            this.tabAssinatura.Controls.Add(this.listTitulos);
            this.tabAssinatura.Controls.Add(this.label2);
            this.tabAssinatura.Controls.Add(this.textBox1);
            this.tabAssinatura.Controls.Add(this.label1);
            this.tabAssinatura.Location = new System.Drawing.Point(4, 29);
            this.tabAssinatura.Name = "tabAssinatura";
            this.tabAssinatura.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssinatura.Size = new System.Drawing.Size(643, 436);
            this.tabAssinatura.TabIndex = 3;
            this.tabAssinatura.Text = "Assinatura";
            // 
            // btnAssinar
            // 
            this.btnAssinar.Location = new System.Drawing.Point(93, 299);
            this.btnAssinar.Name = "btnAssinar";
            this.btnAssinar.Size = new System.Drawing.Size(169, 40);
            this.btnAssinar.TabIndex = 4;
            this.btnAssinar.Text = "Criar assinatura";
            this.btnAssinar.UseVisualStyleBackColor = true;
            this.btnAssinar.Click += new System.EventHandler(this.btnAssinar_Click);
            // 
            // listTitulos
            // 
            this.listTitulos.FormattingEnabled = true;
            this.listTitulos.ItemHeight = 20;
            this.listTitulos.Location = new System.Drawing.Point(93, 86);
            this.listTitulos.Name = "listTitulos";
            this.listTitulos.Size = new System.Drawing.Size(169, 184);
            this.listTitulos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topico";
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(12, 53);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 29);
            this.Novo.TabIndex = 1;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(93, 53);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 29);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(13, 15);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(55, 20);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(76, 9);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServer.MaxLength = 15;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(144, 26);
            this.txtServer.TabIndex = 4;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(243, 5);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(112, 35);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 644);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.tabTopicosTitulos);
            this.Name = "frmPublisher";
            this.Text = "Publisher";
            this.tabTopicosTitulos.ResumeLayout(false);
            this.tabTopicos.ResumeLayout(false);
            this.tabTopicos.PerformLayout();
            this.tabTitulos.ResumeLayout(false);
            this.tabTitulos.PerformLayout();
            this.tabAssinatura.ResumeLayout(false);
            this.tabAssinatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTopicosTitulos;        
        private System.Windows.Forms.TabPage tabTitulos;                
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TabPage tabTopicos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxTopicos;
        private System.Windows.Forms.Label lblTopico;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtTitTopico;
        private System.Windows.Forms.Label lblTitTopico;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TabPage tabAssinatura;
        private System.Windows.Forms.Button btnAssinar;
        private System.Windows.Forms.ListBox listTitulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

    }
}

