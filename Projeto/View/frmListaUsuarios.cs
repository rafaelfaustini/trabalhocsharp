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
using System.IO;

namespace View
{
    public partial class frmListaUsuarios : Form
    {
        private Usuario u;

        public frmListaUsuarios()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFavoritarHistoria form = new frmFavoritarHistoria();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
            frmCadUsuario form = new frmCadUsuario();
            DataGridViewCellCollection d = dgvDados.SelectedRows[0].Cells;
            Usuario u = new Usuario();

            string id = d[0].Value.ToString();
            u.Id = int.Parse(id);
            u.DisplayName = d[1].Value.ToString();
            u.Email = d[2].Value.ToString();
            u.Username = d[3].Value.ToString();
            u.Senha = d[4].Value.ToString();



                form.Tag = u;
                form.ShowDialog();
            }
            catch
            {

            }
        }
        private void CarregarMapaUsuarios()
        {
            Dictionary<Int64, Usuario> mapaUsuarios = (Dictionary<Int64, Usuario>)this.Tag;
            foreach (Usuario o in mapaUsuarios.Values)
            {
                dgvDados.Rows.Add(o.Id, o.DisplayName, o.Email, o.Username, o.Senha);
            }
        }

        private void frmListaUsuarios_Load_1(object sender, EventArgs e)
        {
            CarregarMapaUsuarios();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDados.SelectedRows[0].Cells[0].Value.ToString());
            if (id != null)
            {
                UsuarioController control = new UsuarioController();
                control.RemoverBD(id);
                int indice = dgvDados.CurrentCell.RowIndex;
                dgvDados.Rows.RemoveAt(indice);
            }
        }
    }
}
