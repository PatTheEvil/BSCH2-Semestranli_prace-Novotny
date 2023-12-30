using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BSCH2_Novotny.Model;
using System.Data;
using System.Data.SQLite;

namespace BSCH2_Novotny.Database
{
	public class SqliteDataAccess
	{
		public static ObservableCollection<Vojak> vojaci = new ObservableCollection<Vojak>();
		public static ObservableCollection<Typ_zbrane> typy = new ObservableCollection<Typ_zbrane>();
		public static ObservableCollection<Munice> munice = new ObservableCollection<Munice>();
		public static ObservableCollection<Zbran> zbrane = new ObservableCollection<Zbran>();
		public static ObservableCollection<Vojak> LoadVojaci()
		{

			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro načtení dat z databáze pro tabulku 'Vojaci'
				string query = "SELECT * FROM Vojaci";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							// Načtení dat z řádku výsledků dotazu a vytvoření instance Vojak
							Vojak vojak = new Vojak
							{
								Id = Convert.ToInt32(reader["Id"]),
								Jmeno = reader["Jmeno"].ToString(),
								Prijmeni = reader["Prijmeni"].ToString(),
								Narozeni = DateOnly.Parse(reader["Narozeni"].ToString())

							};

							vojaci.Add(vojak); // Přidání načtených dat do kolekce
						}
					}
				}

				connection.Close();
				return vojaci;
			}
		}

		public static void SaveVojak(Vojak newVojak)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro vložení nového vojáka do databáze
				string query = "INSERT INTO Vojaci (Jmeno, Prijmeni, Narozeni) VALUES (@Jmeno, @Prijmeni, @Narozeni)";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Jmeno", newVojak.Jmeno);
					command.Parameters.AddWithValue("@Prijmeni", newVojak.Prijmeni);
					command.Parameters.AddWithValue("@Narozeni", newVojak.Narozeni);

					command.ExecuteNonQuery(); // Provedení dotazu pro vložení dat do databáze
				}

				connection.Close();
			}

		}

		public static void UpdateVojak(Vojak vojak)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "UPDATE Vojaci SET Jmeno = @Jmeno, Prijmeni = @Prijmeni, Narozeni = @Narozeni WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Jmeno", vojak.Jmeno);
					command.Parameters.AddWithValue("@Prijmeni", vojak.Prijmeni);
					command.Parameters.AddWithValue("@Narozeni", vojak.Narozeni);
					command.Parameters.AddWithValue("@Id", vojak.Id);

					command.ExecuteNonQuery(); // Provedení dotazu pro aktualizaci dat v databázi
				}

				connection.Close();
			}
		}

		public static void DeleteVojakById(int id)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Vojaci WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					command.ExecuteNonQuery(); // Provedení dotazu pro smazání záznamu z databáze
				}

				connection.Close();
			}
		}

		public static void DeleteAllVojaci()
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Vojaci";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.ExecuteNonQuery(); // Provedení dotazu pro smazání všech záznamů z tabulky
				}

				connection.Close();
			}
		}




		public static ObservableCollection<Typ_zbrane> LoadTypy()
		{

			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro načtení dat z databáze pro tabulku 'Typy_zbrani'
				string query = "SELECT * FROM Typy_zbrani";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							// Načtení dat z řádku výsledků dotazu a vytvoření instance Typu_zbrane
							Typ_zbrane typ = new Typ_zbrane
							{
								Id = Convert.ToInt32(reader["Id"]),
								Typ = reader["Typ"].ToString(),

							};

							typy.Add(typ); // Přidání načtených dat do kolekce
						}
					}
				}

				connection.Close();
				return typy;
			}
		}

		public static void SaveTyp(Typ_zbrane typ)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro vložení nového typu_zbrane do databáze
				string query = "INSERT INTO Typy_zbrani (Typ) VALUES (@Typ)";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Typ", typ.Typ);

					command.ExecuteNonQuery(); // Provedení dotazu pro vložení dat do databáze
				}

				connection.Close();
			}

		}

		public static void UpdateTyp(Typ_zbrane typ)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "UPDATE Typy_zbrani SET Typ = @Typ WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Typ", typ.Typ);
					command.Parameters.AddWithValue("@Id", typ.Id);

					command.ExecuteNonQuery(); // Provedení dotazu pro aktualizaci dat v databázi
				}

				connection.Close();
			}
		}

		public static void DeleteTypById(int id)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Typy_zbrani WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					command.ExecuteNonQuery(); // Provedení dotazu pro smazání záznamu z databáze
				}

				connection.Close();
			}
		}

		public static void DeleteAllTypy()
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Typy_zbrani";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.ExecuteNonQuery(); // Provedení dotazu pro smazání všech záznamů z tabulky
				}

				connection.Close();
			}
		}




		public static ObservableCollection<Munice> LoadMunice()
		{

			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro načtení dat z databáze pro tabulku 'Munice'
				string query = "SELECT * FROM Munice";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							// Načtení dat z řádku výsledků dotazu a vytvoření instance Munice
							Munice newMunice = new Munice
							{
								Id = Convert.ToInt32(reader["Id"]),
								Raze = reader["Raze"].ToString(),

							};

							munice.Add(newMunice); // Přidání načtených dat do kolekce
						}
					}
				}

				connection.Close();
				return munice;
			}
		}

		public static void SaveMunice(Munice munice)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro vložení nové munice do databáze
				string query = "INSERT INTO Munice (Raze) VALUES (@Raze)";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Raze", munice.Raze);

					command.ExecuteNonQuery(); // Provedení dotazu pro vložení dat do databáze
				}

				connection.Close();
			}

		}

		public static void UpdateMunice(Munice munice)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "UPDATE Munice SET Raze = @Raze WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Raze", munice.Raze);
					command.Parameters.AddWithValue("@Id", munice.Id);

					command.ExecuteNonQuery(); // Provedení dotazu pro aktualizaci dat v databázi
				}

				connection.Close();
			}
		}

		public static void DeleteMuniceById(int id)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Munice WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					command.ExecuteNonQuery(); // Provedení dotazu pro smazání záznamu z databáze
				}

				connection.Close();
			}
		}

		public static void DeleteAllMunice()
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Munice";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.ExecuteNonQuery(); // Provedení dotazu pro smazání všech záznamů z tabulky
				}

				connection.Close();
			}
		}




		public static ObservableCollection<Zbran> LoadZbrane()
		{
			ObservableCollection<Zbran> zbrane = new ObservableCollection<Zbran>();

			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "SELECT Z.Id AS ZbranId, Z.Nazev AS NazevZbrane, Z.Id_vojaka AS VojakId, V.Jmeno AS Jmeno, V.Prijmeni AS Prijmeni, V.Narozeni AS Narozeni, T.Id AS TypId, T.Typ as Typ, M.Id AS MuniceId, M.Raze AS RazeMunice " +
								"FROM Zbrane Z " +
								"INNER JOIN Vojaci V ON Z.Id_vojaka = V.Id " +
								"INNER JOIN Typy_zbrani T ON Z.Id_typu = T.Id " +
								"INNER JOIN Munice M ON Z.Id_munice = M.Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Vojak vojak = new Vojak
							{
								Id = Convert.ToInt32(reader["VojakId"]),
								Jmeno = reader["Jmeno"].ToString(),
								Prijmeni = reader["Prijmeni"].ToString(),
								Narozeni = DateOnly.Parse(reader["Narozeni"].ToString())
							};

							Typ_zbrane typ = new Typ_zbrane
							{
								Id = Convert.ToInt32(reader["TypId"]),
								Typ = reader["Typ"].ToString()
							};

							Munice munice = new Munice
							{
								Id = Convert.ToInt32(reader["MuniceId"]),
								Raze = reader["RazeMunice"].ToString()
							};

							Zbran zbran = new Zbran
							{
								Id = Convert.ToInt32(reader["ZbranId"]),
								Nazev = reader["NazevZbrane"].ToString(),
								Vojak = vojak,
								Typ = typ,
								Munice = munice
							};

							zbrane.Add(zbran);
						}
					}
				}

				connection.Close();
			}

			return zbrane;
		}

		public static void SaveZbrane(Zbran zbran)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				// Zde vytvořte SQL dotaz pro vložení nové munice do databáze
				string query = "INSERT INTO Zbrane (Nazev, Id_vojaka, Id_typu, Id_munice) VALUES (@Nazev, @Id_vojaka, @Id_typu, @Id_munice)";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nazev", zbran.Nazev);
					command.Parameters.AddWithValue("@Id_vojaka", zbran.Vojak.Id);
					command.Parameters.AddWithValue("@Id_typu", zbran.Typ.Id);
					command.Parameters.AddWithValue("@Id_munice", zbran.Munice.Id);


					command.ExecuteNonQuery(); // Provedení dotazu pro vložení dat do databáze
				}

				connection.Close();
			}

		}

		public static void UpdateZbrane(Zbran zbran)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "UPDATE Zbrane SET Nazev = @Nazev, Id_vojaka = @Id_vojaka, Id_typu = @Id_typu, Id_munice = @Id_munice WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nazev", zbran.Nazev);
					command.Parameters.AddWithValue("@Id_vojaka", zbran.Vojak.Id);
					command.Parameters.AddWithValue("@Id_typu", zbran.Typ.Id);
					command.Parameters.AddWithValue("@Id_munice", zbran.Munice.Id);
					command.Parameters.AddWithValue("@Id", zbran.Id);

					command.ExecuteNonQuery(); // Provedení dotazu pro aktualizaci dat v databázi
				}

				connection.Close();
			}
		}

		public static void DeleteZbranById(int id)
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Zbrane WHERE Id = @Id";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					command.ExecuteNonQuery(); // Provedení dotazu pro smazání záznamu z databáze
				}

				connection.Close();
			}
		}

		public static void DeleteAllZbrane()
		{
			using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=./Databaze.db;"))
			{
				connection.Open();

				string query = "DELETE FROM Zbrane";

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.ExecuteNonQuery(); // Provedení dotazu pro smazání všech záznamů z tabulky
				}

				connection.Close();
			}
		}
	}
}
