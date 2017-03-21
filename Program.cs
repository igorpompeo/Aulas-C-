using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, rua, compl;
            int idade, num;
            long cep;

            Pessoa p;
            Endereco e;

            while (true)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a rua: ");
                rua = Console.ReadLine();
                Console.WriteLine("Digite a numero: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o complemento:");
                compl = Console.ReadLine();
                Console.WriteLine("Digite o cep:");
                cep = long.Parse(Console.ReadLine());

                e = new Endereco(rua, num, compl, cep);
                p = new Pessoa(nome, idade, e);

                Console.WriteLine(p.Imprimir());
            }
        }
    }
    class Endereco
    {
        private string rua;
        private int numero;
        private string complemento;
        private long cep;

        public Endereco(string rua, int numero, string complemento, long cep)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Cep = cep;
        }

        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public long Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }
        public string Imprimir()
        {
            return "Rua: " + this.rua + "N: " + this.numero + "Complemento: " + this.complemento +
                "CEP: " + this.cep;
        }
    }
    class Pessoa
    {
        private string nome;
        private int idade;
        private Endereco residencial;

        public Pessoa (string nome, int idade, Endereco residencial)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.residencial = residencial;
        }

        public Pessoa()
        {
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

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        internal Endereco Residencial
        {
            get
            {
                return residencial;
            }

            set
            {
                residencial = value;
            }
        }
        public string Imprimir()
        {
            return "Nome:" + this.nome + "\n Idade:" + this.idade + "\n Endereco:" +
                this.residencial.Imprimir();
        }
    }
}
