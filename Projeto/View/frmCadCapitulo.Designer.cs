namespace View
{
    partial class frmCadCapitulo
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpbDadosComp = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbNomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbDadosComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(504, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Selecione a história";
            // 
            // gpbDadosComp
            // 
            this.gpbDadosComp.Controls.Add(this.textBox1);
            this.gpbDadosComp.Controls.Add(this.label1);
            this.gpbDadosComp.Controls.Add(this.txbNome);
            this.gpbDadosComp.Controls.Add(this.txbNomeUsuario);
            this.gpbDadosComp.Controls.Add(this.label3);
            this.gpbDadosComp.Controls.Add(this.label2);
            this.gpbDadosComp.Location = new System.Drawing.Point(12, 70);
            this.gpbDadosComp.Name = "gpbDadosComp";
            this.gpbDadosComp.Size = new System.Drawing.Size(504, 432);
            this.gpbDadosComp.TabIndex = 7;
            this.gpbDadosComp.TabStop = false;
            this.gpbDadosComp.Text = "Dados de Capítulo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 128);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Observações:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(107, 57);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(371, 210);
            this.txbNome.TabIndex = 10;
            // 
            // txbNomeUsuario
            // 
            this.txbNomeUsuario.Location = new System.Drawing.Point(107, 24);
            this.txbNomeUsuario.Name = "txbNomeUsuario";
            this.txbNomeUsuario.Size = new System.Drawing.Size(371, 20);
            this.txbNomeUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadCapitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbDadosComp);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmCadCapitulo";
            this.Text = "Cadastro de Capítulo";
            this.Load += new System.EventHandler(this.frmCadCapitulo_Load);
            this.gpbDadosComp.ResumeLayout(false);
            this.gpbDadosComp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gpbDadosComp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbNomeUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}