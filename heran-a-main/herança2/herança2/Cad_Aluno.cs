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
    public partial class Cad_Aluno : Form
    {
        public Cad_Aluno()
        {
            InitializeComponent();
        }
        Aluno aluno;
        private void btn_cad_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txt_nome.Text, (Convert.ToInt32(txt_idade.Text)), txt_curso.Text);
            txt_nome.Clear();
            txt_idade.Clear();
            txt_curso.Clear();
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImprimeDados());
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 pin = new Form1();
            pin.Show();
        }
    }
}
