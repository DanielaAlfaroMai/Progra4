using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmConvertirGrados
{
    public partial class FrmConvertirGrados : Form
    {
        public FrmConvertirGrados()
        {
            InitializeComponent();
        }

        private void btnConvertirCelciusEnFahrenheit_Click(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
           txtNumeroFahrenheit.Text=proceso.CelsiusaFahrenheit(txtNumeroCelcius.Text);
        }

        private void btnConvertirFahrenhietEnCelsius_Click(object sender, EventArgs e)
        {
            Procesos proceso = new Procesos();
            txtNumeroCelcius.Text= proceso.FahrenheitaCelcius(txtNumeroFahrenheit.Text);

        }
    }
}
