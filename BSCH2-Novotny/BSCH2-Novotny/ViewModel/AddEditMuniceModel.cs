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
	public class AddEditMuniceModel
	{
		public ICommand AddMuniceCommand { get; set; }
		public ICommand EditMuniceCommand { get; set; }
		public ICommand CloseCommand { get; set; }
		private Window Window { get; set; }

		private int? Id { get; set; }
		public string Raze { get; set; }

		public AddEditMuniceModel(Button btn_OK, Window window)
		{
			Id = null;

			AddMuniceCommand = new RelayCommand(AddMunice, CanAddMunice);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = AddMuniceCommand;

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



		private bool CanAddMunice(object arg)
		{
			return true;
		}

		private void AddMunice(object obj)
		{
			MuniceManager.AddMunice(new Munice() { Id = Id, Raze = Raze });
			Window.Close();
		}



		public AddEditMuniceModel(Munice munice, Button btn_OK, Window window)
		{
			Id = munice.Id;
			Raze = munice.Raze;

			EditMuniceCommand = new RelayCommand(EditMunice, CanEditMunice);
			CloseCommand = new RelayCommand(Close, CanClose);

			btn_OK.Command = EditMuniceCommand;

			Window = window;
		}

		private bool CanEditMunice(object arg)
		{
			return true;
		}

		private void EditMunice(object obj)
		{
			MuniceManager.EditMunice(new Munice() { Id = Id, Raze = Raze });
			Window.Close();
		}
	}
}
