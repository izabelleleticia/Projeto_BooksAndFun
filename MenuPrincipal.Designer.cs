namespace Projeto_BooksAndFun
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblContato = new System.Windows.Forms.Label();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.pctServico = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            this.pctEventos = new System.Windows.Forms.PictureBox();
            this.pctLivros = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContato
            // 
            this.dgvContato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.dgvContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContato.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContato.EnableHeadersVisualStyles = false;
            this.dgvContato.Location = new System.Drawing.Point(38, 38);
            this.dgvContato.Name = "dgvContato";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContato.Size = new System.Drawing.Size(592, 249);
            this.dgvContato.TabIndex = 5;
            this.dgvContato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContato_CellContentClick);
            this.dgvContato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContato_CellFormatting);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVisualizar.Location = new System.Drawing.Point(38, 293);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(124, 28);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "VISUALIZAR";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApagar.Location = new System.Drawing.Point(38, 327);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(123, 28);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.btnResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponder.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResponder.Location = new System.Drawing.Point(39, 361);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(123, 29);
            this.btnResponder.TabIndex = 9;
            this.btnResponder.Text = "RESPONDER";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.SystemColors.Control;
            this.lblContato.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblContato.Location = new System.Drawing.Point(35, 11);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(221, 23);
            this.lblContato.TabIndex = 10;
            this.lblContato.Text = "CONTATOS POR E-MAIL";
            // 
            // timerData
            // 
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblData.Location = new System.Drawing.Point(498, 290);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(132, 23);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "00/00/0000";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(1171, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 29);
            this.btnSair.TabIndex = 54;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("pctFuncionario.Image")));
            this.pctFuncionario.Location = new System.Drawing.Point(311, 414);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(136, 125);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 55;
            this.pctFuncionario.TabStop = false;
            this.pctFuncionario.Click += new System.EventHandler(this.pctFuncionario_Click);
            // 
            // pctServico
            // 
            this.pctServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctServico.Image = global::Projeto_BooksAndFun.Properties.Resources.servico_de_gestao_modificado;
            this.pctServico.Location = new System.Drawing.Point(453, 414);
            this.pctServico.Name = "pctServico";
            this.pctServico.Size = new System.Drawing.Size(136, 125);
            this.pctServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctServico.TabIndex = 13;
            this.pctServico.TabStop = false;
            // 
            // pctCliente
            // 
            this.pctCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCliente.Image = ((System.Drawing.Image)(resources.GetObject("pctCliente.Image")));
            this.pctCliente.Location = new System.Drawing.Point(12, 414);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(149, 135);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCliente.TabIndex = 12;
            this.pctCliente.TabStop = false;
            this.pctCliente.Click += new System.EventHandler(this.pctCliente_Click);
            // 
            // pctEventos
            // 
            this.pctEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEventos.Image = ((System.Drawing.Image)(resources.GetObject("pctEventos.Image")));
            this.pctEventos.Location = new System.Drawing.Point(595, 414);
            this.pctEventos.Name = "pctEventos";
            this.pctEventos.Size = new System.Drawing.Size(138, 135);
            this.pctEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEventos.TabIndex = 11;
            this.pctEventos.TabStop = false;
            this.pctEventos.Click += new System.EventHandler(this.pctEventos_Click_1);
            // 
            // pctLivros
            // 
            this.pctLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLivros.Image = global::Projeto_BooksAndFun.Properties.Resources.pilha_de_tres_livros_modificado;
            this.pctLivros.Location = new System.Drawing.Point(173, 414);
            this.pctLivros.Name = "pctLivros";
            this.pctLivros.Size = new System.Drawing.Size(132, 135);
            this.pctLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLivros.TabIndex = 1;
            this.pctLivros.TabStop = false;
            this.pctLivros.Click += new System.EventHandler(this.pctLivros_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::Projeto_BooksAndFun.Properties.Resources.logo_077;
            this.pctLogo.Location = new System.Drawing.Point(619, -121);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(746, 682);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 680);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pctServico);
            this.Controls.Add(this.pctCliente);
            this.Controls.Add(this.pctEventos);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dgvContato);
            this.Controls.Add(this.pctLivros);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctLivros;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.PictureBox pctEventos;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.PictureBox pctServico;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pctFuncionario;
    }
}