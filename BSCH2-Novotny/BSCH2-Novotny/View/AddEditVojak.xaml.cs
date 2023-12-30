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
	/// Interakční logika pro AddEditVojak.xaml
	/// </summary>
	public partial class AddEditVojak : Window
	{
		public AddEditVojak()
		{

			InitializeComponent();
			AddEditVojakModel addEditVojakModel = new AddEditVojakModel(Btn_OK, this);
			this.DataContext = addEditVojakModel;
		}

		public AddEditVojak(Vojak vojak)
		{
			InitializeComponent();
			AddEditVojakModel addEditVojakModel = new AddEditVojakModel(vojak, Btn_OK, this);
			this.DataContext = addEditVojakModel;
		}


	}
}
