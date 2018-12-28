using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlen_Ausgesprochen_C_sharp
{
	class Program
	{
		//MAIN... incl EINGABE und Programmablauf
		static void Main(string[] args)
		{
			bool loopbreak = false;
			int inteingabe;

			Console.Write("Bitte eine Zahl eingeben:");
			string eingabe = Console.ReadLine();
			bool ceingabe = Int32.TryParse(eingabe, out (inteingabe));
			


			while (!ceingabe) //ToDo: in Methode packen 
			{
				Console.WriteLine("Sie haben {0}, eingegeben! Bitte eine Zahl" +
				" zwischen -2.147.483.648 und 2.147.483.647 eingeben", eingabe);
				eingabe = Console.ReadLine();
				ceingabe = Int32.TryParse(eingabe, out (inteingabe));
			}

			int stellen = anZahlen(inteingabe);
			Console.WriteLine(ConvertToAusgesprochen(inteingabe,stellen));


			while (!loopbreak)
			{ 
				Console.WriteLine("Wenn sie noch eine weitere Zahl eingeben möchten," +
				" bitte drücken sie: 'j' ");
				Console.WriteLine("Jede andere Taste beendet das Programm!");
				ConsoleKeyInfo caseInput = Console.ReadKey(true);
				switch (caseInput.Key)
				{
					case ConsoleKey.J:
						Console.Write("Bitte eine Zahl eingeben:");
						eingabe = Console.ReadLine();
						ceingabe = Int32.TryParse(eingabe, out (inteingabe));
						stellen = anZahlen(inteingabe);
						Console.WriteLine(ConvertToAusgesprochen(inteingabe,stellen));
						break;
					default:
						loopbreak = true;
						break;
				}

			}

			// Console.WriteLine(hunderter + "und" + einer + zehner, hunderter
			// , einer, zehner);
		}

		//VERARBEITUNG

		static string ConvertToAusgesprochen(int Zahl, int stellen)
		{
			if (Zahl == 0)
			{
				Console.WriteLine("Null ( nicht NULL! )");
				return ("Null !NULL");

			}
			else if (stellen == 1)
			{
				// pos INT
				return("1-9");
				
			}
			else if (stellen == 2)
			{
				// pos INT
				return("10-99");
				
			}
			else if (stellen == 3)
			{
				// pos INT
				return("100-999");
				
			}
			else if (stellen == 4)
			{
				// pos INT
				return("1000-9999");
				
			}
			else if (Zahl > 10000) // stellen <= 2 &&
			{
				// pos INT
				return("Sie sind größenwahsinnig! Ihre Zahl hat: "+stellen + " Stellen...");
				
			}
			
			else
			{
				
				return("else fall");
			}
		}
		

		static int anZahlen(int n)
		{
			if (n < 0)
			{
			n = (n == Int32.MinValue) ? Int32.MaxValue : -n;
			}
			if (n < 10) return 1;
			if (n < 100) return 2;
			if (n < 1000) return 3;
			if (n < 10000) return 4;
			if (n < 100000) return 5;
			if (n < 1000000) return 6;
			if (n < 10000000) return 7;
			if (n < 100000000) return 8;
			if (n < 1000000000) return 9;
			else return 10;
		}

		static string einerStelle(int einer)
		{
			return ("einer");
		// Einerstelle bestimmen und String zurückgeben.
		}

		static string zehnerStelle(int zehner)
		{
			return ("Zehner");
		// Einerstelle bestimmen und String zurückgeben.
		}

		static string hunderterStelle()
		{
			return ("hunderter");
		}

		static string tausenderStellen()
		{
			return ("tausender");
		}
		
		// AUSGABE


		static void Ausgabe()
		{


		}
	}
}


