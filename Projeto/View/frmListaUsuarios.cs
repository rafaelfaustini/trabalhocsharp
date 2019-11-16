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
    }
}
