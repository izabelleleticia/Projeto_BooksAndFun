namespace Projeto_BooksAndFun
{
    partial class frmResponderEmail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResponderEmail = new System.Windows.Forms.Label();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.lblResponderEmail);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblResponderEmail
            // 
            this.lblResponderEmail.AutoSize = true;
            this.lblResponderEmail.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponderEmail.ForeColor = System.Drawing.Color.White;
            this.lblResponderEmail.Location = new System.Drawing.Point(412, 6);
            this.lblResponderEmail.Name = "lblResponderEmail";
            this.lblResponderEmail.Size = new System.Drawing.Size(278, 30);
            this.lblResponderEmail.TabIndex = 11;
            this.lblResponderEmail.Text = "RESPOSTA DE E-MAILS";
            // 
            // rtbResposta
            // 
            this.rtbResposta.Location = new System.Drawing.Point(537, 166);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.Size = new System.Drawing.Size(381, 344);
            this.rtbResposta.TabIndex = 1;
            this.rtbResposta.Text = "";
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(142, 166);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(776, 344);
            this.rtbMensagem.TabIndex = 2;
            this.rtbMensagem.Text = "";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblEmail.Location = new System.Drawing.Point(276, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 27);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblAssunto.Location = new System.Drawing.Point(275, 88);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(115, 27);
            this.lblAssunto.TabIndex = 9;
            this.lblAssunto.Text = "ASSUNTO:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(396, 95);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(339, 20);
            this.txtAssunto.TabIndex = 10;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblResposta.Location = new System.Drawing.Point(790, 136);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(121, 27);
            this.lblResposta.TabIndex = 13;
            this.lblResposta.Text = "RESPOSTA";
            this.lblResposta.Click += new System.EventHandler(this.lblResposta_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblMensagem.Location = new System.Drawing.Point(145, 136);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(129, 27);
            this.lblMensagem.TabIndex = 14;
            this.lblMensagem.Text = "MENSAGEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(798, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "ENVIAR";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::Projeto_BooksAndFun.Properties.Resources.Rectangle_3__2_;
            this.btnEnviar.Location = new System.Drawing.Point(759, 536);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(156, 32);
            this.btnEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEnviar.TabIndex = 69;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmResponderEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 778);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.rtbResposta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbMensagem);
            this.Name = "frmResponderEmail";
            this.Text = "ResponderEmail";
            this.Load += new System.EventHandler(this.frmResponderEmail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResponderEmail;
        private System.Windows.Forms.RichTextBox rtbResposta;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnEnviar;
    }
}