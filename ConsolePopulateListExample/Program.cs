using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePopulateListExample
{
	class Program
	{
		static void Main(string[] args)
		{
			PreencherAlunos preencherAlunos = new PreencherAlunos();
			List<Aluno> Alunos = preencherAlunos.Alunos;

			foreach(var aux in Alunos)
			{
				Console.WriteLine("Nome: {0}, Idade: {1}", aux.Nome, aux.Idade);
			}

			Console.Read();
		}

		public class Aluno
		{
			public string Nome { get; set; }
			public int Idade { get; set; }
		}

		public class PreencherAlunos
		{
			public List<Aluno> Alunos = new List<Aluno>();

			public PreencherAlunos()
			{
				Alunos.Add(new Aluno { Nome = "Eduardo Santos", Idade = 15 });
				Alunos.Add(new Aluno { Nome = "Antonio Amaro", Idade = 16 });
				Alunos.Add(new Aluno { Nome = "Arnaldo Sacommani", Idade = 12 });
				Alunos.Add(new Aluno { Nome = "Bruno Alves", Idade = 15 });

				Alunos.Sort(delegate (Aluno Nome1, Aluno Nome2)
				{
					return Nome1.Nome.CompareTo(Nome2.Nome);
				});
			}
		}

	}
}
