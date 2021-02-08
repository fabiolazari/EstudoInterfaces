using EstudoInterfaces.Entidade;
using EstudoInterfaces.Estrutura.Interface;
using System;

namespace EstudoInterfaces.Service
{
	public class ContratoCLTService : IContrato
	{
		public bool DesligamentoContrato(Contrato contrato)
		{
			Console.WriteLine("Desligamento Funcionário CLT...");
			return true;
		}

		public bool EfetivacaoContrato(Contrato contrato)
		{
			Console.WriteLine("Admissão Funcionário CLT...");
			return true;
		}

		public bool LicencaContrato(Contrato contrato)
		{
			Console.WriteLine("Afastamento Funcionário CLT...");
			return true;
		}

		public bool RecessoContrato(Contrato contrato)
		{
			Console.WriteLine("Férias Funcionário CLT...");
			return true;
		}

		public bool SuspensaoContrato(Contrato contrato)
		{
			Console.WriteLine("Suspensão Contrato CLT Funcionário...");
			return true;
		}
	}
}
