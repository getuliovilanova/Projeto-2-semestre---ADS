namespace restaurante
{
    partial class frmPesquisaCli
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesqCPF = new System.Windows.Forms.TextBox();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.txtPesqEmail = new System.Windows.Forms.TextBox();
            this.btnPesqCliente = new System.Windows.Forms.Button();
            this.btnPesqVoltar = new System.Windows.Forms.Button();
            this.txtPesqTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoPesqCPf = new System.Windows.Forms.RadioButton();
            this.rdoPesqNome = new System.Windows.Forms.RadioButton();
            this.rdoPesqEmail = new System.Windows.Forms.RadioButton();
            this.rdoPesqTelefone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Informe os dados para consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail";
            // 
            // txtPesqCPF
            // 
            this.txtPesqCPF.Location = new System.Drawing.Point(27, 58);
            this.txtPesqCPF.MaxLength = 11;
            this.txtPesqCPF.Name = "txtPesqCPF";
            this.txtPesqCPF.Size = new System.Drawing.Size(123, 20);
            this.txtPesqCPF.TabIndex = 8;
            this.txtPesqCPF.Click += new System.EventHandler(this.txtPesqCPF_Click);
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Location = new System.Drawing.Point(27, 102);
            this.txtPesqNome.MaxLength = 50;
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(286, 20);
            this.txtPesqNome.TabIndex = 9;
            this.txtPesqNome.Click += new System.EventHandler(this.txtPesqNome_Click);
            // 
            // txtPesqEmail
            // 
            this.txtPesqEmail.Location = new System.Drawing.Point(27, 146);
            this.txtPesqEmail.MaxLength = 50;
            this.txtPesqEmail.Name = "txtPesqEmail";
            this.txtPesqEmail.Size = new System.Drawing.Size(286, 20);
            this.txtPesqEmail.TabIndex = 10;
            this.txtPesqEmail.Click += new System.EventHandler(this.txtPesqEmail_Click);
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Location = new System.Drawing.Point(27, 183);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(133, 38);
            this.btnPesqCliente.TabIndex = 5;
            this.btnPesqCliente.Text = "&Pesquisar";
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click_1);
            // 
            // btnPesqVoltar
            // 
            this.btnPesqVoltar.Location = new System.Drawing.Point(180, 183);
            this.btnPesqVoltar.Name = "btnPesqVoltar";
            this.btnPesqVoltar.Size = new System.Drawing.Size(133, 38);
            this.btnPesqVoltar.TabIndex = 7;
            this.btnPesqVoltar.Text = "&Voltar";
            this.btnPesqVoltar.UseVisualStyleBackColor = true;
            this.btnPesqVoltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPesqTelefone
            // 
            this.txtPesqTelefone.Location = new System.Drawing.Point(190, 58);
            this.txtPesqTelefone.MaxLength = 10;
            this.txtPesqTelefone.Name = "txtPesqTelefone";
            this.txtPesqTelefone.Size = new System.Drawing.Size(123, 20);
            this.txtPesqTelefone.TabIndex = 8;
            this.txtPesqTelefone.Click += new System.EventHandler(this.txtPesqTelefone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone";
            // 
            // rdoPesqCPf
            // 
            this.rdoPesqCPf.AutoSize = true;
            this.rdoPesqCPf.Checked = true;
            this.rdoPesqCPf.Location = new System.Drawing.Point(7, 62);
            this.rdoPesqCPf.Name = "rdoPesqCPf";
            this.rdoPesqCPf.Size = new System.Drawing.Size(14, 13);
            this.rdoPesqCPf.TabIndex = 1;
            this.rdoPesqCPf.TabStop = true;
            this.rdoPesqCPf.UseVisualStyleBackColor = true;
            this.rdoPesqCPf.CheckedChanged += new System.EventHandler(this.rdoPesqCPf_CheckedChanged);
            // 
            // rdoPesqNome
            // 
            this.rdoPesqNome.AutoSize = true;
            this.rdoPesqNome.Location = new System.Drawing.Point(7, 106);
            this.rdoPesqNome.Name = "rdoPesqNome";
            this.rdoPesqNome.Size = new System.Drawing.Size(14, 13);
            this.rdoPesqNome.TabIndex = 3;
            this.rdoPesqNome.UseVisualStyleBackColor = true;
            this.rdoPesqNome.CheckedChanged += new System.EventHandler(this.rdoPesqNome_CheckedChanged);
            // 
            // rdoPesqEmail
            // 
            this.rdoPesqEmail.AutoSize = true;
            this.rdoPesqEmail.Location = new System.Drawing.Point(7, 150);
            this.rdoPesqEmail.Name = "rdoPesqEmail";
            this.rdoPesqEmail.Size = new System.Drawing.Size(14, 13);
            this.rdoPesqEmail.TabIndex = 4;
            this.rdoPesqEmail.UseVisualStyleBackColor = true;
            this.rdoPesqEmail.CheckedChanged += new System.EventHandler(this.rdoPesqEmail_CheckedChanged);
            // 
            // rdoPesqTelefone
            // 
            this.rdoPesqTelefone.AutoSize = true;
            this.rdoPesqTelefone.Location = new System.Drawing.Point(171, 62);
            this.rdoPesqTelefone.Name = "rdoPesqTelefone";
            this.rdoPesqTelefone.Size = new System.Drawing.Size(14, 13);
            this.rdoPesqTelefone.TabIndex = 2;
            this.rdoPesqTelefone.UseVisualStyleBackColor = true;
            this.rdoPesqTelefone.CheckedChanged += new System.EventHandler(this.rdoPesqTelefone_CheckedChanged);
            // 
            // frmPesqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 235);
            this.ControlBox = false;
            this.Controls.Add(this.rdoPesqTelefone);
            this.Controls.Add(this.rdoPesqEmail);
            this.Controls.Add(this.rdoPesqNome);
            this.Controls.Add(this.rdoPesqCPf);
            this.Controls.Add(this.txtPesqTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesqVoltar);
            this.Controls.Add(this.btnPesqCliente);
            this.Controls.Add(this.txtPesqEmail);
            this.Controls.Add(this.txtPesqNome);
            this.Controls.Add(this.txtPesqCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPesqCliente";
            this.Text = "Pesquisa de Clientes";
            this.Load += new System.EventHandler(this.frmPesqCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesqCPF;
        private System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.TextBox txtPesqEmail;
        private System.Windows.Forms.Button btnPesqCliente;
        private System.Windows.Forms.Button btnPesqVoltar;
        private System.Windows.Forms.TextBox txtPesqTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoPesqCPf;
        private System.Windows.Forms.RadioButton rdoPesqNome;
        private System.Windows.Forms.RadioButton rdoPesqEmail;
        private System.Windows.Forms.RadioButton rdoPesqTelefone;
    }
}