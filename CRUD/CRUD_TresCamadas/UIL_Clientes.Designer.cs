namespace CRUD_TresCamadas
{
    partial class UIL_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIL_Clientes));
            this.dgvListarDados = new System.Windows.Forms.DataGridView();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLeitura = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListarDados
            // 
            this.dgvListarDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDados.Location = new System.Drawing.Point(56, 278);
            this.dgvListarDados.Name = "dgvListarDados";
            this.dgvListarDados.Size = new System.Drawing.Size(559, 150);
            this.dgvListarDados.TabIndex = 25;
            this.dgvListarDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarDados_CellContentClick);
            // 
            // btExcluir
            // 
            this.btExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btExcluir.Location = new System.Drawing.Point(540, 196);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 24;
            this.btExcluir.Text = "&Excluir(D)";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLeitura
            // 
            this.btLeitura.Enabled = false;
            this.btLeitura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btLeitura.Location = new System.Drawing.Point(306, 196);
            this.btLeitura.Name = "btLeitura";
            this.btLeitura.Size = new System.Drawing.Size(75, 23);
            this.btLeitura.TabIndex = 23;
            this.btLeitura.Text = "&Leitura(R)";
            this.btLeitura.UseVisualStyleBackColor = true;
            this.btLeitura.Click += new System.EventHandler(this.btLeitura_Click);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btGravar.Location = new System.Drawing.Point(189, 196);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 22;
            this.btGravar.Text = "&Gravar(C)";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCadastrar.Location = new System.Drawing.Point(72, 196);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 21;
            this.btCadastrar.Text = "&Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAtualizar.Location = new System.Drawing.Point(423, 196);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 19;
            this.btAtualizar.Text = "&Atualizar(U)";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(128, 116);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(331, 20);
            this.tbCodigo.TabIndex = 18;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(128, 77);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(331, 20);
            this.tbPesquisar.TabIndex = 17;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(128, 151);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(331, 20);
            this.tbNome.TabIndex = 16;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(69, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pesquisa:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(56, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 47);
            this.panel1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CRUD_TresCamadas.Properties.Resources.atualizar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(429, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 36);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CRUD_TresCamadas.Properties.Resources.gravar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(189, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackgroundImage = global::CRUD_TresCamadas.Properties.Resources.pesquisar;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPesquisar.Enabled = false;
            this.btPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPesquisar.Location = new System.Drawing.Point(407, 17);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(30, 20);
            this.btPesquisar.TabIndex = 20;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // UIL_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListarDados);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btLeitura);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UIL_Clientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UIL_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarDados;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btLeitura;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

