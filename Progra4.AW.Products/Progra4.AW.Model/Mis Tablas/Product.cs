using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra4.AW.Model
{
    public partial class Product
    {
        public string SizeInInches {
            get {
               string elResultado = Size;
                if (SizeUnitMeasureCode!=null&& SizeUnitMeasureCode == "CM")
                {
                    float elTamaño = 0;
                    if (float.TryParse(Size, out elTamaño))
                    {
                        elResultado = (elTamaño / (float)2.54).ToString();
                    }
                    
                }
                return elResultado;
            }
        }
    }
}
