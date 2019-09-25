using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class frmPrincipal : Form
    {

        private Dictionary<Int64, Usuario> mapaUsuarios;
        private Dictionary<Int64, Usuario> mapaHistorias;
        private Dictionary<Int64, Usuario> mapaCapitulos;




        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadComentario());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            
            frmLogin form = new frmLogin();

            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();

                Usuario user = (Usuario)form.Tag;

                sUser.Text = " | Usuário: " + user.DisplayName;

                tmHora.Enabled = true;

            }
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            itsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void AbrirForm(Form frm)
        {
            frm.Show();
        }
    
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }
        private void itbCadPessoa_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }


        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }

        private void itbCadHistoria_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadHistoria());
        }

        private void itbCadCapitulo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadCapitulo());
        }

        private void itbCadFavorito_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new frmListaUsuarios());
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmListaHistorias());
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmListaCapitulos());
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmListaComentarios());
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadHistoria());
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadCapitulo());
        }

        private void aDicionarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadComentario());
        }

        private void adicionarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
