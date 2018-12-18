using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlen_Ausgesprochen_C_sharp
{
	class CZahl
	{
		int i;
		//private int eingabe;
		private readonly string hunderter, einer, zehner;

		public int I { get => i; set => i = value; }

		public CZahl (int i)
		{
		//return;
		}
		//public int Eingabe { get => eingabe; set => eingabe = value; }

		/*private static void Eingabe()
		{
			
		}
		*/


		private string Spell(int I) // kann auch direkt umwandeln...
		{
			
			return "empty";
		}
		/*private void Eingabe(int eingabe)
		{
		Convert.ToInt32(Console.ReadLine());
		}
		*/
	}
}
