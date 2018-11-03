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
        public string PulgadasaCentimetros(string Pulgadas)
        {
            double pulgadas = Convert.ToDouble(Pulgadas);
            string Centimetros = PulgadasaCentimetros(pulgadas);
            return Centimetros;
        }
        public string PulgadasaCentimetros(double pulgadas)
        {
            double resp = pulgadas * 2.54;
            string res = resp.ToString();
            return res;
        }
        public string CentimetrosaPulgadas(string Centimetros)
        {
            double centimetros = Convert.ToDouble(Centimetros);
            string Pulgadas = CentimetrosaPulgadas(centimetros);
            return Pulgadas;

        }
        public string CentimetrosaPulgadas(double centimetros)
        {
            double resp = centimetros / 2.54;
            string res = resp.ToString();
            return res;
        }



    }
}
