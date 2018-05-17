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
        }

        #endregion
    }
}
