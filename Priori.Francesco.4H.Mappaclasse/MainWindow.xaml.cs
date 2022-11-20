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

namespace Priori.Francesco._4H.Mappaclasse
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

        //Quarta Riga

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco sono presenti:" + "Priori Francesco e Burioli Alessandro");
            btn1.Content = "Priori Francesco" + "\n\r" + "Burioli Alessandro";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Dyrmishi Leo");
            btn2.Content = "Dyrmishi Leo";
        }

        //Terza Riga

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Rossini Agostino");
            btn3.Content = "Rossini Agostino";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco sono presenti: " + "Tumidei Matteo e Cancelieri Andrea");
            btn4.Content = "Tumidei Matteo" + "\n\r" + "Cancelieri Andrea";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Basilico Karol");
            btn5.Content = "Basilico Karol";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Chietti Antonio");
            btn6.Content = "Chietti Antonio";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Dervishi Samuele");
            btn7.Content = "Dervishi Samuele";
        }

        //Seconda Riga

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Ghinelli Johan");
            btn8.Content = "Ghinelli Johan";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Casadei Federico");
            btn9.Content = "Casadei Federico";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Morelli Giovanni");
            btn10.Content = "Morelli Giovanni";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Islamovsky Fathi");
            btn11.Content = "Islamovsky Fathi";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Zang");
            btn12.Content = "Zang";
        }

        //Prima Riga
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Capanna Alessandro");
            btn13.Content = "Capanna Alessandro";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Cau Federico");
            btn14.Content = "Cau Federico";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Lombardi Samuele");
            btn15.Content = "Lombardi Samuele";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Salvi Matteo");
            btn16.Content = "Salvi Matteo";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Paolo Pompa");
            btn17.Content = "Paolo Pompa";
        }

        //Cattedra Prof

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nella Cattedra è presente il: " + "Prof Conti Maurizio");
            btn18.Content = "Conti Maurizio" + "\r\n" + "Sartini Matteo";
        }
    }
}
