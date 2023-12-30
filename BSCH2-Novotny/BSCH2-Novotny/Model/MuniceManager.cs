using BSCH2_Novotny.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSCH2_Novotny.Model
{
	class MuniceManager
	{
		public static ObservableCollection<Munice> munice = new ObservableCollection<Munice>();


		public static ObservableCollection<Munice> GetMunice()
		{
			munice.Clear();
			munice = SqliteDataAccess.LoadMunice();
			return munice;


		}

		public static void AddMunice(Munice munice)
		{
			SqliteDataAccess.SaveMunice(munice);
		}

		public static void EditMunice(Munice munice)
		{
			SqliteDataAccess.UpdateMunice(munice);
		}

		public static void DeleteById(int? id)
		{
			SqliteDataAccess.DeleteMuniceById((int)id);
		}

		public static void DeleteAll()
		{
			SqliteDataAccess.DeleteAllMunice();
		}

		public static Munice GetById(int id)
		{
			foreach (Munice munice in munice)
			{
				if (munice.Id == id) return munice;
			}

			return null;
		}
	}
}
