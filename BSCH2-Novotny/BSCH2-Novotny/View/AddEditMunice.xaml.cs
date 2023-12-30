using BSCH2_Novotny.Model;
using BSCH2_Novotny.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BSCH2_Novotny
{
	/// <summary>
	/// Interakční logika pro AddEditMunice.xaml
	/// </summary>
	public partial class AddEditMunice : Window
	{
		public AddEditMunice()
		{
			InitializeComponent();
			AddEditMuniceModel addEditMuniceModel = new AddEditMuniceModel(Btn_ok, this);
			this.DataContext = addEditMuniceModel;
		}

		public AddEditMunice(Munice munice)
		{
			InitializeComponent();
			AddEditMuniceModel addEditMuniceModel = new AddEditMuniceModel(munice, Btn_ok, this);
			this.DataContext = addEditMuniceModel;
		}

	}
}
