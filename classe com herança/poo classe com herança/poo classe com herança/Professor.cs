 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_classe_com_herança
{
    public class Professor : Pessoa
    {
        private string Titulacao;

        public Professor()
        {
            this.Nome = null;
            this.Idade = 0;
            this.Titulacao = null;
        }

        public Professor( string nome, int idade, string titulacao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Titulacao = titulacao;
        }

        public string titulacao
        {
            get { return this.titulacao; }
            set { this.titulacao = value; }
        }

        public override string ImprimeDados()
        {
           String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Idade.ToString(), " ", this.Titulacao);
            return s;
        }
    }
}
