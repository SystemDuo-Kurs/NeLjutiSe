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

namespace NeLjutiSe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int broj = 1;
        List<Button> polja = new();
        public MainWindow()
        {
            InitializeComponent();

            polja.Add(p1);
            polja.Add(p2);
            polja.Add(p3);
            polja.Add(p4);
            polja.Add(p5);
            polja.Add(p6);
            polja.Add(p7);
            polja.Add(p8);
            polja.Add(p9);
            polja.Add(p10);
            polja.Add(p11);
            polja.Add(p12);
            polja.Add(p13);
            polja.Add(p14);
            polja.Add(p15);
            polja.Add(p16);

            polja[0].Background = Brushes.Green;

        }

        private void BaciKocku(object sender, RoutedEventArgs e)
        {
            Random r = new();
            //MessageBox.Show(polja[0].Background.ToString());
            polja[broj-1].Background = Brushes.LightGray;

            int kockica = r.Next(1, 7);
            broj += kockica;
            if (broj > 16)
                broj -= 16;
            polja[broj - 1].Background = Brushes.Green;
            Broj.Content = kockica;
        }
    }
}
