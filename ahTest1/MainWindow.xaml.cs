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

namespace tutorialWorkspace
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

        private void button_toCalc_Click(object sender, RoutedEventArgs e)
        {
            CalcWindow calcWin = new CalcWindow();
            calcWin.Show();
            this.Close();
        }

        private void button_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
