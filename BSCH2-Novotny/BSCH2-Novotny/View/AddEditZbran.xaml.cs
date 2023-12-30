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
	/// Interakční logika pro AddEditZbran.xaml
	/// </summary>
	public partial class AddEditZbran : Window
	{
		public AddEditZbran()
		{
			InitializeComponent();
			AddEditZbranModel addEditZbranModel = new AddEditZbranModel(Btn_OK, this, Cb_vojak, Cb_typ, Cb_munice);
			this.DataContext = addEditZbranModel;
		}

		public AddEditZbran(Zbran zbran)
		{
			InitializeComponent();
			AddEditZbranModel addEditZbranModel = new AddEditZbranModel(zbran, Btn_OK, this, Cb_vojak, Cb_typ, Cb_munice);
			this.DataContext = addEditZbranModel;
		}
	}
}
