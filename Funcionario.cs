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
			Funcionario f1 = new Funcionario ("Igor","1234567-8");
			Funcionario v1 = new Vendedor ("Thor","xxxxxxx-x",1000);
			Funcionario a1 = new Administrador ("Thor","xxxxxxx-x",1000);

			v1.Vendas();
			v1.totalVendas();
			v1.Vendas();
			v1.totalVendas();
			v1.Vendas();
			v1.totalVendas();
			v1.Imprimi();

			a1.horasExtra();
			a1.totalHoraExtra();
			a1.horasExtra();
			a1.totalHoraExtra();
			a1.horasExtra();
			a1.totalHoraExtra();
			a1.Imprimi();
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

 	class Administrador : Funcionario
 	{
 		private double salario;
 		private int horaExtra;
 		private boolean extra;

 		public Administrador (string nome, string rg, double sal) : base(nome, rg)
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
 		public void horasExtra()
 		{
 			extra = true;
 		}
 		public void totalHoraExtra()
 		{
 			if(extra != false)
 			{
 				horaExtra++;
 			}
 		}
 		public void Zera()
 		{
 			horaExtra = 0;
 		}
 		public double Imprimi()
 		{
 			return salario = (salario/100) * horaExtra ;
 			Zera();
		}
 	}
}
