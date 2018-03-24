using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaderaDeEratostenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MetodoDeColadera mtc;

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            mtc = new MetodoDeColadera(100);

            mtc.inicializarArreglo();
            mtc.buscarMultiplos();
            
            textBox1.Text += mtc.mostrar().ToString();
        }



       
    }
}
