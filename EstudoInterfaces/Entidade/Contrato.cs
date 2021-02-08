using EstudoInterfaces.Estrutura.Enum;

namespace EstudoInterfaces.Entidade
{
	public class Contrato
	{
		public int Id { get; set; }
		public long Matricula { get; set; }
		public string Descricao { get; set; }
		public TipoPessoa TipoPessoa { get; set; }
		public TipoContrato TipoContrato { get; set; }
		public Funcionario Funcionario { get; set; }

		public Contrato(TipoContrato tipoContrato)
		{
			TipoContrato = tipoContrato;
			Funcionario = new Funcionario();
		}

		public Contrato(int id, long matricula, string descricao, Funcionario funcionario, TipoPessoa tipoPessoa)
		{
			Id = id;
			Matricula = matricula;
			Descricao = descricao;
			Funcionario = funcionario;
			TipoPessoa = tipoPessoa;
		}
	}
}
