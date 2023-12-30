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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BSCH2_Novotny
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainViewModel ViewModel { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			ViewModel = new MainViewModel(Lv, Gv, Cb_typ, Cb_munice);
			this.DataContext = ViewModel;
		}

		private void Window_ContentRendered(object sender, EventArgs e)
		{
			MinWidth = 1000;
			MinHeight = 742;
		}
	}
}
