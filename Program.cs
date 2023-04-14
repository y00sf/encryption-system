using System;

public class Program
{
	public static void Main()
	{

		Console.WriteLine("1 to encryption, 2 to unencryption");
		string choosse = Console.ReadLine();
		int choose = int.Parse(choosse);



		if (choose == 1)
		{
			//in
			Console.WriteLine("write the text:");
			string text = Console.ReadLine();
			byte asci = 85;
			int pass = 85;
			string ttext = string.Empty;
			string fin = ttext;

			//------------------------------------


			//------------------------------------
			foreach (char c in text)
			{
				asci = (byte)c;

				int a = pass ^ asci;
				string ao = Convert.ToString(a, 2);
				string binary = Convert.ToString(asci, 2);
				string passo = Convert.ToString(pass, 2);
				char tcyph = (char)a;

				//------------------------------------

				Console.WriteLine();
				Console.WriteLine("المرسل:");
				Console.WriteLine("enter         " + c);
				Console.WriteLine("ascii         " + asci);
				Console.WriteLine("binary        " + binary);
				Console.WriteLine("cyph-binary   " + ao);
				Console.WriteLine("cyph-ascii    " + tcyph);

				//------------------------------------

				ttext = tcyph.ToString();
				fin = fin + ttext;
			}

			//------------------------------------

			Console.WriteLine();
			Console.WriteLine("cyph end :" + fin);
			Console.WriteLine();


			Console.WriteLine("2 to unencryption, 3 to main menu");
			choosse = Console.ReadLine();
			choose = int.Parse(choosse);

			if (choose == 3)
			{
				Main();
			}

		}
		if (choose == 2)
		{

			//out
			string theEnter = string.Empty;
			int tpass = 85;

			string tuncyphF = string.Empty;
			string tuncyph = tuncyphF;


			//------------------------------------

			Console.WriteLine("Type the ciphertext:");
			theEnter = Console.ReadLine();
			foreach (char y in theEnter)
			{
				Console.WriteLine();
				Console.WriteLine("المستقبل:");

				int b = y ^ tpass;

				int asci2 = Convert.ToByte(b);
				string end = asci2.ToString();
				string binary2 = Convert.ToString(b, 2);

				char charAsci2 = (char)asci2;
				//------------------------------------

				Console.WriteLine("cyph-ascii     " + y);
				Console.WriteLine("binary-uncyph  " + binary2);
				Console.WriteLine("asci           " + asci2);
				Console.WriteLine("end            " + charAsci2);

				//------------------------------------

				tuncyphF = charAsci2.ToString();
				tuncyph = tuncyph + charAsci2;
			}


			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("uncyph end " + tuncyph);



			Console.WriteLine("1 to main menu");
			choosse = Console.ReadLine();
			choose = int.Parse(choosse);

			if (choose == 1)
			{
				Main();
			}

		}


	}
}