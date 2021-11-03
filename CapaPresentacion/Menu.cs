using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamara al formulario Proveedor 
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar la formulario Componentes 
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar la formulario Almacen
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void empresaDistribuidoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar la formulario Distribuidora 
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ensambadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar la formulario Ensamblador  
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void jefeDeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar la formulario Jefe de Almacen
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
