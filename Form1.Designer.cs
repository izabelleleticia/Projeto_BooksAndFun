namespace Projeto_BooksAndFun
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.RichTextBox();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.pctSenha = new System.Windows.Forms.PictureBox();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.bntSair = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.PictureBox();
            this.pnlEmail.SuspendLayout();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblLogin.Location = new System.Drawing.Point(833, 78);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(92, 32);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "LOGIN";
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.pictureBox1);
            this.pnlEmail.Location = new System.Drawing.Point(806, 495);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(307, 97);
            this.pnlEmail.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(42, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 24);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.Text = "";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlSenha
            // 
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.pictureBox2);
            this.pnlSenha.Location = new System.Drawing.Point(806, 623);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(307, 97);
            this.pnlSenha.TabIndex = 59;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Location = new System.Drawing.Point(42, 31);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(211, 24);
            this.txtSenha.TabIndex = 56;
            this.txtSenha.Text = "";
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblEntrar.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrar.ForeColor = System.Drawing.Color.White;
            this.lblEntrar.Location = new System.Drawing.Point(1054, 765);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(113, 32);
            this.lblEntrar.TabIndex = 61;
            this.lblEntrar.Text = "ENTRAR";
            this.lblEntrar.Click += new System.EventHandler(this.lblEntrar_Click);
            // 
            // pctSenha
            // 
            this.pctSenha.Image = global::Projeto_BooksAndFun.Properties.Resources.cadeado_modificado;
            this.pctSenha.Location = new System.Drawing.Point(733, 623);
            this.pctSenha.Name = "pctSenha";
            this.pctSenha.Size = new System.Drawing.Size(100, 67);
            this.pctSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSenha.TabIndex = 2;
            this.pctSenha.TabStop = false;
            // 
            // pctEmail
            // 
            this.pctEmail.Image = global::Projeto_BooksAndFun.Properties.Resources.o_email_modificado;
            this.pctEmail.Location = new System.Drawing.Point(733, 505);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(100, 62);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEmail.TabIndex = 1;
            this.pctEmail.TabStop = false;
            // 
            // bntSair
            // 
            this.bntSair.Image = global::Projeto_BooksAndFun.Properties.Resources.close_button__2_;
            this.bntSair.Location = new System.Drawing.Point(1601, 45);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(57, 34);
            this.bntSair.TabIndex = 62;
            this.bntSair.TabStop = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_BooksAndFun.Properties.Resources.Rectangle_2__2_;
            this.pictureBox2.Location = new System.Drawing.Point(33, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 38);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_BooksAndFun.Properties.Resources.Rectangle_2__2_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 38);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::Projeto_BooksAndFun.Properties.Resources.logo_077;
            this.pctLogo.Location = new System.Drawing.Point(639, 86);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(528, 506);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Image = global::Projeto_BooksAndFun.Properties.Resources.Rectangle_3__1_;
            this.btnEntrar.Location = new System.Drawing.Point(1033, 765);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(156, 32);
            this.btnEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEntrar.TabIndex = 60;
            this.btnEntrar.TabStop = false;
            this.btnEntrar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 806);
            this.Controls.Add(this.pctSenha);
            this.Controls.Add(this.pctEmail);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.lblEntrar);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnEntrar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlEmail.ResumeLayout(false);
            this.pnlSenha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctSenha;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.RichTextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnEntrar;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.PictureBox bntSair;
    }
}

