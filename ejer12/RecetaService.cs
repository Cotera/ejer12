using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
	public class RecetaService : IRecetaService
	{
		private IRecetaRepository recetaRepository;

		public RecetaService(IRecetaRepository _recetaRepository)
		{
			this.recetaRepository = _recetaRepository;
		}

		public double Create(Receta receta)
		{
			receta.Peso *= 2;
			return receta.Peso;
			
		}

	}
}
