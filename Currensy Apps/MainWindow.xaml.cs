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

namespace Currensy_Apps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrensyController currensy;
        public MainWindow()
        {
            InitializeComponent();
            currensy = new CurrensyController();
        }

        private void Button_Hitung_Click(object sender, RoutedEventArgs e)
        {
            var nominalInput = InputTextBox.Text;
            var result = "invalid";
            if (currensy.isAllowed(nominalInput))
            {
                result = currensy.usdToIdr(nominalInput);
            }
            resultLabel.Content = result;

        }
    }
}
