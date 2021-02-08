using EstudoInterfaces.Entidade;
using EstudoInterfaces.Estrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoInterfaces.Service
{
	public class ContratoMenorAprendizService : IContrato
	{
		public bool DesligamentoContrato(Contrato contrato)
		{
			Console.WriteLine("Encerramento Contrato Menor Aprendiz...");
			return true;
		}

		public bool EfetivacaoContrato(Contrato contrato)
		{
			Console.WriteLine("Admissão Menor Aprendiz...");
			return true;
		}

		public bool LicencaContrato(Contrato contrato)
		{
			Console.WriteLine("Afastamento Menor Aprendiz...");
			return true;
		}

		public bool RecessoContrato(Contrato contrato)
		{
			Console.WriteLine("Férias Menor Aprendiz...");
			return true;
		}

		public bool SuspensaoContrato(Contrato contrato)
		{
			Console.WriteLine("Suspensão Contrato Menor Aprendiz...");
			return true;
		}
	}
}
