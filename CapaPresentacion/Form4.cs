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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        EmpresaDistribuidora empresaDistribuidora = new EmpresaDistribuidora();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            // leer las propiedades del objeto
            string nombres = empresaDistribuidora.Nombres;
            string telefono = empresaDistribuidora.Telefono;
            string ubicacion = empresaDistribuidora.Ubicacion;
            string mediosDistribucion = empresaDistribuidora.MediosDistribucion;
            string horarioAtencion = empresaDistribuidora.HorarioAtencion;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos de la Empresa Distribuidora:  " + "\n" + "\n" + "Nombres:  " + nombres + "\n" +
                "Telefono:  " + telefono + "\n" + "Ubicacion:  " + ubicacion + "\n" + "Medios de Distribucion:  " +
                mediosDistribucion + "\n" + "Horario de Atencion:  " + horarioAtencion);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empresaDistribuidora.Entregar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empresaDistribuidora.Almacenar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empresaDistribuidora.Transportar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empresaDistribuidora.ResgistrarEnvio());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empresaDistribuidora.RegistrarEntrega());
        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
