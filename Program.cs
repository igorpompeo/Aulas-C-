using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new Conta(1, "Fulano");
            Conta ccExp = new Especial(2, "Cicrano",300);

            cc.Depositar(200);
            cc.Sacar(300);
            Console.WriteLine(cc);

            ccExp.Depositar(200);
            ccExp.Sacar(300);
            Console.WriteLine(ccExp);

            Console.ReadKey();

        }
    }

    class Conta
    {
        public int Numero { set; get; }
        public string Nome { set; get; }
        public DateTime DataAbert { protected set; get; }
        public double Saldo { protected set; get; }

        public Conta(int num, string nome)
        {
            this.Numero = num;
            this.Nome = nome;
            this.DataAbert = DateTime.Now;
            this.Saldo = 0;
        }

        public void Depositar(double valor)
        {
            this.Saldo = this.Saldo + valor;
        }

        public virtual Boolean  Sacar(double valor)
        {
            if (valor > this.Saldo)
                return false;

            this.Saldo = this.Saldo - valor;

            return true;
        }

        public override string ToString()
        {
            return this.Numero + " " + this.Nome + "(" + this.DataAbert.ToShortDateString() + ")"  
                + " - " + this.Saldo;
        }
    }

    class Especial : Conta
    {
        private double limite;

        public Especial (int num, string nome, double lim)
            : base(num, nome)
        {
            this.limite = lim;
        }

        public override bool Sacar(double valor)
        {
            if (valor > (this.Saldo + this.limite))
                return false;

            this.Saldo = this.Saldo - valor;
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + "limite " + this.limite;
        }
    }

}
