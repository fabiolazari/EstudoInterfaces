using EstudoInterfaces.Entidade;
using EstudoInterfaces.Estrutura.Enum;
using EstudoInterfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudoInterfaces
{
	public class Program
	{
		static int Main(string[] args)
		{
			Contrato contratoCLT = new Contrato(TipoContrato.CLT);
			ContratoCLTService contratoCLtService = new ContratoCLTService();
			contratoCLtService.EfetivacaoContrato(contratoCLT);

			Console.WriteLine();

			Contrato contratoPJ = new Contrato(TipoContrato.PJ);
			ContratoPJService contratoPJService = new ContratoPJService();
			contratoPJService.EfetivacaoContrato(contratoPJ);

			Console.WriteLine();

			Contrato contratoMenor = new Contrato(TipoContrato.CLT);
			ContratoMenorAprendizService contratoMenorService = new ContratoMenorAprendizService();
			contratoMenorService.EfetivacaoContrato(contratoMenor);

			Console.ReadLine();

		}
	}
}
