namespace Projeto_BooksAndFun
{
    partial class frmCadEvento
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
            this.mtEvento = new System.Windows.Forms.MonthCalendar();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.pnlEvento = new System.Windows.Forms.Panel();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            this.pnlEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtEvento
            // 
            this.mtEvento.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.mtEvento.Location = new System.Drawing.Point(6, 9);
            this.mtEvento.Name = "mtEvento";
            this.mtEvento.TabIndex = 0;
            this.mtEvento.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Location = new System.Drawing.Point(45, 285);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(220, 20);
            this.txtNomeEvento.TabIndex = 1;
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = global::Projeto_BooksAndFun.Properties.Resources.calendario_modified2;
            this.pctFuncionario.Location = new System.Drawing.Point(67, 21);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(165, 213);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 67;
            this.pctFuncionario.TabStop = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblResposta.Location = new System.Drawing.Point(453, 21);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(224, 27);
            this.lblResposta.TabIndex = 68;
            this.lblResposta.Text = "CADASTRAR EVENTO";
            // 
            // pnlEvento
            // 
            this.pnlEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.pnlEvento.Controls.Add(this.mtEvento);
            this.pnlEvento.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEvento.Location = new System.Drawing.Point(349, 59);
            this.pnlEvento.Name = "pnlEvento";
            this.pnlEvento.Size = new System.Drawing.Size(473, 477);
            this.pnlEvento.TabIndex = 69;
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(103, 255);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(80, 27);
            this.lblNomeEvento.TabIndex = 70;
            this.lblNomeEvento.Text = "NOME:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblDescricao.Location = new System.Drawing.Point(78, 328);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(133, 27);
            this.lblDescricao.TabIndex = 72;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(36, 358);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 39);
            this.txtDescricao.TabIndex = 73;
            this.txtDescricao.Text = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(36, 422);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 38);
            this.btnCadastrar.TabIndex = 74;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(36, 466);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 38);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.Text = "ALTERAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(36, 510);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 38);
            this.btnExcluir.TabIndex = 76;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // frmCadEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 620);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.pnlEvento);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.txtNomeEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEvento";
            this.Text = "cadEvento";
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            this.pnlEvento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mtEvento;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Panel pnlEvento;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
    }
}