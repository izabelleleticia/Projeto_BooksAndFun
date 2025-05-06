namespace Projeto_BooksAndFun
{
    partial class editarLivro
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
            this.cmbEditora = new System.Windows.Forms.ComboBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.pctLivro = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtAnoPub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEditora
            // 
            this.cmbEditora.FormattingEnabled = true;
            this.cmbEditora.Location = new System.Drawing.Point(633, 259);
            this.cmbEditora.Name = "cmbEditora";
            this.cmbEditora.Size = new System.Drawing.Size(121, 21);
            this.cmbEditora.TabIndex = 139;
            // 
            // cmbAutor
            // 
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(332, 100);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(121, 21);
            this.cmbAutor.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(614, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 33);
            this.label6.TabIndex = 137;
            this.label6.Text = "SÉRIE";
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(620, 392);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(121, 21);
            this.cmbSerie.TabIndex = 136;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(80, 258);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 135;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.Location = new System.Drawing.Point(238, 456);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(159, 23);
            this.btnSelecionarImagem.TabIndex = 134;
            this.btnSelecionarImagem.Text = "SELECIONAR IMAGEM";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // pctLivro
            // 
            this.pctLivro.Image = global::Projeto_BooksAndFun.Properties.Resources.abra_o_livro;
            this.pctLivro.Location = new System.Drawing.Point(80, 441);
            this.pctLivro.Name = "pctLivro";
            this.pctLivro.Size = new System.Drawing.Size(142, 94);
            this.pctLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLivro.TabIndex = 133;
            this.pctLivro.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(627, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 33);
            this.label5.TabIndex = 132;
            this.label5.Text = "EDITORA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(353, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 33);
            this.label4.TabIndex = 131;
            this.label4.Text = "QUANTIDADE:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(359, 393);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(220, 20);
            this.txtQuantidade.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(74, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 129;
            this.label1.Text = "PREÇO UNITÁRIO:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(80, 391);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(220, 20);
            this.txtPreco.TabIndex = 128;
            // 
            // txtAnoPub
            // 
            this.txtAnoPub.Location = new System.Drawing.Point(328, 259);
            this.txtAnoPub.Name = "txtAnoPub";
            this.txtAnoPub.Size = new System.Drawing.Size(220, 20);
            this.txtAnoPub.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(323, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 33);
            this.label3.TabIndex = 126;
            this.label3.Text = "ANO PUBLICAÇÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(75, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 33);
            this.label2.TabIndex = 125;
            this.label2.Text = "GÊNERO:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblDescricao.Location = new System.Drawing.Point(323, 64);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(125, 33);
            this.lblDescricao.TabIndex = 124;
            this.lblDescricao.Text = "AUTOR:";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(75, 64);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(110, 33);
            this.lblNomeEvento.TabIndex = 123;
            this.lblNomeEvento.Text = "NOME:";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(80, 100);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(220, 20);
            this.txtNomeLivro.TabIndex = 122;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(238, 485);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 23);
            this.btnSalvar.TabIndex = 140;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(238, 512);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 23);
            this.btnExcluir.TabIndex = 141;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // editarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 596);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbEditora);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSerie);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.pctLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtAnoPub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.txtNomeLivro);
            this.Name = "editarLivro";
            this.Text = "editarLivro";
            ((System.ComponentModel.ISupportInitialize)(this.pctLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEditora;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.PictureBox pctLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtAnoPub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
    }
}