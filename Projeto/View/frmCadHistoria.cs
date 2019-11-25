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
    public partial class frmCadHistoria : Form
    {
        List<Usuario> usuarios = null;
        public frmCadHistoria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadHistoria_Load(object sender, EventArgs e)
        {
            var usuariocast = this.Tag as List<Usuario>;
            if (usuariocast != null)
            {
                usuarios = (List<Usuario>)this.Tag;
                comboBox1.DataSource = usuarios;
                comboBox1.DisplayMember = "Username";
                comboBox1.ValueMember = "Id";
            }
            else
            {
                UsuarioController control = new UsuarioController();
                usuarios = control.ListarUsuarios().Values.ToList();
                comboBox1.DataSource = usuarios;
                comboBox1.DisplayMember = "Username";
                comboBox1.ValueMember = "Id";

                Historia h = (Historia)this.Tag;

                comboBox1.SelectedItem = h.Autor;
                txbNomeUsuario.Text = h.Titulo;
                txbNome.Text = h.Sinopse;
                button1.Text = "Alterar";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var historiacast = this.Tag as Historia;
                HistoriaController control = new HistoriaController();


                if (historiacast != null)
                {
                    var h = (Historia)this.Tag;
                    h.Autor = (Usuario)comboBox1.SelectedItem;
                    h.Titulo = txbNomeUsuario.Text;
                    h.Data = DateTime.Today;
                    h.Sinopse = txbNome.Text;
                    Boolean teste = control.AlterarBD(h);
                    if (teste)
                    {
                        MessageBox.Show("História alterada com sucesso!");
                    }
                }
                else
                {

                    Historia h = new Historia();
                    h.Autor = (Usuario)comboBox1.SelectedItem;
                    h.Titulo = txbNomeUsuario.Text;
                    h.Data = DateTime.Today;
                    h.Sinopse = txbNome.Text;

                    //Enviar objeto para camada de controle para Salvar no arquivo
                    Boolean teste = control.InserirBD(h);

                    if (teste)
                    {
                        MessageBox.Show("História cadastrada com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR HISTORIA: " + ex.Message);
            }
     
        }
    }
}
