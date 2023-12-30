using BSCH2_Novotny.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BSCH2_Novotny.ViewModel
{
	public class AddEditZbranModel : INotifyPropertyChanged
	{
		public ICommand AddZbranCommand { get; set; }
		public ICommand EditZbranCommand { get; set; }
		public ICommand CloseCommand { get; set; }
		private Window Window { get; set; }

		private int? Id { get; set; }
		public string Nazev { get; set; }
		public ObservableCollection<Vojak> Vojaci { get; set; }
		public ObservableCollection<Typ_zbrane> Typy { get; set; }
		public ObservableCollection<Munice> Munice { get; set; }
		public ComboBox Cb_Vojaci { get; set; }
		public ComboBox Cb_Typy { get; set; }
		public ComboBox Cb_Munice { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public AddEditZbranModel(Button btn_OK, Window window, ComboBox Cb_vojak, ComboBox Cb_typ, ComboBox Cb_munice)
		{
			Id = null;

			AddZbranCommand = new RelayCommand(AddZbran, CanAddZbran);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = AddZbranCommand;

			Window = window;

			Vojaci = new ObservableCollection<Vojak>();
			Typy = new ObservableCollection<Typ_zbrane>();
			Munice = new ObservableCollection<Munice>();
			LoadData();

			Cb_Vojaci = Cb_vojak;
			Cb_Typy = Cb_typ;
			Cb_Munice = Cb_munice;
		}

		private void LoadData()
		{
			foreach (Vojak vojak in VojakManager.GetVojaci())
			{
				Vojaci.Add(vojak);
			}

			foreach (Typ_zbrane typ in TypManager.GetTypy())
			{
				Typy.Add(typ);
			}

			foreach (Munice munice in MuniceManager.GetMunice())
			{
				Munice.Add(munice);
			}


			OnPropertyChanged(nameof(Vojaci));
			OnPropertyChanged(nameof(Typy));
			OnPropertyChanged(nameof(Munice));
		}

		private bool CanClose(object arg)
		{
			return true;
		}

		private void Close(object obj)
		{
			Window.Close();
		}



		private bool CanAddZbran(object arg)
		{
			return true;
		}

		private void AddZbran(object obj)
		{
			Vojak selectedVojak = Cb_Vojaci.SelectedItem as Vojak;
			Typ_zbrane selectedTyp = Cb_Typy.SelectedItem as Typ_zbrane;
			Munice selectedMunice = Cb_Munice.SelectedItem as Munice;
			ZbranManager.AddZbran(new Zbran() { Id = Id, Nazev = Nazev, Vojak = VojakManager.GetById((int)selectedVojak.Id), Typ = TypManager.GetById((int)selectedTyp.Id), Munice = MuniceManager.GetById((int)selectedMunice.Id) });
			Window.Close();
		}



		public AddEditZbranModel(Zbran zbran, Button btn_OK, Window window, ComboBox Cb_vojak, ComboBox Cb_typ, ComboBox Cb_munice)
		{
			Id = zbran.Id;
			Nazev = zbran.Nazev;


			EditZbranCommand = new RelayCommand(EditZbran, CanEditZbran);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = EditZbranCommand;

			Window = window;

			Vojaci = new ObservableCollection<Vojak>();
			Typy = new ObservableCollection<Typ_zbrane>();
			Munice = new ObservableCollection<Munice>();
			LoadData();

			Cb_vojak.ItemsSource = Vojaci;
			// Zde přiřaďte kolekci Typu zbraně do ComboBoxu pro Typy zbraní
			Cb_typ.ItemsSource = Typy;
			// Zde přiřaďte kolekci Munice do ComboBoxu pro Munici
			Cb_munice.ItemsSource = Munice;

			// Nastavení vybraných položek v ComboBoxech
			Cb_vojak.SelectedItem = zbran.Vojak;
			Cb_typ.SelectedItem = zbran.Typ;
			Cb_munice.SelectedItem = zbran.Munice;

			OnPropertyChanged(nameof(Vojaci));
			OnPropertyChanged(nameof(Typy));
			OnPropertyChanged(nameof(Munice));

			Cb_Vojaci = Cb_vojak;
			Cb_Typy = Cb_typ;
			Cb_Munice = Cb_munice;
		}

		private bool CanEditZbran(object arg)
		{
			return true;
		}

		private void EditZbran(object obj)
		{
			Vojak selectedVojak = Cb_Vojaci.SelectedItem as Vojak;
			Typ_zbrane selectedTyp = Cb_Typy.SelectedItem as Typ_zbrane;
			Munice selectedMunice = Cb_Munice.SelectedItem as Munice;
			ZbranManager.EditZbran(new Zbran() { Id = Id, Nazev = Nazev, Vojak = VojakManager.GetById((int)selectedVojak.Id), Typ = TypManager.GetById((int)selectedTyp.Id), Munice = MuniceManager.GetById((int)selectedMunice.Id) });
			Window.Close();
		}
	}
}
