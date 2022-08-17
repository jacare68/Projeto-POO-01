using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_classe_com_herança
{
    public class Aluno : Pessoa
    {
        private int Matricula;
        
        public Aluno()
        {
            this.Nome = null;
            this.Idade = 0;
            this.Matricula = 0;
        }

        public Aluno( string nome, int idade, int matricula)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Matricula = matricula;
        }

        public int matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, "", this.Idade, "", this.Matricula);
            return s;
        }


    }
}
