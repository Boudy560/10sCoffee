using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Threading;

namespace tenscoffe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        public MainWindow()
        {
            InitializeComponent();
            
            
            // start code for adding time on screen 
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1) // Update every second
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();

            // Set the initial time
            UpdateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            TimeTextBlock.Text = DateTime.Now.ToString("hh:mm:ss tt"); // Example: "02:45:30 PM"
        }
        // End code for adding time on screen 


        //event for buttons 
        private void besns(object sender, RoutedEventArgs e)
        {
            Bens_Bill ben = new Bens_Bill();
            ben.Show();
        }

        private void flavors(object sender, RoutedEventArgs e)
        {

        }

        private void copper(object sender, RoutedEventArgs e)
        {

        }

        private void drinks(object sender, RoutedEventArgs e)
        {

        }

        private void daily_sales(object sender, RoutedEventArgs e)
        {

        }

        private void monthly_salas(object sender, RoutedEventArgs e)
        {

        }

        private void ben_is_left(object sender, RoutedEventArgs e)
        {

        }

        private void annual_salas(object sender, RoutedEventArgs e)
        {

        }

        private void flavors_is_left(object sender, RoutedEventArgs e)
        {

        }

        private void copper_is_left(object sender, RoutedEventArgs e)
        {

        }

        private void expen_1(object sender, RoutedEventArgs e)
        {

        }

        private void expen_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
