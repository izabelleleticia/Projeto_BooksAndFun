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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEvento));
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Location = new System.Drawing.Point(321, 129);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(220, 20);
            this.txtNomeEvento.TabIndex = 1;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblResposta.Location = new System.Drawing.Point(453, 21);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(264, 29);
            this.lblResposta.TabIndex = 68;
            this.lblResposta.Text = "CADASTRAR EVENTO";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(316, 93);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(92, 29);
            this.lblNomeEvento.TabIndex = 70;
            this.lblNomeEvento.Text = "NOME:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblDescricao.Location = new System.Drawing.Point(564, 93);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(153, 29);
            this.lblDescricao.TabIndex = 72;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(67, 312);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 38);
            this.btnCadastrar.TabIndex = 74;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Location = new System.Drawing.Point(67, 356);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 38);
            this.btnExcluir.TabIndex = 76;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbStatus.Location = new System.Drawing.Point(321, 324);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 77;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblDataCad.Location = new System.Drawing.Point(316, 188);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(141, 25);
            this.lblDataCad.TabIndex = 78;
            this.lblDataCad.Text = "DATA INICIO:";
            this.lblDataCad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(564, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "DATA TÉRMINO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(321, 226);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(242, 20);
            this.dtInicio.TabIndex = 82;
        
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(569, 226);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(240, 20);
            this.dtFim.TabIndex = 83;
            this.dtFim.Value = new System.DateTime(2025, 3, 12, 0, 0, 0, 0);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(569, 129);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(220, 20);
            this.txtDescricao.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(316, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = "STATUS:";
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("pctFuncionario.Image")));
            this.pctFuncionario.Location = new System.Drawing.Point(67, 21);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(165, 213);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 67;
            this.pctFuncionario.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(564, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "LOCAL:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(569, 325);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(220, 20);
            this.txtLocal.TabIndex = 87;
            // 
            // frmCadEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 620);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataCad);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.txtNomeEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCadEvento";
            this.Text = "cadEvento";
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocal;
    }
}