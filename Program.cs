using System;

namespace modul3_1302204090
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Demo kode buah
			KodeBuah buah = KodeBuah.GetKodeBuah("C000");
			Console.WriteLine(buah.GetBuah() + " dengan kode " + buah.GetKode());

			Console.WriteLine(" ");

			// Demo posisi karakter
			PosisiKarakterGame posisiKarakter = new PosisiKarakterGame();
			posisiKarakter.TekanW();
			posisiKarakter.TekanX();
			posisiKarakter.TekanS();
			posisiKarakter.TekanW();
			posisiKarakter.TekanW();
		}
	}
}
