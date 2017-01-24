namespace SubscriberPublisher
{
    partial class FrmSubscriber
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
            this.lblTopico = new System.Windows.Forms.Label();
            this.cbxTopicos = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxTitulos = new System.Windows.Forms.ComboBox();
            this.btnAssinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopico
            // 
            this.lblTopico.AutoSize = true;
            this.lblTopico.Location = new System.Drawing.Point(22, 146);
            this.lblTopico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopico.Name = "lblTopico";
            this.lblTopico.Size = new System.Drawing.Size(56, 20);
            this.lblTopico.TabIndex = 13;
            this.lblTopico.Text = "Topico";
            // 
            // cbxTopicos
            // 
            this.cbxTopicos.FormattingEnabled = true;
            this.cbxTopicos.Location = new System.Drawing.Point(93, 138);
            this.cbxTopicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTopicos.Name = "cbxTopicos";
            this.cbxTopicos.Size = new System.Drawing.Size(180, 28);
            this.cbxTopicos.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(22, 216);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 20);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Titulos";
            // 
            // cbxTitulos
            // 
            this.cbxTitulos.FormattingEnabled = true;
            this.cbxTitulos.Location = new System.Drawing.Point(93, 213);
            this.cbxTitulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTitulos.Name = "cbxTitulos";
            this.cbxTitulos.Size = new System.Drawing.Size(180, 28);
            this.cbxTitulos.TabIndex = 16;
            // 
            // btnAssinar
            // 
            this.btnAssinar.Location = new System.Drawing.Point(93, 266);
            this.btnAssinar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssinar.Name = "btnAssinar";
            this.btnAssinar.Size = new System.Drawing.Size(112, 35);
            this.btnAssinar.TabIndex = 17;
            this.btnAssinar.Text = "Assinar";
            this.btnAssinar.UseVisualStyleBackColor = true;
            this.btnAssinar.Click += new System.EventHandler(this.btnAssinar_Click);
            // 
            // FrmSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 538);
            this.Controls.Add(this.btnAssinar);
            this.Controls.Add(this.cbxTitulos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxTopicos);
            this.Controls.Add(this.lblTopico);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSubscriber";
            this.Text = "Subscriber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopico;
        private System.Windows.Forms.ComboBox cbxTopicos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxTitulos;
        private System.Windows.Forms.Button btnAssinar;
    }
}

