using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disciplina> lista = new List<Disciplina>();
            Disciplina d1 = new Disciplina("Lab. Prog.", 4);
            Disciplina d2 = new Disciplina("Estrut. Dados", 4);
            Disciplina d3 = new Disciplina("Eng. Software", 4);
            lista.Add(d1);
            lista.Add(d2);
            lista.Add(d3);
            Aluno aluno = new Aluno("Aluno1", 23123123, lista);

            Console.WriteLine(aluno.Imprimir());

            Console.ReadKey();
        }
    }
    class Disciplina
    {
        private string materia;
        private int carga;

        public int Carga
        {
            get
            {
                return carga;
            }

            set
            {
                carga = value;
            }
        }

        public string Materia
        {
            get
            {
                return materia;
            }

            set
            {
                materia = value;
            }
        }
        public Disciplina (string materia, int carga)
        {
            this.carga = carga;
            this.materia = materia;
        }
        public string Imprimir()
        {
            return "Disciplina: " + this.materia + "Carga horária: " + this.carga;
        }
    }
    class Aluno
    {
        private string nome;
        private int ra;
        List<Disciplina> disciplinas;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Ra
        {
            get
            {
                return ra;
            }

            set
            {
                ra = value;
            }
        }

        internal List<Disciplina> Disciplinas
        {
            get
            {
                return disciplinas;
            }

            set
            {
                disciplinas = value;
            }
        }
        public Aluno (string nome, int ra, List<Disciplina> disc)
        {
            this.nome = nome;
            this.ra = ra;
            this.disciplinas = disc;
        }
        public string Imprimir()
        {
            string saida = this.nome + " " + this.ra + "\n";

            foreach (Disciplina d in this.disciplinas)
            {
                saida += d.Imprimir() + "\n";
            }

            return saida;
        }
    }
}
