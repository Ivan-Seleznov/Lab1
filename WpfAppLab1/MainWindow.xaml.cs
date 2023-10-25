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

namespace WpfAppLab1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var length = Convert.ToDouble(LengthTextBox.Text);
                var width = Convert.ToDouble(WidthTextBox.Text);

                Rectangle Rectangle = new Rectangle(length, width);

                PerimeterText.Content = Rectangle.CalculatePerimeter();
                AreaText.Content = Rectangle.CalculateArea();
            } 
            catch
            {
                MessageBox.Show("Введено невірні дані.");
            }
        }
    }
}
