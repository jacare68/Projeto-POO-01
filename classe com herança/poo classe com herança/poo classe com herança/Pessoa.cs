using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_classe_com_herança
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

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
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public abstract String ImprimeDados();

    }

}
