using BSCH2_Novotny.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BSCH2_Novotny.ViewModel
{
	public class AddEditVojakModel
	{
		public ICommand AddVojakCommand { get; set; }
		public ICommand EditVojakCommand { get; set; }
		public ICommand CloseCommand { get; set; }
		private Window Window { get; set; }

		private int? Id { get; set; }
		public string Jmeno { get; set; }
		public string Prijmeni { get; set; }
		public DateTime Narozeni { get; set; }

		public AddEditVojakModel(Button btn_OK, Window window)
		{
			Id = null;

			AddVojakCommand = new RelayCommand(AddVojak, CanAddVojak);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = AddVojakCommand;

			Window = window;
		}

		private bool CanClose(object arg)
		{
			return true;
		}

		private void Close(object obj)
		{
			Window.Close();
		}



		private bool CanAddVojak(object arg)
		{
			return true;
		}

		private void AddVojak(object obj)
		{
			VojakManager.AddVojak(new Vojak() { Id = Id, Jmeno = Jmeno, Prijmeni = Prijmeni, Narozeni = DateOnly.FromDateTime(Narozeni) });
			Window.Close();
		}



		public AddEditVojakModel(Vojak vojak, Button btn_OK, Window window)
		{
			Id = vojak.Id;
			Jmeno = vojak.Jmeno;
			Prijmeni = vojak.Prijmeni;
			Narozeni = vojak.Narozeni.ToDateTime(TimeOnly.Parse("00:00 PM"));

			EditVojakCommand = new RelayCommand(EditVojak, CanEditVojak);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = EditVojakCommand;

			Window = window;
		}

		private bool CanEditVojak(object arg)
		{
			return true;
		}

		private void EditVojak(object obj)
		{
			VojakManager.EditVojak(new Vojak() { Id = Id, Jmeno = Jmeno, Prijmeni = Prijmeni, Narozeni = DateOnly.FromDateTime(Narozeni) });
			Window.Close();
		}




	}
}
