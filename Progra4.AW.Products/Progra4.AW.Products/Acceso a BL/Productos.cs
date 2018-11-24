using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra4.AW.Products.Acceso_a_BL
{
   public class Productos
    {
        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            var elClienteWCF = new SI.Productos.AWProductosClient();
            var elResultado = elClienteWCF.ListarProductosPorColor(elColor);
            elClienteWCF.Close();
            return elResultado;
        }

    }
}
