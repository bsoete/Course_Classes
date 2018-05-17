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
using Vehicles_Lib;

namespace WpfKlassen
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

        #region Globale Variabelen


        #endregion

        #region Methoden



        #endregion

        #region EventHandlers


        private void btnObjecten_Click(object sender, RoutedEventArgs e)
        {
            Car auto; // Car-variabele declareren
            auto = new Car();  // Car-variabele initialiseren => auto wordt een object van het type Car

            auto.actualSpeed = 120;
            auto.colorCar = Car.ColorCars.Rood;
            double snelheidInMijl = auto.KmNaarMijl(auto.actualSpeed);
            MessageBox.Show($"Deze auto rijdt {auto.actualSpeed} km/uur en heeft als kleur {auto.colorCar}. \nIn de USA is deze snelheid {snelheidInMijl} Mijl/h","AutoGegevens");

            Car auto2 = new Car();
            auto2.actualSpeed = 50;

            MessageBox.Show($"Deze 2de auto rijdt {auto2.actualSpeed} km/uur en heeft als kleur {auto2.colorCar}. \nIn de USA is deze snelheid {auto2.KmNaarMijl(auto2.actualSpeed)} Mijl/h", "AutoGegevens");


            Car auto3 = new Car(200);
            MessageBox.Show($"Deze 3de auto rijdt {auto3.actualSpeed} km/uur en heeft als kleur {auto3.colorCar}. \nIn de USA is deze snelheid {auto3.KmNaarMijl(auto3.actualSpeed)} Mijl/h", "AutoGegevens");

            Car auto4 = new Car(Car.ColorCars.Zwart, 150);
            MessageBox.Show($"Deze 4de auto rijdt {auto4.actualSpeed} km/uur en heeft als kleur {auto4.colorCar}. \nIn de USA is deze snelheid {auto4.KmNaarMijl(auto4.actualSpeed)} Mijl/h", "AutoGegevens");
        }

        #endregion
    }
}
