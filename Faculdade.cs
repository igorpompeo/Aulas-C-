using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorUsuarios usuarios = new GerenciadorUsuarios();
            List<Disciplina> discAluno;
            Disciplina[] disciplinas = {
                new Disciplina("Estrutura de Dados", 4),
                new Disciplina("Laboratorio Programacao", 4),
                new Disciplina("Engenharia de Software", 4),
                new Disciplina("Antropologia", 4),
                new Disciplina("Projeto Integrado", 4),
            };

            usuarios.Add(new Professor("Artur", 12312, disciplinas[1]));
            usuarios.Add(new Professor("Fulano", 12312, disciplinas[0]));
            usuarios.Add(new Professor("Cicrano", 12312, disciplinas[2]));
            usuarios.Add(new Professor("Beltrano", 12312, disciplinas[3]));
            usuarios.Add(new Professor("Fulano2", 12312, disciplinas[4]));

            discAluno = new List<Disciplina>();
            discAluno.Add(disciplinas[0]);
            discAluno.Add(disciplinas[1]);

            usuarios.Add(new Aluno("Aluno1", 12313, discAluno));

            discAluno = new List<Disciplina>();
            discAluno.Add(disciplinas[1]);
            discAluno.Add(disciplinas[2]);

            usuarios.Add(new Aluno("Aluno2", 12313, discAluno));

            discAluno = new List<Disciplina>();
            discAluno.Add(disciplinas[3]);
            discAluno.Add(disciplinas[1]);

            usuarios.Add(new Aluno("Aluno3", 12313, discAluno));

            discAluno = new List<Disciplina>();
            discAluno.Add(disciplinas[0]);
            discAluno.Add(disciplinas[2]);

            usuarios.Add(new Aluno("Aluno4", 12313, discAluno));

            Console.WriteLine("Professores");
            Console.WriteLine(usuarios.ListarProfessores());
            Console.WriteLine("Alunos");
            Console.WriteLine(usuarios.ListarAlunos());
            while (true)
            {
                int i = 0;
                foreach (Disciplina d in disciplinas)
                {
                    Console.WriteLine(i + " - " + d.ToString());
                    i++;
                }

                Console.WriteLine("Selecione uma disciplina (0 - 4)");

                Console.WriteLine(
                    usuarios.BuscarDisciplina(
                        disciplinas[int.Parse(Console.ReadLine())]
                        )
                    );
            }
        }
    }

    class Disciplina
    {
        private string nome;
        private int cargaHoraria;

        public Disciplina (string nome, int ch)
        {
            this.nome = nome;
            this.cargaHoraria = ch;
        }

        public override string ToString()
        {
            return this.nome + " (" + this.cargaHoraria + ")";
        }
    }

    class Usuario
    {
        private string nome;
        private int ru;

        public Usuario(string nome, int ru)
        {
            this.nome = nome;
            this.ru = ru;
        }

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

        public int Ru
        {
            get
            {
                return ru;
            }

            set
            {
                ru = value;
            }
        }

        public override string ToString()
        {
            return this.nome + " " + this.ru;
        }
    }

    class Aluno : Usuario
    {
        private List<Disciplina> disciplinas;

        public Aluno(string nome, int ru, List<Disciplina> lst):
            base(nome,ru)
        {
            this.disciplinas = lst;
        }

        internal List<Disciplina> Disciplinas
        {
            get
            {
                return disciplinas;
            }

            private set
            {
                disciplinas = value;
            }
        }
        public override string ToString()
        {
            return "Aluno:" + base.ToString();
        }
    }

    class Professor : Usuario
    {
        private Disciplina disciplina;

        public Professor(string nome, int ru, Disciplina disc):
            base(nome,ru)
        {
            this.disciplina = disc;
        }

        internal Disciplina Disciplina
        {
            get
            {
                return disciplina;
            }

            private set
            {
                disciplina = value;
            }
        }
        public override string ToString()
        {
            return "Professor:" + base.ToString();
        }
    }
    
    class GerenciadorUsuarios
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void Add(Usuario u)
        {
            this.usuarios.Add(u);
        }

        public string ListarProfessores()
        {
            string saida = "";

            foreach(Usuario u in usuarios)
            {
                if (u is Professor)
                    saida += u.ToString() + "\n";
            }

            return saida;
        }

        public string ListarAlunos()
        {
            string saida = "";

            foreach (Usuario u in usuarios)
            {
                if (u is Aluno)
                    saida += u.ToString() + "\n";
            }

            return saida;
        }

        public string BuscarDisciplina(Disciplina d)
        {
            string saida = "";

            foreach (Usuario u in usuarios)
            {
                if (u is Professor)
                {
                    if (((Professor)u).Disciplina == d)
                    {
                        saida += u.ToString() + "\n";
                    }
                }
            }

            foreach (Usuario u in usuarios)
            {
                if (u is Aluno)
                {
                    foreach(Disciplina disc in ((Aluno)u).Disciplinas)
                    {
                        if (disc == d)
                        {
                            saida += u.ToString() + "\n";
                        }
                    }
                    
                }
            }

            return saida;
        }

    }


}
