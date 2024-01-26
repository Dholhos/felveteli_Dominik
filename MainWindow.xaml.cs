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

namespace WpfApp2
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

        private void txtFiuNev_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ()
            {
                lbFiuk.Items.Add(txtFiuNev);
            }
            else if (txtFiuNev.Text=="")
            {
                MessageBox.Show("Adjon meg egy Fiú Nevet!");
            }
            else if (lbFiuk.Items.Contains(txtFiuNev))
            {
                MessageBox.Show("Ez a név már létezik a listában");
            }

        }

        private void btnMix_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            float fiu = Math.Floor(random(0, lbFiuk.Items.Count()));
            float lany = Math.Floor(random(0, lbFiuk.Items.Count()));


        }
    }
}
