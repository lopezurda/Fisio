using System;
using NUnit.Framework;
using Web.Helper;
using NUnit.Core;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class TestUtilidad
	{
		[Test]
		public void TestParseoFecha ()
		{
			string fecha="17/01/1975";
			DateTime fechaParseada=Utilidad.ParsearFecha(fecha);
			Console.WriteLine("Fecha Parseada: "+fechaParseada.ToString());
		}
	}
}

