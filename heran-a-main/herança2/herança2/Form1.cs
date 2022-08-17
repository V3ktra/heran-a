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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_prof_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cad_Prof prof = new Cad_Prof();
            prof.Show();
        }

        private void btn_aluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cad_Aluno aluno = new Cad_Aluno();
            aluno.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
