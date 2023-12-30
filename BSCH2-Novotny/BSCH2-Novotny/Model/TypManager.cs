using BSCH2_Novotny.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSCH2_Novotny.Model
{
	class TypManager
	{

		public static ObservableCollection<Typ_zbrane> typy = new ObservableCollection<Typ_zbrane>();

		public static ObservableCollection<Typ_zbrane> GetTypy()
		{
			typy.Clear();
			typy = SqliteDataAccess.LoadTypy();
			return typy;
		}

		public static void AddTyp(Typ_zbrane typ)
		{
			SqliteDataAccess.SaveTyp(typ);
		}

		public static void EditTyp(Typ_zbrane typ)
		{
			SqliteDataAccess.UpdateTyp(typ);
		}

		public static void DeleteById(int? id)
		{
			SqliteDataAccess.DeleteTypById((int)id);
		}

		public static void DeleteAll()
		{
			SqliteDataAccess.DeleteAllTypy();
		}

		public static Typ_zbrane GetById(int id)
		{
			foreach (Typ_zbrane typ in typy)
			{
				if (typ.Id == id) return typ;
			}
			return null;
		}
	}
}
