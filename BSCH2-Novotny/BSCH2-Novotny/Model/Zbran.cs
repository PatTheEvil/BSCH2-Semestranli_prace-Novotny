using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSCH2_Novotny.Model
{
	public class Zbran
	{
		public int? Id { get; set; }
		public string Nazev { get; set; }
		public Vojak Vojak { get; set; }
		public Typ_zbrane Typ { get; set; }
		public Munice Munice { get; set; }
	}
}
