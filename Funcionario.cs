using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}
	class Funcionario
	{
		public string nome, RG;

		public void Funcionario(string nome, string rg)
		{
			this.nome = nome;
			this.RG = rg;
		}
		public string Nome
		{
			get
			{
				return ano;
			}
			set
			{
				nome = value;
			}
		}
		public string Rg
		{
			get
			{
				return RG;
			}
			set
			{
				RG = value;
			}
		}
	}

	class Vendedor : Funcionario
	{
		private double salario;
		private int comissaoMes;
		private boolean vendas;

		public Vendedor (string nome, string rg, double sal) : base(nome, rg)
		{
			this.salario = sal;
		}
		
		public double Salario
		{
			get
			{
				return salario;
			}
			set
			{
				salario = value;
			}
		}
		public void Vendas()
		{
			vendas = true;
		}
		public void totalVendas()
		{
			if(vendas != false)
			{
				comissaoMes++;
			}
		}
		public void Zera()
		{
			comissaoMes = 0;
		}
		public double Imprimi()
		{
			return salario = salario + (comissaoMes*0.05);
			Zera();
		}

	}

}
