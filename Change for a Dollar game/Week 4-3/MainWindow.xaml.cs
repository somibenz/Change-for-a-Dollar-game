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

namespace Week_4_3
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

        private void lblButton_Click(object sender, RoutedEventArgs e)
        {


            

            int txtPennies = int.Parse(txtBox.Text) * 1;
            int txtNickels = int.Parse(txtBox1.Text) * 5;
            int txtDimes = int.Parse(txtBox2.Text) * 10;
            int txtQuarter = int.Parse(txtBox3.Text) * 25;
            int total = txtPennies + txtNickels + txtDimes + txtQuarter;


            if (total==100)
            {
                lblOutput.Content = ("you've won");
            }
            else
            {
                MessageBox.Show("amount entered does not equal a dollar");
            }









        }
    }
}

