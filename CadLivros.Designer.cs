namespace Projeto_BooksAndFun
{
    partial class CadLivros
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
            this.txtAnoPub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtIDGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDEditora = new System.Windows.Forms.TextBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.dgvEditora = new System.Windows.Forms.DataGridView();
            this.bntSair = new System.Windows.Forms.PictureBox();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctLivro = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnoPub
            // 
            this.txtAnoPub.Location = new System.Drawing.Point(579, 294);
            this.txtAnoPub.Name = "txtAnoPub";
            this.txtAnoPub.Size = new System.Drawing.Size(220, 20);
            this.txtAnoPub.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(574, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 33);
            this.label3.TabIndex = 102;
            this.label3.Text = "ANO PUBLICAÇÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(326, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 101;
            this.label2.Text = "ID GÊNERO:";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Location = new System.Drawing.Point(579, 135);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(220, 20);
            this.txtIdAutor.TabIndex = 100;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Location = new System.Drawing.Point(78, 346);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 38);
            this.btnExcluir.TabIndex = 94;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(78, 302);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 38);
            this.btnCadastrar.TabIndex = 93;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblDescricao.Location = new System.Drawing.Point(574, 99);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(162, 33);
            this.lblDescricao.TabIndex = 92;
            this.lblDescricao.Text = "ID AUTOR:";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(326, 99);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(110, 33);
            this.lblNomeEvento.TabIndex = 91;
            this.lblNomeEvento.Text = "NOME:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblResposta.Location = new System.Drawing.Point(544, 25);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(339, 37);
            this.lblResposta.TabIndex = 90;
            this.lblResposta.Text = "CADASTRAR LIVROS";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(331, 135);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(220, 20);
            this.txtNomeLivro.TabIndex = 88;
            // 
            // txtIDGenero
            // 
            this.txtIDGenero.Location = new System.Drawing.Point(331, 294);
            this.txtIDGenero.Name = "txtIDGenero";
            this.txtIDGenero.Size = new System.Drawing.Size(220, 20);
            this.txtIDGenero.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(326, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 106;
            this.label1.Text = "PREÇO UNITÁRIO:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(331, 426);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(220, 20);
            this.txtPreco.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(578, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 33);
            this.label4.TabIndex = 108;
            this.label4.Text = "QUANTIDADE:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(583, 427);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(220, 20);
            this.txtQuantidade.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(878, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 33);
            this.label5.TabIndex = 110;
            this.label5.Text = "ID EDITORA:";
            // 
            // txtIDEditora
            // 
            this.txtIDEditora.Location = new System.Drawing.Point(883, 288);
            this.txtIDEditora.Name = "txtIDEditora";
            this.txtIDEditora.Size = new System.Drawing.Size(220, 20);
            this.txtIDEditora.TabIndex = 109;
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = global::Projeto_BooksAndFun.Properties.Resources.pilha_de_tres_livros_modificado1;
            this.pctFuncionario.Location = new System.Drawing.Point(78, 47);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(165, 213);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 89;
            this.pctFuncionario.TabStop = false;
            // 
            // dgvEditora
            // 
            this.dgvEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditora.Location = new System.Drawing.Point(1128, 69);
            this.dgvEditora.Name = "dgvEditora";
            this.dgvEditora.Size = new System.Drawing.Size(569, 289);
            this.dgvEditora.TabIndex = 111;
            // 
            // bntSair
            // 
            this.bntSair.Image = global::Projeto_BooksAndFun.Properties.Resources.close_button__2_;
            this.bntSair.Location = new System.Drawing.Point(1681, 25);
            this.bntSair.Margin = new System.Windows.Forms.Padding(5);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(95, 60);
            this.bntSair.TabIndex = 112;
            this.bntSair.TabStop = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // dgvGenero
            // 
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Location = new System.Drawing.Point(1128, 391);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.Size = new System.Drawing.Size(569, 289);
            this.dgvGenero.TabIndex = 113;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // pctLivro
            // 
            this.pctLivro.Image = global::Projeto_BooksAndFun.Properties.Resources.abra_o_livro;
            this.pctLivro.Location = new System.Drawing.Point(331, 452);
            this.pctLivro.Name = "pctLivro";
            this.pctLivro.Size = new System.Drawing.Size(142, 94);
            this.pctLivro.TabIndex = 115;
            this.pctLivro.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Location = new System.Drawing.Point(489, 491);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarImagem.TabIndex = 116;
            this.btnSelecionarImagem.Text = "button1";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 820);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.pctLivro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dgvEditora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDEditora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtIDGenero);
            this.Controls.Add(this.txtAnoPub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdAutor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.txtNomeLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadLivros";
            this.Text = "CadLivros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnoPub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAutor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtIDGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDEditora;
        private System.Windows.Forms.DataGridView dgvEditora;
        private System.Windows.Forms.PictureBox bntSair;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctLivro;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}