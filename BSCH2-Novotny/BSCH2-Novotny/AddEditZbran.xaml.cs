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
        }

        private void Btn_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Btn_storno_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
