using BSCH2_Novotny.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace BSCH2_Novotny.ViewModel
{
	public class AddEditTypModel
	{
		public ICommand AddTypCommand { get; set; }
		public ICommand EditTypCommand { get; set; }
		public ICommand CloseCommand { get; set; }
		private Window Window { get; set; }

		private int? Id { get; set; }
		public string Typ { get; set; }

		public AddEditTypModel(Button btn_OK, Window window)
		{
			Id = null;

			AddTypCommand = new RelayCommand(AddTyp, CanAddTyp);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = AddTypCommand;

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



		private bool CanAddTyp(object arg)
		{
			return true;
		}

		private void AddTyp(object obj)
		{
			TypManager.AddTyp(new Typ_zbrane() { Id = Id, Typ = Typ });
			Window.Close();
		}



		public AddEditTypModel(Typ_zbrane typ, Button btn_OK, Window window)
		{
			Id = typ.Id;
			Typ = typ.Typ;

			EditTypCommand = new RelayCommand(EditTyp, CanEditTyp);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = EditTypCommand;

			Window = window;
		}

		private bool CanEditTyp(object arg)
		{
			return true;
		}

		private void EditTyp(object obj)
		{
			TypManager.EditTyp(new Typ_zbrane() { Id = Id, Typ = Typ });
			Window.Close();
		}
	}
}
