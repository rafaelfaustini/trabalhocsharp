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
    public partial class frmCadCapitulo : Form
    {
        List<Historia> historias = new List<Historia>();
        public frmCadCapitulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadCapitulo_Load(object sender, EventArgs e)
        {
            var usuariocast = this.Tag as List<Historia>;
            if (usuariocast != null)
            {
                historias = (List<Historia>)this.Tag;
                comboBox1.DataSource = historias;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "id";
            }
            else
            {
                HistoriaController control = new HistoriaController();
                historias = control.ListarHistorias().Values.ToList();
                comboBox1.DataSource = historias;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "id";

                Capitulo c = (Capitulo)this.Tag;

                comboBox1.SelectedItem = c.historia;
                txbNomeUsuario.Text = c.Titulo;
                txbNome.Text = c.Texto;
                textBox1.Text = c.Observacoes;
                button1.Text = "Alterar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var capitulocast = this.Tag as Capitulo;
                CapituloController control = new CapituloController();


                if (capitulocast != null)
                {

                    var c = (Capitulo)this.Tag;

                    Boolean teste = control.AlterarBD(c);
                    if (teste)
                    {
                        MessageBox.Show("CAPITULO alterado com sucesso!");
                    }
                }
                else
                {

                    Capitulo c = new Capitulo();
                    c.historia = (Historia)comboBox1.SelectedItem;
                    c.Titulo = txbNomeUsuario.Text;
                    c.Texto = txbNome.Text;
                    c.Observacoes = textBox1.Text;

                    //Enviar objeto para camada de controle para Salvar no arquivo
                    Boolean teste = control.InserirBD(c);

                    if (teste)
                    {
                        MessageBox.Show("CAPITULO cadastrado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR CAPITULO: " + ex.Message);
            }
     
        }
    }
}
