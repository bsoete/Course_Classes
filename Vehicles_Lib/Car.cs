using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Lib
{
    public class Car
    {
        #region Globale variabelen
        public enum ColorCars {Groen, Rood,Geel,Zwart} // Definiëren Enumeratie

        public ColorCars colorCar; // Aanmaken globale variabele van type ColorCars
        public int actualSpeed;   // Aanmaken globale variabele van het type int

        #endregion

        #region Constructor(s)
        public Car() // Standaard Parameterloze Constructor
        {
            actualSpeed = 0;
            colorCar = ColorCars.Groen; 
        }

        #endregion

        #region Methoden
        // Aanmaken van klassemethode KmNaarMijl (ontvangt 1 Parameter)

        public double KmNaarMijl(int speed)
        {
            return speed / 1.609344;
        }
        #endregion

    }
}
