using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConvertirMedidas
{
    class Procesos
    {
        public void PulgadasaCentimetros(TextBox txtNumeroPulgadas,TextBox txtNumeroCentimetros)
        {
            double pulgadas = Convert.ToDouble(txtNumeroPulgadas.Text);
            double resp = pulgadas * 2.54;
            txtNumeroCentimetros.Text = resp.ToString();
        }
        public void CentimetrosaPulgadas(TextBox txtNumeroPulgadas, TextBox txtNumeroCentimetros)
        {
            double centimetros = Convert.ToDouble(txtNumeroCentimetros.Text);
            double resp = centimetros / 2.54;
            txtNumeroPulgadas.Text = resp.ToString();

        }

    }
}
