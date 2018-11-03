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
        public void CelsiusaFahrenheit(TextBox txtNumeroCelcius, TextBox txtNumeroFahrenheit) {
            double celcius = Convert.ToDouble(txtNumeroCelcius.Text);
            double res = (celcius * 9 / 5) + 32;
            txtNumeroFahrenheit.Text = res.ToString();
        }
        public void FahrenheitaCelcius(TextBox txtNumeroCelcius, TextBox txtNumeroFahrenheit)
        {
            double fahrenhiet = Convert.ToDouble(txtNumeroFahrenheit.Text);
            double res = (fahrenhiet - 32) * 5 / 9;
            txtNumeroCelcius.Text = res.ToString();

        }
    }
}
