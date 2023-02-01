using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace _20230201
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush (Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            txtRed.Content = Convert.ToByte(sliPiros.Value);
            txtGreen.Content = Convert.ToByte(sliZold.Value);
            txtBlue.Content = Convert.ToByte(sliKek.Value);
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.SelectedIndex > -1)
                lbSzinek.Items.RemoveAt(lbSzinek.SelectedIndex);
            else
                MessageBox.Show("Nincs kiválasztott elem a listából!");
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            if (!lbSzinek.Items.Contains($"{Convert.ToByte(sliPiros.Value)};{Convert.ToByte(sliZold.Value)};{Convert.ToByte(sliKek.Value)}"))
                lbSzinek.Items.Add($"{Convert.ToByte(sliPiros.Value)};{Convert.ToByte(sliZold.Value)};{Convert.ToByte(sliKek.Value)};");
            else
                MessageBox.Show("Ez az elem már fel lett véve!");
        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }

        private void lbSzinek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string[] tagok = lbSzinek.SelectedItem.ToString().Split(';');
            sliPiros.Value = Convert.ToByte(tagok[0]);
            sliZold.Value = Convert.ToByte(tagok[1]);
            sliKek.Value = Convert.ToByte(tagok[2]);
        }
    }
}
