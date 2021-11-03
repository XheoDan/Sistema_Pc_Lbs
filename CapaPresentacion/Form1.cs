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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Proveedor1 proveedor1 = new Proveedor1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string nombres = txtNombres.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string horarioAtencion = txtHorarioAtencion.Text.Trim();
            string direccion = txtDirrecion.Text.Trim();
            // Esccribir los datos del docente en el objeto

            proveedor1.Nombres = nombres;
            proveedor1.Telefono = telefono;
            proveedor1.Correo = correo;
            proveedor1.HorarioAtencion = horarioAtencion;
            proveedor1.Direccion = direccion;

            // confirmar que se a escrito en el objeto 
            MessageBox.Show("Se a escrito correctamente el objeto");
            // limpiarlas cajas de texto 
            txtNombres.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtHorarioAtencion.Clear();
            txtDirrecion.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtNombres.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string nombres= proveedor1.Nombres;
            string telefono = proveedor1.Telefono;
            string correo = proveedor1.Correo;
            string horarioAtencio = proveedor1.HorarioAtencion;
            string direccion = proveedor1.Direccion;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos del Proveedor:  " + "\n" + "\n" + "Nombres:  " + nombres + "\n" +
                "Telefono:  " + telefono + "\n" + "Correo:  " + correo + "\n" + "Horario de Atencion:  " +
                horarioAtencio + "\n" + "Direccion:  " + direccion);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(proveedor1.Vender());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proveedor1.Proveer());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proveedor1.Archivar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proveedor1.Cobrar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proveedor1.Enviar());
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDirrecion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorarioAtencion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
