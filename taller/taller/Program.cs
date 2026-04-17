// Luben
using System;
using System.IO;

namespace taller
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("========taller 2do B==========!");
			
			//directorio
			
			
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOSIUJO");
			string RutaReportes = Path.Combine(rutaRaiz, "REPORTES");
			if(!Directory.Exists(RutaReportes))
			{
				Directory.CreateDirectory(RutaReportes);
				Console.WriteLine("creado correctamente el directorio");
			}
			Console.WriteLine(rutaRaiz);
			
			Console.WriteLine(RutaReportes);
			
			if (!Directory.Exists(RutaReportes))
                {
	                Directory.CreateDirectory(RutaReportes);
                    Console.WriteLine("\n[OK] Directorios creados correctamente.");
                }
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}