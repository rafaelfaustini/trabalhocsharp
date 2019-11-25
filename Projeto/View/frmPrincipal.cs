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
using Control;

namespace View
{
    public partial class frmPrincipal : Form
    {

        private Dictionary<Int64, Usuario> mapaUsuarios;
        private Dictionary<Int64, Historia> mapaHistorias;




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
            frmCadComentario form = new frmCadComentario();
            form.Tag = mapaHistorias.Values.ToList();
            AbrirForm(form);
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

                CarregarListaUsuarios();
                CarregarListaHistorias();

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
        private void itbCadUsuario_Click(object sender, EventArgs e)
        {
            frmCadUsuario form = new frmCadUsuario();

            try
            {
            Int64 ultimaChave = mapaUsuarios.Keys.Max() + 1;

            form.Tag = ultimaChave;

            }catch{

            }

            AbrirForm(form);
        }
        private void CarregarListaUsuarios()
        {
            try
            {
                UsuarioController control = new UsuarioController();

                mapaUsuarios = control.ListarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTA DE Usuarios: " + ex.Message);
            }
        }
        private void CarregarListaHistorias()
        {
            try
            {
                HistoriaController control = new HistoriaController();

                mapaHistorias = control.ListarHistorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTA DE Histórias: " + ex.Message);
            }
        }


        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }

        private void itbCadHistoria_Click(object sender, EventArgs e)
        {
            frmCadHistoria form = new frmCadHistoria();
            form.Tag = mapaUsuarios.Values.ToList();
            AbrirForm(form);
        }

        private void itbCadCapitulo_Click(object sender, EventArgs e)
        {
            frmCadCapitulo form = new frmCadCapitulo();
            form.Tag = mapaHistorias.Values.ToList();
            AbrirForm(form);
        }

        private void itbCadFavorito_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadUsuario());
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmListaUsuarios form = new frmListaUsuarios();

            try
            {
                form.Tag = mapaUsuarios;

            }
            catch
            {

            }
            AbrirForm(form);
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaHistorias form = new frmListaHistorias();

            try
            {
                form.Tag = mapaHistorias;

            }
            catch
            {

            }
            AbrirForm(form);
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListaCapitulos form = new frmListaCapitulos();
            form.Tag = mapaHistorias.Values.ToList();
            AbrirForm(form);
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmListaComentarios form = new frmListaComentarios();
            form.Tag = mapaHistorias.Values.ToList();
            AbrirForm(form);
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

        private void itmArquivo_Click(object sender, EventArgs e)
        {

        }
    }
}
