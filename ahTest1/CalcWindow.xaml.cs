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

namespace tutorialWorkspace
{
    /// <summary>
    /// Interaction logic for CalcWindow.xaml
    /// </summary>
    public partial class CalcWindow : Window
    {
        public CalcWindow()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(tb_num1.Text) + Int32.Parse(tb_num2.Text);
            tb_result.Text = result.ToString();
        }

        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(tb_num1.Text) - Int32.Parse(tb_num2.Text);
            tb_result.Text = result.ToString();
        }

        private void button_mult_Click(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(tb_num1.Text) * Int32.Parse(tb_num2.Text);
            tb_result.Text = result.ToString();
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            double result = float.Parse(tb_num1.Text) / float.Parse(tb_num2.Text + ".0");
            tb_result.Text = result.ToString("0.00");
        }

        private void button_toMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
