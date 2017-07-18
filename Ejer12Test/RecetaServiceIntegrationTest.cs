using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejer12;

namespace Ejer12Test
{
	[TestClass]
	public class RecetaServiceIntegrationTest
	{
		[TestMethod]
		public void TestCreate()
		{
			IUnityContainer container = new UnityContainer();
			container.RegisterType<IRecetaService, RecetaService>();
			container.RegisterType<IRecetaRepository, RecetaRepository>();

			IRecetaService sut = container.Resolve<IRecetaService>();

			Receta receta = new Receta();
			receta.Nombre = "Arroz Negro";

			receta.Peso = 100;

			Receta resultado = sut.Create(receta);

			Assert.AreEqual(2 * 100.0, resultado.Peso);
		}
	}
}
