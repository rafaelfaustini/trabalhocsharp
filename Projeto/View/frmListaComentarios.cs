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
    public partial class frmListaComentarios : Form
    {
        List<Historia> historias = new List<Historia>();
        List<Capitulo> capitulos = null;
        List<Comentario> comentarios = new List<Comentario>();

        public frmListaComentarios()
        {
            InitializeComponent();
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
                ComentarioController control = new ComentarioController();
                control.RemoverBD(id);
                int indice = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(indice);
            }
        }

        private void carregaLista()
        {
            dataGridView1.Rows.Clear();
            foreach (Comentario c in comentarios)
            {
                dataGridView1.Rows.Add(c.id, c.Texto, c.criado, c.Usuario);
            }
        }

        private void carregaComentarios()
        {
            Capitulo selecionado = (Capitulo)comboBox1.SelectedItem;
            ComentarioController control = new ComentarioController();
            if (selecionado != null)
            {
                comentarios = control.ListarComentariosDeCapitulo(selecionado).Values.ToList();
                carregaLista();
            }
        }
        private void carregaCapitulos()
        {
            Historia selecionado = (Historia)comboBox2.SelectedItem;
            CapituloController control = new CapituloController();
            capitulos = control.ListarCapituloDeHistoria(selecionado).Values.ToList();
            comboBox1.DataSource = capitulos;
            comboBox1.DisplayMember = "Titulo";
            comboBox1.ValueMember = "Id";
            carregaComentarios();
        }
        private void frmListaComentarios_Load(object sender, EventArgs e)
        {

            var cast = this.Tag as List<Historia>;
            if (cast != null)
            {
                historias = (List<Historia>)this.Tag;
                comboBox2.DataSource = historias;
                comboBox2.DisplayMember = "Titulo";
                comboBox2.ValueMember = "Id";
                carregaCapitulos();
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComentarios();
        }

        private void comboBox2_TabIndexChanged(object sender, EventArgs e)
        {
            carregaCapitulos();
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            carregaCapitulos();

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            carregaCapitulos();

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            carregaComentarios();

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            carregaComentarios();

        }
    }
}
