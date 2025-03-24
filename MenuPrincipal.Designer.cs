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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblContato = new System.Windows.Forms.Label();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.lblApagar = new System.Windows.Forms.Label();
            this.lblVisualizar = new System.Windows.Forms.Label();
            this.lblResponder = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnResponder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnApagar = new System.Windows.Forms.PictureBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.pctServico = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            this.pctEventos = new System.Windows.Forms.PictureBox();
            this.pctLivros = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.SystemColors.Control;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblContato.Location = new System.Drawing.Point(229, 19);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(450, 42);
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
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblData.Location = new System.Drawing.Point(865, 438);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(150, 31);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "00/00/0000";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.ForeColor = System.Drawing.Color.White;
            this.lblApagar.Location = new System.Drawing.Point(453, 462);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(99, 25);
            this.lblApagar.TabIndex = 62;
            this.lblApagar.Text = "APAGAR";
            this.lblApagar.Click += new System.EventHandler(this.lblApagar_Click);
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.AutoSize = true;
            this.lblVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar.ForeColor = System.Drawing.Color.White;
            this.lblVisualizar.Location = new System.Drawing.Point(257, 462);
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(133, 25);
            this.lblVisualizar.TabIndex = 64;
            this.lblVisualizar.Text = "VISUALIZAR";
            this.lblVisualizar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResponder
            // 
            this.lblResponder.AutoSize = true;
            this.lblResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.lblResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponder.ForeColor = System.Drawing.Color.White;
            this.lblResponder.Location = new System.Drawing.Point(625, 462);
            this.lblResponder.Name = "lblResponder";
            this.lblResponder.Size = new System.Drawing.Size(144, 25);
            this.lblResponder.TabIndex = 66;
            this.lblResponder.Text = "RESPONDER";
            this.lblResponder.Click += new System.EventHandler(this.lblResponder_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Projeto_BooksAndFun.Properties.Resources.revenue1;
            this.pictureBox2.Location = new System.Drawing.Point(31, 598);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.Image = ((System.Drawing.Image)(resources.GetObject("btnResponder.Image")));
            this.btnResponder.Location = new System.Drawing.Point(610, 459);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(156, 32);
            this.btnResponder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnResponder.TabIndex = 65;
            this.btnResponder.TabStop = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(417, 459);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(156, 32);
            this.btnApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnApagar.TabIndex = 61;
            this.btnApagar.TabStop = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("pctFuncionario.Image")));
            this.pctFuncionario.Location = new System.Drawing.Point(579, 598);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(175, 203);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 55;
            this.pctFuncionario.TabStop = false;
            this.pctFuncionario.Click += new System.EventHandler(this.pctFuncionario_Click);
            // 
            // pctServico
            // 
            this.pctServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctServico.Image = ((System.Drawing.Image)(resources.GetObject("pctServico.Image")));
            this.pctServico.Location = new System.Drawing.Point(760, 598);
            this.pctServico.Name = "pctServico";
            this.pctServico.Size = new System.Drawing.Size(175, 203);
            this.pctServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctServico.TabIndex = 13;
            this.pctServico.TabStop = false;
            // 
            // pctCliente
            // 
            this.pctCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCliente.Image = ((System.Drawing.Image)(resources.GetObject("pctCliente.Image")));
            this.pctCliente.Location = new System.Drawing.Point(216, 598);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(179, 203);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCliente.TabIndex = 12;
            this.pctCliente.TabStop = false;
            this.pctCliente.Click += new System.EventHandler(this.pctCliente_Click);
            // 
            // pctEventos
            // 
            this.pctEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEventos.Image = ((System.Drawing.Image)(resources.GetObject("pctEventos.Image")));
            this.pctEventos.Location = new System.Drawing.Point(941, 598);
            this.pctEventos.Name = "pctEventos";
            this.pctEventos.Size = new System.Drawing.Size(191, 203);
            this.pctEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEventos.TabIndex = 11;
            this.pctEventos.TabStop = false;
            this.pctEventos.Click += new System.EventHandler(this.pctEventos_Click);
            // 
            // pctLivros
            // 
            this.pctLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLivros.Image = ((System.Drawing.Image)(resources.GetObject("pctLivros.Image")));
            this.pctLivros.Location = new System.Drawing.Point(401, 598);
            this.pctLivros.Name = "pctLivros";
            this.pctLivros.Size = new System.Drawing.Size(172, 203);
            this.pctLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLivros.TabIndex = 1;
            this.pctLivros.TabStop = false;
            this.pctLivros.Click += new System.EventHandler(this.pctLivros_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(1205, -3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(806, 793);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // dgvContato
            // 
            this.dgvContato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContato.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContato.EnableHeadersVisualStyles = false;
            this.dgvContato.Location = new System.Drawing.Point(218, 64);
            this.dgvContato.MultiSelect = false;
            this.dgvContato.Name = "dgvContato";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(33)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvContato.RowHeadersVisible = false;
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.Size = new System.Drawing.Size(808, 371);
            this.dgvContato.TabIndex = 79;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgvContato);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblResponder);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblVisualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblApagar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pctServico);
            this.Controls.Add(this.pctCliente);
            this.Controls.Add(this.pctEventos);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.pctLivros);
            this.Controls.Add(this.pctLogo);
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctLivros;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.PictureBox pctEventos;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.PictureBox pctServico;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.PictureBox btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVisualizar;
        private System.Windows.Forms.Label lblResponder;
        private System.Windows.Forms.PictureBox btnResponder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvContato;
    }
}