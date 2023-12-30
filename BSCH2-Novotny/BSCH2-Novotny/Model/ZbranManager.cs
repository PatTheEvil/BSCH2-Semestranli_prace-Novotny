using BSCH2_Novotny.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSCH2_Novotny.Model
{
	class ZbranManager
	{
		public static ObservableCollection<Zbran> zbrane = new ObservableCollection<Zbran>();

		public static ObservableCollection<Zbran> GetZbrane()
		{
			zbrane.Clear();
			zbrane = SqliteDataAccess.LoadZbrane();
			return zbrane;
		}

		public static void AddZbran(Zbran zbran)
		{
			SqliteDataAccess.SaveZbrane(zbran);
		}

		public static void EditZbran(Zbran zbran)
		{
			SqliteDataAccess.UpdateZbrane(zbran);
		}

		public static void DeleteById(int? id)
		{
			SqliteDataAccess.DeleteZbranById((int)id);
		}

		public static void DeleteAll()
		{
			SqliteDataAccess.DeleteAllZbrane();
		}

		public static Zbran GetById(int id)
		{
			foreach (Zbran zbran in zbrane)
			{
				if (zbran.Id == id) return zbran;
			}
			return null;
		}
	}
}
