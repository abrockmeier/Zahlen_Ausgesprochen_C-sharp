using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlen_Ausgesprochen_C_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.Write("Bitte eine Zahl eingeben:");
			// Eingabe();
			int eingabe = Convert.ToInt32(Console.ReadLine());
			CZahl zahl = new CZahl(eingabe);
			zahl.I =  eingabe;

			// Console.WriteLine(hunderter + "und" + einer + zehner, hunderter, einer, zehner);
		}

		
	}
}
