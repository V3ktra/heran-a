using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herança2
{
    public partial class Cad_Prof : Form
    {
        public Cad_Prof()
        {
            InitializeComponent();
        }
        Professor professor;
        private void btn_cad_Click(object sender, EventArgs e)
        {
            professor = new Professor(txt_nome.Text, (Convert.ToInt32(txt_idade.Text)), txt_titu.Text);
            txt_nome.Clear();
            txt_idade.Clear();
            txt_titu.Clear();
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImprimeDados());
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 prin = new Form1();
            prin.Show();
        }
    }
}
