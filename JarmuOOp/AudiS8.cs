using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuOOp
{
	internal class AudiS8 : Jarmu
	{
		private bool lezerblokkolo;

		public AudiS8(bool v, int aktSebesseg, string rendszam) : base(aktSebesseg, rendszam)
		{
			this.lezerblokkolo = lezerblokkolo;
		}

		public override bool GyorshajtottE(int sebessegkorlat)
		{
			if (this.aktSebesseg > sebessegkorlat && !this.lezerblokkolo)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
