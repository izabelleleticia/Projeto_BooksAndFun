namespace Projeto_BooksAndFun
{
    partial class FrmLivros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(955, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 29);
            this.btnSair.TabIndex = 76;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblStatus.Location = new System.Drawing.Point(690, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 29);
            this.lblStatus.TabIndex = 75;
            this.lblStatus.Text = "STATUS:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblNome.Location = new System.Drawing.Point(235, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(210, 29);
            this.lblNome.TabIndex = 74;
            this.lblNome.Text = "NOME DO LIVRO:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(326, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(335, 20);
            this.txtNome.TabIndex = 73;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVO",
            "INATIVO",
            "DESATIVADO"});
            this.cmbStatus.Location = new System.Drawing.Point(793, 23);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(139, 21);
            this.cmbStatus.TabIndex = 72;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(34, 384);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 38);
            this.btnExcluir.TabIndex = 71;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(34, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 38);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Text = "ALTERAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(34, 296);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 38);
            this.btnCadastrar.TabIndex = 69;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblResposta.Location = new System.Drawing.Point(46, 240);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(129, 29);
            this.lblResposta.TabIndex = 67;
            this.lblResposta.Text = "L I V R O S";
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = global::Projeto_BooksAndFun.Properties.Resources.open_book__2_;
            this.pctFuncionario.Location = new System.Drawing.Point(12, 23);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(197, 234);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 66;
            this.pctFuncionario.TabStop = false;
            // 
            // dgvLivros
            // 
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivros.EnableHeadersVisualStyles = false;
            this.dgvLivros.Location = new System.Drawing.Point(229, 61);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(858, 544);
            this.dgvLivros.TabIndex = 78;
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 617);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.pctFuncionario);
            this.Name = "FrmLivros";
            this.Text = "FrmLivros";
            this.Load += new System.EventHandler(this.FrmLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.DataGridView dgvLivros;
    }
}