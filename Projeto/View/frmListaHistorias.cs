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
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (id != null)
            {
                HistoriaController control = new HistoriaController();
                control.RemoverBD(id);
                int indice = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(indice);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadHistoria form = new frmCadHistoria();
                DataGridViewCellCollection d = dataGridView1.SelectedRows[0].Cells;
                Historia h = new Historia();

                string id = d[0].Value.ToString();
                h.id = int.Parse(id);
                h.Autor = (Usuario)d[1].Value;
                h.Titulo = d[2].Value.ToString();
                h.Sinopse = d[3].Value.ToString();
                String s = d[4].Value.ToString();
                h.Terminada = Convert.ToBoolean(s);
                h.Data = Convert.ToDateTime(d[5].Value.ToString());


                form.Tag = h;
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }
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
