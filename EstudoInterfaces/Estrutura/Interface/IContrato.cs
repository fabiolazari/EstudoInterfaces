using EstudoInterfaces.Entidade;

namespace EstudoInterfaces.Estrutura.Interface
{
	public interface IContrato
	{
		bool EfetivacaoContrato(Contrato contrato);

		bool LicencaContrato(Contrato contrato);

		bool SuspensaoContrato(Contrato contrato);

		bool RecessoContrato(Contrato contrato);

		bool DesligamentoContrato(Contrato contrato);
	}
}
