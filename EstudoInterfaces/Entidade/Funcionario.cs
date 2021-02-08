
namespace EstudoInterfaces.Entidade
{
	public class Funcionario
	{
		private int _id;
		private int _nome;
		private int _cpf;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public int Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		public int CPF
		{
			get { return _cpf; }
			set { _cpf = value; }
		}

		public Funcionario()
		{
		}

		public Funcionario(int id, int nome, int cPF)
		{
			Id = id;
			Nome = nome;
			CPF = cPF;
		}
	}
}
