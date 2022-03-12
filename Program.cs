using System;

namespace modul3_1302204090
{
	internal class Program
	{
		static void Main(string[] args)
		{
			KodeBuah buah = KodeBuah.GetKodeBuah("C000");

			Console.WriteLine(buah.GetBuah() + " dengan kode " + buah.GetKode());
		}
	}
}
