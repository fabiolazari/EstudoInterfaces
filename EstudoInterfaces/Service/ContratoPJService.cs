using EstudoInterfaces.Entidade;
using EstudoInterfaces.Estrutura.Interface;
using System;

namespace EstudoInterfaces.Service
{
	public class ContratoPJService : IContrato
	{
		public bool DesligamentoContrato(Contrato contrato)
		{
			Console.WriteLine("Encerramento Contrato Funcionário PJ...");
			return true;
		}

		public bool EfetivacaoContrato(Contrato contrato)
		{
			Console.WriteLine("Contratação Funcionário PJ...");
			return true;
		}

		public bool LicencaContrato(Contrato contrato)
		{
			Console.WriteLine("Afastamento Funcionário PJ...");
			return true;
		}

		public bool RecessoContrato(Contrato contrato)
		{
			Console.WriteLine("Recesso Funcionário PJ...");
			return true;
		}

		public bool SuspensaoContrato(Contrato contrato)
		{
			Console.WriteLine("Suspensão Contrato Funcionário PJ...");
			return true;
		}
	}
}
