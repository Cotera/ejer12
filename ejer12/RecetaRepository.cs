using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
	public class RecetaRepository : IRecetaRepository
	{
		public Receta Create(Receta receta)
		{
			receta.Peso *= 2;
			return receta;
		}
	}
}
