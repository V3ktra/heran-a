﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança2
{
    public abstract class Pessoa
    {
        public string nome;
        public int idade;
    }
    public Pessoa() 
    {
        this.nome = null;
        this.idade = 0;
    }
    public Pessoa(string nome, int idade) 
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public abstract String ImprimeDados();
}
