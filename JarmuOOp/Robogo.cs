using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuOOp
{
	internal class Robogo : Jarmu, KisGepjarmu
	{
		private int maxSebesseg;

		public Robogo(int maxSebesseg, int aktSebesseg, string rendszam): base(aktSebesseg, rendszam)
		{
			this.maxSebesseg = maxSebesseg;
			this.aktSebesseg = aktSebesseg;
			this.rendszam = rendszam;
		}

		public override bool GyorshajtottE(int sebessegkorlat)
		{
			return this.aktSebesseg > sebessegkorlat;
		}

		public bool HaladhatE(int sebesseg)
		{
			throw new NotImplementedException();
		}

		public bool HaladhatItt(int sebesseg)
		{
			return this.maxSebesseg > this.aktSebesseg;
		}

		public override string ToString()
		{
			return "Robogó: " + base.ToString();
		}

	}

}
