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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Ensamblador ensamblador = new Ensamblador();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string sOInstalar = txtSistemaOperativo.Text.Trim();
            string versionSO = txtVersionSO.Text.Trim();
            // Esccribir los datos del docente en el objeto

            ensamblador.Nombres = nombres;
            ensamblador.Apellidos = apellidos;
            ensamblador.Telefono = telefono;
            ensamblador.SOInstalar = sOInstalar;
            ensamblador.VersionSO = versionSO;

            // confirmar que se a escrito en el objeto 
            MessageBox.Show("Se a escrito correctamente el objeto");
            // limpiarlas cajas de texto 
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtSistemaOperativo.Clear();
            txtVersionSO.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string nombres = ensamblador.Nombres;
            string apellido = ensamblador.Apellidos;
            string telefono = ensamblador.Telefono;
            string sOInstalar = ensamblador.SOInstalar;
            string VersionSO = ensamblador.VersionSO;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos del Ensamblador :  " + "\n" + "\n" + "Nombre:  " + nombres + "\n" +
                "Apellidos:  " + apellido + "\n" + "Telefono:  " + telefono + "\n" + "SOInstalar:  " +
                sOInstalar + "\n" + "VersionSO:  " + VersionSO);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Trabajar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Colaborar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Gestionar());

        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Ensamblar());

        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Verificar());

        }
    }
}
