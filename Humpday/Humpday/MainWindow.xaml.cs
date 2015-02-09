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

namespace Humpday
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Gives an awesome date of today
            DateTime date = DateTime.Today;

            if (date.DayOfWeek.ToString() == "Wednesday")
            {
                humpdayLabel.Content = "Darn strait it is!!";
            }
            else
            {
                humpdayLabel.Content = "Obviously not";
            }
        }
    }
}
