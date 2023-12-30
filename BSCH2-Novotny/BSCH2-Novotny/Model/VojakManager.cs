using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSCH2_Novotny.Database;

namespace BSCH2_Novotny.Model
{
	class VojakManager
	{
		public static ObservableCollection<Vojak> vojaci = new ObservableCollection<Vojak>();

		public static ObservableCollection<Vojak> GetVojaci()
		{
			vojaci.Clear();
			vojaci = SqliteDataAccess.LoadVojaci();
			return vojaci;
		}

		public static void AddVojak(Vojak vojak)
		{
			SqliteDataAccess.SaveVojak(vojak);
		}

		public static void EditVojak(Vojak newVojak)
		{
			SqliteDataAccess.UpdateVojak(newVojak);
		}

		public static void DeleteById(int? id)
		{
			SqliteDataAccess.DeleteVojakById((int)id);
		}

		public static void DeleteAll()
		{
			SqliteDataAccess.DeleteAllVojaci();
		}

		public static Vojak GetById(int id)
		{
			foreach (Vojak vojak in vojaci)
			{
				if (vojak.Id == id) return vojak;
			}
			return null;
		}

	}
}
