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
            this.lblContato = new System.Windows.Forms.Label();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.lblApagar = new System.Windows.Forms.Label();
            this.lblResponder = new System.Windows.Forms.Label();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.bntSair = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pctServicos = new System.Windows.Forms.PictureBox();
            this.pctEventos = new System.Windows.Forms.PictureBox();
            this.pctClientes = new System.Windows.Forms.PictureBox();
            this.pctFuncionarios = new System.Windows.Forms.PictureBox();
            this.pctLivros = new System.Windows.Forms.PictureBox();
            this.pctVendas = new System.Windows.Forms.PictureBox();
            this.btnResponder = new System.Windows.Forms.PictureBox();
            this.btnApagar = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.SystemColors.Control;
            this.lblContato.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblContato.Location = new System.Drawing.Point(382, 32);
            this.lblContato.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(385, 41);
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
            this.lblData.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblData.Location = new System.Drawing.Point(1503, 706);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(165, 30);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "00/00/0000";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblApagar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.ForeColor = System.Drawing.Color.White;
            this.lblApagar.Location = new System.Drawing.Point(769, 716);
            this.lblApagar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(82, 23);
            this.lblApagar.TabIndex = 62;
            this.lblApagar.Text = "APAGAR";
            this.lblApagar.Click += new System.EventHandler(this.lblApagar_Click);
            // 
            // lblResponder
            // 
            this.lblResponder.AutoSize = true;
            this.lblResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblResponder.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponder.ForeColor = System.Drawing.Color.White;
            this.lblResponder.Location = new System.Drawing.Point(934, 717);
            this.lblResponder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResponder.Name = "lblResponder";
            this.lblResponder.Size = new System.Drawing.Size(124, 23);
            this.lblResponder.TabIndex = 66;
            this.lblResponder.Text = "RESPONDER";
            this.lblResponder.Click += new System.EventHandler(this.lblResponder_Click);
            // 
            // dgvContato
            // 
            this.dgvContato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContato.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContato.EnableHeadersVisualStyles = false;
            this.dgvContato.Location = new System.Drawing.Point(370, 111);
            this.dgvContato.Margin = new System.Windows.Forms.Padding(5);
            this.dgvContato.MultiSelect = false;
            this.dgvContato.Name = "dgvContato";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContato.RowHeadersVisible = false;
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.Size = new System.Drawing.Size(1347, 598);
            this.dgvContato.TabIndex = 79;
            // 
            // bntSair
            // 
            this.bntSair.Image = global::Projeto_BooksAndFun.Properties.Resources.close_button__2_;
            this.bntSair.Location = new System.Drawing.Point(1855, 26);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(57, 34);
            this.bntSair.TabIndex = 87;
            this.bntSair.TabStop = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Projeto_BooksAndFun.Properties.Resources.logo_077;
            this.pictureBox9.Location = new System.Drawing.Point(1129, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(770, 634);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 86;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.TabIndex = 85;
            this.pictureBox8.TabStop = false;
            // 
            // pctServicos
            // 
            this.pctServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctServicos.Image = global::Projeto_BooksAndFun.Properties.Resources.servico_de_gestao_modificado;
            this.pctServicos.Location = new System.Drawing.Point(1321, 827);
            this.pctServicos.Margin = new System.Windows.Forms.Padding(5);
            this.pctServicos.Name = "pctServicos";
            this.pctServicos.Size = new System.Drawing.Size(195, 167);
            this.pctServicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctServicos.TabIndex = 84;
            this.pctServicos.TabStop = false;
            this.pctServicos.Click += new System.EventHandler(this.pctServicos_Click);
            // 
            // pctEventos
            // 
            this.pctEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEventos.Image = global::Projeto_BooksAndFun.Properties.Resources.output_onlinepngtools;
            this.pctEventos.Location = new System.Drawing.Point(1116, 827);
            this.pctEventos.Margin = new System.Windows.Forms.Padding(5);
            this.pctEventos.Name = "pctEventos";
            this.pctEventos.Size = new System.Drawing.Size(195, 167);
            this.pctEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEventos.TabIndex = 83;
            this.pctEventos.TabStop = false;
            this.pctEventos.Click += new System.EventHandler(this.pctEventos_Click_1);
            // 
            // pctClientes
            // 
            this.pctClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClientes.Image = global::Projeto_BooksAndFun.Properties.Resources.feedback_modified2;
            this.pctClientes.Location = new System.Drawing.Point(914, 827);
            this.pctClientes.Margin = new System.Windows.Forms.Padding(5);
            this.pctClientes.Name = "pctClientes";
            this.pctClientes.Size = new System.Drawing.Size(192, 167);
            this.pctClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClientes.TabIndex = 82;
            this.pctClientes.TabStop = false;
            this.pctClientes.Click += new System.EventHandler(this.pctClientes_Click);
            // 
            // pctFuncionarios
            // 
            this.pctFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFuncionarios.Image = global::Projeto_BooksAndFun.Properties.Resources.funcionarios_modificado;
            this.pctFuncionarios.Location = new System.Drawing.Point(712, 827);
            this.pctFuncionarios.Margin = new System.Windows.Forms.Padding(5);
            this.pctFuncionarios.Name = "pctFuncionarios";
            this.pctFuncionarios.Size = new System.Drawing.Size(192, 167);
            this.pctFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionarios.TabIndex = 81;
            this.pctFuncionarios.TabStop = false;
            this.pctFuncionarios.Click += new System.EventHandler(this.pctFuncionarios_Click);
            // 
            // pctLivros
            // 
            this.pctLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLivros.Image = global::Projeto_BooksAndFun.Properties.Resources.pilha_de_tres_livros_modificado;
            this.pctLivros.Location = new System.Drawing.Point(509, 827);
            this.pctLivros.Margin = new System.Windows.Forms.Padding(5);
            this.pctLivros.Name = "pctLivros";
            this.pctLivros.Size = new System.Drawing.Size(193, 167);
            this.pctLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLivros.TabIndex = 80;
            this.pctLivros.TabStop = false;
            this.pctLivros.Click += new System.EventHandler(this.pctLivros_Click_1);
            // 
            // pctVendas
            // 
            this.pctVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctVendas.Image = global::Projeto_BooksAndFun.Properties.Resources.revenue1;
            this.pctVendas.Location = new System.Drawing.Point(288, 827);
            this.pctVendas.Margin = new System.Windows.Forms.Padding(5);
            this.pctVendas.Name = "pctVendas";
            this.pctVendas.Size = new System.Drawing.Size(211, 167);
            this.pctVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVendas.TabIndex = 67;
            this.pctVendas.TabStop = false;
            this.pctVendas.Click += new System.EventHandler(this.pctVendas_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.Image = ((System.Drawing.Image)(resources.GetObject("btnResponder.Image")));
            this.btnResponder.Location = new System.Drawing.Point(913, 712);
            this.btnResponder.Margin = new System.Windows.Forms.Padding(5);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(156, 32);
            this.btnResponder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnResponder.TabIndex = 65;
            this.btnResponder.TabStop = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click_1);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(731, 712);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(156, 32);
            this.btnApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnApagar.TabIndex = 61;
            this.btnApagar.TabStop = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(2008, -5);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(1343, 1281);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1060);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pctServicos);
            this.Controls.Add(this.pctEventos);
            this.Controls.Add(this.pctClientes);
            this.Controls.Add(this.pctFuncionarios);
            this.Controls.Add(this.pctLivros);
            this.Controls.Add(this.dgvContato);
            this.Controls.Add(this.pctVendas);
            this.Controls.Add(this.lblResponder);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblApagar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.pctLogo);
            this.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Label lblResponder;
        private System.Windows.Forms.PictureBox btnResponder;
        private System.Windows.Forms.PictureBox pctVendas;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.PictureBox pctLivros;
        private System.Windows.Forms.PictureBox pctFuncionarios;
        private System.Windows.Forms.PictureBox pctClientes;
        private System.Windows.Forms.PictureBox pctEventos;
        private System.Windows.Forms.PictureBox pctServicos;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox bntSair;
    }
}