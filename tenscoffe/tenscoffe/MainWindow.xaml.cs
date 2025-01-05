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
            Flavors_Biil flavors_Biil = new Flavors_Biil(); 
            flavors_Biil.Show();
        }

        private void copper(object sender, RoutedEventArgs e)
        {
            Copper_Bill cen = new Copper_Bill();
            cen.Show();
        }

        private void drinks(object sender, RoutedEventArgs e)
        {
            Drinks_Bill dr = new Drinks_Bill();
            dr.Show();
        }

        private void daily_sales(object sender, RoutedEventArgs e)
        {
            Daily_Salas_Screen dSS = new Daily_Salas_Screen();
            dSS.Show();
        }

        private void monthly_salas(object sender, RoutedEventArgs e)
        {
            Monthly_Salas_Screen mss = new Monthly_Salas_Screen();  
            mss.Show(); 
        }

        private void ben_is_left(object sender, RoutedEventArgs e)
        {
            Ben_Is_Left_Screen bils = new Ben_Is_Left_Screen(); 
            bils.Show();
        }

        private void annual_salas(object sender, RoutedEventArgs e)
        {
            Annual_Salas_Screen ass =   new Annual_Salas_Screen();  
            ass.Show();
        }

        private void flavors_is_left(object sender, RoutedEventArgs e)
        {
            Flavore_Is_Left_Screen fils = new  Flavore_Is_Left_Screen();
            fils.Show();
        }

        private void copper_is_left(object sender, RoutedEventArgs e)
        {
            Copper_Is_Left_Screen cils = new Copper_Is_Left_Screen();
            cils.Show();
        }

        private void expen_1(object sender, RoutedEventArgs e)
        {
            Stor_Specific_Expenses_Screen sses =new Stor_Specific_Expenses_Screen();
            sses.Show();
        }

        private void expen_2(object sender, RoutedEventArgs e)
        {
            Personal_Expenses_Screen pes = new Personal_Expenses_Screen();
            pes.Show();
        }

        private void manage_inventory_coffe_ben(object sender, RoutedEventArgs e)
        {
            MangementBenCoffe mbf = new MangementBenCoffe();
            mbf.Show();
        }

        private void manage_inventory_flavore(object sender, RoutedEventArgs e)
        {
            MangementFlavoers mf =new MangementFlavoers();
            mf.Show();
        }

        private void manage_inventory_coppur(object sender, RoutedEventArgs e)
        {
            MangementCopper mc = new MangementCopper();
            mc.Show();
        }

        private void manage_inventory_drinks(object sender, RoutedEventArgs e)
        {
            MangementDrinks md = new MangementDrinks(); 
            md.Show();
        }
    }
}
