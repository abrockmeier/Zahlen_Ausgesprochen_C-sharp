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
			while (!ceingabe); 

			Console.WriteLine(ConvertToAusgesprochen(inteingabe, stellen));
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
			Console.WriteLine("Sie haben \"{0}\", eingegeben! Bitte eine Zahl" +
			" zwischen -2.147.483.648 und 2.147.483.647 eingeben", eingabe);
		}

		//VERARBEITUNG

		static string ConvertToAusgesprochen(int Zahl, int stellen)
		{
			if (Zahl == 11)
			{
				Console.WriteLine("Elf");
				return ("Elf");
			}
			else if (Zahl == 12)
			{
				Console.WriteLine("Zwölf");
				return ("Zwölf");
			}
			else if (Zahl == 13)
			{
				Console.WriteLine("Dreizehn");
				return ("Dreizehn");
			}
			else if (Zahl == 14)
			{
				Console.WriteLine("Vierzehn");
				return ("Vierzehn");
			}
			else if (Zahl == 15)
			{
				Console.WriteLine("Fünfzehn");
				return ("Fünfzehn");
			}
			else if (Zahl == 16)
			{
				Console.WriteLine("Sechzehn");
				return ("Sechzehn");
			}
			else if (Zahl == 17)
			{
				Console.WriteLine("Siebzehn");
				return ("Siebzehn");
			}
			else if (Zahl == 18)
			{
				Console.WriteLine("Achtzehn");
				return ("Achtzehn");
			}
			else if (Zahl == 19)
			{
				Console.WriteLine("Neunzehn");
				return ("Neunzehn");
			}
			else if (Zahl == 20)
			{
				Console.WriteLine("Zwanzig");
				return ("Zwanzig");
			}
			else if (Zahl == 30)
			{
				Console.WriteLine("Dreißig");
				return ("Dreißig");
			}
			else if (Zahl == 40)
			{
				Console.WriteLine("Vierzig");
				return ("Vierzig");
			}
			else if (Zahl == 50)
			{
				Console.WriteLine("Fünfzig");
				return ("Fünfzig");
			}
			else if (Zahl == 60)
			{
				Console.WriteLine("Sechzig");
				return ("Sechzig");
			}
			else if (Zahl == 70)
			{
				Console.WriteLine("Sechzig");
				return ("Sechzig");
			}
			else if (Zahl == 70)
			{
				Console.WriteLine("Siebzig");
				return ("Siebzig");
			}
			else if (Zahl == 80)
			{
				Console.WriteLine("Achtzig");
				return ("Achtzig");
			}
			else if (Zahl == 90)
			{
				Console.WriteLine("Neunzig");
				return ("Neunzig");
			}

			if (stellen == 1)
			{
				return (EinerStelle(Zahl, stellen));
			}
			else if (stellen == 2)
			{
				return (string.Concat(
				EinerStelle(Zahl, stellen),
				ZehnerStelle(Zahl, stellen)));
			}
			else if (stellen == 3)
			{
				return (string.Concat(
				HunderterStelle(Zahl, stellen),
				EinerStelle(Zahl, stellen),
				ZehnerStelle(Zahl, stellen)));
			}
			else if (stellen == 4)
			{
				return (string.Concat(
				TausenderStellen(Zahl, stellen),
				HunderterStelle(Zahl, stellen),
				EinerStelle(Zahl, stellen),
				ZehnerStelle(Zahl, stellen)));
			}
			else if (Zahl >= 10000) // stellen <= 2 &&
			{
				return ("Sie sind größenwahsinnig! Ihre Zahl hat: " + stellen + " Stellen...");
			}

			else
			{

				return ("else fall Negatives Vorzeichen?");
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
			string strZahl = Convert.ToString(Zahl);
			if (stellen == 1)
			{
				int Einer = strZahl[stellen - 1];
				if (Einer == 48) return ("Null");
				if (Einer == 49) return ("Eins");
				if (Einer == 50) return ("Zwei");
				if (Einer == 51) return ("Drei");
				if (Einer == 52) return ("Vier");
				if (Einer == 53) return ("Fünf");
				if (Einer == 54) return ("Sechs");
				if (Einer == 55) return ("Sieben");
				if (Einer == 56) return ("Acht");
				if (Einer == 57) return ("Neun");
				return ("Something went wrong @ EinerStelle... ");
			}
			if (stellen == 2)
			{
				int Einer = strZahl[stellen - 1];
				if (Einer == 48) return ("");
				if (Einer == 49) return ("Einund");
				if (Einer == 50) return ("Zweiund");
				if (Einer == 51) return ("Dreiund");
				if (Einer == 52) return ("Vierund");
				if (Einer == 53) return ("Fünfund");
				if (Einer == 54) return ("Sechsund");
				if (Einer == 55) return ("Siebenund");
				if (Einer == 56) return ("Achtund");
				if (Einer == 57) return ("Neunund");
				return ("Something went wrong @ Einerstelle (else)... ");
			}
			else
			{
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
				return ("Something went wrong @ Einerstelle (else)... ");
			}
			// Einerstelle bestimmen und String zurückgeben.
		}

		static string ZehnerStelle(int zehner, int stellen)
		{
			string strZahl = Convert.ToString(zehner);
			{
				if (stellen == 2)
				{
					int Zehner = Convert.ToInt32(strZahl[0]);
					
					return(IfZehner(Zehner));
				}
				if (stellen == 3)
				{
					int Zehner = Convert.ToInt32(strZahl[1]);
					return(IfZehner(Zehner));
				}
				if (stellen == 4)
				{
					int Zehner = Convert.ToInt32(strZahl[2]);
					return(IfZehner(Zehner));
				}
				return ("");
			}
		}

		static string HunderterStelle(int hunderter, int stellen)
		{
			string strZahl = Convert.ToString(hunderter);
			if (stellen == 3)
			{
				int Hunderter = Convert.ToInt32(strZahl[0]);
				if (Hunderter == 48) return ("");
				if (Hunderter == 49) return ("Einhundert");
				if (Hunderter == 50) return ("Zweihundert");
				if (Hunderter == 51) return ("Dreihundert");
				if (Hunderter == 52) return ("Vierhundert");
				if (Hunderter == 53) return ("Fünfhundert");
				if (Hunderter == 54) return ("Sechshundert");
				if (Hunderter == 55) return ("Siebenhundert");
				if (Hunderter == 56) return ("Achthundert");
				if (Hunderter == 57) return ("Neunhundert");
				return ("Something went wrong @ HunderterStelle... ");
			}
			if (stellen == 4)
			{
				int Hunderter = Convert.ToInt32(strZahl[1]);
				if (Hunderter == 48) return ("");
				if (Hunderter == 49) return ("einhundert");
				if (Hunderter == 50) return ("zweihundert");
				if (Hunderter == 51) return ("dreihundert");
				if (Hunderter == 52) return ("vierhundert");
				if (Hunderter == 53) return ("fünfhundert");
				if (Hunderter == 54) return ("sechshundert");
				if (Hunderter == 55) return ("siebenhundert");
				if (Hunderter == 56) return ("achthundert");
				if (Hunderter == 57) return ("neunhundert");
				return ("Something went wrong @ HunderterStelle... ");
			}
			return("");	
		}

		static string TausenderStellen(int tausender,int stellen)
		{
			string strZahl = Convert.ToString(tausender);
			if (stellen == 4)
			{
				int Tausender = Convert.ToInt32(strZahl[0]);
				if (Tausender == 48) return ("");
				if (Tausender == 49) return ("Tausend");
				if (Tausender == 50) return ("Zweitausend");
				if (Tausender == 51) return ("Dreitausend");
				if (Tausender == 52) return ("Viertausend");
				if (Tausender == 53) return ("Fünftausend");
				if (Tausender == 54) return ("Sechstausend");
				if (Tausender == 55) return ("Siebentausend");
				if (Tausender == 56) return ("Achttausend");
				if (Tausender == 57) return ("Neuntausend");
				return ("Something went wrong Tausender ;-)... ");
			}
			return("");
		}

		static string IfZehner(int Zehner)
		{
			if (Zehner == 48) return ("");
			if (Zehner == 49) return ("zZzehn");
			if (Zehner == 50) return ("zwanzig");
			if (Zehner == 51) return ("dreißig");
			if (Zehner == 52) return ("vierzig");
			if (Zehner == 53) return ("fünfzig");
			if (Zehner == 54) return ("sechzig");
			if (Zehner == 55) return ("siebzig");
			if (Zehner == 56) return ("achtzig");
			if (Zehner == 57) return ("neunzig");
			return ("Something went wrong @ IfZehner... ");
		}


		// AUSGABE	(Erfolgt bisher über die Programmlogik)
		/*
		static void Ausgabe()
		{


		}
		*/

	}
}


