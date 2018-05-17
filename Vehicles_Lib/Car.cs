using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Lib
{
    class Car
    {
        #region Globale variabelen
        enum ColorCars {Groen, Rood,Geel,Zwart} // Definiëren Enumeratie

        ColorCars colorCar; // Aanmaken globale variabele van type ColorCars
        int actualSpeed;   // Aanmaken globale variabele van het type int

        #endregion

        #region Methoden
        // Aanmaken van klassemethode KmNaarMijl (ontvangt 1 Parameter)

        double KmNaarMijl(int speed)
        {
            return speed / 1.609344;
        }
        #endregion

    }
}
