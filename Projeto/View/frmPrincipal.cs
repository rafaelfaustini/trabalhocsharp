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

        private Dictionary<Int64, Pessoa> mapaPessoas;

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

                sUser.Text = " | Usuário logado: " + user.DisplayName;

                tmHora.Enabled = true;

            }
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            itsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormCadPessoa();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuarios form = new frmListaUsuarios();

            form.ShowDialog();
        }

        private void AbrirFormCadUsuario()
        {
            frmCadUsuario form = new frmCadUsuario();

            form.ShowDialog();
        }

        private void itbCadPessoa_Click(object sender, EventArgs e)
        {
            AbrirFormCadPessoa();
        }


        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
