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
    public partial class frmCadComentario : Form
    {
        List<Capitulo> capitulos = new List<Capitulo>();
        List<Historia> historias = null;
        List<Usuario> usuarios = null;
        public frmCadComentario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadComentario_Load(object sender, EventArgs e)
        {
           

            var usuariocast = this.Tag as List<Historia>;
            if (usuariocast != null)
            {
                UsuarioController control = new UsuarioController();
                usuarios = control.ListarUsuarios().Values.ToList();
                comboBox3.DataSource = usuarios;
                comboBox3.DisplayMember = "Username";
                comboBox3.ValueMember = "Id";

                historias = (List<Historia>)this.Tag;
                comboBox1.DataSource = historias;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "id";

                capitulos = ((Historia)comboBox1.SelectedItem).Capitulos;
                comboBox2.DataSource = capitulos;
                comboBox2.DisplayMember = "Titulo";
                comboBox2.ValueMember = "id";


            }
            else
            {
                HistoriaController control = new HistoriaController();
                historias = control.ListarHistorias().Values.ToList();
                comboBox1.DataSource = historias;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "id";

                capitulos = ((Historia)comboBox1.SelectedItem).Capitulos;
                comboBox2.DataSource = capitulos;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "id";

                Comentario c = (Comentario)this.Tag;

                comboBox1.SelectedItem = c.Capitulo.historia;
                comboBox2.SelectedItem = c.Capitulo;
                textBox1.Text = c.Texto;
                button1.Text = "Alterar";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            capitulos = ((Historia)comboBox1.SelectedItem).Capitulos;
            comboBox2.DataSource = capitulos;
            comboBox1.DisplayMember = "Titulo";
            comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comentariocast = this.Tag as Comentario;
            ComentarioController control = new ComentarioController();


            if (comentariocast != null)
            {
                var c = (Comentario)this.Tag;
                c.Usuario = (Usuario)comboBox3.SelectedItem;
                c.Capitulo.historia = (Historia)comboBox1.SelectedItem;
                c.Capitulo = (Capitulo)comboBox2.SelectedItem;
                c.Texto = textBox1.Text;
                
               /* Boolean teste = control.AlterarBD(c);
                if (teste)
                {
                    MessageBox.Show("Comentario alterada com sucesso!");
                } */
            }
            else
            {
                Comentario c = new Comentario();
                c.Usuario = (Usuario)comboBox3.SelectedItem;
                //c.Capitulo.historia = (Historia)comboBox1.SelectedItem;
                c.Capitulo = (Capitulo)comboBox2.SelectedItem;
                c.criado = DateTime.Today;
                c.Texto = textBox1.Text;

                //Enviar objeto para camada de controle para Salvar no arquivo
                Boolean teste = control.InserirBD(c);

                if (teste)
                {
                    MessageBox.Show("Comentario cadastrado com sucesso!");
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            capitulos = ((Historia)comboBox1.SelectedItem).Capitulos;
            comboBox2.DataSource = capitulos;
            comboBox1.DisplayMember = "Titulo";
            comboBox1.ValueMember = "id";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            capitulos = ((Historia)comboBox1.SelectedItem).Capitulos;
            comboBox2.DataSource = capitulos;
            comboBox1.DisplayMember = "Titulo";
            comboBox1.ValueMember = "id";
        }
    }
}
