using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_classe_com_herança
{
    public class Professor : Pessoa
    {
        private string titulacao;

        public Professor()
        {
            this.nome = null;
            this.idade = 0;
            this.titulacao = null;
        }

        public Professor( string nome, int idade, string titulacao)
        {
            this.nome = nome;
            this.idade = idade;
            this.titulacao = titulacao;
        }

        public string titulacao
        {
            get { return this.titulacao; }
            set { this.titulacao = value; }
        }

        public override string ImprimeDados()
        {
           String s = String Empty;
           s = String.Concat(this.Nome," ", this.Idade)
               
        }
    }
}
