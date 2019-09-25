namespace View
{
    partial class frmListaUsuarios
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
            this.gpbPessoas = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcolNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcolEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcolUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcolSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.janelaImpressao = new System.Windows.Forms.PrintDialog();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpbPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPessoas
            // 
            this.gpbPessoas.Controls.Add(this.dgvDados);
            this.gpbPessoas.Location = new System.Drawing.Point(12, 12);
            this.gpbPessoas.Name = "gpbPessoas";
            this.gpbPessoas.Size = new System.Drawing.Size(539, 392);
            this.gpbPessoas.TabIndex = 6;
            this.gpbPessoas.TabStop = false;
            this.gpbPessoas.Text = "Lista de Pessoas";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcolID,
            this.gcolNome,
            this.gcolEmail,
            this.gcolUsername,
            this.gcolSenha});
            this.dgvDados.Location = new System.Drawing.Point(6, 19);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(527, 354);
            this.dgvDados.TabIndex = 4;
            // 
            // gcolID
            // 
            this.gcolID.HeaderText = "ID";
            this.gcolID.Name = "gcolID";
            this.gcolID.ReadOnly = true;
            this.gcolID.Width = 40;
            // 
            // gcolNome
            // 
            this.gcolNome.HeaderText = "Nome";
            this.gcolNome.Name = "gcolNome";
            this.gcolNome.ReadOnly = true;
            this.gcolNome.Width = 130;
            // 
            // gcolEmail
            // 
            this.gcolEmail.HeaderText = "E-mail";
            this.gcolEmail.Name = "gcolEmail";
            this.gcolEmail.ReadOnly = true;
            this.gcolEmail.Width = 150;
            // 
            // gcolUsername
            // 
            this.gcolUsername.HeaderText = "Username";
            this.gcolUsername.Name = "gcolUsername";
            this.gcolUsername.ReadOnly = true;
            // 
            // gcolSenha
            // 
            this.gcolSenha.HeaderText = "Senha";
            this.gcolSenha.Name = "gcolSenha";
            this.gcolSenha.ReadOnly = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(476, 410);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // janelaImpressao
            // 
            this.janelaImpressao.UseEXDialog = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(18, 410);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adicionar Favorito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpbPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios Cadastradas";
            this.gpbPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPessoas;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnFechar;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintDialog janelaImpressao;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolSenha;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}