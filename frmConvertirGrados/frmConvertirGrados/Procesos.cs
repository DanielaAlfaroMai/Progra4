using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmConvertirGrados
{
    class Procesos
    {
        public string CelsiusaFahrenheit( string Celcius) {
            double celcius = Convert.ToDouble(Celcius);
            string fahrenheit = CelsiusaFahrenheit(celcius);
            return fahrenheit;
        }
        public string CelsiusaFahrenheit(double celcius)
        {
            double res = (celcius * 9 / 5) + 32;
            string fahremheit = res.ToString();
            return fahremheit;
        }
        public string FahrenheitaCelcius(string txtNumeroFahrenheit)
        {
            double fahrenhiet = Convert.ToDouble(txtNumeroFahrenheit);
            string Celcius = FahrenheitaCelcius(fahrenhiet);
            return Celcius;
        }
        public string FahrenheitaCelcius(double fahrenheit)
        {
            double res = (fahrenheit - 32) * 5 / 9;
            string celcius = res.ToString();
            return celcius;
        }
    }
}
