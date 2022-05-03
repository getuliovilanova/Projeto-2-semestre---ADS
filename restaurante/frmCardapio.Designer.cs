namespace restaurante
{
    partial class frmCardapio
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
            this.btnCardapioVoltar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCardapio = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCardapioVoltar
            // 
            this.btnCardapioVoltar.Location = new System.Drawing.Point(648, 9);
            this.btnCardapioVoltar.Name = "btnCardapioVoltar";
            this.btnCardapioVoltar.Size = new System.Drawing.Size(115, 33);
            this.btnCardapioVoltar.TabIndex = 9;
            this.btnCardapioVoltar.Text = "Voltar";
            this.btnCardapioVoltar.UseVisualStyleBackColor = true;
            this.btnCardapioVoltar.Click += new System.EventHandler(this.btnCardapioVoltar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(529, 9);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(115, 33);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(410, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 33);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar Novo Item";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pé de Fava Oriental";
            // 
            // dgvCardapio
            // 
            this.dgvCardapio.AllowUserToAddRows = false;
            this.dgvCardapio.AllowUserToDeleteRows = false;
            this.dgvCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardapio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCardapio.Location = new System.Drawing.Point(12, 48);
            this.dgvCardapio.MultiSelect = false;
            this.dgvCardapio.Name = "dgvCardapio";
            this.dgvCardapio.ReadOnly = true;
            this.dgvCardapio.Size = new System.Drawing.Size(751, 462);
            this.dgvCardapio.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::restaurante.Properties.Resources.cardapio;
            this.pictureBox1.Location = new System.Drawing.Point(2, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 522);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCardapio);
            this.Controls.Add(this.btnCardapioVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCardapio";
            this.Text = "Cardápio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCardapioVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCardapio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}