namespace SubscriberPublisher
{
    partial class FrmAssinaturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textMensagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxAssinaturas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxTopicos = new System.Windows.Forms.ComboBox();
            this.cboxTitulos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem";
            // 
            // textMensagem
            // 
            this.textMensagem.Location = new System.Drawing.Point(49, 241);
            this.textMensagem.Multiline = true;
            this.textMensagem.Name = "textMensagem";
            this.textMensagem.Size = new System.Drawing.Size(520, 246);
            this.textMensagem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assinaturas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxAssinaturas
            // 
            this.cbxAssinaturas.FormattingEnabled = true;
            this.cbxAssinaturas.Location = new System.Drawing.Point(120, 47);
            this.cbxAssinaturas.Name = "cbxAssinaturas";
            this.cbxAssinaturas.Size = new System.Drawing.Size(272, 28);
            this.cbxAssinaturas.TabIndex = 4;
            this.cbxAssinaturas.Tag = "";
            this.cbxAssinaturas.SelectedIndexChanged += new System.EventHandler(this.cboxAssinaturas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Topicos";
            // 
            // cboxTopicos
            // 
            this.cboxTopicos.FormattingEnabled = true;
            this.cboxTopicos.Location = new System.Drawing.Point(120, 90);
            this.cboxTopicos.Name = "cboxTopicos";
            this.cboxTopicos.Size = new System.Drawing.Size(272, 28);
            this.cboxTopicos.TabIndex = 6;
            this.cboxTopicos.SelectedIndexChanged += new System.EventHandler(this.cboxTopicos_SelectedIndexChanged);
            // 
            // cboxTitulos
            // 
            this.cboxTitulos.FormattingEnabled = true;
            this.cboxTitulos.Location = new System.Drawing.Point(120, 134);
            this.cboxTitulos.Name = "cboxTitulos";
            this.cboxTitulos.Size = new System.Drawing.Size(272, 28);
            this.cboxTitulos.TabIndex = 8;
            this.cboxTitulos.SelectedIndexChanged += new System.EventHandler(this.cboxTitulos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Titulos";
            // 
            // FrmAssinaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 499);
            this.Controls.Add(this.cboxTitulos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxTopicos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxAssinaturas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMensagem);
            this.Controls.Add(this.label1);
            this.Name = "FrmAssinaturas";
            this.Text = "FrmAssinaturas";
            this.Load += new System.EventHandler(this.frmAssinaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxAssinaturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxTopicos;
        private System.Windows.Forms.ComboBox cboxTitulos;
        private System.Windows.Forms.Label label4;
    }
}