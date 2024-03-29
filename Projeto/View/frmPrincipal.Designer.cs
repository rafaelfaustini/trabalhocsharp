﻿namespace View
{
    partial class frmPrincipal
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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.itmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.comentárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDicionarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefa = new System.Windows.Forms.ToolStrip();
            this.itbCadPessoa = new System.Windows.Forms.ToolStripButton();
            this.itbCadHistoria = new System.Windows.Forms.ToolStripButton();
            this.itbCadCapitulo = new System.Windows.Forms.ToolStripButton();
            this.itbCadComentario = new System.Windows.Forms.ToolStripButton();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.itsLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.sUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.mnPrincipal.SuspendLayout();
            this.barraTarefa.SuspendLayout();
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmArquivo});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(830, 24);
            this.mnPrincipal.TabIndex = 6;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // itmArquivo
            // 
            this.itmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.históriaToolStripMenuItem,
            this.capítuloToolStripMenuItem,
            this.comentárioToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.itmArquivo.Name = "itmArquivo";
            this.itmArquivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.itmArquivo.Size = new System.Drawing.Size(61, 20);
            this.itmArquivo.Text = "A&rquivo";
            this.itmArquivo.ToolTipText = "Item arquivo";
            this.itmArquivo.Click += new System.EventHandler(this.itmArquivo_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click_1);
            // 
            // históriaToolStripMenuItem
            // 
            this.históriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.listarToolStripMenuItem1});
            this.históriaToolStripMenuItem.Name = "históriaToolStripMenuItem";
            this.históriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.históriaToolStripMenuItem.Text = "História";
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // capítuloToolStripMenuItem
            // 
            this.capítuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem2,
            this.listarToolStripMenuItem2});
            this.capítuloToolStripMenuItem.Name = "capítuloToolStripMenuItem";
            this.capítuloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.capítuloToolStripMenuItem.Text = "Capítulo";
            // 
            // adicionarToolStripMenuItem2
            // 
            this.adicionarToolStripMenuItem2.Name = "adicionarToolStripMenuItem2";
            this.adicionarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem2.Text = "Adicionar";
            this.adicionarToolStripMenuItem2.Click += new System.EventHandler(this.adicionarToolStripMenuItem2_Click);
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // comentárioToolStripMenuItem
            // 
            this.comentárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDicionarToolStripMenuItem3,
            this.listarToolStripMenuItem3});
            this.comentárioToolStripMenuItem.Name = "comentárioToolStripMenuItem";
            this.comentárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comentárioToolStripMenuItem.Text = "Comentário";
            // 
            // aDicionarToolStripMenuItem3
            // 
            this.aDicionarToolStripMenuItem3.Name = "aDicionarToolStripMenuItem3";
            this.aDicionarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.aDicionarToolStripMenuItem3.Text = "Adicionar";
            this.aDicionarToolStripMenuItem3.Click += new System.EventHandler(this.aDicionarToolStripMenuItem3_Click);
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            this.listarToolStripMenuItem3.Click += new System.EventHandler(this.listarToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // barraTarefa
            // 
            this.barraTarefa.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.barraTarefa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itbCadPessoa,
            this.itbCadHistoria,
            this.itbCadCapitulo,
            this.itbCadComentario});
            this.barraTarefa.Location = new System.Drawing.Point(0, 24);
            this.barraTarefa.Name = "barraTarefa";
            this.barraTarefa.Size = new System.Drawing.Size(830, 52);
            this.barraTarefa.TabIndex = 7;
            this.barraTarefa.Text = "toolStrip1";
            // 
            // itbCadPessoa
            // 
            this.itbCadPessoa.Image = global::View.Properties.Resources.nova_pessoa;
            this.itbCadPessoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itbCadPessoa.Name = "itbCadPessoa";
            this.itbCadPessoa.Size = new System.Drawing.Size(96, 49);
            this.itbCadPessoa.Text = "Usuario";
            this.itbCadPessoa.Click += new System.EventHandler(this.itbCadUsuario_Click);
            // 
            // itbCadHistoria
            // 
            this.itbCadHistoria.Image = global::View.Properties.Resources.nova_historia;
            this.itbCadHistoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itbCadHistoria.Name = "itbCadHistoria";
            this.itbCadHistoria.Size = new System.Drawing.Size(97, 49);
            this.itbCadHistoria.Text = "História";
            this.itbCadHistoria.Click += new System.EventHandler(this.itbCadHistoria_Click);
            // 
            // itbCadCapitulo
            // 
            this.itbCadCapitulo.Image = global::View.Properties.Resources.novo_capitulo;
            this.itbCadCapitulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itbCadCapitulo.Name = "itbCadCapitulo";
            this.itbCadCapitulo.Size = new System.Drawing.Size(101, 49);
            this.itbCadCapitulo.Text = "Capitulo";
            this.itbCadCapitulo.Click += new System.EventHandler(this.itbCadCapitulo_Click);
            // 
            // itbCadComentario
            // 
            this.itbCadComentario.Image = global::View.Properties.Resources.novo_comentario;
            this.itbCadComentario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itbCadComentario.Name = "itbCadComentario";
            this.itbCadComentario.Size = new System.Drawing.Size(119, 49);
            this.itbCadComentario.Text = "Comentário";
            this.itbCadComentario.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsLabelHora,
            this.sUser});
            this.barraStatus.Location = new System.Drawing.Point(0, 403);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(830, 22);
            this.barraStatus.TabIndex = 9;
            this.barraStatus.Text = "statusStrip1";
            // 
            // itsLabelHora
            // 
            this.itsLabelHora.Name = "itsLabelHora";
            this.itsLabelHora.Size = new System.Drawing.Size(49, 17);
            this.itsLabelHora.Text = "00:00:00";
            // 
            // sUser
            // 
            this.sUser.Name = "sUser";
            this.sUser.Size = new System.Drawing.Size(35, 17);
            this.sUser.Text = "sUser";
            // 
            // tmHora
            // 
            this.tmHora.Interval = 1000;
            this.tmHora.Tick += new System.EventHandler(this.tmHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 425);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.barraTarefa);
            this.Controls.Add(this.mnPrincipal);
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Histórias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.barraTarefa.ResumeLayout(false);
            this.barraTarefa.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem itmArquivo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraTarefa;
        private System.Windows.Forms.ToolStripButton itbCadComentario;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itsLabelHora;
        private System.Windows.Forms.Timer tmHora;
        private System.Windows.Forms.ToolStripStatusLabel sUser;
        private System.Windows.Forms.ToolStripButton itbCadPessoa;
        private System.Windows.Forms.ToolStripButton itbCadHistoria;
        private System.Windows.Forms.ToolStripButton itbCadCapitulo;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem capítuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem comentárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDicionarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
    }
}

