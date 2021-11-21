using System;

namespace Part_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zahl1, zahl2, summe, differenz, produkt, quotient, modulo;
			summe = 0;
			differenz = 0;
			produkt = 0;
			quotient = 0;
			modulo = 0;

			Console.Write("Bitte die erste Zahl eintragen: ");
			zahl1 = Convert.ToInt32 (Console.ReadLine() );
			
			Console.Write("Bitte die zweite Zahl eintragen: ");
			zahl2 = Convert.ToInt32 (Console.ReadLine() );
			
			Console.WriteLine("Bitte waehlen die gewuenschte Rechenoperation eintragen. (+,-,*,/)");
			char mathe;
			mathe = Convert.ToChar(Console.ReadLine());
			
			switch(mathe)
			{
				case '+':
					summe = zahl1 + zahl2;
					Console.WriteLine("Die Summe der zwei Zahlen lautet: {0} ", summe);
					break;
				case '-':
					differenz = zahl1 - zahl2;
					Console.WriteLine("Die Differenz der zwei Zahlen lautet: {0} ", differenz);
					break;
				case '*': 
					produkt = zahl1 * zahl2;
					Console.WriteLine("Das Produkt der zwei Zahlen lautet: {0} ", produkt);
					break;
				case '/':
					quotient = zahl1 / zahl2;
					modulo = zahl1 % zahl2;
					Console.WriteLine("Der Quotient der zwei Zahlen lautet: {0} Rest {1}", quotient, modulo);
					break;		
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
