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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Almacen almacen = new Almacen();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtHorarioAtencion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string nombres = txtNombres.Text.Trim();
            string ubicacion = txtUbicacion.Text.Trim();
            string tamanio = txtTamaño.Text.Trim();
            string personalEncaragdo = txtPersonalEncargado.Text.Trim();
            string horarioAtencion = txtHorarioAtencion.Text.Trim();
            // Esccribir los datos del docente en el objeto

            almacen.Nombres = nombres;
            almacen.Ubicacion = ubicacion;
            almacen.Tamanio = tamanio;
            almacen.PersonalEncargado = personalEncaragdo;
            almacen.HorarioAtencion = horarioAtencion;

            // confirmar que se a escrito en el objeto 
            MessageBox.Show("Se a escrito correctamente el objeto");
            // limpiarlas cajas de texto 
            txtNombres.Clear();
            txtUbicacion.Clear();
            txtTamaño.Clear();
            txtPersonalEncargado.Clear();
            txtHorarioAtencion.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string nombres = almacen.Nombres;
            string ubicacion = almacen.Ubicacion;
            string tamanio = almacen.Tamanio;
            string personalEncargado = almacen.PersonalEncargado;
            string HorarioAtencion = almacen.HorarioAtencion;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos de Almacen:  " + "\n" + "\n" + "Nombre:  " + nombres + "\n" +
                "Ubicacion:  " + ubicacion + "\n" + "Tamanio:  " + tamanio + "\n" + "PersonalEncargado:  " +
                personalEncargado + "\n" + "HorarioAtencion:  " + HorarioAtencion);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(almacen.Almacenar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(almacen.ResgistrarProducto());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(almacen.ManternerProducto());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(almacen.Gestionar());

        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(almacen.Custodir());

        }
    }
}
