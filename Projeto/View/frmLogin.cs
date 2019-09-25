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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();

                user.DisplayName = "Admin";
                user.Email = txbLogin.Text;
                user.Senha = txbSenha.Text;


                if (ValidarUsuario(user))
                {
                    this.Tag = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblMsg.Text = "Email ou Senha inválidos!!!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private bool ValidarUsuario(Usuario user)
        {
            try
            {
                if (user.Email == "admin@lasalle.org.br" && user.Senha == "admin")
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            return false;
        }
    }
}
