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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_prid_vojaka_Click(object sender, RoutedEventArgs e)
        {
            AddEditVojak addEditVojak = new AddEditVojak();
            bool? result = addEditVojak.ShowDialog();

            if (result == true)
            {
                MessageBox.Show("Your request will be processed.");
            }
            else
            {
                MessageBox.Show("Nekde nastala chyba");
            }

        }

        private void Btn_prid_zbran_Click(object sender, RoutedEventArgs e)
        {
            AddEditZbran addEditZbran = new AddEditZbran();
            bool? result = addEditZbran.ShowDialog();

            if (result == true)
            {
                MessageBox.Show("Your request will be processed.");
            }
            else
            {
                MessageBox.Show("Nekde nastala chyba");
            }
        }

        private void Btn_prid_typ_Click(object sender, RoutedEventArgs e)
        {
            AddEditTyp addEditTyp = new AddEditTyp();
            bool? result = addEditTyp.ShowDialog();

            if (result == true)
            {
                MessageBox.Show("Your request will be processed.");
            }
            else
            {
                MessageBox.Show("Nekde nastala chyba");
            }
        }

        private void Btn_prid_munici_Click(object sender, RoutedEventArgs e)
        {
            AddEditMunice addEditMunice = new AddEditMunice();
            bool? result = addEditMunice.ShowDialog();

            if (result == true)
            {
                MessageBox.Show("Your request will be processed.");
            }
            else
            {
                MessageBox.Show("Nekde nastala chyba");
            }
        }

        private void Btn_zobr_typy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_zobr_vojaky_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_zobr_zbrane_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_zobr_munici_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_uprav_vojaka_Click(object sender, RoutedEventArgs e)
        {
            //if (Lw.SelectedItems.Count > 0)
            //{
            //    int id = int.Parse(Lw.SelectedItems[0].ToString());
            //}
        }

        private void Btn_uprav_zbran_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_uprav_typ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_uprav_munici_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_smaz_vojaka_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_smaz_zbran_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_smaz_typ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_smaz_munici_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_smaz_vse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            MinWidth = 1000;
            MinHeight = 742;
        }
    }
}
