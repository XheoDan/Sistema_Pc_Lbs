using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        JefeAlmacen jefeAlmacen= new JefeAlmacen ();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string almacenesCargo = txtAlmacenesCargo.Text.Trim();
            string ubicacionAlmacen = txtAlmacenesCargo.Text.Trim();
            // Esccribir los datos del docente en el objeto

            jefeAlmacen.Nombres = nombres;
            jefeAlmacen.Apellidos = apellidos;
            jefeAlmacen.Telefono = telefono;
            jefeAlmacen.AlmacenesCargo = almacenesCargo;
            jefeAlmacen.UbicacionAlmacen = ubicacionAlmacen;

            // confirmar que se a escrito en el objeto 
            MessageBox.Show("Se a escrito correctamente el objeto");
            // limpiarlas cajas de texto 
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtAlmacenesCargo.Clear();
            txtUbicacionAlmacen.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string nombres = jefeAlmacen.Nombres;
            string apellido = jefeAlmacen.Apellidos;
            string telefono = jefeAlmacen.Telefono;
            string almacenesCargo = jefeAlmacen.AlmacenesCargo;
            string ubicacionAlmacen = jefeAlmacen.UbicacionAlmacen;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos de Jefe Almacen :  " + "\n" + "\n" + "Nombre:  " + nombres + "\n" +
                "Apellidos:  " + apellido + "\n" + "Telefono:  " + telefono + "\n" + "Almacenes a Cargo:  " +
                almacenesCargo + "\n" + "Ubicacion de Almacen:  " + ubicacionAlmacen);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Trabajar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Colaborar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Gestionar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Administrar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Registrar());
        }
    }
}
