using System;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void btnOsszeadas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                lbEredmeny.Content = Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text);
            }
            catch (FormatException forma)
            {
                MessageBox.Show(forma.Message);
                if (SzamEllen())
                {
                    return;
                }
            }
        }

        private void btnSzorzas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                lbEredmeny.Content = Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text);
            }
            catch(FormatException forma) 
            {
                MessageBox.Show(forma.Message);
                if (SzamEllen())
                {
                    return;
                }
            }
        }

        private void btnKivonas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbEredmeny.Content = Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text);
            }
            catch (FormatException forma)
            {
                MessageBox.Show(forma.Message);
                if (SzamEllen())
                {
                    return;
                }
            }
        }

        private void btnOsztas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBszam.Text) == 0)
                {
                    MessageBox.Show("A nevező nem lehet 0");
                }
                else
                {
                    lbEredmeny.Content = Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text);
                }
            }
            catch (FormatException forma)
            {
                MessageBox.Show(forma.Message);
                if (SzamEllen())
                {
                    return;
                }
            }
        }
        private bool SzamEllen()
        {
            bool a = double.TryParse(txtAszam.Text, out _);
            bool b = double.TryParse(txtBszam.Text, out _);
            if (!a)
            {
                txtAszam.Text = "";
                txtAszam.Focus();
            }
            if (!b)
            {
                txtBszam.Text = "";
                txtBszam.Focus();
            }
            return a && b;
        }
    }
}