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

        private void frmListaCapitulos_Load(object sender, EventArgs e)
        {

            var cast = this.Tag as List<Historia>;
            if (cast != null)
            {
                historias = (List<Historia>)this.Tag;
                comboBox1.DataSource = historias;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "Id";
            }
            else
            {

            }

        }
    }
}
