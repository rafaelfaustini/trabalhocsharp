using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace View
{
    public partial class frmListaCapitulos : Form
    {
        List<Historia> historias = new List<Historia>();
        List<Capitulo> capitulos = null;

        public frmListaCapitulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregaLista()
        {
            dataGridView1.Rows.Clear();
            foreach (Capitulo c in capitulos)
            {
                dataGridView1.Rows.Add(c.id, c.Titulo, c.Texto, c.Observacoes);
            }
        }
        private void carregaCapitulos()
        {
            Historia selecionado = (Historia)comboBox1.SelectedItem;
            CapituloController control = new CapituloController();
            capitulos = control.ListarCapituloDeHistoria(selecionado).Values.ToList();
            carregaLista();
        }

        private void frmListaCapitulos_Load(object sender, EventArgs e)
        {

            var cast = this.Tag as List<Historia>;
            if (cast != null)
            {
                historias = (List<Historia>)this.Tag;
                comboBox1.DataSource = historias;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "Id";
                carregaCapitulos();
            }
            else
            {

            }

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            carregaCapitulos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaCapitulos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadCapitulo form = new frmCadCapitulo();
                DataGridViewCellCollection d = dataGridView1.SelectedRows[0].Cells;
                Capitulo c = new Capitulo();

                string id = d[0].Value.ToString();
                c.id = int.Parse(id);
                c.historia = (Historia)comboBox1.SelectedItem;
                c.Titulo = d[1].Value.ToString();
                c.Texto = d[2].Value.ToString();
                c.Observacoes = d[3].Value.ToString();
          
                form.Tag = c;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (id != null)
            {
                CapituloController control = new CapituloController();
                control.RemoverBD(id);
                int indice = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(indice);
            }
        }
    }
}
