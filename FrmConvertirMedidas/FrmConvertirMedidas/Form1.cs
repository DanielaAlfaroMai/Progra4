using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConvertirMedidas
{
    public partial class FrmConvertirMedidas : Form
    {
        public FrmConvertirMedidas()
        {
            InitializeComponent();
        }

        private void btnConvertirPulgadasEnCentimetros_Click(object sender, EventArgs e)
        {
            Procesos proced = new Procesos();
            txtNumeroCentimetros.Text = proced.PulgadasaCentimetros(txtNumeroPulgadas.Text);
        }

        private void btnConvertirCentimetrosEnPulgadas_Click(object sender, EventArgs e)
        {
            Procesos proced = new Procesos();
            txtNumeroPulgadas.Text = proced.CentimetrosaPulgadas(txtNumeroCentimetros.Text);

        }

      
    }
}
