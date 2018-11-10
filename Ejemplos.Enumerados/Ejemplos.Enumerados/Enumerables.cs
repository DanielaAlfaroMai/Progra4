using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos.Enumerados
{
    public partial class Enumerables : Form
    {
        IList<string> MiLista = new List<string>()
        { "hello", "word", "to", "everybody" };
        IDictionary<int, string> enumerado = new Dictionary<int, string>();
        HashSet<string> hash = new HashSet<string>();
        LinkedList<string> enlazada = new LinkedList<string>();
        string[] vector = new string[5];
       // int tvector = 5;
        int Contador=0;
        public Enumerables()
        {
            InitializeComponent();
        }

        private void Enumerables_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (chbAgregafinal.Checked) {
                enlazada.AddLast(txtAgrega.Text);
            }
            else
            {
                enlazada.AddFirst(txtAgrega.Text);
            }
            MiLista.Add(txtAgrega.Text);
            //enumerado.Add(0,txtAgrega.Text);
            hash.Add(txtAgrega.Text);
            try{
                vector[Contador] = txtAgrega.Text;
               
            }catch (IndexOutOfRangeException) { }
              Contador++;
            txtAgrega.Text = string.Empty;
        }

        private void btnRefresca_Click(object sender, EventArgs e)
        {
            cmbSalida.Items.Clear();
            foreach (var item in MiLista) {
                cmbSalida.Items.Add(item);
            }
        }

        private void btnRFLE_Click(object sender, EventArgs e)
        {
            cmbSalida.Items.Clear();
            foreach (var item in enlazada)
            {
                cmbSalida.Items.Add(item);
            }
        }
    }
}
