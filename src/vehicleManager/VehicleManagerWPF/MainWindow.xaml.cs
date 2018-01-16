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
using VehicleLibrary;

namespace VehicleManagerWPF
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

        private void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle auto = new Vehicle();
            auto.Year = int.Parse(YearTextBox.Text);
            auto.Make = MakeTextBox.Text;
            auto.Model = ModelTextBox.Text;

            OutputTextBlock.Text = auto.getVehicle();
        }
    }
}
