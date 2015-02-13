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

namespace Humpday
{
    /// <summary>
    /// Interaction logic for Time.xaml
    /// </summary>
    public partial class Time : Window
    {
        private DateTime today;
        private DateTime humpday = DateTime.Today;


        public Time()
        {
            InitializeComponent();

            //set the date to today
            today = DateTime.Today;
            //how to set the date to Humpday
            int daysUntilHumpday = ((int) DayOfWeek.Wednesday - (int) today.DayOfWeek + 7) % 7;
            humpday.AddDays(daysUntilHumpday);

            //Starts the thread to update the frame
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0,0,1);
            dispatcherTimer.Start();
        }

        //The code that is updated each second
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            second.Content = humpday.DayOfWeek;
        }

        private double getSeconds()
        {
            
            
            return (double) 0;

        }
    }
}
