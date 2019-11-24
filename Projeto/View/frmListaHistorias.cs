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
    public partial class frmListaHistorias : Form
    {
        public frmListaHistorias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CarregarMapaHistorias()
        {
            Dictionary<Int64, Historia> mapaHistorias = (Dictionary<Int64, Historia>)this.Tag;
            foreach (Historia o in mapaHistorias.Values)
            {
                dataGridView1.Rows.Add(o.id, o.Autor, o.Titulo, o.Sinopse, o.Terminada, o.Data);
            }
        }

        private void frmListaHistorias_Load(object sender, EventArgs e)
        {
            CarregarMapaHistorias();
        }
    }
}
