using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSCH2_Novotny.Model
{
	public class Vojak
	{
		public Vojak() { }

		public int? Id { get; set; }
		public string Jmeno { get; set; }
		public string Prijmeni { get; set; }
		public DateOnly Narozeni { get; set; }


	}
}
