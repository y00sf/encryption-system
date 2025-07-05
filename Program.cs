using System;

public class Program
{
	public static void Main()
	{

		Console.WriteLine("1 to Encrypt, 2 to Decrypt");
		string choosse = Console.ReadLine();
		int choose = int.Parse(choosse);



		if (choose == 1)
		{
			//in
			Console.WriteLine("Enter the text:");
			string text = Console.ReadLine();
			byte asci = 85;
			int pass = 85;
			string ttext = string.Empty;
			string fin = ttext;


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
				Console.WriteLine("The letters: " + c);
				Console.WriteLine("ASCII: " + asci);
				Console.WriteLine("Binary: " + binary);
				Console.WriteLine("Encrypted binary: " + ao);
				Console.WriteLine("Encrypted ASCII:" + tcyph);


				ttext = tcyph.ToString();
				fin = fin + ttext;
			}


			Console.WriteLine();
			Console.WriteLine("Encryption result :" + fin);
			Console.WriteLine();


			Console.WriteLine("2 to Decrypt, 3 to main menu");
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



			Console.WriteLine("Type the encrypted text:");
			theEnter = Console.ReadLine();
			foreach (char y in theEnter)
			{
				Console.WriteLine();

				int b = y ^ tpass;

				int asci2 = Convert.ToByte(b);
				string end = asci2.ToString();
				string binary2 = Convert.ToString(b, 2);

				char charAsci2 = (char)asci2;

				Console.WriteLine("Encrypted- ASCII: " + y);
				Console.WriteLine("Encrypted binary: " + binary2);
				Console.WriteLine("ASCII: " + asci2);
				Console.WriteLine("Result: " + charAsci2);

				tuncyphF = charAsci2.ToString();
				tuncyph = tuncyph + charAsci2;
			}


			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Decryption result " + tuncyph);



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
