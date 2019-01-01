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
			
			Eingabe();

			WeitereEingabe();

		}


		// EINGABE
		static void Eingabe() // TODO ---> eine Aufgabe je Methode... ;-)
		{
			// bool ersteingabe = true;
			bool ceingabe;
			int inteingabe;
			int stellen;
			string eingabe;

			//if (ersteingabe)
			//{
				do
				{
					Console.Write("Bitte eine Zahl eingeben:");
					eingabe = Console.ReadLine();
					ceingabe = Int32.TryParse(eingabe, out (inteingabe));
					stellen = anZahlen(inteingabe);
					//		return(1);
					if (!ceingabe)
					{
						FalscheEingabe(eingabe);
					}
				}
				while (!ceingabe); //ToDo: ?
				// ersteingabe = false;
				Console.WriteLine(ConvertToAusgesprochen(inteingabe, stellen));
			//}

			
		}
		

		static void WeitereEingabe()
		{
			bool loopbreak = false;
			while (!loopbreak)
			{
				Console.WriteLine("Wenn sie noch eine weitere Zahl eingeben möchten," +
				" bitte drücken sie: 'j' ");
				Console.WriteLine("Jede andere Taste beendet das Programm!");
				ConsoleKeyInfo caseInput = Console.ReadKey(true);

				switch (caseInput.Key)
				{
					case ConsoleKey.J:
						
						Eingabe();
						break;
					default:
						loopbreak = true;
						//return (0);
						break;
				}
			}
		}

		static void FalscheEingabe(string eingabe)
		{
			Console.WriteLine("Sie haben {0}, eingegeben! Bitte eine Zahl" +
			" zwischen -2.147.483.648 und 2.147.483.647 eingeben", eingabe);
		}

		//VERARBEITUNG

		static string ConvertToAusgesprochen(int Zahl, int stellen)
		{
			if (Zahl == 0)
			{
				Console.WriteLine("Null ( nicht NULL! )");
				return ("Null !NULL");

			}
			else if (Zahl == 11)
			{
				Console.WriteLine("ölf");
				return ("Elf");
			}
			else if (Zahl == 12)
			{
				Console.WriteLine("zwölf");
				return ("Zwölf");
			}
			else if (Zahl == 13)
			{
				Console.WriteLine("dreizehn");
				return ("dreizehn");
			}
			else if (Zahl == 14)
			{
				Console.WriteLine("vierzehn");
				return ("vierzehn");
			}
			else if (Zahl == 15)
			{
				Console.WriteLine("ünf10");
				return ("unf10");
			}
			else if (Zahl == 16)
			{
				Console.WriteLine("6zehn");
				return ("6zehn");
			}
			else if (Zahl == 17)
			{
				Console.WriteLine("7zehn");
				return ("7zehn");
			}
			else if (Zahl == 18)
			{
				Console.WriteLine("8zehn");
				return ("8zehn");
			}
			else if (Zahl == 19)
			{
				Console.WriteLine("neunzehn");
				return ("neunzehn");
			}

			else if (stellen == 1)
			{
				return (EinerStelle(Zahl, stellen));
			}
			else if (stellen == 2)
			{
				return (string.Concat(string.Concat(string.Concat(EinerStelle(Zahl, stellen),
				ZehnerStelle(Zahl), " = (" + Zahl + ")"))));
			}
			else if (stellen == 3)
			{

				return ("100-999");

			}
			else if (stellen == 4)
			{
				// pos INT
				return ("1000-9999");

			}
			else if (Zahl > 10000) // stellen <= 2 &&
			{
				// pos INT
				return ("Sie sind größenwahsinnig! Ihre Zahl hat: " + stellen + " Stellen...");

			}

			else
			{

				return ("else fall");
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

		static string EinerStelle(int Zahl, int stellen)
		{
			if (stellen == 1)
			{
				string strZahl = Convert.ToString(Zahl);
				int Einer = strZahl[stellen - 1];
				if (Einer == 48) return ("null");
				if (Einer == 49) return ("eins");
				if (Einer == 50) return ("zwei");
				if (Einer == 51) return ("drei");
				if (Einer == 52) return ("vier");
				if (Einer == 53) return ("fünf");
				if (Einer == 54) return ("sechs");
				if (Einer == 55) return ("sieben");
				if (Einer == 56) return ("acht");
				if (Einer == 57) return ("neun");
				return ("Something went wrong EinerStelle if ;-)... ");
			}
			else
			{
				string strZahl = Convert.ToString(Zahl);
				int Einer = strZahl[stellen - 1];
				if (Einer == 48) return ("");
				if (Einer == 49) return ("einund");
				if (Einer == 50) return ("zweiund");
				if (Einer == 51) return ("dreiund");
				if (Einer == 52) return ("vierund");
				if (Einer == 53) return ("fünfund");
				if (Einer == 54) return ("sechsund");
				if (Einer == 55) return ("siebenund");
				if (Einer == 56) return ("achtund");
				if (Einer == 57) return ("neunund");
				return ("Something went wrong EinerStelle else ;-)... ");
			}
			// Einerstelle bestimmen und String zurückgeben.
		}

		static string ZehnerStelle(int zehner)
		{
			string strZahl = Convert.ToString(zehner);
			int Zehner = Convert.ToInt32(strZahl[0]);
			if (Zehner == 48) return ("");
			if (Zehner == 49) return ("zehn?");
			if (Zehner == 50) return ("zwanzig");
			if (Zehner == 51) return ("dreißig");
			if (Zehner == 52) return ("vierzig");
			if (Zehner == 53) return ("fünfzig");
			if (Zehner == 54) return ("sechzig");
			if (Zehner == 55) return ("siebzig");
			if (Zehner == 56) return ("achtzig");
			if (Zehner == 57) return ("neunzig");
			return ("Something went wrong ZehnerStelle ;-)... ");
		}

		static string HunderterStelle(int hunderter)
		{
			return ("hunderter");
		}

		static string TausenderStellen(int tausender)
		{
			return ("tausender");
		}

		



		// AUSGABE	(Erfolgt bisher über die Programmlogik)
		/*
		static void Ausgabe()
		{


		}
		*/

	}
}


