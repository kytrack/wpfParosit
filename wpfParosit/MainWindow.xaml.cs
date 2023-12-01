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

namespace wpfParosit
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

        private void txtelso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return && txtelso.Text != "")
            {
               lbelso.Items.Add(txtelso.Text);
               txtelso.Clear();
            }
        }

        private void txtmasodik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return && txtmasodik.Text!="")
            {
                lbmasodik.Items.Add(txtmasodik.Text);
                txtmasodik.Clear();
            }
        }

        private void btnmix_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int kevesebbSzama = lbelso.Items.Count>=lbmasodik.Items.Count? lbmasodik.Items.Count : lbelso.Items.Count;

            for (int i = 0; i < kevesebbSzama; i++)
            {
                int elso = random.Next(lbelso.Items.Count 1);
                int masodik = random.Next(lbmasodik.Items.Count-1);
                lbmixelt.Items.Add(lbelso.Items.GetItemAt(elso) + " + " + (lbmasodik.Items.GetItemAt(masodik)));   
                lbelso.Items.RemoveAt(elso);lbmasodik.Items.RemoveAt(masodik); 
            }
        }
    }
}
