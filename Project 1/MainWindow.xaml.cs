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

namespace Project_1
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

        private void OnClick(object sender, RoutedEventArgs e)
        {
            double weight = Convert.ToDouble(WeightBox.Text);
            double height = Convert.ToDouble(HeightBox.Text);

            double bmi = (weight * 720) / (height * height);

            if (bmi > 26)
            {
                BMIButton.Background = Brushes.Yellow;
            } else if (bmi >= 15 && bmi <= 26)
            {
                BMIButton.Background = Brushes.Green;
            } else if (bmi < 15)
            {
                BMIButton.Background = Brushes.Blue;
            }
        }
    }
}
