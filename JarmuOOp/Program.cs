using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuOOp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Robogo robi = new Robogo(50, 25, "XZY - 531");
            Console.WriteLine(robi);
            Console.WriteLine("Haladhat itt? " + (robi.HaladhatItt(45)?"Igen": "Nem"));
			Console.WriteLine("Gyorsanhajt? " + (robi.GyorshajtottE(130) ? "Igen." : "Nem."));
			AudiS8 audi = new AudiS8(true,220,"F4ST-ASF");
            Console.WriteLine(audi);
            Console.WriteLine("Gyorsanhajt? "+(audi.GyorshajtottE(130)? "Igen.":"Nem."));



            Console.ReadKey();
        }
	}
}
