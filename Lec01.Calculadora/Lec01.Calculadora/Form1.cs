using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lec01.Calculadora
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }


        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Procedimientos proced = new Procedimientos();
            txtResult.Text=proced.RealizarOperacion(txtNum1.Text,txtNum2.Text,cmbOperaciones.Text) ;
                
        }

        }

    }

