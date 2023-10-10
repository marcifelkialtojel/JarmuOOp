using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuOOp
{
	internal abstract class Jarmu
	{
		protected int aktSebesseg;
		protected string rendszam;

		protected Jarmu(int aktSebesseg, string rendszam)
		{
			this.aktSebesseg = aktSebesseg;
			this.rendszam = rendszam;
		}

		public abstract bool GyorshajtottE(int sebessegkorlat);

		public override string ToString()
		{
			return $"{this.rendszam} - {this.aktSebesseg} km/h";
		}
	}
}
