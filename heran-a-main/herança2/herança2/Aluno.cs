using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança2
{
    public class Aluno : Pessoa
    {
        private string curso;

        public Aluno() 
        {
            this.curso = null;
        }

        public Aluno(string nome, int idade, string curso) 
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override String ImprimeDados() 
        {
            String s = String.Empty;
            s = String.Concat(this.nome, " ", this.idade.ToString(), " ", this.Curso);
            return s;
        }
    }
}
