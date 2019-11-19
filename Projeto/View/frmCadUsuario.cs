using Model;
using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadUsuario : Form
    {
        private Usuario u = new Usuario();

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario usuario = CarregarUsuarioDoForm();
                UsuarioController control = new UsuarioController();
                var usuariocast = this.Tag as Usuario;

                if (usuariocast != null)
                {
                    u.Id = ((Usuario)this.Tag).Id;
                    Boolean teste = control.AlterarBD(usuario);
                    if (teste)
                    {
                        MessageBox.Show("Usuario alterado com sucesso!");
                    }
                } else {

                //Enviar objeto para camada de controle para Salvar no arquivo
               Boolean teste = control.InserirBD(usuario);

                if (teste)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!");
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR USUARIO: " + ex.Message);
            }
     
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            var usuariocast = this.Tag as Usuario;
            if(usuariocast != null){
                Usuario u = (Usuario)this.Tag;
                txbEmail.Text = u.Email;
                txbNome.Text = u.DisplayName;
                txbNomeUsuario.Text = u.Username;
                mtbSenha.Text = u.Senha;
                btnCadastrar.Text = "Alterar";
            }
        }

        public Usuario CarregarUsuarioDoForm()
        {
            try
            {
                u.Email = txbEmail.Text;
                u.Senha = mtbSenha.Text;
                u.DisplayName = txbNome.Text;
                u.Username = txbNomeUsuario.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar usuário: " + ex.Message);
            }

            return u;

        }

        private void CarregarFormDeUsuario(Usuario u)
        {
  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
