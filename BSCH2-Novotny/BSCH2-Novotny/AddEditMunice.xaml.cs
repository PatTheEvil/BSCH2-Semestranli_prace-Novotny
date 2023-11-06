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
        }

        private void Btn_ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Btn_storno_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
